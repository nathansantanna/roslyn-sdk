﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace Microsoft.CodeAnalysis.Testing
{
    public enum StateInheritanceMode
    {
        /// <summary>
        /// The contents of the <see cref="SolutionState"/> may be explicitly specified, but unspecified elements of
        /// partially-specified state instances are inherited from another source.
        /// </summary>
        AutoInherit,

        /// <summary>
        /// The contents of the <see cref="SolutionState"/> are fully and explicitly specified.
        /// </summary>
        Explicit,
    }
}
