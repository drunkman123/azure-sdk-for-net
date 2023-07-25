// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Model class for provider specific details for an event.
    /// Please note <see cref="SiteRecoveryEventProviderSpecificDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="A2AEventDetails"/>, <see cref="HyperVReplica2012EventDetails"/>, <see cref="HyperVReplica2012R2EventDetails"/>, <see cref="HyperVReplicaAzureEventDetails"/>, <see cref="HyperVReplicaBaseEventDetails"/>, <see cref="InMageAzureV2EventDetails"/>, <see cref="InMageRcmEventDetails"/>, <see cref="InMageRcmFailbackEventDetails"/> and <see cref="VMwareCbtEventDetails"/>.
    /// </summary>
    public abstract partial class SiteRecoveryEventProviderSpecificDetails
    {
        /// <summary> Initializes a new instance of SiteRecoveryEventProviderSpecificDetails. </summary>
        protected SiteRecoveryEventProviderSpecificDetails()
        {
        }

        /// <summary> Initializes a new instance of SiteRecoveryEventProviderSpecificDetails. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        internal SiteRecoveryEventProviderSpecificDetails(string instanceType)
        {
            InstanceType = instanceType;
        }

        /// <summary> Gets the class type. Overridden in derived classes. </summary>
        internal string InstanceType { get; set; }
    }
}
