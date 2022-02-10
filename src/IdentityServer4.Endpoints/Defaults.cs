﻿namespace IdentityServer4.Anonnymous
{
    internal sealed class Defaults
    {
        internal const int AllowedRetries = 5;
        internal static int CodeLifetime = 60;
        internal static int Interval = 5;

        internal sealed class CodeGenetar
        {
            internal const int NumberOfFigures = 5;
            internal const string UserCodeType = "5_figures_user_code";
        }
    }
}