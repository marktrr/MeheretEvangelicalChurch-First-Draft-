using System;
using MeheretEvangelicalChurch.Areas.Identity.Data;
using MeheretEvangelicalChurch.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(MeheretEvangelicalChurch.Areas.Identity.IdentityHostingStartup))]
namespace MeheretEvangelicalChurch.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                
            });
        }
    }
}