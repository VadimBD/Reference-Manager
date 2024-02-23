namespace OnlineReferences.Models
{
    public interface IDbContext
    {
         void SaveReferenceRequest(ReferenceRequestInfo reference);
        IEnumerable<StudentGroup> GetStudentGroups();
     
    }
}
