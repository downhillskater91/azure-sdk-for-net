// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A request to check whether the specified name for a resource is
    /// available.
    /// </summary>
    public partial class CheckNameAvailabilityRequest
    {
        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityRequest
        /// class.
        /// </summary>
        public CheckNameAvailabilityRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityRequest
        /// class.
        /// </summary>
        /// <param name="name">The name whose availability is to be
        /// checked.</param>
        public CheckNameAvailabilityRequest(string name)
        {
            Name = name;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for CheckNameAvailabilityRequest class.
        /// </summary>
        static CheckNameAvailabilityRequest()
        {
            Type = "Microsoft.Sql/servers";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name whose availability is to be checked.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The type of resource that is used as the scope of the availability
        /// check.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public static string Type { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}