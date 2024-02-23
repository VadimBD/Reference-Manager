namespace OnlineReferences.Models
{
    public class ReferenceRequestInfo
    {
        public ReferenceType Type { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public StudentGroup? Group { get; set; }
        public List<ReferenceCustomField> CustomFields { get; set; }
    }
    public enum ReferenceType {
        Academic=1,
        Issue=2,
        Residence=3,
        Admission=4,
    }

}
