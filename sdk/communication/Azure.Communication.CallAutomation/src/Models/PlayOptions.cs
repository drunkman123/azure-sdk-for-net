﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.CallAutomation
{
    /// <summary>
    /// Options to be used in the Play operation.
    /// </summary>
    public class PlayOptions
    {
        /// <summary>
        /// PlaySource objects representing the sources to play.
        /// </summary>
        public IReadOnlyList<PlaySource> PlaySources { get; }

        /// <summary>
        /// A list of target identifiers to play the file to.
        /// </summary>
        public IReadOnlyList<CommunicationIdentifier> PlayTo { get; }

        /// <summary>
        /// The option to play the provided audio source in loop when set to true.
        /// </summary>
        public bool Loop { get; set; }

        /// <summary>
        /// The Operation Context.
        /// </summary>
        public string OperationContext { get; set; }

        /// <summary>
        /// The callback URI to override the main callback URI.
        /// </summary>
        public string OverrideCallbackUrl { get; set; }

        /// <summary>
        /// Creates a new PlayOptions object.
        /// </summary>
        public PlayOptions(IEnumerable<PlaySource> playSources, IEnumerable<CommunicationIdentifier> playTo)
        {
            PlaySources = playSources.ToList();
            PlayTo = playTo.ToList();
        }

        /// <summary>
        /// Creates a new PlayOptions object.
        /// </summary>
        public PlayOptions(PlaySource playSource, IEnumerable<CommunicationIdentifier> playTo)
        {
            PlaySources = new List<PlaySource> { playSource };
            PlayTo = playTo.ToList();
        }
    }
}
