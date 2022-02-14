using System;

using R5T.T0125.T002;
using R5T.T0125.T002.X001;


namespace System
{
    public static class IUsingNameAliasDirectiveBlockLabelExtensions
    {
        public static string Classes(this IUsingNameAliasDirectiveBlockLabel _)
        {
            return UsingNameAliasDirectiveBlockLabels.Classes;
        }

        public static string Default(this IUsingNameAliasDirectiveBlockLabel _)
        {
            return UsingNameAliasDirectiveBlockLabels.Default;
        }

        public static string Interfaces(this IUsingNameAliasDirectiveBlockLabel _)
        {
            return UsingNameAliasDirectiveBlockLabels.Interfaces;
        }
    }
}
