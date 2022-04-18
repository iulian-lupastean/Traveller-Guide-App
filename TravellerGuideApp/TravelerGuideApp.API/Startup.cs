using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using TravelerGuideApp.API.Middleware;
using TravelerGuideApp.API.Services;
using TravelerGuideApp.Application.Commands;
using TravelerGuideApp.Application.Interfaces;
using TravelerGuideApp.Infrastructure.Database.DatabaseContext;
using TravelerGuideApp.Infrastructure.Repositories;

namespace TravelerGuideApp.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TravelerGuideApp", Version = "v1" });
            });

            services.AddSingleton<ISingletonService, SingletonService>();
            services.AddScoped<IScopedService, ScopedService>();
            services.AddTransient<ITransientService, TransientService>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<ITravelItineraryRepository, TravelItineraryRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddDbContext<TravelerGuideAppDBContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("Default")));
            services.AddMediatR(typeof(CreateCityCommand));
            services.AddAutoMapper(typeof(Startup));
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TravelerGuideApp v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseTgaMiddleware();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
