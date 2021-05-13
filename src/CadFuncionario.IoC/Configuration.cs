using CadFuncionario.Core.Services;
using CadFuncionario.Core.Services.Interfaces;
using CadFuncionario.Data.Repositories;
using CadFuncionario.Domain.Interfaces.Data;
using Microsoft.Extensions.DependencyInjection;

namespace CadFuncionario.IoC
{
    public class Configuration
    {
        public static void RegisterServices(IServiceCollection serviceCollection)
        {
            #region Services

            serviceCollection.AddScoped<INotificationService, NotificationService>();

            #endregion

            #region Repositories

            serviceCollection.AddScoped<IProfissaoRepository, ProfissaoRepository>();
            serviceCollection.AddScoped<IFuncionarioRepository, FuncionarioRepository>();

            #endregion
        }
    }
}