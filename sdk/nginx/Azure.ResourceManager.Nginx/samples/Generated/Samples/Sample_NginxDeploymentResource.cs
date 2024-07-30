// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Nginx.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Nginx.Samples
{
    public partial class Sample_NginxDeploymentResource
    {
        // Deployments_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_DeploymentsGet()
        {
            // Generated from example definition: specification/nginx/resource-manager/NGINX.NGINXPLUS/preview/2024-01-01-preview/examples/Deployments_Get.json
            // this example is just showing the usage of "Deployments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NginxDeploymentResource created on azure
            // for more information of creating NginxDeploymentResource, please refer to the document of NginxDeploymentResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string deploymentName = "myDeployment";
            ResourceIdentifier nginxDeploymentResourceId = NginxDeploymentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deploymentName);
            NginxDeploymentResource nginxDeployment = client.GetNginxDeploymentResource(nginxDeploymentResourceId);

            // invoke the operation
            NginxDeploymentResource result = await nginxDeployment.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NginxDeploymentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Deployments_Get_AutoScale
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_DeploymentsGetAutoScale()
        {
            // Generated from example definition: specification/nginx/resource-manager/NGINX.NGINXPLUS/preview/2024-01-01-preview/examples/Deployments_Get_AutoScale.json
            // this example is just showing the usage of "Deployments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NginxDeploymentResource created on azure
            // for more information of creating NginxDeploymentResource, please refer to the document of NginxDeploymentResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string deploymentName = "myDeployment";
            ResourceIdentifier nginxDeploymentResourceId = NginxDeploymentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deploymentName);
            NginxDeploymentResource nginxDeployment = client.GetNginxDeploymentResource(nginxDeploymentResourceId);

            // invoke the operation
            NginxDeploymentResource result = await nginxDeployment.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NginxDeploymentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Deployments_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_DeploymentsUpdate()
        {
            // Generated from example definition: specification/nginx/resource-manager/NGINX.NGINXPLUS/preview/2024-01-01-preview/examples/Deployments_Update.json
            // this example is just showing the usage of "Deployments_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NginxDeploymentResource created on azure
            // for more information of creating NginxDeploymentResource, please refer to the document of NginxDeploymentResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string deploymentName = "myDeployment";
            ResourceIdentifier nginxDeploymentResourceId = NginxDeploymentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deploymentName);
            NginxDeploymentResource nginxDeployment = client.GetNginxDeploymentResource(nginxDeploymentResourceId);

            // invoke the operation
            NginxDeploymentPatch patch = new NginxDeploymentPatch()
            {
                Tags =
{
["Environment"] = "Dev",
},
            };
            ArmOperation<NginxDeploymentResource> lro = await nginxDeployment.UpdateAsync(WaitUntil.Completed, patch);
            NginxDeploymentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NginxDeploymentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Deployments_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeploymentsDelete()
        {
            // Generated from example definition: specification/nginx/resource-manager/NGINX.NGINXPLUS/preview/2024-01-01-preview/examples/Deployments_Delete.json
            // this example is just showing the usage of "Deployments_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NginxDeploymentResource created on azure
            // for more information of creating NginxDeploymentResource, please refer to the document of NginxDeploymentResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string deploymentName = "myDeployment";
            ResourceIdentifier nginxDeploymentResourceId = NginxDeploymentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deploymentName);
            NginxDeploymentResource nginxDeployment = client.GetNginxDeploymentResource(nginxDeploymentResourceId);

            // invoke the operation
            await nginxDeployment.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Deployments_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetNginxDeployments_DeploymentsList()
        {
            // Generated from example definition: specification/nginx/resource-manager/NGINX.NGINXPLUS/preview/2024-01-01-preview/examples/Deployments_List.json
            // this example is just showing the usage of "Deployments_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (NginxDeploymentResource item in subscriptionResource.GetNginxDeploymentsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NginxDeploymentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
