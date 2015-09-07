//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright 2013 by the Spark Development Network
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.Linq;

using Rock.Data;

namespace Rock.Model
{
    /// <summary>
    /// EventItem Service class
    /// </summary>
    public partial class EventItemService : Service<EventItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventItemService"/> class
        /// </summary>
        /// <param name="context">The context.</param>
        public EventItemService(RockContext context) : base(context)
        {
        }

        /// <summary>
        /// Determines whether this instance can delete the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <returns>
        ///   <c>true</c> if this instance can delete the specified item; otherwise, <c>false</c>.
        /// </returns>
        public bool CanDelete( EventItem item, out string errorMessage )
        {
            errorMessage = string.Empty;
            return true;
        }
    }

    /// <summary>
    /// Generated Extension Methods
    /// </summary>
    public static partial class EventItemExtensionMethods
    {
        /// <summary>
        /// Clones this EventItem object to a new EventItem object
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="deepCopy">if set to <c>true</c> a deep copy is made. If false, only the basic entity properties are copied.</param>
        /// <returns></returns>
        public static EventItem Clone( this EventItem source, bool deepCopy )
        {
            if (deepCopy)
            {
                return source.Clone() as EventItem;
            }
            else
            {
                var target = new EventItem();
                target.CopyPropertiesFrom( source );
                return target;
            }
        }

        /// <summary>
        /// Copies the properties from another EventItem object to this EventItem object
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="source">The source.</param>
        public static void CopyPropertiesFrom( this EventItem target, EventItem source )
        {
            target.Id = source.Id;
            target.ApprovedByPersonAliasId = source.ApprovedByPersonAliasId;
            target.ApprovedOnDateTime = source.ApprovedOnDateTime;
            target.Description = source.Description;
            target.DetailsUrl = source.DetailsUrl;
            target.ForeignGuid = source.ForeignGuid;
            target.ForeignKey = source.ForeignKey;
            target.IsActive = source.IsActive;
            target.IsApproved = source.IsApproved;
            target.Name = source.Name;
            target.PhotoId = source.PhotoId;
            target.Summary = source.Summary;
            target.CreatedDateTime = source.CreatedDateTime;
            target.ModifiedDateTime = source.ModifiedDateTime;
            target.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            target.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            target.Guid = source.Guid;
            target.ForeignId = source.ForeignId;

        }
    }
}
