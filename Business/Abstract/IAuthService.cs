using Azure.Core;
using Core.Entities.Concrete;
using Core.Utilities.Result;
using Core.Utilities.Security.Jwt;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto user);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);

        IResult UserExits(string email);
        IDataResult<Core.Utilities.Security.Jwt.AccessToken> CreateAccessToken(User user);
    }
}
