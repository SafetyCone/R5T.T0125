using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.L0011.T001;
using R5T.T0125.T001;


namespace System
{
    public static class ISyntaxOperatorExtensions
    {
        public static UsingNamespaceDirective GetUsingNamespaceDirective(this ISyntaxOperator _,
            UsingDirectiveSyntax usingNamespaceDirective)
        {
            var namespaceName = usingNamespaceDirective.GetNamespaceName();

            var output = UsingNamespaceDirective.From(namespaceName);
            return output;
        }

        public static UsingNameAliasDirective GetUsingNameAliasDirective(this ISyntaxOperator _,
            UsingDirectiveSyntax usingNameAliasDirective)
        {
            var (destinationName, sourceNameExpression) = usingNameAliasDirective.GetNameAliasValues();

            var output = UsingNameAliasDirective.From(
                destinationName,
                sourceNameExpression);

            return output;
        }
    }
}
