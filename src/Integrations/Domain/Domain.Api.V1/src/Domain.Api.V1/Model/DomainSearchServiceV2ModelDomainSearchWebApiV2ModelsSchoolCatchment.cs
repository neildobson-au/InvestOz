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
    /// DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsSchoolCatchment
    /// </summary>
    [DataContract(Name = "Domain.SearchService.v2.Model.DomainSearchWebApiV2ModelsSchoolCatchment")]
    public partial class DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsSchoolCatchment : IEquatable<DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsSchoolCatchment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsSchoolCatchment" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="state">state.</param>
        /// <param name="postcode">postcode.</param>
        public DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsSchoolCatchment(string name = default(string), string state = default(string), string postcode = default(string))
        {
            this.Name = name;
            this.State = state;
            this.Postcode = postcode;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Postcode
        /// </summary>
        [DataMember(Name = "postcode", EmitDefaultValue = false)]
        public string Postcode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsSchoolCatchment {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
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
            return this.Equals(input as DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsSchoolCatchment);
        }

        /// <summary>
        /// Returns true if DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsSchoolCatchment instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsSchoolCatchment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsSchoolCatchment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Postcode == input.Postcode ||
                    (this.Postcode != null &&
                    this.Postcode.Equals(input.Postcode))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Postcode != null)
                    hashCode = hashCode * 59 + this.Postcode.GetHashCode();
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