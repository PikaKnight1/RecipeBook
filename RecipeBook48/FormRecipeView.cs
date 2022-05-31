using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;
using MetroFramework.Components;

namespace RecipeBook48
{
    public partial class FormRecipeView : MetroForm
    {
        FormWelcome formWelcome;

        public FormRecipeView(MetroStyleManager manager, FormWelcome form)
        {
            InitializeComponent();
            SetUpStyle(manager);
            this.formWelcome = form;
        }

        private void FormRecipeView_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                TextBoxIngredients.AppendText("Siemanko, witaj w mojej aplikacji, to tylko test tekstowy yyyy tekst testowy xD");
                TextBoxIngredients.AppendText(Environment.NewLine);
                TextBoxMaking.AppendText("Siemanko, witaj w mojej aplikacji, to tylko test tekstowy yyyy tekst testowy xD");
                TextBoxMaking.AppendText(Environment.NewLine);

            }
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LabelIngredients_Click(object sender, EventArgs e)
        {

        }
    }
}
