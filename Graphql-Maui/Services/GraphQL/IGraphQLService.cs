
using System;
using System.Runtime.CompilerServices;

namespace Graphql_Maui.Services.GraphQL
{
	public interface IGraphQLService
	{
        Task<IReadOnlyList<IAssetInfo>> GetAssets();
    }
}

