using Tesis.AdminFutbol.Debugging;

namespace Tesis.AdminFutbol
{
    public class AdminFutbolConsts
    {
        public const string LocalizationSourceName = "AdminFutbol";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "ce98794903134351a60c84ce92b5c0d1";
    }
}
