using Facade.WebApi.System.Interface;
using FacadeWebApi.System.Classes;
using FacadeWebApi.System.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facade.WebApi.System
{
    public class FacadeGerarGuid : IFacadeGerarGuid
    {
        IClassGerarGuid _guid;

        public FacadeGerarGuid()
        {
            _guid = new ClassGerarGuid();
        }


        public Guid GetGuid()
        {
            return _guid.GetGuid();
        }
    }
}
