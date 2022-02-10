using IdentityServer4.Validation;
using System.Collections.Generic;

namespace IdentityServer4.Anonnymous.Models
{
    public class ValidatedAnonnymousAuthorizationRequest : ValidatedRequest
    {
        /// <summary>
        /// Gets or sets the requested scopes.
        /// </summary>
        /// <value>
        /// The scopes.
        /// </value>
        public IEnumerable<string> RequestedScopes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is open identifier request.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is open identifier request; otherwise, <c>false</c>.
        /// </value>
        public bool IsOpenIdRequest { get; set; }

        /// <summary>
        /// Gets the description the user assigned to the device being authorized.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }
        public string Provider { get; set; }
        public string Transport { get; set; }
        public string TransportData { get; set; }
        public string State { get; set; }
        public string RedirectUrl { get; set; }
        public string VerificationUri { get; set; }
    }
}