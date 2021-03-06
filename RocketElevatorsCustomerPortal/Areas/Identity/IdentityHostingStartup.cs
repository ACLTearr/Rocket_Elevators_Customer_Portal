using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RocketElevatorsCustomerPortal.Areas.Identity.Data;
using RocketElevatorsCustomerPortal.Data;

[assembly: HostingStartup(typeof(RocketElevatorsCustomerPortal.Areas.Identity.IdentityHostingStartup))]
namespace RocketElevatorsCustomerPortal.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<CustomerPortalDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("CustomerPortalDbContextConnection")));

                services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<CustomerPortalDbContext>();
            });
        }
    }
}