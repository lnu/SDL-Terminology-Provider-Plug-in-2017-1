using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDL_Terminology_Provider_Plug_in_2017_1
{
    public partial class TermProviderControl : UserControl
    {
        public WebBrowser WebBrowser
        {
            get
            {
                return this.webBrowser;
            }
        }

        public TermProviderControl()
        {
            InitializeComponent();
        }
    }
}
