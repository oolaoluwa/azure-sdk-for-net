// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Samples
{
    public partial class Sample_ServiceFabricManagedApplicationTypeVersionCollection
    {
        // Get an application type version
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAnApplicationTypeVersion()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/stable/2024-04-01/examples/ApplicationTypeVersionGetOperation_example.json
            // this example is just showing the usage of "ApplicationTypeVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedApplicationTypeResource created on azure
            // for more information of creating ServiceFabricManagedApplicationTypeResource, please refer to the document of ServiceFabricManagedApplicationTypeResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationTypeName = "myAppType";
            ResourceIdentifier serviceFabricManagedApplicationTypeResourceId = ServiceFabricManagedApplicationTypeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationTypeName);
            ServiceFabricManagedApplicationTypeResource serviceFabricManagedApplicationType = client.GetServiceFabricManagedApplicationTypeResource(serviceFabricManagedApplicationTypeResourceId);

            // get the collection of this ServiceFabricManagedApplicationTypeVersionResource
            ServiceFabricManagedApplicationTypeVersionCollection collection = serviceFabricManagedApplicationType.GetServiceFabricManagedApplicationTypeVersions();

            // invoke the operation
            string version = "1.0";
            ServiceFabricManagedApplicationTypeVersionResource result = await collection.GetAsync(version);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricManagedApplicationTypeVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get an application type version
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAnApplicationTypeVersion()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/stable/2024-04-01/examples/ApplicationTypeVersionGetOperation_example.json
            // this example is just showing the usage of "ApplicationTypeVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedApplicationTypeResource created on azure
            // for more information of creating ServiceFabricManagedApplicationTypeResource, please refer to the document of ServiceFabricManagedApplicationTypeResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationTypeName = "myAppType";
            ResourceIdentifier serviceFabricManagedApplicationTypeResourceId = ServiceFabricManagedApplicationTypeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationTypeName);
            ServiceFabricManagedApplicationTypeResource serviceFabricManagedApplicationType = client.GetServiceFabricManagedApplicationTypeResource(serviceFabricManagedApplicationTypeResourceId);

            // get the collection of this ServiceFabricManagedApplicationTypeVersionResource
            ServiceFabricManagedApplicationTypeVersionCollection collection = serviceFabricManagedApplicationType.GetServiceFabricManagedApplicationTypeVersions();

            // invoke the operation
            string version = "1.0";
            bool result = await collection.ExistsAsync(version);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get an application type version
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAnApplicationTypeVersion()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/stable/2024-04-01/examples/ApplicationTypeVersionGetOperation_example.json
            // this example is just showing the usage of "ApplicationTypeVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedApplicationTypeResource created on azure
            // for more information of creating ServiceFabricManagedApplicationTypeResource, please refer to the document of ServiceFabricManagedApplicationTypeResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationTypeName = "myAppType";
            ResourceIdentifier serviceFabricManagedApplicationTypeResourceId = ServiceFabricManagedApplicationTypeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationTypeName);
            ServiceFabricManagedApplicationTypeResource serviceFabricManagedApplicationType = client.GetServiceFabricManagedApplicationTypeResource(serviceFabricManagedApplicationTypeResourceId);

            // get the collection of this ServiceFabricManagedApplicationTypeVersionResource
            ServiceFabricManagedApplicationTypeVersionCollection collection = serviceFabricManagedApplicationType.GetServiceFabricManagedApplicationTypeVersions();

            // invoke the operation
            string version = "1.0";
            NullableResponse<ServiceFabricManagedApplicationTypeVersionResource> response = await collection.GetIfExistsAsync(version);
            ServiceFabricManagedApplicationTypeVersionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceFabricManagedApplicationTypeVersionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Put an application type version
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PutAnApplicationTypeVersion()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/stable/2024-04-01/examples/ApplicationTypeVersionPutOperation_example.json
            // this example is just showing the usage of "ApplicationTypeVersions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedApplicationTypeResource created on azure
            // for more information of creating ServiceFabricManagedApplicationTypeResource, please refer to the document of ServiceFabricManagedApplicationTypeResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationTypeName = "myAppType";
            ResourceIdentifier serviceFabricManagedApplicationTypeResourceId = ServiceFabricManagedApplicationTypeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationTypeName);
            ServiceFabricManagedApplicationTypeResource serviceFabricManagedApplicationType = client.GetServiceFabricManagedApplicationTypeResource(serviceFabricManagedApplicationTypeResourceId);

            // get the collection of this ServiceFabricManagedApplicationTypeVersionResource
            ServiceFabricManagedApplicationTypeVersionCollection collection = serviceFabricManagedApplicationType.GetServiceFabricManagedApplicationTypeVersions();

            // invoke the operation
            string version = "1.0";
            ServiceFabricManagedApplicationTypeVersionData data = new ServiceFabricManagedApplicationTypeVersionData(new AzureLocation("eastus"))
            {
                AppPackageUri = new Uri("http://fakelink.test.com/MyAppType"),
            };
            ArmOperation<ServiceFabricManagedApplicationTypeVersionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, version, data);
            ServiceFabricManagedApplicationTypeVersionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricManagedApplicationTypeVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a list of application type version resources
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetAListOfApplicationTypeVersionResources()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/stable/2024-04-01/examples/ApplicationTypeVersionListOperation_example.json
            // this example is just showing the usage of "ApplicationTypeVersions_ListByApplicationTypes" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedApplicationTypeResource created on azure
            // for more information of creating ServiceFabricManagedApplicationTypeResource, please refer to the document of ServiceFabricManagedApplicationTypeResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationTypeName = "myAppType";
            ResourceIdentifier serviceFabricManagedApplicationTypeResourceId = ServiceFabricManagedApplicationTypeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationTypeName);
            ServiceFabricManagedApplicationTypeResource serviceFabricManagedApplicationType = client.GetServiceFabricManagedApplicationTypeResource(serviceFabricManagedApplicationTypeResourceId);

            // get the collection of this ServiceFabricManagedApplicationTypeVersionResource
            ServiceFabricManagedApplicationTypeVersionCollection collection = serviceFabricManagedApplicationType.GetServiceFabricManagedApplicationTypeVersions();

            // invoke the operation and iterate over the result
            await foreach (ServiceFabricManagedApplicationTypeVersionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceFabricManagedApplicationTypeVersionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
