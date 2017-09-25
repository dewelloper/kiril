using Markum.Cloud.Libraries.LibraryObjects;
using Markum.Cloud.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace Markum.Cloud.Api.Controllers
{
    public class ServerController : BaseApiController
    {
        private IServerService _serverService;
        public ServerController(IServerService serverService)
        {
            _serverService = serverService;
        }

        // GET: api/Server
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Server/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Server
        public IHttpActionResult Post([FromBody] Libraries.Server.ServerCreateModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _serverService.CreateServer(model);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        // PUT: api/Server/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Server/5
        public IHttpActionResult Delete([FromBody]Libraries.Server.ServerRemoveModel model)
        {
            if (!ModelState.IsValid)
                JSendBadRequest(ModelState);

            var res = _serverService.RemoveServer(model);

            return JSendSuccess(HttpStatusCode.OK, res);
        }

        [HttpPost]
        [Route("api/server/ChangeMemorySize")]
        public IHttpActionResult ChangeMemorySize([FromBody]Libraries.Server.ServerChangeMemoryModel model)
        {
            if (!ModelState.IsValid)
                JSendBadRequest(ModelState);

            var res = _serverService.ChangeServerMemorySize(model);

            return JSendSuccess(HttpStatusCode.OK, res);
        }

    }
}
