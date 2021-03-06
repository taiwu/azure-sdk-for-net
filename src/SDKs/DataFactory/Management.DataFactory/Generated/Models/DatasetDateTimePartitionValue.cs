// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The date/time value of a partition.
    /// </summary>
    [Newtonsoft.Json.JsonObject("DateTime")]
    public partial class DatasetDateTimePartitionValue : DatasetPartitionValue
    {
        /// <summary>
        /// Initializes a new instance of the DatasetDateTimePartitionValue
        /// class.
        /// </summary>
        public DatasetDateTimePartitionValue()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatasetDateTimePartitionValue
        /// class.
        /// </summary>
        /// <param name="date">Name of variable containing date. Type: string
        /// (or Expression with resultType string).</param>
        /// <param name="format">Format string for the Date value. Type: string
        /// (or Expression with resultType string).</param>
        public DatasetDateTimePartitionValue(object date = default(object), object format = default(object))
        {
            Date = date;
            Format = format;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of variable containing date. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public object Date { get; set; }

        /// <summary>
        /// Gets or sets format string for the Date value. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "format")]
        public object Format { get; set; }

    }
}
