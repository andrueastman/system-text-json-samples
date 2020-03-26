﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


using System.Text.Json.Serialization;

namespace Microsoft.Graph
{

    /// <summary>
    /// The enum BodyType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BodyType
    {

        /// <summary>
        /// Text
        /// </summary>
        Text = 0,

        /// <summary>
        /// Html
        /// </summary>
        Html = 1,

    }
}