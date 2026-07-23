using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Hestia.Core
{
    public static partial class Utility
    {        
        public static async Task<T> AttemptAsync<T>(Func<int, CancellationToken?, Task<T>> func, ushort max = 1, CancellationToken? cancellation = null,  Func<int, Exception, bool> @continue = null, Func<int, TimeSpan> delay = null)
        {
            if (func is null) { throw new ArgumentNullException( nameof(func), "方法不能为空"); }
            if (max == 0) { throw new ArgumentOutOfRangeException(nameof(max), "最大尝试次数需要大于零"); }
            Trace.WriteLineIf(max > 9, $"最大尝试次数过大(max: {max})");

            int attempt = 0;
            var exceptions = new List<Exception>(max);
            while (true)
            {
                cancellation?.ThrowIfCancellationRequested();
                try
                {
                    return await func(attempt, cancellation);
                }
                catch (OperationCanceledException) { throw; }
                catch (Exception ex) when (attempt < max - 1 && (@continue?.Invoke(attempt, ex) ?? true))
                {
                    exceptions.Add(ex);
                    attempt += 1;
                    if (delay is null) { continue; }
                    var timeout = delay.Invoke(attempt);
                    Trace.WriteLineIf(timeout.Ticks <= 0 || timeout.Ticks > 90 * TimeSpan.TicksPerSecond, $"重试延迟不合理(attempt: {attempt}; timeout: {timeout.TotalMilliseconds} ms)");
                    if(timeout.Ticks > 0) { await (cancellation is null ? Task.Delay(timeout) : Task.Delay(timeout, cancellation.Value)); }
                }
                catch (Exception ex)
                {
                    exceptions.Add(ex);
                    throw new AggregateException($"最终尝试异常(attempt: {attempt})",exceptions);
                }
            }
        }
    }
}
