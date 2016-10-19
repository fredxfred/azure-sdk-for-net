// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Search.Models
{
    using System.Linq;

    /// <summary>
    /// Response containing a list of Azure Search services for a given
    /// resource group.
    /// </summary>
    public partial class SearchServiceListResult
    {
        /// <summary>
        /// Initializes a new instance of the SearchServiceListResult class.
        /// </summary>
        public SearchServiceListResult() { }

        /// <summary>
        /// Initializes a new instance of the SearchServiceListResult class.
        /// </summary>
        /// <param name="services">The Search services in the resource
        /// group.</param>
        public SearchServiceListResult(System.Collections.Generic.IList<SearchService> services = default(System.Collections.Generic.IList<SearchService>))
        {
            Services = services;
        }

        /// <summary>
        /// Gets the Search services in the resource group.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<SearchService> Services { get; private set; }

    }
}
