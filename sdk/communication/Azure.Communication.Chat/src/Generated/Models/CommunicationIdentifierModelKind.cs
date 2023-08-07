// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication
{
    /// <summary> The identifier kind, for example 'communicationUser' or 'phoneNumber'. </summary>
    internal readonly partial struct CommunicationIdentifierModelKind : IEquatable<CommunicationIdentifierModelKind>
    {
        /// <summary> Determines if two <see cref="CommunicationIdentifierModelKind"/> values are the same. </summary>
        public static bool operator ==(CommunicationIdentifierModelKind left, CommunicationIdentifierModelKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CommunicationIdentifierModelKind"/> values are not the same. </summary>
        public static bool operator !=(CommunicationIdentifierModelKind left, CommunicationIdentifierModelKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CommunicationIdentifierModelKind"/>. </summary>
        public static implicit operator CommunicationIdentifierModelKind(string value) => new CommunicationIdentifierModelKind(value);
    }
}
