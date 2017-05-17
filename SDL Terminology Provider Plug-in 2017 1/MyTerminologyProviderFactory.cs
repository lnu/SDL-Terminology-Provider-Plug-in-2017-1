using Sdl.Terminology.TerminologyProvider.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDL_Terminology_Provider_Plug_in_2017_1
{
    [TerminologyProviderFactory(Id = "My_Terminology_Provider_Id",
        Name = "My_Terminology_Provider_Name",
        Description = "My_Terminology_Provider_Description")]
    public class MyTerminologyProviderFactory : ITerminologyProviderFactory
    {
        public ITerminologyProvider CreateTerminologyProvider(Uri terminologyProviderUri, ITerminologyProviderCredentialStore credentials)
        {
            MyTerminologyProvider _terminologyProvider = new MyTerminologyProvider(terminologyProviderUri.ToString());
            return _terminologyProvider;
        }

        public bool SupportsTerminologyProviderUri(Uri terminologyProviderUri)
        {
            return true;
        }
    }
}
