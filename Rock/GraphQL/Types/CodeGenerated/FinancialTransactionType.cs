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

using GraphQL;
using GraphQL.Types;
using Rock.Model;

namespace Rock.GraphQL.Types
{
    /// <summary>
    /// FinancialTransaction GraphQL Type
    /// </summary>
    public partial class FinancialTransaction : ModelGraphType<Rock.Model.FinancialTransaction>
    {
       public FinancialTransaction(): base("FinancialTransaction")
       {
          Field<Rock.GraphQL.Types.PersonAlias>("AuthorizedPersonAlias", resolve: x => x.Source.AuthorizedPersonAlias);
          Field("AuthorizedPersonAliasId", x => x.AuthorizedPersonAliasId, nullable: true);
          Field<Rock.GraphQL.Types.FinancialBatch>("Batch", resolve: x => x.Source.Batch);
          Field("BatchId", x => x.BatchId, nullable: true);
          Field("CheckMicrEncrypted", x => x.CheckMicrEncrypted, nullable: false);
          Field("CheckMicrHash", x => x.CheckMicrHash, nullable: false);
          Field("CheckMicrParts", x => x.CheckMicrParts, nullable: false);
          Field("ContextKey", x => x.ContextKey, nullable: false);
          Field<Rock.GraphQL.Types.PersonAlias>("CreatedByPersonAlias", resolve: x => x.Source.CreatedByPersonAlias);
          Field("CreatedByPersonId", x => x.CreatedByPersonId, nullable: true);
          Field("CreatedByPersonName", x => x.CreatedByPersonName, nullable: false);
          Field("EncryptedKey", x => x.EncryptedKey, nullable: false);
          Field<Rock.GraphQL.Types.FinancialGateway>("FinancialGateway", resolve: x => x.Source.FinancialGateway);
          Field("FinancialGatewayId", x => x.FinancialGatewayId, nullable: true);
          Field<Rock.GraphQL.Types.FinancialPaymentDetail>("FinancialPaymentDetail", resolve: x => x.Source.FinancialPaymentDetail);
          Field("FinancialPaymentDetailId", x => x.FinancialPaymentDetailId, nullable: true);
          Field("ForeignGuid", x => x.ForeignGuid.ToStringSafe(), nullable: true);
          Field("ForeignKey", x => x.ForeignKey, nullable: false);
          Field<ListGraphType<Rock.GraphQL.Types.FinancialTransactionImage>>("Images", resolve: x => x.Source.Images);
          Field("IsReconciled", x => x.IsReconciled, nullable: true);
          Field("IsSettled", x => x.IsSettled, nullable: true);
          Field("IsValid", x => x.IsValid, nullable: false);
          Field("MICRStatus", x => x.MICRStatus.ConvertToInt(), nullable: true);
          Field("ModifiedAuditValuesAlreadyUpdated", x => x.ModifiedAuditValuesAlreadyUpdated, nullable: false);
          Field<Rock.GraphQL.Types.PersonAlias>("ModifiedByPersonAlias", resolve: x => x.Source.ModifiedByPersonAlias);
          Field("ModifiedByPersonId", x => x.ModifiedByPersonId, nullable: true);
          Field("ModifiedByPersonName", x => x.ModifiedByPersonName, nullable: false);
          Field<Rock.GraphQL.Types.PersonAlias>("ProcessedByPersonAlias", resolve: x => x.Source.ProcessedByPersonAlias);
          Field("ProcessedByPersonAliasId", x => x.ProcessedByPersonAliasId, nullable: true);
          Field("ProcessedDateTime", x => x.ProcessedDateTime, nullable: true);
          Field<Rock.GraphQL.Types.FinancialTransactionRefund>("RefundDetails", resolve: x => x.Source.RefundDetails);
          Field<ListGraphType<Rock.GraphQL.Types.FinancialTransactionRefund>>("Refunds", resolve: x => x.Source.Refunds);
          Field<Rock.GraphQL.Types.FinancialScheduledTransaction>("ScheduledTransaction", resolve: x => x.Source.ScheduledTransaction);
          Field("ScheduledTransactionId", x => x.ScheduledTransactionId, nullable: true);
          Field("SettledDate", x => x.SettledDate, nullable: true);
          Field("SettledGroupId", x => x.SettledGroupId, nullable: false);
          Field<Rock.GraphQL.Types.DefinedValue>("SourceTypeValue", resolve: x => x.Source.SourceTypeValue);
          Field("SourceTypeValueId", x => x.SourceTypeValueId, nullable: true);
          Field("Status", x => x.Status, nullable: false);
          Field("StatusMessage", x => x.StatusMessage, nullable: false);
          Field("Summary", x => x.Summary, nullable: false);
          Field("SundayDate", x => x.SundayDate, nullable: true);
          Field("TotalAmount", x => x.TotalAmount, nullable: false);
          Field("TransactionCode", x => x.TransactionCode, nullable: false);
          Field("TransactionDateTime", x => x.TransactionDateTime, nullable: true);
          Field<ListGraphType<Rock.GraphQL.Types.FinancialTransactionDetail>>("TransactionDetails", resolve: x => x.Source.TransactionDetails);
          Field<Rock.GraphQL.Types.DefinedValue>("TransactionTypeValue", resolve: x => x.Source.TransactionTypeValue);
          Field("TransactionTypeValueId", x => x.TransactionTypeValueId, nullable: false);
          Field("TypeId", x => x.TypeId, nullable: false);
          Field("TypeName", x => x.TypeName, nullable: false);
          Field("UrlEncodedKey", x => x.UrlEncodedKey, nullable: false);
          Field("CreatedDateTime", x => x.CreatedDateTime, nullable: true);
          Field("ModifiedDateTime", x => x.ModifiedDateTime, nullable: true);
          Field("CreatedByPersonAliasId", x => x.CreatedByPersonAliasId, nullable: true);
          Field("ModifiedByPersonAliasId", x => x.ModifiedByPersonAliasId, nullable: true);
          Field("Guid", x => x.Guid.ToStringSafe(), nullable: false);
          Field("ForeignId", x => x.ForeignId, nullable: true);
       }
       public override Rock.Model.FinancialTransaction GetById(int id, GraphQLContext context)
       {
           var service = new Rock.Model.FinancialTransactionService(context.db);
           return service.Get(id);
       }
   }
}
