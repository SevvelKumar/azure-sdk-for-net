// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Managed service identity.
    /// </summary>
    public partial class Identity
    {
        /// <summary>
        /// Initializes a new instance of the Identity class.
        /// </summary>
        public Identity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Identity class.
        /// </summary>
        /// <param name="type">Type of managed service identity. Possible
        /// values include: 'None', 'SystemAssigned', 'UserAssigned'</param>
        /// <param name="tenantId">Tenant of managed service identity.</param>
        /// <param name="principalId">Principal Id of managed service
        /// identity.</param>
        /// <param name="userAssignedIdentities">The list of user assigned
        /// identities associated with the resource. The user identity
        /// dictionary key references will be ARM resource ids in the form:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}</param>
        public Identity(IdentityType? type = default(IdentityType?), string tenantId = default(string), string principalId = default(string), IDictionary<string, UserAssignedIdentity> userAssignedIdentities = default(IDictionary<string, UserAssignedIdentity>))
        {
            Type = type;
            TenantId = tenantId;
            PrincipalId = principalId;
            UserAssignedIdentities = userAssignedIdentities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type of managed service identity. Possible values
        /// include: 'None', 'SystemAssigned', 'UserAssigned'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public IdentityType? Type { get; set; }

        /// <summary>
        /// Gets tenant of managed service identity.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; private set; }

        /// <summary>
        /// Gets principal Id of managed service identity.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; private set; }

        /// <summary>
        /// Gets or sets the list of user assigned identities associated with
        /// the resource. The user identity dictionary key references will be
        /// ARM resource ids in the form:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}
        /// </summary>
        [JsonProperty(PropertyName = "userAssignedIdentities")]
        public IDictionary<string, UserAssignedIdentity> UserAssignedIdentities { get; set; }

    }
}