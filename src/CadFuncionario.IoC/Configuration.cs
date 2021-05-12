using CadFuncionario.Data.Repositories;
using CadFuncionario.Domain.Interfaces.Data;
using Microsoft.Extensions.DependencyInjection;

namespace CadFuncionario.IoC
{
    public class Configuration
    {
        public static void RegisterServices(IServiceCollection serviceCollection)
        {
            #region Repositories

            serviceCollection.AddScoped<IProfissaoRepository, ProfissaoRepository>();
            serviceCollection.AddScoped<IFuncionarioRepository, FuncionarioRepository>();

            #endregion
        }
    }
}