using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppAppServiceLayer.Interface;
using WebAppDomain.ViewModel;
using WebAppTest1Applayer.Interface;

namespace WebAppTest1Applayer.AppServices
{
    public class PaymentApplication:IPaymentApp
    {

        public IPaymentService _paymentService { get; set; }

        public PaymentApplication(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        public PaymentDetails CreatePayDetails(PaymentDetails objpay)
        {
            PaymentDetails obj = new PaymentDetails();

            obj = _paymentService.CreatePayDetails(objpay);
            return obj;
        }

        public IEnumerable<PaymentDetails> GetDetails()
        {
            IEnumerable<PaymentDetails> obj=new List<PaymentDetails>();

            obj = _paymentService.GetDetails();
            return obj;
        }
    }
}
