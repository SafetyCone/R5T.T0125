using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0125.T001;

using Instances = R5T.T0125.X002.Instances;


namespace System
{
    public static class UsingDirectiveSyntaxExtensions
    {
        public static UsingNameAliasDirective GetUsingNameAliasDirective(this UsingDirectiveSyntax usingNameAliasDirective)
        {
            var output = Instances.SyntaxOperator.GetUsingNameAliasDirective(usingNameAliasDirective);
            return output;
        }

        public static IEnumerable<UsingNameAliasDirective> GetUsingNameAliasDirectives(this IEnumerable<UsingDirectiveSyntax> usingNameAliasDirectives)
        {
            var output = usingNameAliasDirectives
                .Select(x => x.GetUsingNameAliasDirective())
                ;

            return output;
        }

        public static UsingNameAliasDirective GetUsingNamespaceDirective(this UsingDirectiveSyntax usingNamespaceDirective)
        {
            var output = Instances.SyntaxOperator.GetUsingNameAliasDirective(usingNamespaceDirective);
            return output;
        }

        public static IEnumerable<UsingNameAliasDirective> GetUsingNamespaceDirectives(this IEnumerable<UsingDirectiveSyntax> usingNamespaceDirectives)
        {
            var output = usingNamespaceDirectives
                .Select(x => x.GetUsingNameAliasDirective())
                ;

            return output;
        }

        /// <summary>
        /// Prepends new lines to all using directives except the first.
        /// The leading line separator trivia for the first using directive can be later determined based on the block's position.
        /// </summary>
        public static IEnumerable<UsingDirectiveSyntax> WithWithinBlockSpacing(this IEnumerable<UsingDirectiveSyntax> usingDirectives)
        {
            if (usingDirectives.Any())
            {
                // Prepend new lines to all using directives except the first.
                var output = usingDirectives.TakeFirst()
                    .AppendRange(usingDirectives.SkipFirst()
                        .Select(x => x.PrependNewLine()))
                    ;

                return output;
            }
            else
            {
                // Return the empty.
                return usingDirectives;
            }
        }

        public static IEnumerable<UsingDirectiveSyntax> WithBetweenBlockSpacing(this IEnumerable<UsingDirectiveSyntax> usingDirectives,
            bool isFirstBlock)
        {
            // Check that there are any using directives to begin with.
            if(!usingDirectives.Any())
            {
                return usingDirectives;
            }

            var output = isFirstBlock
                // If the using directives are the first block, do not add any new lines to the first using directive.
                ? usingDirectives
                // If the using directives are not the first block, add two new lines to the first using directive
                : usingDirectives.TakeFirst()
                    .Select(xFirst => xFirst.PrependBlankLine())
                    .AppendRange(usingDirectives.SkipFirst())
                ;

            return output;
        }
    }
}
