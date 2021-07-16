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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Domain.Api.Client.Client;
using Domain.Api.Client.Api;
// uncomment below to import models
//using Domain.Api.Client.Model;

namespace Domain.Api.Client.Test.Api
{
    /// <summary>
    ///  Class for testing SuburbPerformanceStatisticsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SuburbPerformanceStatisticsApiTests : IDisposable
    {
        private SuburbPerformanceStatisticsApi instance;

        public SuburbPerformanceStatisticsApiTests()
        {
            instance = new SuburbPerformanceStatisticsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SuburbPerformanceStatisticsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SuburbPerformanceStatisticsApi
            //Assert.IsType<SuburbPerformanceStatisticsApi>(instance);
        }

        /// <summary>
        /// Test SuburbPerformanceGetByNamedSuburb
        /// </summary>
        [Fact]
        public void SuburbPerformanceGetByNamedSuburbTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string state = null;
            //string suburb = null;
            //string postcode = null;
            //SuburbPerformanceStatisticsV3PropertyCategory? propertyCategory = null;
            //int? bedrooms = null;
            //SuburbPerformanceStatisticsV3PeriodSize? periodSize = null;
            //int? startingPeriodRelativeToCurrent = null;
            //int? totalPeriods = null;
            //var response = instance.SuburbPerformanceGetByNamedSuburb(state, suburb, postcode, propertyCategory, bedrooms, periodSize, startingPeriodRelativeToCurrent, totalPeriods);
            //Assert.IsType<SuburbPerformanceStatisticsV3SuburbPerformance>(response);
        }
    }
}
