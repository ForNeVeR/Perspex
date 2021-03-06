﻿// Copyright (c) The Perspex Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

namespace Perspex.Input
{
    public interface IMouseDevice : IPointerDevice
    {
        Point Position { get; }
    }
}
