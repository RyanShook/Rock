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
using System.Collections.Generic;


namespace Rock.Client
{
    /// <summary>
    /// Base client model for EventItemOccurrence that only includes the non-virtual fields. Use this for PUT/POSTs
    /// </summary>
    public partial class EventItemOccurrenceEntity
    {
        /// <summary />
        public int Id { get; set; }

        /// <summary />
        public int? CampusId { get; set; }

        /// <summary />
        public string ContactEmail { get; set; }

        /// <summary />
        public int? ContactPersonAliasId { get; set; }

        /// <summary />
        public string ContactPhone { get; set; }

        /// <summary />
        public int EventItemId { get; set; }

        /// <summary />
        public Guid? ForeignGuid { get; set; }

        /// <summary />
        public string ForeignKey { get; set; }

        /// <summary />
        public string Location { get; set; }

        /// <summary />
        public string Note { get; set; }

        /// <summary />
        public int? ScheduleId { get; set; }

        /// <summary />
        public Guid Guid { get; set; }

        /// <summary />
        public int? ForeignId { get; set; }

        /// <summary>
        /// Copies the base properties from a source EventItemOccurrence object
        /// </summary>
        /// <param name="source">The source.</param>
        public void CopyPropertiesFrom( EventItemOccurrence source )
        {
            this.Id = source.Id;
            this.CampusId = source.CampusId;
            this.ContactEmail = source.ContactEmail;
            this.ContactPersonAliasId = source.ContactPersonAliasId;
            this.ContactPhone = source.ContactPhone;
            this.EventItemId = source.EventItemId;
            this.ForeignGuid = source.ForeignGuid;
            this.ForeignKey = source.ForeignKey;
            this.Location = source.Location;
            this.Note = source.Note;
            this.ScheduleId = source.ScheduleId;
            this.Guid = source.Guid;
            this.ForeignId = source.ForeignId;

        }
    }

    /// <summary>
    /// Client model for EventItemOccurrence that includes all the fields that are available for GETs. Use this for GETs (use EventItemOccurrenceEntity for POST/PUTs)
    /// </summary>
    public partial class EventItemOccurrence : EventItemOccurrenceEntity
    {
        /// <summary />
        public Campus Campus { get; set; }

        /// <summary />
        public PersonAlias ContactPersonAlias { get; set; }

        /// <summary />
        public ICollection<EventItemOccurrenceChannelItem> ContentChannelItems { get; set; }

        /// <summary />
        public ICollection<EventItemOccurrenceGroupMap> Linkages { get; set; }

        /// <summary />
        public Schedule Schedule { get; set; }

        /// <summary />
        public DateTime? CreatedDateTime { get; set; }

        /// <summary />
        public DateTime? ModifiedDateTime { get; set; }

        /// <summary />
        public int? CreatedByPersonAliasId { get; set; }

        /// <summary />
        public int? ModifiedByPersonAliasId { get; set; }

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
