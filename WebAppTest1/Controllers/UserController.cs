using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppDomain.ViewModel;
using WebAppTest1Applayer.Interface;

namespace WebAppTest1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserApp _UserApp { get; set; }

        public UserController(IUserApp userApp)
        {
            _UserApp = userApp;
        }

        [HttpPost("CreateUser")]
        [Route("api/v{version:apiVersion}/CreateUserDetais")]
        [ApiVersion("1.0")]
        public IActionResult CreateUserDetails(UserDetails obj)
        {
            var objs = _UserApp.CreateUserDetails(obj);
            //var objs1 = _paymentApp.GetDetails();
            return Ok(objs);
        }

        [HttpPost("CreateUser")]
        [Route("api/v{version:apiVersion}/CreateUserDetais")]
        [ApiVersion("2.0")]
        public IActionResult CreateUserDetais(UserDetails obj)
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
        //[ResponseCache(Duration = 60, Location = ResponseCacheLocation.Any)]
        //[Route("api/v{version:apiVersion}/GetUserDetails")]
        [ApiVersion("2.0")]
        public IActionResult GetUserDetails2()
        {
            //var objs = _UserApp.CreateUserDetails();
            //var objs1 = _paymentApp.GetDetails();
            return Ok("APi 2");
        }
    }
}
