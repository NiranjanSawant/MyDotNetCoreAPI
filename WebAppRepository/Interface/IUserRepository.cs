using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppDomain.ViewModel;

namespace WebAppRepository.Interface
{
    public interface IUserRepository
    {
        UserDetails CreateUserDetails(UserDetails obj);
    }
}
