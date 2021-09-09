using Adapter.Interfaces;
using Adapter.Map;
using Services.Services;
using Autofac;
using Core.Interface.Services;
using Repository.Repositories;
using Core.Interface.Repository;
using Application.Interface;
using Application.Service;
//using Application.Validator;

namespace IoC
{
    public class ConfigurationIoC
    {
        public static void Load(ContainerBuilder builder)
        {
            //#region IOC SERVICE
         
            builder.RegisterType<ServiceLaboratorio>().As<IServicelaboratorio>();
            builder.RegisterType<ServicelaboratorioExame>().As<IServicelaboratorioExame>();
            builder.RegisterType<Serviceexame>().As<IServiceExame>();
            //#endregion

            //#region IOC REPOSITORY
            builder.RegisterType<RepositoryLaboratorio>().As<IRepositorylaboratorio>();
            builder.RegisterType<RepositoryExame>().As<IRepositoryExame>();
            builder.RegisterType<RepositoryLaboratorioExame>().As<IRepositorylaboratorioExame>();

            //#endregion

            //#region IOC MAPPER

            builder.RegisterType<MapperLaboratorio>().As<IMapperLaboratorio>();
            builder.RegisterType<MapperLaboratorioExame>().As<IMapperLaboratorioExame>();
            builder.RegisterType<MapperExame>().As<IMapperExame>();
            //#endregion

            //#region IOC APPLICATION
            builder.RegisterType<ApplicationLaboratorio>().As<IApplicationLaboratorio>();
            builder.RegisterType<ApplicationExame>().As<IApplicationExame>();
            builder.RegisterType<ApplicationLaboratorioExame>().As<IApplicationLaboratorioExame>();
            //#endregion

           

        }
    }
}
