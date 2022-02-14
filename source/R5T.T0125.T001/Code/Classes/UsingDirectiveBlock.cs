using System;
using System.Collections.Generic;


namespace R5T.T0125.T001
{
    public class UsingDirectiveBlock
    {
        public string Label { get; }


        public UsingDirectiveBlock(
            string label)
        {
            this.Label = label;
        }
    }


    /// <summary>
    /// A line-separated set of using directives.
    /// </summary>
    public class UsingDirectiveBlock<TUsingDirective> : UsingDirectiveBlock
        where TUsingDirective : IUsingDirective
    {
        #region Static

        public static UsingDirectiveBlock<TUsingDirective> New(string label)
        {
            var output = new UsingDirectiveBlock<TUsingDirective>(label);
            return output;
        }

        #endregion


        public List<TUsingDirective> UsingDirectives { get; } = new List<TUsingDirective>();


        public UsingDirectiveBlock(
            string label)
            : base(label)
        {
        }
    }
}
