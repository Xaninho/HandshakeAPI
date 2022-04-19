namespace HandshakeAPI.Entities
{
    public record Client
    {
        public long Id { get; init; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
    }
}
