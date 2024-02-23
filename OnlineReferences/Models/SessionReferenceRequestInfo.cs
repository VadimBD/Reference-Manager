using OnlineReferences.Infrastructure;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace OnlineReferences.Models
{
    public class SessionReferenceRequestInfo : ReferenceRequestInfo, ISessionSave
    {
        public static ReferenceRequestInfo GetReferenceRequest(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            SessionReferenceRequestInfo rRequest = session?.GetJson<SessionReferenceRequestInfo>("ReferenceRequest") ?? new SessionReferenceRequestInfo();
           
            rRequest.Session = session;
            return rRequest;
        }

        [JsonIgnore]
        public ISession Session { get; set; }

        public void SaveInSession()
        {
            Session?.SetJson("ReferenceRequest", this);
        }
    }
}
