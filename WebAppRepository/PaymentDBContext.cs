using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppDomain;
using static WebAppRepository.ConfigClass;

namespace WebAppRepository
{
    public partial class PaymentDBContext : DbContext
    {

        protected readonly IConfiguration Configuration;

       public string connst { get; set; }


        private readonly PDBContext _PDBCon;

        IConfigurationRoot configurationRoot = new ConfigurationBuilder()
    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .Build();

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    // connect to sql server with connection string from app settings
        //    options.UseSqlServer(Configuration.GetConnectionString("DevConnection"));
        //}
        //public string connst { get; set; }
        //private readonly IConfiguration _configuration;

        public PaymentDBContext(string connname = "DevConnection")
        {
         //  var constring= configurationRoot.GetSection("DevConnection").ToString();
            string constring = configurationRoot["ConnectionStrings:DevConnection"];
            //ConfigClass configClass = new ConfigClass(configurationRoot);
            //PDBContext _PDBCon = new PDBContext(configClass);
            //Class1 tst = new Class1(Configuration);
             this.connst = constring;
        }


        //public PaymentDBContext(DbContextOptions<PaymentDBContext> options) : base(options)
        //{

        //}

        ////public PaymentDBContext(IConfiguration configuration)
        ////{
        ////    _configuration = configuration;
        ////}

        //public string GetConnectionString(string connname)
        //{
        //    Appsets s = new Appsets();
        //    this.connst = s.ConnectionString;
        //    return _configuration.GetConnectionString(connname);
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.connst);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
