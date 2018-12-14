using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FacadeWebApi.System.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FacadeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly IFacade _facade;

        
        public ValuesController(IFacade facade) {
            this._facade = facade;
        }

        [HttpGet]
        public ActionResult<Guid> GetById(Guid id)
        {
            var item =   _facade.ExecuteLoadAsyn(id);
            if (item == null)
            {
                return null;
            }

            return item;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
