// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Support.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmSupportModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Support.SupportAzureServiceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> Localized name of the Azure service. </param>
        /// <param name="resourceTypes"> ARM Resource types. </param>
        /// <returns> A new <see cref="Support.SupportAzureServiceData"/> instance for mocking. </returns>
        public static SupportAzureServiceData SupportAzureServiceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string displayName = null, IEnumerable<string> resourceTypes = null)
        {
            resourceTypes ??= new List<string>();

            return new SupportAzureServiceData(
                id,
                name,
                resourceType,
                systemData,
                displayName,
                resourceTypes?.ToList(),
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Support.ProblemClassificationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> Localized name of problem classification. </param>
        /// <param name="secondaryConsentEnabled"> This property indicates whether secondary consent is present for problem classification. </param>
        /// <returns> A new <see cref="Support.ProblemClassificationData"/> instance for mocking. </returns>
        public static ProblemClassificationData ProblemClassificationData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string displayName = null, IEnumerable<SecondaryConsentEnabled> secondaryConsentEnabled = null)
        {
            secondaryConsentEnabled ??= new List<SecondaryConsentEnabled>();

            return new ProblemClassificationData(
                id,
                name,
                resourceType,
                systemData,
                displayName,
                secondaryConsentEnabled?.ToList(),
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SecondaryConsentEnabled"/>. </summary>
        /// <param name="description"> User consent description. </param>
        /// <param name="secondaryConsentEnabledType"> The Azure service for which secondary consent is needed for case creation. </param>
        /// <returns> A new <see cref="Models.SecondaryConsentEnabled"/> instance for mocking. </returns>
        public static SecondaryConsentEnabled SecondaryConsentEnabled(string description = null, string secondaryConsentEnabledType = null)
        {
            return new SecondaryConsentEnabled(description, secondaryConsentEnabledType, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SupportNameAvailabilityResult"/>. </summary>
        /// <param name="isNameAvailable"> Indicates whether the name is available. </param>
        /// <param name="reason"> The reason why the name is not available. </param>
        /// <param name="message"> The detailed error message describing why the name is not available. </param>
        /// <returns> A new <see cref="Models.SupportNameAvailabilityResult"/> instance for mocking. </returns>
        public static SupportNameAvailabilityResult SupportNameAvailabilityResult(bool? isNameAvailable = null, string reason = null, string message = null)
        {
            return new SupportNameAvailabilityResult(isNameAvailable, reason, message, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Support.SupportTicketData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="supportTicketId"> System generated support ticket Id that is unique. </param>
        /// <param name="description"> Detailed description of the question or issue. </param>
        /// <param name="problemClassificationId"> Each Azure service has its own set of issue categories, also known as problem classification. This parameter is the unique Id for the type of problem you are experiencing. </param>
        /// <param name="problemClassificationDisplayName"> Localized name of problem classification. </param>
        /// <param name="severity"> A value that indicates the urgency of the case, which in turn determines the response time according to the service level agreement of the technical support plan you have with Azure. Note: 'Highest critical impact', also known as the 'Emergency - Severe impact' level in the Azure portal is reserved only for our Premium customers. </param>
        /// <param name="enrollmentId"> Enrollment Id associated with the support ticket. </param>
        /// <param name="require24X7Response"> Indicates if this requires a 24x7 response from Azure. </param>
        /// <param name="advancedDiagnosticConsent"> Advanced diagnostic consent to be updated on the support ticket. </param>
        /// <param name="problemScopingQuestions"> Problem scoping questions associated with the support ticket. </param>
        /// <param name="supportPlanId"> Support plan id associated with the support ticket. </param>
        /// <param name="contactDetails"> Contact information of the user requesting to create a support ticket. </param>
        /// <param name="serviceLevelAgreement"> Service Level Agreement information for this support ticket. </param>
        /// <param name="supportEngineerEmailAddress"> Information about the support engineer working on this support ticket. </param>
        /// <param name="supportPlanType"> Support plan type associated with the support ticket. </param>
        /// <param name="supportPlanDisplayName"> Support plan type associated with the support ticket. </param>
        /// <param name="title"> Title of the support ticket. </param>
        /// <param name="problemStartOn"> Time in UTC (ISO 8601 format) when the problem started. </param>
        /// <param name="serviceId"> This is the resource Id of the Azure service resource associated with the support ticket. </param>
        /// <param name="serviceDisplayName"> Localized name of the Azure service. </param>
        /// <param name="status"> Status of the support ticket. </param>
        /// <param name="createdOn"> Time in UTC (ISO 8601 format) when the support ticket was created. </param>
        /// <param name="modifiedOn"> Time in UTC (ISO 8601 format) when the support ticket was last modified. </param>
        /// <param name="fileWorkspaceName"> File workspace name. </param>
        /// <param name="isTemporaryTicket"> This property indicates if support ticket is a temporary ticket. </param>
        /// <param name="technicalTicketDetailsResourceId"> Additional ticket details associated with a technical support ticket request. </param>
        /// <param name="quotaTicketDetails"> Additional ticket details associated with a quota support ticket request. </param>
        /// <param name="secondaryConsent"> This property indicates secondary consents for the support ticket. </param>
        /// <returns> A new <see cref="Support.SupportTicketData"/> instance for mocking. </returns>
        public static SupportTicketData SupportTicketData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string supportTicketId = null, string description = null, string problemClassificationId = null, string problemClassificationDisplayName = null, SupportSeverityLevel severity = default, string enrollmentId = null, bool? require24X7Response = null, AdvancedDiagnosticConsent advancedDiagnosticConsent = default, string problemScopingQuestions = null, string supportPlanId = null, SupportContactProfile contactDetails = null, SupportServiceLevelAgreement serviceLevelAgreement = null, string supportEngineerEmailAddress = null, string supportPlanType = null, string supportPlanDisplayName = null, string title = null, DateTimeOffset? problemStartOn = null, string serviceId = null, string serviceDisplayName = null, string status = null, DateTimeOffset? createdOn = null, DateTimeOffset? modifiedOn = null, string fileWorkspaceName = null, IsTemporaryTicket? isTemporaryTicket = null, ResourceIdentifier technicalTicketDetailsResourceId = null, QuotaTicketDetails quotaTicketDetails = null, IEnumerable<SecondaryConsent> secondaryConsent = null)
        {
            secondaryConsent ??= new List<SecondaryConsent>();

            return new SupportTicketData(
                id,
                name,
                resourceType,
                systemData,
                supportTicketId,
                description,
                problemClassificationId,
                problemClassificationDisplayName,
                severity,
                enrollmentId,
                require24X7Response,
                advancedDiagnosticConsent,
                problemScopingQuestions,
                supportPlanId,
                contactDetails,
                serviceLevelAgreement,
                supportEngineerEmailAddress != null ? new SupportEngineer(supportEngineerEmailAddress, serializedAdditionalRawData: null) : null,
                supportPlanType,
                supportPlanDisplayName,
                title,
                problemStartOn,
                serviceId,
                serviceDisplayName,
                status,
                createdOn,
                modifiedOn,
                fileWorkspaceName,
                isTemporaryTicket,
                technicalTicketDetailsResourceId != null ? new TechnicalTicketDetails(technicalTicketDetailsResourceId, serializedAdditionalRawData: null) : null,
                quotaTicketDetails,
                secondaryConsent?.ToList(),
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SupportServiceLevelAgreement"/>. </summary>
        /// <param name="startOn"> Time in UTC (ISO 8601 format) when the service level agreement starts. </param>
        /// <param name="expireOn"> Time in UTC (ISO 8601 format) when the service level agreement expires. </param>
        /// <param name="slaInMinutes"> Service Level Agreement in minutes. </param>
        /// <returns> A new <see cref="Models.SupportServiceLevelAgreement"/> instance for mocking. </returns>
        public static SupportServiceLevelAgreement SupportServiceLevelAgreement(DateTimeOffset? startOn = null, DateTimeOffset? expireOn = null, int? slaInMinutes = null)
        {
            return new SupportServiceLevelAgreement(startOn, expireOn, slaInMinutes, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Support.SupportTicketCommunicationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="communicationType"> Communication type. </param>
        /// <param name="communicationDirection"> Direction of communication. </param>
        /// <param name="sender"> Email address of the sender. This property is required if called by a service principal. </param>
        /// <param name="subject"> Subject of the communication. </param>
        /// <param name="body"> Body of the communication. </param>
        /// <param name="createdOn"> Time in UTC (ISO 8601 format) when the communication was created. </param>
        /// <returns> A new <see cref="Support.SupportTicketCommunicationData"/> instance for mocking. </returns>
        public static SupportTicketCommunicationData SupportTicketCommunicationData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, SupportTicketCommunicationType? communicationType = null, SupportTicketCommunicationDirection? communicationDirection = null, string sender = null, string subject = null, string body = null, DateTimeOffset? createdOn = null)
        {
            return new SupportTicketCommunicationData(
                id,
                name,
                resourceType,
                systemData,
                communicationType,
                communicationDirection,
                sender,
                subject,
                body,
                createdOn,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Support.ChatTranscriptDetailData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="messages"> List of chat transcript communication resources. </param>
        /// <param name="startOn"> Time in UTC (ISO 8601 format) when the chat began. </param>
        /// <returns> A new <see cref="Support.ChatTranscriptDetailData"/> instance for mocking. </returns>
        public static ChatTranscriptDetailData ChatTranscriptDetailData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IEnumerable<ChatTranscriptMessageProperties> messages = null, DateTimeOffset? startOn = null)
        {
            messages ??= new List<ChatTranscriptMessageProperties>();

            return new ChatTranscriptDetailData(
                id,
                name,
                resourceType,
                systemData,
                messages?.ToList(),
                startOn,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ChatTranscriptMessageProperties"/>. </summary>
        /// <param name="contentType"> Content type. </param>
        /// <param name="communicationDirection"> Direction of communication. </param>
        /// <param name="sender"> Name of the sender. </param>
        /// <param name="body"> Body of the communication. </param>
        /// <param name="createdOn"> Time in UTC (ISO 8601 format) when the communication was created. </param>
        /// <returns> A new <see cref="Models.ChatTranscriptMessageProperties"/> instance for mocking. </returns>
        public static ChatTranscriptMessageProperties ChatTranscriptMessageProperties(TranscriptContentType? contentType = null, SupportTicketCommunicationDirection? communicationDirection = null, string sender = null, string body = null, DateTimeOffset? createdOn = null)
        {
            return new ChatTranscriptMessageProperties(
                contentType,
                communicationDirection,
                sender,
                body,
                createdOn,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Support.FileWorkspaceDetailData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="createdOn"> Time in UTC (ISO 8601 format) when file workspace was created. </param>
        /// <param name="expireOn"> Time in UTC (ISO 8601 format) when file workspace is going to expire. </param>
        /// <returns> A new <see cref="Support.FileWorkspaceDetailData"/> instance for mocking. </returns>
        public static FileWorkspaceDetailData FileWorkspaceDetailData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DateTimeOffset? createdOn = null, DateTimeOffset? expireOn = null)
        {
            return new FileWorkspaceDetailData(
                id,
                name,
                resourceType,
                systemData,
                createdOn,
                expireOn,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Support.SupportFileDetailData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="createdOn"> Time in UTC (ISO 8601 format) when file workspace was created. </param>
        /// <param name="chunkSize"> Size of each chunk. The size of each chunk should be provided in bytes and must not exceed 2.5 megabytes (MB). </param>
        /// <param name="fileSize"> Size of the file to be uploaded. The file size must not exceed 5 MB and should be provided in bytes. </param>
        /// <param name="numberOfChunks"> Number of chunks to be uploaded. The maximum number of allowed chunks is 2. </param>
        /// <returns> A new <see cref="Support.SupportFileDetailData"/> instance for mocking. </returns>
        public static SupportFileDetailData SupportFileDetailData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DateTimeOffset? createdOn = null, int? chunkSize = null, int? fileSize = null, int? numberOfChunks = null)
        {
            return new SupportFileDetailData(
                id,
                name,
                resourceType,
                systemData,
                createdOn,
                chunkSize,
                fileSize,
                numberOfChunks,
                serializedAdditionalRawData: null);
        }
    }
}
