// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ApiManagementAuthorizationServerResource
    {
        // ApiManagementHeadAuthorizationServer
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetEntityTag_ApiManagementHeadAuthorizationServer()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2022-08-01/examples/ApiManagementHeadAuthorizationServer.json
            // this example is just showing the usage of "AuthorizationServer_GetEntityTag" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementAuthorizationServerResource created on azure
            // for more information of creating ApiManagementAuthorizationServerResource, please refer to the document of ApiManagementAuthorizationServerResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string authsid = "newauthServer2";
            ResourceIdentifier apiManagementAuthorizationServerResourceId = ApiManagementAuthorizationServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, authsid);
            ApiManagementAuthorizationServerResource apiManagementAuthorizationServer = client.GetApiManagementAuthorizationServerResource(apiManagementAuthorizationServerResourceId);

            // invoke the operation
            bool result = await apiManagementAuthorizationServer.GetEntityTagAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementGetAuthorizationServer
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetAuthorizationServer()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2022-08-01/examples/ApiManagementGetAuthorizationServer.json
            // this example is just showing the usage of "AuthorizationServer_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementAuthorizationServerResource created on azure
            // for more information of creating ApiManagementAuthorizationServerResource, please refer to the document of ApiManagementAuthorizationServerResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string authsid = "newauthServer2";
            ResourceIdentifier apiManagementAuthorizationServerResourceId = ApiManagementAuthorizationServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, authsid);
            ApiManagementAuthorizationServerResource apiManagementAuthorizationServer = client.GetApiManagementAuthorizationServerResource(apiManagementAuthorizationServerResourceId);

            // invoke the operation
            ApiManagementAuthorizationServerResource result = await apiManagementAuthorizationServer.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementAuthorizationServerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementUpdateAuthorizationServer
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ApiManagementUpdateAuthorizationServer()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2022-08-01/examples/ApiManagementUpdateAuthorizationServer.json
            // this example is just showing the usage of "AuthorizationServer_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementAuthorizationServerResource created on azure
            // for more information of creating ApiManagementAuthorizationServerResource, please refer to the document of ApiManagementAuthorizationServerResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string authsid = "newauthServer";
            ResourceIdentifier apiManagementAuthorizationServerResourceId = ApiManagementAuthorizationServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, authsid);
            ApiManagementAuthorizationServerResource apiManagementAuthorizationServer = client.GetApiManagementAuthorizationServerResource(apiManagementAuthorizationServerResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            ApiManagementAuthorizationServerPatch patch = new ApiManagementAuthorizationServerPatch()
            {
                UseInTestConsole = false,
                UseInApiDocumentation = true,
                ClientId = "update",
                ClientSecret = "updated",
            };
            ApiManagementAuthorizationServerResource result = await apiManagementAuthorizationServer.UpdateAsync(ifMatch, patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementAuthorizationServerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementDeleteAuthorizationServer
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ApiManagementDeleteAuthorizationServer()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2022-08-01/examples/ApiManagementDeleteAuthorizationServer.json
            // this example is just showing the usage of "AuthorizationServer_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementAuthorizationServerResource created on azure
            // for more information of creating ApiManagementAuthorizationServerResource, please refer to the document of ApiManagementAuthorizationServerResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string authsid = "newauthServer2";
            ResourceIdentifier apiManagementAuthorizationServerResourceId = ApiManagementAuthorizationServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, authsid);
            ApiManagementAuthorizationServerResource apiManagementAuthorizationServer = client.GetApiManagementAuthorizationServerResource(apiManagementAuthorizationServerResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            await apiManagementAuthorizationServer.DeleteAsync(WaitUntil.Completed, ifMatch);

            Console.WriteLine($"Succeeded");
        }

        // ApiManagementAuthorizationServerListSecrets
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSecrets_ApiManagementAuthorizationServerListSecrets()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2022-08-01/examples/ApiManagementAuthorizationServerListSecrets.json
            // this example is just showing the usage of "AuthorizationServer_ListSecrets" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementAuthorizationServerResource created on azure
            // for more information of creating ApiManagementAuthorizationServerResource, please refer to the document of ApiManagementAuthorizationServerResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string authsid = "newauthServer2";
            ResourceIdentifier apiManagementAuthorizationServerResourceId = ApiManagementAuthorizationServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, authsid);
            ApiManagementAuthorizationServerResource apiManagementAuthorizationServer = client.GetApiManagementAuthorizationServerResource(apiManagementAuthorizationServerResourceId);

            // invoke the operation
            AuthorizationServerSecretsContract result = await apiManagementAuthorizationServer.GetSecretsAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
