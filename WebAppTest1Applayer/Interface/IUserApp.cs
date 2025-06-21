using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppDomain.ViewModel;

namespace WebAppTest1Applayer.Interface
{
    public interface IUserApp
    {
        UserDetails CreateUserDetails(UserDetails obuser);
    }
}
