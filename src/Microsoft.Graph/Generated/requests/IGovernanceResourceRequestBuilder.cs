// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IGovernanceResourceRequestBuilder.
    /// </summary>
    public partial interface IGovernanceResourceRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IGovernanceResourceRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IGovernanceResourceRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Parent.
        /// </summary>
        /// <returns>The <see cref="IGovernanceResourceRequestBuilder"/>.</returns>
        IGovernanceResourceRequestBuilder Parent { get; }

        /// <summary>
        /// Gets the request builder for RoleDefinitions.
        /// </summary>
        /// <returns>The <see cref="IGovernanceResourceRoleDefinitionsCollectionRequestBuilder"/>.</returns>
        IGovernanceResourceRoleDefinitionsCollectionRequestBuilder RoleDefinitions { get; }

        /// <summary>
        /// Gets the request builder for RoleAssignments.
        /// </summary>
        /// <returns>The <see cref="IGovernanceResourceRoleAssignmentsCollectionRequestBuilder"/>.</returns>
        IGovernanceResourceRoleAssignmentsCollectionRequestBuilder RoleAssignments { get; }

        /// <summary>
        /// Gets the request builder for RoleAssignmentRequests.
        /// </summary>
        /// <returns>The <see cref="IGovernanceResourceRoleAssignmentRequestsCollectionRequestBuilder"/>.</returns>
        IGovernanceResourceRoleAssignmentRequestsCollectionRequestBuilder RoleAssignmentRequests { get; }

        /// <summary>
        /// Gets the request builder for RoleSettings.
        /// </summary>
        /// <returns>The <see cref="IGovernanceResourceRoleSettingsCollectionRequestBuilder"/>.</returns>
        IGovernanceResourceRoleSettingsCollectionRequestBuilder RoleSettings { get; }
    
        
    
    }
}