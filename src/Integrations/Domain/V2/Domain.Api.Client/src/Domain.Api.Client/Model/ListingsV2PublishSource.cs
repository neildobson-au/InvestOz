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
    /// Specifies where the listing was sold             e.g. sold/leased using domain site or externally  * &#x60;Internal&#x60; - Sold via domain and other internal sites * &#x60;External&#x60; - Agency provided sales data that were Sold externally
    /// </summary>
    /// <value>Specifies where the listing was sold             e.g. sold/leased using domain site or externally  * &#x60;Internal&#x60; - Sold via domain and other internal sites * &#x60;External&#x60; - Agency provided sales data that were Sold externally</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ListingsV2PublishSource
    {
        /// <summary>
        /// Enum Internal for value: internal
        /// </summary>
        [EnumMember(Value = "internal")]
        Internal = 1,

        /// <summary>
        /// Enum External for value: external
        /// </summary>
        [EnumMember(Value = "external")]
        External = 2

    }

}
