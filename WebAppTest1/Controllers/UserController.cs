using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppDomain.ViewModel;
using WebAppTest1Applayer.Interface;

namespace WebAppTest1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Route("api/v{version:apiVersion}/User")]
    public class UserController : ControllerBase
    {
        private IUserApp _UserApp { get; set; }
        private readonly ILogger<UserController> _logger;
        public UserController(IUserApp userApp, ILogger<UserController> logger)
        {
            _UserApp = userApp;
            _logger = logger;
            // Logs an informational message when the controller instance is created. 
            // Useful for confirming that the controller is up and running.
            _logger.LogInformation("UserController Started");
        }

        [HttpPost("CreateUser")]
        [MapToApiVersion("1.0")]
        public IActionResult CreateUserDetails([FromBody] UserDetails obj)
        {
            var objs = _UserApp.CreateUserDetails(obj);
            //var objs1 = _paymentApp.GetDetails();
            return Ok(objs);
        }

        [HttpPost("CreateUser")]
        [MapToApiVersion("2.0")]
        public IActionResult CreateUserDetais([FromBody] UserDetails obj)
        {
            var objs = _UserApp.CreateUserDetails(obj);
            //var objs1 = _paymentApp.GetDetails();
            return Ok(objs);
        }

        //[HttpGet("GetUserDetails")]
        //[ResponseCache(Duration =60,Location =ResponseCacheLocation.Any)]
        //public IActionResult GetUserDetails(UserDetails obj)
        //{
        //    var objs = _UserApp.CreateUserDetails(obj);
        //    //var objs1 = _paymentApp.GetDetails();
        //    return Ok(objs);
        //}

        [HttpGet("GetUserDetails")]
        //[ResponseCache(Duration = 60, Location = ResponseCacheLocation.Any)]
        //[Route("api/v{version:apiVersion}/GetUserDetails")]
        [ApiVersion("1.0")]
        public IActionResult GetUserDetails1()
        {
            // var objs = _UserApp.CreateUserDetails();
            //var objs1 = _paymentApp.GetDetails();
            return Ok("APi 1");
        }

        [HttpGet("GetUserDetails")]
        [ResponseCache(Duration = 60, Location = ResponseCacheLocation.Any)]
        //[Route("api/v{version:apiVersion}/GetUserDetails")]
        [ApiVersion("2.0")]
        public IActionResult GetUserDetails2()
        {
            //var objs = _UserApp.CreateUserDetails();
            //var objs1 = _paymentApp.GetDetails();
            return Ok("APi 2");
        }

        [HttpGet("GetUserDetails")]
        //[ResponseCache(Duration = 60, Location = ResponseCacheLocation.Any)]
        //[Route("api/v{version:apiVersion}/GetUserDetails")]
        //[OutputCache(Duration = 60)]
        [ApiVersion("3.0")]
        public IActionResult GetUserDetails3()
        {
            //var objs = _UserApp.CreateUserDetails();
            //var objs1 = _paymentApp.GetDetails();
            return Ok("APi 2");
        }

        [HttpGet("error")]
        [ApiVersion("1.0")]
        public IActionResult ThrowError()
        {
            throw new InvalidOperationException("Boom! Something went wrong testing chk");
        }

        [HttpGet("GetUserNames")]
        [ApiVersion("1.0")]
        public IEnumerable<UserDetails> GetUserNames()
        {
            var products = new List<UserDetails> 
            { new UserDetails {firstName = "Niranjan", lastName = "Sawant" }, 
                new UserDetails { firstName = "Sachin", lastName = "Tendulkar" }
             };
            return products; // This will be serialized into JSON array
            }
        }
}
