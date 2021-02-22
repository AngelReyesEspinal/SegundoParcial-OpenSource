using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SistemaDeCompras.Models;
using SistemaDeCompras.Services;
using SistemaDeCompras.Services.Departamento;

namespace SistemaDeCompras
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddHttpClient();
            services.AddDbContext<SistemaDeComprasDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DbConnectionString")));

            services.AddTransient<IDepartamentoService, DepartamentoService>();
            services.AddTransient<IOrdenDeCompraService, OrdenDeCompraService>();
            services.AddTransient<IProveedorService, ProveedorService>();
            services.AddTransient<IUnidadDeMedidaService, UnidadDeMedidaService>();
            services.AddTransient<IArticuloService, ArticuloService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseCors("AllowDebugOrigin");
            }

            app.UseCors("AllowProdOrigin");

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
