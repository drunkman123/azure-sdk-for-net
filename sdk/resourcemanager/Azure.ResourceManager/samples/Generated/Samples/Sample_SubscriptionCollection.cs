// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Samples
{
    public partial class Sample_SubscriptionCollection
    {
        // GetASingleSubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetASingleSubscription()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2022-12-01/examples/GetSubscription.json
            // this example is just showing the usage of "Subscriptions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenant = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this SubscriptionResource
            SubscriptionCollection collection = tenant.GetSubscriptions();

            // invoke the operation
            string subscriptionId = "291bba3f-e0a5-47bc-a099-3bdcb2a50a05";
            SubscriptionResource result = await collection.GetAsync(subscriptionId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SubscriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetASingleSubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetASingleSubscription()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2022-12-01/examples/GetSubscription.json
            // this example is just showing the usage of "Subscriptions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenant = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this SubscriptionResource
            SubscriptionCollection collection = tenant.GetSubscriptions();

            // invoke the operation
            string subscriptionId = "291bba3f-e0a5-47bc-a099-3bdcb2a50a05";
            bool result = await collection.ExistsAsync(subscriptionId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // GetAllSubscriptions
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetAllSubscriptions()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2022-12-01/examples/GetSubscriptions.json
            // this example is just showing the usage of "Subscriptions_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenant = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this SubscriptionResource
            SubscriptionCollection collection = tenant.GetSubscriptions();

            // invoke the operation and iterate over the result
            await foreach (SubscriptionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SubscriptionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
