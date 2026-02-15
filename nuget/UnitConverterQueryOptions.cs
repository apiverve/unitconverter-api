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
        public string Value { get; set; }

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
    }
}
