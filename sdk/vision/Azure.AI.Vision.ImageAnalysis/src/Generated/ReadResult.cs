// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.Vision.ImageAnalysis
{
    /// <summary> The results of an Read operation. </summary>
    public partial class ReadResult
    {
        /// <summary> Initializes a new instance of ReadResult. </summary>
        /// <param name="content"> Concatenate string representation of all textual and visual elements in reading order. </param>
        /// <param name="pages"> A list of analyzed pages. </param>
        /// <param name="stringIndexType"> The method used to compute string offset and length, possible values include: 'textElements', 'unicodeCodePoint', 'utf16CodeUnit' etc. </param>
        /// <param name="styles"> Extracted font styles. </param>
        /// <param name="modelVersion"> The model used to generate the Read result. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/>, <paramref name="pages"/>, <paramref name="stringIndexType"/>, <paramref name="styles"/> or <paramref name="modelVersion"/> is null. </exception>
        internal ReadResult(string content, IEnumerable<DocumentPage> pages, string stringIndexType, IEnumerable<DocumentStyle> styles, string modelVersion)
        {
            Argument.AssertNotNull(content, nameof(content));
            Argument.AssertNotNull(pages, nameof(pages));
            Argument.AssertNotNull(stringIndexType, nameof(stringIndexType));
            Argument.AssertNotNull(styles, nameof(styles));
            Argument.AssertNotNull(modelVersion, nameof(modelVersion));

            Content = content;
            Pages = pages.ToList();
            StringIndexType = stringIndexType;
            Styles = styles.ToList();
            ModelVersion = modelVersion;
        }

        /// <summary> Initializes a new instance of ReadResult. </summary>
        /// <param name="content"> Concatenate string representation of all textual and visual elements in reading order. </param>
        /// <param name="pages"> A list of analyzed pages. </param>
        /// <param name="stringIndexType"> The method used to compute string offset and length, possible values include: 'textElements', 'unicodeCodePoint', 'utf16CodeUnit' etc. </param>
        /// <param name="styles"> Extracted font styles. </param>
        /// <param name="modelVersion"> The model used to generate the Read result. </param>
        internal ReadResult(string content, IReadOnlyList<DocumentPage> pages, string stringIndexType, IReadOnlyList<DocumentStyle> styles, string modelVersion)
        {
            Content = content;
            Pages = pages;
            StringIndexType = stringIndexType;
            Styles = styles;
            ModelVersion = modelVersion;
        }

        /// <summary> Concatenate string representation of all textual and visual elements in reading order. </summary>
        public string Content { get; }
        /// <summary> A list of analyzed pages. </summary>
        public IReadOnlyList<DocumentPage> Pages { get; }
        /// <summary> The method used to compute string offset and length, possible values include: 'textElements', 'unicodeCodePoint', 'utf16CodeUnit' etc. </summary>
        public string StringIndexType { get; }
        /// <summary> Extracted font styles. </summary>
        public IReadOnlyList<DocumentStyle> Styles { get; }
        /// <summary> The model used to generate the Read result. </summary>
        public string ModelVersion { get; }
    }
}
