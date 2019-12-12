using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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
