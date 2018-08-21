using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JeymerBot.ViewModels
{
    public class RequestDTO
    {
        public int RequestId { get; set; }
        public string Message { get; set; }
        public string UserId { get; set; }
        public string Id { get; set; }
        public int FkId { get; set; }
        public string Name { get; set; }
    }
}
