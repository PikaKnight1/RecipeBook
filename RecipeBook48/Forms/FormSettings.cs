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
using MetroFramework;


namespace RecipeBook48
{
    public partial class FormSettings : MetroForm
    {
        readonly FormWelcome form;

        public FormSettings(MetroStyleManager manager, FormWelcome form)
        {
            InitializeComponent();
            SetUpStyle(manager);
            this.form = form;
        }

        private void ThisFormLoad(object sender, EventArgs e)
        {
            try
            {
                TextBoxIP.Text = form.connection.Host;
                TextBoxUsername.Text = form.connection.User;
                TextBoxPass.Text = form.connection.Password;
                TextBoxPort.Text = form.connection.Port;
                TextBoxSID.Text = form.connection.Sid;
            }
            catch
            {
                //ignore when config file is empty
            }
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

                JsonSerializing.ThemeSettingsToFile((int)styleManager.Theme, (int)styleManager.Style);
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
            form.connection = new SqlConnection(TextBoxIP.Text, TextBoxPort.Text, TextBoxUsername.Text, TextBoxPass.Text, TextBoxSID.Text);

            if (form.connection.TestSqlConnection())
            {
                MetroMessageBox.Show(this, "Połączenie działa poprawnie", "Test połączenia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetroMessageBox.Show(this, "Wystąpił błąd! Sprawdź ustawienia.", "Test połączenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSQLSaveClick(object sender, EventArgs e)
        {
            form.connection = new SqlConnection(TextBoxIP.Text, TextBoxPort.Text, TextBoxUsername.Text, TextBoxPass.Text, TextBoxSID.Text);
            JsonSerializing.SqlSettingsToFile(form.connection);
        }
    }
}
