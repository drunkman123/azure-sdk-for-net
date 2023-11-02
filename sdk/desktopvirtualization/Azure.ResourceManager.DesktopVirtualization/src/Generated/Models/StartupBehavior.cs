// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> The desired startup behavior during the ramp up period for personal vms in the hostpool. </summary>
    public readonly partial struct StartupBehavior : IEquatable<StartupBehavior>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StartupBehavior"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StartupBehavior(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string WithAssignedUserValue = "WithAssignedUser";
        private const string AllValue = "All";

        /// <summary> Session hosts will not be started by the service. This setting depends on Start VM on Connect to be enabled to start the session hosts. </summary>
        public static StartupBehavior None { get; } = new StartupBehavior(NoneValue);
        /// <summary> Session hosts with an assigned user will be started during Ramp Up. </summary>
        public static StartupBehavior WithAssignedUser { get; } = new StartupBehavior(WithAssignedUserValue);
        /// <summary> All personal session hosts in the hostpool will be started during ramp up. </summary>
        public static StartupBehavior All { get; } = new StartupBehavior(AllValue);
        /// <summary> Determines if two <see cref="StartupBehavior"/> values are the same. </summary>
        public static bool operator ==(StartupBehavior left, StartupBehavior right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StartupBehavior"/> values are not the same. </summary>
        public static bool operator !=(StartupBehavior left, StartupBehavior right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StartupBehavior"/>. </summary>
        public static implicit operator StartupBehavior(string value) => new StartupBehavior(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StartupBehavior other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StartupBehavior other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
