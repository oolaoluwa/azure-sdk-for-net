// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_DefaultSecurityRuleResource
    {
        // DefaultSecurityRuleGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_DefaultSecurityRuleGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-01-01/examples/DefaultSecurityRuleGet.json
            // this example is just showing the usage of "DefaultSecurityRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DefaultSecurityRuleResource created on azure
            // for more information of creating DefaultSecurityRuleResource, please refer to the document of DefaultSecurityRuleResource
            string subscriptionId = "subid";
            string resourceGroupName = "testrg";
            string networkSecurityGroupName = "nsg1";
            string defaultSecurityRuleName = "AllowVnetInBound";
            ResourceIdentifier defaultSecurityRuleResourceId = DefaultSecurityRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkSecurityGroupName, defaultSecurityRuleName);
            DefaultSecurityRuleResource defaultSecurityRule = client.GetDefaultSecurityRuleResource(defaultSecurityRuleResourceId);

            // invoke the operation
            DefaultSecurityRuleResource result = await defaultSecurityRule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
