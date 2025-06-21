using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppAppServiceLayer.Interface;
using WebAppDomain.ViewModel;
using WebAppRepository.Interface;

namespace WebAppAppServiceLayer.Services
{
    public class PaymentService:IPaymentService
    {
        public IPaymentRepository _paymentRepository { get; set; }

        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }
        public PaymentDetails CreatePayDetails(PaymentDetails objpay)
        {
            PaymentDetails obj = new PaymentDetails();
           
            obj=_paymentRepository.CreatePayDetails(objpay);
            return obj;
        }

        public IEnumerable<PaymentDetails> GetDetails()
        {
            IEnumerable<PaymentDetails> obj= _paymentRepository.GetDetails();
            return obj;
        }
    }
}
