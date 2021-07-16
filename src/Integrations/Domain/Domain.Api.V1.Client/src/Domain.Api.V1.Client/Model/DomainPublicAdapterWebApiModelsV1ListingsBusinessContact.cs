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
    /// Contact
    /// </summary>
    [DataContract(Name = "Domain.Public.Adapter.Web.Api.Models.v1.Listings.Business.Contact")]
    public partial class DomainPublicAdapterWebApiModelsV1ListingsBusinessContact : IEquatable<DomainPublicAdapterWebApiModelsV1ListingsBusinessContact>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainPublicAdapterWebApiModelsV1ListingsBusinessContact" /> class.
        /// </summary>
        /// <param name="id">Agent identifier.</param>
        /// <param name="firstName">First name. Not available in CRE.</param>
        /// <param name="lastName">Last name. Not available in CRE.</param>
        /// <param name="imageUrl">Image URL.</param>
        /// <param name="displayFullName">Full name.</param>
        /// <param name="phoneNumbers">Phone numbers.</param>
        /// <param name="emailAddress">E-mail address.</param>
        /// <param name="address">Full address.</param>
        public DomainPublicAdapterWebApiModelsV1ListingsBusinessContact(int id = default(int), string firstName = default(string), string lastName = default(string), string imageUrl = default(string), string displayFullName = default(string), List<DomainPublicAdapterWebApiModelsV1ListingsBusinessPhoneNumber> phoneNumbers = default(List<DomainPublicAdapterWebApiModelsV1ListingsBusinessPhoneNumber>), string emailAddress = default(string), string address = default(string))
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ImageUrl = imageUrl;
            this.DisplayFullName = displayFullName;
            this.PhoneNumbers = phoneNumbers;
            this.EmailAddress = emailAddress;
            this.Address = address;
        }

        /// <summary>
        /// Agent identifier
        /// </summary>
        /// <value>Agent identifier</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// First name. Not available in CRE
        /// </summary>
        /// <value>First name. Not available in CRE</value>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name. Not available in CRE
        /// </summary>
        /// <value>Last name. Not available in CRE</value>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Image URL
        /// </summary>
        /// <value>Image URL</value>
        [DataMember(Name = "imageUrl", EmitDefaultValue = false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Full name
        /// </summary>
        /// <value>Full name</value>
        [DataMember(Name = "displayFullName", EmitDefaultValue = false)]
        public string DisplayFullName { get; set; }

        /// <summary>
        /// Phone numbers
        /// </summary>
        /// <value>Phone numbers</value>
        [DataMember(Name = "phoneNumbers", EmitDefaultValue = false)]
        public List<DomainPublicAdapterWebApiModelsV1ListingsBusinessPhoneNumber> PhoneNumbers { get; set; }

        /// <summary>
        /// E-mail address
        /// </summary>
        /// <value>E-mail address</value>
        [DataMember(Name = "emailAddress", EmitDefaultValue = false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Full address
        /// </summary>
        /// <value>Full address</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainPublicAdapterWebApiModelsV1ListingsBusinessContact {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  DisplayFullName: ").Append(DisplayFullName).Append("\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
            return this.Equals(input as DomainPublicAdapterWebApiModelsV1ListingsBusinessContact);
        }

        /// <summary>
        /// Returns true if DomainPublicAdapterWebApiModelsV1ListingsBusinessContact instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainPublicAdapterWebApiModelsV1ListingsBusinessContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainPublicAdapterWebApiModelsV1ListingsBusinessContact input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.DisplayFullName == input.DisplayFullName ||
                    (this.DisplayFullName != null &&
                    this.DisplayFullName.Equals(input.DisplayFullName))
                ) && 
                (
                    this.PhoneNumbers == input.PhoneNumbers ||
                    this.PhoneNumbers != null &&
                    input.PhoneNumbers != null &&
                    this.PhoneNumbers.SequenceEqual(input.PhoneNumbers)
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.DisplayFullName != null)
                    hashCode = hashCode * 59 + this.DisplayFullName.GetHashCode();
                if (this.PhoneNumbers != null)
                    hashCode = hashCode * 59 + this.PhoneNumbers.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
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
