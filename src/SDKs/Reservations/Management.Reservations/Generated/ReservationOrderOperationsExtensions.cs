// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ReservationOrderOperations.
    /// </summary>
    public static partial class ReservationOrderOperationsExtensions
    {
            /// <summary>
            /// Get all `ReservationOrder`s.
            /// </summary>
            /// <remarks>
            /// List of all the `ReservationOrder`s that the user has access to in the
            /// current tenant.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<ReservationOrderResponse> List(this IReservationOrderOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all `ReservationOrder`s.
            /// </summary>
            /// <remarks>
            /// List of all the `ReservationOrder`s that the user has access to in the
            /// current tenant.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ReservationOrderResponse>> ListAsync(this IReservationOrderOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a specific `ReservationOrder`.
            /// </summary>
            /// <remarks>
            /// Get the details of the `ReservationOrder`.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            public static ReservationOrderResponse Get(this IReservationOrderOperations operations, string reservationOrderId)
            {
                return operations.GetAsync(reservationOrderId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a specific `ReservationOrder`.
            /// </summary>
            /// <remarks>
            /// Get the details of the `ReservationOrder`.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ReservationOrderResponse> GetAsync(this IReservationOrderOperations operations, string reservationOrderId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(reservationOrderId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all `ReservationOrder`s.
            /// </summary>
            /// <remarks>
            /// List of all the `ReservationOrder`s that the user has access to in the
            /// current tenant.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ReservationOrderResponse> ListNext(this IReservationOrderOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all `ReservationOrder`s.
            /// </summary>
            /// <remarks>
            /// List of all the `ReservationOrder`s that the user has access to in the
            /// current tenant.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ReservationOrderResponse>> ListNextAsync(this IReservationOrderOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}