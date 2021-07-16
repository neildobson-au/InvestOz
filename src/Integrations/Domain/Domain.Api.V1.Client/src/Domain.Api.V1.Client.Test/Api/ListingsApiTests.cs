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
    ///  Class for testing ListingsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ListingsApiTests : IDisposable
    {
        private ListingsApi instance;

        public ListingsApiTests()
        {
            instance = new ListingsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ListingsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ListingsApi
            //Assert.IsType<ListingsApi>(instance);
        }

        /// <summary>
        /// Test ListingLocationsSearch
        /// </summary>
        [Fact]
        public void ListingLocationsSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string terms = null;
            //var response = instance.ListingLocationsSearch(terms);
            //Assert.IsType<List<DomainPublicAdapterWebApiModelsV1ListingsListingLocation>>(response);
        }

        /// <summary>
        /// Test ListingsDetailedBusinessSearch
        /// </summary>
        [Fact]
        public void ListingsDetailedBusinessSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DomainPublicAdapterWebApiModelsV1ListingsBusinessSearchRequest domainPublicAdapterWebApiModelsV1ListingsBusinessSearchRequest = null;
            //var response = instance.ListingsDetailedBusinessSearch(domainPublicAdapterWebApiModelsV1ListingsBusinessSearchRequest);
            //Assert.IsType<List<DomainPublicAdapterWebApiModelsV1ListingsBusinessListing>>(response);
        }

        /// <summary>
        /// Test ListingsDetailedCommercialSearch
        /// </summary>
        [Fact]
        public void ListingsDetailedCommercialSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DomainPublicAdapterWebApiModelsV1ListingsCommercialSearchRequest domainPublicAdapterWebApiModelsV1ListingsCommercialSearchRequest = null;
            //var response = instance.ListingsDetailedCommercialSearch(domainPublicAdapterWebApiModelsV1ListingsCommercialSearchRequest);
            //Assert.IsType<List<DomainPublicAdapterWebApiModelsV1ListingsCommercialListing>>(response);
        }

        /// <summary>
        /// Test ListingsDetailedResidentialSearch
        /// </summary>
        [Fact]
        public void ListingsDetailedResidentialSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsSearchParameters domainSearchServiceV2ModelDomainSearchWebApiV2ModelsSearchParameters = null;
            //var response = instance.ListingsDetailedResidentialSearch(domainSearchServiceV2ModelDomainSearchWebApiV2ModelsSearchParameters);
            //Assert.IsType<List<DomainSearchServiceV2ModelDomainSearchContractsV2SearchResult>>(response);
        }

        /// <summary>
        /// Test ListingsGet
        /// </summary>
        [Fact]
        public void ListingsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.ListingsGet(id);
            //Assert.IsType<DomainPublicAdapterWebApiModelsV1ListingsListing>(response);
        }

        /// <summary>
        /// Test ListingsGetEnquiries
        /// </summary>
        [Fact]
        public void ListingsGetEnquiriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //int? pageNumber = null;
            //var response = instance.ListingsGetEnquiries(id, pageNumber);
            //Assert.IsType<List<DomainPublicAdapterWebApiModelsV1EnquiriesEnquiryReport>>(response);
        }

        /// <summary>
        /// Test ListingsGetListingReport
        /// </summary>
        [Fact]
        public void ListingsGetListingReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ListingsGetListingReport(id);
            //Assert.IsType<DomainListingAdminServiceV1ModelListingReport>(response);
        }

        /// <summary>
        /// Test ListingsGetListingReportByReference
        /// </summary>
        [Fact]
        public void ListingsGetListingReportByReferenceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int agencyId = null;
            //string providerAdId = null;
            //var response = instance.ListingsGetListingReportByReference(agencyId, providerAdId);
            //Assert.IsType<List<DomainListingAdminServiceV1ModelListingReport>>(response);
        }

        /// <summary>
        /// Test ListingsGetListingStatistics
        /// </summary>
        [Fact]
        public void ListingsGetListingStatisticsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string timePeriod = null;
            //var response = instance.ListingsGetListingStatistics(id, timePeriod);
            //Assert.IsType<DomainPublicAdapterWebApiModelsV1ListingsStatisticsReport>(response);
        }

        /// <summary>
        /// Test ListingsGetListingStatisticsByAgentId
        /// </summary>
        [Fact]
        public void ListingsGetListingStatisticsByAgentIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int agentId = null;
            //string timePeriod = null;
            //string statusFilter = null;
            //int? pageNumber = null;
            //int? pageSize = null;
            //var response = instance.ListingsGetListingStatisticsByAgentId(agentId, timePeriod, statusFilter, pageNumber, pageSize);
            //Assert.IsType<List<DomainPublicAdapterWebApiModelsV1ListingsStatistics>>(response);
        }

        /// <summary>
        /// Test ListingsUpdateOffmarketDetails
        /// </summary>
        [Fact]
        public void ListingsUpdateOffmarketDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //DomainListingAdminServiceV1ModelOffMarketDetails domainListingAdminServiceV1ModelOffMarketDetails = null;
            //var response = instance.ListingsUpdateOffmarketDetails(id, domainListingAdminServiceV1ModelOffMarketDetails);
            //Assert.IsType<DomainListingAdminServiceV1ModelListingResponse>(response);
        }

        /// <summary>
        /// Test ListingsUpsertBusinessListing
        /// </summary>
        [Fact]
        public void ListingsUpsertBusinessListingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DomainListingAdminServiceV1ModelBusinessListing domainListingAdminServiceV1ModelBusinessListing = null;
            //var response = instance.ListingsUpsertBusinessListing(domainListingAdminServiceV1ModelBusinessListing);
            //Assert.IsType<DomainListingAdminServiceV1ModelListingResponse>(response);
        }

        /// <summary>
        /// Test ListingsUpsertCommercialListing
        /// </summary>
        [Fact]
        public void ListingsUpsertCommercialListingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DomainListingAdminServiceV1ModelCommercialListing domainListingAdminServiceV1ModelCommercialListing = null;
            //var response = instance.ListingsUpsertCommercialListing(domainListingAdminServiceV1ModelCommercialListing);
            //Assert.IsType<DomainListingAdminServiceV1ModelListingResponse>(response);
        }

        /// <summary>
        /// Test ListingsUpsertResidentialListing
        /// </summary>
        [Fact]
        public void ListingsUpsertResidentialListingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DomainListingAdminServiceV1ModelResidentialListing domainListingAdminServiceV1ModelResidentialListing = null;
            //var response = instance.ListingsUpsertResidentialListing(domainListingAdminServiceV1ModelResidentialListing);
            //Assert.IsType<DomainListingAdminServiceV1ModelListingResponse>(response);
        }

        /// <summary>
        /// Test ProjectsGet
        /// </summary>
        [Fact]
        public void ProjectsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.ProjectsGet(id);
            //Assert.IsType<ListingsV2Project>(response);
        }

        /// <summary>
        /// Test ProjectsSearch
        /// </summary>
        [Fact]
        public void ProjectsSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? agencyId = null;
            //int? pageNumber = null;
            //int? pageSize = null;
            //var response = instance.ProjectsSearch(agencyId, pageNumber, pageSize);
            //Assert.IsType<List<ListingsV2Project>>(response);
        }
    }
}
