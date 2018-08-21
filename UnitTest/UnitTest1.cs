using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BL;
using DAO;
using DAO.Contexts;
using Entities;
using JeymerBot.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest {
    [TestClass]
    public class UnitTest {
        private BlRequest _BlRequest;

        public UnitTest() {
            _BlRequest = new BlRequest(new MockDao());
        }

        [TestMethod]
        public async Task GetAll() {
            List<RequestModel> moq = new List<RequestModel>();

            var add = new RequestModel();
            add.RequestId = 1;
            add.Message = "test";
            moq.Add(add);        

            var res = await _BlRequest.GetAll();   

            CollectionAssert.Equals(moq, res.ToList());
         
        }
        [TestMethod]
        public async Task GetById() {         

            var moq = new RequestModel();
            moq.RequestId = 1;
            moq.Message = "test";      

            var res = await _BlRequest.GetById(1);
            
            Assert.AreEqual(moq.RequestId, res.RequestId);
            Assert.AreEqual(moq.Message, res.Message);
        }

        [TestMethod]
        public async Task Insert() {

            var req = new RequestModel();
            req.Message = "TEST UNIT";
            req.UserName = "EZE";

            var res = await _BlRequest.Insert(req);

            
        }
    }


}