// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Failed validation result details. </summary>
    public partial class ValidationResponseErrorInfo
    {
        /// <summary> Initializes a new instance of ValidationResponseErrorInfo. </summary>
        internal ValidationResponseErrorInfo()
        {
        }

        /// <summary> Initializes a new instance of ValidationResponseErrorInfo. </summary>
        /// <param name="code"> Error code indicating why validation failed. </param>
        /// <param name="message"> Message indicating why validation failed. </param>
        internal ValidationResponseErrorInfo(string code, string message)
        {
            Code = code;
            Message = message;
        }

        /// <summary> Error code indicating why validation failed. </summary>
        public string Code { get; }
        /// <summary> Message indicating why validation failed. </summary>
        public string Message { get; }
    }
}
