// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SqlVirtualMachine
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SqlVirtualMachineGroupsOperations.
    /// </summary>
    public static partial class SqlVirtualMachineGroupsOperationsExtensions
    {
            /// <summary>
            /// Gets a SQL virtual machine group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the resource. You can obtain this
            /// value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='sqlVirtualMachineGroupName'>
            /// Name of the SQL virtual machine group.
            /// </param>
            public static SqlVirtualMachineGroup Get(this ISqlVirtualMachineGroupsOperations operations, string resourceGroupName, string sqlVirtualMachineGroupName)
            {
                return operations.GetAsync(resourceGroupName, sqlVirtualMachineGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a SQL virtual machine group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the resource. You can obtain this
            /// value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='sqlVirtualMachineGroupName'>
            /// Name of the SQL virtual machine group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SqlVirtualMachineGroup> GetAsync(this ISqlVirtualMachineGroupsOperations operations, string resourceGroupName, string sqlVirtualMachineGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, sqlVirtualMachineGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a SQL virtual machine group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the resource. You can obtain this
            /// value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='sqlVirtualMachineGroupName'>
            /// Name of the SQL virtual machine group.
            /// </param>
            /// <param name='parameters'>
            /// The SQL virtual machine group.
            /// </param>
            public static SqlVirtualMachineGroup CreateOrUpdate(this ISqlVirtualMachineGroupsOperations operations, string resourceGroupName, string sqlVirtualMachineGroupName, SqlVirtualMachineGroup parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, sqlVirtualMachineGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a SQL virtual machine group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the resource. You can obtain this
            /// value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='sqlVirtualMachineGroupName'>
            /// Name of the SQL virtual machine group.
            /// </param>
            /// <param name='parameters'>
            /// The SQL virtual machine group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SqlVirtualMachineGroup> CreateOrUpdateAsync(this ISqlVirtualMachineGroupsOperations operations, string resourceGroupName, string sqlVirtualMachineGroupName, SqlVirtualMachineGroup parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, sqlVirtualMachineGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a SQL virtual machine group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the resource. You can obtain this
            /// value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='sqlVirtualMachineGroupName'>
            /// Name of the SQL virtual machine group.
            /// </param>
            public static void Delete(this ISqlVirtualMachineGroupsOperations operations, string resourceGroupName, string sqlVirtualMachineGroupName)
            {
                operations.DeleteAsync(resourceGroupName, sqlVirtualMachineGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a SQL virtual machine group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the resource. You can obtain this
            /// value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='sqlVirtualMachineGroupName'>
            /// Name of the SQL virtual machine group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISqlVirtualMachineGroupsOperations operations, string resourceGroupName, string sqlVirtualMachineGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, sqlVirtualMachineGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates SQL virtual machine group tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the resource. You can obtain this
            /// value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='sqlVirtualMachineGroupName'>
            /// Name of the SQL virtual machine group.
            /// </param>
            /// <param name='parameters'>
            /// The SQL virtual machine group.
            /// </param>
            public static SqlVirtualMachineGroup Update(this ISqlVirtualMachineGroupsOperations operations, string resourceGroupName, string sqlVirtualMachineGroupName, SqlVirtualMachineGroupUpdate parameters)
            {
                return operations.UpdateAsync(resourceGroupName, sqlVirtualMachineGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates SQL virtual machine group tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the resource. You can obtain this
            /// value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='sqlVirtualMachineGroupName'>
            /// Name of the SQL virtual machine group.
            /// </param>
            /// <param name='parameters'>
            /// The SQL virtual machine group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SqlVirtualMachineGroup> UpdateAsync(this ISqlVirtualMachineGroupsOperations operations, string resourceGroupName, string sqlVirtualMachineGroupName, SqlVirtualMachineGroupUpdate parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, sqlVirtualMachineGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all SQL virtual machine groups in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the resource. You can obtain this
            /// value from the Azure Resource Manager API or the portal.
            /// </param>
            public static IPage<SqlVirtualMachineGroup> ListByResourceGroup(this ISqlVirtualMachineGroupsOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all SQL virtual machine groups in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the resource. You can obtain this
            /// value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SqlVirtualMachineGroup>> ListByResourceGroupAsync(this ISqlVirtualMachineGroupsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all SQL virtual machine groups in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<SqlVirtualMachineGroup> List(this ISqlVirtualMachineGroupsOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all SQL virtual machine groups in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SqlVirtualMachineGroup>> ListAsync(this ISqlVirtualMachineGroupsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a SQL virtual machine group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the resource. You can obtain this
            /// value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='sqlVirtualMachineGroupName'>
            /// Name of the SQL virtual machine group.
            /// </param>
            /// <param name='parameters'>
            /// The SQL virtual machine group.
            /// </param>
            public static SqlVirtualMachineGroup BeginCreateOrUpdate(this ISqlVirtualMachineGroupsOperations operations, string resourceGroupName, string sqlVirtualMachineGroupName, SqlVirtualMachineGroup parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, sqlVirtualMachineGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a SQL virtual machine group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the resource. You can obtain this
            /// value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='sqlVirtualMachineGroupName'>
            /// Name of the SQL virtual machine group.
            /// </param>
            /// <param name='parameters'>
            /// The SQL virtual machine group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SqlVirtualMachineGroup> BeginCreateOrUpdateAsync(this ISqlVirtualMachineGroupsOperations operations, string resourceGroupName, string sqlVirtualMachineGroupName, SqlVirtualMachineGroup parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, sqlVirtualMachineGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a SQL virtual machine group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the resource. You can obtain this
            /// value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='sqlVirtualMachineGroupName'>
            /// Name of the SQL virtual machine group.
            /// </param>
            public static void BeginDelete(this ISqlVirtualMachineGroupsOperations operations, string resourceGroupName, string sqlVirtualMachineGroupName)
            {
                operations.BeginDeleteAsync(resourceGroupName, sqlVirtualMachineGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a SQL virtual machine group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the resource. You can obtain this
            /// value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='sqlVirtualMachineGroupName'>
            /// Name of the SQL virtual machine group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this ISqlVirtualMachineGroupsOperations operations, string resourceGroupName, string sqlVirtualMachineGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, sqlVirtualMachineGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates SQL virtual machine group tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the resource. You can obtain this
            /// value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='sqlVirtualMachineGroupName'>
            /// Name of the SQL virtual machine group.
            /// </param>
            /// <param name='parameters'>
            /// The SQL virtual machine group.
            /// </param>
            public static SqlVirtualMachineGroup BeginUpdate(this ISqlVirtualMachineGroupsOperations operations, string resourceGroupName, string sqlVirtualMachineGroupName, SqlVirtualMachineGroupUpdate parameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, sqlVirtualMachineGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates SQL virtual machine group tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the resource. You can obtain this
            /// value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='sqlVirtualMachineGroupName'>
            /// Name of the SQL virtual machine group.
            /// </param>
            /// <param name='parameters'>
            /// The SQL virtual machine group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SqlVirtualMachineGroup> BeginUpdateAsync(this ISqlVirtualMachineGroupsOperations operations, string resourceGroupName, string sqlVirtualMachineGroupName, SqlVirtualMachineGroupUpdate parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, sqlVirtualMachineGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all SQL virtual machine groups in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SqlVirtualMachineGroup> ListByResourceGroupNext(this ISqlVirtualMachineGroupsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all SQL virtual machine groups in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SqlVirtualMachineGroup>> ListByResourceGroupNextAsync(this ISqlVirtualMachineGroupsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all SQL virtual machine groups in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SqlVirtualMachineGroup> ListNext(this ISqlVirtualMachineGroupsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all SQL virtual machine groups in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SqlVirtualMachineGroup>> ListNextAsync(this ISqlVirtualMachineGroupsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}