﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.Bot.Schema;
using Microsoft.Rest;

namespace Microsoft.Bot.Connector.Authentication
{
    /// <summary>
    /// Represents a Cloud Environment used to authenticate Bot Framework Protocol network calls within this environment.
    /// </summary>
    public interface ICloudEnvironment
    {
        /// <summary>
        /// Validate Bot Framework Protocol requests.
        /// </summary>
        /// <param name="activity">The inbound Activity.</param>
        /// <param name="authHeader">The http auth header.</param>
        /// <returns>Asynchronous Task with Authentication results.</returns>
        /// <exception cref="UnauthorizedAccessException">If the validation returns false.</exception>
        Task<(ClaimsIdentity claimsIdentity, ServiceClientCredentials credentials, string scope, string callerId)> AuthenticateRequestAsync(Activity activity, string authHeader);

        /// <summary>
        /// Get the credentials object needed to make a proactive call.
        /// </summary>
        /// <param name="claimsIdentity">The inbound Activity.</param>
        /// <param name="audience">The http auth header.</param>
        /// <returns>Asynchronous Task with Authentication results.</returns>
        Task<ServiceClientCredentials> GetProactiveCredentialsAsync(ClaimsIdentity claimsIdentity, string audience);
    }
}
