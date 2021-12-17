// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Authorization.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Authorization
{
    internal partial class RoleManagementPolicyAssignmentsRestOperations
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of RoleManagementPolicyAssignmentsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="endpoint"> server parameter. </param>
        public RoleManagementPolicyAssignmentsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ClientOptions options, Uri endpoint = null)
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateGetRequest(string scope, string roleManagementPolicyAssignmentName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Authorization/roleManagementPolicyAssignments/", false);
            uri.AppendPath(roleManagementPolicyAssignmentName, true);
            uri.AppendQuery("api-version", "2020-10-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Get the specified role management policy assignment for a resource scope. </summary>
        /// <param name="scope"> The scope of the role management policy. </param>
        /// <param name="roleManagementPolicyAssignmentName"> The name of format {guid_guid} the role management policy assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="roleManagementPolicyAssignmentName"/> is null. </exception>
        public async Task<Response<RoleManagementPolicyAssignmentData>> GetAsync(string scope, string roleManagementPolicyAssignmentName, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (roleManagementPolicyAssignmentName == null)
            {
                throw new ArgumentNullException(nameof(roleManagementPolicyAssignmentName));
            }

            using var message = CreateGetRequest(scope, roleManagementPolicyAssignmentName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleManagementPolicyAssignmentData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RoleManagementPolicyAssignmentData.DeserializeRoleManagementPolicyAssignmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((RoleManagementPolicyAssignmentData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get the specified role management policy assignment for a resource scope. </summary>
        /// <param name="scope"> The scope of the role management policy. </param>
        /// <param name="roleManagementPolicyAssignmentName"> The name of format {guid_guid} the role management policy assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="roleManagementPolicyAssignmentName"/> is null. </exception>
        public Response<RoleManagementPolicyAssignmentData> Get(string scope, string roleManagementPolicyAssignmentName, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (roleManagementPolicyAssignmentName == null)
            {
                throw new ArgumentNullException(nameof(roleManagementPolicyAssignmentName));
            }

            using var message = CreateGetRequest(scope, roleManagementPolicyAssignmentName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleManagementPolicyAssignmentData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RoleManagementPolicyAssignmentData.DeserializeRoleManagementPolicyAssignmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((RoleManagementPolicyAssignmentData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string scope, string roleManagementPolicyAssignmentName, RoleManagementPolicyAssignmentData parameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Authorization/roleManagementPolicyAssignments/", false);
            uri.AppendPath(roleManagementPolicyAssignmentName, true);
            uri.AppendQuery("api-version", "2020-10-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Create a role management policy assignment. </summary>
        /// <param name="scope"> The scope of the role management policy assignment to upsert. </param>
        /// <param name="roleManagementPolicyAssignmentName"> The name of format {guid_guid} the role management policy assignment to upsert. </param>
        /// <param name="parameters"> Parameters for the role management policy assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/>, <paramref name="roleManagementPolicyAssignmentName"/>, or <paramref name="parameters"/> is null. </exception>
        public async Task<Response<RoleManagementPolicyAssignmentData>> CreateAsync(string scope, string roleManagementPolicyAssignmentName, RoleManagementPolicyAssignmentData parameters, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (roleManagementPolicyAssignmentName == null)
            {
                throw new ArgumentNullException(nameof(roleManagementPolicyAssignmentName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateRequest(scope, roleManagementPolicyAssignmentName, parameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        RoleManagementPolicyAssignmentData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RoleManagementPolicyAssignmentData.DeserializeRoleManagementPolicyAssignmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create a role management policy assignment. </summary>
        /// <param name="scope"> The scope of the role management policy assignment to upsert. </param>
        /// <param name="roleManagementPolicyAssignmentName"> The name of format {guid_guid} the role management policy assignment to upsert. </param>
        /// <param name="parameters"> Parameters for the role management policy assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/>, <paramref name="roleManagementPolicyAssignmentName"/>, or <paramref name="parameters"/> is null. </exception>
        public Response<RoleManagementPolicyAssignmentData> Create(string scope, string roleManagementPolicyAssignmentName, RoleManagementPolicyAssignmentData parameters, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (roleManagementPolicyAssignmentName == null)
            {
                throw new ArgumentNullException(nameof(roleManagementPolicyAssignmentName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateRequest(scope, roleManagementPolicyAssignmentName, parameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        RoleManagementPolicyAssignmentData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RoleManagementPolicyAssignmentData.DeserializeRoleManagementPolicyAssignmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string scope, string roleManagementPolicyAssignmentName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Authorization/roleManagementPolicyAssignments/", false);
            uri.AppendPath(roleManagementPolicyAssignmentName, true);
            uri.AppendQuery("api-version", "2020-10-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Delete a role management policy assignment. </summary>
        /// <param name="scope"> The scope of the role management policy assignment to delete. </param>
        /// <param name="roleManagementPolicyAssignmentName"> The name of format {guid_guid} the role management policy assignment to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="roleManagementPolicyAssignmentName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string scope, string roleManagementPolicyAssignmentName, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (roleManagementPolicyAssignmentName == null)
            {
                throw new ArgumentNullException(nameof(roleManagementPolicyAssignmentName));
            }

            using var message = CreateDeleteRequest(scope, roleManagementPolicyAssignmentName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Delete a role management policy assignment. </summary>
        /// <param name="scope"> The scope of the role management policy assignment to delete. </param>
        /// <param name="roleManagementPolicyAssignmentName"> The name of format {guid_guid} the role management policy assignment to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="roleManagementPolicyAssignmentName"/> is null. </exception>
        public Response Delete(string scope, string roleManagementPolicyAssignmentName, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (roleManagementPolicyAssignmentName == null)
            {
                throw new ArgumentNullException(nameof(roleManagementPolicyAssignmentName));
            }

            using var message = CreateDeleteRequest(scope, roleManagementPolicyAssignmentName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListForScopeRequest(string scope)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Authorization/roleManagementPolicyAssignments", false);
            uri.AppendQuery("api-version", "2020-10-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets role management assignment policies for a resource scope. </summary>
        /// <param name="scope"> The scope of the role management policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public async Task<Response<RoleManagementPolicyAssignmentListResult>> ListForScopeAsync(string scope, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }

            using var message = CreateListForScopeRequest(scope);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleManagementPolicyAssignmentListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RoleManagementPolicyAssignmentListResult.DeserializeRoleManagementPolicyAssignmentListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets role management assignment policies for a resource scope. </summary>
        /// <param name="scope"> The scope of the role management policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public Response<RoleManagementPolicyAssignmentListResult> ListForScope(string scope, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }

            using var message = CreateListForScopeRequest(scope);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleManagementPolicyAssignmentListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RoleManagementPolicyAssignmentListResult.DeserializeRoleManagementPolicyAssignmentListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListForScopeNextPageRequest(string nextLink, string scope)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets role management assignment policies for a resource scope. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="scope"> The scope of the role management policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="scope"/> is null. </exception>
        public async Task<Response<RoleManagementPolicyAssignmentListResult>> ListForScopeNextPageAsync(string nextLink, string scope, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }

            using var message = CreateListForScopeNextPageRequest(nextLink, scope);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleManagementPolicyAssignmentListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RoleManagementPolicyAssignmentListResult.DeserializeRoleManagementPolicyAssignmentListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets role management assignment policies for a resource scope. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="scope"> The scope of the role management policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="scope"/> is null. </exception>
        public Response<RoleManagementPolicyAssignmentListResult> ListForScopeNextPage(string nextLink, string scope, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }

            using var message = CreateListForScopeNextPageRequest(nextLink, scope);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleManagementPolicyAssignmentListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RoleManagementPolicyAssignmentListResult.DeserializeRoleManagementPolicyAssignmentListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
