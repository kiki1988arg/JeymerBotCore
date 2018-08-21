using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAO.Interfaces
{
    public interface IDAO
    {
        Task<IEnumerable<RequestModel>> GetAllAsync();
        Task<RequestModel> GetById(int id);
        Task<HttpResponseMessage> Insert(RequestModel req);
        Task<HttpResponseMessage> Update(RequestModel req);
        Task<HttpResponseMessage> Delete(int id);
    }
}
