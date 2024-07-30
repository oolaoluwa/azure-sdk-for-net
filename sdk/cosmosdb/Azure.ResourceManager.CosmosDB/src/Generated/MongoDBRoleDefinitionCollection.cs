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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="MongoDBRoleDefinitionResource"/> and their operations.
    /// Each <see cref="MongoDBRoleDefinitionResource"/> in the collection will belong to the same instance of <see cref="CosmosDBAccountResource"/>.
    /// To get a <see cref="MongoDBRoleDefinitionCollection"/> instance call the GetMongoDBRoleDefinitions method from an instance of <see cref="CosmosDBAccountResource"/>.
    /// </summary>
    public partial class MongoDBRoleDefinitionCollection : ArmCollection, IEnumerable<MongoDBRoleDefinitionResource>, IAsyncEnumerable<MongoDBRoleDefinitionResource>
    {
        private readonly ClientDiagnostics _mongoDBRoleDefinitionMongoDBResourcesClientDiagnostics;
        private readonly MongoDBResourcesRestOperations _mongoDBRoleDefinitionMongoDBResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MongoDBRoleDefinitionCollection"/> class for mocking. </summary>
        protected MongoDBRoleDefinitionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MongoDBRoleDefinitionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MongoDBRoleDefinitionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mongoDBRoleDefinitionMongoDBResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", MongoDBRoleDefinitionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MongoDBRoleDefinitionResource.ResourceType, out string mongoDBRoleDefinitionMongoDBResourcesApiVersion);
            _mongoDBRoleDefinitionMongoDBResourcesRestClient = new MongoDBResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mongoDBRoleDefinitionMongoDBResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CosmosDBAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CosmosDBAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an Azure Cosmos DB Mongo Role Definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbRoleDefinitions/{mongoRoleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_CreateUpdateMongoRoleDefinition</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="mongoRoleDefinitionId"> The ID for the Role Definition {dbName.roleName}. </param>
        /// <param name="content"> The properties required to create or update a Role Definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mongoRoleDefinitionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mongoRoleDefinitionId"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<MongoDBRoleDefinitionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string mongoRoleDefinitionId, MongoDBRoleDefinitionCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mongoRoleDefinitionId, nameof(mongoRoleDefinitionId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _mongoDBRoleDefinitionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBRoleDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mongoDBRoleDefinitionMongoDBResourcesRestClient.CreateUpdateMongoRoleDefinitionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, mongoRoleDefinitionId, content, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<MongoDBRoleDefinitionResource>(new MongoDBRoleDefinitionOperationSource(Client), _mongoDBRoleDefinitionMongoDBResourcesClientDiagnostics, Pipeline, _mongoDBRoleDefinitionMongoDBResourcesRestClient.CreateCreateUpdateMongoRoleDefinitionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, mongoRoleDefinitionId, content).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an Azure Cosmos DB Mongo Role Definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbRoleDefinitions/{mongoRoleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_CreateUpdateMongoRoleDefinition</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="mongoRoleDefinitionId"> The ID for the Role Definition {dbName.roleName}. </param>
        /// <param name="content"> The properties required to create or update a Role Definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mongoRoleDefinitionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mongoRoleDefinitionId"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<MongoDBRoleDefinitionResource> CreateOrUpdate(WaitUntil waitUntil, string mongoRoleDefinitionId, MongoDBRoleDefinitionCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mongoRoleDefinitionId, nameof(mongoRoleDefinitionId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _mongoDBRoleDefinitionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBRoleDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mongoDBRoleDefinitionMongoDBResourcesRestClient.CreateUpdateMongoRoleDefinition(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, mongoRoleDefinitionId, content, cancellationToken);
                var operation = new CosmosDBArmOperation<MongoDBRoleDefinitionResource>(new MongoDBRoleDefinitionOperationSource(Client), _mongoDBRoleDefinitionMongoDBResourcesClientDiagnostics, Pipeline, _mongoDBRoleDefinitionMongoDBResourcesRestClient.CreateCreateUpdateMongoRoleDefinitionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, mongoRoleDefinitionId, content).Request, response, OperationFinalStateVia.Location);
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
        /// Retrieves the properties of an existing Azure Cosmos DB Mongo Role Definition with the given Id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbRoleDefinitions/{mongoRoleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_GetMongoRoleDefinition</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mongoRoleDefinitionId"> The ID for the Role Definition {dbName.roleName}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mongoRoleDefinitionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mongoRoleDefinitionId"/> is null. </exception>
        public virtual async Task<Response<MongoDBRoleDefinitionResource>> GetAsync(string mongoRoleDefinitionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mongoRoleDefinitionId, nameof(mongoRoleDefinitionId));

            using var scope = _mongoDBRoleDefinitionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBRoleDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = await _mongoDBRoleDefinitionMongoDBResourcesRestClient.GetMongoRoleDefinitionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, mongoRoleDefinitionId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MongoDBRoleDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the properties of an existing Azure Cosmos DB Mongo Role Definition with the given Id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbRoleDefinitions/{mongoRoleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_GetMongoRoleDefinition</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mongoRoleDefinitionId"> The ID for the Role Definition {dbName.roleName}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mongoRoleDefinitionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mongoRoleDefinitionId"/> is null. </exception>
        public virtual Response<MongoDBRoleDefinitionResource> Get(string mongoRoleDefinitionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mongoRoleDefinitionId, nameof(mongoRoleDefinitionId));

            using var scope = _mongoDBRoleDefinitionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBRoleDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = _mongoDBRoleDefinitionMongoDBResourcesRestClient.GetMongoRoleDefinition(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, mongoRoleDefinitionId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MongoDBRoleDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the list of all Azure Cosmos DB Mongo Role Definitions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbRoleDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_ListMongoRoleDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MongoDBRoleDefinitionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MongoDBRoleDefinitionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mongoDBRoleDefinitionMongoDBResourcesRestClient.CreateListMongoRoleDefinitionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new MongoDBRoleDefinitionResource(Client, MongoDBRoleDefinitionData.DeserializeMongoDBRoleDefinitionData(e)), _mongoDBRoleDefinitionMongoDBResourcesClientDiagnostics, Pipeline, "MongoDBRoleDefinitionCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Retrieves the list of all Azure Cosmos DB Mongo Role Definitions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbRoleDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_ListMongoRoleDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MongoDBRoleDefinitionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MongoDBRoleDefinitionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mongoDBRoleDefinitionMongoDBResourcesRestClient.CreateListMongoRoleDefinitionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new MongoDBRoleDefinitionResource(Client, MongoDBRoleDefinitionData.DeserializeMongoDBRoleDefinitionData(e)), _mongoDBRoleDefinitionMongoDBResourcesClientDiagnostics, Pipeline, "MongoDBRoleDefinitionCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbRoleDefinitions/{mongoRoleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_GetMongoRoleDefinition</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mongoRoleDefinitionId"> The ID for the Role Definition {dbName.roleName}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mongoRoleDefinitionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mongoRoleDefinitionId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string mongoRoleDefinitionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mongoRoleDefinitionId, nameof(mongoRoleDefinitionId));

            using var scope = _mongoDBRoleDefinitionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBRoleDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mongoDBRoleDefinitionMongoDBResourcesRestClient.GetMongoRoleDefinitionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, mongoRoleDefinitionId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbRoleDefinitions/{mongoRoleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_GetMongoRoleDefinition</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mongoRoleDefinitionId"> The ID for the Role Definition {dbName.roleName}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mongoRoleDefinitionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mongoRoleDefinitionId"/> is null. </exception>
        public virtual Response<bool> Exists(string mongoRoleDefinitionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mongoRoleDefinitionId, nameof(mongoRoleDefinitionId));

            using var scope = _mongoDBRoleDefinitionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBRoleDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = _mongoDBRoleDefinitionMongoDBResourcesRestClient.GetMongoRoleDefinition(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, mongoRoleDefinitionId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbRoleDefinitions/{mongoRoleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_GetMongoRoleDefinition</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mongoRoleDefinitionId"> The ID for the Role Definition {dbName.roleName}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mongoRoleDefinitionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mongoRoleDefinitionId"/> is null. </exception>
        public virtual async Task<NullableResponse<MongoDBRoleDefinitionResource>> GetIfExistsAsync(string mongoRoleDefinitionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mongoRoleDefinitionId, nameof(mongoRoleDefinitionId));

            using var scope = _mongoDBRoleDefinitionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBRoleDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _mongoDBRoleDefinitionMongoDBResourcesRestClient.GetMongoRoleDefinitionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, mongoRoleDefinitionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MongoDBRoleDefinitionResource>(response.GetRawResponse());
                return Response.FromValue(new MongoDBRoleDefinitionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbRoleDefinitions/{mongoRoleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_GetMongoRoleDefinition</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mongoRoleDefinitionId"> The ID for the Role Definition {dbName.roleName}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mongoRoleDefinitionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mongoRoleDefinitionId"/> is null. </exception>
        public virtual NullableResponse<MongoDBRoleDefinitionResource> GetIfExists(string mongoRoleDefinitionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mongoRoleDefinitionId, nameof(mongoRoleDefinitionId));

            using var scope = _mongoDBRoleDefinitionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBRoleDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _mongoDBRoleDefinitionMongoDBResourcesRestClient.GetMongoRoleDefinition(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, mongoRoleDefinitionId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MongoDBRoleDefinitionResource>(response.GetRawResponse());
                return Response.FromValue(new MongoDBRoleDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MongoDBRoleDefinitionResource> IEnumerable<MongoDBRoleDefinitionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MongoDBRoleDefinitionResource> IAsyncEnumerable<MongoDBRoleDefinitionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
