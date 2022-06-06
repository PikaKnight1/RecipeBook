using MetroFramework.Components;

namespace RecipeBook48
{
    partial class FormAdminPanelMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridAdminRecipes = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecipeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecipeAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecipeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StepVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditRecipe = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteRecipe = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LabelHint = new MetroFramework.Controls.MetroLabel();
            this.styleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridAdminRecipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // GridAdminRecipes
            // 
            this.GridAdminRecipes.AllowUserToAddRows = false;
            this.GridAdminRecipes.AllowUserToDeleteRows = false;
            this.GridAdminRecipes.AllowUserToResizeColumns = false;
            this.GridAdminRecipes.AllowUserToResizeRows = false;
            this.GridAdminRecipes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridAdminRecipes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridAdminRecipes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridAdminRecipes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridAdminRecipes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridAdminRecipes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridAdminRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAdminRecipes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.RecipeName,
            this.RecipeAuthor,
            this.RecipeDate,
            this.IngVal,
            this.StepVal,
            this.EditRecipe,
            this.DeleteRecipe});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridAdminRecipes.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridAdminRecipes.EnableHeadersVisualStyles = false;
            this.GridAdminRecipes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridAdminRecipes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridAdminRecipes.Location = new System.Drawing.Point(23, 168);
            this.GridAdminRecipes.MultiSelect = false;
            this.GridAdminRecipes.Name = "GridAdminRecipes";
            this.GridAdminRecipes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridAdminRecipes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridAdminRecipes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.GridAdminRecipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridAdminRecipes.Size = new System.Drawing.Size(954, 409);
            this.GridAdminRecipes.TabIndex = 0;
            this.GridAdminRecipes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridAdminRecipeList);
            // 
            // ID
            // 
            this.ID.FillWeight = 30F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // RecipeName
            // 
            this.RecipeName.HeaderText = "Nazwa przepisu";
            this.RecipeName.Name = "RecipeName";
            // 
            // RecipeAuthor
            // 
            this.RecipeAuthor.FillWeight = 80F;
            this.RecipeAuthor.HeaderText = "Autor";
            this.RecipeAuthor.Name = "RecipeAuthor";
            // 
            // RecipeDate
            // 
            this.RecipeDate.FillWeight = 50F;
            this.RecipeDate.HeaderText = "Data dodania";
            this.RecipeDate.Name = "RecipeDate";
            // 
            // IngVal
            // 
            this.IngVal.FillWeight = 30F;
            this.IngVal.HeaderText = "Liczba składników";
            this.IngVal.Name = "IngVal";
            // 
            // StepVal
            // 
            this.StepVal.FillWeight = 30F;
            this.StepVal.HeaderText = "Liczba Kroków";
            this.StepVal.Name = "StepVal";
            // 
            // EditRecipe
            // 
            this.EditRecipe.FillWeight = 50F;
            this.EditRecipe.HeaderText = "Edytuj";
            this.EditRecipe.Name = "EditRecipe";
            this.EditRecipe.Text = "Edytuj";
            this.EditRecipe.UseColumnTextForButtonValue = true;
            // 
            // DeleteRecipe
            // 
            this.DeleteRecipe.FillWeight = 50F;
            this.DeleteRecipe.HeaderText = "Usuń";
            this.DeleteRecipe.Name = "DeleteRecipe";
            this.DeleteRecipe.Text = "Usuń";
            this.DeleteRecipe.UseColumnTextForButtonValue = true;
            // 
            // LabelHint
            // 
            this.LabelHint.AutoSize = true;
            this.LabelHint.Location = new System.Drawing.Point(23, 97);
            this.LabelHint.Name = "LabelHint";
            this.LabelHint.Size = new System.Drawing.Size(381, 95);
            this.LabelHint.TabIndex = 1;
            this.LabelHint.Text = "Panel pozwala na edycję, bądź usuwanie konkretnych przepisów.\r\nWystarczy kliknąć " +
    "\"Usuń\" obok przepisu, by skasować go z bazy.\r\nKlikając \"Edytuj\" obok przepisu mo" +
    "żna przejść do jego edycji.\r\n\r\n";
            // 
            // styleManager
            // 
            this.styleManager.Owner = null;
            // 
            // FormAdminPanelMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.GridAdminRecipes);
            this.Controls.Add(this.LabelHint);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormAdminPanelMain";
            this.Text = "Panel Administratora";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdminPanelMainFormClosed);
            this.Load += new System.EventHandler(this.FormAdminPanelMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridAdminRecipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid GridAdminRecipes;
        private MetroFramework.Controls.MetroLabel LabelHint;
        private MetroFramework.Components.MetroStyleManager styleManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecipeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecipeAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecipeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngVal;
        private System.Windows.Forms.DataGridViewTextBoxColumn StepVal;
        private System.Windows.Forms.DataGridViewButtonColumn EditRecipe;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteRecipe;

        private void SetUpStyle(MetroStyleManager manago)
        {
            this.styleManager = manago;
            this.StyleManager = styleManager;
            this.LabelHint.StyleManager = styleManager;
            this.LabelHint.StyleManager = styleManager;
            this.GridAdminRecipes.StyleManager = styleManager;
        }
    }
}