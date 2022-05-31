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
        FormWelcome form;
        public FormCreateEdit(MetroStyleManager manager, FormWelcome form)
        {
            InitializeComponent();
            SetUpStyle(manager);

            this.form = form;
        }

        private void FormCreateEdit_Load(object sender, EventArgs e)
        {

        }

        HashSet<Tuple<string, string, string>> list = new HashSet<Tuple<string, string, string>>();

        private void metroButton1_Click(object sender, EventArgs e)
        {
            GridIng.Rows.Add(metroTextBox5.Text, metroTextBox4.Text, getSelectedItem());
        }

        private string getSelectedItem()
        {
            if (RadioBtnTypeG.Checked) return RadioBtnTypeG.Text;
            if (RadioBtnTypeKG.Checked) return RadioBtnTypeKG.Text;
            if (RadioBtnTypeML.Checked) return RadioBtnTypeML.Text;
            if (RadioBtnTypeL.Checked) return RadioBtnTypeL.Text;
            if (RadioBtnTypeSZKL.Checked) return RadioBtnTypeSZKL.Text;
            if (RadioBtnTypeLYZ.Checked) return RadioBtnTypeLYZ.Text;
            if (RadioBtnTypeSZCZ.Checked) return RadioBtnTypeSZCZ.Text;
            if (RadioBtnTypeSZT.Checked) return RadioBtnTypeSZT.Text;

            return "nie zaznaczono jednostkki";
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            GridIng.ReadOnly = false;

            GridIng.SelectedRows.Clear();
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
