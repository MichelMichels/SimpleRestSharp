using RestSharp;
using RestSharp.Serialization.Json;
using SimpleRestSharp.Exceptions;
using System;

namespace SimpleRestSharp.Core
{
    public abstract class SimpleRestClient : RestClient
    {
        protected IRestClient restClient;
        protected JsonSerializer json = new JsonSerializer();

        protected SimpleRestClient(string baseUrl)
        {
            restClient = new RestClient(baseUrl);
        }

        protected virtual IRestRequest GetRequest(string url, Method method = Method.GET, DataFormat requestFormat = DataFormat.Json, object body = null)
        {
            var request = new RestRequest(url, method)
            {
                RequestFormat = requestFormat,                              
            };           

            if (body != null)
            {
                request.AddJsonBody(body);
            }

            return request;
        }
        protected virtual IRestResponse<T> GetResponse<T>(IRestRequest request) where T : class, new()
        {
            var response = restClient.Execute<T>(request);
            ValidateResponse(response);

            return response;
        }
        protected virtual IRestResponse GetResponse(IRestRequest request)
        {
            var response = restClient.Execute(request);
            ValidateResponse(response);

            return response;
        }
        protected virtual void ValidateResponse(IRestResponse response)
        {
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new InvalidResponseException(response);
            }
        }
    }
}
