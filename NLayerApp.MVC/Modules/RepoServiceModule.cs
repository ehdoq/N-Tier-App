﻿using Autofac;
using NLayerApp.Core.Repositories;
using NLayerApp.Core.Services;
using NLayerApp.Core.UnitOfWorks;
using NLayerApp.Repository.AppDBContext;
using NLayerApp.Repository.Repositories;
using NLayerApp.Repository.UnitOfWorks;
using NLayerApp.Service.Mapping;
using NLayerApp.Service.Services;
using System.Reflection;
using Module = Autofac.Module;

namespace NLayerApp.Web.Modules
{
    public class RepoServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(Repository<>))
                   .As(typeof(IRepository<>))
                   .InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(Service<>))
                   .As(typeof(IService<>))
                   .InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>()
                   .As<IUnitOfWork>();

            var apiAssembly = Assembly.GetExecutingAssembly();
            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly)
                   .Where(x => x.Name.EndsWith("Repository"))
                   .AsImplementedInterfaces()
                   .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly)
                   .Where(x => x.Name.EndsWith("Service"))
                   .AsImplementedInterfaces()
                   .InstancePerLifetimeScope();

            //InstancePerLifetimeScope => Scoped
            //InstancePerDependency => Transient
        }
    }
}
