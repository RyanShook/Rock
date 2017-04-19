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
    /// MetricCategory GraphQL Type
    /// </summary>
    public partial class MetricCategory : ModelGraphType<Rock.Model.MetricCategory>
    {
       public MetricCategory(): base("MetricCategory")
       {
          Field<Rock.GraphQL.Types.Category>("Category", resolve: x => x.Source.Category);
          Field("CategoryId", x => x.CategoryId, nullable: false);
          Field("ContextKey", x => x.ContextKey, nullable: false);
          Field("EncryptedKey", x => x.EncryptedKey, nullable: false);
          Field("ForeignGuid", x => x.ForeignGuid.ToStringSafe(), nullable: true);
          Field("ForeignKey", x => x.ForeignKey, nullable: false);
          Field("IconCssClass", x => x.IconCssClass, nullable: false);
          Field("IsValid", x => x.IsValid, nullable: false);
          Field<Rock.GraphQL.Types.Metric>("Metric", resolve: x => x.Source.Metric);
          Field("MetricId", x => x.MetricId, nullable: false);
          Field("Name", x => x.Name, nullable: false);
          Field("Order", x => x.Order, nullable: false);
          Field("TypeId", x => x.TypeId, nullable: false);
          Field("TypeName", x => x.TypeName, nullable: false);
          Field("UrlEncodedKey", x => x.UrlEncodedKey, nullable: false);
          Field("Guid", x => x.Guid.ToStringSafe(), nullable: false);
          Field("ForeignId", x => x.ForeignId, nullable: true);
       }
       public override Rock.Model.MetricCategory GetById(int id, GraphQLContext context)
       {
           var service = new Rock.Model.MetricCategoryService(context.db);
           return service.Get(id);
       }
   }
}
