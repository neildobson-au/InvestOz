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
    ///  Class for testing SchoolsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SchoolsApiTests : IDisposable
    {
        private SchoolsApi instance;

        public SchoolsApiTests()
        {
            instance = new SchoolsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SchoolsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SchoolsApi
            //Assert.IsType<SchoolsApi>(instance);
        }

        /// <summary>
        /// Test SchoolsGet
        /// </summary>
        [Fact]
        public void SchoolsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.SchoolsGet(id);
            //Assert.IsType<DomainPublicAdapterWebApiModelsV1LocationsSchoolsSchool>(response);
        }

        /// <summary>
        /// Test SchoolsSearch
        /// </summary>
        [Fact]
        public void SchoolsSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string coordinate = null;
            //var response = instance.SchoolsSearch(coordinate);
            //Assert.IsType<List<DomainPublicAdapterWebApiModelsV1LocationsSchoolsSchool>>(response);
        }
    }
}
