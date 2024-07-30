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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A Class representing a NetworkVirtualApplianceSku along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="NetworkVirtualApplianceSkuResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetNetworkVirtualApplianceSkuResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetNetworkVirtualApplianceSku method.
    /// </summary>
    public partial class NetworkVirtualApplianceSkuResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="NetworkVirtualApplianceSkuResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="skuName"> The skuName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string skuName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Network/networkVirtualApplianceSkus/{skuName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _networkVirtualApplianceSkuVirtualApplianceSkusClientDiagnostics;
        private readonly VirtualApplianceSkusRestOperations _networkVirtualApplianceSkuVirtualApplianceSkusRestClient;
        private readonly NetworkVirtualApplianceSkuData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/networkVirtualApplianceSkus";

        /// <summary> Initializes a new instance of the <see cref="NetworkVirtualApplianceSkuResource"/> class for mocking. </summary>
        protected NetworkVirtualApplianceSkuResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkVirtualApplianceSkuResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal NetworkVirtualApplianceSkuResource(ArmClient client, NetworkVirtualApplianceSkuData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkVirtualApplianceSkuResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal NetworkVirtualApplianceSkuResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkVirtualApplianceSkuVirtualApplianceSkusClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string networkVirtualApplianceSkuVirtualApplianceSkusApiVersion);
            _networkVirtualApplianceSkuVirtualApplianceSkusRestClient = new VirtualApplianceSkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkVirtualApplianceSkuVirtualApplianceSkusApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual NetworkVirtualApplianceSkuData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Retrieves a single available sku for network virtual appliance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/networkVirtualApplianceSkus/{skuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualApplianceSkus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkVirtualApplianceSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NetworkVirtualApplianceSkuResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _networkVirtualApplianceSkuVirtualApplianceSkusClientDiagnostics.CreateScope("NetworkVirtualApplianceSkuResource.Get");
            scope.Start();
            try
            {
                var response = await _networkVirtualApplianceSkuVirtualApplianceSkusRestClient.GetAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkVirtualApplianceSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves a single available sku for network virtual appliance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/networkVirtualApplianceSkus/{skuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualApplianceSkus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkVirtualApplianceSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetworkVirtualApplianceSkuResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _networkVirtualApplianceSkuVirtualApplianceSkusClientDiagnostics.CreateScope("NetworkVirtualApplianceSkuResource.Get");
            scope.Start();
            try
            {
                var response = _networkVirtualApplianceSkuVirtualApplianceSkusRestClient.Get(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkVirtualApplianceSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
