using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BL.Interfaces;
using DAO.Interfaces;
using Entities;

namespace BL
{
    public class BlMock : IBl {
        private readonly IDAO _DAO;
        public BlMock(IDAO DAO) {
            _DAO = DAO;
        }

        public Task<HttpResponseMessage> Delete(int number) {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RequestModel>> GetAll() {
            return await _DAO.GetAllAsync();
        }

        public async Task<RequestModel> GetById(int number) {
            return await _DAO.GetById(number);
        }

        public Task<HttpResponseMessage> Insert(RequestModel req) {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> Update(RequestModel req) {
            throw new NotImplementedException();
        }
    }
}
