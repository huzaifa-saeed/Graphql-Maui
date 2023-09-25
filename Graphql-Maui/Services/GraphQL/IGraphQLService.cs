
using System;
using System.Runtime.CompilerServices;
using StrawberryShake;

namespace Graphql_Maui.Services.GraphQL
{
	public interface IGraphQLService
	{
        IObservable<IOperationResult<IGetAssetsResult>> GetAssets();
    }
}

