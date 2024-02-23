namespace OnlineReferences.Models
{
    public class ReferenceCustomField
    {
        public ReferenceCustomFieldType Type { get; set; }
       public String Value { get; set; } = string.Empty;
    }
    public enum ReferenceCustomFieldType
    {
        Group=1,
        Course=2,
        YearOfBirth=3,
        ResidencePlace= 4,
        
    }
}
