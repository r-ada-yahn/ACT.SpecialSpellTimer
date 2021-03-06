﻿namespace ACT.SpecialSpellTimer.Utility
{
    using System.Text.RegularExpressions;
    using ACT.SpecialSpellTimer.Properties;

    public static class StringExtensions
    {
        public static string ToRegexPattern(
            this string s)
        {
            if (Settings.Default.SimpleRegex)
            {
                return s ?? string.Empty;
            }

            return !string.IsNullOrEmpty(s) ?
                ".*" + s + ".*" :
                string.Empty;
        }

        public static Regex ToRegex(
            this string s)
        {
            return !string.IsNullOrEmpty(s) ?
                new Regex(s, RegexOptions.Compiled) :
                null;
        }
    }
}
