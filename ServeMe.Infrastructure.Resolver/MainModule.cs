using Microsoft.Extensions.DependencyInjection;
using ServeMe.Main.Domain.Repositories;
using ServeMe.Main.Domain.Services;
using ServeMe.Main.Repositories;
using ServeMe.Main.Services;
using System;
using System.Collections.Generic;
using System.Text;
using ServeMe.Infrastructure.DatabaseHelper;

namespace ServeMe.Infrastructure.DI
{
    public static class MainModule
    {
        public static IServiceCollection RegisterServices(
            this IServiceCollection services)
        {
            // Main Services
            services.AddTransient<ITestCoreServ, TestCoreServ>();

            // Main Repositories
            services.AddTransient<IAvaliacaoRepository, AvaliacaoRepository>();
            services.AddTransient<ICategoriaRepository, CategoriaRepository>();
            services.AddTransient<IComentarioRepository, ComentarioRepository>();
            services.AddTransient<IEmailRepository, EmailRepository>();
            services.AddTransient<IEnderecoRepository, EnderecoRepository>();
            services.AddTransient<IEstabelecimentoRepository, EstabelecimentoRepository>();
            services.AddTransient<IFacilidadeRepository, FacilidadeRepository>();
            services.AddTransient<IFormaPagamentoRepository, FormaPagamentoRepository>();
            services.AddTransient<IImagemRepository, ImagemRepository>();
            services.AddTransient<IPerfilRepository, PerfilRepository>();
            services.AddTransient<IProdutoRepository, ProdutoRepository>();
            services.AddTransient<IPromocaoRepository, PromocaoRepository>();
            services.AddTransient<ITelefoneRepository, TelefoneRepository>();
            services.AddTransient<ITipoEstabelecimentoRepository, TipoEstabelecimentoRepository>();
            services.AddTransient<ITipoProdutoRepository, TipoProdutoRepository>();
            services.AddTransient<ITipoTelefoneRepository, TipoTelefoneRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();

            // DatabaseHelper
            services.AddTransient<IPostgreSqlConnectionFactory, PostgreSqlConnectionFactory>();

            // Security Services

            // Security Repositories
            
            return services;
        }
    }
}
