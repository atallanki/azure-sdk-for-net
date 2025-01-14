// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The provisionedClusters resource definition. </summary>
    public partial class ProvisionedClusterCreateOrUpdateContent : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ProvisionedClusterCreateOrUpdateContent. </summary>
        /// <param name="location"> The location. </param>
        public ProvisionedClusterCreateOrUpdateContent(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of ProvisionedClusterCreateOrUpdateContent. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Identity for the Provisioned cluster. Current supported identity types: None, SystemAssigned. </param>
        /// <param name="properties"> All properties of the provisioned cluster. </param>
        /// <param name="extendedLocation"></param>
        internal ProvisionedClusterCreateOrUpdateContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, ProvisionedClustersAllProperties properties, ProvisionedClustersExtendedLocation extendedLocation) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            Properties = properties;
            ExtendedLocation = extendedLocation;
        }

        /// <summary> Identity for the Provisioned cluster. Current supported identity types: None, SystemAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> All properties of the provisioned cluster. </summary>
        public ProvisionedClustersAllProperties Properties { get; set; }
        /// <summary> Gets or sets the extended location. </summary>
        public ProvisionedClustersExtendedLocation ExtendedLocation { get; set; }
    }
}
