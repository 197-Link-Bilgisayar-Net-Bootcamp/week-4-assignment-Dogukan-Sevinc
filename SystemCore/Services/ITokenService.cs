using System.Core.Configuration;
using System.Core.DTOs;
using System.Core.Models;

namespace System.Core.Services
{
    public interface ITokenService
    {
        TokenDto CreateToken(UserApp userApp);

        ClientTokenDto CreateTokenByClient(Client client);
    }
}