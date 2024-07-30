// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkFeatureResource"/> and their operations.
    /// Each <see cref="NetworkFeatureResource"/> in the collection will belong to the same instance of <see cref="WebSiteSlotResource"/>.
    /// To get a <see cref="NetworkFeatureCollection"/> instance call the GetNetworkFeatures method from an instance of <see cref="WebSiteSlotResource"/>.
    /// </summary>
    public partial class NetworkFeatureCollection : ArmCollection
    {
        private readonly ClientDiagnostics _networkFeatureWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _networkFeatureWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkFeatureCollection"/> class for mocking. </summary>
        protected NetworkFeatureCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkFeatureCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkFeatureCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkFeatureWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", NetworkFeatureResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkFeatureResource.ResourceType, out string networkFeatureWebAppsApiVersion);
            _networkFeatureWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkFeatureWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSiteSlotResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSiteSlotResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Gets all network features used by the app (or deployment slot, if specified).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkFeatures/{view}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListNetworkFeaturesSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFeatureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="view"> The type of view. Only "summary" is supported at this time. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="view"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="view"/> is null. </exception>
        public virtual async Task<Response<NetworkFeatureResource>> GetAsync(string view, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(view, nameof(view));

            using var scope = _networkFeatureWebAppsClientDiagnostics.CreateScope("NetworkFeatureCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkFeatureWebAppsRestClient.ListNetworkFeaturesSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, view, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFeatureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets all network features used by the app (or deployment slot, if specified).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkFeatures/{view}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListNetworkFeaturesSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFeatureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="view"> The type of view. Only "summary" is supported at this time. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="view"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="view"/> is null. </exception>
        public virtual Response<NetworkFeatureResource> Get(string view, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(view, nameof(view));

            using var scope = _networkFeatureWebAppsClientDiagnostics.CreateScope("NetworkFeatureCollection.Get");
            scope.Start();
            try
            {
                var response = _networkFeatureWebAppsRestClient.ListNetworkFeaturesSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, view, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFeatureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkFeatures/{view}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListNetworkFeaturesSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFeatureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="view"> The type of view. Only "summary" is supported at this time. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="view"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="view"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string view, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(view, nameof(view));

            using var scope = _networkFeatureWebAppsClientDiagnostics.CreateScope("NetworkFeatureCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkFeatureWebAppsRestClient.ListNetworkFeaturesSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, view, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkFeatures/{view}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListNetworkFeaturesSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFeatureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="view"> The type of view. Only "summary" is supported at this time. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="view"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="view"/> is null. </exception>
        public virtual Response<bool> Exists(string view, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(view, nameof(view));

            using var scope = _networkFeatureWebAppsClientDiagnostics.CreateScope("NetworkFeatureCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkFeatureWebAppsRestClient.ListNetworkFeaturesSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, view, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkFeatures/{view}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListNetworkFeaturesSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFeatureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="view"> The type of view. Only "summary" is supported at this time. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="view"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="view"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkFeatureResource>> GetIfExistsAsync(string view, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(view, nameof(view));

            using var scope = _networkFeatureWebAppsClientDiagnostics.CreateScope("NetworkFeatureCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkFeatureWebAppsRestClient.ListNetworkFeaturesSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, view, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkFeatureResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkFeatureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkFeatures/{view}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListNetworkFeaturesSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFeatureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="view"> The type of view. Only "summary" is supported at this time. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="view"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="view"/> is null. </exception>
        public virtual NullableResponse<NetworkFeatureResource> GetIfExists(string view, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(view, nameof(view));

            using var scope = _networkFeatureWebAppsClientDiagnostics.CreateScope("NetworkFeatureCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkFeatureWebAppsRestClient.ListNetworkFeaturesSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, view, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkFeatureResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkFeatureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
