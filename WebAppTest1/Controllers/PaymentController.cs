using Microsoft.AspNetCore.Mvc;
using WebAppDomain.ViewModel;
using WebAppTest1Applayer.Interface;

namespace WebAppTest1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {

        private IPaymentApp _paymentApp { get; set; }

        public PaymentController(IPaymentApp paymentApp)
        {
            _paymentApp = paymentApp;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpPost("CreatePayDet")]
        public IActionResult CreatePaymentDetail(PaymentDetails obj)
        {
            var objs=_paymentApp.CreatePayDetails(obj);
            var objs1 = _paymentApp.GetDetails();
            return Ok(objs1);
        }

        [HttpGet("GetDetails")]
        public async Task<ActionResult<IEnumerable<PaymentDetails>>> GetDetails()
        {
            var objs = _paymentApp.GetDetails();
            return Ok(objs);
        }

    }
}
