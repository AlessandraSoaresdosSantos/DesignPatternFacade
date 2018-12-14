using System;

namespace FacadeWebApi.System.Classes
{
    internal class SaveObjectEvent
    {
        private ClassSystemOne instance;

        public SaveObjectEvent(ClassSystemOne instance)
        {
            this.instance = instance;
        }
    }
}