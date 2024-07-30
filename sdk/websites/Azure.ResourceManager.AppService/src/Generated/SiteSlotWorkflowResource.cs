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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a SiteSlotWorkflow along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SiteSlotWorkflowResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSiteSlotWorkflowResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteSlotResource"/> using the GetSiteSlotWorkflow method.
    /// </summary>
    public partial class SiteSlotWorkflowResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteSlotWorkflowResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="name"> The name. </param>
        /// <param name="slot"> The slot. </param>
        /// <param name="workflowName"> The workflowName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string workflowName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/workflows/{workflowName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteSlotWorkflowWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotWorkflowWebAppsRestClient;
        private readonly WorkflowEnvelopeData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/workflows";

        /// <summary> Initializes a new instance of the <see cref="SiteSlotWorkflowResource"/> class for mocking. </summary>
        protected SiteSlotWorkflowResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotWorkflowResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteSlotWorkflowResource(ArmClient client, WorkflowEnvelopeData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotWorkflowResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteSlotWorkflowResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotWorkflowWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteSlotWorkflowWebAppsApiVersion);
            _siteSlotWorkflowWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotWorkflowWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual WorkflowEnvelopeData Data
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
        /// Get workflow information by its ID for web site, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/workflows/{workflowName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetInstanceWorkflowSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotWorkflowResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteSlotWorkflowResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotWorkflowWebAppsClientDiagnostics.CreateScope("SiteSlotWorkflowResource.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotWorkflowWebAppsRestClient.GetInstanceWorkflowSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotWorkflowResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get workflow information by its ID for web site, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/workflows/{workflowName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetInstanceWorkflowSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteSlotWorkflowResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteSlotWorkflowResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotWorkflowWebAppsClientDiagnostics.CreateScope("SiteSlotWorkflowResource.Get");
            scope.Start();
            try
            {
                var response = _siteSlotWorkflowWebAppsRestClient.GetInstanceWorkflowSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotWorkflowResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
