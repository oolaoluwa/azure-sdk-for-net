// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppContainers.Models;

namespace Azure.ResourceManager.AppContainers.Samples
{
    public partial class Sample_ContainerAppManagedCertificateCollection
    {
        // Get Certificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetCertificate()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2024-03-01/examples/ManagedCertificate_Get.json
            // this example is just showing the usage of "ManagedCertificates_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedEnvironmentResource created on azure
            // for more information of creating ContainerAppManagedEnvironmentResource, please refer to the document of ContainerAppManagedEnvironmentResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "examplerg";
            string environmentName = "testcontainerenv";
            ResourceIdentifier containerAppManagedEnvironmentResourceId = ContainerAppManagedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName);
            ContainerAppManagedEnvironmentResource containerAppManagedEnvironment = client.GetContainerAppManagedEnvironmentResource(containerAppManagedEnvironmentResourceId);

            // get the collection of this ContainerAppManagedCertificateResource
            ContainerAppManagedCertificateCollection collection = containerAppManagedEnvironment.GetContainerAppManagedCertificates();

            // invoke the operation
            string managedCertificateName = "certificate-firendly-name";
            ContainerAppManagedCertificateResource result = await collection.GetAsync(managedCertificateName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppManagedCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Certificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetCertificate()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2024-03-01/examples/ManagedCertificate_Get.json
            // this example is just showing the usage of "ManagedCertificates_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedEnvironmentResource created on azure
            // for more information of creating ContainerAppManagedEnvironmentResource, please refer to the document of ContainerAppManagedEnvironmentResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "examplerg";
            string environmentName = "testcontainerenv";
            ResourceIdentifier containerAppManagedEnvironmentResourceId = ContainerAppManagedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName);
            ContainerAppManagedEnvironmentResource containerAppManagedEnvironment = client.GetContainerAppManagedEnvironmentResource(containerAppManagedEnvironmentResourceId);

            // get the collection of this ContainerAppManagedCertificateResource
            ContainerAppManagedCertificateCollection collection = containerAppManagedEnvironment.GetContainerAppManagedCertificates();

            // invoke the operation
            string managedCertificateName = "certificate-firendly-name";
            bool result = await collection.ExistsAsync(managedCertificateName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Certificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetCertificate()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2024-03-01/examples/ManagedCertificate_Get.json
            // this example is just showing the usage of "ManagedCertificates_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedEnvironmentResource created on azure
            // for more information of creating ContainerAppManagedEnvironmentResource, please refer to the document of ContainerAppManagedEnvironmentResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "examplerg";
            string environmentName = "testcontainerenv";
            ResourceIdentifier containerAppManagedEnvironmentResourceId = ContainerAppManagedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName);
            ContainerAppManagedEnvironmentResource containerAppManagedEnvironment = client.GetContainerAppManagedEnvironmentResource(containerAppManagedEnvironmentResourceId);

            // get the collection of this ContainerAppManagedCertificateResource
            ContainerAppManagedCertificateCollection collection = containerAppManagedEnvironment.GetContainerAppManagedCertificates();

            // invoke the operation
            string managedCertificateName = "certificate-firendly-name";
            NullableResponse<ContainerAppManagedCertificateResource> response = await collection.GetIfExistsAsync(managedCertificateName);
            ContainerAppManagedCertificateResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerAppManagedCertificateData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create or Update Certificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateCertificate()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2024-03-01/examples/ManagedCertificate_CreateOrUpdate.json
            // this example is just showing the usage of "ManagedCertificates_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedEnvironmentResource created on azure
            // for more information of creating ContainerAppManagedEnvironmentResource, please refer to the document of ContainerAppManagedEnvironmentResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "examplerg";
            string environmentName = "testcontainerenv";
            ResourceIdentifier containerAppManagedEnvironmentResourceId = ContainerAppManagedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName);
            ContainerAppManagedEnvironmentResource containerAppManagedEnvironment = client.GetContainerAppManagedEnvironmentResource(containerAppManagedEnvironmentResourceId);

            // get the collection of this ContainerAppManagedCertificateResource
            ContainerAppManagedCertificateCollection collection = containerAppManagedEnvironment.GetContainerAppManagedCertificates();

            // invoke the operation
            string managedCertificateName = "certificate-firendly-name";
            ContainerAppManagedCertificateData data = new ContainerAppManagedCertificateData(new AzureLocation("East US"))
            {
                Properties = new ManagedCertificateProperties()
                {
                    SubjectName = "my-subject-name.company.country.net",
                    DomainControlValidation = ManagedCertificateDomainControlValidation.Cname,
                },
            };
            ArmOperation<ContainerAppManagedCertificateResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, managedCertificateName, data);
            ContainerAppManagedCertificateResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppManagedCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List Managed Certificates by Managed Environment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListManagedCertificatesByManagedEnvironment()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2024-03-01/examples/ManagedCertificates_ListByManagedEnvironment.json
            // this example is just showing the usage of "ManagedCertificates_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedEnvironmentResource created on azure
            // for more information of creating ContainerAppManagedEnvironmentResource, please refer to the document of ContainerAppManagedEnvironmentResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "examplerg";
            string environmentName = "testcontainerenv";
            ResourceIdentifier containerAppManagedEnvironmentResourceId = ContainerAppManagedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName);
            ContainerAppManagedEnvironmentResource containerAppManagedEnvironment = client.GetContainerAppManagedEnvironmentResource(containerAppManagedEnvironmentResourceId);

            // get the collection of this ContainerAppManagedCertificateResource
            ContainerAppManagedCertificateCollection collection = containerAppManagedEnvironment.GetContainerAppManagedCertificates();

            // invoke the operation and iterate over the result
            await foreach (ContainerAppManagedCertificateResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerAppManagedCertificateData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
