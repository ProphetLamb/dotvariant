//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

#nullable enable
namespace Foo
{
    public partial class Super
    {
        [dotVariant.Variant]
        public partial class Variant
        {
            static partial void VariantOf(int i, string s);
        }
    }
}
