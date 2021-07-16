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
    /// PreMarketV1PropertyMedia
    /// </summary>
    [DataContract(Name = "PreMarket.v1.PropertyMedia")]
    public partial class PreMarketV1PropertyMedia : IEquatable<PreMarketV1PropertyMedia>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PreMarketV1PropertyMedia" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PreMarketV1PropertyMedia() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PreMarketV1PropertyMedia" /> class.
        /// </summary>
        /// <param name="resourceType">resourceType (required).</param>
        /// <param name="url">url (required).</param>
        public PreMarketV1PropertyMedia(PreMarketV1ResourceType resourceType = default(PreMarketV1ResourceType), string url = default(string))
        {
            // to ensure "resourceType" is required (not null)
            this.ResourceType = resourceType;
            // to ensure "url" is required (not null)
            this.Url = url ?? throw new ArgumentNullException("url is a required property for PreMarketV1PropertyMedia and cannot be null");
        }

        /// <summary>
        /// Gets or Sets ResourceType
        /// </summary>
        [DataMember(Name = "resourceType", IsRequired = true, EmitDefaultValue = false)]
        public PreMarketV1ResourceType ResourceType { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PreMarketV1PropertyMedia {\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as PreMarketV1PropertyMedia);
        }

        /// <summary>
        /// Returns true if PreMarketV1PropertyMedia instances are equal
        /// </summary>
        /// <param name="input">Instance of PreMarketV1PropertyMedia to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PreMarketV1PropertyMedia input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResourceType == input.ResourceType ||
                    (this.ResourceType != null &&
                    this.ResourceType.Equals(input.ResourceType))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.ResourceType != null)
                    hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
            // Url (string) pattern
            Regex regexUrl = new Regex(@"^http[s]?:+.*", RegexOptions.CultureInvariant);
            if (false == regexUrl.Match(this.Url).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Url, must match a pattern of " + regexUrl, new [] { "Url" });
            }

            yield break;
        }
    }

}
