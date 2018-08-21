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
    public class BlRequest : IBl {     

        private readonly IDAO _DAO;
        public BlRequest(IDAO DAO) {
            _DAO = DAO;
        } 

        public async Task<IEnumerable<RequestModel>> GetAll() {
            return await _DAO.GetAllAsync();
        }

        public async Task<RequestModel> GetById(int number) {
            return await _DAO.GetById(number);
        }

        public async Task<HttpResponseMessage> Insert(RequestModel req) {
            return await _DAO.Insert(req);
        }

        public async Task<HttpResponseMessage> Update(RequestModel req) {
            return await _DAO.Update(req);
        }

        public async Task<HttpResponseMessage> Delete(int number) {
            return await _DAO.Delete(number);
        }
    }
}
