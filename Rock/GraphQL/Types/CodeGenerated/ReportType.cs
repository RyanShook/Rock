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
    /// Report GraphQL Type
    /// </summary>
    public partial class Report : ModelGraphType<Rock.Model.Report>
    {
       public Report(): base("Report")
       {
          Field<Rock.GraphQL.Types.Category>("Category", resolve: x => x.Source.Category);
          Field("CategoryId", x => x.CategoryId, nullable: true);
          Field("ContextKey", x => x.ContextKey, nullable: false);
          Field<Rock.GraphQL.Types.PersonAlias>("CreatedByPersonAlias", resolve: x => x.Source.CreatedByPersonAlias);
          Field("CreatedByPersonId", x => x.CreatedByPersonId, nullable: true);
          Field("CreatedByPersonName", x => x.CreatedByPersonName, nullable: false);
          Field<Rock.GraphQL.Types.DataView>("DataView", resolve: x => x.Source.DataView);
          Field("DataViewId", x => x.DataViewId, nullable: true);
          Field("Description", x => x.Description, nullable: false);
          Field("EncryptedKey", x => x.EncryptedKey, nullable: false);
          Field<Rock.GraphQL.Types.EntityType>("EntityType", resolve: x => x.Source.EntityType);
          Field("EntityTypeId", x => x.EntityTypeId, nullable: true);
          Field("FetchTop", x => x.FetchTop, nullable: true);
          Field("ForeignGuid", x => x.ForeignGuid.ToStringSafe(), nullable: true);
          Field("ForeignKey", x => x.ForeignKey, nullable: false);
          Field("IsSystem", x => x.IsSystem, nullable: false);
          Field("IsValid", x => x.IsValid, nullable: false);
          Field("ModifiedAuditValuesAlreadyUpdated", x => x.ModifiedAuditValuesAlreadyUpdated, nullable: false);
          Field<Rock.GraphQL.Types.PersonAlias>("ModifiedByPersonAlias", resolve: x => x.Source.ModifiedByPersonAlias);
          Field("ModifiedByPersonId", x => x.ModifiedByPersonId, nullable: true);
          Field("ModifiedByPersonName", x => x.ModifiedByPersonName, nullable: false);
          Field("Name", x => x.Name, nullable: false);
          Field<ListGraphType<Rock.GraphQL.Types.ReportField>>("ReportFields", resolve: x => x.Source.ReportFields);
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
       public override Rock.Model.Report GetById(int id, GraphQLContext context)
       {
           var service = new Rock.Model.ReportService(context.db);
           return service.Get(id);
       }
   }
}
