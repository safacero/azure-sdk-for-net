// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> The DigitalTwinInterfacesPatchInterfacesPropertiesAdditionalPropertiesDesired. </summary>
    public partial class DigitalTwinInterfacesPatchInterfacesPropertiesAdditionalPropertiesDesired
    {
        /// <summary> Initializes a new instance of DigitalTwinInterfacesPatchInterfacesPropertiesAdditionalPropertiesDesired. </summary>
        public DigitalTwinInterfacesPatchInterfacesPropertiesAdditionalPropertiesDesired()
        {
        }

        /// <summary> Initializes a new instance of DigitalTwinInterfacesPatchInterfacesPropertiesAdditionalPropertiesDesired. </summary>
        /// <param name="value"> The desired value of the interface property to set in a digitalTwin. </param>
        internal DigitalTwinInterfacesPatchInterfacesPropertiesAdditionalPropertiesDesired(object value)
        {
            Value = value;
        }

        /// <summary> The desired value of the interface property to set in a digitalTwin. </summary>
        public object Value { get; set; }
    }
}
