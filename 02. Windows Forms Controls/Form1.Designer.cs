
using System.Windows.Forms;

namespace Windows_Forms_Controls
{
    partial class FlatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlatForm));
            this.headingLabel = new System.Windows.Forms.Label();
            this.roomCountLabel = new System.Windows.Forms.Label();
            this.roomsCountComboBox = new System.Windows.Forms.ComboBox();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.BalconyCheckBox = new System.Windows.Forms.CheckBox();
            this.FooterCheckBox = new System.Windows.Forms.CheckBox();
            this.WCCheckBox = new System.Windows.Forms.CheckBox();
            this.BathroomCheckBox = new System.Windows.Forms.CheckBox();
            this.KitchenСheckBox = new System.Windows.Forms.CheckBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearTrackBar = new System.Windows.Forms.TrackBar();
            this.yearResultLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdressGroupBox = new System.Windows.Forms.GroupBox();
            this.IndexTextBox = new System.Windows.Forms.TextBox();
            this.IndexLabel = new System.Windows.Forms.Label();
            this.flatLabel = new System.Windows.Forms.Label();
            this.flatTextBox = new System.Windows.Forms.TextBox();
            this.houseTextBox = new System.Windows.Forms.TextBox();
            this.houseLabel = new System.Windows.Forms.Label();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.streetLabel = new System.Windows.Forms.Label();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.FloorListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SquareLabel = new System.Windows.Forms.Label();
            this.SqareTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.infoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceButton = new System.Windows.Forms.Button();
            this.priceGroupBox = new System.Windows.Forms.GroupBox();
            this.currencyLabel = new System.Windows.Forms.Label();
            this.m2Label = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.flatPictureBox = new System.Windows.Forms.PictureBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegExToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.BaseInfoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ActionToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DateToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SortByComboBox = new System.Windows.Forms.ComboBox();
            this.SortByLabel = new System.Windows.Forms.Label();
            this.SaveSortResCheckBox = new System.Windows.Forms.CheckBox();
            this.DateTimetimer = new System.Windows.Forms.Timer(this.components);
            this.SearchStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.regexToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.наПолноеСоответствиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.FlatToolStrip = new System.Windows.Forms.ToolStrip();
            this.CloneButton = new System.Windows.Forms.Button();
            this.OptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.AdressGroupBox.SuspendLayout();
            this.priceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flatPictureBox)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.FlatToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.BackColor = System.Drawing.Color.Transparent;
            this.headingLabel.Font = new System.Drawing.Font("Malgun Gothic", 36F, System.Drawing.FontStyle.Bold);
            this.headingLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.headingLabel.Location = new System.Drawing.Point(696, 21);
            this.headingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(174, 81);
            this.headingLabel.TabIndex = 0;
            this.headingLabel.Text = "FLAT";
            // 
            // roomCountLabel
            // 
            this.roomCountLabel.AutoSize = true;
            this.roomCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.roomCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomCountLabel.Location = new System.Drawing.Point(332, 298);
            this.roomCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomCountLabel.Name = "roomCountLabel";
            this.roomCountLabel.Size = new System.Drawing.Size(193, 24);
            this.roomCountLabel.TabIndex = 1;
            this.roomCountLabel.Text = "Количество комнат*";
            // 
            // roomsCountComboBox
            // 
            this.roomsCountComboBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.roomsCountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomsCountComboBox.FormattingEnabled = true;
            this.roomsCountComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "более"});
            this.roomsCountComboBox.Location = new System.Drawing.Point(573, 294);
            this.roomsCountComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.roomsCountComboBox.Name = "roomsCountComboBox";
            this.roomsCountComboBox.Size = new System.Drawing.Size(103, 24);
            this.roomsCountComboBox.TabIndex = 2;
            this.roomsCountComboBox.SelectedIndexChanged += new System.EventHandler(this.roomsCountComboBox_SelectedIndexChanged);
            this.roomsCountComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.roomsCountComboBox_Validating);
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.OptionsGroupBox.Controls.Add(this.BalconyCheckBox);
            this.OptionsGroupBox.Controls.Add(this.FooterCheckBox);
            this.OptionsGroupBox.Controls.Add(this.WCCheckBox);
            this.OptionsGroupBox.Controls.Add(this.BathroomCheckBox);
            this.OptionsGroupBox.Controls.Add(this.KitchenСheckBox);
            this.OptionsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionsGroupBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsGroupBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.OptionsGroupBox.Location = new System.Drawing.Point(25, 23);
            this.OptionsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.OptionsGroupBox.Size = new System.Drawing.Size(125, 206);
            this.OptionsGroupBox.TabIndex = 3;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Опции";
            // 
            // BalconyCheckBox
            // 
            this.BalconyCheckBox.AutoSize = true;
            this.BalconyCheckBox.Location = new System.Drawing.Point(20, 170);
            this.BalconyCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.BalconyCheckBox.Name = "BalconyCheckBox";
            this.BalconyCheckBox.Size = new System.Drawing.Size(73, 25);
            this.BalconyCheckBox.TabIndex = 4;
            this.BalconyCheckBox.Text = "Балкон";
            this.BalconyCheckBox.UseVisualStyleBackColor = true;
            this.BalconyCheckBox.CheckedChanged += new System.EventHandler(this.BalconyCheckBox_CheckedChanged);
            // 
            // FooterCheckBox
            // 
            this.FooterCheckBox.AutoSize = true;
            this.FooterCheckBox.Location = new System.Drawing.Point(21, 135);
            this.FooterCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.FooterCheckBox.Name = "FooterCheckBox";
            this.FooterCheckBox.Size = new System.Drawing.Size(74, 25);
            this.FooterCheckBox.TabIndex = 3;
            this.FooterCheckBox.Text = "Подвал";
            this.FooterCheckBox.UseVisualStyleBackColor = true;
            this.FooterCheckBox.CheckedChanged += new System.EventHandler(this.FooterCheckBox_CheckedChanged);
            // 
            // WCCheckBox
            // 
            this.WCCheckBox.AutoSize = true;
            this.WCCheckBox.Checked = true;
            this.WCCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WCCheckBox.Location = new System.Drawing.Point(21, 102);
            this.WCCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.WCCheckBox.Name = "WCCheckBox";
            this.WCCheckBox.Size = new System.Drawing.Size(68, 25);
            this.WCCheckBox.TabIndex = 2;
            this.WCCheckBox.Text = "Туалет";
            this.WCCheckBox.UseVisualStyleBackColor = true;
            this.WCCheckBox.CheckedChanged += new System.EventHandler(this.WCCheckBox_CheckedChanged);
            // 
            // BathroomCheckBox
            // 
            this.BathroomCheckBox.AutoSize = true;
            this.BathroomCheckBox.Checked = true;
            this.BathroomCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BathroomCheckBox.Location = new System.Drawing.Point(20, 71);
            this.BathroomCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.BathroomCheckBox.Name = "BathroomCheckBox";
            this.BathroomCheckBox.Size = new System.Drawing.Size(74, 25);
            this.BathroomCheckBox.TabIndex = 1;
            this.BathroomCheckBox.Text = "Ванная";
            this.BathroomCheckBox.UseVisualStyleBackColor = true;
            this.BathroomCheckBox.CheckedChanged += new System.EventHandler(this.BathroomCheckBox_CheckedChanged);
            // 
            // KitchenСheckBox
            // 
            this.KitchenСheckBox.AutoSize = true;
            this.KitchenСheckBox.Checked = true;
            this.KitchenСheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.KitchenСheckBox.Location = new System.Drawing.Point(20, 41);
            this.KitchenСheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.KitchenСheckBox.Name = "KitchenСheckBox";
            this.KitchenСheckBox.Size = new System.Drawing.Size(65, 25);
            this.KitchenСheckBox.TabIndex = 0;
            this.KitchenСheckBox.Text = "Кухня";
            this.KitchenСheckBox.UseVisualStyleBackColor = true;
            this.KitchenСheckBox.CheckedChanged += new System.EventHandler(this.KitchenСheckBox_CheckedChanged);
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.BackColor = System.Drawing.Color.Transparent;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearLabel.Location = new System.Drawing.Point(332, 363);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(144, 24);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Год постройки";
            // 
            // yearTrackBar
            // 
            this.yearTrackBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.yearTrackBar.Location = new System.Drawing.Point(529, 346);
            this.yearTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.yearTrackBar.Maximum = 2021;
            this.yearTrackBar.Minimum = 1950;
            this.yearTrackBar.Name = "yearTrackBar";
            this.yearTrackBar.Size = new System.Drawing.Size(148, 56);
            this.yearTrackBar.TabIndex = 6;
            this.yearTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.yearTrackBar.Value = 2021;
            this.yearTrackBar.Scroll += new System.EventHandler(this.yearTrackBar_Scroll);
            // 
            // yearResultLabel
            // 
            this.yearResultLabel.AutoSize = true;
            this.yearResultLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yearResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearResultLabel.Location = new System.Drawing.Point(584, 383);
            this.yearResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearResultLabel.Name = "yearResultLabel";
            this.yearResultLabel.Size = new System.Drawing.Size(40, 18);
            this.yearResultLabel.TabIndex = 10;
            this.yearResultLabel.Text = "2021";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.OptionsGroupBox);
            this.panel1.Controls.Add(this.AdressGroupBox);
            this.panel1.Location = new System.Drawing.Point(685, 95);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 261);
            this.panel1.TabIndex = 11;
            // 
            // AdressGroupBox
            // 
            this.AdressGroupBox.Controls.Add(this.IndexTextBox);
            this.AdressGroupBox.Controls.Add(this.IndexLabel);
            this.AdressGroupBox.Controls.Add(this.flatLabel);
            this.AdressGroupBox.Controls.Add(this.flatTextBox);
            this.AdressGroupBox.Controls.Add(this.houseTextBox);
            this.AdressGroupBox.Controls.Add(this.houseLabel);
            this.AdressGroupBox.Controls.Add(this.streetTextBox);
            this.AdressGroupBox.Controls.Add(this.streetLabel);
            this.AdressGroupBox.Controls.Add(this.cityComboBox);
            this.AdressGroupBox.Controls.Add(this.cityLabel);
            this.AdressGroupBox.Controls.Add(this.countryComboBox);
            this.AdressGroupBox.Controls.Add(this.countryLabel);
            this.AdressGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdressGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AdressGroupBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.AdressGroupBox.Location = new System.Drawing.Point(183, 23);
            this.AdressGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.AdressGroupBox.Name = "AdressGroupBox";
            this.AdressGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.AdressGroupBox.Size = new System.Drawing.Size(305, 234);
            this.AdressGroupBox.TabIndex = 20;
            this.AdressGroupBox.TabStop = false;
            this.AdressGroupBox.Text = "Адрес";
            // 
            // IndexTextBox
            // 
            this.IndexTextBox.Location = new System.Drawing.Point(160, 202);
            this.IndexTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IndexTextBox.Name = "IndexTextBox";
            this.IndexTextBox.Size = new System.Drawing.Size(121, 26);
            this.IndexTextBox.TabIndex = 29;
            // 
            // IndexLabel
            // 
            this.IndexLabel.AutoSize = true;
            this.IndexLabel.Location = new System.Drawing.Point(8, 209);
            this.IndexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IndexLabel.Name = "IndexLabel";
            this.IndexLabel.Size = new System.Drawing.Size(70, 20);
            this.IndexLabel.TabIndex = 28;
            this.IndexLabel.Text = "Индекс";
            // 
            // flatLabel
            // 
            this.flatLabel.AutoSize = true;
            this.flatLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.flatLabel.Location = new System.Drawing.Point(8, 171);
            this.flatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.flatLabel.Name = "flatLabel";
            this.flatLabel.Size = new System.Drawing.Size(96, 20);
            this.flatLabel.TabIndex = 27;
            this.flatLabel.Text = "Квартира*";
            // 
            // flatTextBox
            // 
            this.flatTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.flatTextBox.Location = new System.Drawing.Point(160, 167);
            this.flatTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.flatTextBox.Name = "flatTextBox";
            this.flatTextBox.Size = new System.Drawing.Size(121, 26);
            this.flatTextBox.TabIndex = 26;
            this.flatTextBox.TextChanged += new System.EventHandler(this.flatTextBox_TextChanged);
            // 
            // houseTextBox
            // 
            this.houseTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.houseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.houseTextBox.Location = new System.Drawing.Point(160, 132);
            this.houseTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.houseTextBox.Name = "houseTextBox";
            this.houseTextBox.Size = new System.Drawing.Size(121, 26);
            this.houseTextBox.TabIndex = 25;
            this.houseTextBox.TextChanged += new System.EventHandler(this.houseTextBox_TextChanged);
            this.houseTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.houseTextBox_Validating);
            // 
            // houseLabel
            // 
            this.houseLabel.AutoSize = true;
            this.houseLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.houseLabel.Location = new System.Drawing.Point(8, 140);
            this.houseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.houseLabel.Name = "houseLabel";
            this.houseLabel.Size = new System.Drawing.Size(50, 20);
            this.houseLabel.TabIndex = 24;
            this.houseLabel.Text = "Дом*";
            // 
            // streetTextBox
            // 
            this.streetTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.streetTextBox.Location = new System.Drawing.Point(160, 96);
            this.streetTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(121, 26);
            this.streetTextBox.TabIndex = 23;
            this.streetTextBox.TextChanged += new System.EventHandler(this.streetTextBox_TextChanged);
            this.streetTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.streetTextBox_Validating);
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.streetLabel.Location = new System.Drawing.Point(8, 105);
            this.streetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(66, 20);
            this.streetLabel.TabIndex = 21;
            this.streetLabel.Text = "Улица*";
            // 
            // cityComboBox
            // 
            this.cityComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Items.AddRange(new object[] {
            "Минск",
            "Витебск",
            "Гомель",
            "Брест",
            "Гродно",
            "Могилёв"});
            this.cityComboBox.Location = new System.Drawing.Point(160, 59);
            this.cityComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(121, 28);
            this.cityComboBox.TabIndex = 21;
            this.cityComboBox.SelectedIndexChanged += new System.EventHandler(this.cityComboBox_SelectedIndexChanged);
            this.cityComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.cityComboBox_Validating);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cityLabel.Location = new System.Drawing.Point(8, 66);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(67, 20);
            this.cityLabel.TabIndex = 21;
            this.cityLabel.Text = "Город*";
            // 
            // countryComboBox
            // 
            this.countryComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.countryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryComboBox.ForeColor = System.Drawing.Color.Gray;
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Items.AddRange(new object[] {
            "Беларусь"});
            this.countryComboBox.Location = new System.Drawing.Point(160, 21);
            this.countryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(121, 28);
            this.countryComboBox.TabIndex = 22;
            this.countryComboBox.SelectedIndexChanged += new System.EventHandler(this.countryComboBox_SelectedIndexChanged);
            this.countryComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.countryComboBox_Validating);
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.countryLabel.Location = new System.Drawing.Point(8, 31);
            this.countryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(77, 20);
            this.countryLabel.TabIndex = 21;
            this.countryLabel.Text = "Страна*";
            // 
            // FloorListBox
            // 
            this.FloorListBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FloorListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FloorListBox.ColumnWidth = 20;
            this.FloorListBox.ForeColor = System.Drawing.Color.DimGray;
            this.FloorListBox.FormattingEnabled = true;
            this.FloorListBox.ItemHeight = 16;
            this.FloorListBox.Items.AddRange(new object[] {
            "25",
            "24",
            "23",
            "22",
            "21",
            "20",
            "19",
            "18",
            "17",
            "16",
            "15",
            "14",
            "13",
            "12",
            "11",
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.FloorListBox.Location = new System.Drawing.Point(291, 95);
            this.FloorListBox.Margin = new System.Windows.Forms.Padding(4);
            this.FloorListBox.MultiColumn = true;
            this.FloorListBox.Name = "FloorListBox";
            this.FloorListBox.Size = new System.Drawing.Size(21, 400);
            this.FloorListBox.TabIndex = 12;
            this.FloorListBox.SelectedIndexChanged += new System.EventHandler(this.FloorListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(287, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Этаж";
            // 
            // SquareLabel
            // 
            this.SquareLabel.AutoSize = true;
            this.SquareLabel.BackColor = System.Drawing.Color.Transparent;
            this.SquareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SquareLabel.Location = new System.Drawing.Point(332, 422);
            this.SquareLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SquareLabel.Name = "SquareLabel";
            this.SquareLabel.Size = new System.Drawing.Size(97, 24);
            this.SquareLabel.TabIndex = 14;
            this.SquareLabel.Text = "Площадь*";
            // 
            // SqareTextBox
            // 
            this.SqareTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SqareTextBox.Location = new System.Drawing.Point(529, 428);
            this.SqareTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SqareTextBox.Name = "SqareTextBox";
            this.SqareTextBox.Size = new System.Drawing.Size(147, 22);
            this.SqareTextBox.TabIndex = 15;
            this.SqareTextBox.TextChanged += new System.EventHandler(this.SqareTextBox_TextChanged);
            this.SqareTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.SqareTextBox_Validating);
            // 
            // phoneNumberMaskedTextBox
            // 
            this.phoneNumberMaskedTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.phoneNumberMaskedTextBox.Location = new System.Drawing.Point(529, 482);
            this.phoneNumberMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneNumberMaskedTextBox.Mask = "+375 (00) 000-00-00";
            this.phoneNumberMaskedTextBox.Name = "phoneNumberMaskedTextBox";
            this.phoneNumberMaskedTextBox.Size = new System.Drawing.Size(147, 22);
            this.phoneNumberMaskedTextBox.SkipLiterals = false;
            this.phoneNumberMaskedTextBox.TabIndex = 16;
            this.phoneNumberMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.phoneNumberMaskedTextBox_MaskInputRejected);
            this.phoneNumberMaskedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.phoneNumberMaskedTextBox_Validating);
            // 
            // infoRichTextBox
            // 
            this.infoRichTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.infoRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoRichTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.infoRichTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.infoRichTextBox.Location = new System.Drawing.Point(1201, 159);
            this.infoRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.infoRichTextBox.Name = "infoRichTextBox";
            this.infoRichTextBox.ReadOnly = true;
            this.infoRichTextBox.Size = new System.Drawing.Size(265, 327);
            this.infoRichTextBox.TabIndex = 21;
            this.infoRichTextBox.Text = "";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveButton.Enabled = false;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.saveButton.FlatAppearance.BorderSize = 2;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.saveButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.saveButton.Location = new System.Drawing.Point(1028, 482);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(131, 49);
            this.saveButton.TabIndex = 23;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showButton.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.showButton.FlatAppearance.BorderSize = 2;
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.showButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.showButton.Location = new System.Drawing.Point(1339, 556);
            this.showButton.Margin = new System.Windows.Forms.Padding(4);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(128, 49);
            this.showButton.TabIndex = 24;
            this.showButton.Text = "Вывод";
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.priceTextBox.Location = new System.Drawing.Point(12, 42);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.priceTextBox.MaxLength = 36;
            this.priceTextBox.Multiline = true;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(157, 32);
            this.priceTextBox.TabIndex = 26;
            this.priceTextBox.Text = "0";
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // priceButton
            // 
            this.priceButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.priceButton.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.priceButton.FlatAppearance.BorderSize = 2;
            this.priceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceButton.ForeColor = System.Drawing.Color.DimGray;
            this.priceButton.Location = new System.Drawing.Point(211, 38);
            this.priceButton.Margin = new System.Windows.Forms.Padding(4);
            this.priceButton.Name = "priceButton";
            this.priceButton.Size = new System.Drawing.Size(140, 39);
            this.priceButton.TabIndex = 27;
            this.priceButton.Text = "Рассчитать";
            this.priceButton.UseVisualStyleBackColor = false;
            this.priceButton.Click += new System.EventHandler(this.priceButton_Click);
            // 
            // priceGroupBox
            // 
            this.priceGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.priceGroupBox.Controls.Add(this.currencyLabel);
            this.priceGroupBox.Controls.Add(this.priceButton);
            this.priceGroupBox.Controls.Add(this.priceTextBox);
            this.priceGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priceGroupBox.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceGroupBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.priceGroupBox.Location = new System.Drawing.Point(699, 363);
            this.priceGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.priceGroupBox.Name = "priceGroupBox";
            this.priceGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.priceGroupBox.Size = new System.Drawing.Size(359, 90);
            this.priceGroupBox.TabIndex = 28;
            this.priceGroupBox.TabStop = false;
            this.priceGroupBox.Text = "Примерная стоимость квартиры";
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.Location = new System.Drawing.Point(179, 46);
            this.currencyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(23, 25);
            this.currencyLabel.TabIndex = 28;
            this.currencyLabel.Text = "$";
            // 
            // m2Label
            // 
            this.m2Label.AutoSize = true;
            this.m2Label.BackColor = System.Drawing.Color.Transparent;
            this.m2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m2Label.Location = new System.Drawing.Point(427, 422);
            this.m2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m2Label.Name = "m2Label";
            this.m2Label.Size = new System.Drawing.Size(43, 24);
            this.m2Label.TabIndex = 29;
            this.m2Label.Text = "(m²)";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumberLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.phoneNumberLabel.Location = new System.Drawing.Point(332, 474);
            this.phoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(118, 48);
            this.phoneNumberLabel.TabIndex = 30;
            this.phoneNumberLabel.Text = "Контактный\r\nтелефон";
            // 
            // flatPictureBox
            // 
            this.flatPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.flatPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("flatPictureBox.Image")));
            this.flatPictureBox.Location = new System.Drawing.Point(431, 69);
            this.flatPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.flatPictureBox.Name = "flatPictureBox";
            this.flatPictureBox.Size = new System.Drawing.Size(181, 217);
            this.flatPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flatPictureBox.TabIndex = 28;
            this.flatPictureBox.TabStop = false;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.infoLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.infoLabel.Location = new System.Drawing.Point(1324, 46);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(138, 25);
            this.infoLabel.TabIndex = 32;
            this.infoLabel.Text = "Информация";
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exportButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.exportButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.exportButton.Location = new System.Drawing.Point(1339, 494);
            this.exportButton.Margin = new System.Windows.Forms.Padding(4);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(128, 38);
            this.exportButton.TabIndex = 33;
            this.exportButton.Text = "Экспорт";
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // importButton
            // 
            this.importButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.importButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.importButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.importButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.importButton.Location = new System.Drawing.Point(1201, 494);
            this.importButton.Margin = new System.Windows.Forms.Padding(4);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(128, 38);
            this.importButton.TabIndex = 34;
            this.importButton.Text = "Импорт";
            this.importButton.UseVisualStyleBackColor = false;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchToolStripMenuItem,
            this.AboutProgramToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MenuStrip.Size = new System.Drawing.Size(1604, 36);
            this.MenuStrip.TabIndex = 36;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // SearchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.SearchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FullToolStripMenuItem,
            this.RegExToolStripMenuItem});
            this.SearchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(83, 32);
            this.SearchToolStripMenuItem.Text = "Поиск";
            this.SearchToolStripMenuItem.Click += new System.EventHandler(this.SearchToolStripMenuItem_Click);
            // 
            // FullToolStripMenuItem
            // 
            this.FullToolStripMenuItem.Name = "FullToolStripMenuItem";
            this.FullToolStripMenuItem.Size = new System.Drawing.Size(367, 32);
            this.FullToolStripMenuItem.Text = "На полное соответствие";
            this.FullToolStripMenuItem.Click += new System.EventHandler(this.FullToolStripMenuItem_Click);
            // 
            // RegExToolStripMenuItem
            // 
            this.RegExToolStripMenuItem.Name = "RegExToolStripMenuItem";
            this.RegExToolStripMenuItem.Size = new System.Drawing.Size(367, 32);
            this.RegExToolStripMenuItem.Text = "По регулярным выражениям";
            this.RegExToolStripMenuItem.Click += new System.EventHandler(this.RegExToolStripMenuItem_Click);
            // 
            // AboutProgramToolStripMenuItem
            // 
            this.AboutProgramToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.AboutProgramToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem";
            this.AboutProgramToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.AboutProgramToolStripMenuItem.Text = "О программе";
            this.AboutProgramToolStripMenuItem.Click += new System.EventHandler(this.AboutProgramToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BaseInfoToolStripStatusLabel,
            this.ActionToolStripStatusLabel,
            this.DateToolStripStatusLabel,
            this.TimeToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 651);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1604, 26);
            this.statusStrip1.TabIndex = 37;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // BaseInfoToolStripStatusLabel
            // 
            this.BaseInfoToolStripStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.BaseInfoToolStripStatusLabel.Name = "BaseInfoToolStripStatusLabel";
            this.BaseInfoToolStripStatusLabel.Size = new System.Drawing.Size(127, 20);
            this.BaseInfoToolStripStatusLabel.Text = "Квартир в базе 0";
            // 
            // ActionToolStripStatusLabel
            // 
            this.ActionToolStripStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.ActionToolStripStatusLabel.Name = "ActionToolStripStatusLabel";
            this.ActionToolStripStatusLabel.Size = new System.Drawing.Size(260, 20);
            this.ActionToolStripStatusLabel.Text = "Последнее выполненное действие: ";
            // 
            // DateToolStripStatusLabel
            // 
            this.DateToolStripStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateToolStripStatusLabel.Name = "DateToolStripStatusLabel";
            this.DateToolStripStatusLabel.Size = new System.Drawing.Size(45, 20);
            this.DateToolStripStatusLabel.Text = "DATE";
            // 
            // TimeToolStripStatusLabel
            // 
            this.TimeToolStripStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeToolStripStatusLabel.Name = "TimeToolStripStatusLabel";
            this.TimeToolStripStatusLabel.Size = new System.Drawing.Size(42, 20);
            this.TimeToolStripStatusLabel.Text = "TIME";
            // 
            // SortByComboBox
            // 
            this.SortByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortByComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortByComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SortByComboBox.FormattingEnabled = true;
            this.SortByComboBox.Items.AddRange(new object[] {
            "по площади",
            "по количеству комнат",
            "по цене"});
            this.SortByComboBox.Location = new System.Drawing.Point(1201, 118);
            this.SortByComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.SortByComboBox.Name = "SortByComboBox";
            this.SortByComboBox.Size = new System.Drawing.Size(119, 28);
            this.SortByComboBox.TabIndex = 38;
            this.SortByComboBox.SelectedIndexChanged += new System.EventHandler(this.SortByComboBox_SelectedIndexChanged);
            // 
            // SortByLabel
            // 
            this.SortByLabel.AutoSize = true;
            this.SortByLabel.BackColor = System.Drawing.Color.Transparent;
            this.SortByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SortByLabel.Location = new System.Drawing.Point(1197, 94);
            this.SortByLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SortByLabel.Name = "SortByLabel";
            this.SortByLabel.Size = new System.Drawing.Size(121, 20);
            this.SortByLabel.TabIndex = 39;
            this.SortByLabel.Text = "Сортировать";
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
            this.SaveSortResCheckBox.Location = new System.Drawing.Point(1339, 116);
            this.SaveSortResCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.SaveSortResCheckBox.Name = "SaveSortResCheckBox";
            this.SaveSortResCheckBox.Size = new System.Drawing.Size(92, 28);
            this.SaveSortResCheckBox.TabIndex = 40;
            this.SaveSortResCheckBox.Text = "Сохранить";
            this.SaveSortResCheckBox.UseVisualStyleBackColor = false;
            // 
            // DateTimetimer
            // 
            this.DateTimetimer.Enabled = true;
            this.DateTimetimer.Tick += new System.EventHandler(this.DateTimetimer_Tick);
            // 
            // SearchStripDropDownButton
            // 
            this.SearchStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SearchStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regexToolStripMenuItem1,
            this.наПолноеСоответствиеToolStripMenuItem});
            this.SearchStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchStripDropDownButton.Image")));
            this.SearchStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchStripDropDownButton.Name = "SearchStripDropDownButton";
            this.SearchStripDropDownButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.SearchStripDropDownButton.Size = new System.Drawing.Size(66, 24);
            this.SearchStripDropDownButton.Text = "Поиск";
            this.SearchStripDropDownButton.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // regexToolStripMenuItem1
            // 
            this.regexToolStripMenuItem1.Name = "regexToolStripMenuItem1";
            this.regexToolStripMenuItem1.Size = new System.Drawing.Size(260, 26);
            this.regexToolStripMenuItem1.Text = "regex";
            this.regexToolStripMenuItem1.Click += new System.EventHandler(this.regexToolStripMenuItem1_Click);
            // 
            // наПолноеСоответствиеToolStripMenuItem
            // 
            this.наПолноеСоответствиеToolStripMenuItem.Name = "наПолноеСоответствиеToolStripMenuItem";
            this.наПолноеСоответствиеToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.наПолноеСоответствиеToolStripMenuItem.Text = "на полное соответствие";
            this.наПолноеСоответствиеToolStripMenuItem.Click += new System.EventHandler(this.fullToolStripMenuItem_Click);
            // 
            // ResetToolStripButton
            // 
            this.ResetToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.ResetToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ResetToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ResetToolStripButton.Image")));
            this.ResetToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ResetToolStripButton.Name = "ResetToolStripButton";
            this.ResetToolStripButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.ResetToolStripButton.Size = new System.Drawing.Size(77, 24);
            this.ResetToolStripButton.Text = "Очистить";
            this.ResetToolStripButton.Click += new System.EventHandler(this.ResetToolStripButton_Click);
            // 
            // FlatToolStrip
            // 
            this.FlatToolStrip.BackColor = System.Drawing.Color.White;
            this.FlatToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.FlatToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.FlatToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.FlatToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchStripDropDownButton,
            this.ResetToolStripButton});
            this.FlatToolStrip.Location = new System.Drawing.Point(0, 633);
            this.FlatToolStrip.Name = "FlatToolStrip";
            this.FlatToolStrip.Size = new System.Drawing.Size(17, 25);
            this.FlatToolStrip.TabIndex = 41;
            this.FlatToolStrip.Text = "ToolStrip";
            this.FlatToolStrip.DoubleClick += new System.EventHandler(this.FlatToolStrip_DoubleClick);
            // 
            // CloneButton
            // 
            this.CloneButton.Location = new System.Drawing.Point(1201, 556);
            this.CloneButton.Name = "CloneButton";
            this.CloneButton.Size = new System.Drawing.Size(131, 49);
            this.CloneButton.TabIndex = 42;
            this.CloneButton.Text = "Клонировать";
            this.CloneButton.UseVisualStyleBackColor = true;
            this.CloneButton.Click += new System.EventHandler(this.CloneButton_Click);
            // 
            // FlatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1604, 677);
            this.Controls.Add(this.CloneButton);
            this.Controls.Add(this.FlatToolStrip);
            this.Controls.Add(this.SaveSortResCheckBox);
            this.Controls.Add(this.SortByLabel);
            this.Controls.Add(this.SortByComboBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.flatPictureBox);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.m2Label);
            this.Controls.Add(this.priceGroupBox);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.infoRichTextBox);
            this.Controls.Add(this.phoneNumberMaskedTextBox);
            this.Controls.Add(this.SqareTextBox);
            this.Controls.Add(this.SquareLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FloorListBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.yearResultLabel);
            this.Controls.Add(this.yearTrackBar);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.roomsCountComboBox);
            this.Controls.Add(this.roomCountLabel);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1650, 724);
            this.MinimumSize = new System.Drawing.Size(1597, 724);
            this.Name = "FlatForm";
            this.Text = "Квартира";
            this.Load += new System.EventHandler(this.FlatForm_Load);
            this.OptionsGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.AdressGroupBox.ResumeLayout(false);
            this.AdressGroupBox.PerformLayout();
            this.priceGroupBox.ResumeLayout(false);
            this.priceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flatPictureBox)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.FlatToolStrip.ResumeLayout(false);
            this.FlatToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Label roomCountLabel;
        private System.Windows.Forms.ComboBox roomsCountComboBox;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.CheckBox BalconyCheckBox;
        private System.Windows.Forms.CheckBox FooterCheckBox;
        private System.Windows.Forms.CheckBox WCCheckBox;
        private System.Windows.Forms.CheckBox BathroomCheckBox;
        private System.Windows.Forms.CheckBox KitchenСheckBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TrackBar yearTrackBar;
        private System.Windows.Forms.Label yearResultLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox FloorListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SqareTextBox;
        private System.Windows.Forms.Label SquareLabel;
        private System.Windows.Forms.MaskedTextBox phoneNumberMaskedTextBox;
        private System.Windows.Forms.GroupBox AdressGroupBox;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label flatLabel;
        private System.Windows.Forms.TextBox flatTextBox;
        private System.Windows.Forms.TextBox houseTextBox;
        private System.Windows.Forms.Label houseLabel;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.RichTextBox infoRichTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.GroupBox priceGroupBox;
        private System.Windows.Forms.Button priceButton;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label m2Label;
        private System.Windows.Forms.Label currencyLabel;
        private System.Windows.Forms.PictureBox flatPictureBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FullToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegExToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel BaseInfoToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ActionToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel DateToolStripStatusLabel;
        private System.Windows.Forms.Label SortByLabel;
        private System.Windows.Forms.ComboBox SortByComboBox;
        private System.Windows.Forms.CheckBox SaveSortResCheckBox;
        private System.Windows.Forms.Timer DateTimetimer;
        private System.Windows.Forms.ToolStripStatusLabel TimeToolStripStatusLabel;
        private System.Windows.Forms.ToolStrip FlatToolStrip;
        private System.Windows.Forms.ToolStripDropDownButton SearchStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem regexToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem наПолноеСоответствиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton ResetToolStripButton;
        private TextBox IndexTextBox;
        private Label IndexLabel;
        private Button CloneButton;
    }
}

