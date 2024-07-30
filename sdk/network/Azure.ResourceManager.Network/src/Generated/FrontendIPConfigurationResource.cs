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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A Class representing a FrontendIPConfiguration along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="FrontendIPConfigurationResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetFrontendIPConfigurationResource method.
    /// Otherwise you can get one from its parent resource <see cref="LoadBalancerResource"/> using the GetFrontendIPConfiguration method.
    /// </summary>
    public partial class FrontendIPConfigurationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="FrontendIPConfigurationResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="loadBalancerName"> The loadBalancerName. </param>
        /// <param name="frontendIPConfigurationName"> The frontendIPConfigurationName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string loadBalancerName, string frontendIPConfigurationName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/frontendIPConfigurations/{frontendIPConfigurationName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics;
        private readonly LoadBalancerFrontendIPConfigurationsRestOperations _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsRestClient;
        private readonly FrontendIPConfigurationData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/loadBalancers/frontendIPConfigurations";

        /// <summary> Initializes a new instance of the <see cref="FrontendIPConfigurationResource"/> class for mocking. </summary>
        protected FrontendIPConfigurationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FrontendIPConfigurationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal FrontendIPConfigurationResource(ArmClient client, FrontendIPConfigurationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="FrontendIPConfigurationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal FrontendIPConfigurationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string frontendIPConfigurationLoadBalancerFrontendIPConfigurationsApiVersion);
            _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsRestClient = new LoadBalancerFrontendIPConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, frontendIPConfigurationLoadBalancerFrontendIPConfigurationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual FrontendIPConfigurationData Data
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
        /// Gets load balancer frontend IP configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/frontendIPConfigurations/{frontendIPConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerFrontendIPConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontendIPConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FrontendIPConfigurationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics.CreateScope("FrontendIPConfigurationResource.Get");
            scope.Start();
            try
            {
                var response = await _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontendIPConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets load balancer frontend IP configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/frontendIPConfigurations/{frontendIPConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerFrontendIPConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontendIPConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FrontendIPConfigurationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics.CreateScope("FrontendIPConfigurationResource.Get");
            scope.Start();
            try
            {
                var response = _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontendIPConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
