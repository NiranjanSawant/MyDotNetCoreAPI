using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppDomain.ViewModel;

namespace WebAppTest1Applayer.Interface
{
    public interface IPaymentApp
    {
        PaymentDetails CreatePayDetails(PaymentDetails objpay);
        IEnumerable<PaymentDetails> GetDetails();
    }
}
