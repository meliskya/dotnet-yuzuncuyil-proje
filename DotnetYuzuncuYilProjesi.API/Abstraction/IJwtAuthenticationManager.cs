using DotnetYuzuncuYilProjesi.Core.DTOs;

namespace DotnetYuzuncuYilProjesi.API.Abstraction
{
    public interface IJwtAuthenticationManager
    {
        AuthResponseDto Authenticate(string songName, string singer);
    }
}
