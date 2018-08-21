using System;
using System.Collections.Generic;

namespace Entities {
    public partial class User1
    {
        public User1()
        {
            RequestModel = new HashSet<RequestModel1>();
        }

        public string Id { get; set; }
        public int RequestId { get; set; }
        public string Name { get; set; }

        public ICollection<RequestModel1> RequestModel { get; set; }
    }
}
