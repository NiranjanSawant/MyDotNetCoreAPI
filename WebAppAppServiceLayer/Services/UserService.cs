using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppAppServiceLayer.Interface;
using WebAppDomain.ViewModel;
using WebAppRepository.Interface;

namespace WebAppAppServiceLayer.Services
{
    public class UserService: IUserService
    {
        public IUserRepository _userRepository { get; set; }

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public UserDetails CreateUserDetails(UserDetails objpay)
        {
            UserDetails obj = new UserDetails();

            obj = _userRepository.CreateUserDetails(objpay);
            return obj;
        }
    }
}
