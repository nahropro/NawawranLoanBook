using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using NLB.Server.Data;
using NLB.Server.Data.Triggers;
using NLB.Server.Repos;
using NLB.Server.Services;
using System.Security.Cryptography;
using System.Text;

namespace SLB.Web.Server;

public class Startup
{

    public IConfiguration Configuration { get; }
    private static string CROS_POLICY = "CorsPlicy";
    private readonly IWebHostEnvironment env;

    public Startup(IConfiguration configuration,IWebHostEnvironment env)
    {
        Configuration = configuration;
        this.env = env;
    }

    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(Startup));

        //Allow all CORS
        services.AddCors(o => o.AddPolicy(CROS_POLICY, builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        }));

        services.AddDbContext<NLBDbContext>(options =>
        {
            if(env.IsDevelopment())
                options.UseSqlServer(Configuration.GetConnectionString("SqlServerLocal"));
            else
                options.UseSqlServer(Configuration.GetConnectionString("SqlServerSmarter"));

            options.UseTriggers(triggerOptions => {
                triggerOptions.AddTrigger<TransactionTriggers>();
            });
        });

        services.AddControllersWithViews();
        services.AddRazorPages();

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<ICustomerRepo, CustomerRepo>();
        services.AddScoped<ITransactionRepo, TransactionRepo>();
        services.AddScoped<IUserRepo, UserRepo>();

        services.AddTransient<HashAlgorithm, SHA512CryptoServiceProvider>();
        services.AddScoped<IHashService, HashService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<ITokenService, TokenService>();

        services.AddAuthentication(a =>
        {
            a.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            a.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(o =>
        {
            o.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidAudience = Configuration["AuthSettings:Audience"],
                ValidIssuer = Configuration["AuthSettings:Issuer"],
                RequireExpirationTime = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["AuthSettings:Key"])),
                ValidateIssuerSigningKey = true,
                ValidateLifetime = true,
            };
        });

        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "NLB.Web", Version = "v1" });

            string filePath = Path.Combine(AppContext.BaseDirectory, "NLB.Server.xml");
            c.IncludeXmlComments(filePath);

            string filePath2 = Path.Combine(AppContext.BaseDirectory, "NLB.Shared.xml");
            c.IncludeXmlComments(filePath2);
        });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseWebAssemblyDebugging();
        }
        else
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        if(env.IsDevelopment())
            app.UseCors(CROS_POLICY);

        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "NLB.Web v1"));

        //Redirect base url to swagger
        //var option = new RewriteOptions();
        //option.AddRedirect("^$", "swagger");
        //app.UseRewriter(option);

        app.UseHttpsRedirection();
        app.UseBlazorFrameworkFiles();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthentication();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapRazorPages();
            endpoints.MapControllers();
            endpoints.MapFallbackToFile("index.html");
        });
    }
}
