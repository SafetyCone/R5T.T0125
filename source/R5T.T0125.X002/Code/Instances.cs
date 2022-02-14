using System;

using R5T.L0011.T001;
using R5T.T0098;
using R5T.T0125.T002;


namespace R5T.T0125.X002
{
    public static class Instances
    {
        public static IOperation Operation { get; } = T0098.Operation.Instance;
        public static ISyntaxFactory SyntaxFactory { get; } = L0011.T001.SyntaxFactory.Instance;
        public static ISyntaxOperator SyntaxOperator { get; } = L0011.T001.SyntaxOperator.Instance;
        public static IUsingDirectiveBlockLabelOperator UsingDirectiveBlockLabelOperator { get; } = T002.UsingDirectiveBlockLabelOperator.Instance;
        public static IUsingDirectiveBlockSortOrderOperator UsingDirectiveBlockSortOrderOperator { get; } = T002.UsingDirectiveBlockSortOrderOperator.Instance;
    }
}
