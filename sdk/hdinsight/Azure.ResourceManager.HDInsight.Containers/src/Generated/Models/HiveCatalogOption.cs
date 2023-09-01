// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Hive Catalog Option. </summary>
    public partial class HiveCatalogOption
    {
        /// <summary> Initializes a new instance of HiveCatalogOption. </summary>
        /// <param name="catalogName"> Name of trino catalog which should use specified hive metastore. </param>
        /// <param name="metastoreDBConnectionPasswordSecret"> Secret reference name from secretsProfile.secrets containing password for database connection. </param>
        /// <param name="metastoreDBConnectionUriString"> Connection string for hive metastore database. </param>
        /// <param name="metastoreDBConnectionUserName"> User name for database connection. </param>
        /// <param name="metastoreWarehouseDir"> Metastore root directory URI, format: abfs[s]://&lt;container&gt;@&lt;account_name&gt;.dfs.core.windows.net/&lt;path&gt;. More details: https://docs.microsoft.com/en-us/azure/storage/blobs/data-lake-storage-introduction-abfs-uri. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="catalogName"/>, <paramref name="metastoreDBConnectionPasswordSecret"/>, <paramref name="metastoreDBConnectionUriString"/>, <paramref name="metastoreDBConnectionUserName"/> or <paramref name="metastoreWarehouseDir"/> is null. </exception>
        public HiveCatalogOption(string catalogName, string metastoreDBConnectionPasswordSecret, string metastoreDBConnectionUriString, string metastoreDBConnectionUserName, string metastoreWarehouseDir)
        {
            Argument.AssertNotNull(catalogName, nameof(catalogName));
            Argument.AssertNotNull(metastoreDBConnectionPasswordSecret, nameof(metastoreDBConnectionPasswordSecret));
            Argument.AssertNotNull(metastoreDBConnectionUriString, nameof(metastoreDBConnectionUriString));
            Argument.AssertNotNull(metastoreDBConnectionUserName, nameof(metastoreDBConnectionUserName));
            Argument.AssertNotNull(metastoreWarehouseDir, nameof(metastoreWarehouseDir));

            CatalogName = catalogName;
            MetastoreDBConnectionPasswordSecret = metastoreDBConnectionPasswordSecret;
            MetastoreDBConnectionUriString = metastoreDBConnectionUriString;
            MetastoreDBConnectionUserName = metastoreDBConnectionUserName;
            MetastoreWarehouseDir = metastoreWarehouseDir;
        }

        /// <summary> Name of trino catalog which should use specified hive metastore. </summary>
        public string CatalogName { get; set; }
        /// <summary> Secret reference name from secretsProfile.secrets containing password for database connection. </summary>
        public string MetastoreDBConnectionPasswordSecret { get; set; }
        /// <summary> Connection string for hive metastore database. </summary>
        public string MetastoreDBConnectionUriString { get; set; }
        /// <summary> User name for database connection. </summary>
        public string MetastoreDBConnectionUserName { get; set; }
        /// <summary> Metastore root directory URI, format: abfs[s]://&lt;container&gt;@&lt;account_name&gt;.dfs.core.windows.net/&lt;path&gt;. More details: https://docs.microsoft.com/en-us/azure/storage/blobs/data-lake-storage-introduction-abfs-uri. </summary>
        public string MetastoreWarehouseDir { get; set; }
    }
}
