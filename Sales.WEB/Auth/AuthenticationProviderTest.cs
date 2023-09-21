using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Sales.WEB.Auth
{
    public class AuthenticationProviderTest : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var kerUser = new ClaimsIdentity(new List<Claim>
            {
                new Claim("FirstName", "Ker"),
                new Claim("LastName", "Moya"),
                new Claim(ClaimTypes.Name, "zulu@yopmail.com"), 
                new Claim(ClaimTypes.Role, "User")
            },
            authenticationType: "test");

            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(kerUser)));
        }

    }
}
