// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters that can be provided when updating the storage account
    /// properties.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class StorageAccountUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccountUpdateParameters
        /// class.
        /// </summary>
        public StorageAccountUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageAccountUpdateParameters
        /// class.
        /// </summary>
        /// <param name="sku">Gets or sets the SKU name. Note that the SKU name
        /// cannot be updated to Standard_ZRS, Premium_LRS or Premium_ZRS, nor
        /// can accounts of those SKU names be updated to any other
        /// value.</param>
        /// <param name="tags">Gets or sets a list of key value pairs that
        /// describe the resource. These tags can be used in viewing and
        /// grouping this resource (across resource groups). A maximum of 15
        /// tags can be provided for a resource. Each tag must have a key no
        /// greater in length than 128 characters and a value no greater in
        /// length than 256 characters.</param>
        /// <param name="identity">The identity of the resource.</param>
        /// <param name="customDomain">Custom domain assigned to the storage
        /// account by the user. Name is the CNAME source. Only one custom
        /// domain is supported per storage account at this time. To clear the
        /// existing custom domain, use an empty string for the custom domain
        /// name property.</param>
        /// <param name="encryption">Provides the encryption settings on the
        /// account. The default setting is unencrypted.</param>
        /// <param name="accessTier">Required for storage accounts where kind =
        /// BlobStorage. The access tier used for billing. Possible values
        /// include: 'Hot', 'Cool'</param>
        /// <param name="enableAzureFilesAadIntegration">Enables Azure Files
        /// AAD Integration for SMB if sets to true.</param>
        /// <param name="enableHttpsTrafficOnly">Allows https traffic only to
        /// storage service if sets to true.</param>
        /// <param name="networkRuleSet">Network rule set</param>
        /// <param name="kind">Optional. Indicates the type of storage account.
        /// Currently only StorageV2 value supported by server. Possible values
        /// include: 'Storage', 'StorageV2', 'BlobStorage', 'FileStorage',
        /// 'BlockBlobStorage'</param>
        public StorageAccountUpdateParameters(Sku sku = default(Sku), IDictionary<string, string> tags = default(IDictionary<string, string>), Identity identity = default(Identity), CustomDomain customDomain = default(CustomDomain), Encryption encryption = default(Encryption), AccessTier? accessTier = default(AccessTier?), bool? enableAzureFilesAadIntegration = default(bool?), bool? enableHttpsTrafficOnly = default(bool?), NetworkRuleSet networkRuleSet = default(NetworkRuleSet), string kind = default(string))
        {
            Sku = sku;
            Tags = tags;
            Identity = identity;
            CustomDomain = customDomain;
            Encryption = encryption;
            AccessTier = accessTier;
            EnableAzureFilesAadIntegration = enableAzureFilesAadIntegration;
            EnableHttpsTrafficOnly = enableHttpsTrafficOnly;
            NetworkRuleSet = networkRuleSet;
            Kind = kind;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the SKU name. Note that the SKU name cannot be updated
        /// to Standard_ZRS, Premium_LRS or Premium_ZRS, nor can accounts of
        /// those SKU names be updated to any other value.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets a list of key value pairs that describe the resource.
        /// These tags can be used in viewing and grouping this resource
        /// (across resource groups). A maximum of 15 tags can be provided for
        /// a resource. Each tag must have a key no greater in length than 128
        /// characters and a value no greater in length than 256 characters.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the identity of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public Identity Identity { get; set; }

        /// <summary>
        /// Gets or sets custom domain assigned to the storage account by the
        /// user. Name is the CNAME source. Only one custom domain is supported
        /// per storage account at this time. To clear the existing custom
        /// domain, use an empty string for the custom domain name property.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customDomain")]
        public CustomDomain CustomDomain { get; set; }

        /// <summary>
        /// Gets or sets provides the encryption settings on the account. The
        /// default setting is unencrypted.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryption")]
        public Encryption Encryption { get; set; }

        /// <summary>
        /// Gets or sets required for storage accounts where kind =
        /// BlobStorage. The access tier used for billing. Possible values
        /// include: 'Hot', 'Cool'
        /// </summary>
        [JsonProperty(PropertyName = "properties.accessTier")]
        public AccessTier? AccessTier { get; set; }

        /// <summary>
        /// Gets or sets enables Azure Files AAD Integration for SMB if sets to
        /// true.
        /// </summary>
        [JsonProperty(PropertyName = "properties.azureFilesAadIntegration")]
        public bool? EnableAzureFilesAadIntegration { get; set; }

        /// <summary>
        /// Gets or sets allows https traffic only to storage service if sets
        /// to true.
        /// </summary>
        [JsonProperty(PropertyName = "properties.supportsHttpsTrafficOnly")]
        public bool? EnableHttpsTrafficOnly { get; set; }

        /// <summary>
        /// Gets or sets network rule set
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkAcls")]
        public NetworkRuleSet NetworkRuleSet { get; set; }

        /// <summary>
        /// Gets or sets optional. Indicates the type of storage account.
        /// Currently only StorageV2 value supported by server. Possible values
        /// include: 'Storage', 'StorageV2', 'BlobStorage', 'FileStorage',
        /// 'BlockBlobStorage'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku != null)
            {
                Sku.Validate();
            }
            if (CustomDomain != null)
            {
                CustomDomain.Validate();
            }
            if (Encryption != null)
            {
                Encryption.Validate();
            }
            if (NetworkRuleSet != null)
            {
                NetworkRuleSet.Validate();
            }
        }
    }
}
