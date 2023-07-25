// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The Metric. </summary>
    public partial class DataFeedMetric
    {
        /// <summary> Initializes a new instance of DataFeedMetric. </summary>
        /// <param name="id"> metric id. </param>
        /// <param name="name"> metric name. </param>
        /// <param name="displayName"> metric display name. </param>
        /// <param name="description"> metric description. </param>
        internal DataFeedMetric(string id, string name, string displayName, string description)
        {
            Id = id;
            Name = name;
            DisplayName = displayName;
            Description = description;
        }
    }
}
