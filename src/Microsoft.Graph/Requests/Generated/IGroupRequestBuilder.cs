// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IGroupRequestBuilder.
    /// </summary>
    public partial interface IGroupRequestBuilder : IDirectoryObjectRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IGroupRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IGroupRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Members.
        /// </summary>
        /// <returns>The <see cref="IGroupMembersCollectionWithReferencesRequestBuilder"/>.</returns>
        IGroupMembersCollectionWithReferencesRequestBuilder Members { get; }

        /// <summary>
        /// Gets the request builder for MemberOf.
        /// </summary>
        /// <returns>The <see cref="IGroupMemberOfCollectionWithReferencesRequestBuilder"/>.</returns>
        IGroupMemberOfCollectionWithReferencesRequestBuilder MemberOf { get; }

        /// <summary>
        /// Gets the request builder for MembersWithLicenseErrors.
        /// </summary>
        /// <returns>The <see cref="IGroupMembersWithLicenseErrorsCollectionWithReferencesRequestBuilder"/>.</returns>
        IGroupMembersWithLicenseErrorsCollectionWithReferencesRequestBuilder MembersWithLicenseErrors { get; }

        /// <summary>
        /// Gets the request builder for TransitiveMembers.
        /// </summary>
        /// <returns>The <see cref="IGroupTransitiveMembersCollectionWithReferencesRequestBuilder"/>.</returns>
        IGroupTransitiveMembersCollectionWithReferencesRequestBuilder TransitiveMembers { get; }

        /// <summary>
        /// Gets the request builder for TransitiveMemberOf.
        /// </summary>
        /// <returns>The <see cref="IGroupTransitiveMemberOfCollectionWithReferencesRequestBuilder"/>.</returns>
        IGroupTransitiveMemberOfCollectionWithReferencesRequestBuilder TransitiveMemberOf { get; }

        /// <summary>
        /// Gets the request builder for CreatedOnBehalfOf.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectWithReferenceRequestBuilder"/>.</returns>
        IDirectoryObjectWithReferenceRequestBuilder CreatedOnBehalfOf { get; }

        /// <summary>
        /// Gets the request builder for Owners.
        /// </summary>
        /// <returns>The <see cref="IGroupOwnersCollectionWithReferencesRequestBuilder"/>.</returns>
        IGroupOwnersCollectionWithReferencesRequestBuilder Owners { get; }

        /// <summary>
        /// Gets the request builder for Settings.
        /// </summary>
        /// <returns>The <see cref="IGroupSettingsCollectionRequestBuilder"/>.</returns>
        IGroupSettingsCollectionRequestBuilder Settings { get; }

        /// <summary>
        /// Gets the request builder for Extensions.
        /// </summary>
        /// <returns>The <see cref="IGroupExtensionsCollectionRequestBuilder"/>.</returns>
        IGroupExtensionsCollectionRequestBuilder Extensions { get; }

        /// <summary>
        /// Gets the request builder for Threads.
        /// </summary>
        /// <returns>The <see cref="IGroupThreadsCollectionRequestBuilder"/>.</returns>
        IGroupThreadsCollectionRequestBuilder Threads { get; }

        /// <summary>
        /// Gets the request builder for Calendar.
        /// </summary>
        /// <returns>The <see cref="ICalendarRequestBuilder"/>.</returns>
        ICalendarRequestBuilder Calendar { get; }

        /// <summary>
        /// Gets the request builder for CalendarView.
        /// </summary>
        /// <returns>The <see cref="IGroupCalendarViewCollectionRequestBuilder"/>.</returns>
        IGroupCalendarViewCollectionRequestBuilder CalendarView { get; }

        /// <summary>
        /// Gets the request builder for Events.
        /// </summary>
        /// <returns>The <see cref="IGroupEventsCollectionRequestBuilder"/>.</returns>
        IGroupEventsCollectionRequestBuilder Events { get; }

        /// <summary>
        /// Gets the request builder for Conversations.
        /// </summary>
        /// <returns>The <see cref="IGroupConversationsCollectionRequestBuilder"/>.</returns>
        IGroupConversationsCollectionRequestBuilder Conversations { get; }

        /// <summary>
        /// Gets the request builder for Photo.
        /// </summary>
        /// <returns>The <see cref="IProfilePhotoRequestBuilder"/>.</returns>
        IProfilePhotoRequestBuilder Photo { get; }

        /// <summary>
        /// Gets the request builder for Photos.
        /// </summary>
        /// <returns>The <see cref="IGroupPhotosCollectionRequestBuilder"/>.</returns>
        IGroupPhotosCollectionRequestBuilder Photos { get; }

        /// <summary>
        /// Gets the request builder for AcceptedSenders.
        /// </summary>
        /// <returns>The <see cref="IGroupAcceptedSendersCollectionRequestBuilder"/>.</returns>
        IGroupAcceptedSendersCollectionRequestBuilder AcceptedSenders { get; }

        /// <summary>
        /// Gets the request builder for RejectedSenders.
        /// </summary>
        /// <returns>The <see cref="IGroupRejectedSendersCollectionRequestBuilder"/>.</returns>
        IGroupRejectedSendersCollectionRequestBuilder RejectedSenders { get; }

        /// <summary>
        /// Gets the request builder for Drive.
        /// </summary>
        /// <returns>The <see cref="IDriveRequestBuilder"/>.</returns>
        IDriveRequestBuilder Drive { get; }

        /// <summary>
        /// Gets the request builder for Drives.
        /// </summary>
        /// <returns>The <see cref="IGroupDrivesCollectionRequestBuilder"/>.</returns>
        IGroupDrivesCollectionRequestBuilder Drives { get; }

        /// <summary>
        /// Gets the request builder for Sites.
        /// </summary>
        /// <returns>The <see cref="IGroupSitesCollectionRequestBuilder"/>.</returns>
        IGroupSitesCollectionRequestBuilder Sites { get; }

        /// <summary>
        /// Gets the request builder for Planner.
        /// </summary>
        /// <returns>The <see cref="IPlannerGroupRequestBuilder"/>.</returns>
        IPlannerGroupRequestBuilder Planner { get; }

        /// <summary>
        /// Gets the request builder for Onenote.
        /// </summary>
        /// <returns>The <see cref="IOnenoteRequestBuilder"/>.</returns>
        IOnenoteRequestBuilder Onenote { get; }

        /// <summary>
        /// Gets the request builder for GroupLifecyclePolicies.
        /// </summary>
        /// <returns>The <see cref="IGroupGroupLifecyclePoliciesCollectionRequestBuilder"/>.</returns>
        IGroupGroupLifecyclePoliciesCollectionRequestBuilder GroupLifecyclePolicies { get; }

        /// <summary>
        /// Gets the request builder for Team.
        /// </summary>
        /// <returns>The <see cref="ITeamRequestBuilder"/>.</returns>
        ITeamRequestBuilder Team { get; }
    
        /// <summary>
        /// Gets the request builder for GroupSubscribeByMail.
        /// </summary>
        /// <returns>The <see cref="IGroupSubscribeByMailRequestBuilder"/>.</returns>
        IGroupSubscribeByMailRequestBuilder SubscribeByMail();

        /// <summary>
        /// Gets the request builder for GroupUnsubscribeByMail.
        /// </summary>
        /// <returns>The <see cref="IGroupUnsubscribeByMailRequestBuilder"/>.</returns>
        IGroupUnsubscribeByMailRequestBuilder UnsubscribeByMail();

        /// <summary>
        /// Gets the request builder for GroupAddFavorite.
        /// </summary>
        /// <returns>The <see cref="IGroupAddFavoriteRequestBuilder"/>.</returns>
        IGroupAddFavoriteRequestBuilder AddFavorite();

        /// <summary>
        /// Gets the request builder for GroupRemoveFavorite.
        /// </summary>
        /// <returns>The <see cref="IGroupRemoveFavoriteRequestBuilder"/>.</returns>
        IGroupRemoveFavoriteRequestBuilder RemoveFavorite();

        /// <summary>
        /// Gets the request builder for GroupResetUnseenCount.
        /// </summary>
        /// <returns>The <see cref="IGroupResetUnseenCountRequestBuilder"/>.</returns>
        IGroupResetUnseenCountRequestBuilder ResetUnseenCount();

        /// <summary>
        /// Gets the request builder for GroupRenew.
        /// </summary>
        /// <returns>The <see cref="IGroupRenewRequestBuilder"/>.</returns>
        IGroupRenewRequestBuilder Renew();
    
    }
}
