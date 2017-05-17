using Sdl.Terminology.TerminologyProvider.Core;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDL_Terminology_Provider_Plug_in_2017_1
{
    public class MyTerminologyProvider : AbstractTerminologyProvider
    {
        private string IATEURL = "http://www.google.be";

        public override IDefinition Definition
        {
            get
            {
                return new Definition(new List<DescriptiveField>(), GetLanguages().Cast<IDefinitionLanguage>().ToList());
            }
        }

        public override string Description
        {
            get
            {
                return PluginResources.My_Terminology_Provider_Description;
            }
        }

        public override string Name
        {
            get
            {
                return PluginResources.My_Terminology_Provider_Name;
            }
        }

        public override Uri Uri
        {
            get
            {
                return new Uri(IATEURL);
            }
        }

        public MyTerminologyProvider(string providerSettings)
        {
            IATEURL = providerSettings;
        }

        public override IEntry GetEntry(int id)
        {
            return new Entry()
            {

            };
        }

        public override IEntry GetEntry(int id, IEnumerable<ILanguage> languages)
        {
            return new Entry()
            {

            };
        }

        public override IList<ILanguage> GetLanguages()
        {
            return new List<ILanguage>() { new DefinitionLanguage() { IsBidirectional = true, Locale = new CultureInfo("fr-be"), Name = "French(Belgium)" },
            new DefinitionLanguage() { IsBidirectional = true, Locale = new CultureInfo("it-it"), Name = "Italian(Italy)" } };
        }

        public override IList<ISearchResult> Search(string text, ILanguage source, ILanguage destination, int maxResultsCount, SearchMode mode, bool targetRequired)
        {
            // Create search results object (hitlist)
            var results = new List<ISearchResult>();

            results.Add(new SearchResult()
            {
                Id = 0,
                Score = 100,
                Text = "Dummy"
            });

            return results;
        }
    }
}
