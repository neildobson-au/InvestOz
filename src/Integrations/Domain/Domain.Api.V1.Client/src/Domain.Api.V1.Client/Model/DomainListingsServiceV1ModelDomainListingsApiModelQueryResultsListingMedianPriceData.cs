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
    /// DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingMedianPriceData
    /// </summary>
    [DataContract(Name = "Domain.ListingsService.v1.Model.DomainListingsApiModelQueryResultsListingMedianPriceData")]
    public partial class DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingMedianPriceData : IEquatable<DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingMedianPriceData>, IValidatableObject
    {
        /// <summary>
        /// Defines PriceType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PriceTypeEnum
        {
            /// <summary>
            /// Enum House for value: house
            /// </summary>
            [EnumMember(Value = "house")]
            House = 1,

            /// <summary>
            /// Enum ApartmentUnitFlat for value: apartmentUnitFlat
            /// </summary>
            [EnumMember(Value = "apartmentUnitFlat")]
            ApartmentUnitFlat = 2,

            /// <summary>
            /// Enum VacantLand for value: vacantLand
            /// </summary>
            [EnumMember(Value = "vacantLand")]
            VacantLand = 3

        }

        /// <summary>
        /// Gets or Sets PriceType
        /// </summary>
        [DataMember(Name = "priceType", EmitDefaultValue = false)]
        public PriceTypeEnum? PriceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingMedianPriceData" /> class.
        /// </summary>
        /// <param name="priceType">priceType.</param>
        /// <param name="suburb">suburb.</param>
        /// <param name="postcode">postcode.</param>
        /// <param name="medianPrice">medianPrice.</param>
        /// <param name="source">source.</param>
        /// <param name="sourceDateFrom">sourceDateFrom.</param>
        /// <param name="sourceDateTo">sourceDateTo.</param>
        /// <param name="sourceCollectionDate">sourceCollectionDate.</param>
        public DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingMedianPriceData(PriceTypeEnum? priceType = default(PriceTypeEnum?), string suburb = default(string), string postcode = default(string), int medianPrice = default(int), string source = default(string), string sourceDateFrom = default(string), string sourceDateTo = default(string), string sourceCollectionDate = default(string))
        {
            this.PriceType = priceType;
            this.Suburb = suburb;
            this.Postcode = postcode;
            this.MedianPrice = medianPrice;
            this.Source = source;
            this.SourceDateFrom = sourceDateFrom;
            this.SourceDateTo = sourceDateTo;
            this.SourceCollectionDate = sourceCollectionDate;
        }

        /// <summary>
        /// Gets or Sets Suburb
        /// </summary>
        [DataMember(Name = "suburb", EmitDefaultValue = false)]
        public string Suburb { get; set; }

        /// <summary>
        /// Gets or Sets Postcode
        /// </summary>
        [DataMember(Name = "postcode", EmitDefaultValue = false)]
        public string Postcode { get; set; }

        /// <summary>
        /// Gets or Sets MedianPrice
        /// </summary>
        [DataMember(Name = "medianPrice", EmitDefaultValue = false)]
        public int MedianPrice { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets SourceDateFrom
        /// </summary>
        [DataMember(Name = "sourceDateFrom", EmitDefaultValue = false)]
        public string SourceDateFrom { get; set; }

        /// <summary>
        /// Gets or Sets SourceDateTo
        /// </summary>
        [DataMember(Name = "sourceDateTo", EmitDefaultValue = false)]
        public string SourceDateTo { get; set; }

        /// <summary>
        /// Gets or Sets SourceCollectionDate
        /// </summary>
        [DataMember(Name = "sourceCollectionDate", EmitDefaultValue = false)]
        public string SourceCollectionDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingMedianPriceData {\n");
            sb.Append("  PriceType: ").Append(PriceType).Append("\n");
            sb.Append("  Suburb: ").Append(Suburb).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  MedianPrice: ").Append(MedianPrice).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  SourceDateFrom: ").Append(SourceDateFrom).Append("\n");
            sb.Append("  SourceDateTo: ").Append(SourceDateTo).Append("\n");
            sb.Append("  SourceCollectionDate: ").Append(SourceCollectionDate).Append("\n");
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
            return this.Equals(input as DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingMedianPriceData);
        }

        /// <summary>
        /// Returns true if DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingMedianPriceData instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingMedianPriceData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingMedianPriceData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PriceType == input.PriceType ||
                    this.PriceType.Equals(input.PriceType)
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
                    this.MedianPrice == input.MedianPrice ||
                    this.MedianPrice.Equals(input.MedianPrice)
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.SourceDateFrom == input.SourceDateFrom ||
                    (this.SourceDateFrom != null &&
                    this.SourceDateFrom.Equals(input.SourceDateFrom))
                ) && 
                (
                    this.SourceDateTo == input.SourceDateTo ||
                    (this.SourceDateTo != null &&
                    this.SourceDateTo.Equals(input.SourceDateTo))
                ) && 
                (
                    this.SourceCollectionDate == input.SourceCollectionDate ||
                    (this.SourceCollectionDate != null &&
                    this.SourceCollectionDate.Equals(input.SourceCollectionDate))
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
                hashCode = hashCode * 59 + this.PriceType.GetHashCode();
                if (this.Suburb != null)
                    hashCode = hashCode * 59 + this.Suburb.GetHashCode();
                if (this.Postcode != null)
                    hashCode = hashCode * 59 + this.Postcode.GetHashCode();
                hashCode = hashCode * 59 + this.MedianPrice.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.SourceDateFrom != null)
                    hashCode = hashCode * 59 + this.SourceDateFrom.GetHashCode();
                if (this.SourceDateTo != null)
                    hashCode = hashCode * 59 + this.SourceDateTo.GetHashCode();
                if (this.SourceCollectionDate != null)
                    hashCode = hashCode * 59 + this.SourceCollectionDate.GetHashCode();
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
