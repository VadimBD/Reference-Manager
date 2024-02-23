
namespace OnlineReferences.Models
{
    public class FakeDBContext : IDbContext
    {
        public IEnumerable<StudentGroup> GetStudentGroups()
        {
            return new List<StudentGroup>()
            { 
                new StudentGroup(){Id=1,Name="PD-21"},
                new StudentGroup(){Id=2,Name="PD-22"},
                new StudentGroup(){Id=3,Name="PD-23"},
                new StudentGroup(){Id=4,Name="PD-24"},
            };
        }

        public void SaveReferenceRequest(ReferenceRequestInfo reference)
        {
            
        }
    }
}
