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
    /// AttributeQualifier GraphQL Type
    /// </summary>
    public partial class AttributeQualifier : ModelGraphType<Rock.Model.AttributeQualifier>
    {
       public AttributeQualifier(): base("AttributeQualifier")
       {
          Field<Rock.GraphQL.Types.Attribute>("Attribute", resolve: x => x.Source.Attribute);
          Field("AttributeId", x => x.AttributeId, nullable: false);
          Field("ContextKey", x => x.ContextKey, nullable: false);
          Field("EncryptedKey", x => x.EncryptedKey, nullable: false);
          Field("ForeignGuid", x => x.ForeignGuid.ToStringSafe(), nullable: true);
          Field("ForeignKey", x => x.ForeignKey, nullable: false);
          Field("IsSystem", x => x.IsSystem, nullable: false);
          Field("IsValid", x => x.IsValid, nullable: false);
          Field("Key", x => x.Key, nullable: false);
          Field("TypeId", x => x.TypeId, nullable: false);
          Field("TypeName", x => x.TypeName, nullable: false);
          Field("UrlEncodedKey", x => x.UrlEncodedKey, nullable: false);
          Field("Value", x => x.Value, nullable: false);
          Field("Guid", x => x.Guid.ToStringSafe(), nullable: false);
          Field("ForeignId", x => x.ForeignId, nullable: true);
       }
       public override Rock.Model.AttributeQualifier GetById(int id, GraphQLContext context)
       {
           var service = new Rock.Model.AttributeQualifierService(context.db);
           return service.Get(id);
       }
   }
}
