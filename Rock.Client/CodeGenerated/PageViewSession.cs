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
    /// Base client model for PageViewSession that only includes the non-virtual fields. Use this for PUT/POSTs
    /// </summary>
    public partial class PageViewSessionEntity
    {
        /// <summary />
        public int Id { get; set; }

        /// <summary />
        public Guid? ForeignGuid { get; set; }

        /// <summary />
        public string ForeignKey { get; set; }

        /// <summary />
        public string IpAddress { get; set; }

        /// <summary />
        public int PageViewUserAgentId { get; set; }

        /// <summary />
        public Guid? SessionId { get; set; }

        /// <summary />
        public Guid Guid { get; set; }

        /// <summary />
        public int? ForeignId { get; set; }

        /// <summary>
        /// Copies the base properties from a source PageViewSession object
        /// </summary>
        /// <param name="source">The source.</param>
        public void CopyPropertiesFrom( PageViewSession source )
        {
            this.Id = source.Id;
            this.ForeignGuid = source.ForeignGuid;
            this.ForeignKey = source.ForeignKey;
            this.IpAddress = source.IpAddress;
            this.PageViewUserAgentId = source.PageViewUserAgentId;
            this.SessionId = source.SessionId;
            this.Guid = source.Guid;
            this.ForeignId = source.ForeignId;

        }
    }

    /// <summary>
    /// Client model for PageViewSession that includes all the fields that are available for GETs. Use this for GETs (use PageViewSessionEntity for POST/PUTs)
    /// </summary>
    public partial class PageViewSession : PageViewSessionEntity
    {
    }
}