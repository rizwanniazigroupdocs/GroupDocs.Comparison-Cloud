﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PutChangesImagesRequest.cs">
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
    /// Request model for <see cref="GroupDocs.Comparison.Cloud.Sdk.Api.ComparisonApi.PutChangesImages" /> operation.
    /// </summary>  
    public class PutChangesImagesRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutChangesImagesRequest"/> class.
        /// </summary>        
        public PutChangesImagesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutChangesImagesRequest"/> class.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="outFolder">outFolder: path to output folder on file storage</param>
        public PutChangesImagesRequest(ComparisonRequest request = null, string outFolder = null)
        {
            this.Request = request;
            this.OutFolder = outFolder;
        }

        /// <summary>
        /// The request.
        /// </summary>  
        public ComparisonRequest Request { get; set; }

        /// <summary>
        /// outFolder: path to output folder on file storage
        /// </summary>  
        public string OutFolder { get; set; }
    }
}
