// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="SiteSlotInstanceProcessModuleResource"/> and their operations.
    /// Each <see cref="SiteSlotInstanceProcessModuleResource"/> in the collection will belong to the same instance of <see cref="SiteSlotInstanceProcessResource"/>.
    /// To get a <see cref="SiteSlotInstanceProcessModuleCollection"/> instance call the GetSiteSlotInstanceProcessModules method from an instance of <see cref="SiteSlotInstanceProcessResource"/>.
    /// </summary>
    public partial class SiteSlotInstanceProcessModuleCollection : ArmCollection, IEnumerable<SiteSlotInstanceProcessModuleResource>, IAsyncEnumerable<SiteSlotInstanceProcessModuleResource>
    {
        private readonly ClientDiagnostics _siteSlotInstanceProcessModuleWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotInstanceProcessModuleWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotInstanceProcessModuleCollection"/> class for mocking. </summary>
        protected SiteSlotInstanceProcessModuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotInstanceProcessModuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteSlotInstanceProcessModuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotInstanceProcessModuleWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteSlotInstanceProcessModuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteSlotInstanceProcessModuleResource.ResourceType, out string siteSlotInstanceProcessModuleWebAppsApiVersion);
            _siteSlotInstanceProcessModuleWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotInstanceProcessModuleWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteSlotInstanceProcessResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteSlotInstanceProcessResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/processes/{processId}/modules/{baseAddress}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetInstanceProcessModuleSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotInstanceProcessModuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="baseAddress"> Module base address. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="baseAddress"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="baseAddress"/> is null. </exception>
        public virtual async Task<Response<SiteSlotInstanceProcessModuleResource>> GetAsync(string baseAddress, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(baseAddress, nameof(baseAddress));

            using var scope = _siteSlotInstanceProcessModuleWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceProcessModuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotInstanceProcessModuleWebAppsRestClient.GetInstanceProcessModuleSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, baseAddress, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotInstanceProcessModuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/processes/{processId}/modules/{baseAddress}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetInstanceProcessModuleSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotInstanceProcessModuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="baseAddress"> Module base address. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="baseAddress"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="baseAddress"/> is null. </exception>
        public virtual Response<SiteSlotInstanceProcessModuleResource> Get(string baseAddress, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(baseAddress, nameof(baseAddress));

            using var scope = _siteSlotInstanceProcessModuleWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceProcessModuleCollection.Get");
            scope.Start();
            try
            {
                var response = _siteSlotInstanceProcessModuleWebAppsRestClient.GetInstanceProcessModuleSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, baseAddress, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotInstanceProcessModuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for List module information for a process by its ID for a specific scaled-out instance in a web site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/processes/{processId}/modules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListInstanceProcessModulesSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotInstanceProcessModuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotInstanceProcessModuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotInstanceProcessModuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteSlotInstanceProcessModuleWebAppsRestClient.CreateListInstanceProcessModulesSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteSlotInstanceProcessModuleWebAppsRestClient.CreateListInstanceProcessModulesSlotNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SiteSlotInstanceProcessModuleResource(Client, ProcessModuleInfoData.DeserializeProcessModuleInfoData(e)), _siteSlotInstanceProcessModuleWebAppsClientDiagnostics, Pipeline, "SiteSlotInstanceProcessModuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for List module information for a process by its ID for a specific scaled-out instance in a web site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/processes/{processId}/modules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListInstanceProcessModulesSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotInstanceProcessModuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotInstanceProcessModuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotInstanceProcessModuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteSlotInstanceProcessModuleWebAppsRestClient.CreateListInstanceProcessModulesSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteSlotInstanceProcessModuleWebAppsRestClient.CreateListInstanceProcessModulesSlotNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SiteSlotInstanceProcessModuleResource(Client, ProcessModuleInfoData.DeserializeProcessModuleInfoData(e)), _siteSlotInstanceProcessModuleWebAppsClientDiagnostics, Pipeline, "SiteSlotInstanceProcessModuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/processes/{processId}/modules/{baseAddress}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetInstanceProcessModuleSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotInstanceProcessModuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="baseAddress"> Module base address. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="baseAddress"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="baseAddress"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string baseAddress, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(baseAddress, nameof(baseAddress));

            using var scope = _siteSlotInstanceProcessModuleWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceProcessModuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteSlotInstanceProcessModuleWebAppsRestClient.GetInstanceProcessModuleSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, baseAddress, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/processes/{processId}/modules/{baseAddress}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetInstanceProcessModuleSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotInstanceProcessModuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="baseAddress"> Module base address. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="baseAddress"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="baseAddress"/> is null. </exception>
        public virtual Response<bool> Exists(string baseAddress, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(baseAddress, nameof(baseAddress));

            using var scope = _siteSlotInstanceProcessModuleWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceProcessModuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteSlotInstanceProcessModuleWebAppsRestClient.GetInstanceProcessModuleSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, baseAddress, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/processes/{processId}/modules/{baseAddress}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetInstanceProcessModuleSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotInstanceProcessModuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="baseAddress"> Module base address. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="baseAddress"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="baseAddress"/> is null. </exception>
        public virtual async Task<NullableResponse<SiteSlotInstanceProcessModuleResource>> GetIfExistsAsync(string baseAddress, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(baseAddress, nameof(baseAddress));

            using var scope = _siteSlotInstanceProcessModuleWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceProcessModuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteSlotInstanceProcessModuleWebAppsRestClient.GetInstanceProcessModuleSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, baseAddress, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SiteSlotInstanceProcessModuleResource>(response.GetRawResponse());
                return Response.FromValue(new SiteSlotInstanceProcessModuleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/processes/{processId}/modules/{baseAddress}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetInstanceProcessModuleSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotInstanceProcessModuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="baseAddress"> Module base address. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="baseAddress"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="baseAddress"/> is null. </exception>
        public virtual NullableResponse<SiteSlotInstanceProcessModuleResource> GetIfExists(string baseAddress, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(baseAddress, nameof(baseAddress));

            using var scope = _siteSlotInstanceProcessModuleWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceProcessModuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteSlotInstanceProcessModuleWebAppsRestClient.GetInstanceProcessModuleSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, baseAddress, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SiteSlotInstanceProcessModuleResource>(response.GetRawResponse());
                return Response.FromValue(new SiteSlotInstanceProcessModuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteSlotInstanceProcessModuleResource> IEnumerable<SiteSlotInstanceProcessModuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotInstanceProcessModuleResource> IAsyncEnumerable<SiteSlotInstanceProcessModuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
