using System;


namespace R5T.T0125.T001
{
    /// <summary>
    /// Represents a using name alias code directive.
    /// </summary>
    public struct UsingNameAliasDirective : IUsingDirective, IEquatable<UsingNameAliasDirective>
    {
        #region Static

        public static UsingNameAliasDirective From(
            string destinationName,
            string sourceNameExpression)
        {
            var output = new UsingNameAliasDirective(
                destinationName,
                sourceNameExpression);

            return output;
        }

        public static bool operator ==(UsingNameAliasDirective left, UsingNameAliasDirective right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(UsingNameAliasDirective left, UsingNameAliasDirective right)
        {
            return !(left == right);
        }

        #endregion


        public string DestinationName { get; }
        public string SourceNameExpression { get; }


        public UsingNameAliasDirective(
            string destinationName,
            string sourceNameExpression)
        {
            this.DestinationName = destinationName;
            this.SourceNameExpression = sourceNameExpression;
        }

        public bool Equals(UsingNameAliasDirective other)
        {
            var output = true
                && this.DestinationName == other.DestinationName
                && this.SourceNameExpression == other.SourceNameExpression;

            return output;
        }

        public override bool Equals(object obj)
        {
            var output = obj is UsingNameAliasDirective usingNameAliasDirective
                && this.Equals(usingNameAliasDirective);

            return output;
        }

        public override int GetHashCode()
        {
            // Destination name is unique, so only it need be considered.
            var output = this.DestinationName.GetHashCode();
            return output;
        }
    }
}
