
namespace Windows_Forms_Controls
{
    partial class SearchWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchWindow));
            this.OKSearchButton = new System.Windows.Forms.Button();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.yearResultLabel = new System.Windows.Forms.Label();
            this.SearchByStreetCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchByCityCheckBox = new System.Windows.Forms.CheckBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.SearchByYearCheckBox = new System.Windows.Forms.CheckBox();
            this.roomCountLabel = new System.Windows.Forms.Label();
            this.SearchByRoomsCountcheckBox = new System.Windows.Forms.CheckBox();
            this.roomsCountComboBox = new System.Windows.Forms.ComboBox();
            this.yearTrackBar = new System.Windows.Forms.TrackBar();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.streetLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.SearchRichTextBox = new System.Windows.Forms.RichTextBox();
            this.headingLabel = new System.Windows.Forms.Label();
            this.SaveSortResCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // OKSearchButton
            // 
            this.OKSearchButton.Location = new System.Drawing.Point(288, 386);
            this.OKSearchButton.Name = "OKSearchButton";
            this.OKSearchButton.Size = new System.Drawing.Size(81, 27);
            this.OKSearchButton.TabIndex = 5;
            this.OKSearchButton.Text = "ОК";
            this.OKSearchButton.UseVisualStyleBackColor = true;
            this.OKSearchButton.Click += new System.EventHandler(this.OKSearchButton_Click);
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.SearchGroupBox.Controls.Add(this.yearResultLabel);
            this.SearchGroupBox.Controls.Add(this.SearchByStreetCheckBox);
            this.SearchGroupBox.Controls.Add(this.SearchByCityCheckBox);
            this.SearchGroupBox.Controls.Add(this.yearLabel);
            this.SearchGroupBox.Controls.Add(this.SearchByYearCheckBox);
            this.SearchGroupBox.Controls.Add(this.roomCountLabel);
            this.SearchGroupBox.Controls.Add(this.SearchByRoomsCountcheckBox);
            this.SearchGroupBox.Controls.Add(this.roomsCountComboBox);
            this.SearchGroupBox.Controls.Add(this.yearTrackBar);
            this.SearchGroupBox.Controls.Add(this.cityComboBox);
            this.SearchGroupBox.Controls.Add(this.streetTextBox);
            this.SearchGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchGroupBox.Location = new System.Drawing.Point(180, 12);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(287, 211);
            this.SearchGroupBox.TabIndex = 6;
            this.SearchGroupBox.TabStop = false;
            // 
            // yearResultLabel
            // 
            this.yearResultLabel.AutoSize = true;
            this.yearResultLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yearResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearResultLabel.Location = new System.Drawing.Point(188, 92);
            this.yearResultLabel.Name = "yearResultLabel";
            this.yearResultLabel.Size = new System.Drawing.Size(35, 15);
            this.yearResultLabel.TabIndex = 32;
            this.yearResultLabel.Text = "2021";
            // 
            // SearchByStreetCheckBox
            // 
            this.SearchByStreetCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.SearchByStreetCheckBox.AutoSize = true;
            this.SearchByStreetCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchByStreetCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SearchByStreetCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.MenuText;
            this.SearchByStreetCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchByStreetCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.SearchByStreetCheckBox.Location = new System.Drawing.Point(7, 176);
            this.SearchByStreetCheckBox.Name = "SearchByStreetCheckBox";
            this.SearchByStreetCheckBox.Size = new System.Drawing.Size(16, 17);
            this.SearchByStreetCheckBox.TabIndex = 3;
            this.SearchByStreetCheckBox.Text = " ";
            this.SearchByStreetCheckBox.UseVisualStyleBackColor = true;
            this.SearchByStreetCheckBox.CheckedChanged += new System.EventHandler(this.SearchByStreetCheckBox_CheckedChanged);
            // 
            // SearchByCityCheckBox
            // 
            this.SearchByCityCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.SearchByCityCheckBox.AutoSize = true;
            this.SearchByCityCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchByCityCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SearchByCityCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.MenuText;
            this.SearchByCityCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchByCityCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.SearchByCityCheckBox.Location = new System.Drawing.Point(7, 129);
            this.SearchByCityCheckBox.Name = "SearchByCityCheckBox";
            this.SearchByCityCheckBox.Size = new System.Drawing.Size(16, 17);
            this.SearchByCityCheckBox.TabIndex = 2;
            this.SearchByCityCheckBox.Text = " ";
            this.SearchByCityCheckBox.UseVisualStyleBackColor = true;
            this.SearchByCityCheckBox.CheckedChanged += new System.EventHandler(this.SearchByCityCheckBox_CheckedChanged);
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.BackColor = System.Drawing.Color.Transparent;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.yearLabel.Location = new System.Drawing.Point(28, 82);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(112, 18);
            this.yearLabel.TabIndex = 29;
            this.yearLabel.Text = "Год постройки";
            // 
            // SearchByYearCheckBox
            // 
            this.SearchByYearCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.SearchByYearCheckBox.AutoSize = true;
            this.SearchByYearCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchByYearCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SearchByYearCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.MenuText;
            this.SearchByYearCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchByYearCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.SearchByYearCheckBox.Location = new System.Drawing.Point(6, 82);
            this.SearchByYearCheckBox.Name = "SearchByYearCheckBox";
            this.SearchByYearCheckBox.Size = new System.Drawing.Size(16, 17);
            this.SearchByYearCheckBox.TabIndex = 1;
            this.SearchByYearCheckBox.Text = " ";
            this.SearchByYearCheckBox.UseVisualStyleBackColor = true;
            this.SearchByYearCheckBox.CheckedChanged += new System.EventHandler(this.SearchByYearCheckBox_CheckedChanged);
            // 
            // roomCountLabel
            // 
            this.roomCountLabel.AutoSize = true;
            this.roomCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.roomCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomCountLabel.Location = new System.Drawing.Point(27, 19);
            this.roomCountLabel.Name = "roomCountLabel";
            this.roomCountLabel.Size = new System.Drawing.Size(92, 36);
            this.roomCountLabel.TabIndex = 28;
            this.roomCountLabel.Text = "Количество\r\nкомнат";
            // 
            // SearchByRoomsCountcheckBox
            // 
            this.SearchByRoomsCountcheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.SearchByRoomsCountcheckBox.AutoSize = true;
            this.SearchByRoomsCountcheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchByRoomsCountcheckBox.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SearchByRoomsCountcheckBox.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.MenuText;
            this.SearchByRoomsCountcheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchByRoomsCountcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.SearchByRoomsCountcheckBox.Location = new System.Drawing.Point(7, 25);
            this.SearchByRoomsCountcheckBox.Name = "SearchByRoomsCountcheckBox";
            this.SearchByRoomsCountcheckBox.Size = new System.Drawing.Size(16, 17);
            this.SearchByRoomsCountcheckBox.TabIndex = 0;
            this.SearchByRoomsCountcheckBox.Text = " ";
            this.SearchByRoomsCountcheckBox.UseVisualStyleBackColor = true;
            this.SearchByRoomsCountcheckBox.CheckedChanged += new System.EventHandler(this.SearchByRoomsCountcheckBox_CheckedChanged);
            // 
            // roomsCountComboBox
            // 
            this.roomsCountComboBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.roomsCountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomsCountComboBox.Enabled = false;
            this.roomsCountComboBox.FormattingEnabled = true;
            this.roomsCountComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "более"});
            this.roomsCountComboBox.Location = new System.Drawing.Point(155, 19);
            this.roomsCountComboBox.Name = "roomsCountComboBox";
            this.roomsCountComboBox.Size = new System.Drawing.Size(111, 21);
            this.roomsCountComboBox.TabIndex = 7;
            // 
            // yearTrackBar
            // 
            this.yearTrackBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.yearTrackBar.Enabled = false;
            this.yearTrackBar.Location = new System.Drawing.Point(155, 62);
            this.yearTrackBar.Maximum = 2021;
            this.yearTrackBar.Minimum = 1950;
            this.yearTrackBar.Name = "yearTrackBar";
            this.yearTrackBar.Size = new System.Drawing.Size(111, 45);
            this.yearTrackBar.TabIndex = 8;
            this.yearTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.yearTrackBar.Value = 2021;
            this.yearTrackBar.Scroll += new System.EventHandler(this.yearTrackBar_Scroll);
            // 
            // cityComboBox
            // 
            this.cityComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cityComboBox.Enabled = false;
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Items.AddRange(new object[] {
            "Минск",
            "Витебск",
            "Гомель",
            "Брест",
            "Гродно",
            "Могилёв"});
            this.cityComboBox.Location = new System.Drawing.Point(155, 130);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(111, 21);
            this.cityComboBox.TabIndex = 25;
            // 
            // streetTextBox
            // 
            this.streetTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.streetTextBox.Enabled = false;
            this.streetTextBox.Location = new System.Drawing.Point(155, 173);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(111, 20);
            this.streetTextBox.TabIndex = 27;
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.BackColor = System.Drawing.Color.Transparent;
            this.streetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.streetLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.streetLabel.Location = new System.Drawing.Point(208, 187);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(51, 18);
            this.streetLabel.TabIndex = 30;
            this.streetLabel.Text = "Улица";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cityLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cityLabel.Location = new System.Drawing.Point(207, 141);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(52, 18);
            this.cityLabel.TabIndex = 31;
            this.cityLabel.Text = "Город";
            // 
            // SearchRichTextBox
            // 
            this.SearchRichTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SearchRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchRichTextBox.Location = new System.Drawing.Point(186, 247);
            this.SearchRichTextBox.Name = "SearchRichTextBox";
            this.SearchRichTextBox.ReadOnly = true;
            this.SearchRichTextBox.Size = new System.Drawing.Size(281, 121);
            this.SearchRichTextBox.TabIndex = 32;
            this.SearchRichTextBox.Text = "";
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.BackColor = System.Drawing.Color.Transparent;
            this.headingLabel.Font = new System.Drawing.Font("Malgun Gothic", 26F, System.Drawing.FontStyle.Bold);
            this.headingLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.headingLabel.Location = new System.Drawing.Point(12, 93);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(156, 47);
            this.headingLabel.TabIndex = 33;
            this.headingLabel.Text = "SEARCH";
            // 
            // SaveSortResCheckBox
            // 
            this.SaveSortResCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.SaveSortResCheckBox.AutoSize = true;
            this.SaveSortResCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.SaveSortResCheckBox.Checked = true;
            this.SaveSortResCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SaveSortResCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SaveSortResCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.SaveSortResCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveSortResCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SaveSortResCheckBox.Location = new System.Drawing.Point(387, 386);
            this.SaveSortResCheckBox.Name = "SaveSortResCheckBox";
            this.SaveSortResCheckBox.Size = new System.Drawing.Size(80, 25);
            this.SaveSortResCheckBox.TabIndex = 42;
            this.SaveSortResCheckBox.Text = "Сохранить";
            this.SaveSortResCheckBox.UseVisualStyleBackColor = false;
            // 
            // SearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(479, 425);
            this.Controls.Add(this.SaveSortResCheckBox);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.SearchRichTextBox);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.OKSearchButton);
            this.Location = new System.Drawing.Point(500, 500);
            this.Name = "SearchWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SearchWindow";
            this.Load += new System.EventHandler(this.SearchWindow_Load);
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OKSearchButton;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.CheckBox SearchByStreetCheckBox;
        private System.Windows.Forms.CheckBox SearchByCityCheckBox;
        private System.Windows.Forms.CheckBox SearchByYearCheckBox;
        private System.Windows.Forms.CheckBox SearchByRoomsCountcheckBox;
        private System.Windows.Forms.ComboBox roomsCountComboBox;
        private System.Windows.Forms.TrackBar yearTrackBar;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label roomCountLabel;
        private System.Windows.Forms.Label yearResultLabel;
        private System.Windows.Forms.RichTextBox SearchRichTextBox;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.CheckBox SaveSortResCheckBox;
    }
}