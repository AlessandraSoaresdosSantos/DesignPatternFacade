using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Facade.WebApi.System.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Facade.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class GuidController : ControllerBase
    {
        private readonly IFacadeGerarGuid _facadeGuid;

        public GuidController(IFacadeGerarGuid facade)
        {
            this._facadeGuid = facade;
        }

        // GET api/guid
        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(_facadeGuid.GetGuid());
        }
    }
}