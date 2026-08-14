using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Hestia.Core.Cache
{
    public abstract class Store<T, R>(TimeSpan timeout) : IReadOnlyCollection<T>
    {
        protected volatile T[] store = null;
        private readonly SemaphoreSlim @lock = new(1, 1);
        protected TimeSpan Timeout { get; } = timeout;

        public DateTimeOffset UpdateUtc { get; protected set; } = DateTimeOffset.MinValue;

        #region IReadOnlyCollection
        public int Count => store.Length;

        public IEnumerator<T> GetEnumerator() => (store as IEnumerable<T>).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => store.GetEnumerator();
        #endregion

        protected abstract Task LoadAsync(bool reload);

        public R RawData { get; protected set; }

        public async Task RefreshAsync(bool reload = false)
        {
            if (!reload && DateTimeOffset.UtcNow.Ticks - UpdateUtc.Ticks <= Timeout.Ticks) { return; }
            await @lock.WaitAsync();
            if (!reload && DateTimeOffset.UtcNow.Ticks - UpdateUtc.Ticks <= Timeout.Ticks) { return; }
            try
            {
                await LoadAsync(reload);
            }
            finally
            {
                @lock.Release();
            }
        }
    }
}
