﻿using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.DotNet.Try.Project.Generators;

namespace WorkspaceServer.Tests
{
    public static class CodeManipulation
    {
        public static (string processed, int markLocation) ProcessMarkup(string source)
        {
            // TODO: (ProcessMarkup) remove, use MarkupTestFile instead
            var normalised = source.EnforceLF();
            var markLocation = normalised.IndexOf("$$", StringComparison.InvariantCulture);
            var processed = normalised.Replace("$$", string.Empty);
            return (processed, markLocation);
        }
    }
}
