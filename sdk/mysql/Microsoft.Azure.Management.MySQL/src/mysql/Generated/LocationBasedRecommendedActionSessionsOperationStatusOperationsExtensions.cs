// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MySQL
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for LocationBasedRecommendedActionSessionsOperationStatusOperations.
    /// </summary>
    public static partial class LocationBasedRecommendedActionSessionsOperationStatusOperationsExtensions
    {
            /// <summary>
            /// Recommendation action session operation status.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationName'>
            /// The name of the location.
            /// </param>
            /// <param name='operationId'>
            /// The operation identifier.
            /// </param>
            public static RecommendedActionSessionsOperationStatus Get(this ILocationBasedRecommendedActionSessionsOperationStatusOperations operations, string locationName, string operationId)
            {
                return operations.GetAsync(locationName, operationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Recommendation action session operation status.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationName'>
            /// The name of the location.
            /// </param>
            /// <param name='operationId'>
            /// The operation identifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RecommendedActionSessionsOperationStatus> GetAsync(this ILocationBasedRecommendedActionSessionsOperationStatusOperations operations, string locationName, string operationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(locationName, operationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
