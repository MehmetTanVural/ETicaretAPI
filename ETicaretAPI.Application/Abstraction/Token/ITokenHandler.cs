using ETicaretAPI.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Abstraction
{
    public interface ITokenHandler
    {
        Token CreateAccessToken(int miniute);
    }
}
