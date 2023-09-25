using System.Reactive.Linq;
using System.Runtime.CompilerServices;
using StrawberryShake;

namespace Graphql_Maui.Services.GraphQL;

class GraphQLService : IGraphQLService
{
    readonly MauiGraphqlAppClient _client;

    public GraphQLService(MauiGraphqlAppClient client)
    {
        _client = client;
    }
    private IReadOnlyList<IAssetInfo> _assets = Array.Empty<IAssetInfo>();
    public async Task<IReadOnlyList<IAssetInfo>> GetAssets()
    {
        //var result2 = await _client.GetAssets.ExecuteAsync(token).ConfigureAwait(false);
        //result2.EnsureNoErrors();

       
        _client
            .GetAssets
            .Watch(ExecutionStrategy.CacheAndNetwork)
            .Where(n => !n.Errors.Any())
            .Select(t => t.Data!.Assets!.Nodes)
            .Subscribe(result =>
            {
                _assets= result;
            });
        return _assets;
    }  
}