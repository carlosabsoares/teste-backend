namespace SnowmanLabsChallenge.Infra.CrossCutting.IoC
{
    using SnowmanLabsChallenge.Application.Interfaces;
    using SnowmanLabsChallenge.Application.Services;
    using SnowmanLabsChallenge.Domain.Interfaces;
    using SnowmanLabsChallenge.Infra.CrossCutting.Identity.Authorization;
    using SnowmanLabsChallenge.Infra.CrossCutting.Identity.Models;
    using SnowmanLabsChallenge.Infra.Data.Context;
    using SnowmanLabsChallenge.Infra.Data.Repository;
    using SnowmanLabsChallenge.Infra.Data.UoW;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.Extensions.DependencyInjection;

    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Authorization Polices

            services.AddSingleton<IAuthorizationHandler, ClaimsRequirementHandler>();

            #endregion Authorization Polices

            #region Application

            // Nao remova ou edite a linha abaixo. Utilizado para gerar codigo automatico
            // AddAppService //

            #endregion Application

            #region Infra - Data

            // Nao remova ou edite a linha abaixo. Utilizado para gerar codigo automatico
            // AddNewRepository //

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<DefaultContext>();

            #endregion Infra - Data

            #region Services

            #endregion Services

            #region Infra - Identity

            services.AddScoped<IUser, AspNetUser>();

            #endregion Infra - Identity
        }
    }
}
