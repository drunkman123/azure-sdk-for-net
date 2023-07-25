// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Analytics.Synapse.AccessControl.Samples
{
    public class Samples_RoleAssignmentsClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CheckPrincipalAccess()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RoleAssignmentsClient(endpoint, credential);

            var data = new
            {
                subject = new
                {
                    principalId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                },
                actions = new[] {
        new {
            id = "<id>",
            isDataAction = true,
        }
    },
                scope = "<scope>",
            };

            Response response = client.CheckPrincipalAccess(RequestContent.Create(data), ContentType.ApplicationOctetStream);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CheckPrincipalAccess_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RoleAssignmentsClient(endpoint, credential);

            var data = new
            {
                subject = new
                {
                    principalId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                    groupIds = new[] {
            "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"
        },
                },
                actions = new[] {
        new {
            id = "<id>",
            isDataAction = true,
        }
    },
                scope = "<scope>",
            };

            Response response = client.CheckPrincipalAccess(RequestContent.Create(data), ContentType.ApplicationOctetStream);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("accessDecisions")[0].GetProperty("accessDecision").ToString());
            Console.WriteLine(result.GetProperty("accessDecisions")[0].GetProperty("actionId").ToString());
            Console.WriteLine(result.GetProperty("accessDecisions")[0].GetProperty("roleAssignment").GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("accessDecisions")[0].GetProperty("roleAssignment").GetProperty("roleDefinitionId").ToString());
            Console.WriteLine(result.GetProperty("accessDecisions")[0].GetProperty("roleAssignment").GetProperty("principalId").ToString());
            Console.WriteLine(result.GetProperty("accessDecisions")[0].GetProperty("roleAssignment").GetProperty("scope").ToString());
            Console.WriteLine(result.GetProperty("accessDecisions")[0].GetProperty("roleAssignment").GetProperty("principalType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CheckPrincipalAccess_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RoleAssignmentsClient(endpoint, credential);

            var data = new
            {
                subject = new
                {
                    principalId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                },
                actions = new[] {
        new {
            id = "<id>",
            isDataAction = true,
        }
    },
                scope = "<scope>",
            };

            Response response = await client.CheckPrincipalAccessAsync(RequestContent.Create(data), ContentType.ApplicationOctetStream);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CheckPrincipalAccess_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RoleAssignmentsClient(endpoint, credential);

            var data = new
            {
                subject = new
                {
                    principalId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                    groupIds = new[] {
            "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"
        },
                },
                actions = new[] {
        new {
            id = "<id>",
            isDataAction = true,
        }
    },
                scope = "<scope>",
            };

            Response response = await client.CheckPrincipalAccessAsync(RequestContent.Create(data), ContentType.ApplicationOctetStream);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("accessDecisions")[0].GetProperty("accessDecision").ToString());
            Console.WriteLine(result.GetProperty("accessDecisions")[0].GetProperty("actionId").ToString());
            Console.WriteLine(result.GetProperty("accessDecisions")[0].GetProperty("roleAssignment").GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("accessDecisions")[0].GetProperty("roleAssignment").GetProperty("roleDefinitionId").ToString());
            Console.WriteLine(result.GetProperty("accessDecisions")[0].GetProperty("roleAssignment").GetProperty("principalId").ToString());
            Console.WriteLine(result.GetProperty("accessDecisions")[0].GetProperty("roleAssignment").GetProperty("scope").ToString());
            Console.WriteLine(result.GetProperty("accessDecisions")[0].GetProperty("roleAssignment").GetProperty("principalType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetRoleAssignments()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RoleAssignmentsClient(endpoint, credential);

            Response response = client.GetRoleAssignments("<roleId>", "<principalId>", "<scope>", "<continuationToken>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetRoleAssignments_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RoleAssignmentsClient(endpoint, credential);

            Response response = client.GetRoleAssignments("<roleId>", "<principalId>", "<scope>", "<continuationToken>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("roleDefinitionId").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("principalId").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("scope").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("principalType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetRoleAssignments_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RoleAssignmentsClient(endpoint, credential);

            Response response = await client.GetRoleAssignmentsAsync("<roleId>", "<principalId>", "<scope>", "<continuationToken>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetRoleAssignments_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RoleAssignmentsClient(endpoint, credential);

            Response response = await client.GetRoleAssignmentsAsync("<roleId>", "<principalId>", "<scope>", "<continuationToken>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("roleDefinitionId").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("principalId").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("scope").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("principalType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateRoleAssignment()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RoleAssignmentsClient(endpoint, credential);

            var data = new
            {
                roleId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                principalId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                scope = "<scope>",
            };

            Response response = client.CreateRoleAssignment("<roleAssignmentId>", RequestContent.Create(data), ContentType.ApplicationOctetStream);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateRoleAssignment_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RoleAssignmentsClient(endpoint, credential);

            var data = new
            {
                roleId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                principalId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                scope = "<scope>",
                principalType = "<principalType>",
            };

            Response response = client.CreateRoleAssignment("<roleAssignmentId>", RequestContent.Create(data), ContentType.ApplicationOctetStream);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("roleDefinitionId").ToString());
            Console.WriteLine(result.GetProperty("principalId").ToString());
            Console.WriteLine(result.GetProperty("scope").ToString());
            Console.WriteLine(result.GetProperty("principalType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateRoleAssignment_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RoleAssignmentsClient(endpoint, credential);

            var data = new
            {
                roleId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                principalId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                scope = "<scope>",
            };

            Response response = await client.CreateRoleAssignmentAsync("<roleAssignmentId>", RequestContent.Create(data), ContentType.ApplicationOctetStream);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateRoleAssignment_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RoleAssignmentsClient(endpoint, credential);

            var data = new
            {
                roleId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                principalId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                scope = "<scope>",
                principalType = "<principalType>",
            };

            Response response = await client.CreateRoleAssignmentAsync("<roleAssignmentId>", RequestContent.Create(data), ContentType.ApplicationOctetStream);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("roleDefinitionId").ToString());
            Console.WriteLine(result.GetProperty("principalId").ToString());
            Console.WriteLine(result.GetProperty("scope").ToString());
            Console.WriteLine(result.GetProperty("principalType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetRoleAssignmentById()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RoleAssignmentsClient(endpoint, credential);

            Response response = client.GetRoleAssignmentById("<roleAssignmentId>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetRoleAssignmentById_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RoleAssignmentsClient(endpoint, credential);

            Response response = client.GetRoleAssignmentById("<roleAssignmentId>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("roleDefinitionId").ToString());
            Console.WriteLine(result.GetProperty("principalId").ToString());
            Console.WriteLine(result.GetProperty("scope").ToString());
            Console.WriteLine(result.GetProperty("principalType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetRoleAssignmentById_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RoleAssignmentsClient(endpoint, credential);

            Response response = await client.GetRoleAssignmentByIdAsync("<roleAssignmentId>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetRoleAssignmentById_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RoleAssignmentsClient(endpoint, credential);

            Response response = await client.GetRoleAssignmentByIdAsync("<roleAssignmentId>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("roleDefinitionId").ToString());
            Console.WriteLine(result.GetProperty("principalId").ToString());
            Console.WriteLine(result.GetProperty("scope").ToString());
            Console.WriteLine(result.GetProperty("principalType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DeleteRoleAssignmentById()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RoleAssignmentsClient(endpoint, credential);

            Response response = client.DeleteRoleAssignmentById("<roleAssignmentId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DeleteRoleAssignmentById_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RoleAssignmentsClient(endpoint, credential);

            Response response = client.DeleteRoleAssignmentById("<roleAssignmentId>", "<scope>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DeleteRoleAssignmentById_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RoleAssignmentsClient(endpoint, credential);

            Response response = await client.DeleteRoleAssignmentByIdAsync("<roleAssignmentId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DeleteRoleAssignmentById_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new RoleAssignmentsClient(endpoint, credential);

            Response response = await client.DeleteRoleAssignmentByIdAsync("<roleAssignmentId>", "<scope>");
            Console.WriteLine(response.Status);
        }
    }
}
