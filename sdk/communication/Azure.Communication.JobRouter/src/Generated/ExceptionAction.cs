// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.JobRouter
{
    /// <summary>
    /// The action to take when the exception is triggered
    /// Please note <see cref="ExceptionAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="CancelExceptionAction"/>, <see cref="ManualReclassifyExceptionAction"/> and <see cref="ReclassifyExceptionAction"/>.
    /// </summary>
    public abstract partial class ExceptionAction
    {
        /// <summary> Initializes a new instance of ExceptionAction. </summary>
        protected ExceptionAction()
        {
        }

        /// <summary> Initializes a new instance of ExceptionAction. </summary>
        /// <param name="id"> Unique Id of the exception action. </param>
        /// <param name="kind"> The type discriminator describing a sub-type of ExceptionAction. </param>
        internal ExceptionAction(string id, string kind)
        {
            Id = id;
            Kind = kind;
        }

        /// <summary> Unique Id of the exception action. </summary>
        public string Id { get; }
    }
}
