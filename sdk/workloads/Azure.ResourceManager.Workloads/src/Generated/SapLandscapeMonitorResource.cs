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

namespace Azure.ResourceManager.Workloads
{
    /// <summary>
    /// A Class representing a SapLandscapeMonitor along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SapLandscapeMonitorResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSapLandscapeMonitorResource method.
    /// Otherwise you can get one from its parent resource <see cref="SapMonitorResource"/> using the GetSapLandscapeMonitor method.
    /// </summary>
    public partial class SapLandscapeMonitorResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SapLandscapeMonitorResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="monitorName"> The monitorName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string monitorName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/monitors/{monitorName}/sapLandscapeMonitor/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sapLandscapeMonitorClientDiagnostics;
        private readonly SapLandscapeMonitorRestOperations _sapLandscapeMonitorRestClient;
        private readonly SapLandscapeMonitorData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Workloads/monitors/sapLandscapeMonitor";

        /// <summary> Initializes a new instance of the <see cref="SapLandscapeMonitorResource"/> class for mocking. </summary>
        protected SapLandscapeMonitorResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SapLandscapeMonitorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SapLandscapeMonitorResource(ArmClient client, SapLandscapeMonitorData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SapLandscapeMonitorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SapLandscapeMonitorResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sapLandscapeMonitorClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Workloads", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sapLandscapeMonitorApiVersion);
            _sapLandscapeMonitorRestClient = new SapLandscapeMonitorRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sapLandscapeMonitorApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SapLandscapeMonitorData Data
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
        /// Gets configuration values for Single Pane Of Glass for SAP monitor for the specified subscription, resource group, and resource name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/monitors/{monitorName}/sapLandscapeMonitor/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SapLandscapeMonitor_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapLandscapeMonitorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SapLandscapeMonitorResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sapLandscapeMonitorClientDiagnostics.CreateScope("SapLandscapeMonitorResource.Get");
            scope.Start();
            try
            {
                var response = await _sapLandscapeMonitorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SapLandscapeMonitorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets configuration values for Single Pane Of Glass for SAP monitor for the specified subscription, resource group, and resource name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/monitors/{monitorName}/sapLandscapeMonitor/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SapLandscapeMonitor_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapLandscapeMonitorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SapLandscapeMonitorResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sapLandscapeMonitorClientDiagnostics.CreateScope("SapLandscapeMonitorResource.Get");
            scope.Start();
            try
            {
                var response = _sapLandscapeMonitorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SapLandscapeMonitorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a SAP Landscape Monitor Dashboard with the specified subscription, resource group, and SAP monitor name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/monitors/{monitorName}/sapLandscapeMonitor/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SapLandscapeMonitor_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapLandscapeMonitorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _sapLandscapeMonitorClientDiagnostics.CreateScope("SapLandscapeMonitorResource.Delete");
            scope.Start();
            try
            {
                var response = await _sapLandscapeMonitorRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                var uri = _sapLandscapeMonitorRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new WorkloadsArmOperation(response, rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a SAP Landscape Monitor Dashboard with the specified subscription, resource group, and SAP monitor name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/monitors/{monitorName}/sapLandscapeMonitor/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SapLandscapeMonitor_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapLandscapeMonitorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _sapLandscapeMonitorClientDiagnostics.CreateScope("SapLandscapeMonitorResource.Delete");
            scope.Start();
            try
            {
                var response = _sapLandscapeMonitorRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                var uri = _sapLandscapeMonitorRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new WorkloadsArmOperation(response, rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Patches the SAP Landscape Monitor Dashboard for the specified subscription, resource group, and SAP monitor name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/monitors/{monitorName}/sapLandscapeMonitor/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SapLandscapeMonitor_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapLandscapeMonitorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> Request body representing a configuration for Sap Landscape Monitor Dashboard. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<SapLandscapeMonitorResource>> UpdateAsync(SapLandscapeMonitorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sapLandscapeMonitorClientDiagnostics.CreateScope("SapLandscapeMonitorResource.Update");
            scope.Start();
            try
            {
                var response = await _sapLandscapeMonitorRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SapLandscapeMonitorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Patches the SAP Landscape Monitor Dashboard for the specified subscription, resource group, and SAP monitor name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/monitors/{monitorName}/sapLandscapeMonitor/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SapLandscapeMonitor_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapLandscapeMonitorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> Request body representing a configuration for Sap Landscape Monitor Dashboard. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<SapLandscapeMonitorResource> Update(SapLandscapeMonitorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sapLandscapeMonitorClientDiagnostics.CreateScope("SapLandscapeMonitorResource.Update");
            scope.Start();
            try
            {
                var response = _sapLandscapeMonitorRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken);
                return Response.FromValue(new SapLandscapeMonitorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a SAP Landscape Monitor Dashboard for the specified subscription, resource group, and resource name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/monitors/{monitorName}/sapLandscapeMonitor/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SapLandscapeMonitor_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapLandscapeMonitorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Request body representing a configuration for Sap Landscape Monitor Dashboard. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SapLandscapeMonitorResource>> CreateOrUpdateAsync(WaitUntil waitUntil, SapLandscapeMonitorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sapLandscapeMonitorClientDiagnostics.CreateScope("SapLandscapeMonitorResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sapLandscapeMonitorRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                var uri = _sapLandscapeMonitorRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new WorkloadsArmOperation<SapLandscapeMonitorResource>(Response.FromValue(new SapLandscapeMonitorResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Creates a SAP Landscape Monitor Dashboard for the specified subscription, resource group, and resource name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/monitors/{monitorName}/sapLandscapeMonitor/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SapLandscapeMonitor_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapLandscapeMonitorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Request body representing a configuration for Sap Landscape Monitor Dashboard. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SapLandscapeMonitorResource> CreateOrUpdate(WaitUntil waitUntil, SapLandscapeMonitorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sapLandscapeMonitorClientDiagnostics.CreateScope("SapLandscapeMonitorResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sapLandscapeMonitorRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken);
                var uri = _sapLandscapeMonitorRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new WorkloadsArmOperation<SapLandscapeMonitorResource>(Response.FromValue(new SapLandscapeMonitorResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
    }
}
