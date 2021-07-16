/*
 * Domain Public API
 *
 * See https://developer.domain.com.au for more information
 *
 * The version of the OpenAPI document: v1
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
using OpenAPIDateConverter = Domain.Api.V1.Client.Client.OpenAPIDateConverter;

namespace Domain.Api.V1.Client.Model
{
    /// <summary>
    /// A single geographic coordinate
    /// </summary>
    [DataContract(Name = "Domain.Public.Adapter.Web.Api.Models.v1.Point")]
    public partial class DomainPublicAdapterWebApiModelsV1Point : IEquatable<DomainPublicAdapterWebApiModelsV1Point>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainPublicAdapterWebApiModelsV1Point" /> class.
        /// </summary>
        /// <param name="lat">Latitude.</param>
        /// <param name="lon">Longitude.</param>
        public DomainPublicAdapterWebApiModelsV1Point(double lat = default(double), double lon = default(double))
        {
            this.Lat = lat;
            this.Lon = lon;
        }

        /// <summary>
        /// Latitude
        /// </summary>
        /// <value>Latitude</value>
        [DataMember(Name = "lat", EmitDefaultValue = false)]
        public double Lat { get; set; }

        /// <summary>
        /// Longitude
        /// </summary>
        /// <value>Longitude</value>
        [DataMember(Name = "lon", EmitDefaultValue = false)]
        public double Lon { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainPublicAdapterWebApiModelsV1Point {\n");
            sb.Append("  Lat: ").Append(Lat).Append("\n");
            sb.Append("  Lon: ").Append(Lon).Append("\n");
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
            return this.Equals(input as DomainPublicAdapterWebApiModelsV1Point);
        }

        /// <summary>
        /// Returns true if DomainPublicAdapterWebApiModelsV1Point instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainPublicAdapterWebApiModelsV1Point to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainPublicAdapterWebApiModelsV1Point input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Lat == input.Lat ||
                    this.Lat.Equals(input.Lat)
                ) && 
                (
                    this.Lon == input.Lon ||
                    this.Lon.Equals(input.Lon)
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
                hashCode = hashCode * 59 + this.Lat.GetHashCode();
                hashCode = hashCode * 59 + this.Lon.GetHashCode();
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
