using System.Text.Json.Serialization;

namespace OAuth2Demo.Web.Services.Github.Dto
{
    public class GetGithubAccessTokenDto
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }
    }
}