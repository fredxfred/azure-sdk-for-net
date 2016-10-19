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
    /// Defines the SKU of an Azure Search Service, which determines price
    /// tier and capacity limits.
    /// </summary>
    public partial class Sku
    {
        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        public Sku() { }

        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        /// <param name="name">The SKU of the Search service. Possible values
        /// include: 'free', 'basic', 'standard', 'standard2',
        /// 'standard3'</param>
        public Sku(SkuName? name = default(SkuName?))
        {
            Name = name;
        }

        /// <summary>
        /// Gets or sets the SKU of the Search service. Possible values
        /// include: 'free', 'basic', 'standard', 'standard2', 'standard3'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public SkuName? Name { get; set; }

    }
}
