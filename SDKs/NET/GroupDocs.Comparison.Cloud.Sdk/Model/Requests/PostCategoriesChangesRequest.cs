// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PostCategoriesChangesRequest.cs">
//  Copyright (c) 2003-2017 Aspose Pty Ltd
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GroupDocs.Comparison.Cloud.Sdk.Model.Requests
{
    using GroupDocs.Comparison.Cloud.Sdk.Model;

    /// <summary>
    /// Request model for <see cref="GroupDocs.Comparison.Cloud.Sdk.Api.ComparisonApi.PostCategoriesChanges" /> operation.
    /// </summary>  
    public class PostCategoriesChangesRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostCategoriesChangesRequest"/> class.
        /// </summary>        
        public PostCategoriesChangesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCategoriesChangesRequest"/> class.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="categoriesType">Type of the categories.</param>
        public PostCategoriesChangesRequest(Model.ComparisonRequest request = null, string categoriesType = null)
        {
            this.Request = request;
            this.CategoriesType = categoriesType;
        }

        /// <summary>
        /// The request.
        /// </summary>  
        public Model.ComparisonRequest Request { get; set; }

        /// <summary>
        /// Type of the categories.
        /// </summary>  
        public string CategoriesType { get; set; }
    }
}