using RestSharp;
using System;

namespace SimpleRestSharp.Exceptions
{
    public class InvalidResponseException : Exception
    {
        public InvalidResponseException() : base()
        {
            throw new NotSupportedException();
        }
        public InvalidResponseException(IRestResponse response) : base(response.ToString())
        {
            InvalidResponse = response;
        }
        public InvalidResponseException(IRestResponse response, Exception innerException) : base(response.ToString(), innerException)
        {
            InvalidResponse = response;
        }

        public IRestResponse InvalidResponse { get; private set; }
    }
}
