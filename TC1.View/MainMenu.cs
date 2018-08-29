using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TC1.View
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            Services.MultiLanguageManager.SetCulture();
            lblHello.Text = Services.MultiLanguageManager.Localize("TC1.View.MainMenu.lblHello");
        }

        private void btnToEnglish_Click(object sender, EventArgs e)
        {
            Services.MultiLanguageManager.SetCulture("en-US");
            lblHello.Text = Services.MultiLanguageManager.Localize("TC1.View.MainMenu.lblHello");
        }

        private void btnToSpanish_Click(object sender, EventArgs e)
        {
            Services.MultiLanguageManager.SetCulture("es-ES");
            lblHello.Text = Services.MultiLanguageManager.Localize("TC1.View.MainMenu.lblHello");
        }
    }
}
