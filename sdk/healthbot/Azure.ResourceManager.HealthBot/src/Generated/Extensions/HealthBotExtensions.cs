// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.HealthBot.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HealthBot
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.HealthBot. </summary>
    public static partial class HealthBotExtensions
    {
        private static MockableHealthBotArmClient GetMockableHealthBotArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableHealthBotArmClient(client0));
        }

        private static MockableHealthBotResourceGroupResource GetMockableHealthBotResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableHealthBotResourceGroupResource(client, resource.Id));
        }

        private static MockableHealthBotSubscriptionResource GetMockableHealthBotSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableHealthBotSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="HealthBotResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HealthBotResource.CreateResourceIdentifier" /> to create a <see cref="HealthBotResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthBotArmClient.GetHealthBotResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="HealthBotResource"/> object. </returns>
        public static HealthBotResource GetHealthBotResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHealthBotArmClient(client).GetHealthBotResource(id);
        }

        /// <summary>
        /// Gets a collection of HealthBotResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthBotResourceGroupResource.GetHealthBots()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of HealthBotResources and their operations over a HealthBotResource. </returns>
        public static HealthBotCollection GetHealthBots(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableHealthBotResourceGroupResource(resourceGroupResource).GetHealthBots();
        }

        /// <summary>
        /// Get a HealthBot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthBot/healthBots/{botName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthBotResourceGroupResource.GetHealthBotAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="botName"> The name of the Bot resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="botName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="botName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<HealthBotResource>> GetHealthBotAsync(this ResourceGroupResource resourceGroupResource, string botName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableHealthBotResourceGroupResource(resourceGroupResource).GetHealthBotAsync(botName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a HealthBot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthBot/healthBots/{botName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthBotResourceGroupResource.GetHealthBot(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="botName"> The name of the Bot resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="botName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="botName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<HealthBotResource> GetHealthBot(this ResourceGroupResource resourceGroupResource, string botName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableHealthBotResourceGroupResource(resourceGroupResource).GetHealthBot(botName, cancellationToken);
        }

        /// <summary>
        /// Returns all the resources of a particular type belonging to a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HealthBot/healthBots</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthBotSubscriptionResource.GetHealthBots(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="HealthBotResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<HealthBotResource> GetHealthBotsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableHealthBotSubscriptionResource(subscriptionResource).GetHealthBotsAsync(cancellationToken);
        }

        /// <summary>
        /// Returns all the resources of a particular type belonging to a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HealthBot/healthBots</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthBotSubscriptionResource.GetHealthBots(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="HealthBotResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<HealthBotResource> GetHealthBots(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableHealthBotSubscriptionResource(subscriptionResource).GetHealthBots(cancellationToken);
        }
    }
}
