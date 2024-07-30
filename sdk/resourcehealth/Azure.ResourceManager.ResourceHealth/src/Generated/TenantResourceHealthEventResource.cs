// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ResourceHealth
{
    /// <summary>
    /// A Class representing a TenantResourceHealthEvent along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="TenantResourceHealthEventResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetTenantResourceHealthEventResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource"/> using the GetTenantResourceHealthEvent method.
    /// </summary>
    public partial class TenantResourceHealthEventResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="TenantResourceHealthEventResource"/> instance. </summary>
        /// <param name="eventTrackingId"> The eventTrackingId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string eventTrackingId)
        {
            var resourceId = $"/providers/Microsoft.ResourceHealth/events/{eventTrackingId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _tenantResourceHealthEventEventClientDiagnostics;
        private readonly EventRestOperations _tenantResourceHealthEventEventRestClient;
        private readonly ClientDiagnostics _securityAdvisoryImpactedResourcesClientDiagnostics;
        private readonly SecurityAdvisoryImpactedResourcesRestOperations _securityAdvisoryImpactedResourcesRestClient;
        private readonly ResourceHealthEventData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ResourceHealth/events";

        /// <summary> Initializes a new instance of the <see cref="TenantResourceHealthEventResource"/> class for mocking. </summary>
        protected TenantResourceHealthEventResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantResourceHealthEventResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal TenantResourceHealthEventResource(ArmClient client, ResourceHealthEventData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="TenantResourceHealthEventResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantResourceHealthEventResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _tenantResourceHealthEventEventClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ResourceHealth", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string tenantResourceHealthEventEventApiVersion);
            _tenantResourceHealthEventEventRestClient = new EventRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, tenantResourceHealthEventEventApiVersion);
            _securityAdvisoryImpactedResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ResourceHealth", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _securityAdvisoryImpactedResourcesRestClient = new SecurityAdvisoryImpactedResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ResourceHealthEventData Data
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

        /// <summary> Gets a collection of TenantResourceHealthEventImpactedResources in the TenantResourceHealthEvent. </summary>
        /// <returns> An object representing collection of TenantResourceHealthEventImpactedResources and their operations over a TenantResourceHealthEventImpactedResource. </returns>
        public virtual TenantResourceHealthEventImpactedResourceCollection GetTenantResourceHealthEventImpactedResources()
        {
            return GetCachedClient(client => new TenantResourceHealthEventImpactedResourceCollection(client, Id));
        }

        /// <summary>
        /// Gets the specific impacted resource in the tenant by an event.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/events/{eventTrackingId}/impactedResources/{impactedResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImpactedResources_GetByTenantId</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantResourceHealthEventImpactedResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="impactedResourceName"> Name of the Impacted Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="impactedResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="impactedResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<TenantResourceHealthEventImpactedResource>> GetTenantResourceHealthEventImpactedResourceAsync(string impactedResourceName, CancellationToken cancellationToken = default)
        {
            return await GetTenantResourceHealthEventImpactedResources().GetAsync(impactedResourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specific impacted resource in the tenant by an event.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/events/{eventTrackingId}/impactedResources/{impactedResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImpactedResources_GetByTenantId</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantResourceHealthEventImpactedResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="impactedResourceName"> Name of the Impacted Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="impactedResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="impactedResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<TenantResourceHealthEventImpactedResource> GetTenantResourceHealthEventImpactedResource(string impactedResourceName, CancellationToken cancellationToken = default)
        {
            return GetTenantResourceHealthEventImpactedResources().Get(impactedResourceName, cancellationToken);
        }

        /// <summary>
        /// Service health event in the tenant by event tracking id
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/events/{eventTrackingId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Event_GetByTenantIdAndTrackingId</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantResourceHealthEventResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="queryStartTime"> Specifies from when to return events, based on the lastUpdateTime property. For example, queryStartTime = 7/24/2020 OR queryStartTime=7%2F24%2F2020. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TenantResourceHealthEventResource>> GetAsync(string filter = null, string queryStartTime = null, CancellationToken cancellationToken = default)
        {
            using var scope = _tenantResourceHealthEventEventClientDiagnostics.CreateScope("TenantResourceHealthEventResource.Get");
            scope.Start();
            try
            {
                var response = await _tenantResourceHealthEventEventRestClient.GetByTenantIdAndTrackingIdAsync(Id.Name, filter, queryStartTime, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantResourceHealthEventResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Service health event in the tenant by event tracking id
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/events/{eventTrackingId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Event_GetByTenantIdAndTrackingId</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantResourceHealthEventResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="queryStartTime"> Specifies from when to return events, based on the lastUpdateTime property. For example, queryStartTime = 7/24/2020 OR queryStartTime=7%2F24%2F2020. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TenantResourceHealthEventResource> Get(string filter = null, string queryStartTime = null, CancellationToken cancellationToken = default)
        {
            using var scope = _tenantResourceHealthEventEventClientDiagnostics.CreateScope("TenantResourceHealthEventResource.Get");
            scope.Start();
            try
            {
                var response = _tenantResourceHealthEventEventRestClient.GetByTenantIdAndTrackingId(Id.Name, filter, queryStartTime, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantResourceHealthEventResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists impacted resources in the tenant by an event (Security Advisory).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/events/{eventTrackingId}/listSecurityAdvisoryImpactedResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityAdvisoryImpactedResources_ListByTenantIdAndEventId</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceHealthEventImpactedResourceData"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceHealthEventImpactedResourceData> GetSecurityAdvisoryImpactedResourcesByTenantIdAndEventIdAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityAdvisoryImpactedResourcesRestClient.CreateListByTenantIdAndEventIdRequest(Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityAdvisoryImpactedResourcesRestClient.CreateListByTenantIdAndEventIdNextPageRequest(nextLink, Id.Name, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => ResourceHealthEventImpactedResourceData.DeserializeResourceHealthEventImpactedResourceData(e), _securityAdvisoryImpactedResourcesClientDiagnostics, Pipeline, "TenantResourceHealthEventResource.GetSecurityAdvisoryImpactedResourcesByTenantIdAndEventId", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists impacted resources in the tenant by an event (Security Advisory).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/events/{eventTrackingId}/listSecurityAdvisoryImpactedResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityAdvisoryImpactedResources_ListByTenantIdAndEventId</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceHealthEventImpactedResourceData"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceHealthEventImpactedResourceData> GetSecurityAdvisoryImpactedResourcesByTenantIdAndEventId(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityAdvisoryImpactedResourcesRestClient.CreateListByTenantIdAndEventIdRequest(Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityAdvisoryImpactedResourcesRestClient.CreateListByTenantIdAndEventIdNextPageRequest(nextLink, Id.Name, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => ResourceHealthEventImpactedResourceData.DeserializeResourceHealthEventImpactedResourceData(e), _securityAdvisoryImpactedResourcesClientDiagnostics, Pipeline, "TenantResourceHealthEventResource.GetSecurityAdvisoryImpactedResourcesByTenantIdAndEventId", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Service health event details in the tenant by event tracking id. This can be used to fetch sensitive properties for Security Advisory events
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/events/{eventTrackingId}/fetchEventDetails</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Event_FetchDetailsByTenantIdAndTrackingId</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantResourceHealthEventResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TenantResourceHealthEventResource>> FetchDetailsByTenantIdAndTrackingIdAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantResourceHealthEventEventClientDiagnostics.CreateScope("TenantResourceHealthEventResource.FetchDetailsByTenantIdAndTrackingId");
            scope.Start();
            try
            {
                var response = await _tenantResourceHealthEventEventRestClient.FetchDetailsByTenantIdAndTrackingIdAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new TenantResourceHealthEventResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Service health event details in the tenant by event tracking id. This can be used to fetch sensitive properties for Security Advisory events
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/events/{eventTrackingId}/fetchEventDetails</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Event_FetchDetailsByTenantIdAndTrackingId</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantResourceHealthEventResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TenantResourceHealthEventResource> FetchDetailsByTenantIdAndTrackingId(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantResourceHealthEventEventClientDiagnostics.CreateScope("TenantResourceHealthEventResource.FetchDetailsByTenantIdAndTrackingId");
            scope.Start();
            try
            {
                var response = _tenantResourceHealthEventEventRestClient.FetchDetailsByTenantIdAndTrackingId(Id.Name, cancellationToken);
                return Response.FromValue(new TenantResourceHealthEventResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
