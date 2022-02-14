using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0125.T001;
using R5T.T0125.T002;


namespace System
{
    public static class IUsingDirectiveBlockLabelOperatorExtensions
    {
        public static IEnumerable<string> GetDistinctBlockLabels(this IUsingDirectiveBlockLabelOperator _,
            IEnumerable<UsingDirectiveBlock> usingDirectiveBlocks)
        {
            var output = usingDirectiveBlocks
                .Select(x => x.Label)
                .Distinct();

            return output;
        }
    }
}
