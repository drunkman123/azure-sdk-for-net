// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace System.Net.ClientModel.Tests.Client.Models.ResourceManager.Resources
{
    /// <summary> The type of the pattern for an alias path. </summary>
    public partial class ResourceTypeAliasPattern
    {
        /// <summary> Initializes a new instance of ResourceTypeAliasPattern. </summary>
        internal ResourceTypeAliasPattern()
        {
        }

        /// <summary> Initializes a new instance of ResourceTypeAliasPattern. </summary>
        /// <param name="phrase"> The alias pattern phrase. </param>
        /// <param name="variable"> The alias pattern variable. </param>
        /// <param name="patternType"> The type of alias pattern. </param>
        internal ResourceTypeAliasPattern(string phrase, string variable, ResourceTypeAliasPatternType? patternType)
        {
            Phrase = phrase;
            Variable = variable;
            PatternType = patternType;
        }

        /// <summary> The alias pattern phrase. </summary>
        public string Phrase { get; }
        /// <summary> The alias pattern variable. </summary>
        public string Variable { get; }
        /// <summary> The type of alias pattern. </summary>
        public ResourceTypeAliasPatternType? PatternType { get; }
    }
}
