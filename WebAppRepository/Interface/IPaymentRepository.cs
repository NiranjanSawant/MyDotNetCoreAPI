using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppDomain;
using WebAppDomain.ViewModel;

namespace WebAppRepository.Interface
{
    public interface IPaymentRepository
    {
        PaymentDetails CreatePayDetails(PaymentDetails obj);
        PaymentDetails UpdatePayDetails();

        PaymentDetails GetAllDetails();
        PaymentDetails DeleteDetails();
        IEnumerable<PaymentDetails> GetDetails();
    }
}
