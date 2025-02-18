// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.IotFirmwareDefense
{
    /// <summary>
    /// A class representing a collection of <see cref="FirmwareWorkspaceResource" /> and their operations.
    /// Each <see cref="FirmwareWorkspaceResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="FirmwareWorkspaceCollection" /> instance call the GetFirmwareWorkspaces method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class FirmwareWorkspaceCollection : ArmCollection, IEnumerable<FirmwareWorkspaceResource>, IAsyncEnumerable<FirmwareWorkspaceResource>
    {
        private readonly ClientDiagnostics _firmwareWorkspaceWorkspacesClientDiagnostics;
        private readonly WorkspacesRestOperations _firmwareWorkspaceWorkspacesRestClient;

        /// <summary> Initializes a new instance of the <see cref="FirmwareWorkspaceCollection"/> class for mocking. </summary>
        protected FirmwareWorkspaceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FirmwareWorkspaceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FirmwareWorkspaceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _firmwareWorkspaceWorkspacesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.IotFirmwareDefense", FirmwareWorkspaceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FirmwareWorkspaceResource.ResourceType, out string firmwareWorkspaceWorkspacesApiVersion);
            _firmwareWorkspaceWorkspacesRestClient = new WorkspacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, firmwareWorkspaceWorkspacesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create or update a firmware analysis workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="workspaceName"> The name of the firmware analysis workspace. </param>
        /// <param name="data"> Parameters when creating a firmware analysis workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<FirmwareWorkspaceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string workspaceName, FirmwareWorkspaceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _firmwareWorkspaceWorkspacesClientDiagnostics.CreateScope("FirmwareWorkspaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _firmwareWorkspaceWorkspacesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new IotFirmwareDefenseArmOperation<FirmwareWorkspaceResource>(Response.FromValue(new FirmwareWorkspaceResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to create or update a firmware analysis workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="workspaceName"> The name of the firmware analysis workspace. </param>
        /// <param name="data"> Parameters when creating a firmware analysis workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<FirmwareWorkspaceResource> CreateOrUpdate(WaitUntil waitUntil, string workspaceName, FirmwareWorkspaceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _firmwareWorkspaceWorkspacesClientDiagnostics.CreateScope("FirmwareWorkspaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _firmwareWorkspaceWorkspacesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, data, cancellationToken);
                var operation = new IotFirmwareDefenseArmOperation<FirmwareWorkspaceResource>(Response.FromValue(new FirmwareWorkspaceResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get firmware analysis workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The name of the firmware analysis workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual async Task<Response<FirmwareWorkspaceResource>> GetAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));

            using var scope = _firmwareWorkspaceWorkspacesClientDiagnostics.CreateScope("FirmwareWorkspaceCollection.Get");
            scope.Start();
            try
            {
                var response = await _firmwareWorkspaceWorkspacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FirmwareWorkspaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get firmware analysis workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The name of the firmware analysis workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual Response<FirmwareWorkspaceResource> Get(string workspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));

            using var scope = _firmwareWorkspaceWorkspacesClientDiagnostics.CreateScope("FirmwareWorkspaceCollection.Get");
            scope.Start();
            try
            {
                var response = _firmwareWorkspaceWorkspacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FirmwareWorkspaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the firmware analysis workspaces in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FirmwareWorkspaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FirmwareWorkspaceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _firmwareWorkspaceWorkspacesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _firmwareWorkspaceWorkspacesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FirmwareWorkspaceResource(Client, FirmwareWorkspaceData.DeserializeFirmwareWorkspaceData(e)), _firmwareWorkspaceWorkspacesClientDiagnostics, Pipeline, "FirmwareWorkspaceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the firmware analysis workspaces in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FirmwareWorkspaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FirmwareWorkspaceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _firmwareWorkspaceWorkspacesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _firmwareWorkspaceWorkspacesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FirmwareWorkspaceResource(Client, FirmwareWorkspaceData.DeserializeFirmwareWorkspaceData(e)), _firmwareWorkspaceWorkspacesClientDiagnostics, Pipeline, "FirmwareWorkspaceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The name of the firmware analysis workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));

            using var scope = _firmwareWorkspaceWorkspacesClientDiagnostics.CreateScope("FirmwareWorkspaceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _firmwareWorkspaceWorkspacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The name of the firmware analysis workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual Response<bool> Exists(string workspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));

            using var scope = _firmwareWorkspaceWorkspacesClientDiagnostics.CreateScope("FirmwareWorkspaceCollection.Exists");
            scope.Start();
            try
            {
                var response = _firmwareWorkspaceWorkspacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FirmwareWorkspaceResource> IEnumerable<FirmwareWorkspaceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FirmwareWorkspaceResource> IAsyncEnumerable<FirmwareWorkspaceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
