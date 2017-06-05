using System;
using System.Collections.Generic;
using System.Net.Mime;
using BookService.Models;
using RestSharp;
using TechTalk.SpecFlow;
using Xunit;

namespace BookServiceApiTests.IntegrationTests
{
    [Binding]
    public class BookServiceApiFeature1Steps
    {
        private readonly Uri _bookServiceUri = new Uri("http://localhost:59129");
        private RestClient _bookServiceClient;
        private IRestResponse<List<BookDTO>>  _response;

        [Given(@"I have a Book Service REST endpoint")]
        public void GivenIHaveArestEndpointForBooksService()
        {
            _bookServiceClient = new RestClient(_bookServiceUri);
        }
        
        [When(@"I browse to the get books endpoint")]
        public void WhenIBrowseToTheGetBooksEndpoint()
        {
            var request = new RestRequest("api/books", Method.GET);
            _response = _bookServiceClient.Execute<List<BookDTO>>(request);
        }
        
        [Then(@"the result should be a list of all books")]
        public void ThenTheResultShouldBeAListOfAllBooks()
        {
            Assert.NotNull(_response);
            Assert.Equal(_response.Data.Count, 10);
        }
    }
}
