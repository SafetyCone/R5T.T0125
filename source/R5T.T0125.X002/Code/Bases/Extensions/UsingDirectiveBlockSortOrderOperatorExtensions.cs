using System;
using System.Collections.Generic;
using System.Linq;

using R5T.Magyar;

using R5T.T0125.T001;
using R5T.T0125.T002;

using UsingDirectiveBlockSortOrder = R5T.T0125.T001.UsingDirectiveBlockSortOrder;

using Instances = R5T.T0125.X002.Instances;


namespace System
{
    public static class UsingDirectiveBlockSortOrderOperatorExtensions
    {
        public static WasFound<string[]> AnyBlockLabelsMissingFromSortOrder(this IUsingDirectiveBlockSortOrderOperator _,
            IEnumerable<UsingDirectiveBlock> usingDirectiveBlocks,
            UsingDirectiveBlockSortOrder sortOrder)
        {
            var usingDirectiveBlockLabels = Instances.UsingDirectiveBlockLabelOperator.GetDistinctBlockLabels(usingDirectiveBlocks);

            var blockLabelsMissingFromSortOrder = usingDirectiveBlockLabels.Except(sortOrder.BlockLabels);

            var output = WasFound.FromEnumerable(blockLabelsMissingFromSortOrder);
            return output;
        }

        public static TUsingDirectiveBlock[] SortThrowIfAnyMissingBlockLabels<TUsingDirectiveBlock>(this IUsingDirectiveBlockSortOrderOperator _,
            IEnumerable<TUsingDirectiveBlock> usingDirectiveBlocks,
            UsingDirectiveBlockSortOrder sortOrder)
            where TUsingDirectiveBlock : UsingDirectiveBlock
        {
            var anyBlockLabelsMissingFromSortOrder = _.AnyBlockLabelsMissingFromSortOrder(
                usingDirectiveBlocks,
                sortOrder);

            if(anyBlockLabelsMissingFromSortOrder)
            {
                throw new Exception("Block labels were missing from sort order. All block labels must be present in the sort order.");
            }

            var indexByBlockLabel = sortOrder.BlockLabels.GetIndexByItem();

            var output = usingDirectiveBlocks
                .OrderBy(x => indexByBlockLabel[x.Label])
                .Now();

            return output;
        }

        /// <summary>
        /// Chooses <see cref="SortThrowIfAnyMissingBlockLabels{TUsingDirectiveBlock}(IUsingDirectiveBlockSortOrderOperator, IEnumerable{TUsingDirectiveBlock}, UsingDirectiveBlockSortOrder)"/> as the default.
        /// </summary>
        public static TUsingDirectiveBlock[] Sort<TUsingDirectiveBlock>(this IUsingDirectiveBlockSortOrderOperator _,
            IEnumerable<TUsingDirectiveBlock> usingDirectiveBlocks,
            UsingDirectiveBlockSortOrder sortOrder)
            where TUsingDirectiveBlock : UsingDirectiveBlock
        {
            var output = _.SortThrowIfAnyMissingBlockLabels(
                usingDirectiveBlocks,
                sortOrder);

            return output;
        }
    }
}
