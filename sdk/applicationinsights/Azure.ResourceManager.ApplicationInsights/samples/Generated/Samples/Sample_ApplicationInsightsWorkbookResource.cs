// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ApplicationInsights.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ApplicationInsights.Samples
{
    public partial class Sample_ApplicationInsightsWorkbookResource
    {
        // WorkbooksList2
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetApplicationInsightsWorkbooks_WorkbooksList2()
        {
            // Generated from example definition: specification/applicationinsights/resource-manager/Microsoft.Insights/stable/2023-06-01/examples/WorkbooksList2.json
            // this example is just showing the usage of "Workbooks_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "6b643656-33eb-422f-aee8-3ac145d124af";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            WorkbookCategoryType category = WorkbookCategoryType.Workbook;
            await foreach (ApplicationInsightsWorkbookResource item in subscriptionResource.GetApplicationInsightsWorkbooksAsync(category))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ApplicationInsightsWorkbookData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // WorkbooksListSub
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetApplicationInsightsWorkbooks_WorkbooksListSub()
        {
            // Generated from example definition: specification/applicationinsights/resource-manager/Microsoft.Insights/stable/2023-06-01/examples/WorkbooksListSub.json
            // this example is just showing the usage of "Workbooks_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "6b643656-33eb-422f-aee8-3ac145d124af";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            WorkbookCategoryType category = WorkbookCategoryType.Workbook;
            await foreach (ApplicationInsightsWorkbookResource item in subscriptionResource.GetApplicationInsightsWorkbooksAsync(category))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ApplicationInsightsWorkbookData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // WorkbookGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_WorkbookGet()
        {
            // Generated from example definition: specification/applicationinsights/resource-manager/Microsoft.Insights/stable/2023-06-01/examples/WorkbookGet.json
            // this example is just showing the usage of "Workbooks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationInsightsWorkbookResource created on azure
            // for more information of creating ApplicationInsightsWorkbookResource, please refer to the document of ApplicationInsightsWorkbookResource
            string subscriptionId = "6b643656-33eb-422f-aee8-3ac145d124af";
            string resourceGroupName = "my-resource-group";
            string resourceName = "deadb33f-5e0d-4064-8ebb-1a4ed0313eb2";
            ResourceIdentifier applicationInsightsWorkbookResourceId = ApplicationInsightsWorkbookResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            ApplicationInsightsWorkbookResource applicationInsightsWorkbook = client.GetApplicationInsightsWorkbookResource(applicationInsightsWorkbookResourceId);

            // invoke the operation
            ApplicationInsightsWorkbookResource result = await applicationInsightsWorkbook.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApplicationInsightsWorkbookData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // WorkbookGet1
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_WorkbookGet1()
        {
            // Generated from example definition: specification/applicationinsights/resource-manager/Microsoft.Insights/stable/2023-06-01/examples/WorkbookGet1.json
            // this example is just showing the usage of "Workbooks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationInsightsWorkbookResource created on azure
            // for more information of creating ApplicationInsightsWorkbookResource, please refer to the document of ApplicationInsightsWorkbookResource
            string subscriptionId = "6b643656-33eb-422f-aee8-3ac145d124af";
            string resourceGroupName = "my-resource-group";
            string resourceName = "deadb33f-5e0d-4064-8ebb-1a4ed0313eb2";
            ResourceIdentifier applicationInsightsWorkbookResourceId = ApplicationInsightsWorkbookResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            ApplicationInsightsWorkbookResource applicationInsightsWorkbook = client.GetApplicationInsightsWorkbookResource(applicationInsightsWorkbookResourceId);

            // invoke the operation
            ApplicationInsightsWorkbookResource result = await applicationInsightsWorkbook.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApplicationInsightsWorkbookData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // WorkbookManagedGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_WorkbookManagedGet()
        {
            // Generated from example definition: specification/applicationinsights/resource-manager/Microsoft.Insights/stable/2023-06-01/examples/WorkbookManagedGet.json
            // this example is just showing the usage of "Workbooks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationInsightsWorkbookResource created on azure
            // for more information of creating ApplicationInsightsWorkbookResource, please refer to the document of ApplicationInsightsWorkbookResource
            string subscriptionId = "6b643656-33eb-422f-aee8-3ac145d124af";
            string resourceGroupName = "my-resource-group";
            string resourceName = "deadb33f-5e0d-4064-8ebb-1a4ed0313eb2";
            ResourceIdentifier applicationInsightsWorkbookResourceId = ApplicationInsightsWorkbookResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            ApplicationInsightsWorkbookResource applicationInsightsWorkbook = client.GetApplicationInsightsWorkbookResource(applicationInsightsWorkbookResourceId);

            // invoke the operation
            ApplicationInsightsWorkbookResource result = await applicationInsightsWorkbook.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApplicationInsightsWorkbookData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // WorkbookDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_WorkbookDelete()
        {
            // Generated from example definition: specification/applicationinsights/resource-manager/Microsoft.Insights/stable/2023-06-01/examples/WorkbookDelete.json
            // this example is just showing the usage of "Workbooks_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationInsightsWorkbookResource created on azure
            // for more information of creating ApplicationInsightsWorkbookResource, please refer to the document of ApplicationInsightsWorkbookResource
            string subscriptionId = "6b643656-33eb-422f-aee8-3ac145d124af";
            string resourceGroupName = "my-resource-group";
            string resourceName = "deadb33f-5e0d-4064-8ebb-1a4ed0313eb2";
            ResourceIdentifier applicationInsightsWorkbookResourceId = ApplicationInsightsWorkbookResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            ApplicationInsightsWorkbookResource applicationInsightsWorkbook = client.GetApplicationInsightsWorkbookResource(applicationInsightsWorkbookResourceId);

            // invoke the operation
            await applicationInsightsWorkbook.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // WorkbookManagedUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_WorkbookManagedUpdate()
        {
            // Generated from example definition: specification/applicationinsights/resource-manager/Microsoft.Insights/stable/2023-06-01/examples/WorkbookManagedUpdate.json
            // this example is just showing the usage of "Workbooks_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationInsightsWorkbookResource created on azure
            // for more information of creating ApplicationInsightsWorkbookResource, please refer to the document of ApplicationInsightsWorkbookResource
            string subscriptionId = "6b643656-33eb-422f-aee8-3ac145d124af";
            string resourceGroupName = "my-resource-group";
            string resourceName = "deadb33f-5e0d-4064-8ebb-1a4ed0313eb2";
            ResourceIdentifier applicationInsightsWorkbookResourceId = ApplicationInsightsWorkbookResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            ApplicationInsightsWorkbookResource applicationInsightsWorkbook = client.GetApplicationInsightsWorkbookResource(applicationInsightsWorkbookResourceId);

            // invoke the operation
            ApplicationInsightsWorkbookPatch patch = new ApplicationInsightsWorkbookPatch();
            string sourceId = "/subscriptions/6b643656-33eb-422f-aee8-3ac145d124af/resourcegroups/my-resource-group";
            ApplicationInsightsWorkbookResource result = await applicationInsightsWorkbook.UpdateAsync(patch, sourceId: sourceId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApplicationInsightsWorkbookData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // WorkbookUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_WorkbookUpdate()
        {
            // Generated from example definition: specification/applicationinsights/resource-manager/Microsoft.Insights/stable/2023-06-01/examples/WorkbookUpdate.json
            // this example is just showing the usage of "Workbooks_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationInsightsWorkbookResource created on azure
            // for more information of creating ApplicationInsightsWorkbookResource, please refer to the document of ApplicationInsightsWorkbookResource
            string subscriptionId = "6b643656-33eb-422f-aee8-3ac145d124af";
            string resourceGroupName = "my-resource-group";
            string resourceName = "deadb33f-5e0d-4064-8ebb-1a4ed0313eb2";
            ResourceIdentifier applicationInsightsWorkbookResourceId = ApplicationInsightsWorkbookResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            ApplicationInsightsWorkbookResource applicationInsightsWorkbook = client.GetApplicationInsightsWorkbookResource(applicationInsightsWorkbookResourceId);

            // invoke the operation
            ApplicationInsightsWorkbookPatch patch = new ApplicationInsightsWorkbookPatch();
            string sourceId = "/subscriptions/6b643656-33eb-422f-aee8-3ac145d124af/resourceGroups/my-resource-group/providers/Microsoft.Web/sites/MyApp";
            ApplicationInsightsWorkbookResource result = await applicationInsightsWorkbook.UpdateAsync(patch, sourceId: sourceId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApplicationInsightsWorkbookData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
