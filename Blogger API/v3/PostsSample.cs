﻿// Copyright 2017 DAIMTO :  www.daimto.com
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
//     Template File Name:  Methodtemplate.tt
//     Build date: 01/02/2017 22:31:59
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the blogger v3 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: API for access to the data within Blogger.
// API Documentation Link https://developers.google.com/blogger/docs/3.0/getting_started
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/blogger/v3/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.blogger.v3/ 
// Install Command: PM>  Install-Package Google.Apis.blogger.v3
//
//------------------------------------------------------------------------------  
using Google.Apis.blogger.v3;
using Google.Apis.blogger.v3.Data;
using System;

namespace GoogleSamplecSharpSample.bloggerv3.Methods
{
  
    public static class PostsSample
    {


        /// <summary>
        /// Delete a post by ID. 
        /// Documentation https://developers.google.com/blogger/v3/reference/posts/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated blogger service.</param>  
        /// <param name="blogId">The ID of the Blog.</param>
        /// <param name="postId">The ID of the Post.</param>
        public static void Delete(bloggerService service, string blogId, string postId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (blogId == null)
                    throw new ArgumentNullException(blogId);
                if (postId == null)
                    throw new ArgumentNullException(postId);

                // Make the request.
                return service.Posts.Delete(blogId, postId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Posts.Delete failed.", ex);
            }
        }

        public class PostsGetOptionalParms
        {
            /// Whether the body content of the post is included (default: true). This should be set to false when the post bodies are not required, to help minimize traffic.
            public bool FetchBody { get; set; }  
            /// Whether image URL metadata for each post is included (default: false).
            public bool FetchImages { get; set; }  
            /// Maximum number of comments to pull back on a post.
            public int MaxComments { get; set; }  
            /// Access level with which to view the returned result. Note that some fields require elevated access.
            public string View { get; set; }  
        
        }
 
        /// <summary>
        /// Get a post by ID. 
        /// Documentation https://developers.google.com/blogger/v3/reference/posts/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated blogger service.</param>  
        /// <param name="blogId">ID of the blog to fetch the post from.</param>
        /// <param name="postId">The ID of the post</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>PostResponse</returns>
        public static Post Get(bloggerService service, string blogId, string postId, PostsGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (blogId == null)
                    throw new ArgumentNullException(blogId);
                if (postId == null)
                    throw new ArgumentNullException(postId);

                // Building the initial request.
                var request = service.Posts.Get(blogId, postId);

                // Applying optional parameters to the request.                
                request = (PostsResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Posts.Get failed.", ex);
            }
        }

        public class PostsGetByPathOptionalParms
        {
            /// Maximum number of comments to pull back on a post.
            public int MaxComments { get; set; }  
            /// Access level with which to view the returned result. Note that some fields require elevated access.
            public string View { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieve a Post by Path. 
        /// Documentation https://developers.google.com/blogger/v3/reference/posts/getByPath
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated blogger service.</param>  
        /// <param name="blogId">ID of the blog to fetch the post from.</param>
        /// <param name="path">Path of the Post to retrieve.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>PostResponse</returns>
        public static Post GetByPath(bloggerService service, string blogId, string path, PostsGetByPathOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (blogId == null)
                    throw new ArgumentNullException(blogId);
                if (path == null)
                    throw new ArgumentNullException(path);

                // Building the initial request.
                var request = service.Posts.GetByPath(blogId, path);

                // Applying optional parameters to the request.                
                request = (PostsResource.GetByPathRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Posts.GetByPath failed.", ex);
            }
        }

        public class PostsInsertOptionalParms
        {
            /// Whether the body content of the post is included with the result (default: true).
            public bool FetchBody { get; set; }  
            /// Whether image URL metadata for each post is included in the returned result (default: false).
            public bool FetchImages { get; set; }  
            /// Whether to create the post as a draft (default: false).
            public bool IsDraft { get; set; }  
        
        }
 
        /// <summary>
        /// Add a post. 
        /// Documentation https://developers.google.com/blogger/v3/reference/posts/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated blogger service.</param>  
        /// <param name="blogId">ID of the blog to add the post to.</param>
        /// <param name="body">A valid blogger v3 body.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>PostResponse</returns>
        public static Post Insert(bloggerService service, string blogId, Post body, PostsInsertOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (blogId == null)
                    throw new ArgumentNullException(blogId);

                // Building the initial request.
                var request = service.Posts.Insert(body, blogId);

                // Applying optional parameters to the request.                
                request = (PostsResource.InsertRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Posts.Insert failed.", ex);
            }
        }

        public class PostsListOptionalParms
        {
            /// Latest post date to fetch, a date-time with RFC 3339 formatting.
            public string EndDate { get; set; }  
            /// Whether the body content of posts is included (default: true). This should be set to false when the post bodies are not required, to help minimize traffic.
            public bool FetchBodies { get; set; }  
            /// Whether image URL metadata for each post is included.
            public bool FetchImages { get; set; }  
            /// Comma-separated list of labels to search for.
            public string Labels { get; set; }  
            /// Maximum number of posts to fetch.
            public int MaxResults { get; set; }  
            /// Sort search results
            public string OrderBy { get; set; }  
            /// Continuation token if the request is paged.
            public string PageToken { get; set; }  
            /// Earliest post date to fetch, a date-time with RFC 3339 formatting.
            public string StartDate { get; set; }  
            /// Statuses to include in the results.
            public string Status { get; set; }  
            /// Access level with which to view the returned result. Note that some fields require escalated access.
            public string View { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves a list of posts, possibly filtered. 
        /// Documentation https://developers.google.com/blogger/v3/reference/posts/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated blogger service.</param>  
        /// <param name="blogId">ID of the blog to fetch posts from.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>PostListResponse</returns>
        public static PostList List(bloggerService service, string blogId, PostsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (blogId == null)
                    throw new ArgumentNullException(blogId);

                // Building the initial request.
                var request = service.Posts.List(blogId);

                // Applying optional parameters to the request.                
                request = (PostsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Posts.List failed.", ex);
            }
        }

        public class PostsPatchOptionalParms
        {
            /// Whether the body content of the post is included with the result (default: true).
            public bool FetchBody { get; set; }  
            /// Whether image URL metadata for each post is included in the returned result (default: false).
            public bool FetchImages { get; set; }  
            /// Maximum number of comments to retrieve with the returned post.
            public int MaxComments { get; set; }  
            /// Whether a publish action should be performed when the post is updated (default: false).
            public bool Publish { get; set; }  
            /// Whether a revert action should be performed when the post is updated (default: false).
            public bool Revert { get; set; }  
        
        }
 
        /// <summary>
        /// Update a post. This method supports patch semantics. 
        /// Documentation https://developers.google.com/blogger/v3/reference/posts/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated blogger service.</param>  
        /// <param name="blogId">The ID of the Blog.</param>
        /// <param name="postId">The ID of the Post.</param>
        /// <param name="body">A valid blogger v3 body.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>PostResponse</returns>
        public static Post Patch(bloggerService service, string blogId, string postId, Post body, PostsPatchOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (blogId == null)
                    throw new ArgumentNullException(blogId);
                if (postId == null)
                    throw new ArgumentNullException(postId);

                // Building the initial request.
                var request = service.Posts.Patch(body, blogId, postId);

                // Applying optional parameters to the request.                
                request = (PostsResource.PatchRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Posts.Patch failed.", ex);
            }
        }

        public class PostsPublishOptionalParms
        {
            /// Optional date and time to schedule the publishing of the Blog. If no publishDate parameter is given, the post is either published at the a previously saved schedule date (if present), or the current time. If a future date is given, the post will be scheduled to be published.
            public string PublishDate { get; set; }  
        
        }
 
        /// <summary>
        /// Publishes a draft post, optionally at the specific time of the given publishDate parameter. 
        /// Documentation https://developers.google.com/blogger/v3/reference/posts/publish
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated blogger service.</param>  
        /// <param name="blogId">The ID of the Blog.</param>
        /// <param name="postId">The ID of the Post.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>PostResponse</returns>
        public static Post Publish(bloggerService service, string blogId, string postId, PostsPublishOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (blogId == null)
                    throw new ArgumentNullException(blogId);
                if (postId == null)
                    throw new ArgumentNullException(postId);

                // Building the initial request.
                var request = service.Posts.Publish(blogId, postId);

                // Applying optional parameters to the request.                
                request = (PostsResource.PublishRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Posts.Publish failed.", ex);
            }
        }


        /// <summary>
        /// Revert a published or scheduled post to draft state. 
        /// Documentation https://developers.google.com/blogger/v3/reference/posts/revert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated blogger service.</param>  
        /// <param name="blogId">The ID of the Blog.</param>
        /// <param name="postId">The ID of the Post.</param>
        /// <returns>PostResponse</returns>
        public static Post Revert(bloggerService service, string blogId, string postId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (blogId == null)
                    throw new ArgumentNullException(blogId);
                if (postId == null)
                    throw new ArgumentNullException(postId);

                // Make the request.
                return service.Posts.Revert(blogId, postId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Posts.Revert failed.", ex);
            }
        }

        public class PostsSearchOptionalParms
        {
            /// Whether the body content of posts is included (default: true). This should be set to false when the post bodies are not required, to help minimize traffic.
            public bool FetchBodies { get; set; }  
            /// Sort search results
            public string OrderBy { get; set; }  
        
        }
 
        /// <summary>
        /// Search for a post. 
        /// Documentation https://developers.google.com/blogger/v3/reference/posts/search
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated blogger service.</param>  
        /// <param name="blogId">ID of the blog to fetch the post from.</param>
        /// <param name="q">Query terms to search this blog for matching posts.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>PostListResponse</returns>
        public static PostList Search(bloggerService service, string blogId, string q, PostsSearchOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (blogId == null)
                    throw new ArgumentNullException(blogId);
                if (q == null)
                    throw new ArgumentNullException(q);

                // Building the initial request.
                var request = service.Posts.Search(blogId, q);

                // Applying optional parameters to the request.                
                request = (PostsResource.SearchRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Posts.Search failed.", ex);
            }
        }

        public class PostsUpdateOptionalParms
        {
            /// Whether the body content of the post is included with the result (default: true).
            public bool FetchBody { get; set; }  
            /// Whether image URL metadata for each post is included in the returned result (default: false).
            public bool FetchImages { get; set; }  
            /// Maximum number of comments to retrieve with the returned post.
            public int MaxComments { get; set; }  
            /// Whether a publish action should be performed when the post is updated (default: false).
            public bool Publish { get; set; }  
            /// Whether a revert action should be performed when the post is updated (default: false).
            public bool Revert { get; set; }  
        
        }
 
        /// <summary>
        /// Update a post. 
        /// Documentation https://developers.google.com/blogger/v3/reference/posts/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated blogger service.</param>  
        /// <param name="blogId">The ID of the Blog.</param>
        /// <param name="postId">The ID of the Post.</param>
        /// <param name="body">A valid blogger v3 body.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>PostResponse</returns>
        public static Post Update(bloggerService service, string blogId, string postId, Post body, PostsUpdateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (blogId == null)
                    throw new ArgumentNullException(blogId);
                if (postId == null)
                    throw new ArgumentNullException(postId);

                // Building the initial request.
                var request = service.Posts.Update(body, blogId, postId);

                // Applying optional parameters to the request.                
                request = (PostsResource.UpdateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Posts.Update failed.", ex);
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