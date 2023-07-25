// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.JobRouter
{
    /// <summary>
    /// An attachment which attaches worker selectors to a job
    /// Please note <see cref="WorkerSelectorAttachment"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ConditionalWorkerSelectorAttachment"/>, <see cref="PassThroughWorkerSelectorAttachment"/>, <see cref="RuleEngineWorkerSelectorAttachment"/>, <see cref="StaticWorkerSelectorAttachment"/> and <see cref="WeightedAllocationWorkerSelectorAttachment"/>.
    /// </summary>
    public abstract partial class WorkerSelectorAttachment
    {
        /// <summary> Initializes a new instance of WorkerSelectorAttachment. </summary>
        /// <param name="kind"> The type discriminator describing the type of worker selector attachment. </param>
        internal WorkerSelectorAttachment(string kind)
        {
            Kind = kind;
        }
    }
}
