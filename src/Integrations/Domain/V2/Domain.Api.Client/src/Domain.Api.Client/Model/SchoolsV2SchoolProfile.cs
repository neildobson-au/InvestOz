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
    /// SchoolsV2SchoolProfile
    /// </summary>
    [DataContract(Name = "Schools.V2.SchoolProfile")]
    public partial class SchoolsV2SchoolProfile : IEquatable<SchoolsV2SchoolProfile>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchoolsV2SchoolProfile" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SchoolsV2SchoolProfile()
        {
        }

        /// <summary>
        /// Website for the school
        /// </summary>
        /// <value>Website for the school</value>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; private set; }

        /// <summary>
        /// Returns false as Url should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUrl()
        {
            return false;
        }

        /// <summary>
        /// The range of year levels offered by the school.
        /// </summary>
        /// <value>The range of year levels offered by the school.</value>
        [DataMember(Name = "yearRange", EmitDefaultValue = true)]
        public string YearRange { get; private set; }

        /// <summary>
        /// Returns false as YearRange should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeYearRange()
        {
            return false;
        }

        /// <summary>
        /// The Index of Community Socio-Educational Advantage score for the school. This score is derived from a number of variables including parental school and non-school education and occupation, the school’s geographical location and proportion of Indigenous students.
        /// </summary>
        /// <value>The Index of Community Socio-Educational Advantage score for the school. This score is derived from a number of variables including parental school and non-school education and occupation, the school’s geographical location and proportion of Indigenous students.</value>
        [DataMember(Name = "icsea", EmitDefaultValue = true)]
        public int? Icsea { get; private set; }

        /// <summary>
        /// Returns false as Icsea should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIcsea()
        {
            return false;
        }

        /// <summary>
        /// The percentage of students positioned in the lowest socio-educational advantage quarter.
        /// </summary>
        /// <value>The percentage of students positioned in the lowest socio-educational advantage quarter.</value>
        [DataMember(Name = "bottomSeaQuarter", EmitDefaultValue = true)]
        public int? BottomSeaQuarter { get; private set; }

        /// <summary>
        /// Returns false as BottomSeaQuarter should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBottomSeaQuarter()
        {
            return false;
        }

        /// <summary>
        /// The percentage of students positioned in the lower middle socio-educational advantage quarter.
        /// </summary>
        /// <value>The percentage of students positioned in the lower middle socio-educational advantage quarter.</value>
        [DataMember(Name = "lowerMiddleSeaQuarter", EmitDefaultValue = true)]
        public int? LowerMiddleSeaQuarter { get; private set; }

        /// <summary>
        /// Returns false as LowerMiddleSeaQuarter should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLowerMiddleSeaQuarter()
        {
            return false;
        }

        /// <summary>
        /// The percentage of students positioned in the higher middle socio-educational advantage quarter.
        /// </summary>
        /// <value>The percentage of students positioned in the higher middle socio-educational advantage quarter.</value>
        [DataMember(Name = "upperMiddleSeaQuarter", EmitDefaultValue = true)]
        public int? UpperMiddleSeaQuarter { get; private set; }

        /// <summary>
        /// Returns false as UpperMiddleSeaQuarter should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpperMiddleSeaQuarter()
        {
            return false;
        }

        /// <summary>
        /// The percentage of students positioned in the highest socio-educational advantage quarter.
        /// </summary>
        /// <value>The percentage of students positioned in the highest socio-educational advantage quarter.</value>
        [DataMember(Name = "topSeaQuarter", EmitDefaultValue = true)]
        public int? TopSeaQuarter { get; private set; }

        /// <summary>
        /// Returns false as TopSeaQuarter should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTopSeaQuarter()
        {
            return false;
        }

        /// <summary>
        /// The total number of students, including both full-time and part-time students, who are enrolled at the school in the calendar year specified.
        /// </summary>
        /// <value>The total number of students, including both full-time and part-time students, who are enrolled at the school in the calendar year specified.</value>
        [DataMember(Name = "totalEnrolments", EmitDefaultValue = true)]
        public int? TotalEnrolments { get; private set; }

        /// <summary>
        /// Returns false as TotalEnrolments should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTotalEnrolments()
        {
            return false;
        }

        /// <summary>
        /// The total number of female students, including both full-time and part-time students, who are enrolled at the school in the calendar year specified.
        /// </summary>
        /// <value>The total number of female students, including both full-time and part-time students, who are enrolled at the school in the calendar year specified.</value>
        [DataMember(Name = "girlsEnrolments", EmitDefaultValue = true)]
        public int? GirlsEnrolments { get; private set; }

        /// <summary>
        /// Returns false as GirlsEnrolments should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeGirlsEnrolments()
        {
            return false;
        }

        /// <summary>
        /// The total number of male students, including full-time and part-time students, who are enrolled at the school in the calendar year specified.
        /// </summary>
        /// <value>The total number of male students, including full-time and part-time students, who are enrolled at the school in the calendar year specified.</value>
        [DataMember(Name = "boysEnrolments", EmitDefaultValue = true)]
        public int? BoysEnrolments { get; private set; }

        /// <summary>
        /// Returns false as BoysEnrolments should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBoysEnrolments()
        {
            return false;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchoolsV2SchoolProfile {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  YearRange: ").Append(YearRange).Append("\n");
            sb.Append("  Icsea: ").Append(Icsea).Append("\n");
            sb.Append("  BottomSeaQuarter: ").Append(BottomSeaQuarter).Append("\n");
            sb.Append("  LowerMiddleSeaQuarter: ").Append(LowerMiddleSeaQuarter).Append("\n");
            sb.Append("  UpperMiddleSeaQuarter: ").Append(UpperMiddleSeaQuarter).Append("\n");
            sb.Append("  TopSeaQuarter: ").Append(TopSeaQuarter).Append("\n");
            sb.Append("  TotalEnrolments: ").Append(TotalEnrolments).Append("\n");
            sb.Append("  GirlsEnrolments: ").Append(GirlsEnrolments).Append("\n");
            sb.Append("  BoysEnrolments: ").Append(BoysEnrolments).Append("\n");
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
            return this.Equals(input as SchoolsV2SchoolProfile);
        }

        /// <summary>
        /// Returns true if SchoolsV2SchoolProfile instances are equal
        /// </summary>
        /// <param name="input">Instance of SchoolsV2SchoolProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchoolsV2SchoolProfile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.YearRange == input.YearRange ||
                    (this.YearRange != null &&
                    this.YearRange.Equals(input.YearRange))
                ) && 
                (
                    this.Icsea == input.Icsea ||
                    (this.Icsea != null &&
                    this.Icsea.Equals(input.Icsea))
                ) && 
                (
                    this.BottomSeaQuarter == input.BottomSeaQuarter ||
                    (this.BottomSeaQuarter != null &&
                    this.BottomSeaQuarter.Equals(input.BottomSeaQuarter))
                ) && 
                (
                    this.LowerMiddleSeaQuarter == input.LowerMiddleSeaQuarter ||
                    (this.LowerMiddleSeaQuarter != null &&
                    this.LowerMiddleSeaQuarter.Equals(input.LowerMiddleSeaQuarter))
                ) && 
                (
                    this.UpperMiddleSeaQuarter == input.UpperMiddleSeaQuarter ||
                    (this.UpperMiddleSeaQuarter != null &&
                    this.UpperMiddleSeaQuarter.Equals(input.UpperMiddleSeaQuarter))
                ) && 
                (
                    this.TopSeaQuarter == input.TopSeaQuarter ||
                    (this.TopSeaQuarter != null &&
                    this.TopSeaQuarter.Equals(input.TopSeaQuarter))
                ) && 
                (
                    this.TotalEnrolments == input.TotalEnrolments ||
                    (this.TotalEnrolments != null &&
                    this.TotalEnrolments.Equals(input.TotalEnrolments))
                ) && 
                (
                    this.GirlsEnrolments == input.GirlsEnrolments ||
                    (this.GirlsEnrolments != null &&
                    this.GirlsEnrolments.Equals(input.GirlsEnrolments))
                ) && 
                (
                    this.BoysEnrolments == input.BoysEnrolments ||
                    (this.BoysEnrolments != null &&
                    this.BoysEnrolments.Equals(input.BoysEnrolments))
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.YearRange != null)
                    hashCode = hashCode * 59 + this.YearRange.GetHashCode();
                if (this.Icsea != null)
                    hashCode = hashCode * 59 + this.Icsea.GetHashCode();
                if (this.BottomSeaQuarter != null)
                    hashCode = hashCode * 59 + this.BottomSeaQuarter.GetHashCode();
                if (this.LowerMiddleSeaQuarter != null)
                    hashCode = hashCode * 59 + this.LowerMiddleSeaQuarter.GetHashCode();
                if (this.UpperMiddleSeaQuarter != null)
                    hashCode = hashCode * 59 + this.UpperMiddleSeaQuarter.GetHashCode();
                if (this.TopSeaQuarter != null)
                    hashCode = hashCode * 59 + this.TopSeaQuarter.GetHashCode();
                if (this.TotalEnrolments != null)
                    hashCode = hashCode * 59 + this.TotalEnrolments.GetHashCode();
                if (this.GirlsEnrolments != null)
                    hashCode = hashCode * 59 + this.GirlsEnrolments.GetHashCode();
                if (this.BoysEnrolments != null)
                    hashCode = hashCode * 59 + this.BoysEnrolments.GetHashCode();
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
