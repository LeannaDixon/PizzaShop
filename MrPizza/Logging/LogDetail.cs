using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MrPizza.Logging
{
    public class LogDetail
    {
        public LogDetail()
        {
            TimeStamp = DateTime.UtcNow;
        }

        public DateTime TimeStamp { get; private set; }
        public string Message { get; set; }
        public string Product { get; set; }
        public string Layer { get; set; }
        public string Location { get; set; }
        public string Hostname { get; set; }

        public string UserId { get; set; }
        public string CustomerId { get; set; }

        public long? ElapsedMilliseconds { get; set; }
        public Exception Exception { get; set; }
        public string CorrelatioId { get; set; }
        public Dictionary<string, object> AdditionalInfo { get; set; }
    }
}
