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
    public partial class FormCreateEdit : MetroForm
    {
        public FormCreateEdit()
        {
            InitializeComponent();
        }

        private void FormCreateEdit_Load(object sender, EventArgs e)
        {

        }

        HashSet<Tuple<string, string, string>> list = new HashSet<Tuple<string, string, string>>();

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroGrid1.Rows.Add(metroTextBox5.Text, metroTextBox4.Text, getSelectedItem());
        }

        private string getSelectedItem()
        {
            if (metroRadioButton4.Checked) return metroRadioButton4.Text;
            if (metroRadioButton5.Checked) return metroRadioButton5.Text;
            if (metroRadioButton6.Checked) return metroRadioButton6.Text;
            if (metroRadioButton7.Checked) return metroRadioButton7.Text;
            if (metroRadioButton8.Checked) return metroRadioButton8.Text;
            if (metroRadioButton9.Checked) return metroRadioButton9.Text;
            if (metroRadioButton10.Checked) return metroRadioButton10.Text;
            if (metroRadioButton11.Checked) return metroRadioButton11.Text;

            return "nie zaznaczono jednostkki";
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            metroGrid1.ReadOnly = false;

            metroGrid1.SelectedRows.Clear();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroGrid1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroGrid1_Validating(object sender, CancelEventArgs e)
        {
        }
    }
}
