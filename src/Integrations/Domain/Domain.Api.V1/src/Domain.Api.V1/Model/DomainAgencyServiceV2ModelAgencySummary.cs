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
using OpenAPIDateConverter = Domain.Api.V1.Client.OpenAPIDateConverter;

namespace Domain.Api.V1.Model
{
    /// <summary>
    /// DomainAgencyServiceV2ModelAgencySummary
    /// </summary>
    [DataContract(Name = "Domain.AgencyService.v2.Model.AgencySummary")]
    public partial class DomainAgencyServiceV2ModelAgencySummary : IEquatable<DomainAgencyServiceV2ModelAgencySummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainAgencyServiceV2ModelAgencySummary" /> class.
        /// </summary>
        /// <param name="inSuburb">inSuburb.</param>
        /// <param name="querySuburb">querySuburb.</param>
        /// <param name="hasRecentlySold">hasRecentlySold.</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="suburb">suburb.</param>
        /// <param name="logoUrl">logoUrl.</param>
        /// <param name="baseUrl">baseUrl.</param>
        /// <param name="address1">address1.</param>
        /// <param name="address2">address2.</param>
        /// <param name="telephone">telephone.</param>
        /// <param name="rentalTelephone">rentalTelephone.</param>
        /// <param name="mobile">mobile.</param>
        /// <param name="fax">fax.</param>
        /// <param name="state">state.</param>
        /// <param name="description">description.</param>
        /// <param name="email">email.</param>
        /// <param name="rentalEmail">rentalEmail.</param>
        /// <param name="homePageSearchOptions">homePageSearchOptions.</param>
        /// <param name="accountType">accountType.</param>
        /// <param name="numberForSale">numberForSale.</param>
        /// <param name="numberForRent">numberForRent.</param>
        /// <param name="domainUrl">domainUrl.</param>
        /// <param name="showTabSoldLastYear">showTabSoldLastYear.</param>
        public DomainAgencyServiceV2ModelAgencySummary(bool inSuburb = default(bool), string querySuburb = default(string), bool hasRecentlySold = default(bool), int id = default(int), string name = default(string), string suburb = default(string), string logoUrl = default(string), string baseUrl = default(string), string address1 = default(string), string address2 = default(string), string telephone = default(string), string rentalTelephone = default(string), string mobile = default(string), string fax = default(string), string state = default(string), string description = default(string), string email = default(string), string rentalEmail = default(string), string homePageSearchOptions = default(string), int accountType = default(int), int numberForSale = default(int), int numberForRent = default(int), string domainUrl = default(string), bool showTabSoldLastYear = default(bool))
        {
            this.InSuburb = inSuburb;
            this.QuerySuburb = querySuburb;
            this.HasRecentlySold = hasRecentlySold;
            this.Id = id;
            this.Name = name;
            this.Suburb = suburb;
            this.LogoUrl = logoUrl;
            this.BaseUrl = baseUrl;
            this.Address1 = address1;
            this.Address2 = address2;
            this.Telephone = telephone;
            this.RentalTelephone = rentalTelephone;
            this.Mobile = mobile;
            this.Fax = fax;
            this.State = state;
            this.Description = description;
            this.Email = email;
            this.RentalEmail = rentalEmail;
            this.HomePageSearchOptions = homePageSearchOptions;
            this.AccountType = accountType;
            this.NumberForSale = numberForSale;
            this.NumberForRent = numberForRent;
            this.DomainUrl = domainUrl;
            this.ShowTabSoldLastYear = showTabSoldLastYear;
        }

        /// <summary>
        /// Gets or Sets InSuburb
        /// </summary>
        [DataMember(Name = "inSuburb", EmitDefaultValue = false)]
        public bool InSuburb { get; set; }

        /// <summary>
        /// Gets or Sets QuerySuburb
        /// </summary>
        [DataMember(Name = "querySuburb", EmitDefaultValue = false)]
        public string QuerySuburb { get; set; }

        /// <summary>
        /// Gets or Sets HasRecentlySold
        /// </summary>
        [DataMember(Name = "hasRecentlySold", EmitDefaultValue = false)]
        public bool HasRecentlySold { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Suburb
        /// </summary>
        [DataMember(Name = "suburb", EmitDefaultValue = false)]
        public string Suburb { get; set; }

        /// <summary>
        /// Gets or Sets LogoUrl
        /// </summary>
        [DataMember(Name = "logoUrl", EmitDefaultValue = false)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// Gets or Sets BaseUrl
        /// </summary>
        [DataMember(Name = "baseUrl", EmitDefaultValue = false)]
        public string BaseUrl { get; set; }

        /// <summary>
        /// Gets or Sets Address1
        /// </summary>
        [DataMember(Name = "address1", EmitDefaultValue = false)]
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or Sets Address2
        /// </summary>
        [DataMember(Name = "address2", EmitDefaultValue = false)]
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or Sets Telephone
        /// </summary>
        [DataMember(Name = "telephone", EmitDefaultValue = false)]
        public string Telephone { get; set; }

        /// <summary>
        /// Gets or Sets RentalTelephone
        /// </summary>
        [DataMember(Name = "rentalTelephone", EmitDefaultValue = false)]
        public string RentalTelephone { get; set; }

        /// <summary>
        /// Gets or Sets Mobile
        /// </summary>
        [DataMember(Name = "mobile", EmitDefaultValue = false)]
        public string Mobile { get; set; }

        /// <summary>
        /// Gets or Sets Fax
        /// </summary>
        [DataMember(Name = "fax", EmitDefaultValue = false)]
        public string Fax { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets RentalEmail
        /// </summary>
        [DataMember(Name = "rentalEmail", EmitDefaultValue = false)]
        public string RentalEmail { get; set; }

        /// <summary>
        /// Gets or Sets HomePageSearchOptions
        /// </summary>
        [DataMember(Name = "homePageSearchOptions", EmitDefaultValue = false)]
        public string HomePageSearchOptions { get; set; }

        /// <summary>
        /// Gets or Sets AccountType
        /// </summary>
        [DataMember(Name = "accountType", EmitDefaultValue = false)]
        public int AccountType { get; set; }

        /// <summary>
        /// Gets or Sets NumberForSale
        /// </summary>
        [DataMember(Name = "numberForSale", EmitDefaultValue = false)]
        public int NumberForSale { get; set; }

        /// <summary>
        /// Gets or Sets NumberForRent
        /// </summary>
        [DataMember(Name = "numberForRent", EmitDefaultValue = false)]
        public int NumberForRent { get; set; }

        /// <summary>
        /// Gets or Sets DomainUrl
        /// </summary>
        [DataMember(Name = "domainUrl", EmitDefaultValue = false)]
        public string DomainUrl { get; set; }

        /// <summary>
        /// Gets or Sets ShowTabSoldLastYear
        /// </summary>
        [DataMember(Name = "showTabSoldLastYear", EmitDefaultValue = false)]
        public bool ShowTabSoldLastYear { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainAgencyServiceV2ModelAgencySummary {\n");
            sb.Append("  InSuburb: ").Append(InSuburb).Append("\n");
            sb.Append("  QuerySuburb: ").Append(QuerySuburb).Append("\n");
            sb.Append("  HasRecentlySold: ").Append(HasRecentlySold).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Suburb: ").Append(Suburb).Append("\n");
            sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
            sb.Append("  BaseUrl: ").Append(BaseUrl).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  Telephone: ").Append(Telephone).Append("\n");
            sb.Append("  RentalTelephone: ").Append(RentalTelephone).Append("\n");
            sb.Append("  Mobile: ").Append(Mobile).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  RentalEmail: ").Append(RentalEmail).Append("\n");
            sb.Append("  HomePageSearchOptions: ").Append(HomePageSearchOptions).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  NumberForSale: ").Append(NumberForSale).Append("\n");
            sb.Append("  NumberForRent: ").Append(NumberForRent).Append("\n");
            sb.Append("  DomainUrl: ").Append(DomainUrl).Append("\n");
            sb.Append("  ShowTabSoldLastYear: ").Append(ShowTabSoldLastYear).Append("\n");
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
            return this.Equals(input as DomainAgencyServiceV2ModelAgencySummary);
        }

        /// <summary>
        /// Returns true if DomainAgencyServiceV2ModelAgencySummary instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainAgencyServiceV2ModelAgencySummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainAgencyServiceV2ModelAgencySummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InSuburb == input.InSuburb ||
                    this.InSuburb.Equals(input.InSuburb)
                ) && 
                (
                    this.QuerySuburb == input.QuerySuburb ||
                    (this.QuerySuburb != null &&
                    this.QuerySuburb.Equals(input.QuerySuburb))
                ) && 
                (
                    this.HasRecentlySold == input.HasRecentlySold ||
                    this.HasRecentlySold.Equals(input.HasRecentlySold)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Suburb == input.Suburb ||
                    (this.Suburb != null &&
                    this.Suburb.Equals(input.Suburb))
                ) && 
                (
                    this.LogoUrl == input.LogoUrl ||
                    (this.LogoUrl != null &&
                    this.LogoUrl.Equals(input.LogoUrl))
                ) && 
                (
                    this.BaseUrl == input.BaseUrl ||
                    (this.BaseUrl != null &&
                    this.BaseUrl.Equals(input.BaseUrl))
                ) && 
                (
                    this.Address1 == input.Address1 ||
                    (this.Address1 != null &&
                    this.Address1.Equals(input.Address1))
                ) && 
                (
                    this.Address2 == input.Address2 ||
                    (this.Address2 != null &&
                    this.Address2.Equals(input.Address2))
                ) && 
                (
                    this.Telephone == input.Telephone ||
                    (this.Telephone != null &&
                    this.Telephone.Equals(input.Telephone))
                ) && 
                (
                    this.RentalTelephone == input.RentalTelephone ||
                    (this.RentalTelephone != null &&
                    this.RentalTelephone.Equals(input.RentalTelephone))
                ) && 
                (
                    this.Mobile == input.Mobile ||
                    (this.Mobile != null &&
                    this.Mobile.Equals(input.Mobile))
                ) && 
                (
                    this.Fax == input.Fax ||
                    (this.Fax != null &&
                    this.Fax.Equals(input.Fax))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.RentalEmail == input.RentalEmail ||
                    (this.RentalEmail != null &&
                    this.RentalEmail.Equals(input.RentalEmail))
                ) && 
                (
                    this.HomePageSearchOptions == input.HomePageSearchOptions ||
                    (this.HomePageSearchOptions != null &&
                    this.HomePageSearchOptions.Equals(input.HomePageSearchOptions))
                ) && 
                (
                    this.AccountType == input.AccountType ||
                    this.AccountType.Equals(input.AccountType)
                ) && 
                (
                    this.NumberForSale == input.NumberForSale ||
                    this.NumberForSale.Equals(input.NumberForSale)
                ) && 
                (
                    this.NumberForRent == input.NumberForRent ||
                    this.NumberForRent.Equals(input.NumberForRent)
                ) && 
                (
                    this.DomainUrl == input.DomainUrl ||
                    (this.DomainUrl != null &&
                    this.DomainUrl.Equals(input.DomainUrl))
                ) && 
                (
                    this.ShowTabSoldLastYear == input.ShowTabSoldLastYear ||
                    this.ShowTabSoldLastYear.Equals(input.ShowTabSoldLastYear)
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
                hashCode = hashCode * 59 + this.InSuburb.GetHashCode();
                if (this.QuerySuburb != null)
                    hashCode = hashCode * 59 + this.QuerySuburb.GetHashCode();
                hashCode = hashCode * 59 + this.HasRecentlySold.GetHashCode();
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Suburb != null)
                    hashCode = hashCode * 59 + this.Suburb.GetHashCode();
                if (this.LogoUrl != null)
                    hashCode = hashCode * 59 + this.LogoUrl.GetHashCode();
                if (this.BaseUrl != null)
                    hashCode = hashCode * 59 + this.BaseUrl.GetHashCode();
                if (this.Address1 != null)
                    hashCode = hashCode * 59 + this.Address1.GetHashCode();
                if (this.Address2 != null)
                    hashCode = hashCode * 59 + this.Address2.GetHashCode();
                if (this.Telephone != null)
                    hashCode = hashCode * 59 + this.Telephone.GetHashCode();
                if (this.RentalTelephone != null)
                    hashCode = hashCode * 59 + this.RentalTelephone.GetHashCode();
                if (this.Mobile != null)
                    hashCode = hashCode * 59 + this.Mobile.GetHashCode();
                if (this.Fax != null)
                    hashCode = hashCode * 59 + this.Fax.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.RentalEmail != null)
                    hashCode = hashCode * 59 + this.RentalEmail.GetHashCode();
                if (this.HomePageSearchOptions != null)
                    hashCode = hashCode * 59 + this.HomePageSearchOptions.GetHashCode();
                hashCode = hashCode * 59 + this.AccountType.GetHashCode();
                hashCode = hashCode * 59 + this.NumberForSale.GetHashCode();
                hashCode = hashCode * 59 + this.NumberForRent.GetHashCode();
                if (this.DomainUrl != null)
                    hashCode = hashCode * 59 + this.DomainUrl.GetHashCode();
                hashCode = hashCode * 59 + this.ShowTabSoldLastYear.GetHashCode();
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