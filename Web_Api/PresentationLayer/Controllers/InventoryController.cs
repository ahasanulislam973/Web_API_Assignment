using BLL.BOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PresentationLayer.Controllers
{
    public class InventoryController : ApiController
    {
        [Route("api/Inventory/get")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = InventoryService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        [Route("api/Inventory/get/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = InventoryService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/Inventory/create")]
        [HttpPost]
        public HttpResponseMessage Create(InventoryModel n)
        {
            var data = InventoryService.Create(n);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Inventory/update")]
        [HttpPost]
        public HttpResponseMessage Update(InventoryModel n)
        {
            var data = InventoryService.Update(n);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Inventory/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = InventoryService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
    }
}

