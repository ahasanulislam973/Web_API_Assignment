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
    public class StationaryController : ApiController
    {
        [Route("api/stationary/get")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = StationaryService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        [Route("api/stationary/get/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = StationaryService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/stationary/create")]
        [HttpPost]
        public HttpResponseMessage Create(StationaryModel n)
        {
            var data = StationaryService.Create(n);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/stationary/update")]
        [HttpPost]
        public HttpResponseMessage Update(StationaryModel n)
        {
            var data = StationaryService.Update(n);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/stationary/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = StationaryService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
    }
}

