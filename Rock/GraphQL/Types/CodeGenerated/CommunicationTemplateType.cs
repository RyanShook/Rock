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
    /// CommunicationTemplate GraphQL Type
    /// </summary>
    public partial class CommunicationTemplate : ModelGraphType<Rock.Model.CommunicationTemplate>
    {
       public CommunicationTemplate(): base("CommunicationTemplate")
       {
          Field("ContextKey", x => x.ContextKey, nullable: false);
          Field<Rock.GraphQL.Types.PersonAlias>("CreatedByPersonAlias", resolve: x => x.Source.CreatedByPersonAlias);
          Field("CreatedByPersonId", x => x.CreatedByPersonId, nullable: true);
          Field("CreatedByPersonName", x => x.CreatedByPersonName, nullable: false);
          Field("Description", x => x.Description, nullable: false);
          Field("EncryptedKey", x => x.EncryptedKey, nullable: false);
          Field("ForeignGuid", x => x.ForeignGuid.ToStringSafe(), nullable: true);
          Field("ForeignKey", x => x.ForeignKey, nullable: false);
          Field("IsValid", x => x.IsValid, nullable: false);
          Field("MediumDataJson", x => x.MediumDataJson, nullable: false);
          Field<Rock.GraphQL.Types.EntityType>("MediumEntityType", resolve: x => x.Source.MediumEntityType);
          Field("MediumEntityTypeId", x => x.MediumEntityTypeId, nullable: true);
          Field("ModifiedAuditValuesAlreadyUpdated", x => x.ModifiedAuditValuesAlreadyUpdated, nullable: false);
          Field<Rock.GraphQL.Types.PersonAlias>("ModifiedByPersonAlias", resolve: x => x.Source.ModifiedByPersonAlias);
          Field("ModifiedByPersonId", x => x.ModifiedByPersonId, nullable: true);
          Field("ModifiedByPersonName", x => x.ModifiedByPersonName, nullable: false);
          Field("Name", x => x.Name, nullable: false);
          Field<Rock.GraphQL.Types.PersonAlias>("SenderPersonAlias", resolve: x => x.Source.SenderPersonAlias);
          Field("SenderPersonAliasId", x => x.SenderPersonAliasId, nullable: true);
          Field("Subject", x => x.Subject, nullable: false);
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
       public override Rock.Model.CommunicationTemplate GetById(int id, GraphQLContext context)
       {
           var service = new Rock.Model.CommunicationTemplateService(context.db);
           return service.Get(id);
       }
   }
}
