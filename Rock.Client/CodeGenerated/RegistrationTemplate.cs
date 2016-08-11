//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.Collections.Generic;


namespace Rock.Client
{
    /// <summary>
    /// Base client model for RegistrationTemplate that only includes the non-virtual fields. Use this for PUT/POSTs
    /// </summary>
    public partial class RegistrationTemplateEntity
    {
        /// <summary />
        public int Id { get; set; }

        /// <summary />
        public bool AddPersonNote { get; set; }

        /// <summary />
        public bool AllowExternalRegistrationUpdates { get; set; }

        /// <summary />
        public bool AllowGroupPlacement { get; set; }

        /// <summary />
        public bool AllowMultipleRegistrants { get; set; }

        /// <summary />
        public string BatchNamePrefix { get; set; }

        /// <summary />
        public int? CategoryId { get; set; }

        /// <summary />
        public string ConfirmationEmailTemplate { get; set; }

        /// <summary />
        public string ConfirmationFromEmail { get; set; }

        /// <summary />
        public string ConfirmationFromName { get; set; }

        /// <summary />
        public string ConfirmationSubject { get; set; }

        /// <summary />
        public decimal Cost { get; set; }

        /// <summary />
        public string DiscountCodeTerm { get; set; }

        /// <summary />
        public string FeeTerm { get; set; }

        /// <summary />
        public int? FinancialGatewayId { get; set; }

        /// <summary />
        public Guid? ForeignGuid { get; set; }

        /// <summary />
        public string ForeignKey { get; set; }

        /// <summary />
        public int? GroupMemberRoleId { get; set; }

        /// <summary />
        public Rock.Client.Enums.GroupMemberStatus GroupMemberStatus { get; set; }

        /// <summary />
        public int? GroupTypeId { get; set; }

        /// <summary />
        public bool IsActive { get; set; }

        /// <summary />
        public bool LoginRequired { get; set; }

        /// <summary />
        public int MaxRegistrants { get; set; }

        /// <summary />
        public decimal? MinimumInitialPayment { get; set; }

        /// <summary>
        /// If the ModifiedByPersonAliasId is being set manually and should not be overwritten with current user when saved, set this value to true
        /// </summary>
        public bool ModifiedAuditValuesAlreadyUpdated { get; set; }

        /// <summary />
        public string Name { get; set; }

        /// <summary />
        public Rock.Client.Enums.RegistrationNotify Notify { get; set; }

        /// <summary />
        public string PaymentReminderEmailTemplate { get; set; }

        /// <summary />
        public string PaymentReminderFromEmail { get; set; }

        /// <summary />
        public string PaymentReminderFromName { get; set; }

        /// <summary />
        public string PaymentReminderSubject { get; set; }

        /// <summary />
        public int? PaymentReminderTimeSpan { get; set; }

        /// <summary />
        public Rock.Client.Enums.RegistrantsSameFamily RegistrantsSameFamily { get; set; }

        /// <summary />
        public string RegistrantTerm { get; set; }

        /// <summary />
        public string RegistrationTerm { get; set; }

        /// <summary />
        public int? RegistrationWorkflowTypeId { get; set; }

        /// <summary />
        public string ReminderEmailTemplate { get; set; }

        /// <summary />
        public string ReminderFromEmail { get; set; }

        /// <summary />
        public string ReminderFromName { get; set; }

        /// <summary />
        public string ReminderSubject { get; set; }

        /// <summary />
        public string RequestEntryName { get; set; }

        /// <summary />
        public int? RequiredSignatureDocumentTypeId { get; set; }

        /// <summary />
        public bool? SetCostOnInstance { get; set; }

        /// <summary />
        public Rock.Client.Enums.SignatureDocumentAction SignatureDocumentAction { get; set; }

        /// <summary />
        public string SuccessText { get; set; }

        /// <summary />
        public string SuccessTitle { get; set; }

        /// <summary>
        /// Leave this as NULL to let Rock set this
        /// </summary>
        public DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// This does not need to be set or changed. Rock will always set this to the current date/time when saved to the database.
        /// </summary>
        public DateTime? ModifiedDateTime { get; set; }

        /// <summary>
        /// Leave this as NULL to let Rock set this
        /// </summary>
        public int? CreatedByPersonAliasId { get; set; }

        /// <summary>
        /// If you need to set this manually, set ModifiedAuditValuesAlreadyUpdated=True to prevent Rock from setting it
        /// </summary>
        public int? ModifiedByPersonAliasId { get; set; }

        /// <summary />
        public Guid Guid { get; set; }

        /// <summary />
        public int? ForeignId { get; set; }

        /// <summary>
        /// Copies the base properties from a source RegistrationTemplate object
        /// </summary>
        /// <param name="source">The source.</param>
        public void CopyPropertiesFrom( RegistrationTemplate source )
        {
            this.Id = source.Id;
            this.AddPersonNote = source.AddPersonNote;
            this.AllowExternalRegistrationUpdates = source.AllowExternalRegistrationUpdates;
            this.AllowGroupPlacement = source.AllowGroupPlacement;
            this.AllowMultipleRegistrants = source.AllowMultipleRegistrants;
            this.BatchNamePrefix = source.BatchNamePrefix;
            this.CategoryId = source.CategoryId;
            this.ConfirmationEmailTemplate = source.ConfirmationEmailTemplate;
            this.ConfirmationFromEmail = source.ConfirmationFromEmail;
            this.ConfirmationFromName = source.ConfirmationFromName;
            this.ConfirmationSubject = source.ConfirmationSubject;
            this.Cost = source.Cost;
            this.DiscountCodeTerm = source.DiscountCodeTerm;
            this.FeeTerm = source.FeeTerm;
            this.FinancialGatewayId = source.FinancialGatewayId;
            this.ForeignGuid = source.ForeignGuid;
            this.ForeignKey = source.ForeignKey;
            this.GroupMemberRoleId = source.GroupMemberRoleId;
            this.GroupMemberStatus = source.GroupMemberStatus;
            this.GroupTypeId = source.GroupTypeId;
            this.IsActive = source.IsActive;
            this.LoginRequired = source.LoginRequired;
            this.MaxRegistrants = source.MaxRegistrants;
            this.MinimumInitialPayment = source.MinimumInitialPayment;
            this.ModifiedAuditValuesAlreadyUpdated = source.ModifiedAuditValuesAlreadyUpdated;
            this.Name = source.Name;
            this.Notify = source.Notify;
            this.PaymentReminderEmailTemplate = source.PaymentReminderEmailTemplate;
            this.PaymentReminderFromEmail = source.PaymentReminderFromEmail;
            this.PaymentReminderFromName = source.PaymentReminderFromName;
            this.PaymentReminderSubject = source.PaymentReminderSubject;
            this.PaymentReminderTimeSpan = source.PaymentReminderTimeSpan;
            this.RegistrantsSameFamily = source.RegistrantsSameFamily;
            this.RegistrantTerm = source.RegistrantTerm;
            this.RegistrationTerm = source.RegistrationTerm;
            this.RegistrationWorkflowTypeId = source.RegistrationWorkflowTypeId;
            this.ReminderEmailTemplate = source.ReminderEmailTemplate;
            this.ReminderFromEmail = source.ReminderFromEmail;
            this.ReminderFromName = source.ReminderFromName;
            this.ReminderSubject = source.ReminderSubject;
            this.RequestEntryName = source.RequestEntryName;
            this.RequiredSignatureDocumentTypeId = source.RequiredSignatureDocumentTypeId;
            this.SetCostOnInstance = source.SetCostOnInstance;
            this.SignatureDocumentAction = source.SignatureDocumentAction;
            this.SuccessText = source.SuccessText;
            this.SuccessTitle = source.SuccessTitle;
            this.CreatedDateTime = source.CreatedDateTime;
            this.ModifiedDateTime = source.ModifiedDateTime;
            this.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            this.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            this.Guid = source.Guid;
            this.ForeignId = source.ForeignId;

        }
    }

    /// <summary>
    /// Client model for RegistrationTemplate that includes all the fields that are available for GETs. Use this for GETs (use RegistrationTemplateEntity for POST/PUTs)
    /// </summary>
    public partial class RegistrationTemplate : RegistrationTemplateEntity
    {
        /// <summary />
        public ICollection<RegistrationTemplateDiscount> Discounts { get; set; }

        /// <summary />
        public ICollection<RegistrationTemplateFee> Fees { get; set; }

        /// <summary />
        public FinancialGateway FinancialGateway { get; set; }

        /// <summary />
        public ICollection<RegistrationTemplateForm> Forms { get; set; }

        /// <summary />
        public WorkflowType RegistrationWorkflowType { get; set; }

        /// <summary />
        public SignatureDocumentType RequiredSignatureDocumentType { get; set; }

        /// <summary>
        /// NOTE: Attributes are only populated when ?loadAttributes is specified. Options for loadAttributes are true, false, 'simple', 'expanded' 
        /// </summary>
        public Dictionary<string, Rock.Client.Attribute> Attributes { get; set; }

        /// <summary>
        /// NOTE: AttributeValues are only populated when ?loadAttributes is specified. Options for loadAttributes are true, false, 'simple', 'expanded' 
        /// </summary>
        public Dictionary<string, Rock.Client.AttributeValue> AttributeValues { get; set; }
    }
}
