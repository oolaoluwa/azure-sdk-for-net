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
using Azure.ResourceManager.DesktopVirtualization.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    internal partial class DesktopsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of DesktopsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public DesktopsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-09-05";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string applicationGroupName, string desktopName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DesktopVirtualization/applicationGroups/", false);
            uri.AppendPath(applicationGroupName, true);
            uri.AppendPath("/desktops/", false);
            uri.AppendPath(desktopName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string applicationGroupName, string desktopName)
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
            uri.AppendPath("/providers/Microsoft.DesktopVirtualization/applicationGroups/", false);
            uri.AppendPath(applicationGroupName, true);
            uri.AppendPath("/desktops/", false);
            uri.AppendPath(desktopName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a desktop. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="applicationGroupName"> The name of the application group. </param>
        /// <param name="desktopName"> The name of the desktop within the specified desktop group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="applicationGroupName"/> or <paramref name="desktopName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="applicationGroupName"/> or <paramref name="desktopName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<VirtualDesktopData>> GetAsync(string subscriptionId, string resourceGroupName, string applicationGroupName, string desktopName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(applicationGroupName, nameof(applicationGroupName));
            Argument.AssertNotNullOrEmpty(desktopName, nameof(desktopName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, applicationGroupName, desktopName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualDesktopData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VirtualDesktopData.DeserializeVirtualDesktopData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((VirtualDesktopData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a desktop. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="applicationGroupName"> The name of the application group. </param>
        /// <param name="desktopName"> The name of the desktop within the specified desktop group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="applicationGroupName"/> or <paramref name="desktopName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="applicationGroupName"/> or <paramref name="desktopName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<VirtualDesktopData> Get(string subscriptionId, string resourceGroupName, string applicationGroupName, string desktopName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(applicationGroupName, nameof(applicationGroupName));
            Argument.AssertNotNullOrEmpty(desktopName, nameof(desktopName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, applicationGroupName, desktopName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualDesktopData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VirtualDesktopData.DeserializeVirtualDesktopData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((VirtualDesktopData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateUpdateRequestUri(string subscriptionId, string resourceGroupName, string applicationGroupName, string desktopName, VirtualDesktopPatch patch)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DesktopVirtualization/applicationGroups/", false);
            uri.AppendPath(applicationGroupName, true);
            uri.AppendPath("/desktops/", false);
            uri.AppendPath(desktopName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateUpdateRequest(string subscriptionId, string resourceGroupName, string applicationGroupName, string desktopName, VirtualDesktopPatch patch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DesktopVirtualization/applicationGroups/", false);
            uri.AppendPath(applicationGroupName, true);
            uri.AppendPath("/desktops/", false);
            uri.AppendPath(desktopName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(patch, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Update a desktop. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="applicationGroupName"> The name of the application group. </param>
        /// <param name="desktopName"> The name of the desktop within the specified desktop group. </param>
        /// <param name="patch"> Object containing Desktop definitions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="applicationGroupName"/>, <paramref name="desktopName"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="applicationGroupName"/> or <paramref name="desktopName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<VirtualDesktopData>> UpdateAsync(string subscriptionId, string resourceGroupName, string applicationGroupName, string desktopName, VirtualDesktopPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(applicationGroupName, nameof(applicationGroupName));
            Argument.AssertNotNullOrEmpty(desktopName, nameof(desktopName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, applicationGroupName, desktopName, patch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualDesktopData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VirtualDesktopData.DeserializeVirtualDesktopData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Update a desktop. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="applicationGroupName"> The name of the application group. </param>
        /// <param name="desktopName"> The name of the desktop within the specified desktop group. </param>
        /// <param name="patch"> Object containing Desktop definitions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="applicationGroupName"/>, <paramref name="desktopName"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="applicationGroupName"/> or <paramref name="desktopName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<VirtualDesktopData> Update(string subscriptionId, string resourceGroupName, string applicationGroupName, string desktopName, VirtualDesktopPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(applicationGroupName, nameof(applicationGroupName));
            Argument.AssertNotNullOrEmpty(desktopName, nameof(desktopName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, applicationGroupName, desktopName, patch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualDesktopData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VirtualDesktopData.DeserializeVirtualDesktopData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListRequestUri(string subscriptionId, string resourceGroupName, string applicationGroupName, int? pageSize, bool? isDescending, int? initialSkip)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DesktopVirtualization/applicationGroups/", false);
            uri.AppendPath(applicationGroupName, true);
            uri.AppendPath("/desktops", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (pageSize != null)
            {
                uri.AppendQuery("pageSize", pageSize.Value, true);
            }
            if (isDescending != null)
            {
                uri.AppendQuery("isDescending", isDescending.Value, true);
            }
            if (initialSkip != null)
            {
                uri.AppendQuery("initialSkip", initialSkip.Value, true);
            }
            return uri;
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string applicationGroupName, int? pageSize, bool? isDescending, int? initialSkip)
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
            uri.AppendPath("/providers/Microsoft.DesktopVirtualization/applicationGroups/", false);
            uri.AppendPath(applicationGroupName, true);
            uri.AppendPath("/desktops", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (pageSize != null)
            {
                uri.AppendQuery("pageSize", pageSize.Value, true);
            }
            if (isDescending != null)
            {
                uri.AppendQuery("isDescending", isDescending.Value, true);
            }
            if (initialSkip != null)
            {
                uri.AppendQuery("initialSkip", initialSkip.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List desktops. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="applicationGroupName"> The name of the application group. </param>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="applicationGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="applicationGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DesktopList>> ListAsync(string subscriptionId, string resourceGroupName, string applicationGroupName, int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(applicationGroupName, nameof(applicationGroupName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, applicationGroupName, pageSize, isDescending, initialSkip);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DesktopList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DesktopList.DeserializeDesktopList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List desktops. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="applicationGroupName"> The name of the application group. </param>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="applicationGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="applicationGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DesktopList> List(string subscriptionId, string resourceGroupName, string applicationGroupName, int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(applicationGroupName, nameof(applicationGroupName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, applicationGroupName, pageSize, isDescending, initialSkip);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DesktopList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DesktopList.DeserializeDesktopList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string applicationGroupName, int? pageSize, bool? isDescending, int? initialSkip)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string applicationGroupName, int? pageSize, bool? isDescending, int? initialSkip)
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

        /// <summary> List desktops. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="applicationGroupName"> The name of the application group. </param>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="applicationGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="applicationGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DesktopList>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string applicationGroupName, int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(applicationGroupName, nameof(applicationGroupName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, applicationGroupName, pageSize, isDescending, initialSkip);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DesktopList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DesktopList.DeserializeDesktopList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List desktops. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="applicationGroupName"> The name of the application group. </param>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="applicationGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="applicationGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DesktopList> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string applicationGroupName, int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(applicationGroupName, nameof(applicationGroupName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, applicationGroupName, pageSize, isDescending, initialSkip);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DesktopList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DesktopList.DeserializeDesktopList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
