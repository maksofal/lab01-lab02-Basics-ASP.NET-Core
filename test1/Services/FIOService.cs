namespace test1.Services
{
    public class FIOService
    {
        protected internal IFIO MyFio { get; }

        public FIOService(IFIO myfio)
        {
            MyFio = myfio;
        }
    }
}