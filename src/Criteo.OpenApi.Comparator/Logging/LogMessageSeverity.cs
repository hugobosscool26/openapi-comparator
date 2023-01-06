﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Criteo.OpenApi.Comparator.Logging
{
    /// <summary>
    /// Used to express to severity of detected change.
    /// this property is defined according to our own interpretation of the
    /// comparison rules and may differ according to your own interpretation.
    /// </summary>
    public enum Severity
    {
        /// <summary>
        /// The change hasn't any impact on the API (i.e. the version of the OAS is updated)
        /// </summary>
        Info,
        
        /// <summary>
        /// The change has an impact on the API, but should not break client's integration (i.e. adding an optional parameter)
        /// </summary>
        Warning,
        
        /// <summary>
        /// The change should be considered as a breaking change (i.e. updating the format of a response body)
        /// </summary>
        Error
    }
}
