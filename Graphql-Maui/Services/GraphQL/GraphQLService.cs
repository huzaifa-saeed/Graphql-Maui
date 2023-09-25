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

    public IObservable<IOperationResult<IGetAssetsResult>> GetAssets()
    {
        return _client
                  .GetAssets
             .Watch(ExecutionStrategy.CacheAndNetwork)
             .Where(n => !n.Errors.Any());

    }
}