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
    using System.Linq;

    /// <summary>
    /// Represents a container on the  Data Box Edge/Gateway device.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Container : ARMBaseModel
    {
        /// <summary>
        /// Initializes a new instance of the Container class.
        /// </summary>
        public Container()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Container class.
        /// </summary>
        /// <param name="dataFormat">DataFormat for Container. Possible values
        /// include: 'BlockBlob', 'PageBlob', 'AzureFile'</param>
        /// <param name="id">The path ID that uniquely identifies the
        /// object.</param>
        /// <param name="name">The object name.</param>
        /// <param name="type">The hierarchical type of the object.</param>
        /// <param name="containerStatus">Current status of the container.
        /// Possible values include: 'OK', 'Offline', 'Unknown', 'Updating',
        /// 'NeedsAttention'</param>
        /// <param name="refreshDetails">Details of the refresh job on this
        /// container.</param>
        /// <param name="createdDateTime">The UTC time when container got
        /// created.</param>
        /// <param name="systemData">Metadata pertaining to creation and last
        /// modification of Container</param>
        public Container(string dataFormat, string id = default(string), string name = default(string), string type = default(string), string containerStatus = default(string), RefreshDetails refreshDetails = default(RefreshDetails), System.DateTime? createdDateTime = default(System.DateTime?), SystemData systemData = default(SystemData))
            : base(id, name, type)
        {
            ContainerStatus = containerStatus;
            DataFormat = dataFormat;
            RefreshDetails = refreshDetails;
            CreatedDateTime = createdDateTime;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets current status of the container. Possible values include:
        /// 'OK', 'Offline', 'Unknown', 'Updating', 'NeedsAttention'
        /// </summary>
        [JsonProperty(PropertyName = "properties.containerStatus")]
        public string ContainerStatus { get; private set; }

        /// <summary>
        /// Gets or sets dataFormat for Container. Possible values include:
        /// 'BlockBlob', 'PageBlob', 'AzureFile'
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataFormat")]
        public string DataFormat { get; set; }

        /// <summary>
        /// Gets details of the refresh job on this container.
        /// </summary>
        [JsonProperty(PropertyName = "properties.refreshDetails")]
        public RefreshDetails RefreshDetails { get; private set; }

        /// <summary>
        /// Gets the UTC time when container got created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdDateTime")]
        public System.DateTime? CreatedDateTime { get; private set; }

        /// <summary>
        /// Gets metadata pertaining to creation and last modification of
        /// Container
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DataFormat == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DataFormat");
            }
        }
    }
}
