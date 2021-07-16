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
    /// LocationTypeaheadV1PropertySuggestion
    /// </summary>
    [DataContract(Name = "LocationTypeahead.V1.PropertySuggestion")]
    public partial class LocationTypeaheadV1PropertySuggestion : IEquatable<LocationTypeaheadV1PropertySuggestion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationTypeaheadV1PropertySuggestion" /> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="addressComponents">addressComponents.</param>
        /// <param name="id">id.</param>
        /// <param name="relativeScore">relativeScore.</param>
        public LocationTypeaheadV1PropertySuggestion(string address = default(string), LocationTypeaheadV1AddressComponents addressComponents = default(LocationTypeaheadV1AddressComponents), string id = default(string), int relativeScore = default(int))
        {
            this.Address = address;
            this.AddressComponents = addressComponents;
            this.Id = id;
            this.RelativeScore = relativeScore;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets AddressComponents
        /// </summary>
        [DataMember(Name = "addressComponents", EmitDefaultValue = false)]
        public LocationTypeaheadV1AddressComponents AddressComponents { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets RelativeScore
        /// </summary>
        [DataMember(Name = "relativeScore", EmitDefaultValue = false)]
        public int RelativeScore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocationTypeaheadV1PropertySuggestion {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  AddressComponents: ").Append(AddressComponents).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RelativeScore: ").Append(RelativeScore).Append("\n");
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
            return this.Equals(input as LocationTypeaheadV1PropertySuggestion);
        }

        /// <summary>
        /// Returns true if LocationTypeaheadV1PropertySuggestion instances are equal
        /// </summary>
        /// <param name="input">Instance of LocationTypeaheadV1PropertySuggestion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocationTypeaheadV1PropertySuggestion input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.AddressComponents == input.AddressComponents ||
                    (this.AddressComponents != null &&
                    this.AddressComponents.Equals(input.AddressComponents))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RelativeScore == input.RelativeScore ||
                    this.RelativeScore.Equals(input.RelativeScore)
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.AddressComponents != null)
                    hashCode = hashCode * 59 + this.AddressComponents.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.RelativeScore.GetHashCode();
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
