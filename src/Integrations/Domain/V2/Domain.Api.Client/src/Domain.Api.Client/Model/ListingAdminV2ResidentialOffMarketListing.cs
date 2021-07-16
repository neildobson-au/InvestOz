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
    /// Residential off market listing
    /// </summary>
    [DataContract(Name = "ListingAdmin.v2.ResidentialOffMarketListing")]
    public partial class ListingAdminV2ResidentialOffMarketListing : IEquatable<ListingAdminV2ResidentialOffMarketListing>, IValidatableObject
    {
        /// <summary>
        /// Sale or Rent
        /// </summary>
        /// <value>Sale or Rent</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ListingActionEnum
        {
            /// <summary>
            /// Enum Sale for value: sale
            /// </summary>
            [EnumMember(Value = "sale")]
            Sale = 1,

            /// <summary>
            /// Enum Rent for value: rent
            /// </summary>
            [EnumMember(Value = "rent")]
            Rent = 2

        }

        /// <summary>
        /// Sale or Rent
        /// </summary>
        /// <value>Sale or Rent</value>
        [DataMember(Name = "listingAction", IsRequired = true, EmitDefaultValue = false)]
        public ListingActionEnum ListingAction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingAdminV2ResidentialOffMarketListing" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListingAdminV2ResidentialOffMarketListing() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingAdminV2ResidentialOffMarketListing" /> class.
        /// </summary>
        /// <param name="inspectionDetails">inspectionDetails.</param>
        /// <param name="listingProvider">A string identifying the data provider.</param>
        /// <param name="domainAgencyID">The Domain Agency ID (required).</param>
        /// <param name="providerAdId">External Advertisement Id of up to 50 characters will be stored.&lt;br /&gt;  This value is used to identify an Advertisement for updates and should be unique for listing provider.&lt;br /&gt;  This value is case-insensitive (meaning AAAA will update aaaa). (required).</param>
        /// <param name="description">Description of the property.  6000 characters in length. The following HTML elements are permitted: &amp;lt;br /&amp;gt;, &amp;lt;p&amp;gt;&amp;lt;/p&amp;gt;, &amp;amp;nbsp;. HTML must be well-formed.  Carriage Returns are interpreted as line breaks. Foreign characters must be HTML encoded, e.g., façade for façade.</param>
        /// <param name="summary">&#39;Headline&#39; Any HTML stripped out.  If the Summary is less than 80 characters long then the description is concatenated to it and the total trimmed to 250 characters..</param>
        /// <param name="contacts">Minimum required attributes: First name, last name and E-mail.  If the DomainAgentId is provided, contact information will be based on the existing agent found for that id.  Otherwise first name, last name and email will be used to find the matching contact. A new contact will be created if no contact can be found..</param>
        /// <param name="listingAction">Sale or Rent (required).</param>
        /// <param name="offMarketDetails">offMarketDetails (required).</param>
        /// <param name="propertyDetails">propertyDetails (required).</param>
        public ListingAdminV2ResidentialOffMarketListing(ListingAdminV2InspectionDetails inspectionDetails = default(ListingAdminV2InspectionDetails), string listingProvider = default(string), int domainAgencyID = default(int), string providerAdId = default(string), string description = default(string), string summary = default(string), List<ListingAdminV2Contact> contacts = default(List<ListingAdminV2Contact>), ListingActionEnum listingAction = default(ListingActionEnum), ListingAdminV2OffMarketDetailsBase offMarketDetails = default(ListingAdminV2OffMarketDetailsBase), ListingAdminV2ResidentialOffMarketProperty propertyDetails = default(ListingAdminV2ResidentialOffMarketProperty))
        {
            this.DomainAgencyID = domainAgencyID;
            // to ensure "providerAdId" is required (not null)
            this.ProviderAdId = providerAdId ?? throw new ArgumentNullException("providerAdId is a required property for ListingAdminV2ResidentialOffMarketListing and cannot be null");
            this.ListingAction = listingAction;
            // to ensure "offMarketDetails" is required (not null)
            this.OffMarketDetails = offMarketDetails ?? throw new ArgumentNullException("offMarketDetails is a required property for ListingAdminV2ResidentialOffMarketListing and cannot be null");
            // to ensure "propertyDetails" is required (not null)
            this.PropertyDetails = propertyDetails ?? throw new ArgumentNullException("propertyDetails is a required property for ListingAdminV2ResidentialOffMarketListing and cannot be null");
            this.InspectionDetails = inspectionDetails;
            this.ListingProvider = listingProvider;
            this.Description = description;
            this.Summary = summary;
            this.Contacts = contacts;
        }

        /// <summary>
        /// Domain Ad ID
        /// </summary>
        /// <value>Domain Ad ID</value>
        [DataMember(Name = "domainAdId", EmitDefaultValue = false)]
        public int DomainAdId { get; private set; }

        /// <summary>
        /// Returns false as DomainAdId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDomainAdId()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets InspectionDetails
        /// </summary>
        [DataMember(Name = "inspectionDetails", EmitDefaultValue = false)]
        public ListingAdminV2InspectionDetails InspectionDetails { get; set; }

        /// <summary>
        /// True if the property is rural
        /// </summary>
        /// <value>True if the property is rural</value>
        [DataMember(Name = "isRural", EmitDefaultValue = false)]
        public bool IsRural { get; private set; }

        /// <summary>
        /// Returns false as IsRural should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsRural()
        {
            return false;
        }

        /// <summary>
        /// A string identifying the data provider
        /// </summary>
        /// <value>A string identifying the data provider</value>
        [DataMember(Name = "listingProvider", EmitDefaultValue = false)]
        public string ListingProvider { get; set; }

        /// <summary>
        /// The Domain Agency ID
        /// </summary>
        /// <value>The Domain Agency ID</value>
        [DataMember(Name = "domainAgencyID", IsRequired = true, EmitDefaultValue = false)]
        public int DomainAgencyID { get; set; }

        /// <summary>
        /// External Advertisement Id of up to 50 characters will be stored.&lt;br /&gt;  This value is used to identify an Advertisement for updates and should be unique for listing provider.&lt;br /&gt;  This value is case-insensitive (meaning AAAA will update aaaa).
        /// </summary>
        /// <value>External Advertisement Id of up to 50 characters will be stored.&lt;br /&gt;  This value is used to identify an Advertisement for updates and should be unique for listing provider.&lt;br /&gt;  This value is case-insensitive (meaning AAAA will update aaaa).</value>
        [DataMember(Name = "providerAdId", IsRequired = true, EmitDefaultValue = false)]
        public string ProviderAdId { get; set; }

        /// <summary>
        /// Description of the property.  6000 characters in length. The following HTML elements are permitted: &amp;lt;br /&amp;gt;, &amp;lt;p&amp;gt;&amp;lt;/p&amp;gt;, &amp;amp;nbsp;. HTML must be well-formed.  Carriage Returns are interpreted as line breaks. Foreign characters must be HTML encoded, e.g., façade for façade
        /// </summary>
        /// <value>Description of the property.  6000 characters in length. The following HTML elements are permitted: &amp;lt;br /&amp;gt;, &amp;lt;p&amp;gt;&amp;lt;/p&amp;gt;, &amp;amp;nbsp;. HTML must be well-formed.  Carriage Returns are interpreted as line breaks. Foreign characters must be HTML encoded, e.g., façade for façade</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// &#39;Headline&#39; Any HTML stripped out.  If the Summary is less than 80 characters long then the description is concatenated to it and the total trimmed to 250 characters.
        /// </summary>
        /// <value>&#39;Headline&#39; Any HTML stripped out.  If the Summary is less than 80 characters long then the description is concatenated to it and the total trimmed to 250 characters.</value>
        [DataMember(Name = "summary", EmitDefaultValue = false)]
        public string Summary { get; set; }

        /// <summary>
        /// Minimum required attributes: First name, last name and E-mail.  If the DomainAgentId is provided, contact information will be based on the existing agent found for that id.  Otherwise first name, last name and email will be used to find the matching contact. A new contact will be created if no contact can be found.
        /// </summary>
        /// <value>Minimum required attributes: First name, last name and E-mail.  If the DomainAgentId is provided, contact information will be based on the existing agent found for that id.  Otherwise first name, last name and email will be used to find the matching contact. A new contact will be created if no contact can be found.</value>
        [DataMember(Name = "contacts", EmitDefaultValue = false)]
        public List<ListingAdminV2Contact> Contacts { get; set; }

        /// <summary>
        /// Gets or Sets OffMarketDetails
        /// </summary>
        [DataMember(Name = "offMarketDetails", IsRequired = true, EmitDefaultValue = false)]
        public ListingAdminV2OffMarketDetailsBase OffMarketDetails { get; set; }

        /// <summary>
        /// Gets or Sets PropertyDetails
        /// </summary>
        [DataMember(Name = "propertyDetails", IsRequired = true, EmitDefaultValue = false)]
        public ListingAdminV2ResidentialOffMarketProperty PropertyDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListingAdminV2ResidentialOffMarketListing {\n");
            sb.Append("  DomainAdId: ").Append(DomainAdId).Append("\n");
            sb.Append("  InspectionDetails: ").Append(InspectionDetails).Append("\n");
            sb.Append("  IsRural: ").Append(IsRural).Append("\n");
            sb.Append("  ListingProvider: ").Append(ListingProvider).Append("\n");
            sb.Append("  DomainAgencyID: ").Append(DomainAgencyID).Append("\n");
            sb.Append("  ProviderAdId: ").Append(ProviderAdId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  ListingAction: ").Append(ListingAction).Append("\n");
            sb.Append("  OffMarketDetails: ").Append(OffMarketDetails).Append("\n");
            sb.Append("  PropertyDetails: ").Append(PropertyDetails).Append("\n");
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
            return this.Equals(input as ListingAdminV2ResidentialOffMarketListing);
        }

        /// <summary>
        /// Returns true if ListingAdminV2ResidentialOffMarketListing instances are equal
        /// </summary>
        /// <param name="input">Instance of ListingAdminV2ResidentialOffMarketListing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListingAdminV2ResidentialOffMarketListing input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainAdId == input.DomainAdId ||
                    this.DomainAdId.Equals(input.DomainAdId)
                ) && 
                (
                    this.InspectionDetails == input.InspectionDetails ||
                    (this.InspectionDetails != null &&
                    this.InspectionDetails.Equals(input.InspectionDetails))
                ) && 
                (
                    this.IsRural == input.IsRural ||
                    this.IsRural.Equals(input.IsRural)
                ) && 
                (
                    this.ListingProvider == input.ListingProvider ||
                    (this.ListingProvider != null &&
                    this.ListingProvider.Equals(input.ListingProvider))
                ) && 
                (
                    this.DomainAgencyID == input.DomainAgencyID ||
                    this.DomainAgencyID.Equals(input.DomainAgencyID)
                ) && 
                (
                    this.ProviderAdId == input.ProviderAdId ||
                    (this.ProviderAdId != null &&
                    this.ProviderAdId.Equals(input.ProviderAdId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.Contacts == input.Contacts ||
                    this.Contacts != null &&
                    input.Contacts != null &&
                    this.Contacts.SequenceEqual(input.Contacts)
                ) && 
                (
                    this.ListingAction == input.ListingAction ||
                    this.ListingAction.Equals(input.ListingAction)
                ) && 
                (
                    this.OffMarketDetails == input.OffMarketDetails ||
                    (this.OffMarketDetails != null &&
                    this.OffMarketDetails.Equals(input.OffMarketDetails))
                ) && 
                (
                    this.PropertyDetails == input.PropertyDetails ||
                    (this.PropertyDetails != null &&
                    this.PropertyDetails.Equals(input.PropertyDetails))
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
                hashCode = hashCode * 59 + this.DomainAdId.GetHashCode();
                if (this.InspectionDetails != null)
                    hashCode = hashCode * 59 + this.InspectionDetails.GetHashCode();
                hashCode = hashCode * 59 + this.IsRural.GetHashCode();
                if (this.ListingProvider != null)
                    hashCode = hashCode * 59 + this.ListingProvider.GetHashCode();
                hashCode = hashCode * 59 + this.DomainAgencyID.GetHashCode();
                if (this.ProviderAdId != null)
                    hashCode = hashCode * 59 + this.ProviderAdId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.Contacts != null)
                    hashCode = hashCode * 59 + this.Contacts.GetHashCode();
                hashCode = hashCode * 59 + this.ListingAction.GetHashCode();
                if (this.OffMarketDetails != null)
                    hashCode = hashCode * 59 + this.OffMarketDetails.GetHashCode();
                if (this.PropertyDetails != null)
                    hashCode = hashCode * 59 + this.PropertyDetails.GetHashCode();
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
            // DomainAgencyID (int) maximum
            if(this.DomainAgencyID > (int)2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DomainAgencyID, must be a value less than or equal to 2147483647.", new [] { "DomainAgencyID" });
            }

            // DomainAgencyID (int) minimum
            if(this.DomainAgencyID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DomainAgencyID, must be a value greater than or equal to 0.", new [] { "DomainAgencyID" });
            }

            // ProviderAdId (string) maxLength
            if(this.ProviderAdId != null && this.ProviderAdId.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProviderAdId, length must be less than 50.", new [] { "ProviderAdId" });
            }

            // ProviderAdId (string) minLength
            if(this.ProviderAdId != null && this.ProviderAdId.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProviderAdId, length must be greater than 0.", new [] { "ProviderAdId" });
            }

            // Description (string) maxLength
            if(this.Description != null && this.Description.Length > 6000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 6000.", new [] { "Description" });
            }

            // Description (string) minLength
            if(this.Description != null && this.Description.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 0.", new [] { "Description" });
            }

            // Summary (string) maxLength
            if(this.Summary != null && this.Summary.Length > 250)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Summary, length must be less than 250.", new [] { "Summary" });
            }

            // Summary (string) minLength
            if(this.Summary != null && this.Summary.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Summary, length must be greater than 0.", new [] { "Summary" });
            }

            yield break;
        }
    }

}
