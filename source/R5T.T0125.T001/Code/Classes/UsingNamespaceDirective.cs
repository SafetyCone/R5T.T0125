using System;


namespace R5T.T0125.T001
{
    /// <summary>
    /// Represents a using namespace code directive.
    /// </summary>
    public struct UsingNamespaceDirective : IUsingDirective, IEquatable<UsingNamespaceDirective>
    {
        #region Static

        public static UsingNamespaceDirective From(string namespaceName)
        {
            var output = new UsingNamespaceDirective(namespaceName);
            return output;
        }

        public static bool operator ==(UsingNamespaceDirective left, UsingNamespaceDirective right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(UsingNamespaceDirective left, UsingNamespaceDirective right)
        {
            return !(left == right);
        }

        #endregion


        public string NamespaceName { get; }


        public UsingNamespaceDirective(
            string namespaceName)
        {
            this.NamespaceName = namespaceName;
        }

        public bool Equals(UsingNamespaceDirective other)
        {
            var output = this.NamespaceName == other.NamespaceName;
            return output;
        }

        public override bool Equals(object obj)
        {
            var output = obj is UsingNamespaceDirective usingNamespaceDirective
                && this.Equals(usingNamespaceDirective);

            return output;
        }

        public override int GetHashCode()
        {
            var output = this.NamespaceName.GetHashCode();
            return output;
        }
    }
}
