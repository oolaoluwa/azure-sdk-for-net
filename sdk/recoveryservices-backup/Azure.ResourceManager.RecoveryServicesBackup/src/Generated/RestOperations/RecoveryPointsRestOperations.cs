// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.RecoveryServicesBackup.Models;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    internal partial class RecoveryPointsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of RecoveryPointsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public RecoveryPointsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-06-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListRequestUri(string subscriptionId, string resourceGroupName, string vaultName, string fabricName, string containerName, string protectedItemName, string filter)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.RecoveryServices/vaults/", false);
            uri.AppendPath(vaultName, true);
            uri.AppendPath("/backupFabrics/", false);
            uri.AppendPath(fabricName, true);
            uri.AppendPath("/protectionContainers/", false);
            uri.AppendPath(containerName, true);
            uri.AppendPath("/protectedItems/", false);
            uri.AppendPath(protectedItemName, true);
            uri.AppendPath("/recoveryPoints", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            return uri;
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string vaultName, string fabricName, string containerName, string protectedItemName, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.RecoveryServices/vaults/", false);
            uri.AppendPath(vaultName, true);
            uri.AppendPath("/backupFabrics/", false);
            uri.AppendPath(fabricName, true);
            uri.AppendPath("/protectionContainers/", false);
            uri.AppendPath(containerName, true);
            uri.AppendPath("/protectedItems/", false);
            uri.AppendPath(protectedItemName, true);
            uri.AppendPath("/recoveryPoints", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the backup copies for the backed up item. </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name associated with the backed up item. </param>
        /// <param name="containerName"> Container name associated with the backed up item. </param>
        /// <param name="protectedItemName"> Backed up item whose backup copies are to be fetched. </param>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/>, <paramref name="containerName"/> or <paramref name="protectedItemName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/>, <paramref name="containerName"/> or <paramref name="protectedItemName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<RecoveryPointResourceList>> ListAsync(string subscriptionId, string resourceGroupName, string vaultName, string fabricName, string containerName, string protectedItemName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));
            Argument.AssertNotNullOrEmpty(protectedItemName, nameof(protectedItemName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, vaultName, fabricName, containerName, protectedItemName, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RecoveryPointResourceList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RecoveryPointResourceList.DeserializeRecoveryPointResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the backup copies for the backed up item. </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name associated with the backed up item. </param>
        /// <param name="containerName"> Container name associated with the backed up item. </param>
        /// <param name="protectedItemName"> Backed up item whose backup copies are to be fetched. </param>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/>, <paramref name="containerName"/> or <paramref name="protectedItemName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/>, <paramref name="containerName"/> or <paramref name="protectedItemName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<RecoveryPointResourceList> List(string subscriptionId, string resourceGroupName, string vaultName, string fabricName, string containerName, string protectedItemName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));
            Argument.AssertNotNullOrEmpty(protectedItemName, nameof(protectedItemName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, vaultName, fabricName, containerName, protectedItemName, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RecoveryPointResourceList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RecoveryPointResourceList.DeserializeRecoveryPointResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string vaultName, string fabricName, string containerName, string protectedItemName, string recoveryPointId)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.RecoveryServices/vaults/", false);
            uri.AppendPath(vaultName, true);
            uri.AppendPath("/backupFabrics/", false);
            uri.AppendPath(fabricName, true);
            uri.AppendPath("/protectionContainers/", false);
            uri.AppendPath(containerName, true);
            uri.AppendPath("/protectedItems/", false);
            uri.AppendPath(protectedItemName, true);
            uri.AppendPath("/recoveryPoints/", false);
            uri.AppendPath(recoveryPointId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string vaultName, string fabricName, string containerName, string protectedItemName, string recoveryPointId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.RecoveryServices/vaults/", false);
            uri.AppendPath(vaultName, true);
            uri.AppendPath("/backupFabrics/", false);
            uri.AppendPath(fabricName, true);
            uri.AppendPath("/protectionContainers/", false);
            uri.AppendPath(containerName, true);
            uri.AppendPath("/protectedItems/", false);
            uri.AppendPath(protectedItemName, true);
            uri.AppendPath("/recoveryPoints/", false);
            uri.AppendPath(recoveryPointId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary>
        /// Provides the information of the backed up data identified using RecoveryPointID. This is an asynchronous operation.
        /// To know the status of the operation, call the GetProtectedItemOperationResult API.
        /// </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name associated with backed up item. </param>
        /// <param name="containerName"> Container name associated with backed up item. </param>
        /// <param name="protectedItemName"> Backed up item name whose backup data needs to be fetched. </param>
        /// <param name="recoveryPointId"> RecoveryPointID represents the backed up data to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/>, <paramref name="containerName"/>, <paramref name="protectedItemName"/> or <paramref name="recoveryPointId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/>, <paramref name="containerName"/>, <paramref name="protectedItemName"/> or <paramref name="recoveryPointId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<BackupRecoveryPointData>> GetAsync(string subscriptionId, string resourceGroupName, string vaultName, string fabricName, string containerName, string protectedItemName, string recoveryPointId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));
            Argument.AssertNotNullOrEmpty(protectedItemName, nameof(protectedItemName));
            Argument.AssertNotNullOrEmpty(recoveryPointId, nameof(recoveryPointId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, vaultName, fabricName, containerName, protectedItemName, recoveryPointId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BackupRecoveryPointData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = BackupRecoveryPointData.DeserializeBackupRecoveryPointData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((BackupRecoveryPointData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary>
        /// Provides the information of the backed up data identified using RecoveryPointID. This is an asynchronous operation.
        /// To know the status of the operation, call the GetProtectedItemOperationResult API.
        /// </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name associated with backed up item. </param>
        /// <param name="containerName"> Container name associated with backed up item. </param>
        /// <param name="protectedItemName"> Backed up item name whose backup data needs to be fetched. </param>
        /// <param name="recoveryPointId"> RecoveryPointID represents the backed up data to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/>, <paramref name="containerName"/>, <paramref name="protectedItemName"/> or <paramref name="recoveryPointId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/>, <paramref name="containerName"/>, <paramref name="protectedItemName"/> or <paramref name="recoveryPointId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<BackupRecoveryPointData> Get(string subscriptionId, string resourceGroupName, string vaultName, string fabricName, string containerName, string protectedItemName, string recoveryPointId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));
            Argument.AssertNotNullOrEmpty(protectedItemName, nameof(protectedItemName));
            Argument.AssertNotNullOrEmpty(recoveryPointId, nameof(recoveryPointId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, vaultName, fabricName, containerName, protectedItemName, recoveryPointId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BackupRecoveryPointData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = BackupRecoveryPointData.DeserializeBackupRecoveryPointData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((BackupRecoveryPointData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string vaultName, string fabricName, string containerName, string protectedItemName, string filter)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string vaultName, string fabricName, string containerName, string protectedItemName, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the backup copies for the backed up item. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name associated with the backed up item. </param>
        /// <param name="containerName"> Container name associated with the backed up item. </param>
        /// <param name="protectedItemName"> Backed up item whose backup copies are to be fetched. </param>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/>, <paramref name="containerName"/> or <paramref name="protectedItemName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/>, <paramref name="containerName"/> or <paramref name="protectedItemName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<RecoveryPointResourceList>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string vaultName, string fabricName, string containerName, string protectedItemName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));
            Argument.AssertNotNullOrEmpty(protectedItemName, nameof(protectedItemName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, vaultName, fabricName, containerName, protectedItemName, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RecoveryPointResourceList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RecoveryPointResourceList.DeserializeRecoveryPointResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the backup copies for the backed up item. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name associated with the backed up item. </param>
        /// <param name="containerName"> Container name associated with the backed up item. </param>
        /// <param name="protectedItemName"> Backed up item whose backup copies are to be fetched. </param>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/>, <paramref name="containerName"/> or <paramref name="protectedItemName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/>, <paramref name="containerName"/> or <paramref name="protectedItemName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<RecoveryPointResourceList> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string vaultName, string fabricName, string containerName, string protectedItemName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));
            Argument.AssertNotNullOrEmpty(protectedItemName, nameof(protectedItemName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, vaultName, fabricName, containerName, protectedItemName, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RecoveryPointResourceList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RecoveryPointResourceList.DeserializeRecoveryPointResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
