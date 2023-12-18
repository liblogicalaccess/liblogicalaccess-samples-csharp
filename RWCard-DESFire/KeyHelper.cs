using System.Text.RegularExpressions;

namespace RWCard_DESFire
{
    public static class KeyHelper
    {
        public static string FormatKeyString(string key)
        {
            return Regex.Replace(key, ".{2}", "$0 ").Trim();
        }
    }
}
