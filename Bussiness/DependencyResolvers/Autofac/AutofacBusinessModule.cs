using Autofac;
using Bussiness.Abstract;
using Bussiness.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        //configurasyonu burada yapıyoruz
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerManager>().As<ICustomerService>();
            builder.RegisterType<EnFraCustomerDao>().As<ICustomerDao>();
        }
    }
}
