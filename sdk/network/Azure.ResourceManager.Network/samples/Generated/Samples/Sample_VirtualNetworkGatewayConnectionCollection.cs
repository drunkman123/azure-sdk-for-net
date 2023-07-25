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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_VirtualNetworkGatewayConnectionCollection
    {
        // CreateVirtualNetworkGatewayConnection_S2S
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateVirtualNetworkGatewayConnectionS2S()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/VirtualNetworkGatewayConnectionCreate.json
            // this example is just showing the usage of "VirtualNetworkGatewayConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this VirtualNetworkGatewayConnectionResource
            VirtualNetworkGatewayConnectionCollection collection = resourceGroupResource.GetVirtualNetworkGatewayConnections();

            // invoke the operation
            string virtualNetworkGatewayConnectionName = "connS2S";
            VirtualNetworkGatewayConnectionData data = new VirtualNetworkGatewayConnectionData(new VirtualNetworkGatewayData()
            {
                IPConfigurations =
{
new VirtualNetworkGatewayIPConfiguration()
{
PrivateIPAllocationMethod = NetworkIPAllocationMethod.Dynamic,
SubnetId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/vnet1/subnets/GatewaySubnet"),
PublicIPAddressId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/publicIPAddresses/gwpip"),
Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworkGateways/vpngw/ipConfigurations/gwipconfig1"),
Name = "gwipconfig1",
}
},
                GatewayType = VirtualNetworkGatewayType.Vpn,
                VpnType = VpnType.RouteBased,
                EnableBgp = false,
                Active = false,
                Sku = new VirtualNetworkGatewaySku()
                {
                    Name = VirtualNetworkGatewaySkuName.VpnGw1,
                    Tier = VirtualNetworkGatewaySkuTier.VpnGw1,
                },
                BgpSettings = new BgpSettings()
                {
                    Asn = 65514,
                    BgpPeeringAddress = "10.0.1.30",
                    PeerWeight = 0,
                },
                Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworkGateways/vpngw"),
                Location = new AzureLocation("centralus"),
                Tags =
{
},
            }, VirtualNetworkGatewayConnectionType.IPsec)
            {
                LocalNetworkGateway2 = new LocalNetworkGatewayData()
                {
                    LocalNetworkAddressPrefixes =
{
"10.1.0.0/16"
},
                    GatewayIPAddress = "x.x.x.x",
                    Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/localNetworkGateways/localgw"),
                    Location = new AzureLocation("centralus"),
                    Tags =
{
},
                },
                IngressNatRules =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworkGateways/vpngw/natRules/natRule1"),
}
},
                EgressNatRules =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworkGateways/vpngw/natRules/natRule2"),
}
},
                ConnectionProtocol = VirtualNetworkGatewayConnectionProtocol.IkeV2,
                RoutingWeight = 0,
                DpdTimeoutSeconds = 30,
                ConnectionMode = VirtualNetworkGatewayConnectionMode.Default,
                SharedKey = "Abc123",
                EnableBgp = false,
                GatewayCustomBgpIPAddresses =
{
new GatewayCustomBgpIPAddressIPConfiguration("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworkGateways/vpngw/ipConfigurations/default","169.254.21.1"),new GatewayCustomBgpIPAddressIPConfiguration("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworkGateways/vpngw/ipConfigurations/ActiveActive","169.254.21.3")
},
                UsePolicyBasedTrafficSelectors = false,
                IPsecPolicies =
{
},
                TrafficSelectorPolicies =
{
},
                Location = new AzureLocation("centralus"),
            };
            ArmOperation<VirtualNetworkGatewayConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, virtualNetworkGatewayConnectionName, data);
            VirtualNetworkGatewayConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkGatewayConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetVirtualNetworkGatewayConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetVirtualNetworkGatewayConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/VirtualNetworkGatewayConnectionGet.json
            // this example is just showing the usage of "VirtualNetworkGatewayConnections_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this VirtualNetworkGatewayConnectionResource
            VirtualNetworkGatewayConnectionCollection collection = resourceGroupResource.GetVirtualNetworkGatewayConnections();

            // invoke the operation
            string virtualNetworkGatewayConnectionName = "connS2S";
            VirtualNetworkGatewayConnectionResource result = await collection.GetAsync(virtualNetworkGatewayConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkGatewayConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetVirtualNetworkGatewayConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetVirtualNetworkGatewayConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/VirtualNetworkGatewayConnectionGet.json
            // this example is just showing the usage of "VirtualNetworkGatewayConnections_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this VirtualNetworkGatewayConnectionResource
            VirtualNetworkGatewayConnectionCollection collection = resourceGroupResource.GetVirtualNetworkGatewayConnections();

            // invoke the operation
            string virtualNetworkGatewayConnectionName = "connS2S";
            bool result = await collection.ExistsAsync(virtualNetworkGatewayConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ListVirtualNetworkGatewayConnectionsinResourceGroup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListVirtualNetworkGatewayConnectionsinResourceGroup()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/VirtualNetworkGatewayConnectionsList.json
            // this example is just showing the usage of "VirtualNetworkGatewayConnections_List" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this VirtualNetworkGatewayConnectionResource
            VirtualNetworkGatewayConnectionCollection collection = resourceGroupResource.GetVirtualNetworkGatewayConnections();

            // invoke the operation and iterate over the result
            await foreach (VirtualNetworkGatewayConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualNetworkGatewayConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
