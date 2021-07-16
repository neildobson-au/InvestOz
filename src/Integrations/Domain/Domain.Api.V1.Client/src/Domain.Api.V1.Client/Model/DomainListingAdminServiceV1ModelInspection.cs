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
    /// Inspection times
    /// </summary>
    [DataContract(Name = "Domain.ListingAdminService.v1.Model.Inspection")]
    public partial class DomainListingAdminServiceV1ModelInspection : IEquatable<DomainListingAdminServiceV1ModelInspection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainListingAdminServiceV1ModelInspection" /> class.
        /// </summary>
        /// <param name="from">Format: yyyy-mm-dd HH:mm:ss eg: 2015-10-20 13:30:00.</param>
        /// <param name="to">Format: yyyy-mm-dd HH:mm:ss, eg: 2015-10-20 14:30:00.</param>
        /// <param name="repeat">Specifies if the inspection is recurring weekly.</param>
        public DomainListingAdminServiceV1ModelInspection(DateTime from = default(DateTime), DateTime to = default(DateTime), bool repeat = default(bool))
        {
            this.From = from;
            this.To = to;
            this.Repeat = repeat;
        }

        /// <summary>
        /// Format: yyyy-mm-dd HH:mm:ss eg: 2015-10-20 13:30:00
        /// </summary>
        /// <value>Format: yyyy-mm-dd HH:mm:ss eg: 2015-10-20 13:30:00</value>
        [DataMember(Name = "from", EmitDefaultValue = false)]
        public DateTime From { get; set; }

        /// <summary>
        /// Format: yyyy-mm-dd HH:mm:ss, eg: 2015-10-20 14:30:00
        /// </summary>
        /// <value>Format: yyyy-mm-dd HH:mm:ss, eg: 2015-10-20 14:30:00</value>
        [DataMember(Name = "to", EmitDefaultValue = false)]
        public DateTime To { get; set; }

        /// <summary>
        /// Specifies if the inspection is recurring weekly
        /// </summary>
        /// <value>Specifies if the inspection is recurring weekly</value>
        [DataMember(Name = "repeat", EmitDefaultValue = false)]
        public bool Repeat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainListingAdminServiceV1ModelInspection {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Repeat: ").Append(Repeat).Append("\n");
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
            return this.Equals(input as DomainListingAdminServiceV1ModelInspection);
        }

        /// <summary>
        /// Returns true if DomainListingAdminServiceV1ModelInspection instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainListingAdminServiceV1ModelInspection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainListingAdminServiceV1ModelInspection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Repeat == input.Repeat ||
                    this.Repeat.Equals(input.Repeat)
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
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                hashCode = hashCode * 59 + this.Repeat.GetHashCode();
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
