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
    /// Encapsulates the listing&#39;s advertiser identifiers
    /// </summary>
    [DataContract(Name = "Listings.V2.AdvertiserIdentifiers")]
    public partial class ListingsV2AdvertiserIdentifiers : IEquatable<ListingsV2AdvertiserIdentifiers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingsV2AdvertiserIdentifiers" /> class.
        /// </summary>
        /// <param name="advertiserType">advertiserType.</param>
        /// <param name="advertiserId">Advertiser&#39;s identifier.</param>
        /// <param name="contactIds">Identifier of each contact the advertiser has associated with the listing.</param>
        /// <param name="agentIds">Identifier of each agent the advertiser has associated with the listing.</param>
        /// <param name="conjunctionContactIds">Identifier of each conjunctional contact associated with the listing.</param>
        /// <param name="conjunctionAgentIds">Identifier of each conjunctional agent associated with the listing.</param>
        public ListingsV2AdvertiserIdentifiers(ListingsV2AdvertiserType advertiserType = default(ListingsV2AdvertiserType), int? advertiserId = default(int?), List<int> contactIds = default(List<int>), List<string> agentIds = default(List<string>), List<int> conjunctionContactIds = default(List<int>), List<string> conjunctionAgentIds = default(List<string>))
        {
            this.AdvertiserType = advertiserType;
            this.AdvertiserId = advertiserId;
            this.ContactIds = contactIds;
            this.AgentIds = agentIds;
            this.ConjunctionContactIds = conjunctionContactIds;
            this.ConjunctionAgentIds = conjunctionAgentIds;
        }

        /// <summary>
        /// Gets or Sets AdvertiserType
        /// </summary>
        [DataMember(Name = "advertiserType", EmitDefaultValue = false)]
        public ListingsV2AdvertiserType AdvertiserType { get; set; }

        /// <summary>
        /// Advertiser&#39;s identifier
        /// </summary>
        /// <value>Advertiser&#39;s identifier</value>
        [DataMember(Name = "advertiserId", EmitDefaultValue = true)]
        public int? AdvertiserId { get; set; }

        /// <summary>
        /// Identifier of each contact the advertiser has associated with the listing
        /// </summary>
        /// <value>Identifier of each contact the advertiser has associated with the listing</value>
        [DataMember(Name = "contactIds", EmitDefaultValue = true)]
        public List<int> ContactIds { get; set; }

        /// <summary>
        /// Identifier of each agent the advertiser has associated with the listing
        /// </summary>
        /// <value>Identifier of each agent the advertiser has associated with the listing</value>
        [DataMember(Name = "agentIds", EmitDefaultValue = true)]
        public List<string> AgentIds { get; set; }

        /// <summary>
        /// Identifier of each conjunctional contact associated with the listing
        /// </summary>
        /// <value>Identifier of each conjunctional contact associated with the listing</value>
        [DataMember(Name = "conjunctionContactIds", EmitDefaultValue = true)]
        public List<int> ConjunctionContactIds { get; set; }

        /// <summary>
        /// Identifier of each conjunctional agent associated with the listing
        /// </summary>
        /// <value>Identifier of each conjunctional agent associated with the listing</value>
        [DataMember(Name = "conjunctionAgentIds", EmitDefaultValue = true)]
        public List<string> ConjunctionAgentIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListingsV2AdvertiserIdentifiers {\n");
            sb.Append("  AdvertiserType: ").Append(AdvertiserType).Append("\n");
            sb.Append("  AdvertiserId: ").Append(AdvertiserId).Append("\n");
            sb.Append("  ContactIds: ").Append(ContactIds).Append("\n");
            sb.Append("  AgentIds: ").Append(AgentIds).Append("\n");
            sb.Append("  ConjunctionContactIds: ").Append(ConjunctionContactIds).Append("\n");
            sb.Append("  ConjunctionAgentIds: ").Append(ConjunctionAgentIds).Append("\n");
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
            return this.Equals(input as ListingsV2AdvertiserIdentifiers);
        }

        /// <summary>
        /// Returns true if ListingsV2AdvertiserIdentifiers instances are equal
        /// </summary>
        /// <param name="input">Instance of ListingsV2AdvertiserIdentifiers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListingsV2AdvertiserIdentifiers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdvertiserType == input.AdvertiserType ||
                    (this.AdvertiserType != null &&
                    this.AdvertiserType.Equals(input.AdvertiserType))
                ) && 
                (
                    this.AdvertiserId == input.AdvertiserId ||
                    (this.AdvertiserId != null &&
                    this.AdvertiserId.Equals(input.AdvertiserId))
                ) && 
                (
                    this.ContactIds == input.ContactIds ||
                    this.ContactIds != null &&
                    input.ContactIds != null &&
                    this.ContactIds.SequenceEqual(input.ContactIds)
                ) && 
                (
                    this.AgentIds == input.AgentIds ||
                    this.AgentIds != null &&
                    input.AgentIds != null &&
                    this.AgentIds.SequenceEqual(input.AgentIds)
                ) && 
                (
                    this.ConjunctionContactIds == input.ConjunctionContactIds ||
                    this.ConjunctionContactIds != null &&
                    input.ConjunctionContactIds != null &&
                    this.ConjunctionContactIds.SequenceEqual(input.ConjunctionContactIds)
                ) && 
                (
                    this.ConjunctionAgentIds == input.ConjunctionAgentIds ||
                    this.ConjunctionAgentIds != null &&
                    input.ConjunctionAgentIds != null &&
                    this.ConjunctionAgentIds.SequenceEqual(input.ConjunctionAgentIds)
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
                if (this.AdvertiserType != null)
                    hashCode = hashCode * 59 + this.AdvertiserType.GetHashCode();
                if (this.AdvertiserId != null)
                    hashCode = hashCode * 59 + this.AdvertiserId.GetHashCode();
                if (this.ContactIds != null)
                    hashCode = hashCode * 59 + this.ContactIds.GetHashCode();
                if (this.AgentIds != null)
                    hashCode = hashCode * 59 + this.AgentIds.GetHashCode();
                if (this.ConjunctionContactIds != null)
                    hashCode = hashCode * 59 + this.ConjunctionContactIds.GetHashCode();
                if (this.ConjunctionAgentIds != null)
                    hashCode = hashCode * 59 + this.ConjunctionAgentIds.GetHashCode();
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
