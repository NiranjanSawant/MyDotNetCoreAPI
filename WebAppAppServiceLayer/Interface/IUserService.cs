using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppDomain.ViewModel;

namespace WebAppAppServiceLayer.Interface
{
    public interface IUserService
    {
        UserDetails CreateUserDetails(UserDetails objpay);
    }
}
