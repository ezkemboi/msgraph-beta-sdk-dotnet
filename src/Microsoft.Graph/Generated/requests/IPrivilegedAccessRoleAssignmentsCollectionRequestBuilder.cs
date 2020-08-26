// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IPrivilegedAccessRoleAssignmentsCollectionRequestBuilder.
    /// </summary>
    public partial interface IPrivilegedAccessRoleAssignmentsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IPrivilegedAccessRoleAssignmentsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IPrivilegedAccessRoleAssignmentsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IGovernanceRoleAssignmentRequestBuilder"/> for the specified GovernanceRoleAssignment.
        /// </summary>
        /// <param name="id">The ID for the GovernanceRoleAssignment.</param>
        /// <returns>The <see cref="IGovernanceRoleAssignmentRequestBuilder"/>.</returns>
        IGovernanceRoleAssignmentRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for GovernanceRoleAssignmentExport.
        /// </summary>
        /// <returns>The <see cref="IGovernanceRoleAssignmentExportRequestBuilder"/>.</returns>
        IGovernanceRoleAssignmentExportRequestBuilder Export();
    }
}