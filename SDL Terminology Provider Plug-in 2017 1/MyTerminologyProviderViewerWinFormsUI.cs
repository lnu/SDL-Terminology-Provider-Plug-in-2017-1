using Sdl.Terminology.TerminologyProvider.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using System.IO;

namespace SDL_Terminology_Provider_Plug_in_2017_1
{
    [TerminologyProviderViewerWinFormsUI]
    public class MyTerminologyProviderViewerWinFormsUI : ITerminologyProviderViewerWinFormsUI
    {
        private TermProviderControl termControl;
        public Control Control
        {
            get
            {
                termControl = new TermProviderControl();
                return termControl;
            }
        }

        public bool Initialized
        {
            get
            {
                return true;
            }
        }

        public IEntry SelectedTerm
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public event EventHandler<EntryEventArgs> SelectedTermChanged;
        public event EventHandler TermChanged;

        public void AddAndEditTerm(IEntry term, string source, string target)
        {
            throw new NotImplementedException();
        }

        public void AddTerm(string source, string target)
        {
            throw new NotImplementedException();
        }

        public void EditTerm(IEntry term)
        {
            throw new NotImplementedException();
        }

        public void Initialize(ITerminologyProvider terminologyProvider, CultureInfo source, CultureInfo target)
        {

        }

        public void JumpToTerm(IEntry entry)
        {
            string tmpFile = System.IO.Path.GetTempPath() + "simple_list_entry.htm";
            StreamWriter previewFile = new StreamWriter(tmpFile);
            previewFile.Write("<html><body><b>Entry id:</b> " + entry.Id +
                "<br/><b>Source term:</b> " + "ssource" +
                "<br/><b>Target term:</b> " + "target" +
                "<br/><b>Definition:</b> " + "definition" +
                "</body></html>");
            previewFile.Close();
            termControl.WebBrowser.Navigate(tmpFile);
        }

        public void Release()
        {
            throw new NotImplementedException();
        }

        public bool SupportsTerminologyProviderUri(Uri terminologyProviderUri)
        {
            return true;
        }
    }
}
