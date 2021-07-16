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
    /// Summary of listing details
    /// </summary>
    [DataContract(Name = "Domain.Public.Adapter.Web.Api.Models.v1.SalesResults.ListingSummary")]
    public partial class DomainPublicAdapterWebApiModelsV1SalesResultsListingSummary : IEquatable<DomainPublicAdapterWebApiModelsV1SalesResultsListingSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainPublicAdapterWebApiModelsV1SalesResultsListingSummary" /> class.
        /// </summary>
        /// <param name="unitNumber">Gets or Sets UnitNumber.</param>
        /// <param name="streetNumber">Gets or Sets StreetNumber.</param>
        /// <param name="streetName">Gets or Sets StreetName.</param>
        /// <param name="streetType">Gets or Sets StreetType.</param>
        /// <param name="suburb">Gets or Sets Suburb.</param>
        /// <param name="postcode">Gets or Sets Postcode.</param>
        /// <param name="state">Gets or Sets State.</param>
        /// <param name="geoLocation">geoLocation.</param>
        /// <param name="propertyType">Gets or Sets PropertyType.</param>
        /// <param name="bedrooms">Gets or Sets Bedrooms.</param>
        /// <param name="bathrooms">Gets or Sets Bathrooms.</param>
        /// <param name="carspaces">Gets or Sets Carspaces.</param>
        /// <param name="price">Gets or Sets Price.</param>
        /// <param name="result">Gets or Sets Result.</param>
        /// <param name="agent">Gets or Sets Agent.</param>
        /// <param name="id">Gets or Sets the listing id.</param>
        /// <param name="agencyId">Gets or Sets DomainAgencyId.</param>
        /// <param name="agencyName">Gets or Sets AgencyName.</param>
        /// <param name="agencyProfilePageUrl">Gets or Sets AgencyProfilePageUrl.</param>
        /// <param name="propertyDetailsUrl">Gets or Sets DomainPropertyDetailsUrl.</param>
        public DomainPublicAdapterWebApiModelsV1SalesResultsListingSummary(string unitNumber = default(string), string streetNumber = default(string), string streetName = default(string), string streetType = default(string), string suburb = default(string), string postcode = default(string), string state = default(string), DomainPublicAdapterWebApiModelsV1SalesResultsGeoLocation geoLocation = default(DomainPublicAdapterWebApiModelsV1SalesResultsGeoLocation), string propertyType = default(string), int bedrooms = default(int), int bathrooms = default(int), int carspaces = default(int), int price = default(int), string result = default(string), string agent = default(string), int id = default(int), int agencyId = default(int), string agencyName = default(string), string agencyProfilePageUrl = default(string), string propertyDetailsUrl = default(string))
        {
            this.UnitNumber = unitNumber;
            this.StreetNumber = streetNumber;
            this.StreetName = streetName;
            this.StreetType = streetType;
            this.Suburb = suburb;
            this.Postcode = postcode;
            this.State = state;
            this.GeoLocation = geoLocation;
            this.PropertyType = propertyType;
            this.Bedrooms = bedrooms;
            this.Bathrooms = bathrooms;
            this.Carspaces = carspaces;
            this.Price = price;
            this.Result = result;
            this.Agent = agent;
            this.Id = id;
            this.AgencyId = agencyId;
            this.AgencyName = agencyName;
            this.AgencyProfilePageUrl = agencyProfilePageUrl;
            this.PropertyDetailsUrl = propertyDetailsUrl;
        }

        /// <summary>
        /// Gets or Sets UnitNumber
        /// </summary>
        /// <value>Gets or Sets UnitNumber</value>
        [DataMember(Name = "unitNumber", EmitDefaultValue = false)]
        public string UnitNumber { get; set; }

        /// <summary>
        /// Gets or Sets StreetNumber
        /// </summary>
        /// <value>Gets or Sets StreetNumber</value>
        [DataMember(Name = "streetNumber", EmitDefaultValue = false)]
        public string StreetNumber { get; set; }

        /// <summary>
        /// Gets or Sets StreetName
        /// </summary>
        /// <value>Gets or Sets StreetName</value>
        [DataMember(Name = "streetName", EmitDefaultValue = false)]
        public string StreetName { get; set; }

        /// <summary>
        /// Gets or Sets StreetType
        /// </summary>
        /// <value>Gets or Sets StreetType</value>
        [DataMember(Name = "streetType", EmitDefaultValue = false)]
        public string StreetType { get; set; }

        /// <summary>
        /// Gets or Sets Suburb
        /// </summary>
        /// <value>Gets or Sets Suburb</value>
        [DataMember(Name = "suburb", EmitDefaultValue = false)]
        public string Suburb { get; set; }

        /// <summary>
        /// Gets or Sets Postcode
        /// </summary>
        /// <value>Gets or Sets Postcode</value>
        [DataMember(Name = "postcode", EmitDefaultValue = false)]
        public string Postcode { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        /// <value>Gets or Sets State</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets GeoLocation
        /// </summary>
        [DataMember(Name = "geoLocation", EmitDefaultValue = false)]
        public DomainPublicAdapterWebApiModelsV1SalesResultsGeoLocation GeoLocation { get; set; }

        /// <summary>
        /// Gets or Sets PropertyType
        /// </summary>
        /// <value>Gets or Sets PropertyType</value>
        [DataMember(Name = "propertyType", EmitDefaultValue = false)]
        public string PropertyType { get; set; }

        /// <summary>
        /// Gets or Sets Bedrooms
        /// </summary>
        /// <value>Gets or Sets Bedrooms</value>
        [DataMember(Name = "bedrooms", EmitDefaultValue = false)]
        public int Bedrooms { get; set; }

        /// <summary>
        /// Gets or Sets Bathrooms
        /// </summary>
        /// <value>Gets or Sets Bathrooms</value>
        [DataMember(Name = "bathrooms", EmitDefaultValue = false)]
        public int Bathrooms { get; set; }

        /// <summary>
        /// Gets or Sets Carspaces
        /// </summary>
        /// <value>Gets or Sets Carspaces</value>
        [DataMember(Name = "carspaces", EmitDefaultValue = false)]
        public int Carspaces { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        /// <value>Gets or Sets Price</value>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public int Price { get; set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        /// <value>Gets or Sets Result</value>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        public string Result { get; set; }

        /// <summary>
        /// Gets or Sets Agent
        /// </summary>
        /// <value>Gets or Sets Agent</value>
        [DataMember(Name = "agent", EmitDefaultValue = false)]
        public string Agent { get; set; }

        /// <summary>
        /// Gets or Sets the listing id
        /// </summary>
        /// <value>Gets or Sets the listing id</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets DomainAgencyId
        /// </summary>
        /// <value>Gets or Sets DomainAgencyId</value>
        [DataMember(Name = "agencyId", EmitDefaultValue = false)]
        public int AgencyId { get; set; }

        /// <summary>
        /// Gets or Sets AgencyName
        /// </summary>
        /// <value>Gets or Sets AgencyName</value>
        [DataMember(Name = "agencyName", EmitDefaultValue = false)]
        public string AgencyName { get; set; }

        /// <summary>
        /// Gets or Sets AgencyProfilePageUrl
        /// </summary>
        /// <value>Gets or Sets AgencyProfilePageUrl</value>
        [DataMember(Name = "agencyProfilePageUrl", EmitDefaultValue = false)]
        public string AgencyProfilePageUrl { get; set; }

        /// <summary>
        /// Gets or Sets DomainPropertyDetailsUrl
        /// </summary>
        /// <value>Gets or Sets DomainPropertyDetailsUrl</value>
        [DataMember(Name = "propertyDetailsUrl", EmitDefaultValue = false)]
        public string PropertyDetailsUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainPublicAdapterWebApiModelsV1SalesResultsListingSummary {\n");
            sb.Append("  UnitNumber: ").Append(UnitNumber).Append("\n");
            sb.Append("  StreetNumber: ").Append(StreetNumber).Append("\n");
            sb.Append("  StreetName: ").Append(StreetName).Append("\n");
            sb.Append("  StreetType: ").Append(StreetType).Append("\n");
            sb.Append("  Suburb: ").Append(Suburb).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  GeoLocation: ").Append(GeoLocation).Append("\n");
            sb.Append("  PropertyType: ").Append(PropertyType).Append("\n");
            sb.Append("  Bedrooms: ").Append(Bedrooms).Append("\n");
            sb.Append("  Bathrooms: ").Append(Bathrooms).Append("\n");
            sb.Append("  Carspaces: ").Append(Carspaces).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Agent: ").Append(Agent).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AgencyId: ").Append(AgencyId).Append("\n");
            sb.Append("  AgencyName: ").Append(AgencyName).Append("\n");
            sb.Append("  AgencyProfilePageUrl: ").Append(AgencyProfilePageUrl).Append("\n");
            sb.Append("  PropertyDetailsUrl: ").Append(PropertyDetailsUrl).Append("\n");
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
            return this.Equals(input as DomainPublicAdapterWebApiModelsV1SalesResultsListingSummary);
        }

        /// <summary>
        /// Returns true if DomainPublicAdapterWebApiModelsV1SalesResultsListingSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainPublicAdapterWebApiModelsV1SalesResultsListingSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainPublicAdapterWebApiModelsV1SalesResultsListingSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UnitNumber == input.UnitNumber ||
                    (this.UnitNumber != null &&
                    this.UnitNumber.Equals(input.UnitNumber))
                ) && 
                (
                    this.StreetNumber == input.StreetNumber ||
                    (this.StreetNumber != null &&
                    this.StreetNumber.Equals(input.StreetNumber))
                ) && 
                (
                    this.StreetName == input.StreetName ||
                    (this.StreetName != null &&
                    this.StreetName.Equals(input.StreetName))
                ) && 
                (
                    this.StreetType == input.StreetType ||
                    (this.StreetType != null &&
                    this.StreetType.Equals(input.StreetType))
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
                    this.GeoLocation == input.GeoLocation ||
                    (this.GeoLocation != null &&
                    this.GeoLocation.Equals(input.GeoLocation))
                ) && 
                (
                    this.PropertyType == input.PropertyType ||
                    (this.PropertyType != null &&
                    this.PropertyType.Equals(input.PropertyType))
                ) && 
                (
                    this.Bedrooms == input.Bedrooms ||
                    this.Bedrooms.Equals(input.Bedrooms)
                ) && 
                (
                    this.Bathrooms == input.Bathrooms ||
                    this.Bathrooms.Equals(input.Bathrooms)
                ) && 
                (
                    this.Carspaces == input.Carspaces ||
                    this.Carspaces.Equals(input.Carspaces)
                ) && 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.Agent == input.Agent ||
                    (this.Agent != null &&
                    this.Agent.Equals(input.Agent))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.AgencyId == input.AgencyId ||
                    this.AgencyId.Equals(input.AgencyId)
                ) && 
                (
                    this.AgencyName == input.AgencyName ||
                    (this.AgencyName != null &&
                    this.AgencyName.Equals(input.AgencyName))
                ) && 
                (
                    this.AgencyProfilePageUrl == input.AgencyProfilePageUrl ||
                    (this.AgencyProfilePageUrl != null &&
                    this.AgencyProfilePageUrl.Equals(input.AgencyProfilePageUrl))
                ) && 
                (
                    this.PropertyDetailsUrl == input.PropertyDetailsUrl ||
                    (this.PropertyDetailsUrl != null &&
                    this.PropertyDetailsUrl.Equals(input.PropertyDetailsUrl))
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
                if (this.UnitNumber != null)
                    hashCode = hashCode * 59 + this.UnitNumber.GetHashCode();
                if (this.StreetNumber != null)
                    hashCode = hashCode * 59 + this.StreetNumber.GetHashCode();
                if (this.StreetName != null)
                    hashCode = hashCode * 59 + this.StreetName.GetHashCode();
                if (this.StreetType != null)
                    hashCode = hashCode * 59 + this.StreetType.GetHashCode();
                if (this.Suburb != null)
                    hashCode = hashCode * 59 + this.Suburb.GetHashCode();
                if (this.Postcode != null)
                    hashCode = hashCode * 59 + this.Postcode.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.GeoLocation != null)
                    hashCode = hashCode * 59 + this.GeoLocation.GetHashCode();
                if (this.PropertyType != null)
                    hashCode = hashCode * 59 + this.PropertyType.GetHashCode();
                hashCode = hashCode * 59 + this.Bedrooms.GetHashCode();
                hashCode = hashCode * 59 + this.Bathrooms.GetHashCode();
                hashCode = hashCode * 59 + this.Carspaces.GetHashCode();
                hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.Agent != null)
                    hashCode = hashCode * 59 + this.Agent.GetHashCode();
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.AgencyId.GetHashCode();
                if (this.AgencyName != null)
                    hashCode = hashCode * 59 + this.AgencyName.GetHashCode();
                if (this.AgencyProfilePageUrl != null)
                    hashCode = hashCode * 59 + this.AgencyProfilePageUrl.GetHashCode();
                if (this.PropertyDetailsUrl != null)
                    hashCode = hashCode * 59 + this.PropertyDetailsUrl.GetHashCode();
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
