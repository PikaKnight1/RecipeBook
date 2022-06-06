using MetroFramework.Components;

namespace RecipeBook48
{
    partial class FormWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWelcome));
            this.DateTimeCurrent = new MetroFramework.Controls.MetroDateTime();
            this.styleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.TileSetUp = new MetroFramework.Controls.MetroTile();
            this.TileRandomRecipe = new MetroFramework.Controls.MetroTile();
            this.TileAddRecipe = new MetroFramework.Controls.MetroTile();
            this.TileRecipeList = new MetroFramework.Controls.MetroTile();
            this.TileAdminPanel = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.styleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTimeCurrent
            // 
            this.DateTimeCurrent.Checked = false;
            this.DateTimeCurrent.Enabled = false;
            this.DateTimeCurrent.FontSize = MetroFramework.MetroDateTimeSize.Tall;
            this.DateTimeCurrent.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
            this.DateTimeCurrent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DateTimeCurrent.Location = new System.Drawing.Point(358, 542);
            this.DateTimeCurrent.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.DateTimeCurrent.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.DateTimeCurrent.MinimumSize = new System.Drawing.Size(0, 35);
            this.DateTimeCurrent.Name = "DateTimeCurrent";
            this.DateTimeCurrent.Size = new System.Drawing.Size(274, 35);
            this.DateTimeCurrent.TabIndex = 5;
            // 
            // styleManager
            // 
            this.styleManager.Owner = null;
            // 
            // TileSetUp
            // 
            this.TileSetUp.ActiveControl = null;
            this.TileSetUp.Location = new System.Drawing.Point(187, 269);
            this.TileSetUp.Name = "TileSetUp";
            this.TileSetUp.Size = new System.Drawing.Size(300, 150);
            this.TileSetUp.TabIndex = 4;
            this.TileSetUp.Text = "Ustawienia";
            this.TileSetUp.TileImage = ((System.Drawing.Image)(resources.GetObject("TileSetUp.TileImage")));
            this.TileSetUp.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TileSetUp.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TileSetUp.UseSelectable = true;
            this.TileSetUp.UseTileImage = true;
            this.TileSetUp.Click += new System.EventHandler(this.TileSetUpClick);
            // 
            // TileRandomRecipe
            // 
            this.TileRandomRecipe.ActiveControl = null;
            this.TileRandomRecipe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TileRandomRecipe.Location = new System.Drawing.Point(350, 101);
            this.TileRandomRecipe.Name = "TileRandomRecipe";
            this.TileRandomRecipe.Size = new System.Drawing.Size(300, 150);
            this.TileRandomRecipe.TabIndex = 3;
            this.TileRandomRecipe.Text = "Losowy przepis";
            this.TileRandomRecipe.TileImage = ((System.Drawing.Image)(resources.GetObject("TileRandomRecipe.TileImage")));
            this.TileRandomRecipe.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TileRandomRecipe.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TileRandomRecipe.UseSelectable = true;
            this.TileRandomRecipe.UseTileImage = true;
            this.TileRandomRecipe.Click += new System.EventHandler(this.TileRandomRecipeClick);
            // 
            // TileAddRecipe
            // 
            this.TileAddRecipe.ActiveControl = null;
            this.TileAddRecipe.Location = new System.Drawing.Point(675, 101);
            this.TileAddRecipe.Name = "TileAddRecipe";
            this.TileAddRecipe.Size = new System.Drawing.Size(300, 150);
            this.TileAddRecipe.TabIndex = 1;
            this.TileAddRecipe.Text = "Dodaj przepis";
            this.TileAddRecipe.TileImage = global::RecipeBook48.Properties.Resources.img2;
            this.TileAddRecipe.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TileAddRecipe.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TileAddRecipe.UseSelectable = true;
            this.TileAddRecipe.UseTileImage = true;
            this.TileAddRecipe.Click += new System.EventHandler(this.TileAddRecipeClick);
            // 
            // TileRecipeList
            // 
            this.TileRecipeList.ActiveControl = null;
            this.TileRecipeList.Location = new System.Drawing.Point(25, 101);
            this.TileRecipeList.Name = "TileRecipeList";
            this.TileRecipeList.Size = new System.Drawing.Size(300, 150);
            this.TileRecipeList.TabIndex = 0;
            this.TileRecipeList.Text = "Lista przepisów";
            this.TileRecipeList.TileImage = ((System.Drawing.Image)(resources.GetObject("TileRecipeList.TileImage")));
            this.TileRecipeList.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileRecipeList.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TileRecipeList.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TileRecipeList.UseSelectable = true;
            this.TileRecipeList.UseStyleColors = true;
            this.TileRecipeList.UseTileImage = true;
            this.TileRecipeList.Click += new System.EventHandler(this.TileRecipeListClick);
            // 
            // TileAdminPanel
            // 
            this.TileAdminPanel.ActiveControl = null;
            this.TileAdminPanel.Location = new System.Drawing.Point(512, 269);
            this.TileAdminPanel.Name = "TileAdminPanel";
            this.TileAdminPanel.Size = new System.Drawing.Size(300, 150);
            this.TileAdminPanel.TabIndex = 6;
            this.TileAdminPanel.Text = "Panel Administratora";
            this.TileAdminPanel.TileImage = ((System.Drawing.Image)(resources.GetObject("TileAdminPanel.TileImage")));
            this.TileAdminPanel.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TileAdminPanel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TileAdminPanel.UseSelectable = true;
            this.TileAdminPanel.UseTileImage = true;
            this.TileAdminPanel.Click += new System.EventHandler(this.TileAdminPanelClick);
            // 
            // FormWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.TileAdminPanel);
            this.Controls.Add(this.DateTimeCurrent);
            this.Controls.Add(this.TileSetUp);
            this.Controls.Add(this.TileRandomRecipe);
            this.Controls.Add(this.TileAddRecipe);
            this.Controls.Add(this.TileRecipeList);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormWelcome";
            this.Text = "Przepisy - Witaj!";
            this.TransparencyKey = System.Drawing.SystemColors.InactiveBorder;
            this.Load += new System.EventHandler(this.ThisFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.styleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private void SetUpStyle(MetroStyleManager manago)
        {
            this.StyleManager = manago;
            this.styleManager = manago;
            this.TileRandomRecipe.StyleManager = styleManager;
            this.TileAddRecipe.StyleManager = styleManager;
            this.TileSetUp.StyleManager = styleManager;
            this.TileRecipeList.StyleManager = styleManager;
            this.DateTimeCurrent.StyleManager = styleManager;
            this.TileAdminPanel.StyleManager = styleManager;
        }

        private MetroFramework.Controls.MetroTile TileRecipeList;
        private MetroFramework.Controls.MetroTile TileAddRecipe;
        private MetroFramework.Controls.MetroTile TileRandomRecipe;
        private MetroFramework.Controls.MetroTile TileSetUp;
        private MetroFramework.Controls.MetroDateTime DateTimeCurrent;
        private MetroFramework.Components.MetroStyleManager styleManager;
        private MetroFramework.Controls.MetroTile TileAdminPanel;
    }
}