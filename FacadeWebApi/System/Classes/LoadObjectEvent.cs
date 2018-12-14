using System;
using Microsoft.AspNetCore.Mvc;

namespace FacadeWebApi.System.Classes
{
    internal class LoadObjectEvent 
    {
        private Guid id;

        public LoadObjectEvent(Guid id)
        {
            this.id = id;
        }
    }
}