using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DAO.Contexts;
using DAO.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class BaseDao<TObject> : IDAO where TObject : class {
        private JeymerContext _context;

        #region Constructor

        //public void BaseDAO() {
        //    _context = new JeymerContext();
        //}

        public void BaseDAO(JeymerContext context) {
            _context = context;
        }

        #endregion

        #region Metodos

        public async Task<TObject> FindById(int id) {
            return await _context.Set<TObject>().FindAsync(id);
        }

        //public async Task<TObject> FindByQuery(Expression<Func<TObject, bool>> expression) {
        //    return await _context.Set<TObject>().FirstOrDefaultAsync(expression);
        //}

        public async Task<IEnumerable<TObject>> ListAll() {
            return await this._context.Set<TObject>().ToListAsync();
        }

        //public Task<IEnumerable<TObject>> ListByQuery(Expression<Func<TObject, bool>> expression) {
        //    return _context.Set<TObject>().Where(expression);
        //}

        public int Save(TObject entity) {
            try {
                _context.Set<TObject>().Add(entity);
                return _context.SaveChanges();
            } catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }

        public Task<HttpResponseMessage> Update(RequestModel req) {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RequestModel>> GetAllAsync() {
            throw new NotImplementedException();
        }

        public Task<RequestModel> GetById(int id) {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> Insert(RequestModel req) {
            throw new NotImplementedException();
        }
        #endregion

    }
}
