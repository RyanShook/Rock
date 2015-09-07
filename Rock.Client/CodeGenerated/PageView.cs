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
    /// Base client model for PageView that only includes the non-virtual fields. Use this for PUT/POSTs
    /// </summary>
    public partial class PageViewEntity
    {
        /// <summary />
        public int Id { get; set; }

        /// <summary />
        public string ClientType { get; set; }

        /// <summary />
        public DateTime? DateTimeViewed { get; set; }

        /// <summary />
        public Guid? ForeignGuid { get; set; }

        /// <summary />
        public string ForeignKey { get; set; }

        /// <summary />
        public string IpAddress { get; set; }

        /// <summary />
        public int? PageId { get; set; }

        /// <summary />
        public string PageTitle { get; set; }

        /// <summary />
        public int? PersonAliasId { get; set; }

        /// <summary />
        public Guid? SessionId { get; set; }

        /// <summary />
        public int? SiteId { get; set; }

        /// <summary />
        public string Url { get; set; }

        /// <summary />
        public string UserAgent { get; set; }

        /// <summary />
        public Guid Guid { get; set; }

        /// <summary />
        public int? ForeignId { get; set; }

        /// <summary>
        /// Copies the base properties from a source PageView object
        /// </summary>
        /// <param name="source">The source.</param>
        public void CopyPropertiesFrom( PageView source )
        {
            this.Id = source.Id;
            this.ClientType = source.ClientType;
            this.DateTimeViewed = source.DateTimeViewed;
            this.ForeignGuid = source.ForeignGuid;
            this.ForeignKey = source.ForeignKey;
            this.IpAddress = source.IpAddress;
            this.PageId = source.PageId;
            this.PageTitle = source.PageTitle;
            this.PersonAliasId = source.PersonAliasId;
            this.SessionId = source.SessionId;
            this.SiteId = source.SiteId;
            this.Url = source.Url;
            this.UserAgent = source.UserAgent;
            this.Guid = source.Guid;
            this.ForeignId = source.ForeignId;

        }
    }

    /// <summary>
    /// Client model for PageView that includes all the fields that are available for GETs. Use this for GETs (use PageViewEntity for POST/PUTs)
    /// </summary>
    public partial class PageView : PageViewEntity
    {
        /// <summary />
        public PersonAlias PersonAlias { get; set; }

    }
}
