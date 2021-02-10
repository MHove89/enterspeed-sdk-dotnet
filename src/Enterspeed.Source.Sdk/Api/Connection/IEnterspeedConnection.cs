﻿using System.Net.Http;

namespace Enterspeed.Source.Sdk.Api.Connection
{
    public interface IEnterspeedConnection
    {
        /// <summary>
        /// Gets the configured HttpClient.
        /// </summary>
        HttpClient HttpClientConnection { get; }

        /// <summary>
        /// Flushes/resets the current HttpClient.
        /// </summary>
        void Flush();
    }
}