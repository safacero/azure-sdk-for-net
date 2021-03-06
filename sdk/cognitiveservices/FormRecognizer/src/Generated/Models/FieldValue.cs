// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.FormRecognizer.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Base class representing a recognized field value.
    /// </summary>
    [Newtonsoft.Json.JsonObject("fieldValue")]
    public partial class FieldValue
    {
        /// <summary>
        /// Initializes a new instance of the FieldValue class.
        /// </summary>
        public FieldValue()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FieldValue class.
        /// </summary>
        /// <param name="text">OCR text content of the recognized
        /// field.</param>
        /// <param name="elements">List of references to OCR words comprising
        /// the recognized field value.</param>
        public FieldValue(string text = default(string), IList<ElementReference> elements = default(IList<ElementReference>))
        {
            Text = text;
            Elements = elements;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets OCR text content of the recognized field.
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets list of references to OCR words comprising the
        /// recognized field value.
        /// </summary>
        [JsonProperty(PropertyName = "elements")]
        public IList<ElementReference> Elements { get; set; }

    }
}
