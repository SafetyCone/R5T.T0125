using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0125.T001;

using Instances = R5T.T0125.X002.Instances;


namespace System
{
    public static class UsingNamespaceDirectiveExtensions
    {
        public static UsingDirectiveSyntax GetUsingDirective(this UsingNamespaceDirective namespaceDirective)
        {
            var output = Instances.SyntaxFactory.Using(namespaceDirective.NamespaceName);
            return output;
        }

        public static IEnumerable<UsingDirectiveSyntax> GetUsingDirectives(this IEnumerable<UsingNamespaceDirective> namespaceDirectives)
        {
            var output = namespaceDirectives
                .Select(x => x.GetUsingDirective())
                ;

            return output;
        }
    }
}
