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
//     Template File Name:  methodTemplate.tt
//     Build date: 07/06/2017 15:31:22
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Servicecontrol v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Google Service Control provides control plane functionality to managed services, such as logging, monitoring, and status checks.
// API Documentation Link https://cloud.google.com/service-control/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Servicecontrol/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Servicecontrol.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Servicecontrol.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Servicecontrol.v1;
using Google.Apis.Servicecontrol.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Servicecontrolv1.Methods
{
  
    public static class ServicesSample
    {


        /// <summary>
        /// Checks an operation with Google Service Control to decide whetherthe given operation should proceed. It should be called before theoperation is executed.If feasible, the client should cache the check results and reuse them for60 seconds. In case of server errors, the client can rely on the cachedresults for longer time.NOTE: the `CheckRequest` has the size limit of 64KB.This method requires the `servicemanagement.services.check` permissionon the specified service. For more information, see[Google Cloud IAM](https://cloud.google.com/iam). 
        /// Documentation https://developers.google.com/servicecontrol/v1/reference/services/check
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Servicecontrol service.</param>  
        /// <param name="serviceName">The service name as specified in its service configuration. For example,`"pubsub.googleapis.com"`.See google.api.Service for the definition of a service name.</param>
        /// <param name="body">A valid Servicecontrol v1 body.</param>
        /// <returns>CheckResponseResponse</returns>
        public static CheckResponse Check(ServicecontrolService service, string serviceName, CheckRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (serviceName == null)
                    throw new ArgumentNullException(serviceName);

                // Make the request.
                return service.Services.Check(body, serviceName).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Services.Check failed.", ex);
            }
        }

        /// <summary>
        /// Releases previously allocated quota done through AllocateQuota method.This method requires the `servicemanagement.services.quota`permission on the specified service. For more information, see[Google Cloud IAM](https://cloud.google.com/iam).**NOTE:** the client code **must** fail-open if the server returns oneof the following quota errors:-   `PROJECT_STATUS_UNAVAILABLE`-   `SERVICE_STATUS_UNAVAILABLE`-   `BILLING_STATUS_UNAVAILABLE`-   `QUOTA_SYSTEM_UNAVAILABLE`The server may inject above errors to prohibit any hard dependencyon the quota system. 
        /// Documentation https://developers.google.com/servicecontrol/v1/reference/services/releaseQuota
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Servicecontrol service.</param>  
        /// <param name="serviceName">Name of the service as specified in the service configuration. For example,`"pubsub.googleapis.com"`.See google.api.Service for the definition of a service name.</param>
        /// <param name="body">A valid Servicecontrol v1 body.</param>
        /// <returns>ReleaseQuotaResponseResponse</returns>
        public static ReleaseQuotaResponse ReleaseQuota(ServicecontrolService service, string serviceName, ReleaseQuotaRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (serviceName == null)
                    throw new ArgumentNullException(serviceName);

                // Make the request.
                return service.Services.ReleaseQuota(body, serviceName).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Services.ReleaseQuota failed.", ex);
            }
        }

        /// <summary>
        /// Signals the quota controller that service ends the ongoing usagereconciliation.This method requires the `servicemanagement.services.quota`permission on the specified service. For more information, see[Google Cloud IAM](https://cloud.google.com/iam). 
        /// Documentation https://developers.google.com/servicecontrol/v1/reference/services/endReconciliation
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Servicecontrol service.</param>  
        /// <param name="serviceName">Name of the service as specified in the service configuration. For example,`"pubsub.googleapis.com"`.See google.api.Service for the definition of a service name.</param>
        /// <param name="body">A valid Servicecontrol v1 body.</param>
        /// <returns>EndReconciliationResponseResponse</returns>
        public static EndReconciliationResponse EndReconciliation(ServicecontrolService service, string serviceName, EndReconciliationRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (serviceName == null)
                    throw new ArgumentNullException(serviceName);

                // Make the request.
                return service.Services.EndReconciliation(body, serviceName).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Services.EndReconciliation failed.", ex);
            }
        }

        /// <summary>
        /// Reports operation results to Google Service Control, such as logs andmetrics. It should be called after an operation is completed.If feasible, the client should aggregate reporting data for up to 5seconds to reduce API traffic. Limiting aggregation to 5 seconds is toreduce data loss during client crashes. Clients should carefully choosethe aggregation time window to avoid data loss risk more than 0.01%for business and compliance reasons.NOTE: the `ReportRequest` has the size limit of 1MB.This method requires the `servicemanagement.services.report` permissionon the specified service. For more information, see[Google Cloud IAM](https://cloud.google.com/iam). 
        /// Documentation https://developers.google.com/servicecontrol/v1/reference/services/report
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Servicecontrol service.</param>  
        /// <param name="serviceName">The service name as specified in its service configuration. For example,`"pubsub.googleapis.com"`.See google.api.Service for the definition of a service name.</param>
        /// <param name="body">A valid Servicecontrol v1 body.</param>
        /// <returns>ReportResponseResponse</returns>
        public static ReportResponse Report(ServicecontrolService service, string serviceName, ReportRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (serviceName == null)
                    throw new ArgumentNullException(serviceName);

                // Make the request.
                return service.Services.Report(body, serviceName).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Services.Report failed.", ex);
            }
        }

        /// <summary>
        /// Attempts to allocate quota for the specified consumer. It should be calledbefore the operation is executed.This method requires the `servicemanagement.services.quota`permission on the specified service. For more information, see[Google Cloud IAM](https://cloud.google.com/iam).**NOTE:** the client code **must** fail-open if the server returns oneof the following quota errors:-   `PROJECT_STATUS_UNAVAILABLE`-   `SERVICE_STATUS_UNAVAILABLE`-   `BILLING_STATUS_UNAVAILABLE`-   `QUOTA_SYSTEM_UNAVAILABLE`The server may inject above errors to prohibit any hard dependencyon the quota system. 
        /// Documentation https://developers.google.com/servicecontrol/v1/reference/services/allocateQuota
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Servicecontrol service.</param>  
        /// <param name="serviceName">Name of the service as specified in the service configuration. For example,`"pubsub.googleapis.com"`.See google.api.Service for the definition of a service name.</param>
        /// <param name="body">A valid Servicecontrol v1 body.</param>
        /// <returns>AllocateQuotaResponseResponse</returns>
        public static AllocateQuotaResponse AllocateQuota(ServicecontrolService service, string serviceName, AllocateQuotaRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (serviceName == null)
                    throw new ArgumentNullException(serviceName);

                // Make the request.
                return service.Services.AllocateQuota(body, serviceName).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Services.AllocateQuota failed.", ex);
            }
        }

        /// <summary>
        /// Unlike rate quota, allocation quota does not get refilled periodically.So, it is possible that the quota usage as seen by the service differs fromwhat the One Platform considers the usage is. This is expected to happenonly rarely, but over time this can accumulate. Services can invokeStartReconciliation and EndReconciliation to correct this usage drift, asdescribed below:1. Service sends StartReconciliation with a timestamp in future for each   metric that needs to be reconciled. The timestamp being in future allows   to account for in-flight AllocateQuota and ReleaseQuota requests for the   same metric.2. One Platform records this timestamp and starts tracking subsequent   AllocateQuota and ReleaseQuota requests until EndReconciliation is   called.3. At or after the time specified in the StartReconciliation, service   sends EndReconciliation with the usage that needs to be reconciled to.4. One Platform adjusts its own record of usage for that metric to the   value specified in EndReconciliation by taking in to account any   allocation or release between StartReconciliation and EndReconciliation.Signals the quota controller that the service wants to perform a usagereconciliation as specified in the request.This method requires the `servicemanagement.services.quota`permission on the specified service. For more information, see[Google Cloud IAM](https://cloud.google.com/iam). 
        /// Documentation https://developers.google.com/servicecontrol/v1/reference/services/startReconciliation
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Servicecontrol service.</param>  
        /// <param name="serviceName">Name of the service as specified in the service configuration. For example,`"pubsub.googleapis.com"`.See google.api.Service for the definition of a service name.</param>
        /// <param name="body">A valid Servicecontrol v1 body.</param>
        /// <returns>StartReconciliationResponseResponse</returns>
        public static StartReconciliationResponse StartReconciliation(ServicecontrolService service, string serviceName, StartReconciliationRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (serviceName == null)
                    throw new ArgumentNullException(serviceName);

                // Make the request.
                return service.Services.StartReconciliation(body, serviceName).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Services.StartReconciliation failed.", ex);
            }
        }
        
        }

        public static class SampleHelpers
        {

        /// <summary>
        /// Using reflection to apply optional parameters to the request.  
        /// 
        /// If the optonal parameters are null then we will just return the request as is.
        /// </summary>
        /// <param name="request">The request. </param>
        /// <param name="optional">The optional parameters. </param>
        /// <returns></returns>
        public static object ApplyOptionalParms(object request, object optional)
        {
            if (optional == null)
                return request;

            System.Reflection.PropertyInfo[] optionalProperties = (optional.GetType()).GetProperties();

            foreach (System.Reflection.PropertyInfo property in optionalProperties)
            {
                // Copy value from optional parms to the request.  They should have the same names and datatypes.
                System.Reflection.PropertyInfo piShared = (request.GetType()).GetProperty(property.Name);
				if (property.GetValue(optional, null) != null) // TODO Test that we do not add values for items that are null
					piShared.SetValue(request, property.GetValue(optional, null), null);
            }

            return request;
        }
    }
}