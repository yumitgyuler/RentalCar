using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Interceptors
{
    internal class ExceptionLogAspect
    {
        private Type type;

        public ExceptionLogAspect(Type type)
        {
            this.type = type;
        }
    }
}
