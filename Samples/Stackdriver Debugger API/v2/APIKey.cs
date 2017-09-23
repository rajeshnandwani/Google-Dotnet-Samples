﻿// Copyright 2017 DAIMTO ([Linda Lawton](https://twitter.com/LindaLawtonDK)) :  [www.daimto.com](http://www.daimto.com/)
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by DAIMTO-Google-apis-Sample-generator 1.0.0
//     Template File Name:  APIKey.tt
//     Build date: 2017-09-23
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Clouddebugger v2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Examines the call stack and variables of a running application without stopping or slowing it down.
// API Documentation Link http://cloud.google.com/debugger
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Clouddebugger/v2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Clouddebugger.v2/ 
// Install Command: PM>  Install-Package Google.Apis.Clouddebugger.v2
//
//------------------------------------------------------------------------------  
using Google.Apis.Clouddebugger.v2;
using Google.Apis.Services;
using System;

namespace GoogleSamplecSharpSample.Clouddebuggerv2.Auth
{
    /// <summary>
	/// When calling APIs that do not access private user data, you can use simple API keys. These keys are used to authenticate your 
    /// application for accounting purposes. The Google API Console documentation also describes API keys.
    /// https://support.google.com/cloud/answer/6158857
    /// </summary>
    public static class ApiKeyExample
    {
        /// <summary>
        /// Get a valid ClouddebuggerService for a public API Key.
        /// </summary>
        /// <param name="apiKey">API key from Google Developer console</param>
		/// <returns>ClouddebuggerService</returns>
        public static ClouddebuggerService GetService(string apiKey)
        {
            try
            {
                if (string.IsNullOrEmpty(apiKey))
                    throw new ArgumentNullException("api Key");

                return new ClouddebuggerService(new BaseClientService.Initializer()
                {
                    ApiKey = apiKey,
                    ApplicationName = string.Format("{0} API key example", System.Diagnostics.Process.GetCurrentProcess().ProcessName),
                });
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to create new Clouddebugger Service", ex);
            }
        }
    }
}