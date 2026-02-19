using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace WebAppTest1Applayer.Interface
{
    public interface ITokenService
    {
         string GeneratToken(List<Claim> claims);
    }
}
