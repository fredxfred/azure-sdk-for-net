// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Input for the task that validates connection to Azure Database for
    /// PostgreSQL and target server requirements
    /// </summary>
    public partial class ConnectToTargetAzureDbForPostgreSqlSyncTaskInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ConnectToTargetAzureDbForPostgreSqlSyncTaskInput class.
        /// </summary>
        public ConnectToTargetAzureDbForPostgreSqlSyncTaskInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ConnectToTargetAzureDbForPostgreSqlSyncTaskInput class.
        /// </summary>
        /// <param name="sourceConnectionInfo">Connection information for
        /// source PostgreSQL server</param>
        /// <param name="targetConnectionInfo">Connection information for
        /// target Azure Database for PostgreSQL server</param>
        public ConnectToTargetAzureDbForPostgreSqlSyncTaskInput(PostgreSqlConnectionInfo sourceConnectionInfo, PostgreSqlConnectionInfo targetConnectionInfo)
        {
            SourceConnectionInfo = sourceConnectionInfo;
            TargetConnectionInfo = targetConnectionInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets connection information for source PostgreSQL server
        /// </summary>
        [JsonProperty(PropertyName = "sourceConnectionInfo")]
        public PostgreSqlConnectionInfo SourceConnectionInfo { get; set; }

        /// <summary>
        /// Gets or sets connection information for target Azure Database for
        /// PostgreSQL server
        /// </summary>
        [JsonProperty(PropertyName = "targetConnectionInfo")]
        public PostgreSqlConnectionInfo TargetConnectionInfo { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SourceConnectionInfo == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourceConnectionInfo");
            }
            if (TargetConnectionInfo == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetConnectionInfo");
            }
            if (SourceConnectionInfo != null)
            {
                SourceConnectionInfo.Validate();
            }
            if (TargetConnectionInfo != null)
            {
                TargetConnectionInfo.Validate();
            }
        }
    }
}
