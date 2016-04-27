using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Domain.Mobile.Interface;
using Testes.UnitOfWork;

namespace Testes
{
    public class AppModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWorkMock>().InSingletonScope();
            //Bind<CookieDBContext>().ToSelf();
            //Bind<ServicoRegistroLote>().ToSelf();
        }
    }
}
