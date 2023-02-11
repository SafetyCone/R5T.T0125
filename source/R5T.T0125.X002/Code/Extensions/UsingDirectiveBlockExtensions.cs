using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0125.T001;


namespace R5T.T0125.X002
{
    public static class UsingDirectiveBlockExtensions
    {
        public static UsingDirectiveSyntax[] GetUsingDirectives(this UsingDirectiveBlock<UsingNameAliasDirective> nameAliasDirectiveBlock)
        {
            var usingDirectives = nameAliasDirectiveBlock.UsingDirectives.GetUsingDirectives()
                .WithWithinBlockSpacing()
                .Now_OLD();

            return usingDirectives;
        }

        public static UsingDirectiveSyntax[] GetUsingDirectives(this UsingDirectiveBlock<UsingNamespaceDirective> namespaceDirectiveBlock)
        {
            var usingDirectives = namespaceDirectiveBlock.UsingDirectives.GetUsingDirectives()
                .WithWithinBlockSpacing()
                .Now_OLD();

            return usingDirectives;
        }
    }
}
