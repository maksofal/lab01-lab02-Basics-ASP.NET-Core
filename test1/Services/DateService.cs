namespace test1.Services
{
    public class DateService
    {
        protected internal IDate MyDate { get; }

        public DateService(IDate myDate)
        {
            MyDate = myDate;
        }
    }
}