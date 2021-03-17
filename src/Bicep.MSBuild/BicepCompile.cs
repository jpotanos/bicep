// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Microsoft.Build.Utilities;
using System;

namespace Bicep.MSBuild
{
    public class BicepCompile : ToolTask
    {
        protected override string ToolName => throw new NotImplementedException();

        protected override string GenerateFullPathToTool()
        {
            throw new NotImplementedException();
        }
    }
}
