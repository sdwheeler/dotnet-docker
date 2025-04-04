﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.DotNet.Docker.Tests;

public class WindowsImageTheoryAttribute : DotNetTheoryAttribute
{
    public WindowsImageTheoryAttribute()
    {
        if (DockerHelper.IsLinuxContainerModeEnabled)
        {
            Skip = "Windows image test not applicable when running in Linux Container mode";
        }
    }
}
