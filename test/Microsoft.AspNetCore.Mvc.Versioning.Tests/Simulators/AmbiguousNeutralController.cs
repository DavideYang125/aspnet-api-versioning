﻿namespace Microsoft.AspNetCore.Mvc.Versioning
{
    using System;
    using System.Threading.Tasks;

    [ApiVersionNeutral]
    [ControllerName( "Ambiguous" )]
    public sealed class AmbiguousNeutralController : Controller
    {
        public Task<string> Get() => Task.FromResult( "Test" );
    }
}
