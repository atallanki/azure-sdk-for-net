// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Object for Capturing DeviceCapacityInfo
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DeviceCapacityInfo : ARMBaseModel
    {
        /// <summary>
        /// Initializes a new instance of the DeviceCapacityInfo class.
        /// </summary>
        public DeviceCapacityInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeviceCapacityInfo class.
        /// </summary>
        /// <param name="id">The path ID that uniquely identifies the
        /// object.</param>
        /// <param name="name">The object name.</param>
        /// <param name="type">The hierarchical type of the object.</param>
        /// <param name="timeStamp">Timestamp of request in UTC</param>
        /// <param name="clusterStorageCapacityInfo">Cluster capacity data for
        /// storage resources (CSV).</param>
        /// <param name="clusterComputeCapacityInfo">Cluster capacity data for
        /// compute resources (Memory and GPU).</param>
        /// <param name="nodeCapacityInfos">The dictionary of individual node
        /// names and node capacities in the cluster.</param>
        /// <param name="systemData">Metadata pertaining to device capacity
        /// info.</param>
        public DeviceCapacityInfo(string id = default(string), string name = default(string), string type = default(string), System.DateTime? timeStamp = default(System.DateTime?), ClusterStorageViewData clusterStorageCapacityInfo = default(ClusterStorageViewData), ClusterCapacityViewData clusterComputeCapacityInfo = default(ClusterCapacityViewData), IDictionary<string, HostCapacity> nodeCapacityInfos = default(IDictionary<string, HostCapacity>), SystemData systemData = default(SystemData))
            : base(id, name, type)
        {
            TimeStamp = timeStamp;
            ClusterStorageCapacityInfo = clusterStorageCapacityInfo;
            ClusterComputeCapacityInfo = clusterComputeCapacityInfo;
            NodeCapacityInfos = nodeCapacityInfos;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets timestamp of request in UTC
        /// </summary>
        [JsonProperty(PropertyName = "properties.timeStamp")]
        public System.DateTime? TimeStamp { get; set; }

        /// <summary>
        /// Gets or sets cluster capacity data for storage resources (CSV).
        /// </summary>
        [JsonProperty(PropertyName = "properties.clusterStorageCapacityInfo")]
        public ClusterStorageViewData ClusterStorageCapacityInfo { get; set; }

        /// <summary>
        /// Gets or sets cluster capacity data for compute resources (Memory
        /// and GPU).
        /// </summary>
        [JsonProperty(PropertyName = "properties.clusterComputeCapacityInfo")]
        public ClusterCapacityViewData ClusterComputeCapacityInfo { get; set; }

        /// <summary>
        /// Gets or sets the dictionary of individual node names and node
        /// capacities in the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.nodeCapacityInfos")]
        public IDictionary<string, HostCapacity> NodeCapacityInfos { get; set; }

        /// <summary>
        /// Gets metadata pertaining to device capacity info.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

    }
}
