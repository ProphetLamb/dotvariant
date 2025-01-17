//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Immutable;

namespace dotVariant.Generator
{
    public readonly record struct Descriptor(
        INamedTypeSymbol Type,
        TypeDeclarationSyntax Syntax,
        ImmutableArray<IParameterSymbol> Options,
        NullableContext NullableContext)
    {
        public static Descriptor FromDeclaration(
            INamedTypeSymbol type,
            TypeDeclarationSyntax syntax,
            NullableContext nullability)
        {
            var options = Inspect.GetOptions(type);
            return new(type, syntax, options, nullability);
        }

        public string HintName => $"{Type.ToString()
            // If the contains type parameters replace angle brackets as those are not allowed in AddSource()
            .Replace('<', '{')
            .Replace('>', '}')
            // Escaped names like @class or @event aren't supported either
            .Replace('@', '.')}.cs";
    }
}
