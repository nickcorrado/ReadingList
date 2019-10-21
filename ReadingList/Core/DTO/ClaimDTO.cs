namespace Core.DTO
{
    public class ClaimDTO
    {
        public int ClaimId { get; set; }
        public int UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
    }
}
