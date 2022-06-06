using MetroFramework.Components;

namespace RecipeBook48
{
    partial class FormRecipeView
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
            this.PanelTop = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.LabelTimeText = new MetroFramework.Controls.MetroLabel();
            this.LabelTime = new MetroFramework.Controls.MetroLabel();
            this.LabelDifficultyText = new MetroFramework.Controls.MetroLabel();
            this.LabelDifficulty = new MetroFramework.Controls.MetroLabel();
            this.PictureRecipe = new System.Windows.Forms.PictureBox();
            this.PanelTopLeft = new MetroFramework.Controls.MetroPanel();
            this.LabelCategoryText = new MetroFramework.Controls.MetroLabel();
            this.LabelCategory = new MetroFramework.Controls.MetroLabel();
            this.LabelAuthorText = new MetroFramework.Controls.MetroLabel();
            this.LabelAuthor = new MetroFramework.Controls.MetroLabel();
            this.LabelIngredients = new MetroFramework.Controls.MetroLabel();
            this.LabelSteps = new MetroFramework.Controls.MetroLabel();
            this.PanelIngredients = new MetroFramework.Controls.MetroPanel();
            this.TextBoxIngredients = new MetroFramework.Controls.MetroTextBox();
            this.PanelSteps = new MetroFramework.Controls.MetroPanel();
            this.TextBoxSteps = new MetroFramework.Controls.MetroTextBox();
            this.styleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.PanelTop.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureRecipe)).BeginInit();
            this.PanelTopLeft.SuspendLayout();
            this.PanelIngredients.SuspendLayout();
            this.PanelSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.styleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.metroPanel1);
            this.PanelTop.Controls.Add(this.PictureRecipe);
            this.PanelTop.Controls.Add(this.PanelTopLeft);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.HorizontalScrollbarBarColor = true;
            this.PanelTop.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelTop.HorizontalScrollbarSize = 10;
            this.PanelTop.Location = new System.Drawing.Point(20, 60);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(960, 108);
            this.PanelTop.TabIndex = 0;
            this.PanelTop.VerticalScrollbarBarColor = true;
            this.PanelTop.VerticalScrollbarHighlightOnWheel = false;
            this.PanelTop.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.LabelTimeText);
            this.metroPanel1.Controls.Add(this.LabelTime);
            this.metroPanel1.Controls.Add(this.LabelDifficultyText);
            this.metroPanel1.Controls.Add(this.LabelDifficulty);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(610, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(350, 108);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // LabelTimeText
            // 
            this.LabelTimeText.AutoSize = true;
            this.LabelTimeText.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LabelTimeText.Location = new System.Drawing.Point(3, 79);
            this.LabelTimeText.Name = "LabelTimeText";
            this.LabelTimeText.Size = new System.Drawing.Size(192, 25);
            this.LabelTimeText.TabIndex = 7;
            this.LabelTimeText.Text = "aaaaaaaaaaaaaaaaaaaa";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Location = new System.Drawing.Point(3, 60);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(129, 19);
            this.LabelTime.TabIndex = 5;
            this.LabelTime.Text = "Czas przygotowania:";
            // 
            // LabelDifficultyText
            // 
            this.LabelDifficultyText.AutoSize = true;
            this.LabelDifficultyText.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LabelDifficultyText.Location = new System.Drawing.Point(3, 22);
            this.LabelDifficultyText.Name = "LabelDifficultyText";
            this.LabelDifficultyText.Size = new System.Drawing.Size(192, 25);
            this.LabelDifficultyText.TabIndex = 4;
            this.LabelDifficultyText.Text = "aaaaaaaaaaaaaaaaaaaa";
            // 
            // LabelDifficulty
            // 
            this.LabelDifficulty.AutoSize = true;
            this.LabelDifficulty.Location = new System.Drawing.Point(3, 3);
            this.LabelDifficulty.Name = "LabelDifficulty";
            this.LabelDifficulty.Size = new System.Drawing.Size(113, 19);
            this.LabelDifficulty.TabIndex = 3;
            this.LabelDifficulty.Text = "Poziom trudności:";
            // 
            // PictureRecipe
            // 
            this.PictureRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureRecipe.Location = new System.Drawing.Point(393, 3);
            this.PictureRecipe.Name = "PictureRecipe";
            this.PictureRecipe.Size = new System.Drawing.Size(182, 102);
            this.PictureRecipe.TabIndex = 3;
            this.PictureRecipe.TabStop = false;
            // 
            // PanelTopLeft
            // 
            this.PanelTopLeft.Controls.Add(this.LabelCategoryText);
            this.PanelTopLeft.Controls.Add(this.LabelCategory);
            this.PanelTopLeft.Controls.Add(this.LabelAuthorText);
            this.PanelTopLeft.Controls.Add(this.LabelAuthor);
            this.PanelTopLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelTopLeft.HorizontalScrollbarBarColor = true;
            this.PanelTopLeft.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelTopLeft.HorizontalScrollbarSize = 10;
            this.PanelTopLeft.Location = new System.Drawing.Point(0, 0);
            this.PanelTopLeft.Name = "PanelTopLeft";
            this.PanelTopLeft.Size = new System.Drawing.Size(350, 108);
            this.PanelTopLeft.TabIndex = 1;
            this.PanelTopLeft.VerticalScrollbarBarColor = true;
            this.PanelTopLeft.VerticalScrollbarHighlightOnWheel = false;
            this.PanelTopLeft.VerticalScrollbarSize = 10;
            // 
            // LabelCategoryText
            // 
            this.LabelCategoryText.AutoSize = true;
            this.LabelCategoryText.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LabelCategoryText.Location = new System.Drawing.Point(3, 79);
            this.LabelCategoryText.Name = "LabelCategoryText";
            this.LabelCategoryText.Size = new System.Drawing.Size(192, 25);
            this.LabelCategoryText.TabIndex = 6;
            this.LabelCategoryText.Text = "aaaaaaaaaaaaaaaaaaaa";
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Location = new System.Drawing.Point(3, 60);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(68, 19);
            this.LabelCategory.TabIndex = 5;
            this.LabelCategory.Text = "Kategoria:";
            // 
            // LabelAuthorText
            // 
            this.LabelAuthorText.AutoSize = true;
            this.LabelAuthorText.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LabelAuthorText.Location = new System.Drawing.Point(3, 22);
            this.LabelAuthorText.Name = "LabelAuthorText";
            this.LabelAuthorText.Size = new System.Drawing.Size(192, 25);
            this.LabelAuthorText.TabIndex = 4;
            this.LabelAuthorText.Text = "aaaaaaaaaaaaaaaaaaaa";
            // 
            // LabelAuthor
            // 
            this.LabelAuthor.AutoSize = true;
            this.LabelAuthor.Location = new System.Drawing.Point(3, 3);
            this.LabelAuthor.Name = "LabelAuthor";
            this.LabelAuthor.Size = new System.Drawing.Size(50, 19);
            this.LabelAuthor.TabIndex = 3;
            this.LabelAuthor.Text = "Autor: ";
            // 
            // LabelIngredients
            // 
            this.LabelIngredients.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LabelIngredients.Location = new System.Drawing.Point(3, 2);
            this.LabelIngredients.Name = "LabelIngredients";
            this.LabelIngredients.Size = new System.Drawing.Size(228, 25);
            this.LabelIngredients.TabIndex = 5;
            this.LabelIngredients.Text = "Składniki:";
            // 
            // LabelSteps
            // 
            this.LabelSteps.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LabelSteps.Location = new System.Drawing.Point(0, 0);
            this.LabelSteps.Name = "LabelSteps";
            this.LabelSteps.Size = new System.Drawing.Size(530, 25);
            this.LabelSteps.TabIndex = 6;
            this.LabelSteps.Text = "Wykonanie:";
            // 
            // PanelIngredients
            // 
            this.PanelIngredients.Controls.Add(this.TextBoxIngredients);
            this.PanelIngredients.Controls.Add(this.LabelIngredients);
            this.PanelIngredients.HorizontalScrollbarBarColor = true;
            this.PanelIngredients.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelIngredients.HorizontalScrollbarSize = 10;
            this.PanelIngredients.Location = new System.Drawing.Point(20, 174);
            this.PanelIngredients.Name = "PanelIngredients";
            this.PanelIngredients.Size = new System.Drawing.Size(350, 403);
            this.PanelIngredients.TabIndex = 5;
            this.PanelIngredients.VerticalScrollbarBarColor = true;
            this.PanelIngredients.VerticalScrollbarHighlightOnWheel = false;
            this.PanelIngredients.VerticalScrollbarSize = 10;
            // 
            // TextBoxIngredients
            // 
            this.TextBoxIngredients.BackColor = System.Drawing.Color.White;
            this.TextBoxIngredients.Enabled = false;
            this.TextBoxIngredients.Lines = new string[0];
            this.TextBoxIngredients.Location = new System.Drawing.Point(3, 30);
            this.TextBoxIngredients.MaxLength = 32767;
            this.TextBoxIngredients.Multiline = true;
            this.TextBoxIngredients.Name = "TextBoxIngredients";
            this.TextBoxIngredients.PasswordChar = '\0';
            this.TextBoxIngredients.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxIngredients.SelectedText = "";
            this.TextBoxIngredients.Size = new System.Drawing.Size(344, 370);
            this.TextBoxIngredients.Style = MetroFramework.MetroColorStyle.Teal;
            this.TextBoxIngredients.TabIndex = 6;
            this.TextBoxIngredients.UseSelectable = true;
            // 
            // PanelSteps
            // 
            this.PanelSteps.Controls.Add(this.TextBoxSteps);
            this.PanelSteps.Controls.Add(this.LabelSteps);
            this.PanelSteps.HorizontalScrollbarBarColor = true;
            this.PanelSteps.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelSteps.HorizontalScrollbarSize = 10;
            this.PanelSteps.Location = new System.Drawing.Point(413, 176);
            this.PanelSteps.Name = "PanelSteps";
            this.PanelSteps.Size = new System.Drawing.Size(564, 401);
            this.PanelSteps.TabIndex = 6;
            this.PanelSteps.VerticalScrollbarBarColor = true;
            this.PanelSteps.VerticalScrollbarHighlightOnWheel = false;
            this.PanelSteps.VerticalScrollbarSize = 10;
            // 
            // TextBoxSteps
            // 
            this.TextBoxSteps.Enabled = false;
            this.TextBoxSteps.Lines = new string[0];
            this.TextBoxSteps.Location = new System.Drawing.Point(3, 28);
            this.TextBoxSteps.MaxLength = 32767;
            this.TextBoxSteps.Multiline = true;
            this.TextBoxSteps.Name = "TextBoxSteps";
            this.TextBoxSteps.PasswordChar = '\0';
            this.TextBoxSteps.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxSteps.SelectedText = "";
            this.TextBoxSteps.Size = new System.Drawing.Size(558, 373);
            this.TextBoxSteps.TabIndex = 7;
            this.TextBoxSteps.UseSelectable = true;
            // 
            // styleManager
            // 
            this.styleManager.Owner = null;
            // 
            // FormRecipeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.PanelSteps);
            this.Controls.Add(this.PanelIngredients);
            this.Controls.Add(this.PanelTop);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormRecipeView";
            this.Text = "Tytuł przepisu tutaj";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThisFormClosing);
            this.Load += new System.EventHandler(this.ThisFormLoad);
            this.PanelTop.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureRecipe)).EndInit();
            this.PanelTopLeft.ResumeLayout(false);
            this.PanelTopLeft.PerformLayout();
            this.PanelIngredients.ResumeLayout(false);
            this.PanelSteps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.styleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private void SetUpStyle(MetroStyleManager manago)
        {
            this.StyleManager = manago;
            this.styleManager = manago;
            this.PanelTop.StyleManager = styleManager;
            this.PanelTopLeft.StyleManager = styleManager;
            this.LabelCategory.StyleManager = styleManager;
            this.LabelAuthorText.StyleManager = styleManager;
            this.LabelAuthor.StyleManager = styleManager;
            this.metroPanel1.StyleManager = styleManager;
            this.LabelTime.StyleManager = styleManager;
            this.LabelDifficultyText.StyleManager = styleManager;
            this.LabelDifficulty.StyleManager = styleManager;
            this.LabelTimeText.StyleManager = styleManager;
            this.LabelCategoryText.StyleManager = styleManager;
            this.LabelIngredients.StyleManager = styleManager;
            this.LabelSteps.StyleManager = styleManager;
            this.PanelIngredients.StyleManager = styleManager;
            this.TextBoxIngredients.StyleManager = styleManager;
            this.PanelSteps.StyleManager = styleManager;
            this.TextBoxSteps.StyleManager = styleManager;
        }

        private MetroFramework.Controls.MetroPanel PanelTop;
        private MetroFramework.Controls.MetroPanel PanelTopLeft;
        private System.Windows.Forms.PictureBox PictureRecipe;
        private MetroFramework.Controls.MetroLabel LabelCategory;
        private MetroFramework.Controls.MetroLabel LabelAuthorText;
        private MetroFramework.Controls.MetroLabel LabelAuthor;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel LabelTime;
        private MetroFramework.Controls.MetroLabel LabelDifficultyText;
        private MetroFramework.Controls.MetroLabel LabelDifficulty;
        private MetroFramework.Controls.MetroLabel LabelTimeText;
        private MetroFramework.Controls.MetroLabel LabelCategoryText;
        private MetroFramework.Controls.MetroLabel LabelIngredients;
        private MetroFramework.Controls.MetroLabel LabelSteps;
        private MetroFramework.Controls.MetroPanel PanelIngredients;
        private MetroFramework.Controls.MetroTextBox TextBoxIngredients;
        private MetroFramework.Controls.MetroPanel PanelSteps;
        private MetroFramework.Controls.MetroTextBox TextBoxSteps;
        private MetroFramework.Components.MetroStyleManager styleManager;
    }
}