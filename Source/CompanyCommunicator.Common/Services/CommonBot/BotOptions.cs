﻿// <copyright file="BotOptions.cs" company="Microsoft">
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
// </copyright>

namespace Microsoft.Teams.Apps.CompanyCommunicator.Common.Services.CommonBot
{
    /// <summary>
    /// Options used for holding metadata for the bot.
    /// </summary>
    public class BotOptions
    {
        /// <summary>
        /// Gets or sets the Microsoft app ID for the user bot.
        /// </summary>
        public string UserAppId { get; set; }

        /// <summary>
        /// Gets or sets the Microsoft app password for the user bot.
        /// </summary>
        public string UserAppPassword { get; set; }

        /// <summary>
        /// Gets or sets the Microsoft app ID for the author bot.
        /// </summary>
        public string AuthorAppId { get; set; }

        /// <summary>
        /// Gets or sets the Microsoft app password for the author bot.
        /// </summary>
        public string AuthorAppPassword { get; set; }

        /// <summary>
        /// Gets or sets the TargetingEnabled flag for the author bot.
        /// </summary>
        public string TargetingEnabled { get; set; }

        /// <summary>
        /// Gets or sets the MasterAdminUpns flag for the author bot.
        /// </summary>
        public string MasterAdminUpns { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets the ImageUploadBlobStorage flag for the author bot.
        /// </summary>
        public bool ImageUploadBlobStorage { get; set; }
    }
}
