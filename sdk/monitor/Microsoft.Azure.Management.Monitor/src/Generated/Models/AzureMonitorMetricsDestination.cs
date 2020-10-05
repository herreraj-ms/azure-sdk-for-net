// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Azure Monitor Metrics destination.
    /// </summary>
    public partial class AzureMonitorMetricsDestination
    {
        /// <summary>
        /// Initializes a new instance of the AzureMonitorMetricsDestination
        /// class.
        /// </summary>
        public AzureMonitorMetricsDestination()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureMonitorMetricsDestination
        /// class.
        /// </summary>
        /// <param name="name">A friendly name for the destination.
        /// This name should be unique across all destinations (regardless of
        /// type) within the data collection rule.</param>
        public AzureMonitorMetricsDestination(string name)
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a friendly name for the destination.
        /// This name should be unique across all destinations (regardless of
        /// type) within the data collection rule.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Name != null)
            {
                if (Name.Length > 32)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 32);
                }
                if (Name.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Name", 0);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(Name, "^[-\\w\\._\\(\\)]+$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Name", "^[-\\w\\._\\(\\)]+$");
                }
            }
        }
    }
}
