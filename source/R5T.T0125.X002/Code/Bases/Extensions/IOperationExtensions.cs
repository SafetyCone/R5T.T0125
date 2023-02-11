using System;
using System.Linq;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.Magyar;

using R5T.T0125.T001;
using R5T.T0098;

using Instances = R5T.T0125.X002.Instances;


namespace System
{
    public static class IOperationExtensions
    {
        public static UsingDirectiveSyntax[] GetUsingDirectives(this IOperation _,
            UsingDirectivesSpecification usingDirectivesSpecification,
            UsingDirectiveBlockSortOrder nameAliasSortOrder,
            UsingDirectiveBlockSortOrder namespaceSortOrder)
        {
            var namespaceBlocksInOrder = Instances.UsingDirectiveBlockSortOrderOperator.Sort(
                usingDirectivesSpecification.Namespaces.Values,
                namespaceSortOrder);

            var nameAliasBlocksInOrder = Instances.UsingDirectiveBlockSortOrderOperator.Sort(
                usingDirectivesSpecification.Namespaces.Values,
                nameAliasSortOrder);

            var isFirstBlock = true;

            var output = namespaceBlocksInOrder
                .Select(xBlock => xBlock.UsingDirectives.GetUsingDirectives())
                .AppendRange(nameAliasBlocksInOrder
                    .Select(xBlock => xBlock.UsingDirectives.GetUsingDirectives()))
                .SelectMany(xUsingDirectiveEnumerable =>
                {
                    var usingDirectives = xUsingDirectiveEnumerable.WithBetweenBlockSpacing(isFirstBlock);

                    isFirstBlock = false;

                    return usingDirectives;
                })
                .Now_OLD()
                ;

            return output;
        }
    }
}
