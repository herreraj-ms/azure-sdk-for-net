// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Definition of which performance counters will be collected and how they
    /// will be collected by this data collection rule.
    /// Collected from both Windows and Linux machines where the counter is
    /// present.
    /// </summary>
    public partial class PerfCounterDataSource
    {
        /// <summary>
        /// Initializes a new instance of the PerfCounterDataSource class.
        /// </summary>
        public PerfCounterDataSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PerfCounterDataSource class.
        /// </summary>
        /// <param name="streams">List of streams that this data source will be
        /// sent to.
        /// A stream indicates what schema will be used for this data and
        /// usually what table in Log Analytics the data will be sent
        /// to.</param>
        /// <param name="scheduledTransferPeriod">The interval between data
        /// uploads (scheduled transfers), rounded up to the nearest minute.
        /// Possible values include: 'PT1M', 'PT5M', 'PT15M', 'PT30M',
        /// 'PT60M'</param>
        /// <param name="samplingFrequencyInSeconds">The number of seconds
        /// between consecutive counter measurements (samples).</param>
        /// <param name="counterSpecifiers">A list of specifier names of the
        /// performance counters you want to collect.
        /// Use a wildcard (*) to collect a counter for all instances.
        /// To get a list of performance counters on Windows, run the command
        /// 'typeperf'.</param>
        /// <param name="name">A friendly name for the data source.
        /// This name should be unique across all data sources (regardless of
        /// type) within the data collection rule.</param>
        public PerfCounterDataSource(IList<string> streams, string scheduledTransferPeriod, int samplingFrequencyInSeconds, IList<string> counterSpecifiers, string name)
        {
            Streams = streams;
            ScheduledTransferPeriod = scheduledTransferPeriod;
            SamplingFrequencyInSeconds = samplingFrequencyInSeconds;
            CounterSpecifiers = counterSpecifiers;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of streams that this data source will be sent to.
        /// A stream indicates what schema will be used for this data and
        /// usually what table in Log Analytics the data will be sent to.
        /// </summary>
        [JsonProperty(PropertyName = "streams")]
        public IList<string> Streams { get; set; }

        /// <summary>
        /// Gets or sets the interval between data uploads (scheduled
        /// transfers), rounded up to the nearest minute. Possible values
        /// include: 'PT1M', 'PT5M', 'PT15M', 'PT30M', 'PT60M'
        /// </summary>
        [JsonProperty(PropertyName = "scheduledTransferPeriod")]
        public string ScheduledTransferPeriod { get; set; }

        /// <summary>
        /// Gets or sets the number of seconds between consecutive counter
        /// measurements (samples).
        /// </summary>
        [JsonProperty(PropertyName = "samplingFrequencyInSeconds")]
        public int SamplingFrequencyInSeconds { get; set; }

        /// <summary>
        /// Gets or sets a list of specifier names of the performance counters
        /// you want to collect.
        /// Use a wildcard (*) to collect a counter for all instances.
        /// To get a list of performance counters on Windows, run the command
        /// 'typeperf'.
        /// </summary>
        [JsonProperty(PropertyName = "counterSpecifiers")]
        public IList<string> CounterSpecifiers { get; set; }

        /// <summary>
        /// Gets or sets a friendly name for the data source.
        /// This name should be unique across all data sources (regardless of
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
            if (Streams == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Streams");
            }
            if (ScheduledTransferPeriod == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ScheduledTransferPeriod");
            }
            if (CounterSpecifiers == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CounterSpecifiers");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (SamplingFrequencyInSeconds > 30)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "SamplingFrequencyInSeconds", 30);
            }
            if (SamplingFrequencyInSeconds < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "SamplingFrequencyInSeconds", 1);
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
