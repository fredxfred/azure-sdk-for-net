// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The integration account.
    /// </summary>
    public partial class IntegrationAccount : Resource
    {
        /// <summary>
        /// Initializes a new instance of the IntegrationAccount class.
        /// </summary>
        public IntegrationAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IntegrationAccount class.
        /// </summary>
        /// <param name="id">The resource id.</param>
        /// <param name="name">Gets the resource name.</param>
        /// <param name="type">Gets the resource type.</param>
        /// <param name="location">The resource location.</param>
        /// <param name="tags">The resource tags.</param>
        /// <param name="properties">The integration account
        /// properties.</param>
        /// <param name="sku">The sku.</param>
        public IntegrationAccount(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), object properties = default(object), IntegrationAccountSku sku = default(IntegrationAccountSku))
            : base(id, name, type, location, tags)
        {
            Properties = properties;
            Sku = sku;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the integration account properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public object Properties { get; set; }

        /// <summary>
        /// Gets or sets the sku.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public IntegrationAccountSku Sku { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
