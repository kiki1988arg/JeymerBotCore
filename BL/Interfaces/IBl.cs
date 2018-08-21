using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BL.Interfaces
{
    public interface IBl
    {
        Task<IEnumerable<RequestModel>> GetAll();
        Task<RequestModel> GetById(int number);
        Task<HttpResponseMessage> Insert(RequestModel req);
        Task<HttpResponseMessage> Update(RequestModel req);
        Task<HttpResponseMessage> Delete(int number);

    }
}
