using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppDomain.ViewModel;

namespace WebAppAppServiceLayer.Interface
{
    public interface IPaymentService
    {
        PaymentDetails CreatePayDetails(PaymentDetails objpay);
        IEnumerable<PaymentDetails> GetDetails();
    }
}
