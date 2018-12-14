using FacadeWebApi.System.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FacadeWebApi.System.Classes
{
    public class ClassSystemOne : IClassSystemOne
    {
        
        public ClassSystemOne()
        {
            
        }

        public Guid LoadAsync(Guid id)
        {
            return Guid.NewGuid();
        }

        

    }
}
