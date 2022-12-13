using AutoMapper;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using study_web_platform.Services;
using study_web_platform.Helpers;


namespace study_web_platform
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        //This method gets called by the runtime.Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // services.AddDbContext<DataContext>(opt =>
            //     //server - name where we host: if launch with docker compose Server must contain network name 
            //     opt.UseNpgsql($"Server=localhost;Port=5432;Database=devplatform;User Id=postgres;Password={Toolchain.GetStringFromDotEnv("DB_PASSWD")};"));

            // services.AddDatabaseDeveloperPageExceptionFilter();

            //services.AddScoped(typeof(IEfRepository<>), typeof(UserRepository<>));

            //services.AddCors();
            //services.AddControllers();

            // services.AddScoped<IUserService, UserService>();
            // services.AddAutoMapper(typeof(UserProfile));

            // services.AddAuthentication()
            //     .AddIdentityServerJwt();

            // services.AddSwaggerGen(c =>
            // {
            //     c.SwaggerDoc("v1", new OpenApiInfo { Title = "Study WEB platform API API", Version = "v1" });
            // });

            //services.AddScoped<IUserService, UserService>();
            services.AddControllersWithViews();

            services.AddSpaStaticFiles(configuration => { configuration.RootPath = "wwwroot"; });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.UseDeveloperExceptionPage();

            if (env.IsDevelopment())
                app.UseMigrationsEndPoint();
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            // app.UseMiddleware<JwtMiddleware>();
            app.UseRouting();
            // app.UseSwagger();
            // app.UseSwaggerUI(x =>
            // {
            //     x.SwaggerEndpoint("/swagger/v1/swagger.json", "Study WEB platform API v1");

            // });

            // app.UseAuthentication();
            // //app.UseIdentityServer();
            // app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });

            // app.UseSpa(spa =>
            // {
            //     spa.Options.SourcePath = "ClientApp";

            //     if (env.IsDevelopment())
            //         spa.UseReactDevelopmentServer(npmScript: "start");
            // });
        }
    }
}

// using AutoMapper;
// using Microsoft.AspNetCore.Builder;
// using Microsoft.AspNetCore.Hosting;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.DependencyInjection;
// using Microsoft.OpenApi.Models;
// using study_web_platform.Helpers;
// using study_web_platform.Services;

// namespace study_web_platform
// {
//     public class Startup
//     {
//         public Startup(IConfiguration configuration)
//         {
//             Configuration = configuration;
//         }

//         public IConfiguration Configuration { get; }

//         public void ConfigureServices(IServiceCollection services)
//         {
//             services.AddDbContext<DataContext>(opt =>
//                 opt.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));

//             services.AddScoped(typeof(IEfRepository<>), typeof(UserRepository<>));

//             services.AddAutoMapper(typeof(UserProfile));
//             services.AddCors();
//             services.AddControllers();
//             services.AddSwaggerGen(c =>
//             {
//                 c.SwaggerDoc("v1", new OpenApiInfo { Title = "Sailora WEB API API", Version = "v1" });
//             });

//             services.AddScoped<IUserService, UserService>();
//         }

//         // configure the HTTP request pipeline
//         public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//         {
//             app.UseRouting();
//             app.UseSwagger();
//             app.UseSwaggerUI(x =>
//             {
//                 x.SwaggerEndpoint("/swagger/v1/swagger.json", "Sailora WEB API v1");

//             });

//             app.UseCors(x => x
//                 .AllowAnyOrigin()
//                 .AllowAnyMethod()
//                 .AllowAnyHeader());

//             app.UseMiddleware<JwtMiddleware>();
//             app.UseEndpoints(x => x.MapControllers());
//         }
//     }
// }