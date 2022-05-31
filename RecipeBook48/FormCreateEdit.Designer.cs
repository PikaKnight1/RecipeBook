using MetroFramework.Components;

namespace RecipeBook48
{
    partial class FormCreateEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateEdit));
            this.LabelRecName = new MetroFramework.Controls.MetroLabel();
            this.LabelRecDifficulty = new MetroFramework.Controls.MetroLabel();
            this.LabelRecTime = new MetroFramework.Controls.MetroLabel();
            this.TabsAddEditRecipe = new MetroFramework.Controls.MetroTabControl();
            this.TabBasics = new MetroFramework.Controls.MetroTabPage();
            this.PictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.TextBoxPhoto = new MetroFramework.Controls.MetroTextBox();
            this.ComboBoxCategory = new MetroFramework.Controls.MetroComboBox();
            this.TextBoxTime = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.RadioBtnHard = new MetroFramework.Controls.MetroRadioButton();
            this.RadioBtnMed = new MetroFramework.Controls.MetroRadioButton();
            this.RadioBtnEasy = new MetroFramework.Controls.MetroRadioButton();
            this.TextBoxRecName = new MetroFramework.Controls.MetroTextBox();
            this.LabelPhotoDesc = new MetroFramework.Controls.MetroLabel();
            this.LabelURLDesc = new MetroFramework.Controls.MetroLabel();
            this.LabelRecURLDesc = new MetroFramework.Controls.MetroLabel();
            this.LabelRecPhoto = new MetroFramework.Controls.MetroLabel();
            this.LabelRecCategory = new MetroFramework.Controls.MetroLabel();
            this.TabIng = new MetroFramework.Controls.MetroTabPage();
            this.GridIng = new MetroFramework.Controls.MetroGrid();
            this.IngName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ButtonAddIng = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.RadioBtnTypeSZT = new MetroFramework.Controls.MetroRadioButton();
            this.RadioBtnTypeSZCZ = new MetroFramework.Controls.MetroRadioButton();
            this.RadioBtnTypeLYZ = new MetroFramework.Controls.MetroRadioButton();
            this.RadioBtnTypeSZKL = new MetroFramework.Controls.MetroRadioButton();
            this.RadioBtnTypeL = new MetroFramework.Controls.MetroRadioButton();
            this.RadioBtnTypeML = new MetroFramework.Controls.MetroRadioButton();
            this.RadioBtnTypeKG = new MetroFramework.Controls.MetroRadioButton();
            this.RadioBtnTypeG = new MetroFramework.Controls.MetroRadioButton();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.LabelIngType = new MetroFramework.Controls.MetroLabel();
            this.LabelIngValue = new MetroFramework.Controls.MetroLabel();
            this.LabelIngName = new MetroFramework.Controls.MetroLabel();
            this.TabMaking = new MetroFramework.Controls.MetroTabPage();
            this.ButtonMakingAdd = new MetroFramework.Controls.MetroButton();
            this.TextBoxMaking = new MetroFramework.Controls.MetroTextBox();
            this.LabelMaking = new MetroFramework.Controls.MetroLabel();
            this.GridMaking = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabSend = new MetroFramework.Controls.MetroTabPage();
            this.ButtonSend = new MetroFramework.Controls.MetroButton();
            this.LabelInfoSend = new MetroFramework.Controls.MetroLabel();
            this.styleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.TabsAddEditRecipe.SuspendLayout();
            this.TabBasics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPhoto)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.TabIng.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridIng)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.TabMaking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMaking)).BeginInit();
            this.TabSend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.styleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelRecName
            // 
            this.LabelRecName.AutoSize = true;
            this.LabelRecName.Location = new System.Drawing.Point(3, 30);
            this.LabelRecName.Name = "LabelRecName";
            this.LabelRecName.Size = new System.Drawing.Size(104, 19);
            this.LabelRecName.TabIndex = 2;
            this.LabelRecName.Text = "Nazwa przepisu:";
            // 
            // LabelRecDifficulty
            // 
            this.LabelRecDifficulty.AutoSize = true;
            this.LabelRecDifficulty.Location = new System.Drawing.Point(3, 59);
            this.LabelRecDifficulty.Name = "LabelRecDifficulty";
            this.LabelRecDifficulty.Size = new System.Drawing.Size(113, 19);
            this.LabelRecDifficulty.TabIndex = 3;
            this.LabelRecDifficulty.Text = "Poziom trudności:";
            // 
            // LabelRecTime
            // 
            this.LabelRecTime.AutoSize = true;
            this.LabelRecTime.Location = new System.Drawing.Point(3, 92);
            this.LabelRecTime.Name = "LabelRecTime";
            this.LabelRecTime.Size = new System.Drawing.Size(266, 19);
            this.LabelRecTime.TabIndex = 4;
            this.LabelRecTime.Text = "Czas potrzebny na wykonanie (w minutach): ";
            // 
            // TabsAddEditRecipe
            // 
            this.TabsAddEditRecipe.Controls.Add(this.TabBasics);
            this.TabsAddEditRecipe.Controls.Add(this.TabIng);
            this.TabsAddEditRecipe.Controls.Add(this.TabMaking);
            this.TabsAddEditRecipe.Controls.Add(this.TabSend);
            this.TabsAddEditRecipe.Location = new System.Drawing.Point(23, 63);
            this.TabsAddEditRecipe.Name = "TabsAddEditRecipe";
            this.TabsAddEditRecipe.SelectedIndex = 0;
            this.TabsAddEditRecipe.Size = new System.Drawing.Size(954, 514);
            this.TabsAddEditRecipe.TabIndex = 5;
            this.TabsAddEditRecipe.UseSelectable = true;
            // 
            // TabBasics
            // 
            this.TabBasics.Controls.Add(this.PictureBoxPhoto);
            this.TabBasics.Controls.Add(this.TextBoxPhoto);
            this.TabBasics.Controls.Add(this.ComboBoxCategory);
            this.TabBasics.Controls.Add(this.TextBoxTime);
            this.TabBasics.Controls.Add(this.metroPanel1);
            this.TabBasics.Controls.Add(this.TextBoxRecName);
            this.TabBasics.Controls.Add(this.LabelPhotoDesc);
            this.TabBasics.Controls.Add(this.LabelURLDesc);
            this.TabBasics.Controls.Add(this.LabelRecURLDesc);
            this.TabBasics.Controls.Add(this.LabelRecPhoto);
            this.TabBasics.Controls.Add(this.LabelRecCategory);
            this.TabBasics.Controls.Add(this.LabelRecTime);
            this.TabBasics.Controls.Add(this.LabelRecName);
            this.TabBasics.Controls.Add(this.LabelRecDifficulty);
            this.TabBasics.HorizontalScrollbarBarColor = true;
            this.TabBasics.HorizontalScrollbarHighlightOnWheel = false;
            this.TabBasics.HorizontalScrollbarSize = 10;
            this.TabBasics.Location = new System.Drawing.Point(4, 38);
            this.TabBasics.Name = "TabBasics";
            this.TabBasics.Size = new System.Drawing.Size(946, 472);
            this.TabBasics.TabIndex = 0;
            this.TabBasics.Text = "Podstawowe informacje";
            this.TabBasics.VerticalScrollbarBarColor = true;
            this.TabBasics.VerticalScrollbarHighlightOnWheel = false;
            this.TabBasics.VerticalScrollbarSize = 10;
            // 
            // PictureBoxPhoto
            // 
            this.PictureBoxPhoto.Location = new System.Drawing.Point(290, 242);
            this.PictureBoxPhoto.Name = "PictureBoxPhoto";
            this.PictureBoxPhoto.Size = new System.Drawing.Size(368, 188);
            this.PictureBoxPhoto.TabIndex = 15;
            this.PictureBoxPhoto.TabStop = false;
            // 
            // TextBoxPhoto
            // 
            this.TextBoxPhoto.Lines = new string[] {
        "metroTextBox3"};
            this.TextBoxPhoto.Location = new System.Drawing.Point(63, 213);
            this.TextBoxPhoto.MaxLength = 32767;
            this.TextBoxPhoto.Name = "TextBoxPhoto";
            this.TextBoxPhoto.PasswordChar = '\0';
            this.TextBoxPhoto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxPhoto.SelectedText = "";
            this.TextBoxPhoto.Size = new System.Drawing.Size(880, 23);
            this.TextBoxPhoto.TabIndex = 14;
            this.TextBoxPhoto.Text = "metroTextBox3";
            this.TextBoxPhoto.UseSelectable = true;
            // 
            // ComboBoxCategory
            // 
            this.ComboBoxCategory.FormattingEnabled = true;
            this.ComboBoxCategory.ItemHeight = 23;
            this.ComboBoxCategory.Location = new System.Drawing.Point(667, 30);
            this.ComboBoxCategory.Name = "ComboBoxCategory";
            this.ComboBoxCategory.Size = new System.Drawing.Size(276, 29);
            this.ComboBoxCategory.TabIndex = 13;
            this.ComboBoxCategory.UseSelectable = true;
            // 
            // TextBoxTime
            // 
            this.TextBoxTime.Lines = new string[] {
        "metroTextBox2"};
            this.TextBoxTime.Location = new System.Drawing.Point(275, 92);
            this.TextBoxTime.MaxLength = 32767;
            this.TextBoxTime.Name = "TextBoxTime";
            this.TextBoxTime.PasswordChar = '\0';
            this.TextBoxTime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxTime.SelectedText = "";
            this.TextBoxTime.Size = new System.Drawing.Size(166, 23);
            this.TextBoxTime.TabIndex = 12;
            this.TextBoxTime.Text = "metroTextBox2";
            this.TextBoxTime.UseSelectable = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.RadioBtnHard);
            this.metroPanel1.Controls.Add(this.RadioBtnMed);
            this.metroPanel1.Controls.Add(this.RadioBtnEasy);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(194, 59);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(247, 19);
            this.metroPanel1.TabIndex = 11;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // RadioBtnHard
            // 
            this.RadioBtnHard.AutoSize = true;
            this.RadioBtnHard.Location = new System.Drawing.Point(188, 3);
            this.RadioBtnHard.Name = "RadioBtnHard";
            this.RadioBtnHard.Size = new System.Drawing.Size(59, 15);
            this.RadioBtnHard.TabIndex = 4;
            this.RadioBtnHard.Text = "Trudny";
            this.RadioBtnHard.UseSelectable = true;
            // 
            // RadioBtnMed
            // 
            this.RadioBtnMed.AutoSize = true;
            this.RadioBtnMed.Location = new System.Drawing.Point(96, 3);
            this.RadioBtnMed.Name = "RadioBtnMed";
            this.RadioBtnMed.Size = new System.Drawing.Size(56, 15);
            this.RadioBtnMed.TabIndex = 3;
            this.RadioBtnMed.Text = "Średni";
            this.RadioBtnMed.UseSelectable = true;
            // 
            // RadioBtnEasy
            // 
            this.RadioBtnEasy.AutoSize = true;
            this.RadioBtnEasy.Location = new System.Drawing.Point(0, 3);
            this.RadioBtnEasy.Name = "RadioBtnEasy";
            this.RadioBtnEasy.Size = new System.Drawing.Size(54, 15);
            this.RadioBtnEasy.TabIndex = 2;
            this.RadioBtnEasy.Text = "Łatwy";
            this.RadioBtnEasy.UseSelectable = true;
            // 
            // TextBoxRecName
            // 
            this.TextBoxRecName.Lines = new string[] {
        "metroTextBox1"};
            this.TextBoxRecName.Location = new System.Drawing.Point(194, 30);
            this.TextBoxRecName.MaxLength = 32767;
            this.TextBoxRecName.Name = "TextBoxRecName";
            this.TextBoxRecName.PasswordChar = '\0';
            this.TextBoxRecName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxRecName.SelectedText = "";
            this.TextBoxRecName.Size = new System.Drawing.Size(247, 23);
            this.TextBoxRecName.TabIndex = 10;
            this.TextBoxRecName.Text = "metroTextBox1";
            this.TextBoxRecName.UseSelectable = true;
            // 
            // LabelPhotoDesc
            // 
            this.LabelPhotoDesc.AutoSize = true;
            this.LabelPhotoDesc.Location = new System.Drawing.Point(3, 180);
            this.LabelPhotoDesc.Name = "LabelPhotoDesc";
            this.LabelPhotoDesc.Size = new System.Drawing.Size(326, 19);
            this.LabelPhotoDesc.TabIndex = 9;
            this.LabelPhotoDesc.Text = "Jeśli operacja się powiedzie, poniżej pojawi się zdjęcie.";
            // 
            // LabelURLDesc
            // 
            this.LabelURLDesc.AutoSize = true;
            this.LabelURLDesc.Location = new System.Drawing.Point(3, 161);
            this.LabelURLDesc.Name = "LabelURLDesc";
            this.LabelURLDesc.Size = new System.Drawing.Size(438, 19);
            this.LabelURLDesc.TabIndex = 8;
            this.LabelURLDesc.Text = "Następnie kliknij Sprawdź, by program mógł sprawdzić poprawność linku.";
            // 
            // LabelRecURLDesc
            // 
            this.LabelRecURLDesc.AutoSize = true;
            this.LabelRecURLDesc.Location = new System.Drawing.Point(3, 142);
            this.LabelRecURLDesc.Name = "LabelRecURLDesc";
            this.LabelRecURLDesc.Size = new System.Drawing.Size(655, 19);
            this.LabelRecURLDesc.TabIndex = 7;
            this.LabelRecURLDesc.Text = "W poniższe pole wklej adres URL prowadzący do zdjęcia przedstawiającego potrawę. " +
    "Sugerowany format: jpg ";
            // 
            // LabelRecPhoto
            // 
            this.LabelRecPhoto.AutoSize = true;
            this.LabelRecPhoto.Location = new System.Drawing.Point(3, 213);
            this.LabelRecPhoto.Name = "LabelRecPhoto";
            this.LabelRecPhoto.Size = new System.Drawing.Size(54, 19);
            this.LabelRecPhoto.TabIndex = 6;
            this.LabelRecPhoto.Text = "Zdjęcie:";
            // 
            // LabelRecCategory
            // 
            this.LabelRecCategory.AutoSize = true;
            this.LabelRecCategory.Location = new System.Drawing.Point(560, 30);
            this.LabelRecCategory.Name = "LabelRecCategory";
            this.LabelRecCategory.Size = new System.Drawing.Size(68, 19);
            this.LabelRecCategory.TabIndex = 5;
            this.LabelRecCategory.Text = "Kategoria:";
            // 
            // TabIng
            // 
            this.TabIng.Controls.Add(this.GridIng);
            this.TabIng.Controls.Add(this.ButtonAddIng);
            this.TabIng.Controls.Add(this.metroPanel2);
            this.TabIng.Controls.Add(this.metroTextBox5);
            this.TabIng.Controls.Add(this.metroTextBox4);
            this.TabIng.Controls.Add(this.LabelIngType);
            this.TabIng.Controls.Add(this.LabelIngValue);
            this.TabIng.Controls.Add(this.LabelIngName);
            this.TabIng.HorizontalScrollbarBarColor = true;
            this.TabIng.HorizontalScrollbarHighlightOnWheel = false;
            this.TabIng.HorizontalScrollbarSize = 10;
            this.TabIng.Location = new System.Drawing.Point(4, 38);
            this.TabIng.Name = "TabIng";
            this.TabIng.Size = new System.Drawing.Size(946, 472);
            this.TabIng.TabIndex = 1;
            this.TabIng.Text = "Lista składników";
            this.TabIng.VerticalScrollbarBarColor = true;
            this.TabIng.VerticalScrollbarHighlightOnWheel = false;
            this.TabIng.VerticalScrollbarSize = 10;
            // 
            // GridIng
            // 
            this.GridIng.AllowUserToResizeRows = false;
            this.GridIng.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridIng.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridIng.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridIng.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridIng.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridIng.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridIng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridIng.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IngName,
            this.IngValue,
            this.IngType});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridIng.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridIng.EnableHeadersVisualStyles = false;
            this.GridIng.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridIng.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridIng.Location = new System.Drawing.Point(3, 3);
            this.GridIng.Name = "GridIng";
            this.GridIng.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridIng.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridIng.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridIng.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridIng.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridIng.Size = new System.Drawing.Size(940, 264);
            this.GridIng.TabIndex = 11;
            this.GridIng.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick_1);
            this.GridIng.Validating += new System.ComponentModel.CancelEventHandler(this.metroGrid1_Validating);
            // 
            // IngName
            // 
            this.IngName.HeaderText = "Nazwa składnika";
            this.IngName.Name = "IngName";
            // 
            // IngValue
            // 
            this.IngValue.FillWeight = 50F;
            this.IngValue.HeaderText = "Ilość";
            this.IngValue.Name = "IngValue";
            // 
            // IngType
            // 
            this.IngType.FillWeight = 50F;
            this.IngType.HeaderText = "Jednostka";
            this.IngType.Items.AddRange(new object[] {
            "g",
            "kg",
            "ml",
            "l",
            "szkl",
            "łyż",
            "szczypta",
            "szt"});
            this.IngType.Name = "IngType";
            this.IngType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IngType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ButtonAddIng
            // 
            this.ButtonAddIng.Location = new System.Drawing.Point(448, 426);
            this.ButtonAddIng.Name = "ButtonAddIng";
            this.ButtonAddIng.Size = new System.Drawing.Size(151, 34);
            this.ButtonAddIng.TabIndex = 9;
            this.ButtonAddIng.Text = "Dodaj";
            this.ButtonAddIng.UseSelectable = true;
            this.ButtonAddIng.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.RadioBtnTypeSZT);
            this.metroPanel2.Controls.Add(this.RadioBtnTypeSZCZ);
            this.metroPanel2.Controls.Add(this.RadioBtnTypeLYZ);
            this.metroPanel2.Controls.Add(this.RadioBtnTypeSZKL);
            this.metroPanel2.Controls.Add(this.RadioBtnTypeL);
            this.metroPanel2.Controls.Add(this.RadioBtnTypeML);
            this.metroPanel2.Controls.Add(this.RadioBtnTypeKG);
            this.metroPanel2.Controls.Add(this.RadioBtnTypeG);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(116, 349);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(301, 111);
            this.metroPanel2.TabIndex = 8;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // RadioBtnTypeSZT
            // 
            this.RadioBtnTypeSZT.AutoSize = true;
            this.RadioBtnTypeSZT.Location = new System.Drawing.Point(137, 77);
            this.RadioBtnTypeSZT.Name = "RadioBtnTypeSZT";
            this.RadioBtnTypeSZT.Size = new System.Drawing.Size(37, 15);
            this.RadioBtnTypeSZT.TabIndex = 9;
            this.RadioBtnTypeSZT.Text = "szt";
            this.RadioBtnTypeSZT.UseSelectable = true;
            // 
            // RadioBtnTypeSZCZ
            // 
            this.RadioBtnTypeSZCZ.AutoSize = true;
            this.RadioBtnTypeSZCZ.Location = new System.Drawing.Point(137, 56);
            this.RadioBtnTypeSZCZ.Name = "RadioBtnTypeSZCZ";
            this.RadioBtnTypeSZCZ.Size = new System.Drawing.Size(67, 15);
            this.RadioBtnTypeSZCZ.TabIndex = 8;
            this.RadioBtnTypeSZCZ.Text = "szczypta";
            this.RadioBtnTypeSZCZ.UseSelectable = true;
            // 
            // RadioBtnTypeLYZ
            // 
            this.RadioBtnTypeLYZ.AutoSize = true;
            this.RadioBtnTypeLYZ.Location = new System.Drawing.Point(137, 36);
            this.RadioBtnTypeLYZ.Name = "RadioBtnTypeLYZ";
            this.RadioBtnTypeLYZ.Size = new System.Drawing.Size(37, 15);
            this.RadioBtnTypeLYZ.TabIndex = 7;
            this.RadioBtnTypeLYZ.Text = "łyż";
            this.RadioBtnTypeLYZ.UseSelectable = true;
            // 
            // RadioBtnTypeSZKL
            // 
            this.RadioBtnTypeSZKL.AutoSize = true;
            this.RadioBtnTypeSZKL.Location = new System.Drawing.Point(137, 15);
            this.RadioBtnTypeSZKL.Name = "RadioBtnTypeSZKL";
            this.RadioBtnTypeSZKL.Size = new System.Drawing.Size(42, 15);
            this.RadioBtnTypeSZKL.TabIndex = 6;
            this.RadioBtnTypeSZKL.Text = "szkl";
            this.RadioBtnTypeSZKL.UseSelectable = true;
            // 
            // RadioBtnTypeL
            // 
            this.RadioBtnTypeL.AutoSize = true;
            this.RadioBtnTypeL.Location = new System.Drawing.Point(4, 77);
            this.RadioBtnTypeL.Name = "RadioBtnTypeL";
            this.RadioBtnTypeL.Size = new System.Drawing.Size(26, 15);
            this.RadioBtnTypeL.TabIndex = 5;
            this.RadioBtnTypeL.Text = "l";
            this.RadioBtnTypeL.UseSelectable = true;
            // 
            // RadioBtnTypeML
            // 
            this.RadioBtnTypeML.AutoSize = true;
            this.RadioBtnTypeML.Location = new System.Drawing.Point(4, 56);
            this.RadioBtnTypeML.Name = "RadioBtnTypeML";
            this.RadioBtnTypeML.Size = new System.Drawing.Size(37, 15);
            this.RadioBtnTypeML.TabIndex = 4;
            this.RadioBtnTypeML.Text = "ml";
            this.RadioBtnTypeML.UseSelectable = true;
            // 
            // RadioBtnTypeKG
            // 
            this.RadioBtnTypeKG.AutoSize = true;
            this.RadioBtnTypeKG.Location = new System.Drawing.Point(4, 35);
            this.RadioBtnTypeKG.Name = "RadioBtnTypeKG";
            this.RadioBtnTypeKG.Size = new System.Drawing.Size(36, 15);
            this.RadioBtnTypeKG.TabIndex = 3;
            this.RadioBtnTypeKG.Text = "kg";
            this.RadioBtnTypeKG.UseSelectable = true;
            // 
            // RadioBtnTypeG
            // 
            this.RadioBtnTypeG.AutoSize = true;
            this.RadioBtnTypeG.Checked = true;
            this.RadioBtnTypeG.Location = new System.Drawing.Point(4, 14);
            this.RadioBtnTypeG.Name = "RadioBtnTypeG";
            this.RadioBtnTypeG.Size = new System.Drawing.Size(30, 15);
            this.RadioBtnTypeG.TabIndex = 2;
            this.RadioBtnTypeG.TabStop = true;
            this.RadioBtnTypeG.Text = "g";
            this.RadioBtnTypeG.UseSelectable = true;
            // 
            // metroTextBox5
            // 
            this.metroTextBox5.Lines = new string[0];
            this.metroTextBox5.Location = new System.Drawing.Point(116, 320);
            this.metroTextBox5.MaxLength = 32767;
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.PasswordChar = '\0';
            this.metroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox5.SelectedText = "";
            this.metroTextBox5.Size = new System.Drawing.Size(301, 23);
            this.metroTextBox5.TabIndex = 7;
            this.metroTextBox5.UseSelectable = true;
            // 
            // metroTextBox4
            // 
            this.metroTextBox4.Lines = new string[0];
            this.metroTextBox4.Location = new System.Drawing.Point(116, 280);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '\0';
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.Size = new System.Drawing.Size(301, 23);
            this.metroTextBox4.TabIndex = 6;
            this.metroTextBox4.UseSelectable = true;
            // 
            // LabelIngType
            // 
            this.LabelIngType.AutoSize = true;
            this.LabelIngType.Location = new System.Drawing.Point(3, 360);
            this.LabelIngType.Name = "LabelIngType";
            this.LabelIngType.Size = new System.Drawing.Size(69, 19);
            this.LabelIngType.TabIndex = 5;
            this.LabelIngType.Text = "Jednostka:";
            // 
            // LabelIngValue
            // 
            this.LabelIngValue.AutoSize = true;
            this.LabelIngValue.Location = new System.Drawing.Point(3, 320);
            this.LabelIngValue.Name = "LabelIngValue";
            this.LabelIngValue.Size = new System.Drawing.Size(37, 19);
            this.LabelIngValue.TabIndex = 4;
            this.LabelIngValue.Text = "Ilość:";
            // 
            // LabelIngName
            // 
            this.LabelIngName.AutoSize = true;
            this.LabelIngName.Location = new System.Drawing.Point(3, 280);
            this.LabelIngName.Name = "LabelIngName";
            this.LabelIngName.Size = new System.Drawing.Size(107, 19);
            this.LabelIngName.TabIndex = 3;
            this.LabelIngName.Text = "Nazwa składnika:";
            // 
            // TabMaking
            // 
            this.TabMaking.Controls.Add(this.ButtonMakingAdd);
            this.TabMaking.Controls.Add(this.TextBoxMaking);
            this.TabMaking.Controls.Add(this.LabelMaking);
            this.TabMaking.Controls.Add(this.GridMaking);
            this.TabMaking.HorizontalScrollbarBarColor = true;
            this.TabMaking.HorizontalScrollbarHighlightOnWheel = false;
            this.TabMaking.HorizontalScrollbarSize = 10;
            this.TabMaking.Location = new System.Drawing.Point(4, 38);
            this.TabMaking.Name = "TabMaking";
            this.TabMaking.Size = new System.Drawing.Size(946, 472);
            this.TabMaking.TabIndex = 2;
            this.TabMaking.Text = "Wykonanie";
            this.TabMaking.VerticalScrollbarBarColor = true;
            this.TabMaking.VerticalScrollbarHighlightOnWheel = false;
            this.TabMaking.VerticalScrollbarSize = 10;
            // 
            // ButtonMakingAdd
            // 
            this.ButtonMakingAdd.Location = new System.Drawing.Point(795, 313);
            this.ButtonMakingAdd.Name = "ButtonMakingAdd";
            this.ButtonMakingAdd.Size = new System.Drawing.Size(151, 34);
            this.ButtonMakingAdd.TabIndex = 19;
            this.ButtonMakingAdd.Text = "Dodaj";
            this.ButtonMakingAdd.UseSelectable = true;
            // 
            // TextBoxMaking
            // 
            this.TextBoxMaking.Lines = new string[] {
        "metroTextBox6"};
            this.TextBoxMaking.Location = new System.Drawing.Point(112, 273);
            this.TextBoxMaking.MaxLength = 32767;
            this.TextBoxMaking.Name = "TextBoxMaking";
            this.TextBoxMaking.PasswordChar = '\0';
            this.TextBoxMaking.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxMaking.SelectedText = "";
            this.TextBoxMaking.Size = new System.Drawing.Size(831, 23);
            this.TextBoxMaking.TabIndex = 17;
            this.TextBoxMaking.Text = "metroTextBox6";
            this.TextBoxMaking.UseSelectable = true;
            // 
            // LabelMaking
            // 
            this.LabelMaking.AutoSize = true;
            this.LabelMaking.Location = new System.Drawing.Point(-1, 273);
            this.LabelMaking.Name = "LabelMaking";
            this.LabelMaking.Size = new System.Drawing.Size(40, 19);
            this.LabelMaking.TabIndex = 14;
            this.LabelMaking.Text = "Treść:";
            // 
            // GridMaking
            // 
            this.GridMaking.AllowUserToResizeRows = false;
            this.GridMaking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridMaking.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridMaking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridMaking.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridMaking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridMaking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridMaking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMaking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridMaking.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridMaking.EnableHeadersVisualStyles = false;
            this.GridMaking.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridMaking.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridMaking.Location = new System.Drawing.Point(3, 3);
            this.GridMaking.Name = "GridMaking";
            this.GridMaking.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridMaking.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridMaking.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridMaking.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridMaking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridMaking.Size = new System.Drawing.Size(940, 264);
            this.GridMaking.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Krok:";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // TabSend
            // 
            this.TabSend.Controls.Add(this.ButtonSend);
            this.TabSend.Controls.Add(this.LabelInfoSend);
            this.TabSend.HorizontalScrollbarBarColor = true;
            this.TabSend.HorizontalScrollbarHighlightOnWheel = false;
            this.TabSend.HorizontalScrollbarSize = 10;
            this.TabSend.Location = new System.Drawing.Point(4, 38);
            this.TabSend.Name = "TabSend";
            this.TabSend.Size = new System.Drawing.Size(946, 472);
            this.TabSend.TabIndex = 3;
            this.TabSend.Text = "Wysłanie przepisu do bazy";
            this.TabSend.VerticalScrollbarBarColor = true;
            this.TabSend.VerticalScrollbarHighlightOnWheel = false;
            this.TabSend.VerticalScrollbarSize = 10;
            // 
            // ButtonSend
            // 
            this.ButtonSend.Location = new System.Drawing.Point(755, 403);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(195, 66);
            this.ButtonSend.TabIndex = 9;
            this.ButtonSend.Text = "Wyślij";
            this.ButtonSend.UseSelectable = true;
            // 
            // LabelInfoSend
            // 
            this.LabelInfoSend.AutoSize = true;
            this.LabelInfoSend.Location = new System.Drawing.Point(3, 19);
            this.LabelInfoSend.Name = "LabelInfoSend";
            this.LabelInfoSend.Size = new System.Drawing.Size(576, 76);
            this.LabelInfoSend.TabIndex = 8;
            this.LabelInfoSend.Text = resources.GetString("LabelInfoSend.Text");
            // 
            // styleManager
            // 
            this.styleManager.Owner = null;
            // 
            // FormCreateEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.TabsAddEditRecipe);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormCreateEdit";
            this.Text = "Dodaj / Edytuj przepis";
            this.Load += new System.EventHandler(this.FormCreateEdit_Load);
            this.TabsAddEditRecipe.ResumeLayout(false);
            this.TabBasics.ResumeLayout(false);
            this.TabBasics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPhoto)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.TabIng.ResumeLayout(false);
            this.TabIng.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridIng)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.TabMaking.ResumeLayout(false);
            this.TabMaking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMaking)).EndInit();
            this.TabSend.ResumeLayout(false);
            this.TabSend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.styleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LabelRecName;
        private MetroFramework.Controls.MetroLabel LabelRecDifficulty;
        private MetroFramework.Controls.MetroLabel LabelRecTime;
        private MetroFramework.Controls.MetroTabControl TabsAddEditRecipe;
        private MetroFramework.Controls.MetroTabPage TabBasics;
        private System.Windows.Forms.PictureBox PictureBoxPhoto;
        private MetroFramework.Controls.MetroTextBox TextBoxPhoto;
        private MetroFramework.Controls.MetroComboBox ComboBoxCategory;
        private MetroFramework.Controls.MetroTextBox TextBoxTime;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroRadioButton RadioBtnHard;
        private MetroFramework.Controls.MetroRadioButton RadioBtnMed;
        private MetroFramework.Controls.MetroRadioButton RadioBtnEasy;
        private MetroFramework.Controls.MetroTextBox TextBoxRecName;
        private MetroFramework.Controls.MetroLabel LabelPhotoDesc;
        private MetroFramework.Controls.MetroLabel LabelURLDesc;
        private MetroFramework.Controls.MetroLabel LabelRecURLDesc;
        private MetroFramework.Controls.MetroLabel LabelRecPhoto;
        private MetroFramework.Controls.MetroLabel LabelRecCategory;
        private MetroFramework.Controls.MetroTabPage TabIng;
        private MetroFramework.Controls.MetroTabPage TabMaking;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroRadioButton RadioBtnTypeSZT;
        private MetroFramework.Controls.MetroRadioButton RadioBtnTypeSZCZ;
        private MetroFramework.Controls.MetroRadioButton RadioBtnTypeLYZ;
        private MetroFramework.Controls.MetroRadioButton RadioBtnTypeSZKL;
        private MetroFramework.Controls.MetroRadioButton RadioBtnTypeL;
        private MetroFramework.Controls.MetroRadioButton RadioBtnTypeML;
        private MetroFramework.Controls.MetroRadioButton RadioBtnTypeKG;
        private MetroFramework.Controls.MetroRadioButton RadioBtnTypeG;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroLabel LabelIngType;
        private MetroFramework.Controls.MetroLabel LabelIngValue;
        private MetroFramework.Controls.MetroLabel LabelIngName;
        private MetroFramework.Controls.MetroButton ButtonAddIng;
        private MetroFramework.Controls.MetroGrid GridIng;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngValue;
        private System.Windows.Forms.DataGridViewComboBoxColumn IngType;
        private MetroFramework.Controls.MetroButton ButtonMakingAdd;
        private MetroFramework.Controls.MetroTextBox TextBoxMaking;
        private MetroFramework.Controls.MetroLabel LabelMaking;
        private MetroFramework.Controls.MetroGrid GridMaking;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private MetroFramework.Controls.MetroTabPage TabSend;
        private MetroFramework.Controls.MetroButton ButtonSend;
        private MetroFramework.Controls.MetroLabel LabelInfoSend;
        private MetroFramework.Components.MetroStyleManager styleManager;

        private void SetUpStyle(MetroStyleManager manago)
        {
            this.StyleManager = manago;
            this.styleManager = manago;
            this.LabelRecName.StyleManager = styleManager;
            this.LabelRecDifficulty.StyleManager = styleManager;
            this.LabelRecTime.StyleManager = styleManager;
            this.TabsAddEditRecipe.StyleManager = styleManager;
            this.TabBasics.StyleManager = styleManager;
            this.TextBoxPhoto.StyleManager = styleManager;
            this.ComboBoxCategory.StyleManager = styleManager;
            this.TextBoxTime.StyleManager = styleManager;
            this.metroPanel1.StyleManager = styleManager;
            this.RadioBtnHard.StyleManager = styleManager;
            this.RadioBtnMed.StyleManager = styleManager;
            this.RadioBtnEasy.StyleManager = styleManager;
            this.TextBoxRecName.StyleManager = styleManager;
            this.LabelPhotoDesc.StyleManager = styleManager;
            this.LabelURLDesc.StyleManager = styleManager;
            this.LabelRecURLDesc.StyleManager = styleManager;
            this.LabelRecPhoto.StyleManager = styleManager;
            this.LabelRecCategory.StyleManager = styleManager;
            this.TabIng.StyleManager = styleManager;
            this.TabMaking.StyleManager = styleManager;
            this.metroPanel2.StyleManager = styleManager;
            this.RadioBtnTypeSZT.StyleManager = styleManager;
            this.RadioBtnTypeSZCZ.StyleManager = styleManager;
            this.RadioBtnTypeLYZ.StyleManager = styleManager;
            this.RadioBtnTypeSZKL.StyleManager = styleManager;
            this.RadioBtnTypeL.StyleManager = styleManager;
            this.RadioBtnTypeML.StyleManager = styleManager;
            this.RadioBtnTypeKG.StyleManager = styleManager;
            this.RadioBtnTypeG.StyleManager = styleManager;
            this.metroTextBox5.StyleManager = styleManager;
            this.metroTextBox4.StyleManager = styleManager;
            this.LabelIngType.StyleManager = styleManager;
            this.LabelIngValue.StyleManager = styleManager;
            this.LabelIngName.StyleManager = styleManager;
            this.ButtonAddIng.StyleManager = styleManager;
            this.GridIng.StyleManager = styleManager;
            this.ButtonMakingAdd.StyleManager = styleManager;
            this.TextBoxMaking.StyleManager = styleManager;
            this.LabelMaking.StyleManager = styleManager;
            this.GridMaking.StyleManager = styleManager;
            this.TabSend.StyleManager = styleManager;
            this.ButtonSend.StyleManager = styleManager;
            this.LabelInfoSend.StyleManager = styleManager;
        }

    }
}