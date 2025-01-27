﻿namespace IdentityServer4.Anonymous.Services.Generators
{
    public class AuthorizationResponse
    {
        public int Lifetime { get; set; }
        public int Interval { get; set; }
        public string VerificationCode { get; set; }
        public string VerificationUri { get; set; }
        public string VerificationUriComplete { get; set; }
    }
}