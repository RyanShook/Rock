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
    /// Registration GraphQL Type
    /// </summary>
    public partial class Registration : ModelGraphType<Rock.Model.Registration>
    {
       public Registration(): base("Registration")
       {
          Field("BalanceDue", x => x.BalanceDue, nullable: false);
          Field("ConfirmationEmail", x => x.ConfirmationEmail, nullable: false);
          Field("ContextKey", x => x.ContextKey, nullable: false);
          Field<Rock.GraphQL.Types.PersonAlias>("CreatedByPersonAlias", resolve: x => x.Source.CreatedByPersonAlias);
          Field("CreatedByPersonId", x => x.CreatedByPersonId, nullable: true);
          Field("CreatedByPersonName", x => x.CreatedByPersonName, nullable: false);
          Field("DiscountAmount", x => x.DiscountAmount, nullable: false);
          Field("DiscountCode", x => x.DiscountCode, nullable: false);
          Field("DiscountedCost", x => x.DiscountedCost, nullable: false);
          Field("DiscountPercentage", x => x.DiscountPercentage, nullable: false);
          Field("EncryptedKey", x => x.EncryptedKey, nullable: false);
          Field("FirstName", x => x.FirstName, nullable: false);
          Field("ForeignGuid", x => x.ForeignGuid.ToStringSafe(), nullable: true);
          Field("ForeignKey", x => x.ForeignKey, nullable: false);
          Field<Rock.GraphQL.Types.Group>("Group", resolve: x => x.Source.Group);
          Field("GroupId", x => x.GroupId, nullable: true);
          Field("IsTemporary", x => x.IsTemporary, nullable: false);
          Field("IsValid", x => x.IsValid, nullable: false);
          Field("LastName", x => x.LastName, nullable: false);
          Field("LastPaymentReminderDateTime", x => x.LastPaymentReminderDateTime, nullable: true);
          Field("ModifiedAuditValuesAlreadyUpdated", x => x.ModifiedAuditValuesAlreadyUpdated, nullable: false);
          Field<Rock.GraphQL.Types.PersonAlias>("ModifiedByPersonAlias", resolve: x => x.Source.ModifiedByPersonAlias);
          Field("ModifiedByPersonId", x => x.ModifiedByPersonId, nullable: true);
          Field("ModifiedByPersonName", x => x.ModifiedByPersonName, nullable: false);
          Field<Rock.GraphQL.Types.PersonAlias>("PersonAlias", resolve: x => x.Source.PersonAlias);
          Field("PersonAliasId", x => x.PersonAliasId, nullable: true);
          Field("PersonId", x => x.PersonId, nullable: true);
          Field<ListGraphType<Rock.GraphQL.Types.RegistrationRegistrant>>("Registrants", resolve: x => x.Source.Registrants);
          Field<Rock.GraphQL.Types.RegistrationInstance>("RegistrationInstance", resolve: x => x.Source.RegistrationInstance);
          Field("RegistrationInstanceId", x => x.RegistrationInstanceId, nullable: false);
          Field("TotalCost", x => x.TotalCost, nullable: false);
          Field("TotalPaid", x => x.TotalPaid, nullable: false);
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
       public override Rock.Model.Registration GetById(int id, GraphQLContext context)
       {
           var service = new Rock.Model.RegistrationService(context.db);
           return service.Get(id);
       }
   }
}
