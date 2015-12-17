// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    /// <summary>
    /// Definition of Container operations for the Azure Backup extension with
    /// RecoveryService Vault.
    /// </summary>
    public partial interface IContainerOperation
    {
        /// <summary>
        /// Get the status of refresh container operation
        /// </summary>
        /// <param name='resourceGroupName'>
        /// ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='fabricName'>
        /// Backup Fabric name for the backup item
        /// </param>
        /// <param name='operationId'>
        /// Operation ID of refresh container operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a BaseRecoveryServicesJobResponse for Async
        /// operations.
        /// </returns>
        Task<BaseRecoveryServicesJobResponse> GetRefreshOperationResultAsync(string resourceGroupName, string resourceName, string fabricName, string operationId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// List all protection containers.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='queryParams'>
        /// ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a ProtectionContainerListResponse.
        /// </returns>
        Task<ProtectionContainerListResponse> ListAsync(string resourceGroupName, string resourceName, ProtectionContainerListQueryParams queryParams, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Trigger the Discovery.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='fabricName'>
        /// Backup Fabric name for the backup item
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a BaseRecoveryServicesJobResponse for Async
        /// operations.
        /// </returns>
        Task<BaseRecoveryServicesJobResponse> RefreshAsync(string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders, string fabricName, CancellationToken cancellationToken);
    }
}
