using NLB.Client.Core;
using NLB.Client.Services;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Json;

namespace NLB.Client
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private readonly IUserService userService;
        private readonly HttpClient http;

        public CustomAuthStateProvider(IUserService userService, HttpClient http)
        {
            this.userService = userService;
            this.http = http;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            List<Claim> claims = new List<Claim>();

            await userService.LoadTokenAsync();

            var identity = new ClaimsIdentity();
            if(Storage.Token is not null)
            {
                http.DefaultRequestHeaders.Authorization=new AuthenticationHeaderValue("bearer",Storage.Token.Token);
                claims = ParseClaimsFromJwt(Storage.Token.Token).ToList();
                identity = new ClaimsIdentity(claims, "jwt");
            }

            var user = new ClaimsPrincipal(identity);
            var state= new AuthenticationState(user);

            NotifyAuthenticationStateChanged(Task.FromResult(state));
            
            return state;
        }

        private static IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            var payload = jwt.Split('.')[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);
            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);
            return keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString()));
        }

        private static byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }
            return Convert.FromBase64String(base64);
        }
    }
}
