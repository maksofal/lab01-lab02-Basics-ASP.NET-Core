namespace test1.Services
{
    public class Counter : ICounter
    {
        static int n=1;
        private int _value;
        public Counter()
        {
           _value = n++;
               
            
        }
        
        public int Value
        {
            get { return _value; }
        }
    }
}