namespace Adapter
{
    public class OldElectricitySystem
    {
        public string MatchThinSocket()
        {
            return "220V";
        }
    }

    public interface INewElectricitySystem
    {
        string MatchWideSocket();
    }

    public class NewElectricitySystem : INewElectricitySystem
    {
        public string MatchWideSocket()
        {
            return "220V";
        }
    }
}
