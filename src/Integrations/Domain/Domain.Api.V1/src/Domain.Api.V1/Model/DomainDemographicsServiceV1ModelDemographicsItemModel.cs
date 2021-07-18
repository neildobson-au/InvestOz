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
using OpenAPIDateConverter = Domain.Api.V1.Client.OpenAPIDateConverter;

namespace Domain.Api.V1.Model
{
    /// <summary>
    /// DomainDemographicsServiceV1ModelDemographicsItemModel
    /// </summary>
    [DataContract(Name = "Domain.DemographicsService.v1.Model.DemographicsItemModel")]
    public partial class DomainDemographicsServiceV1ModelDemographicsItemModel : IEquatable<DomainDemographicsServiceV1ModelDemographicsItemModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainDemographicsServiceV1ModelDemographicsItemModel" /> class.
        /// </summary>
        /// <param name="label">label.</param>
        /// <param name="value">value.</param>
        /// <param name="composition">composition.</param>
        public DomainDemographicsServiceV1ModelDemographicsItemModel(string label = default(string), int value = default(int), string composition = default(string))
        {
            this.Label = label;
            this.Value = value;
            this.Composition = composition;
        }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public int Value { get; set; }

        /// <summary>
        /// Gets or Sets Composition
        /// </summary>
        [DataMember(Name = "composition", EmitDefaultValue = false)]
        public string Composition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainDemographicsServiceV1ModelDemographicsItemModel {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Composition: ").Append(Composition).Append("\n");
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
            return this.Equals(input as DomainDemographicsServiceV1ModelDemographicsItemModel);
        }

        /// <summary>
        /// Returns true if DomainDemographicsServiceV1ModelDemographicsItemModel instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainDemographicsServiceV1ModelDemographicsItemModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainDemographicsServiceV1ModelDemographicsItemModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.Composition == input.Composition ||
                    (this.Composition != null &&
                    this.Composition.Equals(input.Composition))
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
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Composition != null)
                    hashCode = hashCode * 59 + this.Composition.GetHashCode();
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