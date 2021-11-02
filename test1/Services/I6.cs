namespace test1.Services
{
    public interface I6
    {
        public string Six();
    }
    
    public class GetSix : I6
    {   
        
        public string Six()
        {
            return "Шестая служба";
        }
    }
}