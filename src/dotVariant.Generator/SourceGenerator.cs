using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace dotVariant.Generator
{
    [Generator]
    public sealed class SourceGenerator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            var receiver = (SyntaxReceiver)context.SyntaxContextReceiver!;

            var decls =
                receiver
                .VariantDecls
                .Select(decl => (decl.Symbol, decl.Syntax, Diags: Diagnose.Variant(decl.Symbol, decl.Syntax, context.CancellationToken)))
                .Memoize();

            decls
                .SelectMany(desc => desc.Diags)
                .ForEach(context.ReportDiagnostic);

            decls
                .Where(decl => !decl.Diags.Any(d => d.Severity == DiagnosticSeverity.Error))
                .Select(decl => Descriptor.FromDeclaration(context, decl.Symbol, decl.Syntax))
                .ForEach(desc => context.AddSource(desc.Type.ToDisplayString(), Renderer.Render(context, desc)));
        }

        public void Initialize(GeneratorInitializationContext context)
        {
            context.RegisterForSyntaxNotifications(() => new SyntaxReceiver());
        }

        private sealed class SyntaxReceiver : ISyntaxContextReceiver
        {
            public List<(ITypeSymbol Symbol, TypeDeclarationSyntax Syntax)> VariantDecls { get; } = new();

            public void OnVisitSyntaxNode(GeneratorSyntaxContext context)
            {
                if (context.Node is not TypeDeclarationSyntax tds || tds.AttributeLists.IsEmpty())
                {
                    return;
                }

                var sema = context.SemanticModel;

                if (sema.GetDeclaredSymbol(tds) is not ITypeSymbol symbol)
                {
                    return;
                }

                const string attributeName = nameof(dotVariant) + "." + nameof(VariantAttribute);
                if (symbol.GetAttributes().Any(a => a.AttributeClass?.ToDisplayString() == attributeName))
                {
                    VariantDecls.Add((symbol, tds));
                }
            }
        }
    }
}
