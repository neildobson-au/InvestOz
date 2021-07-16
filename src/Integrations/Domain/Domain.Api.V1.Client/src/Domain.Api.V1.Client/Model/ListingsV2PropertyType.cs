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
    /// Available types of Properties  * &#x60;Unknown&#x60; - Unknown * &#x60;AcreageSemiRural&#x60; - Acreage-SemiRural * &#x60;ApartmentUnitFlat&#x60; - Apartment Unit Flat * &#x60;Aquaculture&#x60; - Aquaculture             commercial/rural type * &#x60;BlockOfUnits&#x60; - Block Of Units * &#x60;Carspace&#x60; - Carspace * &#x60;DairyFarming&#x60; - Dairy Farming             commercial/rural type * &#x60;DevelopmentLand&#x60; - Development / Land * &#x60;DevelopmentSite&#x60; - Development site * &#x60;Duplex&#x60; - Duplex * &#x60;Farm&#x60; - Farm * &#x60;FishingForestry&#x60; - Fishing / Forestry             commercial/rural type * &#x60;HomeBased&#x60; - Home Based * &#x60;NewHomeDesigns&#x60; - New Home Designs * &#x60;HotelLeisure&#x60; - Hotel / Leisure             commercial type * &#x60;House&#x60; - House * &#x60;NewHouseLand&#x60; - New House And Land * &#x60;IndustrialWarehouse&#x60; - Industrial / Warehouse             commercial type * &#x60;IrrigationServices&#x60; - Irrigation Services             commercial/rural type * &#x60;NewLand&#x60; - New Land * &#x60;Livestock&#x60; - Livestock             commercial/rural type * &#x60;International&#x60; - International             commercial type * &#x60;MedicalConsulting&#x60; - Medical / Consulting             commercial type * &#x60;NewApartments&#x60; - New Apartments / Off the Plan * &#x60;Offices&#x60; - Offices             commercial type * &#x60;ParkingCarSpace&#x60; - Parking / Car Space             commercial type * &#x60;Penthouse&#x60; - Penthouse * &#x60;Retail&#x60; - Retail             commercial type * &#x60;Retirement&#x60; - Retirement * &#x60;Rural&#x60; - Rural * &#x60;RuralCommercialFarming&#x60; - Rural / Commercial Farming              commercial type * &#x60;SemiDetached&#x60; - Semi Detached * &#x60;ShowroomsBulkyGoods&#x60; - Showrooms / Bulky Goods             commercial type * &#x60;SpecialistFarm&#x60; - The specialist farm * &#x60;Studio&#x60; - Studio * &#x60;Terrace&#x60; - Terrace * &#x60;Townhouse&#x60; - The townhouse * &#x60;VacantLand&#x60; - Vacant Land * &#x60;Villa&#x60; - Villa * &#x60;ServicedOffices&#x60; - Serviced Offices             commercial type * &#x60;Other&#x60; - Other             commercial type * &#x60;ChickenShop&#x60; - Chicken Shop             commercial type * &#x60;SeafoodShop&#x60; - Seafood Shop             commercial type * &#x60;DeliCafe&#x60; - Deli Cafe             commercial type * &#x60;Cropping&#x60; - Cropping             commercial/rural type * &#x60;Viticulture&#x60; - Viticulture             commercial/rural type * &#x60;MixedFarming&#x60; - Mixed Farming             commercial type * &#x60;Grazing&#x60; - Grazing             commercial/rural type * &#x60;Horticulture&#x60; - Horticulture             commercial/rural type * &#x60;Equine&#x60; - Equine             commercial/rural type * &#x60;Farmlet&#x60; - Farmlet             commercial/rural type * &#x60;Orchard&#x60; - Orchard             commercial/rural type * &#x60;RuralLifestyle&#x60; - Rural Lifestyle             commercial/rural type * &#x60;OnlineBusiness&#x60; - Online Business
    /// </summary>
    /// <value>Available types of Properties  * &#x60;Unknown&#x60; - Unknown * &#x60;AcreageSemiRural&#x60; - Acreage-SemiRural * &#x60;ApartmentUnitFlat&#x60; - Apartment Unit Flat * &#x60;Aquaculture&#x60; - Aquaculture             commercial/rural type * &#x60;BlockOfUnits&#x60; - Block Of Units * &#x60;Carspace&#x60; - Carspace * &#x60;DairyFarming&#x60; - Dairy Farming             commercial/rural type * &#x60;DevelopmentLand&#x60; - Development / Land * &#x60;DevelopmentSite&#x60; - Development site * &#x60;Duplex&#x60; - Duplex * &#x60;Farm&#x60; - Farm * &#x60;FishingForestry&#x60; - Fishing / Forestry             commercial/rural type * &#x60;HomeBased&#x60; - Home Based * &#x60;NewHomeDesigns&#x60; - New Home Designs * &#x60;HotelLeisure&#x60; - Hotel / Leisure             commercial type * &#x60;House&#x60; - House * &#x60;NewHouseLand&#x60; - New House And Land * &#x60;IndustrialWarehouse&#x60; - Industrial / Warehouse             commercial type * &#x60;IrrigationServices&#x60; - Irrigation Services             commercial/rural type * &#x60;NewLand&#x60; - New Land * &#x60;Livestock&#x60; - Livestock             commercial/rural type * &#x60;International&#x60; - International             commercial type * &#x60;MedicalConsulting&#x60; - Medical / Consulting             commercial type * &#x60;NewApartments&#x60; - New Apartments / Off the Plan * &#x60;Offices&#x60; - Offices             commercial type * &#x60;ParkingCarSpace&#x60; - Parking / Car Space             commercial type * &#x60;Penthouse&#x60; - Penthouse * &#x60;Retail&#x60; - Retail             commercial type * &#x60;Retirement&#x60; - Retirement * &#x60;Rural&#x60; - Rural * &#x60;RuralCommercialFarming&#x60; - Rural / Commercial Farming              commercial type * &#x60;SemiDetached&#x60; - Semi Detached * &#x60;ShowroomsBulkyGoods&#x60; - Showrooms / Bulky Goods             commercial type * &#x60;SpecialistFarm&#x60; - The specialist farm * &#x60;Studio&#x60; - Studio * &#x60;Terrace&#x60; - Terrace * &#x60;Townhouse&#x60; - The townhouse * &#x60;VacantLand&#x60; - Vacant Land * &#x60;Villa&#x60; - Villa * &#x60;ServicedOffices&#x60; - Serviced Offices             commercial type * &#x60;Other&#x60; - Other             commercial type * &#x60;ChickenShop&#x60; - Chicken Shop             commercial type * &#x60;SeafoodShop&#x60; - Seafood Shop             commercial type * &#x60;DeliCafe&#x60; - Deli Cafe             commercial type * &#x60;Cropping&#x60; - Cropping             commercial/rural type * &#x60;Viticulture&#x60; - Viticulture             commercial/rural type * &#x60;MixedFarming&#x60; - Mixed Farming             commercial type * &#x60;Grazing&#x60; - Grazing             commercial/rural type * &#x60;Horticulture&#x60; - Horticulture             commercial/rural type * &#x60;Equine&#x60; - Equine             commercial/rural type * &#x60;Farmlet&#x60; - Farmlet             commercial/rural type * &#x60;Orchard&#x60; - Orchard             commercial/rural type * &#x60;RuralLifestyle&#x60; - Rural Lifestyle             commercial/rural type * &#x60;OnlineBusiness&#x60; - Online Business</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ListingsV2PropertyType
    {
        /// <summary>
        /// Enum Unknown for value: unknown
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown = 1,

        /// <summary>
        /// Enum AcreageSemiRural for value: acreageSemiRural
        /// </summary>
        [EnumMember(Value = "acreageSemiRural")]
        AcreageSemiRural = 2,

        /// <summary>
        /// Enum Duplex for value: duplex
        /// </summary>
        [EnumMember(Value = "duplex")]
        Duplex = 3,

        /// <summary>
        /// Enum House for value: house
        /// </summary>
        [EnumMember(Value = "house")]
        House = 4,

        /// <summary>
        /// Enum Rural for value: rural
        /// </summary>
        [EnumMember(Value = "rural")]
        Rural = 5,

        /// <summary>
        /// Enum Farm for value: farm
        /// </summary>
        [EnumMember(Value = "farm")]
        Farm = 6,

        /// <summary>
        /// Enum SpecialistFarm for value: specialistFarm
        /// </summary>
        [EnumMember(Value = "specialistFarm")]
        SpecialistFarm = 7,

        /// <summary>
        /// Enum Carspace for value: carspace
        /// </summary>
        [EnumMember(Value = "carspace")]
        Carspace = 8,

        /// <summary>
        /// Enum DevelopmentLand for value: developmentLand
        /// </summary>
        [EnumMember(Value = "developmentLand")]
        DevelopmentLand = 9,

        /// <summary>
        /// Enum DevelopmentSite for value: developmentSite
        /// </summary>
        [EnumMember(Value = "developmentSite")]
        DevelopmentSite = 10,

        /// <summary>
        /// Enum NewHouseLand for value: newHouseLand
        /// </summary>
        [EnumMember(Value = "newHouseLand")]
        NewHouseLand = 11,

        /// <summary>
        /// Enum Villa for value: villa
        /// </summary>
        [EnumMember(Value = "villa")]
        Villa = 12,

        /// <summary>
        /// Enum Townhouse for value: townhouse
        /// </summary>
        [EnumMember(Value = "townhouse")]
        Townhouse = 13,

        /// <summary>
        /// Enum SemiDetached for value: semiDetached
        /// </summary>
        [EnumMember(Value = "semiDetached")]
        SemiDetached = 14,

        /// <summary>
        /// Enum Terrace for value: terrace
        /// </summary>
        [EnumMember(Value = "terrace")]
        Terrace = 15,

        /// <summary>
        /// Enum Penthouse for value: penthouse
        /// </summary>
        [EnumMember(Value = "penthouse")]
        Penthouse = 16,

        /// <summary>
        /// Enum Studio for value: studio
        /// </summary>
        [EnumMember(Value = "studio")]
        Studio = 17,

        /// <summary>
        /// Enum ApartmentUnitFlat for value: apartmentUnitFlat
        /// </summary>
        [EnumMember(Value = "apartmentUnitFlat")]
        ApartmentUnitFlat = 18,

        /// <summary>
        /// Enum BlockOfUnits for value: blockOfUnits
        /// </summary>
        [EnumMember(Value = "blockOfUnits")]
        BlockOfUnits = 19,

        /// <summary>
        /// Enum VacantLand for value: vacantLand
        /// </summary>
        [EnumMember(Value = "vacantLand")]
        VacantLand = 20,

        /// <summary>
        /// Enum NewHomeDesigns for value: newHomeDesigns
        /// </summary>
        [EnumMember(Value = "newHomeDesigns")]
        NewHomeDesigns = 21,

        /// <summary>
        /// Enum HotelLeisure for value: hotelLeisure
        /// </summary>
        [EnumMember(Value = "hotelLeisure")]
        HotelLeisure = 22,

        /// <summary>
        /// Enum IndustrialWarehouse for value: industrialWarehouse
        /// </summary>
        [EnumMember(Value = "industrialWarehouse")]
        IndustrialWarehouse = 23,

        /// <summary>
        /// Enum NewLand for value: newLand
        /// </summary>
        [EnumMember(Value = "newLand")]
        NewLand = 24,

        /// <summary>
        /// Enum International for value: international
        /// </summary>
        [EnumMember(Value = "international")]
        International = 25,

        /// <summary>
        /// Enum MedicalConsulting for value: medicalConsulting
        /// </summary>
        [EnumMember(Value = "medicalConsulting")]
        MedicalConsulting = 26,

        /// <summary>
        /// Enum NewApartments for value: newApartments
        /// </summary>
        [EnumMember(Value = "newApartments")]
        NewApartments = 27,

        /// <summary>
        /// Enum Offices for value: offices
        /// </summary>
        [EnumMember(Value = "offices")]
        Offices = 28,

        /// <summary>
        /// Enum ParkingCarSpace for value: parkingCarSpace
        /// </summary>
        [EnumMember(Value = "parkingCarSpace")]
        ParkingCarSpace = 29,

        /// <summary>
        /// Enum Retail for value: retail
        /// </summary>
        [EnumMember(Value = "retail")]
        Retail = 30,

        /// <summary>
        /// Enum Retirement for value: retirement
        /// </summary>
        [EnumMember(Value = "retirement")]
        Retirement = 31,

        /// <summary>
        /// Enum RuralCommercialFarming for value: ruralCommercialFarming
        /// </summary>
        [EnumMember(Value = "ruralCommercialFarming")]
        RuralCommercialFarming = 32,

        /// <summary>
        /// Enum ShowroomsBulkyGoods for value: showroomsBulkyGoods
        /// </summary>
        [EnumMember(Value = "showroomsBulkyGoods")]
        ShowroomsBulkyGoods = 33,

        /// <summary>
        /// Enum ServicedOffices for value: servicedOffices
        /// </summary>
        [EnumMember(Value = "servicedOffices")]
        ServicedOffices = 34,

        /// <summary>
        /// Enum Other for value: other
        /// </summary>
        [EnumMember(Value = "other")]
        Other = 35,

        /// <summary>
        /// Enum ChickenShop for value: chickenShop
        /// </summary>
        [EnumMember(Value = "chickenShop")]
        ChickenShop = 36,

        /// <summary>
        /// Enum SeafoodShop for value: seafoodShop
        /// </summary>
        [EnumMember(Value = "seafoodShop")]
        SeafoodShop = 37,

        /// <summary>
        /// Enum DeliCafe for value: deliCafe
        /// </summary>
        [EnumMember(Value = "deliCafe")]
        DeliCafe = 38,

        /// <summary>
        /// Enum Cropping for value: cropping
        /// </summary>
        [EnumMember(Value = "cropping")]
        Cropping = 39,

        /// <summary>
        /// Enum Viticulture for value: viticulture
        /// </summary>
        [EnumMember(Value = "viticulture")]
        Viticulture = 40,

        /// <summary>
        /// Enum MixedFarming for value: mixedFarming
        /// </summary>
        [EnumMember(Value = "mixedFarming")]
        MixedFarming = 41,

        /// <summary>
        /// Enum Grazing for value: grazing
        /// </summary>
        [EnumMember(Value = "grazing")]
        Grazing = 42,

        /// <summary>
        /// Enum Horticulture for value: horticulture
        /// </summary>
        [EnumMember(Value = "horticulture")]
        Horticulture = 43,

        /// <summary>
        /// Enum Equine for value: equine
        /// </summary>
        [EnumMember(Value = "equine")]
        Equine = 44,

        /// <summary>
        /// Enum Farmlet for value: farmlet
        /// </summary>
        [EnumMember(Value = "farmlet")]
        Farmlet = 45,

        /// <summary>
        /// Enum Orchard for value: orchard
        /// </summary>
        [EnumMember(Value = "orchard")]
        Orchard = 46,

        /// <summary>
        /// Enum RuralLifestyle for value: ruralLifestyle
        /// </summary>
        [EnumMember(Value = "ruralLifestyle")]
        RuralLifestyle = 47,

        /// <summary>
        /// Enum IrrigationServices for value: irrigationServices
        /// </summary>
        [EnumMember(Value = "irrigationServices")]
        IrrigationServices = 48,

        /// <summary>
        /// Enum DairyFarming for value: dairyFarming
        /// </summary>
        [EnumMember(Value = "dairyFarming")]
        DairyFarming = 49,

        /// <summary>
        /// Enum Livestock for value: livestock
        /// </summary>
        [EnumMember(Value = "livestock")]
        Livestock = 50,

        /// <summary>
        /// Enum Aquaculture for value: aquaculture
        /// </summary>
        [EnumMember(Value = "aquaculture")]
        Aquaculture = 51,

        /// <summary>
        /// Enum FishingForestry for value: fishingForestry
        /// </summary>
        [EnumMember(Value = "fishingForestry")]
        FishingForestry = 52,

        /// <summary>
        /// Enum OnlineBusiness for value: onlineBusiness
        /// </summary>
        [EnumMember(Value = "onlineBusiness")]
        OnlineBusiness = 53,

        /// <summary>
        /// Enum HomeBased for value: homeBased
        /// </summary>
        [EnumMember(Value = "homeBased")]
        HomeBased = 54

    }

}
