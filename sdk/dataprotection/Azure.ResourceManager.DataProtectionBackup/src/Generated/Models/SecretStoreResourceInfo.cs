// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Class representing a secret store resource. </summary>
    public partial class SecretStoreResourceInfo
    {
        /// <summary> Initializes a new instance of <see cref="SecretStoreResourceInfo"/>. </summary>
        /// <param name="secretStoreType"> Gets or sets the type of secret store. </param>
        public SecretStoreResourceInfo(SecretStoreType secretStoreType)
        {
            SecretStoreType = secretStoreType;
        }

        /// <summary> Initializes a new instance of <see cref="SecretStoreResourceInfo"/>. </summary>
        /// <param name="uri"> Uri to get to the resource. </param>
        /// <param name="secretStoreType"> Gets or sets the type of secret store. </param>
        /// <param name="value"> Gets or sets value stored in secret store resource. </param>
        internal SecretStoreResourceInfo(Uri uri, SecretStoreType secretStoreType, string value)
        {
            Uri = uri;
            SecretStoreType = secretStoreType;
            Value = value;
        }

        /// <summary> Uri to get to the resource. </summary>
        public Uri Uri { get; set; }
        /// <summary> Gets or sets the type of secret store. </summary>
        public SecretStoreType SecretStoreType { get; set; }
        /// <summary> Gets or sets value stored in secret store resource. </summary>
        public string Value { get; set; }
    }
}
