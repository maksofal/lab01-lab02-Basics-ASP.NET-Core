namespace test1.Services
{
    public interface ITime
    {
        public string Time();

    }
    
    public class GetTime : ITime
    {
        
        public string Time()
        {
            return System.DateTime.Now.ToString(format:"hh:mm:ss");
        }
    }
    
}