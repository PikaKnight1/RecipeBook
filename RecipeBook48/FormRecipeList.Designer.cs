using MetroFramework.Components;

namespace RecipeBook48
{
    partial class FormRecipeList
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
            this.PanelLeft = new MetroFramework.Controls.MetroPanel();
            this.PanelCategories = new MetroFramework.Controls.MetroPanel();
            this.RadioCatOthers = new MetroFramework.Controls.MetroRadioButton();
            this.RadioCatCakes = new MetroFramework.Controls.MetroRadioButton();
            this.RadioCatSoup = new MetroFramework.Controls.MetroRadioButton();
            this.RadioCatFast = new MetroFramework.Controls.MetroRadioButton();
            this.RadioCatDinner = new MetroFramework.Controls.MetroRadioButton();
            this.RadioCatAny = new MetroFramework.Controls.MetroRadioButton();
            this.LabelCategory = new MetroFramework.Controls.MetroLabel();
            this.PanelTime = new MetroFramework.Controls.MetroPanel();
            this.RadioTimeLong = new MetroFramework.Controls.MetroRadioButton();
            this.RadioTimeShort = new MetroFramework.Controls.MetroRadioButton();
            this.RadioTimeMedium = new MetroFramework.Controls.MetroRadioButton();
            this.RadioTimeAny = new MetroFramework.Controls.MetroRadioButton();
            this.LabelTime = new MetroFramework.Controls.MetroLabel();
            this.PanelDifficulty = new MetroFramework.Controls.MetroPanel();
            this.RadioDiffHard = new MetroFramework.Controls.MetroRadioButton();
            this.RadioDiffEasy = new MetroFramework.Controls.MetroRadioButton();
            this.RadioDiffMedium = new MetroFramework.Controls.MetroRadioButton();
            this.RadioDiffAny = new MetroFramework.Controls.MetroRadioButton();
            this.LabelDifficulty = new MetroFramework.Controls.MetroLabel();
            this.PanelSort = new MetroFramework.Controls.MetroPanel();
            this.RadioSortDateOld = new MetroFramework.Controls.MetroRadioButton();
            this.RadioSortZA = new MetroFramework.Controls.MetroRadioButton();
            this.RadioSortDateNew = new MetroFramework.Controls.MetroRadioButton();
            this.RadioSortAZ = new MetroFramework.Controls.MetroRadioButton();
            this.LabelSort = new MetroFramework.Controls.MetroLabel();
            this.ButtonRandomRecipe = new MetroFramework.Controls.MetroButton();
            this.PanelTop = new MetroFramework.Controls.MetroPanel();
            this.TextBoxSearch = new MetroFramework.Controls.MetroTextBox();
            this.ButtonSearch = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.styleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.PanelLeft.SuspendLayout();
            this.PanelCategories.SuspendLayout();
            this.PanelTime.SuspendLayout();
            this.PanelDifficulty.SuspendLayout();
            this.PanelSort.SuspendLayout();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.styleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.Controls.Add(this.PanelCategories);
            this.PanelLeft.Controls.Add(this.PanelTime);
            this.PanelLeft.Controls.Add(this.PanelDifficulty);
            this.PanelLeft.Controls.Add(this.PanelSort);
            this.PanelLeft.Controls.Add(this.ButtonRandomRecipe);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.HorizontalScrollbarBarColor = true;
            this.PanelLeft.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelLeft.HorizontalScrollbarSize = 10;
            this.PanelLeft.Location = new System.Drawing.Point(20, 60);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(149, 520);
            this.PanelLeft.TabIndex = 0;
            this.PanelLeft.VerticalScrollbarBarColor = true;
            this.PanelLeft.VerticalScrollbarHighlightOnWheel = false;
            this.PanelLeft.VerticalScrollbarSize = 10;
            // 
            // PanelCategories
            // 
            this.PanelCategories.Controls.Add(this.RadioCatOthers);
            this.PanelCategories.Controls.Add(this.RadioCatCakes);
            this.PanelCategories.Controls.Add(this.RadioCatSoup);
            this.PanelCategories.Controls.Add(this.RadioCatFast);
            this.PanelCategories.Controls.Add(this.RadioCatDinner);
            this.PanelCategories.Controls.Add(this.RadioCatAny);
            this.PanelCategories.Controls.Add(this.LabelCategory);
            this.PanelCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCategories.HorizontalScrollbarBarColor = true;
            this.PanelCategories.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelCategories.HorizontalScrollbarSize = 10;
            this.PanelCategories.Location = new System.Drawing.Point(0, 359);
            this.PanelCategories.Name = "PanelCategories";
            this.PanelCategories.Size = new System.Drawing.Size(149, 146);
            this.PanelCategories.TabIndex = 5;
            this.PanelCategories.VerticalScrollbarBarColor = true;
            this.PanelCategories.VerticalScrollbarHighlightOnWheel = false;
            this.PanelCategories.VerticalScrollbarSize = 10;
            // 
            // RadioCatOthers
            // 
            this.RadioCatOthers.AutoSize = true;
            this.RadioCatOthers.Location = new System.Drawing.Point(3, 130);
            this.RadioCatOthers.Name = "RadioCatOthers";
            this.RadioCatOthers.Size = new System.Drawing.Size(73, 15);
            this.RadioCatOthers.TabIndex = 8;
            this.RadioCatOthers.Text = "Pozostałe";
            this.RadioCatOthers.UseSelectable = true;
            // 
            // RadioCatCakes
            // 
            this.RadioCatCakes.AutoSize = true;
            this.RadioCatCakes.Location = new System.Drawing.Point(3, 109);
            this.RadioCatCakes.Name = "RadioCatCakes";
            this.RadioCatCakes.Size = new System.Drawing.Size(100, 15);
            this.RadioCatCakes.TabIndex = 7;
            this.RadioCatCakes.Text = "Ciasta i ciastka";
            this.RadioCatCakes.UseSelectable = true;
            // 
            // RadioCatSoup
            // 
            this.RadioCatSoup.AutoSize = true;
            this.RadioCatSoup.Location = new System.Drawing.Point(4, 88);
            this.RadioCatSoup.Name = "RadioCatSoup";
            this.RadioCatSoup.Size = new System.Drawing.Size(50, 15);
            this.RadioCatSoup.TabIndex = 6;
            this.RadioCatSoup.Text = "Zupy";
            this.RadioCatSoup.UseSelectable = true;
            // 
            // RadioCatFast
            // 
            this.RadioCatFast.AutoSize = true;
            this.RadioCatFast.Location = new System.Drawing.Point(4, 46);
            this.RadioCatFast.Name = "RadioCatFast";
            this.RadioCatFast.Size = new System.Drawing.Size(113, 15);
            this.RadioCatFast.TabIndex = 5;
            this.RadioCatFast.Text = "Szybkie przekąski";
            this.RadioCatFast.UseSelectable = true;
            // 
            // RadioCatDinner
            // 
            this.RadioCatDinner.AutoSize = true;
            this.RadioCatDinner.Location = new System.Drawing.Point(4, 67);
            this.RadioCatDinner.Name = "RadioCatDinner";
            this.RadioCatDinner.Size = new System.Drawing.Size(96, 15);
            this.RadioCatDinner.TabIndex = 4;
            this.RadioCatDinner.Text = "Dania Główne";
            this.RadioCatDinner.UseSelectable = true;
            // 
            // RadioCatAny
            // 
            this.RadioCatAny.AutoSize = true;
            this.RadioCatAny.Checked = true;
            this.RadioCatAny.Location = new System.Drawing.Point(4, 25);
            this.RadioCatAny.Name = "RadioCatAny";
            this.RadioCatAny.Size = new System.Drawing.Size(70, 15);
            this.RadioCatAny.TabIndex = 3;
            this.RadioCatAny.TabStop = true;
            this.RadioCatAny.Text = "Dowolny";
            this.RadioCatAny.UseSelectable = true;
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Location = new System.Drawing.Point(4, 2);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(83, 19);
            this.LabelCategory.TabIndex = 2;
            this.LabelCategory.Text = "Typ potrawy:";
            // 
            // PanelTime
            // 
            this.PanelTime.Controls.Add(this.RadioTimeLong);
            this.PanelTime.Controls.Add(this.RadioTimeShort);
            this.PanelTime.Controls.Add(this.RadioTimeMedium);
            this.PanelTime.Controls.Add(this.RadioTimeAny);
            this.PanelTime.Controls.Add(this.LabelTime);
            this.PanelTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTime.HorizontalScrollbarBarColor = true;
            this.PanelTime.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelTime.HorizontalScrollbarSize = 10;
            this.PanelTime.Location = new System.Drawing.Point(0, 249);
            this.PanelTime.Name = "PanelTime";
            this.PanelTime.Size = new System.Drawing.Size(149, 110);
            this.PanelTime.TabIndex = 4;
            this.PanelTime.VerticalScrollbarBarColor = true;
            this.PanelTime.VerticalScrollbarHighlightOnWheel = false;
            this.PanelTime.VerticalScrollbarSize = 10;
            // 
            // RadioTimeLong
            // 
            this.RadioTimeLong.AutoSize = true;
            this.RadioTimeLong.Location = new System.Drawing.Point(4, 88);
            this.RadioTimeLong.Name = "RadioTimeLong";
            this.RadioTimeLong.Size = new System.Drawing.Size(86, 15);
            this.RadioTimeLong.TabIndex = 6;
            this.RadioTimeLong.Text = "Do 2 godzin";
            this.RadioTimeLong.UseSelectable = true;
            // 
            // RadioTimeShort
            // 
            this.RadioTimeShort.AutoSize = true;
            this.RadioTimeShort.Location = new System.Drawing.Point(4, 46);
            this.RadioTimeShort.Name = "RadioTimeShort";
            this.RadioTimeShort.Size = new System.Drawing.Size(88, 15);
            this.RadioTimeShort.TabIndex = 5;
            this.RadioTimeShort.Text = "Do 30 minut";
            this.RadioTimeShort.UseSelectable = true;
            // 
            // RadioTimeMedium
            // 
            this.RadioTimeMedium.AutoSize = true;
            this.RadioTimeMedium.Location = new System.Drawing.Point(4, 67);
            this.RadioTimeMedium.Name = "RadioTimeMedium";
            this.RadioTimeMedium.Size = new System.Drawing.Size(88, 15);
            this.RadioTimeMedium.TabIndex = 4;
            this.RadioTimeMedium.Text = "Do 60 minut";
            this.RadioTimeMedium.UseSelectable = true;
            // 
            // RadioTimeAny
            // 
            this.RadioTimeAny.AutoSize = true;
            this.RadioTimeAny.Checked = true;
            this.RadioTimeAny.Location = new System.Drawing.Point(4, 25);
            this.RadioTimeAny.Name = "RadioTimeAny";
            this.RadioTimeAny.Size = new System.Drawing.Size(70, 15);
            this.RadioTimeAny.TabIndex = 3;
            this.RadioTimeAny.TabStop = true;
            this.RadioTimeAny.Text = "Dowolny";
            this.RadioTimeAny.UseSelectable = true;
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Location = new System.Drawing.Point(4, 2);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(129, 19);
            this.LabelTime.TabIndex = 2;
            this.LabelTime.Text = "Czas przygotowania:";
            // 
            // PanelDifficulty
            // 
            this.PanelDifficulty.Controls.Add(this.RadioDiffHard);
            this.PanelDifficulty.Controls.Add(this.RadioDiffEasy);
            this.PanelDifficulty.Controls.Add(this.RadioDiffMedium);
            this.PanelDifficulty.Controls.Add(this.RadioDiffAny);
            this.PanelDifficulty.Controls.Add(this.LabelDifficulty);
            this.PanelDifficulty.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelDifficulty.HorizontalScrollbarBarColor = true;
            this.PanelDifficulty.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelDifficulty.HorizontalScrollbarSize = 10;
            this.PanelDifficulty.Location = new System.Drawing.Point(0, 139);
            this.PanelDifficulty.Name = "PanelDifficulty";
            this.PanelDifficulty.Size = new System.Drawing.Size(149, 110);
            this.PanelDifficulty.TabIndex = 3;
            this.PanelDifficulty.VerticalScrollbarBarColor = true;
            this.PanelDifficulty.VerticalScrollbarHighlightOnWheel = false;
            this.PanelDifficulty.VerticalScrollbarSize = 10;
            // 
            // RadioDiffHard
            // 
            this.RadioDiffHard.AutoSize = true;
            this.RadioDiffHard.Location = new System.Drawing.Point(4, 88);
            this.RadioDiffHard.Name = "RadioDiffHard";
            this.RadioDiffHard.Size = new System.Drawing.Size(59, 15);
            this.RadioDiffHard.TabIndex = 6;
            this.RadioDiffHard.Text = "Trudny";
            this.RadioDiffHard.UseSelectable = true;
            // 
            // RadioDiffEasy
            // 
            this.RadioDiffEasy.AutoSize = true;
            this.RadioDiffEasy.Location = new System.Drawing.Point(4, 46);
            this.RadioDiffEasy.Name = "RadioDiffEasy";
            this.RadioDiffEasy.Size = new System.Drawing.Size(54, 15);
            this.RadioDiffEasy.TabIndex = 5;
            this.RadioDiffEasy.Text = "Łatwy";
            this.RadioDiffEasy.UseSelectable = true;
            // 
            // RadioDiffMedium
            // 
            this.RadioDiffMedium.AutoSize = true;
            this.RadioDiffMedium.Location = new System.Drawing.Point(4, 67);
            this.RadioDiffMedium.Name = "RadioDiffMedium";
            this.RadioDiffMedium.Size = new System.Drawing.Size(56, 15);
            this.RadioDiffMedium.TabIndex = 4;
            this.RadioDiffMedium.Text = "Średni";
            this.RadioDiffMedium.UseSelectable = true;
            // 
            // RadioDiffAny
            // 
            this.RadioDiffAny.AutoSize = true;
            this.RadioDiffAny.Checked = true;
            this.RadioDiffAny.Location = new System.Drawing.Point(4, 25);
            this.RadioDiffAny.Name = "RadioDiffAny";
            this.RadioDiffAny.Size = new System.Drawing.Size(70, 15);
            this.RadioDiffAny.TabIndex = 3;
            this.RadioDiffAny.TabStop = true;
            this.RadioDiffAny.Text = "Dowolny";
            this.RadioDiffAny.UseSelectable = true;
            // 
            // LabelDifficulty
            // 
            this.LabelDifficulty.AutoSize = true;
            this.LabelDifficulty.Location = new System.Drawing.Point(4, 2);
            this.LabelDifficulty.Name = "LabelDifficulty";
            this.LabelDifficulty.Size = new System.Drawing.Size(113, 19);
            this.LabelDifficulty.TabIndex = 2;
            this.LabelDifficulty.Text = "Poziom trudności:";
            // 
            // PanelSort
            // 
            this.PanelSort.Controls.Add(this.RadioSortDateOld);
            this.PanelSort.Controls.Add(this.RadioSortZA);
            this.PanelSort.Controls.Add(this.RadioSortDateNew);
            this.PanelSort.Controls.Add(this.RadioSortAZ);
            this.PanelSort.Controls.Add(this.LabelSort);
            this.PanelSort.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSort.HorizontalScrollbarBarColor = true;
            this.PanelSort.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelSort.HorizontalScrollbarSize = 10;
            this.PanelSort.Location = new System.Drawing.Point(0, 29);
            this.PanelSort.Name = "PanelSort";
            this.PanelSort.Size = new System.Drawing.Size(149, 110);
            this.PanelSort.TabIndex = 2;
            this.PanelSort.VerticalScrollbarBarColor = true;
            this.PanelSort.VerticalScrollbarHighlightOnWheel = false;
            this.PanelSort.VerticalScrollbarSize = 10;
            // 
            // RadioSortDateOld
            // 
            this.RadioSortDateOld.AutoSize = true;
            this.RadioSortDateOld.Location = new System.Drawing.Point(4, 88);
            this.RadioSortDateOld.Name = "RadioSortDateOld";
            this.RadioSortDateOld.Size = new System.Drawing.Size(106, 15);
            this.RadioSortDateOld.TabIndex = 6;
            this.RadioSortDateOld.Text = "Od najstarszych";
            this.RadioSortDateOld.UseSelectable = true;
            // 
            // RadioSortZA
            // 
            this.RadioSortZA.AutoSize = true;
            this.RadioSortZA.Location = new System.Drawing.Point(4, 46);
            this.RadioSortZA.Name = "RadioSortZA";
            this.RadioSortZA.Size = new System.Drawing.Size(117, 15);
            this.RadioSortZA.TabIndex = 5;
            this.RadioSortZA.Text = "Alfabetycznie Z-A";
            this.RadioSortZA.UseSelectable = true;
            // 
            // RadioSortDateNew
            // 
            this.RadioSortDateNew.AutoSize = true;
            this.RadioSortDateNew.Location = new System.Drawing.Point(4, 67);
            this.RadioSortDateNew.Name = "RadioSortDateNew";
            this.RadioSortDateNew.Size = new System.Drawing.Size(110, 15);
            this.RadioSortDateNew.TabIndex = 4;
            this.RadioSortDateNew.Text = "Od najnowszych";
            this.RadioSortDateNew.UseSelectable = true;
            // 
            // RadioSortAZ
            // 
            this.RadioSortAZ.AutoSize = true;
            this.RadioSortAZ.Checked = true;
            this.RadioSortAZ.Location = new System.Drawing.Point(4, 25);
            this.RadioSortAZ.Name = "RadioSortAZ";
            this.RadioSortAZ.Size = new System.Drawing.Size(114, 15);
            this.RadioSortAZ.TabIndex = 3;
            this.RadioSortAZ.TabStop = true;
            this.RadioSortAZ.Text = "Alfabetyczne A-Z";
            this.RadioSortAZ.UseSelectable = true;
            // 
            // LabelSort
            // 
            this.LabelSort.AutoSize = true;
            this.LabelSort.Location = new System.Drawing.Point(4, 2);
            this.LabelSort.Name = "LabelSort";
            this.LabelSort.Size = new System.Drawing.Size(78, 19);
            this.LabelSort.TabIndex = 2;
            this.LabelSort.Text = "Sortowanie:";
            // 
            // ButtonRandomRecipe
            // 
            this.ButtonRandomRecipe.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonRandomRecipe.Location = new System.Drawing.Point(0, 0);
            this.ButtonRandomRecipe.Name = "ButtonRandomRecipe";
            this.ButtonRandomRecipe.Size = new System.Drawing.Size(149, 29);
            this.ButtonRandomRecipe.TabIndex = 1;
            this.ButtonRandomRecipe.Text = "Wylosuj coś dla mnie!";
            this.ButtonRandomRecipe.UseSelectable = true;
            this.ButtonRandomRecipe.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.TextBoxSearch);
            this.PanelTop.Controls.Add(this.ButtonSearch);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.HorizontalScrollbarBarColor = true;
            this.PanelTop.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelTop.HorizontalScrollbarSize = 10;
            this.PanelTop.Location = new System.Drawing.Point(169, 60);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(811, 37);
            this.PanelTop.TabIndex = 1;
            this.PanelTop.VerticalScrollbarBarColor = true;
            this.PanelTop.VerticalScrollbarHighlightOnWheel = false;
            this.PanelTop.VerticalScrollbarSize = 10;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBoxSearch.Lines = new string[] {
        "Tu wpisz nazwę szukanego dania..."};
            this.TextBoxSearch.Location = new System.Drawing.Point(406, 0);
            this.TextBoxSearch.MaxLength = 32767;
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.PasswordChar = '\0';
            this.TextBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxSearch.SelectedText = "";
            this.TextBoxSearch.Size = new System.Drawing.Size(253, 29);
            this.TextBoxSearch.TabIndex = 2;
            this.TextBoxSearch.Text = "Tu wpisz nazwę szukanego dania...";
            this.TextBoxSearch.UseSelectable = true;
            this.TextBoxSearch.Click += new System.EventHandler(this.TextBoxSearch_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSearch.Location = new System.Drawing.Point(665, 0);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(144, 29);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "Szukaj";
            this.ButtonSearch.UseSelectable = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(169, 97);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(811, 483);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // styleManager
            // 
            this.styleManager.Owner = null;
            // 
            // FormRecipeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelLeft);
            this.Name = "FormRecipeList";
            this.Text = "Przepisy - Lista Przepisów";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainMenu_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelLeft.ResumeLayout(false);
            this.PanelCategories.ResumeLayout(false);
            this.PanelCategories.PerformLayout();
            this.PanelTime.ResumeLayout(false);
            this.PanelTime.PerformLayout();
            this.PanelDifficulty.ResumeLayout(false);
            this.PanelDifficulty.PerformLayout();
            this.PanelSort.ResumeLayout(false);
            this.PanelSort.PerformLayout();
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.styleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private void SetUpStyle(MetroStyleManager manago)
        {
            this.StyleManager = manago;
            this.styleManager = manago;
            this.PanelLeft.StyleManager = styleManager;
            this.PanelCategories.StyleManager = styleManager;
            this.RadioCatOthers.StyleManager = styleManager;
            this.RadioCatCakes.StyleManager = styleManager;
            this.RadioCatSoup.StyleManager = styleManager;
            this.RadioCatFast.StyleManager = styleManager;
            this.RadioCatDinner.StyleManager = styleManager;
            this.RadioCatAny.StyleManager = styleManager;
            this.LabelCategory.StyleManager = styleManager;
            this.PanelTime.StyleManager = styleManager;
            this.RadioTimeLong.StyleManager = styleManager;
            this.RadioTimeShort.StyleManager = styleManager;
            this.RadioTimeMedium.StyleManager = styleManager;
            this.RadioTimeAny.StyleManager = styleManager;
            this.LabelTime.StyleManager = styleManager;
            this.PanelDifficulty.StyleManager = styleManager;
            this.RadioDiffHard.StyleManager = styleManager;
            this.RadioDiffEasy.StyleManager = styleManager;
            this.RadioDiffMedium.StyleManager = styleManager;
            this.RadioDiffAny.StyleManager = styleManager;
            this.LabelDifficulty.StyleManager = styleManager;
            this.PanelSort.StyleManager = styleManager;
            this.RadioSortDateOld.StyleManager = styleManager;
            this.RadioSortZA.StyleManager = styleManager;
            this.RadioSortDateNew.StyleManager = styleManager;
            this.RadioSortAZ.StyleManager = styleManager;
            this.LabelSort.StyleManager = styleManager;
            this.ButtonRandomRecipe.StyleManager = styleManager;
            this.PanelTop.StyleManager = styleManager;
            this.TextBoxSearch.StyleManager = styleManager;
            this.ButtonSearch.StyleManager = styleManager;
        }

        private MetroFramework.Controls.MetroPanel PanelLeft;
        private MetroFramework.Controls.MetroPanel PanelSort;
        private MetroFramework.Controls.MetroRadioButton RadioSortDateOld;
        private MetroFramework.Controls.MetroRadioButton RadioSortZA;
        private MetroFramework.Controls.MetroRadioButton RadioSortDateNew;
        private MetroFramework.Controls.MetroRadioButton RadioSortAZ;
        private MetroFramework.Controls.MetroLabel LabelSort;
        private MetroFramework.Controls.MetroPanel PanelDifficulty;
        private MetroFramework.Controls.MetroRadioButton RadioDiffHard;
        private MetroFramework.Controls.MetroRadioButton RadioDiffEasy;
        private MetroFramework.Controls.MetroRadioButton RadioDiffMedium;
        private MetroFramework.Controls.MetroRadioButton RadioDiffAny;
        private MetroFramework.Controls.MetroLabel LabelDifficulty;
        private MetroFramework.Controls.MetroButton ButtonRandomRecipe;
        private MetroFramework.Controls.MetroPanel PanelTime;
        private MetroFramework.Controls.MetroRadioButton RadioTimeLong;
        private MetroFramework.Controls.MetroRadioButton RadioTimeShort;
        private MetroFramework.Controls.MetroRadioButton RadioTimeMedium;
        private MetroFramework.Controls.MetroRadioButton RadioTimeAny;
        private MetroFramework.Controls.MetroLabel LabelTime;
        private MetroFramework.Controls.MetroPanel PanelTop;
        private MetroFramework.Controls.MetroTextBox TextBoxSearch;
        private MetroFramework.Controls.MetroButton ButtonSearch;
        private MetroFramework.Controls.MetroPanel PanelCategories;
        private MetroFramework.Controls.MetroRadioButton RadioCatOthers;
        private MetroFramework.Controls.MetroRadioButton RadioCatCakes;
        private MetroFramework.Controls.MetroRadioButton RadioCatSoup;
        private MetroFramework.Controls.MetroRadioButton RadioCatFast;
        private MetroFramework.Controls.MetroRadioButton RadioCatDinner;
        private MetroFramework.Controls.MetroRadioButton RadioCatAny;
        private MetroFramework.Controls.MetroLabel LabelCategory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public MetroStyleManager styleManager;
    }
}

