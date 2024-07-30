// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.NetApp.Samples
{
    public partial class Sample_RegionInfoResource
    {
        // RegionInfos_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_RegionInfosGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2023-11-01/examples/RegionInfos_Get.json
            // this example is just showing the usage of "NetAppResourceRegionInfos_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RegionInfoResource created on azure
            // for more information of creating RegionInfoResource, please refer to the document of RegionInfoResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            AzureLocation location = new AzureLocation("eastus");
            ResourceIdentifier regionInfoResourceId = RegionInfoResource.CreateResourceIdentifier(subscriptionId, location);
            RegionInfoResource regionInfoResource = client.GetRegionInfoResource(regionInfoResourceId);

            // invoke the operation
            RegionInfoResource result = await regionInfoResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RegionInfoResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
