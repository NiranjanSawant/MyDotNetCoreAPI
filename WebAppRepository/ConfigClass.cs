using Microsoft.Extensions.Configuration;
using WebAppDomain;

namespace WebAppRepository
{
    public class ConfigClass
    {
    
        private readonly IConfiguration _configuration;
        private readonly MyLibrarySettings _myLibrarySettings;

        public ConfigClass(IConfiguration configuration)
        {
            _configuration = configuration;
           // _myLibrarySettings = _configuration.GetSection("ConnectionStrings").GetType()<MyLibrarySettings> ();
            //_myLibrarySettings = _configuration.GetSection("ConnectionStrings").GetSection() < MyLibrarySettings > ();
        }

        public void DoSomething()
        {
            var apiKey = _myLibrarySettings.ApiKey;
            var connectionString = _myLibrarySettings.ConnectionStrings.DefaultConnection;

            // Use apiKey and connectionString as needed
        }
        public class MyLibrarySettings
        {
            public string ApiKey { get; set; }
            public ConnectionStrings ConnectionStrings { get; set; }
        }

        public class ConnectionStrings
        {
            public string DefaultConnection { get; set; }
        }

    }
}