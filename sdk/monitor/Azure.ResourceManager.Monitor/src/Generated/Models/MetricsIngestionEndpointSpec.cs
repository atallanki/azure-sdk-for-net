// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Definition of the endpoint used for ingesting metrics. </summary>
    internal partial class MetricsIngestionEndpointSpec
    {
        /// <summary> Initializes a new instance of MetricsIngestionEndpointSpec. </summary>
        public MetricsIngestionEndpointSpec()
        {
        }

        /// <summary> Initializes a new instance of MetricsIngestionEndpointSpec. </summary>
        /// <param name="endpoint"> The endpoint. This property is READ-ONLY. </param>
        internal MetricsIngestionEndpointSpec(string endpoint)
        {
            Endpoint = endpoint;
        }

        /// <summary> The endpoint. This property is READ-ONLY. </summary>
        public string Endpoint { get; }
    }
}
