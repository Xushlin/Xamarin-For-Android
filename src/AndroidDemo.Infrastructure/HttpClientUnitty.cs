using System;
using System.Net;
using System.Net.Http;

namespace AndroidDemo.Infrastructure
{
    internal static class HttpClientUnitty
    {
        private static HttpClient _client;

        public static HttpClient Of()
        {
            if (_client != null) return _client;

            var handler = new HttpClientHandler();
            if (handler.SupportsAutomaticDecompression)
            {
                handler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            }
            _client = new HttpClient(handler) {Timeout = new TimeSpan(0, 5, 0)};

            return _client;
        }
    }
}

