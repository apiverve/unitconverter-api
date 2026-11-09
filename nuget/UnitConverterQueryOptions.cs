using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace APIVerve.API.UnitConverter
{
    /// <summary>
    /// Query options for the Unit Converter API
    /// </summary>
    public class UnitConverterQueryOptions
    {
        /// <summary>
        /// The value to convert
        /// </summary>
        [JsonProperty("value")]
        public double Value { get; set; }

        /// <summary>
        /// The unit to convert from
        /// </summary>
        [JsonProperty("from")]
        public string From { get; set; }

        /// <summary>
        /// The unit to convert to
        /// </summary>
        [JsonProperty("to")]
        public string To { get; set; }

        /// <summary>
        /// Decimal places to round results to, between 0 and 10 (default 2)
        /// </summary>
        [JsonProperty("precision")]
        public int? Precision { get; set; }

        /// <summary>
        /// Also return the value converted into every unit of the same measure
        /// </summary>
        [JsonProperty("conversions")]
        public bool? Conversions { get; set; }
    }
}
