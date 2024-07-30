// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> Cluster principal role. </summary>
    public readonly partial struct KustoClusterPrincipalRole : IEquatable<KustoClusterPrincipalRole>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KustoClusterPrincipalRole"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KustoClusterPrincipalRole(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllDatabasesAdminValue = "AllDatabasesAdmin";
        private const string AllDatabasesViewerValue = "AllDatabasesViewer";

        /// <summary> AllDatabasesAdmin. </summary>
        public static KustoClusterPrincipalRole AllDatabasesAdmin { get; } = new KustoClusterPrincipalRole(AllDatabasesAdminValue);
        /// <summary> AllDatabasesViewer. </summary>
        public static KustoClusterPrincipalRole AllDatabasesViewer { get; } = new KustoClusterPrincipalRole(AllDatabasesViewerValue);
        /// <summary> Determines if two <see cref="KustoClusterPrincipalRole"/> values are the same. </summary>
        public static bool operator ==(KustoClusterPrincipalRole left, KustoClusterPrincipalRole right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KustoClusterPrincipalRole"/> values are not the same. </summary>
        public static bool operator !=(KustoClusterPrincipalRole left, KustoClusterPrincipalRole right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KustoClusterPrincipalRole"/>. </summary>
        public static implicit operator KustoClusterPrincipalRole(string value) => new KustoClusterPrincipalRole(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KustoClusterPrincipalRole other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KustoClusterPrincipalRole other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
