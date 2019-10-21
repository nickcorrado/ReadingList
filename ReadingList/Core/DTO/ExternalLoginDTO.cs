namespace Core.DTO
{
    public class ExternalLoginDTO
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public int UserId { get; set; }
    }
}
