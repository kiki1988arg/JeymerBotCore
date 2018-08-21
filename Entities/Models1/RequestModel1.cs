using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class RequestModel1
    {
        public int RequestId { get; set; }
        public string Message { get; set; }
        public string UserId { get; set; }

        public virtual User1 User { get; set; }
    }
}
