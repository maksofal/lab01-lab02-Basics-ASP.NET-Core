namespace test1.Services
{
    public class GetDate : IDate
    {
        private string _date;

        public GetDate()
        {
            _date = System.DateTimeOffset.Now.ToString(format:" dd MMMM yyyy  ");
        }

        public string Ddate
        {
            get { return _date; }
        }
    }
}