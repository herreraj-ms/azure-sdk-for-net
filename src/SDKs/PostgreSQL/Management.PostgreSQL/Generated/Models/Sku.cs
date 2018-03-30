// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PostgreSQL.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Billing information related properties of a server.
    /// </summary>
    public partial class Sku
    {
        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        public Sku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        /// <param name="name">The name of the sku, typically, tier + family +
        /// cores, e.g. B_Gen4_1, GP_Gen5_8.</param>
        /// <param name="tier">The tier of the particular SKU, e.g. Basic.
        /// Possible values include: 'Basic', 'GeneralPurpose',
        /// 'MemoryOptimized'</param>
        /// <param name="capacity">The scale up/out capacity, representing
        /// server's compute units.</param>
        /// <param name="size">The size code, to be interpreted by resource as
        /// appropriate.</param>
        /// <param name="family">The family of hardware.</param>
        public Sku(string name = default(string), string tier = default(string), int? capacity = default(int?), string size = default(string), string family = default(string))
        {
            Name = name;
            Tier = tier;
            Capacity = capacity;
            Size = size;
            Family = family;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the sku, typically, tier + family + cores,
        /// e.g. B_Gen4_1, GP_Gen5_8.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the tier of the particular SKU, e.g. Basic. Possible
        /// values include: 'Basic', 'GeneralPurpose', 'MemoryOptimized'
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

        /// <summary>
        /// Gets or sets the scale up/out capacity, representing server's
        /// compute units.
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public int? Capacity { get; set; }

        /// <summary>
        /// Gets or sets the size code, to be interpreted by resource as
        /// appropriate.
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; }

        /// <summary>
        /// Gets or sets the family of hardware.
        /// </summary>
        [JsonProperty(PropertyName = "family")]
        public string Family { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Capacity < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Capacity", 0);
            }
        }
    }
}
