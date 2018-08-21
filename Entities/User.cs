using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class User
    {
        public User()
        {
            RequestModel = new HashSet<RequestModel>();
        }

        public int RequestId { get; set; }
        public string Name { get; set; }

        public ICollection<RequestModel> RequestModel { get; set; }
    }
}
