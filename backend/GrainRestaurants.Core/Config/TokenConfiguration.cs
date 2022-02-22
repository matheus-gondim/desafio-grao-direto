namespace GrainRestaurants.Core.Config
{
    public class TokenConfiguration
    {
        public string Issuer { get; } = "MinervaAPI";
        public string Secret { get; } = "QUAL_O_SIGNIFICADO_DA_VIDA_DO_UNIVERSO_E_TUDO_MAIS";
        public int DaysToExpiry { get; } = 30;
    }
}
