using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace KuntoLps2.Localization
{
    public static class KuntoLps2LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(KuntoLps2Consts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(KuntoLps2LocalizationConfigurer).GetAssembly(),
                        "KuntoLps2.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
