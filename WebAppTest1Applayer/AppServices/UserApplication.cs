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
   
    public class UserApplication: IUserApp
    {
        private readonly IUserService _userService;

        public UserApplication(IUserService userService)
        {
            this._userService = userService;
        }
        public UserDetails CreateUserDetails(UserDetails obUser)
        {
            UserDetails obj = new UserDetails();

            obj = _userService.CreateUserDetails(obUser);
            return obj;
        }
    }
}
