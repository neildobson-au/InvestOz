/*
 * Domain Public API
 *
 * See https://developer.domain.com.au for more information
 *
 * The version of the OpenAPI document: v2
 * Contact: api@domain.com.au
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Domain.Api.Client.Client.OpenAPIDateConverter;

namespace Domain.Api.Client.Model
{
    /// <summary>
    /// APMAPIModelsSuburbV2SuburbPerformanceModel
    /// </summary>
    [DataContract(Name = "SuburbPerformanceStatistics.V3.SuburbPerformance")]
    public partial class SuburbPerformanceStatisticsV3SuburbPerformance : IEquatable<SuburbPerformanceStatisticsV3SuburbPerformance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SuburbPerformanceStatisticsV3SuburbPerformance" /> class.
        /// </summary>
        /// <param name="header">header.</param>
        /// <param name="series">series.</param>
        public SuburbPerformanceStatisticsV3SuburbPerformance(SuburbPerformanceStatisticsV3SuburbSeriesHeader header = default(SuburbPerformanceStatisticsV3SuburbSeriesHeader), SuburbPerformanceStatisticsV3SuburbSeries series = default(SuburbPerformanceStatisticsV3SuburbSeries))
        {
            this.Header = header;
            this.Series = series;
        }

        /// <summary>
        /// Gets or Sets Header
        /// </summary>
        [DataMember(Name = "header", EmitDefaultValue = false)]
        public SuburbPerformanceStatisticsV3SuburbSeriesHeader Header { get; set; }

        /// <summary>
        /// Gets or Sets Series
        /// </summary>
        [DataMember(Name = "series", EmitDefaultValue = false)]
        public SuburbPerformanceStatisticsV3SuburbSeries Series { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SuburbPerformanceStatisticsV3SuburbPerformance {\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  Series: ").Append(Series).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SuburbPerformanceStatisticsV3SuburbPerformance);
        }

        /// <summary>
        /// Returns true if SuburbPerformanceStatisticsV3SuburbPerformance instances are equal
        /// </summary>
        /// <param name="input">Instance of SuburbPerformanceStatisticsV3SuburbPerformance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SuburbPerformanceStatisticsV3SuburbPerformance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Header == input.Header ||
                    (this.Header != null &&
                    this.Header.Equals(input.Header))
                ) && 
                (
                    this.Series == input.Series ||
                    (this.Series != null &&
                    this.Series.Equals(input.Series))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Header != null)
                    hashCode = hashCode * 59 + this.Header.GetHashCode();
                if (this.Series != null)
                    hashCode = hashCode * 59 + this.Series.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
