// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Summary of revision metadata. </summary>
    public partial class ApiRevisionContract
    {
        /// <summary> Initializes a new instance of ApiRevisionContract. </summary>
        internal ApiRevisionContract()
        {
        }

        /// <summary> Initializes a new instance of ApiRevisionContract. </summary>
        /// <param name="apiId"> Identifier of the API Revision. </param>
        /// <param name="apiRevision"> Revision number of API. </param>
        /// <param name="createdOn"> The time the API Revision was created. The date conforms to the following format: yyyy-MM-ddTHH:mm:ssZ as specified by the ISO 8601 standard. </param>
        /// <param name="updatedOn"> The time the API Revision were updated. The date conforms to the following format: yyyy-MM-ddTHH:mm:ssZ as specified by the ISO 8601 standard. </param>
        /// <param name="description"> Description of the API Revision. </param>
        /// <param name="privateUriString"> Gateway URL for accessing the non-current API Revision. </param>
        /// <param name="isOnline"> Indicates if API revision is the current api revision. </param>
        /// <param name="isCurrent"> Indicates if API revision is accessible via the gateway. </param>
        internal ApiRevisionContract(string apiId, string apiRevision, DateTimeOffset? createdOn, DateTimeOffset? updatedOn, string description, string privateUriString, bool? isOnline, bool? isCurrent)
        {
            ApiId = apiId;
            ApiRevision = apiRevision;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            Description = description;
            PrivateUriString = privateUriString;
            IsOnline = isOnline;
            IsCurrent = isCurrent;
        }

        /// <summary> Identifier of the API Revision. </summary>
        public string ApiId { get; }
        /// <summary> Revision number of API. </summary>
        public string ApiRevision { get; }
        /// <summary> The time the API Revision was created. The date conforms to the following format: yyyy-MM-ddTHH:mm:ssZ as specified by the ISO 8601 standard. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The time the API Revision were updated. The date conforms to the following format: yyyy-MM-ddTHH:mm:ssZ as specified by the ISO 8601 standard. </summary>
        public DateTimeOffset? UpdatedOn { get; }
        /// <summary> Description of the API Revision. </summary>
        public string Description { get; }
        /// <summary> Gateway URL for accessing the non-current API Revision. </summary>
        public string PrivateUriString { get; }
        /// <summary> Indicates if API revision is the current api revision. </summary>
        public bool? IsOnline { get; }
        /// <summary> Indicates if API revision is accessible via the gateway. </summary>
        public bool? IsCurrent { get; }
    }
}
