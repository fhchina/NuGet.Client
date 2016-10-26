﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace NuGet.SolutionRestoreManager
{
    /// <summary>
    /// Root object containing project restore info.
    /// Implementation of <see cref="IVsProjectRestoreInfo"/> for internal consumption.
    /// Used solely by <see cref="ProjectRestoreInfoBuilder"/>.
    /// </summary>
    internal class VsProjectRestoreInfo : IVsProjectRestoreInfo
    {
        public String BaseIntermediatePath { get; }

        public string OriginalTargetFrameworks { get; }

        public IVsTargetFrameworks TargetFrameworks { get; }

        public IVsReferenceItems ToolReferences { get; }

        public VsProjectRestoreInfo(string baseIntermediatePath, IVsTargetFrameworks targetFrameworks)
        {
            if (string.IsNullOrEmpty(baseIntermediatePath))
            {
                throw new ArgumentException(ProjectManagement.Strings.Argument_Cannot_Be_Null_Or_Empty, nameof(baseIntermediatePath));
            }

            if (targetFrameworks == null)
            {
                throw new ArgumentNullException(nameof(targetFrameworks));
            }

            BaseIntermediatePath = baseIntermediatePath;
            TargetFrameworks = targetFrameworks;
        }
    }
}