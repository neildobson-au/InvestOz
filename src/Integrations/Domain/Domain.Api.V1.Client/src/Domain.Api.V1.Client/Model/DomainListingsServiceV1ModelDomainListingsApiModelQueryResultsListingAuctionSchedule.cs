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
    /// DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingAuctionSchedule
    /// </summary>
    [DataContract(Name = "Domain.ListingsService.v1.Model.DomainListingsApiModelQueryResultsListingAuctionSchedule")]
    public partial class DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingAuctionSchedule : IEquatable<DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingAuctionSchedule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingAuctionSchedule" /> class.
        /// </summary>
        /// <param name="locationDescription">locationDescription.</param>
        /// <param name="openingDateTime">openingDateTime.</param>
        /// <param name="terms">terms.</param>
        public DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingAuctionSchedule(string locationDescription = default(string), DateTime openingDateTime = default(DateTime), string terms = default(string))
        {
            this.LocationDescription = locationDescription;
            this.OpeningDateTime = openingDateTime;
            this.Terms = terms;
        }

        /// <summary>
        /// Gets or Sets LocationDescription
        /// </summary>
        [DataMember(Name = "locationDescription", EmitDefaultValue = false)]
        public string LocationDescription { get; set; }

        /// <summary>
        /// Gets or Sets OpeningDateTime
        /// </summary>
        [DataMember(Name = "openingDateTime", EmitDefaultValue = false)]
        public DateTime OpeningDateTime { get; set; }

        /// <summary>
        /// Gets or Sets Terms
        /// </summary>
        [DataMember(Name = "terms", EmitDefaultValue = false)]
        public string Terms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingAuctionSchedule {\n");
            sb.Append("  LocationDescription: ").Append(LocationDescription).Append("\n");
            sb.Append("  OpeningDateTime: ").Append(OpeningDateTime).Append("\n");
            sb.Append("  Terms: ").Append(Terms).Append("\n");
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
            return this.Equals(input as DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingAuctionSchedule);
        }

        /// <summary>
        /// Returns true if DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingAuctionSchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingAuctionSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingAuctionSchedule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LocationDescription == input.LocationDescription ||
                    (this.LocationDescription != null &&
                    this.LocationDescription.Equals(input.LocationDescription))
                ) && 
                (
                    this.OpeningDateTime == input.OpeningDateTime ||
                    (this.OpeningDateTime != null &&
                    this.OpeningDateTime.Equals(input.OpeningDateTime))
                ) && 
                (
                    this.Terms == input.Terms ||
                    (this.Terms != null &&
                    this.Terms.Equals(input.Terms))
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
                if (this.LocationDescription != null)
                    hashCode = hashCode * 59 + this.LocationDescription.GetHashCode();
                if (this.OpeningDateTime != null)
                    hashCode = hashCode * 59 + this.OpeningDateTime.GetHashCode();
                if (this.Terms != null)
                    hashCode = hashCode * 59 + this.Terms.GetHashCode();
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
