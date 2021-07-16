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
    /// Tender Information
    /// </summary>
    [DataContract(Name = "ListingAdmin.v2.Tender")]
    public partial class ListingAdminV2Tender : IEquatable<ListingAdminV2Tender>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingAdminV2Tender" /> class.
        /// </summary>
        /// <param name="recipientName">The recipient name of the tender, up to 50 characters.</param>
        /// <param name="address">Street address, up to 100 characters..</param>
        /// <param name="endDate">Closing Date.</param>
        public ListingAdminV2Tender(string recipientName = default(string), string address = default(string), DateTime endDate = default(DateTime))
        {
            this.RecipientName = recipientName;
            this.Address = address;
            this.EndDate = endDate;
        }

        /// <summary>
        /// The recipient name of the tender, up to 50 characters
        /// </summary>
        /// <value>The recipient name of the tender, up to 50 characters</value>
        [DataMember(Name = "recipientName", EmitDefaultValue = false)]
        public string RecipientName { get; set; }

        /// <summary>
        /// Street address, up to 100 characters.
        /// </summary>
        /// <value>Street address, up to 100 characters.</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Closing Date
        /// </summary>
        /// <value>Closing Date</value>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListingAdminV2Tender {\n");
            sb.Append("  RecipientName: ").Append(RecipientName).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
            return this.Equals(input as ListingAdminV2Tender);
        }

        /// <summary>
        /// Returns true if ListingAdminV2Tender instances are equal
        /// </summary>
        /// <param name="input">Instance of ListingAdminV2Tender to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListingAdminV2Tender input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecipientName == input.RecipientName ||
                    (this.RecipientName != null &&
                    this.RecipientName.Equals(input.RecipientName))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
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
                if (this.RecipientName != null)
                    hashCode = hashCode * 59 + this.RecipientName.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
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
            // RecipientName (string) maxLength
            if(this.RecipientName != null && this.RecipientName.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RecipientName, length must be less than 50.", new [] { "RecipientName" });
            }

            // RecipientName (string) minLength
            if(this.RecipientName != null && this.RecipientName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RecipientName, length must be greater than 0.", new [] { "RecipientName" });
            }

            // Address (string) maxLength
            if(this.Address != null && this.Address.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Address, length must be less than 100.", new [] { "Address" });
            }

            // Address (string) minLength
            if(this.Address != null && this.Address.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Address, length must be greater than 0.", new [] { "Address" });
            }

            yield break;
        }
    }

}
