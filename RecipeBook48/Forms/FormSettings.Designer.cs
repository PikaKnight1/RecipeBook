using MetroFramework.Components;

namespace RecipeBook48
{
    partial class FormSettings
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
            this.LabelSQLSettings = new MetroFramework.Controls.MetroLabel();
            this.LabelSqlIP = new MetroFramework.Controls.MetroLabel();
            this.LabelSqlPort = new MetroFramework.Controls.MetroLabel();
            this.LabelSqlUsername = new MetroFramework.Controls.MetroLabel();
            this.LabelSqlPass = new MetroFramework.Controls.MetroLabel();
            this.LabelSqlSID = new MetroFramework.Controls.MetroLabel();
            this.TextBoxIP = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxPort = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxUsername = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxPass = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxSID = new MetroFramework.Controls.MetroTextBox();
            this.ButtonConnTest = new MetroFramework.Controls.MetroButton();
            this.LabelAppSettings = new MetroFramework.Controls.MetroLabel();
            this.LabelTheme = new MetroFramework.Controls.MetroLabel();
            this.LabelColor = new MetroFramework.Controls.MetroLabel();
            this.ComboColor = new MetroFramework.Controls.MetroComboBox();
            this.ComboTheme = new MetroFramework.Controls.MetroComboBox();
            this.styleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.ButtonThemeAccept = new MetroFramework.Controls.MetroButton();
            this.ButtonSQLSave = new MetroFramework.Controls.MetroButton();
            this.ButtonCancel = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.styleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelSQLSettings
            // 
            this.LabelSQLSettings.AutoSize = true;
            this.LabelSQLSettings.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LabelSQLSettings.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelSQLSettings.Location = new System.Drawing.Point(23, 86);
            this.LabelSQLSettings.Name = "LabelSQLSettings";
            this.LabelSQLSettings.Size = new System.Drawing.Size(204, 25);
            this.LabelSQLSettings.TabIndex = 0;
            this.LabelSQLSettings.Text = "Ustawienia bazy danych:";
            // 
            // LabelSqlIP
            // 
            this.LabelSqlIP.AutoSize = true;
            this.LabelSqlIP.Location = new System.Drawing.Point(23, 120);
            this.LabelSqlIP.Name = "LabelSqlIP";
            this.LabelSqlIP.Size = new System.Drawing.Size(96, 19);
            this.LabelSqlIP.TabIndex = 1;
            this.LabelSqlIP.Text = "Adres IP hosta:";
            // 
            // LabelSqlPort
            // 
            this.LabelSqlPort.AutoSize = true;
            this.LabelSqlPort.Location = new System.Drawing.Point(23, 149);
            this.LabelSqlPort.Name = "LabelSqlPort";
            this.LabelSqlPort.Size = new System.Drawing.Size(37, 19);
            this.LabelSqlPort.TabIndex = 2;
            this.LabelSqlPort.Text = "Port:";
            // 
            // LabelSqlUsername
            // 
            this.LabelSqlUsername.AutoSize = true;
            this.LabelSqlUsername.Location = new System.Drawing.Point(23, 178);
            this.LabelSqlUsername.Name = "LabelSqlUsername";
            this.LabelSqlUsername.Size = new System.Drawing.Size(124, 19);
            this.LabelSqlUsername.TabIndex = 3;
            this.LabelSqlUsername.Text = "Nazwa użytkownika:";
            // 
            // LabelSqlPass
            // 
            this.LabelSqlPass.AutoSize = true;
            this.LabelSqlPass.Location = new System.Drawing.Point(23, 207);
            this.LabelSqlPass.Name = "LabelSqlPass";
            this.LabelSqlPass.Size = new System.Drawing.Size(44, 19);
            this.LabelSqlPass.TabIndex = 4;
            this.LabelSqlPass.Text = "Hasło:";
            // 
            // LabelSqlSID
            // 
            this.LabelSqlSID.AutoSize = true;
            this.LabelSqlSID.Location = new System.Drawing.Point(23, 236);
            this.LabelSqlSID.Name = "LabelSqlSID";
            this.LabelSqlSID.Size = new System.Drawing.Size(31, 19);
            this.LabelSqlSID.TabIndex = 5;
            this.LabelSqlSID.Text = "SID:";
            // 
            // TextBoxIP
            // 
            this.TextBoxIP.Lines = new string[0];
            this.TextBoxIP.Location = new System.Drawing.Point(163, 120);
            this.TextBoxIP.MaxLength = 32767;
            this.TextBoxIP.Name = "TextBoxIP";
            this.TextBoxIP.PasswordChar = '\0';
            this.TextBoxIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxIP.SelectedText = "";
            this.TextBoxIP.Size = new System.Drawing.Size(194, 23);
            this.TextBoxIP.TabIndex = 6;
            this.TextBoxIP.UseSelectable = true;
            this.TextBoxIP.Click += new System.EventHandler(this.TextBoxIP_Click);
            // 
            // TextBoxPort
            // 
            this.TextBoxPort.Lines = new string[0];
            this.TextBoxPort.Location = new System.Drawing.Point(163, 149);
            this.TextBoxPort.MaxLength = 32767;
            this.TextBoxPort.Name = "TextBoxPort";
            this.TextBoxPort.PasswordChar = '\0';
            this.TextBoxPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxPort.SelectedText = "";
            this.TextBoxPort.Size = new System.Drawing.Size(194, 23);
            this.TextBoxPort.TabIndex = 7;
            this.TextBoxPort.UseSelectable = true;
            this.TextBoxPort.Click += new System.EventHandler(this.TextBoxPortClick);
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Lines = new string[0];
            this.TextBoxUsername.Location = new System.Drawing.Point(163, 178);
            this.TextBoxUsername.MaxLength = 32767;
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.PasswordChar = '\0';
            this.TextBoxUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxUsername.SelectedText = "";
            this.TextBoxUsername.Size = new System.Drawing.Size(194, 23);
            this.TextBoxUsername.TabIndex = 8;
            this.TextBoxUsername.UseSelectable = true;
            this.TextBoxUsername.Click += new System.EventHandler(this.TextBoxUsernameClick);
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Lines = new string[0];
            this.TextBoxPass.Location = new System.Drawing.Point(163, 207);
            this.TextBoxPass.MaxLength = 32767;
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.PasswordChar = '\0';
            this.TextBoxPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxPass.SelectedText = "";
            this.TextBoxPass.Size = new System.Drawing.Size(194, 23);
            this.TextBoxPass.TabIndex = 9;
            this.TextBoxPass.UseSelectable = true;
            this.TextBoxPass.Click += new System.EventHandler(this.TextBoxPassClick);
            // 
            // TextBoxSID
            // 
            this.TextBoxSID.Lines = new string[0];
            this.TextBoxSID.Location = new System.Drawing.Point(163, 236);
            this.TextBoxSID.MaxLength = 32767;
            this.TextBoxSID.Name = "TextBoxSID";
            this.TextBoxSID.PasswordChar = '\0';
            this.TextBoxSID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxSID.SelectedText = "";
            this.TextBoxSID.Size = new System.Drawing.Size(194, 23);
            this.TextBoxSID.TabIndex = 10;
            this.TextBoxSID.UseSelectable = true;
            this.TextBoxSID.Click += new System.EventHandler(this.TextBoxSIDClick);
            // 
            // ButtonConnTest
            // 
            this.ButtonConnTest.Location = new System.Drawing.Point(256, 265);
            this.ButtonConnTest.Name = "ButtonConnTest";
            this.ButtonConnTest.Size = new System.Drawing.Size(101, 28);
            this.ButtonConnTest.TabIndex = 11;
            this.ButtonConnTest.Text = "Test połączenia";
            this.ButtonConnTest.UseSelectable = true;
            this.ButtonConnTest.Click += new System.EventHandler(this.ButtonSqlTestClick);
            // 
            // LabelAppSettings
            // 
            this.LabelAppSettings.AutoSize = true;
            this.LabelAppSettings.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LabelAppSettings.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelAppSettings.Location = new System.Drawing.Point(472, 86);
            this.LabelAppSettings.Name = "LabelAppSettings";
            this.LabelAppSettings.Size = new System.Drawing.Size(167, 25);
            this.LabelAppSettings.TabIndex = 12;
            this.LabelAppSettings.Text = "Ustawienia aplikacji:";
            // 
            // LabelTheme
            // 
            this.LabelTheme.AutoSize = true;
            this.LabelTheme.Location = new System.Drawing.Point(472, 120);
            this.LabelTheme.Name = "LabelTheme";
            this.LabelTheme.Size = new System.Drawing.Size(101, 19);
            this.LabelTheme.TabIndex = 17;
            this.LabelTheme.Text = "Motyw aplikacji:";
            // 
            // LabelColor
            // 
            this.LabelColor.AutoSize = true;
            this.LabelColor.Location = new System.Drawing.Point(472, 178);
            this.LabelColor.Name = "LabelColor";
            this.LabelColor.Size = new System.Drawing.Size(101, 19);
            this.LabelColor.TabIndex = 18;
            this.LabelColor.Text = "Kolor akcentów:";
            // 
            // ComboColor
            // 
            this.ComboColor.FormattingEnabled = true;
            this.ComboColor.ItemHeight = 23;
            this.ComboColor.Items.AddRange(new object[] {
            "Czarny",
            "Biały",
            "Srebrny",
            "Niebieski",
            "Zielony",
            "Limonkowy",
            "Teal",
            "Pomarańczowy",
            "Brązowy",
            "Różowy",
            "Magenta",
            "Fioletowy"});
            this.ComboColor.Location = new System.Drawing.Point(612, 178);
            this.ComboColor.Name = "ComboColor";
            this.ComboColor.Size = new System.Drawing.Size(194, 29);
            this.ComboColor.TabIndex = 19;
            this.ComboColor.UseSelectable = true;
            // 
            // ComboTheme
            // 
            this.ComboTheme.FormattingEnabled = true;
            this.ComboTheme.ItemHeight = 23;
            this.ComboTheme.Items.AddRange(new object[] {
            "Jasny",
            "Ciemny"});
            this.ComboTheme.Location = new System.Drawing.Point(612, 120);
            this.ComboTheme.Name = "ComboTheme";
            this.ComboTheme.Size = new System.Drawing.Size(194, 29);
            this.ComboTheme.TabIndex = 20;
            this.ComboTheme.UseSelectable = true;
            // 
            // styleManager
            // 
            this.styleManager.Owner = null;
            // 
            // ButtonThemeAccept
            // 
            this.ButtonThemeAccept.Location = new System.Drawing.Point(693, 226);
            this.ButtonThemeAccept.Name = "ButtonThemeAccept";
            this.ButtonThemeAccept.Size = new System.Drawing.Size(113, 29);
            this.ButtonThemeAccept.TabIndex = 21;
            this.ButtonThemeAccept.Text = "Zastosuj";
            this.ButtonThemeAccept.UseSelectable = true;
            this.ButtonThemeAccept.Click += new System.EventHandler(this.ButtonThemeAcceptClick);
            // 
            // ButtonSQLSave
            // 
            this.ButtonSQLSave.Location = new System.Drawing.Point(256, 299);
            this.ButtonSQLSave.Name = "ButtonSQLSave";
            this.ButtonSQLSave.Size = new System.Drawing.Size(101, 28);
            this.ButtonSQLSave.TabIndex = 22;
            this.ButtonSQLSave.Text = "Zapisz";
            this.ButtonSQLSave.UseSelectable = true;
            this.ButtonSQLSave.Click += new System.EventHandler(this.ButtonSQLSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.ForeColor = System.Drawing.Color.Coral;
            this.ButtonCancel.Location = new System.Drawing.Point(803, 524);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(174, 53);
            this.ButtonCancel.TabIndex = 23;
            this.ButtonCancel.Text = "Anuluj";
            this.ButtonCancel.UseSelectable = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSQLSave);
            this.Controls.Add(this.ButtonThemeAccept);
            this.Controls.Add(this.ComboTheme);
            this.Controls.Add(this.ComboColor);
            this.Controls.Add(this.LabelColor);
            this.Controls.Add(this.LabelTheme);
            this.Controls.Add(this.LabelAppSettings);
            this.Controls.Add(this.ButtonConnTest);
            this.Controls.Add(this.TextBoxSID);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.TextBoxPort);
            this.Controls.Add(this.TextBoxIP);
            this.Controls.Add(this.LabelSqlSID);
            this.Controls.Add(this.LabelSqlPass);
            this.Controls.Add(this.LabelSqlUsername);
            this.Controls.Add(this.LabelSqlPort);
            this.Controls.Add(this.LabelSqlIP);
            this.Controls.Add(this.LabelSQLSettings);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormSettings";
            this.Text = "Ustawienia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettingsFormClosing);
            this.Load += new System.EventHandler(this.ThisFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.styleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LabelSQLSettings;
        private MetroFramework.Controls.MetroLabel LabelSqlIP;
        private MetroFramework.Controls.MetroLabel LabelSqlPort;
        private MetroFramework.Controls.MetroLabel LabelSqlUsername;
        private MetroFramework.Controls.MetroLabel LabelSqlPass;
        private MetroFramework.Controls.MetroLabel LabelSqlSID;
        private MetroFramework.Controls.MetroTextBox TextBoxIP;
        private MetroFramework.Controls.MetroTextBox TextBoxPort;
        private MetroFramework.Controls.MetroTextBox TextBoxUsername;
        private MetroFramework.Controls.MetroTextBox TextBoxPass;
        private MetroFramework.Controls.MetroTextBox TextBoxSID;
        private MetroFramework.Controls.MetroButton ButtonConnTest;
        private MetroFramework.Controls.MetroLabel LabelAppSettings;
        private MetroFramework.Controls.MetroLabel LabelTheme;
        private MetroFramework.Controls.MetroLabel LabelColor;
        private MetroFramework.Controls.MetroComboBox ComboColor;
        private MetroFramework.Controls.MetroComboBox ComboTheme;

        private void SetUpStyle(MetroStyleManager manago)
        {
            this.StyleManager = manago;
            this.styleManager = manago;
            this.LabelSQLSettings.StyleManager = styleManager;
            this.LabelSqlIP.StyleManager = styleManager;
            this.LabelSqlPort.StyleManager = styleManager;
            this.LabelSqlUsername.StyleManager = styleManager;
            this.LabelSqlPass.StyleManager = styleManager;
            this.LabelSqlSID.StyleManager = styleManager;
            this.TextBoxIP.StyleManager = styleManager;
            this.TextBoxPort.StyleManager = styleManager;
            this.TextBoxUsername.StyleManager = styleManager;
            this.TextBoxPass.StyleManager = styleManager;
            this.TextBoxSID.StyleManager = styleManager;
            this.ButtonConnTest.StyleManager = styleManager;
            this.LabelAppSettings.StyleManager = styleManager;
            this.LabelTheme.StyleManager = styleManager;
            this.LabelColor.StyleManager = styleManager; 
            this.ComboColor.StyleManager = styleManager; 
            this.ComboTheme.StyleManager = styleManager;
            this.ButtonCancel.StyleManager = styleManager;
            this.ButtonSQLSave.StyleManager = styleManager;
            this.ButtonThemeAccept.StyleManager = styleManager;            
        }

        private MetroFramework.Components.MetroStyleManager styleManager;
        private MetroFramework.Controls.MetroButton ButtonThemeAccept;
        private MetroFramework.Controls.MetroButton ButtonSQLSave;
        private MetroFramework.Controls.MetroButton ButtonCancel;
    }
}