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
    /// DomainAgencyServiceV2ModelContactDetails
    /// </summary>
    [DataContract(Name = "Domain.AgencyService.v2.Model.ContactDetails")]
    public partial class DomainAgencyServiceV2ModelContactDetails : IEquatable<DomainAgencyServiceV2ModelContactDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainAgencyServiceV2ModelContactDetails" /> class.
        /// </summary>
        /// <param name="businessSale">businessSale.</param>
        /// <param name="businessRent">businessRent.</param>
        /// <param name="commercialLease">commercialLease.</param>
        /// <param name="commercialSale">commercialSale.</param>
        /// <param name="emailDomains">emailDomains.</param>
        /// <param name="general">general.</param>
        /// <param name="residentialRent">residentialRent.</param>
        /// <param name="residentialSale">residentialSale.</param>
        public DomainAgencyServiceV2ModelContactDetails(DomainAgencyServiceV2ModelEmailPhone businessSale = default(DomainAgencyServiceV2ModelEmailPhone), DomainAgencyServiceV2ModelEmailPhone businessRent = default(DomainAgencyServiceV2ModelEmailPhone), DomainAgencyServiceV2ModelEmailPhone commercialLease = default(DomainAgencyServiceV2ModelEmailPhone), DomainAgencyServiceV2ModelEmailPhone commercialSale = default(DomainAgencyServiceV2ModelEmailPhone), List<DomainAgencyServiceV2ModelEmailDomain> emailDomains = default(List<DomainAgencyServiceV2ModelEmailDomain>), DomainAgencyServiceV2ModelGeneralContactDetails general = default(DomainAgencyServiceV2ModelGeneralContactDetails), DomainAgencyServiceV2ModelEmailPhone residentialRent = default(DomainAgencyServiceV2ModelEmailPhone), DomainAgencyServiceV2ModelEmailPhone residentialSale = default(DomainAgencyServiceV2ModelEmailPhone))
        {
            this.BusinessSale = businessSale;
            this.BusinessRent = businessRent;
            this.CommercialLease = commercialLease;
            this.CommercialSale = commercialSale;
            this.EmailDomains = emailDomains;
            this.General = general;
            this.ResidentialRent = residentialRent;
            this.ResidentialSale = residentialSale;
        }

        /// <summary>
        /// Gets or Sets BusinessSale
        /// </summary>
        [DataMember(Name = "businessSale", EmitDefaultValue = false)]
        public DomainAgencyServiceV2ModelEmailPhone BusinessSale { get; set; }

        /// <summary>
        /// Gets or Sets BusinessRent
        /// </summary>
        [DataMember(Name = "businessRent", EmitDefaultValue = false)]
        public DomainAgencyServiceV2ModelEmailPhone BusinessRent { get; set; }

        /// <summary>
        /// Gets or Sets CommercialLease
        /// </summary>
        [DataMember(Name = "commercialLease", EmitDefaultValue = false)]
        public DomainAgencyServiceV2ModelEmailPhone CommercialLease { get; set; }

        /// <summary>
        /// Gets or Sets CommercialSale
        /// </summary>
        [DataMember(Name = "commercialSale", EmitDefaultValue = false)]
        public DomainAgencyServiceV2ModelEmailPhone CommercialSale { get; set; }

        /// <summary>
        /// Gets or Sets EmailDomains
        /// </summary>
        [DataMember(Name = "emailDomains", EmitDefaultValue = false)]
        public List<DomainAgencyServiceV2ModelEmailDomain> EmailDomains { get; set; }

        /// <summary>
        /// Gets or Sets General
        /// </summary>
        [DataMember(Name = "general", EmitDefaultValue = false)]
        public DomainAgencyServiceV2ModelGeneralContactDetails General { get; set; }

        /// <summary>
        /// Gets or Sets ResidentialRent
        /// </summary>
        [DataMember(Name = "residentialRent", EmitDefaultValue = false)]
        public DomainAgencyServiceV2ModelEmailPhone ResidentialRent { get; set; }

        /// <summary>
        /// Gets or Sets ResidentialSale
        /// </summary>
        [DataMember(Name = "residentialSale", EmitDefaultValue = false)]
        public DomainAgencyServiceV2ModelEmailPhone ResidentialSale { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainAgencyServiceV2ModelContactDetails {\n");
            sb.Append("  BusinessSale: ").Append(BusinessSale).Append("\n");
            sb.Append("  BusinessRent: ").Append(BusinessRent).Append("\n");
            sb.Append("  CommercialLease: ").Append(CommercialLease).Append("\n");
            sb.Append("  CommercialSale: ").Append(CommercialSale).Append("\n");
            sb.Append("  EmailDomains: ").Append(EmailDomains).Append("\n");
            sb.Append("  General: ").Append(General).Append("\n");
            sb.Append("  ResidentialRent: ").Append(ResidentialRent).Append("\n");
            sb.Append("  ResidentialSale: ").Append(ResidentialSale).Append("\n");
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
            return this.Equals(input as DomainAgencyServiceV2ModelContactDetails);
        }

        /// <summary>
        /// Returns true if DomainAgencyServiceV2ModelContactDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainAgencyServiceV2ModelContactDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainAgencyServiceV2ModelContactDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BusinessSale == input.BusinessSale ||
                    (this.BusinessSale != null &&
                    this.BusinessSale.Equals(input.BusinessSale))
                ) && 
                (
                    this.BusinessRent == input.BusinessRent ||
                    (this.BusinessRent != null &&
                    this.BusinessRent.Equals(input.BusinessRent))
                ) && 
                (
                    this.CommercialLease == input.CommercialLease ||
                    (this.CommercialLease != null &&
                    this.CommercialLease.Equals(input.CommercialLease))
                ) && 
                (
                    this.CommercialSale == input.CommercialSale ||
                    (this.CommercialSale != null &&
                    this.CommercialSale.Equals(input.CommercialSale))
                ) && 
                (
                    this.EmailDomains == input.EmailDomains ||
                    this.EmailDomains != null &&
                    input.EmailDomains != null &&
                    this.EmailDomains.SequenceEqual(input.EmailDomains)
                ) && 
                (
                    this.General == input.General ||
                    (this.General != null &&
                    this.General.Equals(input.General))
                ) && 
                (
                    this.ResidentialRent == input.ResidentialRent ||
                    (this.ResidentialRent != null &&
                    this.ResidentialRent.Equals(input.ResidentialRent))
                ) && 
                (
                    this.ResidentialSale == input.ResidentialSale ||
                    (this.ResidentialSale != null &&
                    this.ResidentialSale.Equals(input.ResidentialSale))
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
                if (this.BusinessSale != null)
                    hashCode = hashCode * 59 + this.BusinessSale.GetHashCode();
                if (this.BusinessRent != null)
                    hashCode = hashCode * 59 + this.BusinessRent.GetHashCode();
                if (this.CommercialLease != null)
                    hashCode = hashCode * 59 + this.CommercialLease.GetHashCode();
                if (this.CommercialSale != null)
                    hashCode = hashCode * 59 + this.CommercialSale.GetHashCode();
                if (this.EmailDomains != null)
                    hashCode = hashCode * 59 + this.EmailDomains.GetHashCode();
                if (this.General != null)
                    hashCode = hashCode * 59 + this.General.GetHashCode();
                if (this.ResidentialRent != null)
                    hashCode = hashCode * 59 + this.ResidentialRent.GetHashCode();
                if (this.ResidentialSale != null)
                    hashCode = hashCode * 59 + this.ResidentialSale.GetHashCode();
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
