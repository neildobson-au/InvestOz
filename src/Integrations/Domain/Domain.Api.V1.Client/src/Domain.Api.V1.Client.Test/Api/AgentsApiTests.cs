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
    ///  Class for testing AgentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AgentsApiTests : IDisposable
    {
        private AgentsApi instance;

        public AgentsApiTests()
        {
            instance = new AgentsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AgentsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AgentsApi
            //Assert.IsType<AgentsApi>(instance);
        }

        /// <summary>
        /// Test AgentsGet
        /// </summary>
        [Fact]
        public void AgentsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.AgentsGet(id);
            //Assert.IsType<DomainAgencyServiceV1ModelAgentDto>(response);
        }

        /// <summary>
        /// Test AgentsGetListings
        /// </summary>
        [Fact]
        public void AgentsGetListingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //DateTime? dateUpdatedSince = null;
            //bool? includedArchivedListings = null;
            //int? pageNumber = null;
            //int? pageSize = null;
            //var response = instance.AgentsGetListings(id, dateUpdatedSince, includedArchivedListings, pageNumber, pageSize);
            //Assert.IsType<List<DomainPublicAdapterWebApiModelsV1ListingsListing>>(response);
        }

        /// <summary>
        /// Test AgentsSearch
        /// </summary>
        [Fact]
        public void AgentsSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string query = null;
            //int? pageNumber = null;
            //int? pageSize = null;
            //var response = instance.AgentsSearch(query, pageNumber, pageSize);
            //Assert.IsType<List<DomainAgentSearchV1ModelAutoSuggestAgentResultDto>>(response);
        }
    }
}
