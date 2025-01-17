// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    /// <summary> Crypto keys list. </summary>
    internal partial class FirmwareCryptoKeyList
    {
        /// <summary> Initializes a new instance of <see cref="FirmwareCryptoKeyList"/>. </summary>
        internal FirmwareCryptoKeyList()
        {
            Value = new ChangeTrackingList<FirmwareCryptoKey>();
        }

        /// <summary> Initializes a new instance of <see cref="FirmwareCryptoKeyList"/>. </summary>
        /// <param name="value"> Crypto keys list. </param>
        /// <param name="nextLink"> The uri to fetch the next page of asset. </param>
        internal FirmwareCryptoKeyList(IReadOnlyList<FirmwareCryptoKey> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Crypto keys list. </summary>
        public IReadOnlyList<FirmwareCryptoKey> Value { get; }
        /// <summary> The uri to fetch the next page of asset. </summary>
        public string NextLink { get; }
    }
}
