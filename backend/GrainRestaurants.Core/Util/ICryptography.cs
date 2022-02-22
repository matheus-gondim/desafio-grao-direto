namespace GrainRestaurants.Core.Util
{
    public interface ICryptography
    {
        string Hash(string password);
        string Salt(string hash);
        bool Compare(string password, string hash);
        public string GenerareToken();
    }
}
