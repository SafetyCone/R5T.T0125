using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0125.T001;

using Instances = R5T.T0125.X002.Instances;


namespace System
{
    public static class UsingNameAliasDirectiveExtensions
    {
        public static UsingDirectiveSyntax GetUsingDirective(this UsingNameAliasDirective nameAliasDirective)
        {
            var output = Instances.SyntaxFactory.Using(
                nameAliasDirective.DestinationName,
                nameAliasDirective.SourceNameExpression);

            return output;
        }

        public static IEnumerable<UsingDirectiveSyntax> GetUsingDirectives(this IEnumerable<UsingNameAliasDirective> nameAliasDirectives)
        {
            var output = nameAliasDirectives
                .Select(x => x.GetUsingDirective())
                ;

            return output;
        }
    }
}
