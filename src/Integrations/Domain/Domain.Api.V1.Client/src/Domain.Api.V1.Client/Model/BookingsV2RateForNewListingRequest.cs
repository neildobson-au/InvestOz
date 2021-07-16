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
    /// Provide a summary of the intended listing for which to calculate a rate.
    /// </summary>
    [DataContract(Name = "Bookings.V2.RateForNewListingRequest")]
    public partial class BookingsV2RateForNewListingRequest : IEquatable<BookingsV2RateForNewListingRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookingsV2RateForNewListingRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BookingsV2RateForNewListingRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BookingsV2RateForNewListingRequest" /> class.
        /// </summary>
        /// <param name="agencyId">Id of the agency for whom rates are to be calculated. (required).</param>
        /// <param name="agentFirstName">The first name of the primary agent associated with the listing. (required).</param>
        /// <param name="agentLastName">The last name of the primary agent associated with the listing (required).</param>
        /// <param name="agentEmail">The email of the primary agent associated with the listing. (required).</param>
        /// <param name="suburb">Suburb for which rates are to be calculated. (required).</param>
        /// <param name="postcode">Postcode for which rates are to be calculated. (required).</param>
        /// <param name="state">State for which rates are to be calculated (required).</param>
        /// <param name="propertyType">propertyType (required).</param>
        /// <param name="isNewDevelopment">Whether to return the normal or new development rates (required).</param>
        /// <param name="listingType">listingType (required).</param>
        /// <param name="price">The value of the listing (required).</param>
        /// <param name="channel">channel (required).</param>
        /// <param name="bookingStartDate">Date at which the booking will start. Defaults to today. Allows for returning future contracts/price changes..</param>
        public BookingsV2RateForNewListingRequest(int agencyId = default(int), string agentFirstName = default(string), string agentLastName = default(string), string agentEmail = default(string), string suburb = default(string), string postcode = default(string), string state = default(string), ListingsV1PropertyType propertyType = default(ListingsV1PropertyType), bool isNewDevelopment = default(bool), ListingsV1Objective listingType = default(ListingsV1Objective), double price = default(double), ListingsV1Channel channel = default(ListingsV1Channel), DateTime? bookingStartDate = default(DateTime?))
        {
            this.AgencyId = agencyId;
            // to ensure "agentFirstName" is required (not null)
            this.AgentFirstName = agentFirstName ?? throw new ArgumentNullException("agentFirstName is a required property for BookingsV2RateForNewListingRequest and cannot be null");
            // to ensure "agentLastName" is required (not null)
            this.AgentLastName = agentLastName ?? throw new ArgumentNullException("agentLastName is a required property for BookingsV2RateForNewListingRequest and cannot be null");
            // to ensure "agentEmail" is required (not null)
            this.AgentEmail = agentEmail ?? throw new ArgumentNullException("agentEmail is a required property for BookingsV2RateForNewListingRequest and cannot be null");
            // to ensure "suburb" is required (not null)
            this.Suburb = suburb ?? throw new ArgumentNullException("suburb is a required property for BookingsV2RateForNewListingRequest and cannot be null");
            // to ensure "postcode" is required (not null)
            this.Postcode = postcode ?? throw new ArgumentNullException("postcode is a required property for BookingsV2RateForNewListingRequest and cannot be null");
            // to ensure "state" is required (not null)
            this.State = state ?? throw new ArgumentNullException("state is a required property for BookingsV2RateForNewListingRequest and cannot be null");
            // to ensure "propertyType" is required (not null)
            this.PropertyType = propertyType;
            this.IsNewDevelopment = isNewDevelopment;
            // to ensure "listingType" is required (not null)
            this.ListingType = listingType;
            this.Price = price;
            // to ensure "channel" is required (not null)
            this.Channel = channel;
            this.BookingStartDate = bookingStartDate;
        }

        /// <summary>
        /// Id of the agency for whom rates are to be calculated.
        /// </summary>
        /// <value>Id of the agency for whom rates are to be calculated.</value>
        [DataMember(Name = "agencyId", IsRequired = true, EmitDefaultValue = false)]
        public int AgencyId { get; set; }

        /// <summary>
        /// The first name of the primary agent associated with the listing.
        /// </summary>
        /// <value>The first name of the primary agent associated with the listing.</value>
        [DataMember(Name = "agentFirstName", IsRequired = true, EmitDefaultValue = false)]
        public string AgentFirstName { get; set; }

        /// <summary>
        /// The last name of the primary agent associated with the listing
        /// </summary>
        /// <value>The last name of the primary agent associated with the listing</value>
        [DataMember(Name = "agentLastName", IsRequired = true, EmitDefaultValue = false)]
        public string AgentLastName { get; set; }

        /// <summary>
        /// The email of the primary agent associated with the listing.
        /// </summary>
        /// <value>The email of the primary agent associated with the listing.</value>
        [DataMember(Name = "agentEmail", IsRequired = true, EmitDefaultValue = false)]
        public string AgentEmail { get; set; }

        /// <summary>
        /// Suburb for which rates are to be calculated.
        /// </summary>
        /// <value>Suburb for which rates are to be calculated.</value>
        [DataMember(Name = "suburb", IsRequired = true, EmitDefaultValue = false)]
        public string Suburb { get; set; }

        /// <summary>
        /// Postcode for which rates are to be calculated.
        /// </summary>
        /// <value>Postcode for which rates are to be calculated.</value>
        [DataMember(Name = "postcode", IsRequired = true, EmitDefaultValue = false)]
        public string Postcode { get; set; }

        /// <summary>
        /// State for which rates are to be calculated
        /// </summary>
        /// <value>State for which rates are to be calculated</value>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets PropertyType
        /// </summary>
        [DataMember(Name = "propertyType", IsRequired = true, EmitDefaultValue = false)]
        public ListingsV1PropertyType PropertyType { get; set; }

        /// <summary>
        /// Whether to return the normal or new development rates
        /// </summary>
        /// <value>Whether to return the normal or new development rates</value>
        [DataMember(Name = "isNewDevelopment", IsRequired = true, EmitDefaultValue = false)]
        public bool IsNewDevelopment { get; set; }

        /// <summary>
        /// Gets or Sets ListingType
        /// </summary>
        [DataMember(Name = "listingType", IsRequired = true, EmitDefaultValue = false)]
        public ListingsV1Objective ListingType { get; set; }

        /// <summary>
        /// The value of the listing
        /// </summary>
        /// <value>The value of the listing</value>
        [DataMember(Name = "price", IsRequired = true, EmitDefaultValue = false)]
        public double Price { get; set; }

        /// <summary>
        /// Gets or Sets Channel
        /// </summary>
        [DataMember(Name = "channel", IsRequired = true, EmitDefaultValue = false)]
        public ListingsV1Channel Channel { get; set; }

        /// <summary>
        /// Date at which the booking will start. Defaults to today. Allows for returning future contracts/price changes.
        /// </summary>
        /// <value>Date at which the booking will start. Defaults to today. Allows for returning future contracts/price changes.</value>
        [DataMember(Name = "bookingStartDate", EmitDefaultValue = true)]
        public DateTime? BookingStartDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BookingsV2RateForNewListingRequest {\n");
            sb.Append("  AgencyId: ").Append(AgencyId).Append("\n");
            sb.Append("  AgentFirstName: ").Append(AgentFirstName).Append("\n");
            sb.Append("  AgentLastName: ").Append(AgentLastName).Append("\n");
            sb.Append("  AgentEmail: ").Append(AgentEmail).Append("\n");
            sb.Append("  Suburb: ").Append(Suburb).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PropertyType: ").Append(PropertyType).Append("\n");
            sb.Append("  IsNewDevelopment: ").Append(IsNewDevelopment).Append("\n");
            sb.Append("  ListingType: ").Append(ListingType).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  BookingStartDate: ").Append(BookingStartDate).Append("\n");
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
            return this.Equals(input as BookingsV2RateForNewListingRequest);
        }

        /// <summary>
        /// Returns true if BookingsV2RateForNewListingRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BookingsV2RateForNewListingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BookingsV2RateForNewListingRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AgencyId == input.AgencyId ||
                    this.AgencyId.Equals(input.AgencyId)
                ) && 
                (
                    this.AgentFirstName == input.AgentFirstName ||
                    (this.AgentFirstName != null &&
                    this.AgentFirstName.Equals(input.AgentFirstName))
                ) && 
                (
                    this.AgentLastName == input.AgentLastName ||
                    (this.AgentLastName != null &&
                    this.AgentLastName.Equals(input.AgentLastName))
                ) && 
                (
                    this.AgentEmail == input.AgentEmail ||
                    (this.AgentEmail != null &&
                    this.AgentEmail.Equals(input.AgentEmail))
                ) && 
                (
                    this.Suburb == input.Suburb ||
                    (this.Suburb != null &&
                    this.Suburb.Equals(input.Suburb))
                ) && 
                (
                    this.Postcode == input.Postcode ||
                    (this.Postcode != null &&
                    this.Postcode.Equals(input.Postcode))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.PropertyType == input.PropertyType ||
                    (this.PropertyType != null &&
                    this.PropertyType.Equals(input.PropertyType))
                ) && 
                (
                    this.IsNewDevelopment == input.IsNewDevelopment ||
                    this.IsNewDevelopment.Equals(input.IsNewDevelopment)
                ) && 
                (
                    this.ListingType == input.ListingType ||
                    (this.ListingType != null &&
                    this.ListingType.Equals(input.ListingType))
                ) && 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
                ) && 
                (
                    this.BookingStartDate == input.BookingStartDate ||
                    (this.BookingStartDate != null &&
                    this.BookingStartDate.Equals(input.BookingStartDate))
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
                hashCode = hashCode * 59 + this.AgencyId.GetHashCode();
                if (this.AgentFirstName != null)
                    hashCode = hashCode * 59 + this.AgentFirstName.GetHashCode();
                if (this.AgentLastName != null)
                    hashCode = hashCode * 59 + this.AgentLastName.GetHashCode();
                if (this.AgentEmail != null)
                    hashCode = hashCode * 59 + this.AgentEmail.GetHashCode();
                if (this.Suburb != null)
                    hashCode = hashCode * 59 + this.Suburb.GetHashCode();
                if (this.Postcode != null)
                    hashCode = hashCode * 59 + this.Postcode.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.PropertyType != null)
                    hashCode = hashCode * 59 + this.PropertyType.GetHashCode();
                hashCode = hashCode * 59 + this.IsNewDevelopment.GetHashCode();
                if (this.ListingType != null)
                    hashCode = hashCode * 59 + this.ListingType.GetHashCode();
                hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Channel != null)
                    hashCode = hashCode * 59 + this.Channel.GetHashCode();
                if (this.BookingStartDate != null)
                    hashCode = hashCode * 59 + this.BookingStartDate.GetHashCode();
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
