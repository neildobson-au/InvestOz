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
    /// Property Inspection(s) details
    /// </summary>
    [DataContract(Name = "Listings.V2.PropertyInspections")]
    public partial class ListingsV2PropertyInspections : IEquatable<ListingsV2PropertyInspections>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingsV2PropertyInspections" /> class.
        /// </summary>
        /// <param name="inspections">Inspection details for the property. e.g. opening and closing times.</param>
        /// <param name="pastInspections">Inspection details for the property. e.g. opening and closing times.</param>
        /// <param name="isByAppointmentOnly">True or False indicating whether the inspection is by appointment only.</param>
        public ListingsV2PropertyInspections(List<ListingsV2Inspection> inspections = default(List<ListingsV2Inspection>), List<ListingsV2Inspection> pastInspections = default(List<ListingsV2Inspection>), bool isByAppointmentOnly = default(bool))
        {
            this.Inspections = inspections;
            this.PastInspections = pastInspections;
            this.IsByAppointmentOnly = isByAppointmentOnly;
        }

        /// <summary>
        /// Inspection details for the property. e.g. opening and closing times
        /// </summary>
        /// <value>Inspection details for the property. e.g. opening and closing times</value>
        [DataMember(Name = "inspections", EmitDefaultValue = true)]
        public List<ListingsV2Inspection> Inspections { get; set; }

        /// <summary>
        /// Inspection details for the property. e.g. opening and closing times
        /// </summary>
        /// <value>Inspection details for the property. e.g. opening and closing times</value>
        [DataMember(Name = "pastInspections", EmitDefaultValue = true)]
        public List<ListingsV2Inspection> PastInspections { get; set; }

        /// <summary>
        /// True or False indicating whether the inspection is by appointment only
        /// </summary>
        /// <value>True or False indicating whether the inspection is by appointment only</value>
        [DataMember(Name = "isByAppointmentOnly", EmitDefaultValue = false)]
        public bool IsByAppointmentOnly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListingsV2PropertyInspections {\n");
            sb.Append("  Inspections: ").Append(Inspections).Append("\n");
            sb.Append("  PastInspections: ").Append(PastInspections).Append("\n");
            sb.Append("  IsByAppointmentOnly: ").Append(IsByAppointmentOnly).Append("\n");
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
            return this.Equals(input as ListingsV2PropertyInspections);
        }

        /// <summary>
        /// Returns true if ListingsV2PropertyInspections instances are equal
        /// </summary>
        /// <param name="input">Instance of ListingsV2PropertyInspections to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListingsV2PropertyInspections input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Inspections == input.Inspections ||
                    this.Inspections != null &&
                    input.Inspections != null &&
                    this.Inspections.SequenceEqual(input.Inspections)
                ) && 
                (
                    this.PastInspections == input.PastInspections ||
                    this.PastInspections != null &&
                    input.PastInspections != null &&
                    this.PastInspections.SequenceEqual(input.PastInspections)
                ) && 
                (
                    this.IsByAppointmentOnly == input.IsByAppointmentOnly ||
                    this.IsByAppointmentOnly.Equals(input.IsByAppointmentOnly)
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
                if (this.Inspections != null)
                    hashCode = hashCode * 59 + this.Inspections.GetHashCode();
                if (this.PastInspections != null)
                    hashCode = hashCode * 59 + this.PastInspections.GetHashCode();
                hashCode = hashCode * 59 + this.IsByAppointmentOnly.GetHashCode();
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
