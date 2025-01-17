//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using System;

namespace dotVariant
{
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class NoImplicitConversionAttribute : Attribute
    {
        public NoImplicitConversionAttribute() { }
    }
}
