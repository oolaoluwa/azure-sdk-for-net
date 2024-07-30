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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="AdminRuleGroupResource"/> and their operations.
    /// Each <see cref="AdminRuleGroupResource"/> in the collection will belong to the same instance of <see cref="SecurityAdminConfigurationResource"/>.
    /// To get an <see cref="AdminRuleGroupCollection"/> instance call the GetAdminRuleGroups method from an instance of <see cref="SecurityAdminConfigurationResource"/>.
    /// </summary>
    public partial class AdminRuleGroupCollection : ArmCollection, IEnumerable<AdminRuleGroupResource>, IAsyncEnumerable<AdminRuleGroupResource>
    {
        private readonly ClientDiagnostics _adminRuleGroupAdminRuleCollectionsClientDiagnostics;
        private readonly AdminRuleCollectionsRestOperations _adminRuleGroupAdminRuleCollectionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AdminRuleGroupCollection"/> class for mocking. </summary>
        protected AdminRuleGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AdminRuleGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AdminRuleGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _adminRuleGroupAdminRuleCollectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", AdminRuleGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AdminRuleGroupResource.ResourceType, out string adminRuleGroupAdminRuleCollectionsApiVersion);
            _adminRuleGroupAdminRuleCollectionsRestClient = new AdminRuleCollectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, adminRuleGroupAdminRuleCollectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SecurityAdminConfigurationResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SecurityAdminConfigurationResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an admin rule collection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/securityAdminConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdminRuleCollections_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AdminRuleGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleCollectionName"> The name of the network manager security Configuration rule collection. </param>
        /// <param name="data"> The Rule Collection to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleCollectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleCollectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AdminRuleGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string ruleCollectionName, AdminRuleGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleCollectionName, nameof(ruleCollectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _adminRuleGroupAdminRuleCollectionsClientDiagnostics.CreateScope("AdminRuleGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _adminRuleGroupAdminRuleCollectionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ruleCollectionName, data, cancellationToken).ConfigureAwait(false);
                var uri = _adminRuleGroupAdminRuleCollectionsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ruleCollectionName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new NetworkArmOperation<AdminRuleGroupResource>(Response.FromValue(new AdminRuleGroupResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates an admin rule collection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/securityAdminConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdminRuleCollections_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AdminRuleGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleCollectionName"> The name of the network manager security Configuration rule collection. </param>
        /// <param name="data"> The Rule Collection to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleCollectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleCollectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AdminRuleGroupResource> CreateOrUpdate(WaitUntil waitUntil, string ruleCollectionName, AdminRuleGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleCollectionName, nameof(ruleCollectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _adminRuleGroupAdminRuleCollectionsClientDiagnostics.CreateScope("AdminRuleGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _adminRuleGroupAdminRuleCollectionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ruleCollectionName, data, cancellationToken);
                var uri = _adminRuleGroupAdminRuleCollectionsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ruleCollectionName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new NetworkArmOperation<AdminRuleGroupResource>(Response.FromValue(new AdminRuleGroupResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a network manager security admin configuration rule collection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/securityAdminConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdminRuleCollections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AdminRuleGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleCollectionName"> The name of the network manager security Configuration rule collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleCollectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleCollectionName"/> is null. </exception>
        public virtual async Task<Response<AdminRuleGroupResource>> GetAsync(string ruleCollectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleCollectionName, nameof(ruleCollectionName));

            using var scope = _adminRuleGroupAdminRuleCollectionsClientDiagnostics.CreateScope("AdminRuleGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _adminRuleGroupAdminRuleCollectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ruleCollectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AdminRuleGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a network manager security admin configuration rule collection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/securityAdminConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdminRuleCollections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AdminRuleGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleCollectionName"> The name of the network manager security Configuration rule collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleCollectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleCollectionName"/> is null. </exception>
        public virtual Response<AdminRuleGroupResource> Get(string ruleCollectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleCollectionName, nameof(ruleCollectionName));

            using var scope = _adminRuleGroupAdminRuleCollectionsClientDiagnostics.CreateScope("AdminRuleGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _adminRuleGroupAdminRuleCollectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ruleCollectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AdminRuleGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the rule collections in a security admin configuration, in a paginated format.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/securityAdminConfigurations/{configurationName}/ruleCollections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdminRuleCollections_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AdminRuleGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> An optional query parameter which specifies the maximum number of records to be returned by the server. </param>
        /// <param name="skipToken"> SkipToken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AdminRuleGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AdminRuleGroupResource> GetAllAsync(int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _adminRuleGroupAdminRuleCollectionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _adminRuleGroupAdminRuleCollectionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, top, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AdminRuleGroupResource(Client, AdminRuleGroupData.DeserializeAdminRuleGroupData(e)), _adminRuleGroupAdminRuleCollectionsClientDiagnostics, Pipeline, "AdminRuleGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the rule collections in a security admin configuration, in a paginated format.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/securityAdminConfigurations/{configurationName}/ruleCollections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdminRuleCollections_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AdminRuleGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> An optional query parameter which specifies the maximum number of records to be returned by the server. </param>
        /// <param name="skipToken"> SkipToken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AdminRuleGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AdminRuleGroupResource> GetAll(int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _adminRuleGroupAdminRuleCollectionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _adminRuleGroupAdminRuleCollectionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, top, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AdminRuleGroupResource(Client, AdminRuleGroupData.DeserializeAdminRuleGroupData(e)), _adminRuleGroupAdminRuleCollectionsClientDiagnostics, Pipeline, "AdminRuleGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/securityAdminConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdminRuleCollections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AdminRuleGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleCollectionName"> The name of the network manager security Configuration rule collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleCollectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleCollectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string ruleCollectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleCollectionName, nameof(ruleCollectionName));

            using var scope = _adminRuleGroupAdminRuleCollectionsClientDiagnostics.CreateScope("AdminRuleGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _adminRuleGroupAdminRuleCollectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ruleCollectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/securityAdminConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdminRuleCollections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AdminRuleGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleCollectionName"> The name of the network manager security Configuration rule collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleCollectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleCollectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string ruleCollectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleCollectionName, nameof(ruleCollectionName));

            using var scope = _adminRuleGroupAdminRuleCollectionsClientDiagnostics.CreateScope("AdminRuleGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _adminRuleGroupAdminRuleCollectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ruleCollectionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/securityAdminConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdminRuleCollections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AdminRuleGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleCollectionName"> The name of the network manager security Configuration rule collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleCollectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleCollectionName"/> is null. </exception>
        public virtual async Task<NullableResponse<AdminRuleGroupResource>> GetIfExistsAsync(string ruleCollectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleCollectionName, nameof(ruleCollectionName));

            using var scope = _adminRuleGroupAdminRuleCollectionsClientDiagnostics.CreateScope("AdminRuleGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _adminRuleGroupAdminRuleCollectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ruleCollectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AdminRuleGroupResource>(response.GetRawResponse());
                return Response.FromValue(new AdminRuleGroupResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/securityAdminConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AdminRuleCollections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AdminRuleGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleCollectionName"> The name of the network manager security Configuration rule collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleCollectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleCollectionName"/> is null. </exception>
        public virtual NullableResponse<AdminRuleGroupResource> GetIfExists(string ruleCollectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleCollectionName, nameof(ruleCollectionName));

            using var scope = _adminRuleGroupAdminRuleCollectionsClientDiagnostics.CreateScope("AdminRuleGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _adminRuleGroupAdminRuleCollectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ruleCollectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AdminRuleGroupResource>(response.GetRawResponse());
                return Response.FromValue(new AdminRuleGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AdminRuleGroupResource> IEnumerable<AdminRuleGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AdminRuleGroupResource> IAsyncEnumerable<AdminRuleGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
