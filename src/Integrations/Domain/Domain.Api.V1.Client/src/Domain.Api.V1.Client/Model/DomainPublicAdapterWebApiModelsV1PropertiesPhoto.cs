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
    /// A property photo
    /// </summary>
    [DataContract(Name = "Domain.Public.Adapter.Web.Api.Models.v1.Properties.Photo")]
    public partial class DomainPublicAdapterWebApiModelsV1PropertiesPhoto : IEquatable<DomainPublicAdapterWebApiModelsV1PropertiesPhoto>, IValidatableObject
    {
        /// <summary>
        /// The type of photo.
        /// </summary>
        /// <value>The type of photo.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ImageTypeEnum
        {
            /// <summary>
            /// Enum Property for value: Property
            /// </summary>
            [EnumMember(Value = "Property")]
            Property = 1,

            /// <summary>
            /// Enum Floorplan for value: Floorplan
            /// </summary>
            [EnumMember(Value = "Floorplan")]
            Floorplan = 2,

            /// <summary>
            /// Enum GoogleStreetView for value: GoogleStreetView
            /// </summary>
            [EnumMember(Value = "GoogleStreetView")]
            GoogleStreetView = 3

        }

        /// <summary>
        /// The type of photo.
        /// </summary>
        /// <value>The type of photo.</value>
        [DataMember(Name = "imageType", EmitDefaultValue = false)]
        public ImageTypeEnum? ImageType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainPublicAdapterWebApiModelsV1PropertiesPhoto" /> class.
        /// </summary>
        /// <param name="imageType">The type of photo..</param>
        /// <param name="advertId">Gets or sets the advert identifier from which this photo relates.</param>
        /// <param name="date">Gets or sets the date of the photo.</param>
        /// <param name="fullUrl">The full size photo url..</param>
        /// <param name="rank">The rank of the photo. Lower rank &#x3D; more preferred photo..</param>
        public DomainPublicAdapterWebApiModelsV1PropertiesPhoto(ImageTypeEnum? imageType = default(ImageTypeEnum?), int advertId = default(int), DateTime date = default(DateTime), string fullUrl = default(string), int rank = default(int))
        {
            this.ImageType = imageType;
            this.AdvertId = advertId;
            this.Date = date;
            this.FullUrl = fullUrl;
            this.Rank = rank;
        }

        /// <summary>
        /// Gets or sets the advert identifier from which this photo relates
        /// </summary>
        /// <value>Gets or sets the advert identifier from which this photo relates</value>
        [DataMember(Name = "advertId", EmitDefaultValue = false)]
        public int AdvertId { get; set; }

        /// <summary>
        /// Gets or sets the date of the photo
        /// </summary>
        /// <value>Gets or sets the date of the photo</value>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The full size photo url.
        /// </summary>
        /// <value>The full size photo url.</value>
        [DataMember(Name = "fullUrl", EmitDefaultValue = false)]
        public string FullUrl { get; set; }

        /// <summary>
        /// The rank of the photo. Lower rank &#x3D; more preferred photo.
        /// </summary>
        /// <value>The rank of the photo. Lower rank &#x3D; more preferred photo.</value>
        [DataMember(Name = "rank", EmitDefaultValue = false)]
        public int Rank { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainPublicAdapterWebApiModelsV1PropertiesPhoto {\n");
            sb.Append("  ImageType: ").Append(ImageType).Append("\n");
            sb.Append("  AdvertId: ").Append(AdvertId).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  FullUrl: ").Append(FullUrl).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
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
            return this.Equals(input as DomainPublicAdapterWebApiModelsV1PropertiesPhoto);
        }

        /// <summary>
        /// Returns true if DomainPublicAdapterWebApiModelsV1PropertiesPhoto instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainPublicAdapterWebApiModelsV1PropertiesPhoto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainPublicAdapterWebApiModelsV1PropertiesPhoto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImageType == input.ImageType ||
                    this.ImageType.Equals(input.ImageType)
                ) && 
                (
                    this.AdvertId == input.AdvertId ||
                    this.AdvertId.Equals(input.AdvertId)
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.FullUrl == input.FullUrl ||
                    (this.FullUrl != null &&
                    this.FullUrl.Equals(input.FullUrl))
                ) && 
                (
                    this.Rank == input.Rank ||
                    this.Rank.Equals(input.Rank)
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
                hashCode = hashCode * 59 + this.ImageType.GetHashCode();
                hashCode = hashCode * 59 + this.AdvertId.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.FullUrl != null)
                    hashCode = hashCode * 59 + this.FullUrl.GetHashCode();
                hashCode = hashCode * 59 + this.Rank.GetHashCode();
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
