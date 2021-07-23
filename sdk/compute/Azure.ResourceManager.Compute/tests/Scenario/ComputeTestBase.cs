﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.TestFramework;
using NUnit.Framework;

namespace Azure.ResourceManager.Compute.Tests
{
    public class ComputeTestBase : ManagementRecordedTestBase<ComputeTestEnvironment>
    {
        protected Location DefaultLocation => Location.WestUS2;
        protected ArmClient Client { get; private set; }
        protected Subscription DefaultSubscription => Client.DefaultSubscription;

        public ComputeTestBase(bool isAsync) : base(isAsync)
        {
        }

        public ComputeTestBase(bool isAsync, RecordedTestMode mode) : base(isAsync, mode)
        {
        }

        [SetUp]
        public void CreateCommonClient()
        {
            Client = GetArmClient();
        }

        protected async Task<ResourceGroup> CreateResourceGroupAsync()
        {
            var resourceGroupName = Recording.GenerateAssetName("testRG-");
            return await DefaultSubscription.GetResourceGroups().CreateOrUpdateAsync(
                resourceGroupName,
                new ResourceGroupData(DefaultLocation)
                {
                    Tags =
                    {
                        { "test", "env" }
                    }
                });
        }
    }
}
