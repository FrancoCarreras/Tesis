using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Tesis.AdminFutbol.Localization
{
    public static class AdminFutbolLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AdminFutbolConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AdminFutbolLocalizationConfigurer).GetAssembly(),
                        "Tesis.AdminFutbol.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
