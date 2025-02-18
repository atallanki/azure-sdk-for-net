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
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// List of VM sizes being checked for creation on appliance along with
    /// corresponding result.
    /// </summary>
    public partial class VmPlacementRequestResult
    {
        /// <summary>
        /// Initializes a new instance of the VmPlacementRequestResult class.
        /// </summary>
        public VmPlacementRequestResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VmPlacementRequestResult class.
        /// </summary>
        /// <param name="vmSize">List of VM sizes being checked.</param>
        /// <param name="isFeasible">Boolean value indicating if the VM(s) in
        /// VmSize can be created.</param>
        /// <param name="messageCode">MessageCode indicating reason for success
        /// or failure.</param>
        /// <param name="message">Localized message to be displayed to the user
        /// to explain the check result.</param>
        public VmPlacementRequestResult(IList<string> vmSize = default(IList<string>), bool? isFeasible = default(bool?), string messageCode = default(string), string message = default(string))
        {
            VmSize = vmSize;
            IsFeasible = isFeasible;
            MessageCode = messageCode;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of VM sizes being checked.
        /// </summary>
        [JsonProperty(PropertyName = "vmSize")]
        public IList<string> VmSize { get; set; }

        /// <summary>
        /// Gets or sets boolean value indicating if the VM(s) in VmSize can be
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "isFeasible")]
        public bool? IsFeasible { get; set; }

        /// <summary>
        /// Gets or sets messageCode indicating reason for success or failure.
        /// </summary>
        [JsonProperty(PropertyName = "messageCode")]
        public string MessageCode { get; set; }

        /// <summary>
        /// Gets or sets localized message to be displayed to the user to
        /// explain the check result.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
