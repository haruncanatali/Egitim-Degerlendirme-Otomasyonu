using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Egitim.Business.Ninject
{
    public class InstanceFactory
    {
        public T GetInstance<T>()
        {
            var kernel = new StandardKernel(new BusinessModule());
            return kernel.Get<T>();
        }
    }
}
