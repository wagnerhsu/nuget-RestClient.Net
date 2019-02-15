using System;
using System.Net;

namespace RestClientDotNet
{
    public class HttpStatusException : Exception
    {
        public HttpStatusCode StatusCode { get; }
        public byte[] ErrorData { get; }

        public HttpStatusException(string message, HttpStatusCode statusCode, byte[] errorData) : base(message)
        {
            StatusCode = statusCode;
            ErrorData = errorData;
        }

        public HttpStatusException()
        {
        }

        public HttpStatusException(string message) : base(message)
        {
        }

        public HttpStatusException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}