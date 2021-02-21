using Egitim.Business.Abstract;
using Egitim.Business.Concrete;
using Egitim.DataAccess.Abstract;
using Egitim.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace Egitim.Business.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IOgretmenService>().To<OgretmenManager>().InTransientScope();
            Bind<IOgretmenDal>().To<OgretmenDal>().InTransientScope();

            Bind<IOkulService>().To<OkulManager>().InTransientScope();
            Bind<IOkulDal>().To<OkulDal>().InTransientScope();

            Bind<IOkulYorumService>().To<OkulYorumManager>().InTransientScope();
            Bind<IOkulYorumDal>().To<OkulYorumDal>().InTransientScope();

            Bind<IOgretmenYorumService>().To<OgretmenYorumManager>().InTransientScope();
            Bind<IOgretmenYorumDal>().To<OgretmenYorumDal>().InTransientScope();
        }
    }
}
