using System;


namespace R5T.T0125.T002
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class UsingDirectiveBlockLabel : IUsingDirectiveBlockLabel
    {
        #region Static
        
        public static UsingDirectiveBlockLabel Instance { get; } = new();

        #endregion
    }
}