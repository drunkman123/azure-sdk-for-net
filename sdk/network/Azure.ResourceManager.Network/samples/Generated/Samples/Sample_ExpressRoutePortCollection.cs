// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_ExpressRoutePortCollection
    {
        // ExpressRoutePortGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ExpressRoutePortGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/ExpressRoutePortGet.json
            // this example is just showing the usage of "ExpressRoutePorts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ExpressRoutePortResource
            ExpressRoutePortCollection collection = resourceGroupResource.GetExpressRoutePorts();

            // invoke the operation
            string expressRoutePortName = "portName";
            ExpressRoutePortResource result = await collection.GetAsync(expressRoutePortName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRoutePortData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ExpressRoutePortGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ExpressRoutePortGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/ExpressRoutePortGet.json
            // this example is just showing the usage of "ExpressRoutePorts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ExpressRoutePortResource
            ExpressRoutePortCollection collection = resourceGroupResource.GetExpressRoutePorts();

            // invoke the operation
            string expressRoutePortName = "portName";
            bool result = await collection.ExistsAsync(expressRoutePortName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ExpressRoutePortCreate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ExpressRoutePortCreate()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/ExpressRoutePortCreate.json
            // this example is just showing the usage of "ExpressRoutePorts_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ExpressRoutePortResource
            ExpressRoutePortCollection collection = resourceGroupResource.GetExpressRoutePorts();

            // invoke the operation
            string expressRoutePortName = "portName";
            ExpressRoutePortData data = new ExpressRoutePortData()
            {
                PeeringLocation = "peeringLocationName",
                BandwidthInGbps = 100,
                Encapsulation = ExpressRoutePortsEncapsulation.QinQ,
                BillingType = ExpressRoutePortsBillingType.UnlimitedData,
                Location = new AzureLocation("westus"),
            };
            ArmOperation<ExpressRoutePortResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, expressRoutePortName, data);
            ExpressRoutePortResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRoutePortData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ExpressRoutePortUpdateLink
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ExpressRoutePortUpdateLink()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/ExpressRoutePortUpdateLink.json
            // this example is just showing the usage of "ExpressRoutePorts_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ExpressRoutePortResource
            ExpressRoutePortCollection collection = resourceGroupResource.GetExpressRoutePorts();

            // invoke the operation
            string expressRoutePortName = "portName";
            ExpressRoutePortData data = new ExpressRoutePortData()
            {
                PeeringLocation = "peeringLocationName",
                BandwidthInGbps = 100,
                Encapsulation = ExpressRoutePortsEncapsulation.QinQ,
                Links =
{
new ExpressRouteLinkData()
{
AdminState = ExpressRouteLinkAdminState.Enabled,
Name = "link1",
}
},
                BillingType = ExpressRoutePortsBillingType.UnlimitedData,
                Location = new AzureLocation("westus"),
            };
            ArmOperation<ExpressRoutePortResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, expressRoutePortName, data);
            ExpressRoutePortResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRoutePortData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ExpressRoutePortListByResourceGroup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ExpressRoutePortListByResourceGroup()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/ExpressRoutePortListByResourceGroup.json
            // this example is just showing the usage of "ExpressRoutePorts_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ExpressRoutePortResource
            ExpressRoutePortCollection collection = resourceGroupResource.GetExpressRoutePorts();

            // invoke the operation and iterate over the result
            await foreach (ExpressRoutePortResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ExpressRoutePortData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
