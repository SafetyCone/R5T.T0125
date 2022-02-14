using System;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0125.T001;

using Instances = R5T.T0125.X002.Instances;


namespace System
{
    public static class CompilationUnitSyntaxExtensions
    {
        public static async Task<UsingDirectivesSpecification> GetUsingDirectivesSpecification(this CompilationUnitSyntax compilationUnit,
            IUsingNameAliasDirectiveBlockLabelProvider usingNameAliasDirectiveBlockLabelProvider,
            IUsingNamespaceDirectiveBlockLabelProvider usingNamespaceDirectiveBlockLabelProvider,
            string localNamespaceName)
        {
            var usingDirectives = compilationUnit.GetUsings();

            //=> Need to get namespace directives in BLOCKS!
            var usingNamespaceDirectives = usingDirectives.GetUsingNamespaceDirectiveSyntaxes();
            var nameAliasDirectives = usingDirectives.GetUsingNameAliasDirectiveSyntaxes();

            var output = new UsingDirectivesSpecification();

            //var namespaceBlockCount = using

            //foreach (var usingNamespaceDirective in usingNamespaceDirectives)
            //{
            //    var blockLabel = await usingNamespaceDirectiveBlockLabelProvider.GetBlockLabel(
            //        )
            //}

            throw new NotImplementedException();
        }

        public static CompilationUnitSyntax SetUsings(this CompilationUnitSyntax compilationUnit,
            UsingDirectivesSpecification usingDirectivesSpecification,
            UsingDirectiveBlockSortOrder nameAliasSortOrder,
            UsingDirectiveBlockSortOrder namespaceSortOrder)
        {
            var usingDirectives = Instances.Operation.GetUsingDirectives(
                usingDirectivesSpecification,
                nameAliasSortOrder,
                namespaceSortOrder);

            var outputCompilationUnit = compilationUnit.WithUsings(
                usingDirectives.ToSyntaxList());

            return outputCompilationUnit;
        }
    }
}