using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DAO.Interfaces;
using Entities;


namespace DAO
{
    public class MockDao : IDAO {
        public Task<HttpResponseMessage> Delete(int id) {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RequestModel>> GetAllAsync() {
            List<RequestModel> moq = new List<RequestModel>();         
            var aux = new RequestModel() {
                RequestId = 1,
                Message = "test"
            };
            moq.Add(aux);
            return moq;
        }

        public async Task<RequestModel> GetById(int id) {
            var moq = new RequestModel();
            moq.RequestId = id;
            moq.Message = "test";

            return moq;
        }

        public Task<HttpResponseMessage> Insert(RequestModel req) {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> Update(RequestModel req) {
            throw new NotImplementedException();
        }
    }
}
