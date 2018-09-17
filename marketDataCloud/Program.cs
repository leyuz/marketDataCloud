using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace marketDataCloud {
    public class Program {
        public static void Main (string[] args) {
            CreateWebHostBuilder (args).Build ().Run ();
        }

        public static IWebHostBuilder CreateWebHostBuilder (string[] args) =>
            WebHost.CreateDefaultBuilder (args)
            .UseWebRoot ("web/wwwroot") //omitting this will use default root of wwwroot/ instead of web/wwwroot/
            // .UseKestrel (options => {
            //     options.Listen (IPAddress.Loopback, 5000);
            //     options.Listen (IPAddress.Loopback, 5001, listenOptions => {
            //         listenOptions.UseHttps (fileName: "certificate.pfx", password: "topsecret");
            //     });
            // })
            .UseStartup<Startup> ();
    }
}