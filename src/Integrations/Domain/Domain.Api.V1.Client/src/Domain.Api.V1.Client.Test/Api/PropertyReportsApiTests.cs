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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Api;
// uncomment below to import models
//using Domain.Api.V1.Client.Model;

namespace Domain.Api.V1.Client.Test.Api
{
    /// <summary>
    ///  Class for testing PropertyReportsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PropertyReportsApiTests : IDisposable
    {
        private PropertyReportsApi instance;

        public PropertyReportsApiTests()
        {
            instance = new PropertyReportsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PropertyReportsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PropertyReportsApi
            //Assert.IsType<PropertyReportsApi>(instance);
        }

        /// <summary>
        /// Test PropertyReportsGet
        /// </summary>
        [Fact]
        public void PropertyReportsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string propertyType = null;
            //string streetNumber = null;
            //string streetName = null;
            //string suburb = null;
            //string state = null;
            //string unitNumber = null;
            //string streetType = null;
            //string postcode = null;
            //int? areaSize = null;
            //int? bedrooms = null;
            //int? bathrooms = null;
            //int? parking = null;
            //string preparedFor = null;
            //string productCode = null;
            //var response = instance.PropertyReportsGet(propertyType, streetNumber, streetName, suburb, state, unitNumber, streetType, postcode, areaSize, bedrooms, bathrooms, parking, preparedFor, productCode);
            //Assert.IsType<DomainPropertyReportServiceV1ModelPropertyReportGenerationResult>(response);
        }
    }
}
