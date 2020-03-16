using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using System.Security.Claims;

namespace BlazorApp1.Data
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        public ILocalStorageService _localStorageService { get; }

        public CustomAuthenticationStateProvider(ILocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var accessToken = await _localStorageService.GetItemAsync<string>("accessToken");

            ClaimsIdentity identity;

            if (accessToken != null && accessToken != string.Empty)
            {
                User user = new User();//await _userService.GetUserByAccessTokenAsync(accessToken);
                identity = GetClaimsIdentity(user);
            }
            else
            {
                identity = new ClaimsIdentity();
            }

            var claimsPrincipal = new ClaimsPrincipal(identity);

            return await Task.FromResult(new AuthenticationState(claimsPrincipal));
        }

        private ClaimsIdentity GetClaimsIdentity(User user)
        {
            var claimsIdentity = new ClaimsIdentity();

            if (user.email != null)
            {
                claimsIdentity = new ClaimsIdentity(new[]
                                {
                                    new Claim(ClaimTypes.Name, user.email),
                                    //new Claim(ClaimTypes.Role, user.Role.RoleDesc),
                                }, "apiauth_type");
            }

            return claimsIdentity;
        }
    }
}
