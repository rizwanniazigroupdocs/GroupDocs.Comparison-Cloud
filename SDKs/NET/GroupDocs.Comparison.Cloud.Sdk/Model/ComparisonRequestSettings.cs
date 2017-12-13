// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ComparisonRequestSettings.cs">
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

namespace GroupDocs.Comparison.Cloud.Sdk.Model 
{
  using System;  
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// ComparisonRequestSettings dto
  /// </summary>  
  public class ComparisonRequestSettings 
  {                       
        /// <summary>
        /// The generate summary page
        /// </summary>  
        public bool? GenerateSummaryPage { get; set; }

        /// <summary>
        /// The show deleted content
        /// </summary>  
        public bool? ShowDeletedContent { get; set; }

        /// <summary>
        /// The style change detection
        /// </summary>  
        public bool? StyleChangeDetection { get; set; }

        /// <summary>
        /// The inserted items style
        /// </summary>  
        public StyleSettingsValues InsertedItemsStyle { get; set; }

        /// <summary>
        /// The deleted items style
        /// </summary>  
        public StyleSettingsValues DeletedItemsStyle { get; set; }

        /// <summary>
        /// The style changed items style
        /// </summary>  
        public StyleSettingsValues StyleChangedItemsStyle { get; set; }

        /// <summary>
        /// The words separator chars
        /// </summary>  
        public List<string> WordsSeparatorChars { get; set; }

        /// <summary>
        /// The use frames for delete ins elements
        /// </summary>  
        public bool? UseFramesForDelInsElements { get; set; }

        /// <summary>
        /// The detail level
        /// </summary>  
        public string DetailLevel { get; set; }

        /// <summary>
        /// The calculate component coordinates
        /// </summary>  
        public bool? CalculateComponentCoordinates { get; set; }

        /// <summary>
        /// The clone metadata
        /// </summary>  
        public string CloneMetadata { get; set; }

        /// <summary>
        /// The metadata
        /// </summary>  
        public ComparisonMetadataValues MetaData { get; set; }

        /// <summary>
        /// The password save option
        /// </summary>  
        public string PasswordSaveOption { get; set; }

        /// <summary>
        /// The password
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// The mark deleted inserted content deep
        /// </summary>  
        public bool? MarkDeletedInsertedContentDeep { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ComparisonRequestSettings {\n");
          sb.Append("  GenerateSummaryPage: ").Append(this.GenerateSummaryPage).Append("\n");
          sb.Append("  ShowDeletedContent: ").Append(this.ShowDeletedContent).Append("\n");
          sb.Append("  StyleChangeDetection: ").Append(this.StyleChangeDetection).Append("\n");
          sb.Append("  InsertedItemsStyle: ").Append(this.InsertedItemsStyle).Append("\n");
          sb.Append("  DeletedItemsStyle: ").Append(this.DeletedItemsStyle).Append("\n");
          sb.Append("  StyleChangedItemsStyle: ").Append(this.StyleChangedItemsStyle).Append("\n");
          sb.Append("  WordsSeparatorChars: ").Append(this.WordsSeparatorChars).Append("\n");
          sb.Append("  UseFramesForDelInsElements: ").Append(this.UseFramesForDelInsElements).Append("\n");
          sb.Append("  DetailLevel: ").Append(this.DetailLevel).Append("\n");
          sb.Append("  CalculateComponentCoordinates: ").Append(this.CalculateComponentCoordinates).Append("\n");
          sb.Append("  CloneMetadata: ").Append(this.CloneMetadata).Append("\n");
          sb.Append("  MetaData: ").Append(this.MetaData).Append("\n");
          sb.Append("  PasswordSaveOption: ").Append(this.PasswordSaveOption).Append("\n");
          sb.Append("  Password: ").Append(this.Password).Append("\n");
          sb.Append("  MarkDeletedInsertedContentDeep: ").Append(this.MarkDeletedInsertedContentDeep).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
