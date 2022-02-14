using System;
using System.Threading.Tasks;


namespace R5T.T0125.T001
{
    /// <summary>
    /// Used in creating a <see cref="UsingDirectivesSpecification"/> from code.
    /// </summary>
    public interface IUsingNamespaceDirectiveBlockLabelProvider
    {
        Task<string> GetBlockLabel(
            string namespaceName,
            string localNamespaceName);
    }
}
