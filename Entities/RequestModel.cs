using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public partial class RequestModel
    {
        public int RequestId { get; set; }
        public string Message { get; set; }
        public string UserName { get; set; }


        public User UserNameNavigation { get; set; }
    }
}
