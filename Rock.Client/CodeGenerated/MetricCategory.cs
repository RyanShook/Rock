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
    /// Base client model for MetricCategory that only includes the non-virtual fields. Use this for PUT/POSTs
    /// </summary>
    public partial class MetricCategoryEntity
    {
        /// <summary />
        public int Id { get; set; }

        /// <summary />
        public int CategoryId { get; set; }

        /// <summary />
        public Guid? ForeignGuid { get; set; }

        /// <summary />
        public string ForeignKey { get; set; }

        /// <summary />
        public int MetricId { get; set; }

        /// <summary />
        public int Order { get; set; }

        /// <summary />
        public Guid Guid { get; set; }

        /// <summary />
        public int? ForeignId { get; set; }

        /// <summary>
        /// Copies the base properties from a source MetricCategory object
        /// </summary>
        /// <param name="source">The source.</param>
        public void CopyPropertiesFrom( MetricCategory source )
        {
            this.Id = source.Id;
            this.CategoryId = source.CategoryId;
            this.ForeignGuid = source.ForeignGuid;
            this.ForeignKey = source.ForeignKey;
            this.MetricId = source.MetricId;
            this.Order = source.Order;
            this.Guid = source.Guid;
            this.ForeignId = source.ForeignId;

        }
    }

    /// <summary>
    /// Client model for MetricCategory that includes all the fields that are available for GETs. Use this for GETs (use MetricCategoryEntity for POST/PUTs)
    /// </summary>
    public partial class MetricCategory : MetricCategoryEntity
    {
        /// <summary />
        public Category Category { get; set; }

        /// <summary />
        public Metric Metric { get; set; }

    }
}
