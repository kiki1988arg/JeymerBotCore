using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DAO.Contexts;
using DAO.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class DAOrequest : IDAO {
        private readonly JeymerContext _context;
        public DAOrequest(JeymerContext context) {
            _context = context;
        }     

        public async Task<IEnumerable<RequestModel>> GetAllAsync() => await _context.RequestModel.ToListAsync();

        public async Task<RequestModel> GetById(int id) => await _context.RequestModel.FindAsync(id);

        public async Task<HttpResponseMessage> Insert(RequestModel req) {
            _context.RequestModel.Add(req);
            int status = await _context.SaveChangesAsync();          
            return new HttpResponseMessage(HttpStatusCode.OK);     
        }

        public async Task<HttpResponseMessage> Update(RequestModel req) {        
            var e = _context.RequestModel.SingleOrDefault(b => b.RequestId == req.RequestId);
            e.Message = req.Message;
            int status = await _context.SaveChangesAsync();
            return new HttpResponseMessage(HttpStatusCode.OK);         
        }
        public Task<HttpResponseMessage> Delete(int id) {
            throw new NotImplementedException();
        }
    }
}
