namespace test1.Services
{
    public interface I5
    {
        public string Five();
    }
    public class GetFIVE : I5
    {   
        
        public string Five()
        {
            return "Пятая служба";
        }
    }
    
}