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
    /// The rental detail&#39;s of the listing in case of it being for rent or leased
    /// </summary>
    [DataContract(Name = "Listings.V2.RentalDetails")]
    public partial class ListingsV2RentalDetails : IEquatable<ListingsV2RentalDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingsV2RentalDetails" /> class.
        /// </summary>
        /// <param name="rentalMethod">rentalMethod.</param>
        /// <param name="source">source.</param>
        /// <param name="leasedDate">The Date the listing was leased. DateTime is in AEST (Australian Eastern Standard Time) timezone..</param>
        /// <param name="leasedPrice">The last leased price entered by the Advertiser   This price will only be visible if allowed by the Advertiser  and the listing as been leased.</param>
        /// <param name="canDisplayPrice">Indicates whether this instance can display price.</param>
        /// <param name="leasedMonths">The number of months the property was last leased for  This will only be visible if the property has been leased.</param>
        /// <param name="termOfLeaseFrom">Lease term range from.</param>
        /// <param name="termOfLeaseTo">Lease term range to.</param>
        /// <param name="leaseOutgoings">Outgoing cost of current lease.</param>
        public ListingsV2RentalDetails(ListingsV2RentalMethod rentalMethod = default(ListingsV2RentalMethod), ListingsV2PublishSource source = default(ListingsV2PublishSource), DateTime? leasedDate = default(DateTime?), int? leasedPrice = default(int?), bool canDisplayPrice = default(bool), int? leasedMonths = default(int?), int? termOfLeaseFrom = default(int?), int? termOfLeaseTo = default(int?), int? leaseOutgoings = default(int?))
        {
            this.RentalMethod = rentalMethod;
            this.Source = source;
            this.LeasedDate = leasedDate;
            this.LeasedPrice = leasedPrice;
            this.CanDisplayPrice = canDisplayPrice;
            this.LeasedMonths = leasedMonths;
            this.TermOfLeaseFrom = termOfLeaseFrom;
            this.TermOfLeaseTo = termOfLeaseTo;
            this.LeaseOutgoings = leaseOutgoings;
        }

        /// <summary>
        /// Gets or Sets RentalMethod
        /// </summary>
        [DataMember(Name = "rentalMethod", EmitDefaultValue = false)]
        public ListingsV2RentalMethod RentalMethod { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public ListingsV2PublishSource Source { get; set; }

        /// <summary>
        /// The Date the listing was leased. DateTime is in AEST (Australian Eastern Standard Time) timezone.
        /// </summary>
        /// <value>The Date the listing was leased. DateTime is in AEST (Australian Eastern Standard Time) timezone.</value>
        [DataMember(Name = "leasedDate", EmitDefaultValue = true)]
        public DateTime? LeasedDate { get; set; }

        /// <summary>
        /// The last leased price entered by the Advertiser   This price will only be visible if allowed by the Advertiser  and the listing as been leased
        /// </summary>
        /// <value>The last leased price entered by the Advertiser   This price will only be visible if allowed by the Advertiser  and the listing as been leased</value>
        [DataMember(Name = "leasedPrice", EmitDefaultValue = true)]
        public int? LeasedPrice { get; set; }

        /// <summary>
        /// Indicates whether this instance can display price
        /// </summary>
        /// <value>Indicates whether this instance can display price</value>
        [DataMember(Name = "canDisplayPrice", EmitDefaultValue = false)]
        public bool CanDisplayPrice { get; set; }

        /// <summary>
        /// The number of months the property was last leased for  This will only be visible if the property has been leased
        /// </summary>
        /// <value>The number of months the property was last leased for  This will only be visible if the property has been leased</value>
        [DataMember(Name = "leasedMonths", EmitDefaultValue = true)]
        public int? LeasedMonths { get; set; }

        /// <summary>
        /// Lease term range from
        /// </summary>
        /// <value>Lease term range from</value>
        [DataMember(Name = "termOfLeaseFrom", EmitDefaultValue = true)]
        public int? TermOfLeaseFrom { get; set; }

        /// <summary>
        /// Lease term range to
        /// </summary>
        /// <value>Lease term range to</value>
        [DataMember(Name = "termOfLeaseTo", EmitDefaultValue = true)]
        public int? TermOfLeaseTo { get; set; }

        /// <summary>
        /// Outgoing cost of current lease
        /// </summary>
        /// <value>Outgoing cost of current lease</value>
        [DataMember(Name = "leaseOutgoings", EmitDefaultValue = true)]
        public int? LeaseOutgoings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListingsV2RentalDetails {\n");
            sb.Append("  RentalMethod: ").Append(RentalMethod).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  LeasedDate: ").Append(LeasedDate).Append("\n");
            sb.Append("  LeasedPrice: ").Append(LeasedPrice).Append("\n");
            sb.Append("  CanDisplayPrice: ").Append(CanDisplayPrice).Append("\n");
            sb.Append("  LeasedMonths: ").Append(LeasedMonths).Append("\n");
            sb.Append("  TermOfLeaseFrom: ").Append(TermOfLeaseFrom).Append("\n");
            sb.Append("  TermOfLeaseTo: ").Append(TermOfLeaseTo).Append("\n");
            sb.Append("  LeaseOutgoings: ").Append(LeaseOutgoings).Append("\n");
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
            return this.Equals(input as ListingsV2RentalDetails);
        }

        /// <summary>
        /// Returns true if ListingsV2RentalDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ListingsV2RentalDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListingsV2RentalDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RentalMethod == input.RentalMethod ||
                    (this.RentalMethod != null &&
                    this.RentalMethod.Equals(input.RentalMethod))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.LeasedDate == input.LeasedDate ||
                    (this.LeasedDate != null &&
                    this.LeasedDate.Equals(input.LeasedDate))
                ) && 
                (
                    this.LeasedPrice == input.LeasedPrice ||
                    (this.LeasedPrice != null &&
                    this.LeasedPrice.Equals(input.LeasedPrice))
                ) && 
                (
                    this.CanDisplayPrice == input.CanDisplayPrice ||
                    this.CanDisplayPrice.Equals(input.CanDisplayPrice)
                ) && 
                (
                    this.LeasedMonths == input.LeasedMonths ||
                    (this.LeasedMonths != null &&
                    this.LeasedMonths.Equals(input.LeasedMonths))
                ) && 
                (
                    this.TermOfLeaseFrom == input.TermOfLeaseFrom ||
                    (this.TermOfLeaseFrom != null &&
                    this.TermOfLeaseFrom.Equals(input.TermOfLeaseFrom))
                ) && 
                (
                    this.TermOfLeaseTo == input.TermOfLeaseTo ||
                    (this.TermOfLeaseTo != null &&
                    this.TermOfLeaseTo.Equals(input.TermOfLeaseTo))
                ) && 
                (
                    this.LeaseOutgoings == input.LeaseOutgoings ||
                    (this.LeaseOutgoings != null &&
                    this.LeaseOutgoings.Equals(input.LeaseOutgoings))
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
                if (this.RentalMethod != null)
                    hashCode = hashCode * 59 + this.RentalMethod.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.LeasedDate != null)
                    hashCode = hashCode * 59 + this.LeasedDate.GetHashCode();
                if (this.LeasedPrice != null)
                    hashCode = hashCode * 59 + this.LeasedPrice.GetHashCode();
                hashCode = hashCode * 59 + this.CanDisplayPrice.GetHashCode();
                if (this.LeasedMonths != null)
                    hashCode = hashCode * 59 + this.LeasedMonths.GetHashCode();
                if (this.TermOfLeaseFrom != null)
                    hashCode = hashCode * 59 + this.TermOfLeaseFrom.GetHashCode();
                if (this.TermOfLeaseTo != null)
                    hashCode = hashCode * 59 + this.TermOfLeaseTo.GetHashCode();
                if (this.LeaseOutgoings != null)
                    hashCode = hashCode * 59 + this.LeaseOutgoings.GetHashCode();
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
