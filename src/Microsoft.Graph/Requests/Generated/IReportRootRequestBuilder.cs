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
    /// The interface IReportRootRequestBuilder.
    /// </summary>
    public partial interface IReportRootRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IReportRootRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IReportRootRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for ReportRootGetOffice365ActivationsUserDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetOffice365ActivationsUserDetailRequestBuilder"/>.</returns>
        IReportRootGetOffice365ActivationsUserDetailRequestBuilder GetOffice365ActivationsUserDetail();

        /// <summary>
        /// Gets the request builder for ReportRootGetOffice365ActivationCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetOffice365ActivationCountsRequestBuilder"/>.</returns>
        IReportRootGetOffice365ActivationCountsRequestBuilder GetOffice365ActivationCounts();

        /// <summary>
        /// Gets the request builder for ReportRootGetOffice365ActivationsUserCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetOffice365ActivationsUserCountsRequestBuilder"/>.</returns>
        IReportRootGetOffice365ActivationsUserCountsRequestBuilder GetOffice365ActivationsUserCounts();

        /// <summary>
        /// Gets the request builder for ReportRootGetOffice365ActiveUserDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetOffice365ActiveUserDetailRequestBuilder"/>.</returns>
        IReportRootGetOffice365ActiveUserDetailRequestBuilder GetOffice365ActiveUserDetail(
            Date date);

        /// <summary>
        /// Gets the request builder for ReportRootGetOffice365ActiveUserDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetOffice365ActiveUserDetailRequestBuilder"/>.</returns>
        IReportRootGetOffice365ActiveUserDetailRequestBuilder GetOffice365ActiveUserDetail(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetOffice365ServicesUserCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetOffice365ServicesUserCountsRequestBuilder"/>.</returns>
        IReportRootGetOffice365ServicesUserCountsRequestBuilder GetOffice365ServicesUserCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetOffice365ActiveUserCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetOffice365ActiveUserCountsRequestBuilder"/>.</returns>
        IReportRootGetOffice365ActiveUserCountsRequestBuilder GetOffice365ActiveUserCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetOffice365GroupsActivityDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetOffice365GroupsActivityDetailRequestBuilder"/>.</returns>
        IReportRootGetOffice365GroupsActivityDetailRequestBuilder GetOffice365GroupsActivityDetail(
            Date date);

        /// <summary>
        /// Gets the request builder for ReportRootGetOffice365GroupsActivityDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetOffice365GroupsActivityDetailRequestBuilder"/>.</returns>
        IReportRootGetOffice365GroupsActivityDetailRequestBuilder GetOffice365GroupsActivityDetail(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetOffice365GroupsActivityCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetOffice365GroupsActivityCountsRequestBuilder"/>.</returns>
        IReportRootGetOffice365GroupsActivityCountsRequestBuilder GetOffice365GroupsActivityCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetOffice365GroupsActivityGroupCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetOffice365GroupsActivityGroupCountsRequestBuilder"/>.</returns>
        IReportRootGetOffice365GroupsActivityGroupCountsRequestBuilder GetOffice365GroupsActivityGroupCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetOffice365GroupsActivityStorage.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetOffice365GroupsActivityStorageRequestBuilder"/>.</returns>
        IReportRootGetOffice365GroupsActivityStorageRequestBuilder GetOffice365GroupsActivityStorage(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetOffice365GroupsActivityFileCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetOffice365GroupsActivityFileCountsRequestBuilder"/>.</returns>
        IReportRootGetOffice365GroupsActivityFileCountsRequestBuilder GetOffice365GroupsActivityFileCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetEmailActivityUserDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetEmailActivityUserDetailRequestBuilder"/>.</returns>
        IReportRootGetEmailActivityUserDetailRequestBuilder GetEmailActivityUserDetail(
            Date date);

        /// <summary>
        /// Gets the request builder for ReportRootGetEmailActivityUserDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetEmailActivityUserDetailRequestBuilder"/>.</returns>
        IReportRootGetEmailActivityUserDetailRequestBuilder GetEmailActivityUserDetail(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetEmailActivityCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetEmailActivityCountsRequestBuilder"/>.</returns>
        IReportRootGetEmailActivityCountsRequestBuilder GetEmailActivityCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetEmailActivityUserCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetEmailActivityUserCountsRequestBuilder"/>.</returns>
        IReportRootGetEmailActivityUserCountsRequestBuilder GetEmailActivityUserCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetEmailAppUsageUserDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetEmailAppUsageUserDetailRequestBuilder"/>.</returns>
        IReportRootGetEmailAppUsageUserDetailRequestBuilder GetEmailAppUsageUserDetail(
            Date date);

        /// <summary>
        /// Gets the request builder for ReportRootGetEmailAppUsageUserDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetEmailAppUsageUserDetailRequestBuilder"/>.</returns>
        IReportRootGetEmailAppUsageUserDetailRequestBuilder GetEmailAppUsageUserDetail(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetEmailAppUsageAppsUserCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetEmailAppUsageAppsUserCountsRequestBuilder"/>.</returns>
        IReportRootGetEmailAppUsageAppsUserCountsRequestBuilder GetEmailAppUsageAppsUserCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetEmailAppUsageUserCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetEmailAppUsageUserCountsRequestBuilder"/>.</returns>
        IReportRootGetEmailAppUsageUserCountsRequestBuilder GetEmailAppUsageUserCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetEmailAppUsageVersionsUserCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetEmailAppUsageVersionsUserCountsRequestBuilder"/>.</returns>
        IReportRootGetEmailAppUsageVersionsUserCountsRequestBuilder GetEmailAppUsageVersionsUserCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetMailboxUsageDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetMailboxUsageDetailRequestBuilder"/>.</returns>
        IReportRootGetMailboxUsageDetailRequestBuilder GetMailboxUsageDetail(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetMailboxUsageMailboxCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetMailboxUsageMailboxCountsRequestBuilder"/>.</returns>
        IReportRootGetMailboxUsageMailboxCountsRequestBuilder GetMailboxUsageMailboxCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetMailboxUsageQuotaStatusMailboxCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetMailboxUsageQuotaStatusMailboxCountsRequestBuilder"/>.</returns>
        IReportRootGetMailboxUsageQuotaStatusMailboxCountsRequestBuilder GetMailboxUsageQuotaStatusMailboxCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetMailboxUsageStorage.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetMailboxUsageStorageRequestBuilder"/>.</returns>
        IReportRootGetMailboxUsageStorageRequestBuilder GetMailboxUsageStorage(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetOneDriveActivityUserDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetOneDriveActivityUserDetailRequestBuilder"/>.</returns>
        IReportRootGetOneDriveActivityUserDetailRequestBuilder GetOneDriveActivityUserDetail(
            Date date);

        /// <summary>
        /// Gets the request builder for ReportRootGetOneDriveActivityUserDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetOneDriveActivityUserDetailRequestBuilder"/>.</returns>
        IReportRootGetOneDriveActivityUserDetailRequestBuilder GetOneDriveActivityUserDetail(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetOneDriveActivityUserCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetOneDriveActivityUserCountsRequestBuilder"/>.</returns>
        IReportRootGetOneDriveActivityUserCountsRequestBuilder GetOneDriveActivityUserCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetOneDriveActivityFileCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetOneDriveActivityFileCountsRequestBuilder"/>.</returns>
        IReportRootGetOneDriveActivityFileCountsRequestBuilder GetOneDriveActivityFileCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetOneDriveUsageAccountDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetOneDriveUsageAccountDetailRequestBuilder"/>.</returns>
        IReportRootGetOneDriveUsageAccountDetailRequestBuilder GetOneDriveUsageAccountDetail(
            Date date);

        /// <summary>
        /// Gets the request builder for ReportRootGetOneDriveUsageAccountDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetOneDriveUsageAccountDetailRequestBuilder"/>.</returns>
        IReportRootGetOneDriveUsageAccountDetailRequestBuilder GetOneDriveUsageAccountDetail(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetOneDriveUsageAccountCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetOneDriveUsageAccountCountsRequestBuilder"/>.</returns>
        IReportRootGetOneDriveUsageAccountCountsRequestBuilder GetOneDriveUsageAccountCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetOneDriveUsageFileCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetOneDriveUsageFileCountsRequestBuilder"/>.</returns>
        IReportRootGetOneDriveUsageFileCountsRequestBuilder GetOneDriveUsageFileCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetOneDriveUsageStorage.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetOneDriveUsageStorageRequestBuilder"/>.</returns>
        IReportRootGetOneDriveUsageStorageRequestBuilder GetOneDriveUsageStorage(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetSharePointActivityUserDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetSharePointActivityUserDetailRequestBuilder"/>.</returns>
        IReportRootGetSharePointActivityUserDetailRequestBuilder GetSharePointActivityUserDetail(
            Date date);

        /// <summary>
        /// Gets the request builder for ReportRootGetSharePointActivityUserDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetSharePointActivityUserDetailRequestBuilder"/>.</returns>
        IReportRootGetSharePointActivityUserDetailRequestBuilder GetSharePointActivityUserDetail(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetSharePointActivityFileCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetSharePointActivityFileCountsRequestBuilder"/>.</returns>
        IReportRootGetSharePointActivityFileCountsRequestBuilder GetSharePointActivityFileCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetSharePointActivityUserCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetSharePointActivityUserCountsRequestBuilder"/>.</returns>
        IReportRootGetSharePointActivityUserCountsRequestBuilder GetSharePointActivityUserCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetSharePointActivityPages.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetSharePointActivityPagesRequestBuilder"/>.</returns>
        IReportRootGetSharePointActivityPagesRequestBuilder GetSharePointActivityPages(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetSharePointSiteUsageDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetSharePointSiteUsageDetailRequestBuilder"/>.</returns>
        IReportRootGetSharePointSiteUsageDetailRequestBuilder GetSharePointSiteUsageDetail(
            Date date);

        /// <summary>
        /// Gets the request builder for ReportRootGetSharePointSiteUsageDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetSharePointSiteUsageDetailRequestBuilder"/>.</returns>
        IReportRootGetSharePointSiteUsageDetailRequestBuilder GetSharePointSiteUsageDetail(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetSharePointSiteUsageFileCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetSharePointSiteUsageFileCountsRequestBuilder"/>.</returns>
        IReportRootGetSharePointSiteUsageFileCountsRequestBuilder GetSharePointSiteUsageFileCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetSharePointSiteUsageSiteCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetSharePointSiteUsageSiteCountsRequestBuilder"/>.</returns>
        IReportRootGetSharePointSiteUsageSiteCountsRequestBuilder GetSharePointSiteUsageSiteCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetSharePointSiteUsageStorage.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetSharePointSiteUsageStorageRequestBuilder"/>.</returns>
        IReportRootGetSharePointSiteUsageStorageRequestBuilder GetSharePointSiteUsageStorage(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetSharePointSiteUsagePages.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetSharePointSiteUsagePagesRequestBuilder"/>.</returns>
        IReportRootGetSharePointSiteUsagePagesRequestBuilder GetSharePointSiteUsagePages(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetSkypeForBusinessActivityUserDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetSkypeForBusinessActivityUserDetailRequestBuilder"/>.</returns>
        IReportRootGetSkypeForBusinessActivityUserDetailRequestBuilder GetSkypeForBusinessActivityUserDetail(
            Date date);

        /// <summary>
        /// Gets the request builder for ReportRootGetSkypeForBusinessActivityUserDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetSkypeForBusinessActivityUserDetailRequestBuilder"/>.</returns>
        IReportRootGetSkypeForBusinessActivityUserDetailRequestBuilder GetSkypeForBusinessActivityUserDetail(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetSkypeForBusinessActivityCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetSkypeForBusinessActivityCountsRequestBuilder"/>.</returns>
        IReportRootGetSkypeForBusinessActivityCountsRequestBuilder GetSkypeForBusinessActivityCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetSkypeForBusinessActivityUserCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetSkypeForBusinessActivityUserCountsRequestBuilder"/>.</returns>
        IReportRootGetSkypeForBusinessActivityUserCountsRequestBuilder GetSkypeForBusinessActivityUserCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetSkypeForBusinessPeerToPeerActivityCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetSkypeForBusinessPeerToPeerActivityCountsRequestBuilder"/>.</returns>
        IReportRootGetSkypeForBusinessPeerToPeerActivityCountsRequestBuilder GetSkypeForBusinessPeerToPeerActivityCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetSkypeForBusinessPeerToPeerActivityUserCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetSkypeForBusinessPeerToPeerActivityUserCountsRequestBuilder"/>.</returns>
        IReportRootGetSkypeForBusinessPeerToPeerActivityUserCountsRequestBuilder GetSkypeForBusinessPeerToPeerActivityUserCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetSkypeForBusinessPeerToPeerActivityMinuteCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetSkypeForBusinessPeerToPeerActivityMinuteCountsRequestBuilder"/>.</returns>
        IReportRootGetSkypeForBusinessPeerToPeerActivityMinuteCountsRequestBuilder GetSkypeForBusinessPeerToPeerActivityMinuteCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetSkypeForBusinessOrganizerActivityCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetSkypeForBusinessOrganizerActivityCountsRequestBuilder"/>.</returns>
        IReportRootGetSkypeForBusinessOrganizerActivityCountsRequestBuilder GetSkypeForBusinessOrganizerActivityCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetSkypeForBusinessOrganizerActivityUserCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetSkypeForBusinessOrganizerActivityUserCountsRequestBuilder"/>.</returns>
        IReportRootGetSkypeForBusinessOrganizerActivityUserCountsRequestBuilder GetSkypeForBusinessOrganizerActivityUserCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetSkypeForBusinessOrganizerActivityMinuteCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetSkypeForBusinessOrganizerActivityMinuteCountsRequestBuilder"/>.</returns>
        IReportRootGetSkypeForBusinessOrganizerActivityMinuteCountsRequestBuilder GetSkypeForBusinessOrganizerActivityMinuteCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetSkypeForBusinessParticipantActivityCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetSkypeForBusinessParticipantActivityCountsRequestBuilder"/>.</returns>
        IReportRootGetSkypeForBusinessParticipantActivityCountsRequestBuilder GetSkypeForBusinessParticipantActivityCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetSkypeForBusinessParticipantActivityUserCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetSkypeForBusinessParticipantActivityUserCountsRequestBuilder"/>.</returns>
        IReportRootGetSkypeForBusinessParticipantActivityUserCountsRequestBuilder GetSkypeForBusinessParticipantActivityUserCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetSkypeForBusinessParticipantActivityMinuteCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetSkypeForBusinessParticipantActivityMinuteCountsRequestBuilder"/>.</returns>
        IReportRootGetSkypeForBusinessParticipantActivityMinuteCountsRequestBuilder GetSkypeForBusinessParticipantActivityMinuteCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetSkypeForBusinessDeviceUsageUserDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetSkypeForBusinessDeviceUsageUserDetailRequestBuilder"/>.</returns>
        IReportRootGetSkypeForBusinessDeviceUsageUserDetailRequestBuilder GetSkypeForBusinessDeviceUsageUserDetail(
            Date date);

        /// <summary>
        /// Gets the request builder for ReportRootGetSkypeForBusinessDeviceUsageUserDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetSkypeForBusinessDeviceUsageUserDetailRequestBuilder"/>.</returns>
        IReportRootGetSkypeForBusinessDeviceUsageUserDetailRequestBuilder GetSkypeForBusinessDeviceUsageUserDetail(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetSkypeForBusinessDeviceUsageDistributionUserCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetSkypeForBusinessDeviceUsageDistributionUserCountsRequestBuilder"/>.</returns>
        IReportRootGetSkypeForBusinessDeviceUsageDistributionUserCountsRequestBuilder GetSkypeForBusinessDeviceUsageDistributionUserCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetSkypeForBusinessDeviceUsageUserCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetSkypeForBusinessDeviceUsageUserCountsRequestBuilder"/>.</returns>
        IReportRootGetSkypeForBusinessDeviceUsageUserCountsRequestBuilder GetSkypeForBusinessDeviceUsageUserCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetYammerActivityUserDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetYammerActivityUserDetailRequestBuilder"/>.</returns>
        IReportRootGetYammerActivityUserDetailRequestBuilder GetYammerActivityUserDetail(
            Date date);

        /// <summary>
        /// Gets the request builder for ReportRootGetYammerActivityUserDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetYammerActivityUserDetailRequestBuilder"/>.</returns>
        IReportRootGetYammerActivityUserDetailRequestBuilder GetYammerActivityUserDetail(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetYammerActivityCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetYammerActivityCountsRequestBuilder"/>.</returns>
        IReportRootGetYammerActivityCountsRequestBuilder GetYammerActivityCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetYammerActivityUserCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetYammerActivityUserCountsRequestBuilder"/>.</returns>
        IReportRootGetYammerActivityUserCountsRequestBuilder GetYammerActivityUserCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetYammerDeviceUsageUserDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetYammerDeviceUsageUserDetailRequestBuilder"/>.</returns>
        IReportRootGetYammerDeviceUsageUserDetailRequestBuilder GetYammerDeviceUsageUserDetail(
            Date date);

        /// <summary>
        /// Gets the request builder for ReportRootGetYammerDeviceUsageUserDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetYammerDeviceUsageUserDetailRequestBuilder"/>.</returns>
        IReportRootGetYammerDeviceUsageUserDetailRequestBuilder GetYammerDeviceUsageUserDetail(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetYammerDeviceUsageDistributionUserCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetYammerDeviceUsageDistributionUserCountsRequestBuilder"/>.</returns>
        IReportRootGetYammerDeviceUsageDistributionUserCountsRequestBuilder GetYammerDeviceUsageDistributionUserCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetYammerDeviceUsageUserCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetYammerDeviceUsageUserCountsRequestBuilder"/>.</returns>
        IReportRootGetYammerDeviceUsageUserCountsRequestBuilder GetYammerDeviceUsageUserCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetYammerGroupsActivityDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetYammerGroupsActivityDetailRequestBuilder"/>.</returns>
        IReportRootGetYammerGroupsActivityDetailRequestBuilder GetYammerGroupsActivityDetail(
            Date date);

        /// <summary>
        /// Gets the request builder for ReportRootGetYammerGroupsActivityDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetYammerGroupsActivityDetailRequestBuilder"/>.</returns>
        IReportRootGetYammerGroupsActivityDetailRequestBuilder GetYammerGroupsActivityDetail(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetYammerGroupsActivityGroupCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetYammerGroupsActivityGroupCountsRequestBuilder"/>.</returns>
        IReportRootGetYammerGroupsActivityGroupCountsRequestBuilder GetYammerGroupsActivityGroupCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetYammerGroupsActivityCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetYammerGroupsActivityCountsRequestBuilder"/>.</returns>
        IReportRootGetYammerGroupsActivityCountsRequestBuilder GetYammerGroupsActivityCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetTeamsUserActivityUserDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetTeamsUserActivityUserDetailRequestBuilder"/>.</returns>
        IReportRootGetTeamsUserActivityUserDetailRequestBuilder GetTeamsUserActivityUserDetail(
            Date date);

        /// <summary>
        /// Gets the request builder for ReportRootGetTeamsUserActivityUserDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetTeamsUserActivityUserDetailRequestBuilder"/>.</returns>
        IReportRootGetTeamsUserActivityUserDetailRequestBuilder GetTeamsUserActivityUserDetail(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetTeamsUserActivityCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetTeamsUserActivityCountsRequestBuilder"/>.</returns>
        IReportRootGetTeamsUserActivityCountsRequestBuilder GetTeamsUserActivityCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetTeamsUserActivityUserCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetTeamsUserActivityUserCountsRequestBuilder"/>.</returns>
        IReportRootGetTeamsUserActivityUserCountsRequestBuilder GetTeamsUserActivityUserCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetTeamsDeviceUsageUserDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetTeamsDeviceUsageUserDetailRequestBuilder"/>.</returns>
        IReportRootGetTeamsDeviceUsageUserDetailRequestBuilder GetTeamsDeviceUsageUserDetail(
            Date date);

        /// <summary>
        /// Gets the request builder for ReportRootGetTeamsDeviceUsageUserDetail.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetTeamsDeviceUsageUserDetailRequestBuilder"/>.</returns>
        IReportRootGetTeamsDeviceUsageUserDetailRequestBuilder GetTeamsDeviceUsageUserDetail(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetTeamsDeviceUsageUserCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetTeamsDeviceUsageUserCountsRequestBuilder"/>.</returns>
        IReportRootGetTeamsDeviceUsageUserCountsRequestBuilder GetTeamsDeviceUsageUserCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootGetTeamsDeviceUsageDistributionUserCounts.
        /// </summary>
        /// <returns>The <see cref="IReportRootGetTeamsDeviceUsageDistributionUserCountsRequestBuilder"/>.</returns>
        IReportRootGetTeamsDeviceUsageDistributionUserCountsRequestBuilder GetTeamsDeviceUsageDistributionUserCounts(
            string period);

        /// <summary>
        /// Gets the request builder for ReportRootDeviceConfigurationUserActivity.
        /// </summary>
        /// <returns>The <see cref="IReportRootDeviceConfigurationUserActivityRequestBuilder"/>.</returns>
        IReportRootDeviceConfigurationUserActivityRequestBuilder DeviceConfigurationUserActivity();

        /// <summary>
        /// Gets the request builder for ReportRootDeviceConfigurationDeviceActivity.
        /// </summary>
        /// <returns>The <see cref="IReportRootDeviceConfigurationDeviceActivityRequestBuilder"/>.</returns>
        IReportRootDeviceConfigurationDeviceActivityRequestBuilder DeviceConfigurationDeviceActivity();

        /// <summary>
        /// Gets the request builder for ReportRootManagedDeviceEnrollmentFailureDetails.
        /// </summary>
        /// <returns>The <see cref="IReportRootManagedDeviceEnrollmentFailureDetailsRequestBuilder"/>.</returns>
        IReportRootManagedDeviceEnrollmentFailureDetailsRequestBuilder ManagedDeviceEnrollmentFailureDetails();

        /// <summary>
        /// Gets the request builder for ReportRootManagedDeviceEnrollmentFailureDetails.
        /// </summary>
        /// <returns>The <see cref="IReportRootManagedDeviceEnrollmentFailureDetailsRequestBuilder"/>.</returns>
        IReportRootManagedDeviceEnrollmentFailureDetailsRequestBuilder ManagedDeviceEnrollmentFailureDetails(
            Int32? skip = null,
            Int32? top = null,
            string filter = null,
            string skipToken = null);

        /// <summary>
        /// Gets the request builder for ReportRootManagedDeviceEnrollmentTopFailures.
        /// </summary>
        /// <returns>The <see cref="IReportRootManagedDeviceEnrollmentTopFailuresRequestBuilder"/>.</returns>
        IReportRootManagedDeviceEnrollmentTopFailuresRequestBuilder ManagedDeviceEnrollmentTopFailures();

        /// <summary>
        /// Gets the request builder for ReportRootManagedDeviceEnrollmentTopFailures.
        /// </summary>
        /// <returns>The <see cref="IReportRootManagedDeviceEnrollmentTopFailuresRequestBuilder"/>.</returns>
        IReportRootManagedDeviceEnrollmentTopFailuresRequestBuilder ManagedDeviceEnrollmentTopFailures(
            string period = null);
    
    }
}
