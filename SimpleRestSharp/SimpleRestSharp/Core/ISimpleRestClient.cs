using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleRestSharp.Core
{
    public interface ISimpleRestClient
    {
        IRestRequest GetRequest(string url, Method method = Method.GET, DataFormat requestFormat = DataFormat.Json, object body = null);
        IRestResponse<T> GetResponse<T>(IRestRequest request) where T : class, new();
        IRestResponse GetResponse(IRestRequest request);
    }
}
