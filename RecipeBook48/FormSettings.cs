using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;


namespace RecipeBook48
{
    public partial class FormSettings : MetroForm
    {
        FormWelcome form;

        public FormSettings(MetroStyleManager manager, FormWelcome form)
        {
            InitializeComponent();
            SetUpStyle(manager);

            this.form = form;
        }

        private void ThisFormLoad(object sender, EventArgs e)
        {

        }

        private void TextBoxIP_Click(object sender, EventArgs e)
        {
            TextBoxIP.SelectAll();
        }

        private void FormSettingsFormClosing(object sender, FormClosingEventArgs e)
        {
            form.Show();
        }

        private void ButtonThemeAcceptClick(object sender, EventArgs e)
        {
            if (ComboColor.SelectedIndex > -1 && ComboTheme.SelectedIndex > -1)
            {
                styleManager.Theme = (MetroFramework.MetroThemeStyle)ComboTheme.SelectedIndex + 1;
                styleManager.Style = (MetroFramework.MetroColorStyle)ComboColor.SelectedIndex + 1;
                this.Refresh();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Nie wybrano obu wymaganych pól. Wybierz odpowiedni motyw i kolor.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxPortClick(object sender, EventArgs e)
        {
            TextBoxPort.SelectAll();
        }

        private void TextBoxUsernameClick(object sender, EventArgs e)
        {
            TextBoxUsername.SelectAll();
        }

        private void TextBoxPassClick(object sender, EventArgs e)
        {
            TextBoxPass.SelectAll();
        }

        private void TextBoxSIDClick(object sender, EventArgs e)
        {
            TextBoxSID.SelectAll();
        }

        private void ButtonSqlTestClick(object sender, EventArgs e)
        {

        }
    }
}
