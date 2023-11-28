using KuntoLps2.Debugging;

namespace KuntoLps2
{
    public class KuntoLps2Consts
    {
        public const string LocalizationSourceName = "KuntoLps2";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "855adc60beda42c197ee34f28e5d5d38";
    }
}
