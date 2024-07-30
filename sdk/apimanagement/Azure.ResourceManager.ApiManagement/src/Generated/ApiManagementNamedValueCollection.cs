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
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiManagementNamedValueResource"/> and their operations.
    /// Each <see cref="ApiManagementNamedValueResource"/> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource"/>.
    /// To get an <see cref="ApiManagementNamedValueCollection"/> instance call the GetApiManagementNamedValues method from an instance of <see cref="ApiManagementServiceResource"/>.
    /// </summary>
    public partial class ApiManagementNamedValueCollection : ArmCollection, IEnumerable<ApiManagementNamedValueResource>, IAsyncEnumerable<ApiManagementNamedValueResource>
    {
        private readonly ClientDiagnostics _apiManagementNamedValueNamedValueClientDiagnostics;
        private readonly NamedValueRestOperations _apiManagementNamedValueNamedValueRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementNamedValueCollection"/> class for mocking. </summary>
        protected ApiManagementNamedValueCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementNamedValueCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementNamedValueCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementNamedValueNamedValueClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementNamedValueResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementNamedValueResource.ResourceType, out string apiManagementNamedValueNamedValueApiVersion);
            _apiManagementNamedValueNamedValueRestClient = new NamedValueRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementNamedValueNamedValueApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates named value.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/namedValues/{namedValueId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NamedValue_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementNamedValueResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="namedValueId"> Identifier of the NamedValue. </param>
        /// <param name="content"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namedValueId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namedValueId"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiManagementNamedValueResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string namedValueId, ApiManagementNamedValueCreateOrUpdateContent content, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namedValueId, nameof(namedValueId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _apiManagementNamedValueNamedValueClientDiagnostics.CreateScope("ApiManagementNamedValueCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiManagementNamedValueNamedValueRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, namedValueId, content, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiManagementNamedValueResource>(new ApiManagementNamedValueOperationSource(Client), _apiManagementNamedValueNamedValueClientDiagnostics, Pipeline, _apiManagementNamedValueNamedValueRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, namedValueId, content, ifMatch).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates named value.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/namedValues/{namedValueId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NamedValue_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementNamedValueResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="namedValueId"> Identifier of the NamedValue. </param>
        /// <param name="content"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namedValueId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namedValueId"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<ApiManagementNamedValueResource> CreateOrUpdate(WaitUntil waitUntil, string namedValueId, ApiManagementNamedValueCreateOrUpdateContent content, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namedValueId, nameof(namedValueId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _apiManagementNamedValueNamedValueClientDiagnostics.CreateScope("ApiManagementNamedValueCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiManagementNamedValueNamedValueRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, namedValueId, content, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiManagementNamedValueResource>(new ApiManagementNamedValueOperationSource(Client), _apiManagementNamedValueNamedValueClientDiagnostics, Pipeline, _apiManagementNamedValueNamedValueRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, namedValueId, content, ifMatch).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the details of the named value specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/namedValues/{namedValueId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NamedValue_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementNamedValueResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="namedValueId"> Identifier of the NamedValue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namedValueId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namedValueId"/> is null. </exception>
        public virtual async Task<Response<ApiManagementNamedValueResource>> GetAsync(string namedValueId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namedValueId, nameof(namedValueId));

            using var scope = _apiManagementNamedValueNamedValueClientDiagnostics.CreateScope("ApiManagementNamedValueCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementNamedValueNamedValueRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, namedValueId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementNamedValueResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the named value specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/namedValues/{namedValueId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NamedValue_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementNamedValueResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="namedValueId"> Identifier of the NamedValue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namedValueId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namedValueId"/> is null. </exception>
        public virtual Response<ApiManagementNamedValueResource> Get(string namedValueId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namedValueId, nameof(namedValueId));

            using var scope = _apiManagementNamedValueNamedValueClientDiagnostics.CreateScope("ApiManagementNamedValueCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementNamedValueNamedValueRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, namedValueId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementNamedValueResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a collection of named values defined within a service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/namedValues</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NamedValue_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementNamedValueResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| tags | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith, any, all |&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="isKeyVaultRefreshFailed"> When set to true, the response contains only named value entities which failed refresh. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementNamedValueResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementNamedValueResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, bool? isKeyVaultRefreshFailed = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementNamedValueNamedValueRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, isKeyVaultRefreshFailed);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementNamedValueNamedValueRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, isKeyVaultRefreshFailed);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ApiManagementNamedValueResource(Client, ApiManagementNamedValueData.DeserializeApiManagementNamedValueData(e)), _apiManagementNamedValueNamedValueClientDiagnostics, Pipeline, "ApiManagementNamedValueCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists a collection of named values defined within a service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/namedValues</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NamedValue_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementNamedValueResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| tags | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith, any, all |&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="isKeyVaultRefreshFailed"> When set to true, the response contains only named value entities which failed refresh. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementNamedValueResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementNamedValueResource> GetAll(string filter = null, int? top = null, int? skip = null, bool? isKeyVaultRefreshFailed = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementNamedValueNamedValueRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, isKeyVaultRefreshFailed);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementNamedValueNamedValueRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, isKeyVaultRefreshFailed);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ApiManagementNamedValueResource(Client, ApiManagementNamedValueData.DeserializeApiManagementNamedValueData(e)), _apiManagementNamedValueNamedValueClientDiagnostics, Pipeline, "ApiManagementNamedValueCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/namedValues/{namedValueId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NamedValue_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementNamedValueResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="namedValueId"> Identifier of the NamedValue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namedValueId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namedValueId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string namedValueId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namedValueId, nameof(namedValueId));

            using var scope = _apiManagementNamedValueNamedValueClientDiagnostics.CreateScope("ApiManagementNamedValueCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementNamedValueNamedValueRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, namedValueId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/namedValues/{namedValueId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NamedValue_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementNamedValueResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="namedValueId"> Identifier of the NamedValue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namedValueId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namedValueId"/> is null. </exception>
        public virtual Response<bool> Exists(string namedValueId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namedValueId, nameof(namedValueId));

            using var scope = _apiManagementNamedValueNamedValueClientDiagnostics.CreateScope("ApiManagementNamedValueCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementNamedValueNamedValueRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, namedValueId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/namedValues/{namedValueId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NamedValue_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementNamedValueResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="namedValueId"> Identifier of the NamedValue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namedValueId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namedValueId"/> is null. </exception>
        public virtual async Task<NullableResponse<ApiManagementNamedValueResource>> GetIfExistsAsync(string namedValueId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namedValueId, nameof(namedValueId));

            using var scope = _apiManagementNamedValueNamedValueClientDiagnostics.CreateScope("ApiManagementNamedValueCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _apiManagementNamedValueNamedValueRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, namedValueId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ApiManagementNamedValueResource>(response.GetRawResponse());
                return Response.FromValue(new ApiManagementNamedValueResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/namedValues/{namedValueId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NamedValue_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementNamedValueResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="namedValueId"> Identifier of the NamedValue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namedValueId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namedValueId"/> is null. </exception>
        public virtual NullableResponse<ApiManagementNamedValueResource> GetIfExists(string namedValueId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namedValueId, nameof(namedValueId));

            using var scope = _apiManagementNamedValueNamedValueClientDiagnostics.CreateScope("ApiManagementNamedValueCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _apiManagementNamedValueNamedValueRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, namedValueId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ApiManagementNamedValueResource>(response.GetRawResponse());
                return Response.FromValue(new ApiManagementNamedValueResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiManagementNamedValueResource> IEnumerable<ApiManagementNamedValueResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiManagementNamedValueResource> IAsyncEnumerable<ApiManagementNamedValueResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
