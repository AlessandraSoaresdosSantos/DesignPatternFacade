using FacadeWebApi.System.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacadeWebApi.System.Classes
{
    public class ClassGerarGuid: IClassGerarGuid
    {
        public ClassGerarGuid() { }

        public Guid GetGuid()
        {
            return  Guid.NewGuid();
        }
    }
}
