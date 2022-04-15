using Castle.DynamicProxy;
using System.Diagnostics;

namespace Homework2.AspectOrianted.Models
{
    public class PerformanceAspectAttribute : MethodInterceptionBaseAttribute
    {
        private readonly Stopwatch _stopwatch;
        public PerformanceAspectAttribute()
        {
            _stopwatch = new Stopwatch();
        }
        public override void Intercept(IInvocation invocation)
        {
            try
            {
                _stopwatch.Start();
                invocation.Proceed();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            string message = $"Performance : {invocation?.Method?.DeclaringType?.FullName}.{invocation?.Method.Name}-->{_stopwatch.Elapsed.TotalSeconds}";

            Console.WriteLine(message);

            _stopwatch.Reset();
        }
    }
}
