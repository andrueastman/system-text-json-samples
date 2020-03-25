using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Graph;
using Microsoft.Identity.Client;

namespace SystemTextJsonSamples
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            string clientId = "d662ac70-7482-45af-9dc3-c3cde8eeede4";
            string[] scopes = new[] { "User.Read", "Mail.ReadWrite" , "Calendars.ReadWrite" };

            //Create the msal application
            IPublicClientApplication publicClientApplication = PublicClientApplicationBuilder
                .Create(clientId).WithRedirectUri("http://localhost:1234")
                .Build();

            var authResult = await publicClientApplication.AcquireTokenInteractive(scopes).ExecuteAsync();

            /* Create a DelegateAuthenticationProvider to use */
            var delegatingAuthProvider = new DelegateAuthenticationProvider((requestMessage) =>
            {
                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("bearer", authResult.AccessToken);
                return Task.FromResult(0);
            });

            HttpClient httpClient = GraphClientFactory.Create(delegatingAuthProvider);

            //Test Batch Code
            //await TestBatch(httpClient);

            //await TestFetchUser(httpClient);

            await TestFetchEvents(httpClient);

        }

        private static async Task TestFetchUser(HttpClient httpClient)
        {
            BaseClient baseClient = new BaseClient("https://graph.microsoft.com/v1.0/", httpClient);
            BaseRequest request = new BaseRequest("https://graph.microsoft.com/v1.0/me/messages", baseClient);
            User user = await request.SendAsync<User>(null, CancellationToken.None);
            Console.WriteLine(user.Id);
            Console.WriteLine(user.DisplayName);
        }


        private static async Task TestBatch(HttpClient httpClient)
        {
            // Create http GET request.
            HttpRequestMessage httpRequestMessage1 = new HttpRequestMessage(HttpMethod.Get, "https://graph.microsoft.com/v1.0/me/");

            // Create http POST request.
            String jsonContent = "{" +
                        "\"displayName\": \"My Notebook2\"" +
                        "}";
            HttpRequestMessage httpRequestMessage2 = new HttpRequestMessage(HttpMethod.Post, "https://graph.microsoft.com/v1.0/me/onenote/notebooks")
            {
                Content = new StringContent(jsonContent, Encoding.UTF8, "application/json")
            };

            // Create batch request steps with request ids.
            BatchRequestStep requestStep1 = new BatchRequestStep("1", httpRequestMessage1, null);
            BatchRequestStep requestStep2 = new BatchRequestStep("2", httpRequestMessage2, new List<string> { "1" });

            // Add batch request steps to BatchRequestContent.
            BatchRequestContent batchRequestContent = new BatchRequestContent();
            batchRequestContent.AddBatchRequestStep(requestStep1);
            batchRequestContent.AddBatchRequestStep(requestStep2);

            // Send batch request with BatchRequestContent.
            HttpResponseMessage response = await httpClient.PostAsync("https://graph.microsoft.com/v1.0/$batch", batchRequestContent);

            // Handle http responses using BatchResponseContent.
            BatchResponseContent batchResponseContent = new BatchResponseContent(response);
            Dictionary<string, HttpResponseMessage> responses = await batchResponseContent.GetResponsesAsync();
            HttpResponseMessage httpResponse = await batchResponseContent.GetResponseByIdAsync("1");
            string responseString = await httpResponse.Content.ReadAsStringAsync();
            Console.WriteLine(responseString);

            HttpResponseMessage httpResponse2 = await batchResponseContent.GetResponseByIdAsync("2");
            responseString = await httpResponse.Content.ReadAsStringAsync();
            Console.WriteLine(responseString);

            string nextLink = await batchResponseContent.GetNextLinkAsync();
            Console.WriteLine(nextLink);
        }

        private static async Task TestFetchEvents(HttpClient httpClient)
        {
            BaseClient baseClient = new BaseClient("https://graph.microsoft.com/v1.0/", httpClient);
            BaseRequest request = new BaseRequest("https://graph.microsoft.com/v1.0/me/events", baseClient);
            UserEventsCollectionResponse eventsCollectionPage = await request.SendAsync<UserEventsCollectionResponse>(null,CancellationToken.None);
            foreach (var eventExample in eventsCollectionPage.Value.CurrentPage)
            {
                Console.WriteLine(eventExample.Id);
                Console.WriteLine(eventExample.CreatedDateTime);
                Console.WriteLine(eventExample.BodyPreview);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }

    }
}
