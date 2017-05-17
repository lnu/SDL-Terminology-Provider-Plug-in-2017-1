using Sdl.Terminology.TerminologyProvider.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDL_Terminology_Provider_Plug_in_2017_1
{
    [TerminologyProviderWinFormsUI]
    public class MyTerminologyProviderWinFormsUI : ITerminologyProviderWinFormsUI
    {
        public bool SupportsEditing
        {
            get
            {
                return false;
            }
        }

        public string TypeDescription
        {
            get
            {
                return PluginResources.My_Terminology_Provider_Description;
            }
        }

        public string TypeName
        {
            get
            {
                return PluginResources.My_Terminology_Provider_Name;
            }
        }

        public ITerminologyProvider[] Browse(IWin32Window owner, ITerminologyProviderCredentialStore credentialStore)
        {
            return new ITerminologyProvider[]{ new MyTerminologyProvider("http://www.google.be")};
        }

        public bool Edit(IWin32Window owner, ITerminologyProvider terminologyProvider)
        {
            throw new NotImplementedException();
        }

        public TerminologyProviderDisplayInfo GetDisplayInfo(Uri terminologyProviderUri)
        {
            throw new NotImplementedException();
        }

        public bool SupportsTerminologyProviderUri(Uri terminologyProviderUri)
        {
            return true;
        }
    }
}
