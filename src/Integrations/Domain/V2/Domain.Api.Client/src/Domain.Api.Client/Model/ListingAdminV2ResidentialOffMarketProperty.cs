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
    /// Residential off market property
    /// </summary>
    [DataContract(Name = "ListingAdmin.v2.ResidentialOffMarketProperty")]
    public partial class ListingAdminV2ResidentialOffMarketProperty : IEquatable<ListingAdminV2ResidentialOffMarketProperty>, IValidatableObject
    {
        /// <summary>
        /// Defines PropertyType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PropertyTypeEnum
        {
            /// <summary>
            /// Enum AcreageSemiRural for value: acreageSemiRural
            /// </summary>
            [EnumMember(Value = "acreageSemiRural")]
            AcreageSemiRural = 1,

            /// <summary>
            /// Enum ApartmentUnitFlat for value: apartmentUnitFlat
            /// </summary>
            [EnumMember(Value = "apartmentUnitFlat")]
            ApartmentUnitFlat = 2,

            /// <summary>
            /// Enum Aquaculture for value: aquaculture
            /// </summary>
            [EnumMember(Value = "aquaculture")]
            Aquaculture = 3,

            /// <summary>
            /// Enum BlockOfUnits for value: blockOfUnits
            /// </summary>
            [EnumMember(Value = "blockOfUnits")]
            BlockOfUnits = 4,

            /// <summary>
            /// Enum CarSpace for value: carSpace
            /// </summary>
            [EnumMember(Value = "carSpace")]
            CarSpace = 5,

            /// <summary>
            /// Enum DairyFarming for value: dairyFarming
            /// </summary>
            [EnumMember(Value = "dairyFarming")]
            DairyFarming = 6,

            /// <summary>
            /// Enum DevelopmentSite for value: developmentSite
            /// </summary>
            [EnumMember(Value = "developmentSite")]
            DevelopmentSite = 7,

            /// <summary>
            /// Enum Duplex for value: duplex
            /// </summary>
            [EnumMember(Value = "duplex")]
            Duplex = 8,

            /// <summary>
            /// Enum Farm for value: farm
            /// </summary>
            [EnumMember(Value = "farm")]
            Farm = 9,

            /// <summary>
            /// Enum FishingForestry for value: fishingForestry
            /// </summary>
            [EnumMember(Value = "fishingForestry")]
            FishingForestry = 10,

            /// <summary>
            /// Enum NewHomeDesigns for value: newHomeDesigns
            /// </summary>
            [EnumMember(Value = "newHomeDesigns")]
            NewHomeDesigns = 11,

            /// <summary>
            /// Enum House for value: house
            /// </summary>
            [EnumMember(Value = "house")]
            House = 12,

            /// <summary>
            /// Enum NewHouseLand for value: newHouseLand
            /// </summary>
            [EnumMember(Value = "newHouseLand")]
            NewHouseLand = 13,

            /// <summary>
            /// Enum IrrigationServices for value: irrigationServices
            /// </summary>
            [EnumMember(Value = "irrigationServices")]
            IrrigationServices = 14,

            /// <summary>
            /// Enum NewLand for value: newLand
            /// </summary>
            [EnumMember(Value = "newLand")]
            NewLand = 15,

            /// <summary>
            /// Enum Livestock for value: livestock
            /// </summary>
            [EnumMember(Value = "livestock")]
            Livestock = 16,

            /// <summary>
            /// Enum NewApartments for value: newApartments
            /// </summary>
            [EnumMember(Value = "newApartments")]
            NewApartments = 17,

            /// <summary>
            /// Enum Penthouse for value: penthouse
            /// </summary>
            [EnumMember(Value = "penthouse")]
            Penthouse = 18,

            /// <summary>
            /// Enum Retirement for value: retirement
            /// </summary>
            [EnumMember(Value = "retirement")]
            Retirement = 19,

            /// <summary>
            /// Enum Rural for value: rural
            /// </summary>
            [EnumMember(Value = "rural")]
            Rural = 20,

            /// <summary>
            /// Enum SemiDetached for value: semiDetached
            /// </summary>
            [EnumMember(Value = "semiDetached")]
            SemiDetached = 21,

            /// <summary>
            /// Enum SpecialistFarm for value: specialistFarm
            /// </summary>
            [EnumMember(Value = "specialistFarm")]
            SpecialistFarm = 22,

            /// <summary>
            /// Enum Studio for value: studio
            /// </summary>
            [EnumMember(Value = "studio")]
            Studio = 23,

            /// <summary>
            /// Enum Terrace for value: terrace
            /// </summary>
            [EnumMember(Value = "terrace")]
            Terrace = 24,

            /// <summary>
            /// Enum Townhouse for value: townhouse
            /// </summary>
            [EnumMember(Value = "townhouse")]
            Townhouse = 25,

            /// <summary>
            /// Enum VacantLand for value: vacantLand
            /// </summary>
            [EnumMember(Value = "vacantLand")]
            VacantLand = 26,

            /// <summary>
            /// Enum Villa for value: villa
            /// </summary>
            [EnumMember(Value = "villa")]
            Villa = 27,

            /// <summary>
            /// Enum Cropping for value: cropping
            /// </summary>
            [EnumMember(Value = "cropping")]
            Cropping = 28,

            /// <summary>
            /// Enum Viticulture for value: viticulture
            /// </summary>
            [EnumMember(Value = "viticulture")]
            Viticulture = 29,

            /// <summary>
            /// Enum MixedFarming for value: mixedFarming
            /// </summary>
            [EnumMember(Value = "mixedFarming")]
            MixedFarming = 30,

            /// <summary>
            /// Enum Grazing for value: grazing
            /// </summary>
            [EnumMember(Value = "grazing")]
            Grazing = 31,

            /// <summary>
            /// Enum Horticulture for value: horticulture
            /// </summary>
            [EnumMember(Value = "horticulture")]
            Horticulture = 32,

            /// <summary>
            /// Enum Equine for value: equine
            /// </summary>
            [EnumMember(Value = "equine")]
            Equine = 33,

            /// <summary>
            /// Enum Farmlet for value: farmlet
            /// </summary>
            [EnumMember(Value = "farmlet")]
            Farmlet = 34,

            /// <summary>
            /// Enum Orchard for value: orchard
            /// </summary>
            [EnumMember(Value = "orchard")]
            Orchard = 35,

            /// <summary>
            /// Enum RuralLifestyle for value: ruralLifestyle
            /// </summary>
            [EnumMember(Value = "ruralLifestyle")]
            RuralLifestyle = 36

        }


        /// <summary>
        /// Residential property types&lt;br /&gt;  &#39;Retirement&#39; requires at least one more property type to be specified with it (for example: \&quot;Retirement, ApartmentUnitFlat\&quot;) [&#39;acreageSemiRural&#39;, &#39;apartmentUnitFlat&#39;, &#39;aquaculture&#39;, &#39;blockOfUnits&#39;, &#39;carSpace&#39;, &#39;dairyFarming&#39;, &#39;developmentSite&#39;, &#39;duplex&#39;, &#39;farm&#39;, &#39;fishingForestry&#39;, &#39;newHomeDesigns&#39;, &#39;house&#39;, &#39;newHouseLand&#39;, &#39;irrigationServices&#39;, &#39;newLand&#39;, &#39;livestock&#39;, &#39;newApartments&#39;, &#39;penthouse&#39;, &#39;retirement&#39;, &#39;rural&#39;, &#39;semiDetached&#39;, &#39;specialistFarm&#39;, &#39;studio&#39;, &#39;terrace&#39;, &#39;townhouse&#39;, &#39;vacantLand&#39;, &#39;villa&#39;, &#39;cropping&#39;, &#39;viticulture&#39;, &#39;mixedFarming&#39;, &#39;grazing&#39;, &#39;horticulture&#39;, &#39;equine&#39;, &#39;farmlet&#39;, &#39;orchard&#39;, &#39;ruralLifestyle&#39;].
        /// </summary>
        /// <value>Residential property types&lt;br /&gt;  &#39;Retirement&#39; requires at least one more property type to be specified with it (for example: \&quot;Retirement, ApartmentUnitFlat\&quot;) [&#39;acreageSemiRural&#39;, &#39;apartmentUnitFlat&#39;, &#39;aquaculture&#39;, &#39;blockOfUnits&#39;, &#39;carSpace&#39;, &#39;dairyFarming&#39;, &#39;developmentSite&#39;, &#39;duplex&#39;, &#39;farm&#39;, &#39;fishingForestry&#39;, &#39;newHomeDesigns&#39;, &#39;house&#39;, &#39;newHouseLand&#39;, &#39;irrigationServices&#39;, &#39;newLand&#39;, &#39;livestock&#39;, &#39;newApartments&#39;, &#39;penthouse&#39;, &#39;retirement&#39;, &#39;rural&#39;, &#39;semiDetached&#39;, &#39;specialistFarm&#39;, &#39;studio&#39;, &#39;terrace&#39;, &#39;townhouse&#39;, &#39;vacantLand&#39;, &#39;villa&#39;, &#39;cropping&#39;, &#39;viticulture&#39;, &#39;mixedFarming&#39;, &#39;grazing&#39;, &#39;horticulture&#39;, &#39;equine&#39;, &#39;farmlet&#39;, &#39;orchard&#39;, &#39;ruralLifestyle&#39;].</value>
        [DataMember(Name = "propertyType", IsRequired = true, EmitDefaultValue = false)]
        public List<PropertyTypeEnum> PropertyType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingAdminV2ResidentialOffMarketProperty" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListingAdminV2ResidentialOffMarketProperty() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingAdminV2ResidentialOffMarketProperty" /> class.
        /// </summary>
        /// <param name="propertyType">Residential property types&lt;br /&gt;  &#39;Retirement&#39; requires at least one more property type to be specified with it (for example: \&quot;Retirement, ApartmentUnitFlat\&quot;) [&#39;acreageSemiRural&#39;, &#39;apartmentUnitFlat&#39;, &#39;aquaculture&#39;, &#39;blockOfUnits&#39;, &#39;carSpace&#39;, &#39;dairyFarming&#39;, &#39;developmentSite&#39;, &#39;duplex&#39;, &#39;farm&#39;, &#39;fishingForestry&#39;, &#39;newHomeDesigns&#39;, &#39;house&#39;, &#39;newHouseLand&#39;, &#39;irrigationServices&#39;, &#39;newLand&#39;, &#39;livestock&#39;, &#39;newApartments&#39;, &#39;penthouse&#39;, &#39;retirement&#39;, &#39;rural&#39;, &#39;semiDetached&#39;, &#39;specialistFarm&#39;, &#39;studio&#39;, &#39;terrace&#39;, &#39;townhouse&#39;, &#39;vacantLand&#39;, &#39;villa&#39;, &#39;cropping&#39;, &#39;viticulture&#39;, &#39;mixedFarming&#39;, &#39;grazing&#39;, &#39;horticulture&#39;, &#39;equine&#39;, &#39;farmlet&#39;, &#39;orchard&#39;, &#39;ruralLifestyle&#39;]. (required).</param>
        /// <param name="bedRooms">Number of bedrooms.</param>
        /// <param name="bathRooms">Number of bathrooms.</param>
        /// <param name="parkingInfo">parkingInfo.</param>
        /// <param name="images">List of image files, photos or floor plans related to the listing..</param>
        /// <param name="address">address (required).</param>
        /// <param name="area">area.</param>
        /// <param name="landArea">landArea.</param>
        public ListingAdminV2ResidentialOffMarketProperty(List<PropertyTypeEnum> propertyType = default(List<PropertyTypeEnum>), int bedRooms = default(int), int bathRooms = default(int), ListingAdminV2ParkingInfo parkingInfo = default(ListingAdminV2ParkingInfo), List<ListingAdminV2PropertyMedia> images = default(List<ListingAdminV2PropertyMedia>), ListingAdminV2Address address = default(ListingAdminV2Address), ListingAdminV2Area area = default(ListingAdminV2Area), ListingAdminV2LandArea landArea = default(ListingAdminV2LandArea))
        {
            // to ensure "propertyType" is required (not null)
            this.PropertyType = propertyType ?? throw new ArgumentNullException("propertyType is a required property for ListingAdminV2ResidentialOffMarketProperty and cannot be null");
            // to ensure "address" is required (not null)
            this.Address = address ?? throw new ArgumentNullException("address is a required property for ListingAdminV2ResidentialOffMarketProperty and cannot be null");
            this.BedRooms = bedRooms;
            this.BathRooms = bathRooms;
            this.ParkingInfo = parkingInfo;
            this.Images = images;
            this.Area = area;
            this.LandArea = landArea;
        }

        /// <summary>
        /// Number of bedrooms
        /// </summary>
        /// <value>Number of bedrooms</value>
        [DataMember(Name = "bedRooms", EmitDefaultValue = false)]
        public int BedRooms { get; set; }

        /// <summary>
        /// Number of bathrooms
        /// </summary>
        /// <value>Number of bathrooms</value>
        [DataMember(Name = "bathRooms", EmitDefaultValue = false)]
        public int BathRooms { get; set; }

        /// <summary>
        /// Gets or Sets ParkingInfo
        /// </summary>
        [DataMember(Name = "parkingInfo", EmitDefaultValue = false)]
        public ListingAdminV2ParkingInfo ParkingInfo { get; set; }

        /// <summary>
        /// List of image files, photos or floor plans related to the listing.
        /// </summary>
        /// <value>List of image files, photos or floor plans related to the listing.</value>
        [DataMember(Name = "images", EmitDefaultValue = false)]
        public List<ListingAdminV2PropertyMedia> Images { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = false)]
        public ListingAdminV2Address Address { get; set; }

        /// <summary>
        /// Gets or Sets Area
        /// </summary>
        [DataMember(Name = "area", EmitDefaultValue = false)]
        public ListingAdminV2Area Area { get; set; }

        /// <summary>
        /// Gets or Sets LandArea
        /// </summary>
        [DataMember(Name = "landArea", EmitDefaultValue = false)]
        public ListingAdminV2LandArea LandArea { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListingAdminV2ResidentialOffMarketProperty {\n");
            sb.Append("  PropertyType: ").Append(PropertyType).Append("\n");
            sb.Append("  BedRooms: ").Append(BedRooms).Append("\n");
            sb.Append("  BathRooms: ").Append(BathRooms).Append("\n");
            sb.Append("  ParkingInfo: ").Append(ParkingInfo).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Area: ").Append(Area).Append("\n");
            sb.Append("  LandArea: ").Append(LandArea).Append("\n");
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
            return this.Equals(input as ListingAdminV2ResidentialOffMarketProperty);
        }

        /// <summary>
        /// Returns true if ListingAdminV2ResidentialOffMarketProperty instances are equal
        /// </summary>
        /// <param name="input">Instance of ListingAdminV2ResidentialOffMarketProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListingAdminV2ResidentialOffMarketProperty input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PropertyType == input.PropertyType ||
                    this.PropertyType.SequenceEqual(input.PropertyType)
                ) && 
                (
                    this.BedRooms == input.BedRooms ||
                    this.BedRooms.Equals(input.BedRooms)
                ) && 
                (
                    this.BathRooms == input.BathRooms ||
                    this.BathRooms.Equals(input.BathRooms)
                ) && 
                (
                    this.ParkingInfo == input.ParkingInfo ||
                    (this.ParkingInfo != null &&
                    this.ParkingInfo.Equals(input.ParkingInfo))
                ) && 
                (
                    this.Images == input.Images ||
                    this.Images != null &&
                    input.Images != null &&
                    this.Images.SequenceEqual(input.Images)
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Area == input.Area ||
                    (this.Area != null &&
                    this.Area.Equals(input.Area))
                ) && 
                (
                    this.LandArea == input.LandArea ||
                    (this.LandArea != null &&
                    this.LandArea.Equals(input.LandArea))
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
                hashCode = hashCode * 59 + this.PropertyType.GetHashCode();
                hashCode = hashCode * 59 + this.BedRooms.GetHashCode();
                hashCode = hashCode * 59 + this.BathRooms.GetHashCode();
                if (this.ParkingInfo != null)
                    hashCode = hashCode * 59 + this.ParkingInfo.GetHashCode();
                if (this.Images != null)
                    hashCode = hashCode * 59 + this.Images.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Area != null)
                    hashCode = hashCode * 59 + this.Area.GetHashCode();
                if (this.LandArea != null)
                    hashCode = hashCode * 59 + this.LandArea.GetHashCode();
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
            // BedRooms (int) maximum
            if(this.BedRooms > (int)2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BedRooms, must be a value less than or equal to 2147483647.", new [] { "BedRooms" });
            }

            // BedRooms (int) minimum
            if(this.BedRooms < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BedRooms, must be a value greater than or equal to 0.", new [] { "BedRooms" });
            }

            // BathRooms (int) maximum
            if(this.BathRooms > (int)2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BathRooms, must be a value less than or equal to 2147483647.", new [] { "BathRooms" });
            }

            // BathRooms (int) minimum
            if(this.BathRooms < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BathRooms, must be a value greater than or equal to 0.", new [] { "BathRooms" });
            }

            yield break;
        }
    }

}
