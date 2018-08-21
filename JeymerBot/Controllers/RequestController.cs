using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
using BL.Interfaces;
using Entities;
using JeymerBot.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JeymerBot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private IBl _Bl;
        public RequestController(IBl Bl) {
            _Bl = Bl;
        }
        // GET: api/Request
        [HttpGet]
        public async Task<IEnumerable<RequestModel>> GetAll()
        {
            var res = await _Bl.GetAll();
            return res;
        }

        // GET: api/Request/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<RequestModel> Get(int id)
        {
            var res = await _Bl.GetById(id);
            return res;
        }

        // POST: api/Request
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RequestDTO req)
        {
            RequestModel request = new RequestModel();        
            request.Message = req.Message;
            request.UserName = req.Name;            
            var res = await _Bl.Insert(request);
            return Ok(res);
        }

        // PUT: api/Request/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] RequestDTO req)
        {
            RequestModel request = new RequestModel();
            request.RequestId = id;
            request.Message = req.Message;            
            var res = await _Bl.Update(request);
            return Ok(res);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var res = await _Bl.Delete(id);
            return Ok(res);
        }
    }
}
