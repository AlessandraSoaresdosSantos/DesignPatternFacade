using FacadeWebApi.System.Classes;
using FacadeWebApi.System.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FacadeWebApi.System
{
    public class Facade: IFacade 
    {
        private readonly IClassSystemOne _classOne;

        public Facade(IClassSystemOne classOne)
        {
            _classOne = classOne;
        }

        public  Guid ExecuteLoadAsyn(Guid id)
        {
            return   _classOne.LoadAsync(id);

        }

    }
}
