using FacadeWebApi.System.Classes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FacadeWebApi.System.Interface
{
    public interface IFacade
    {
        Guid ExecuteLoadAsyn(Guid id);
         
    }
}
