namespace test1.Services
{
    public class FIO: IFIO
    {
        private string _FIO;

        public FIO()
        {
            _FIO = "Maksudova Sofya";
        }

        public string FFIO
        {
            get { return _FIO; }
        }
    }
}