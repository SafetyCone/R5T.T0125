using System;


namespace R5T.T0125.T002
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class UsingNamespaceDirectiveBlockLabel : IUsingNamespaceDirectiveBlockLabel
    {
        #region Static
        
        public static UsingNamespaceDirectiveBlockLabel Instance { get; } = new();

        #endregion
    }
}