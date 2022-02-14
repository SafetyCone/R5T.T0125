using System;
using System.Collections.Generic;


namespace R5T.T0125.T001
{
    /// <summary>
    /// Holds the using directive data for a code unit.
    /// </summary>
    public class UsingDirectivesSpecification
    {
        public Dictionary<string, UsingDirectiveBlock<UsingNamespaceDirective>> Namespaces { get; } = new Dictionary<string, UsingDirectiveBlock<UsingNamespaceDirective>>();
        public Dictionary<string, UsingDirectiveBlock<UsingNameAliasDirective>> NameAliases { get; } = new Dictionary<string, UsingDirectiveBlock<UsingNameAliasDirective>>();
    }
}
