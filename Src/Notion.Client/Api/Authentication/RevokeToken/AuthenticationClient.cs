using System.Threading;
using System.Threading.Tasks;

namespace Notion.Client
{
    public sealed partial class AuthenticationClient
    {
        public async Task RevokeTokenAsync(
            RevokeTokenRequest revokeTokenRequest,
            CancellationToken cancellationToken = default)
        {
            var body = (IRevokeTokenBodyParameters)revokeTokenRequest;

            await _client.PostAsync<RevokeTokenResponse>(
                ApiEndpoints.AuthenticationUrls.RevokeToken(),
                body,
                cancellationToken: cancellationToken
            );
        }
    }
}
