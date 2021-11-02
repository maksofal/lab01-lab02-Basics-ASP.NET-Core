namespace test1.Services
{
    public class CounterService
    {
        protected internal ICounter MyCounter { get; }
        public CounterService(ICounter counter)
        {
            MyCounter = counter;
        }
    }
}