
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.infoLabel = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.OptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.AdressGroupBox.SuspendLayout();
            this.priceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flatPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.BackColor = System.Drawing.Color.Transparent;
            this.headingLabel.Font = new System.Drawing.Font("Malgun Gothic", 36F, System.Drawing.FontStyle.Bold);
            this.headingLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.headingLabel.Location = new System.Drawing.Point(533, 9);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(140, 65);
            this.headingLabel.TabIndex = 0;
            this.headingLabel.Text = "FLAT";
            // 
            // roomCountLabel
            // 
            this.roomCountLabel.AutoSize = true;
            this.roomCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.roomCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomCountLabel.Location = new System.Drawing.Point(249, 242);
            this.roomCountLabel.Name = "roomCountLabel";
            this.roomCountLabel.Size = new System.Drawing.Size(153, 18);
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
            this.roomsCountComboBox.Location = new System.Drawing.Point(430, 239);
            this.roomsCountComboBox.Name = "roomsCountComboBox";
            this.roomsCountComboBox.Size = new System.Drawing.Size(78, 21);
            this.roomsCountComboBox.TabIndex = 2;
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
            this.OptionsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OptionsGroupBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.OptionsGroupBox.Location = new System.Drawing.Point(19, 19);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(94, 167);
            this.OptionsGroupBox.TabIndex = 3;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Опции";
            // 
            // BalconyCheckBox
            // 
            this.BalconyCheckBox.AutoSize = true;
            this.BalconyCheckBox.Location = new System.Drawing.Point(15, 138);
            this.BalconyCheckBox.Name = "BalconyCheckBox";
            this.BalconyCheckBox.Size = new System.Drawing.Size(75, 21);
            this.BalconyCheckBox.TabIndex = 4;
            this.BalconyCheckBox.Text = "Балкон";
            this.BalconyCheckBox.UseVisualStyleBackColor = true;
            // 
            // FooterCheckBox
            // 
            this.FooterCheckBox.AutoSize = true;
            this.FooterCheckBox.Location = new System.Drawing.Point(16, 110);
            this.FooterCheckBox.Name = "FooterCheckBox";
            this.FooterCheckBox.Size = new System.Drawing.Size(76, 21);
            this.FooterCheckBox.TabIndex = 3;
            this.FooterCheckBox.Text = "Подвал";
            this.FooterCheckBox.UseVisualStyleBackColor = true;
            // 
            // WCCheckBox
            // 
            this.WCCheckBox.AutoSize = true;
            this.WCCheckBox.Checked = true;
            this.WCCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WCCheckBox.Location = new System.Drawing.Point(16, 83);
            this.WCCheckBox.Name = "WCCheckBox";
            this.WCCheckBox.Size = new System.Drawing.Size(74, 21);
            this.WCCheckBox.TabIndex = 2;
            this.WCCheckBox.Text = "Туалет";
            this.WCCheckBox.UseVisualStyleBackColor = true;
            // 
            // BathroomCheckBox
            // 
            this.BathroomCheckBox.AutoSize = true;
            this.BathroomCheckBox.Checked = true;
            this.BathroomCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BathroomCheckBox.Location = new System.Drawing.Point(15, 58);
            this.BathroomCheckBox.Name = "BathroomCheckBox";
            this.BathroomCheckBox.Size = new System.Drawing.Size(76, 21);
            this.BathroomCheckBox.TabIndex = 1;
            this.BathroomCheckBox.Text = "Ванная";
            this.BathroomCheckBox.UseVisualStyleBackColor = true;
            // 
            // KitchenСheckBox
            // 
            this.KitchenСheckBox.AutoSize = true;
            this.KitchenСheckBox.Checked = true;
            this.KitchenСheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.KitchenСheckBox.Location = new System.Drawing.Point(15, 33);
            this.KitchenСheckBox.Name = "KitchenСheckBox";
            this.KitchenСheckBox.Size = new System.Drawing.Size(65, 21);
            this.KitchenСheckBox.TabIndex = 0;
            this.KitchenСheckBox.Text = "Кухня";
            this.KitchenСheckBox.UseVisualStyleBackColor = true;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.BackColor = System.Drawing.Color.Transparent;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearLabel.Location = new System.Drawing.Point(249, 295);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(112, 18);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Год постройки";
            // 
            // yearTrackBar
            // 
            this.yearTrackBar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.yearTrackBar.Location = new System.Drawing.Point(397, 281);
            this.yearTrackBar.Maximum = 2021;
            this.yearTrackBar.Minimum = 1950;
            this.yearTrackBar.Name = "yearTrackBar";
            this.yearTrackBar.Size = new System.Drawing.Size(111, 45);
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
            this.yearResultLabel.Location = new System.Drawing.Point(438, 311);
            this.yearResultLabel.Name = "yearResultLabel";
            this.yearResultLabel.Size = new System.Drawing.Size(35, 15);
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
            this.panel1.Location = new System.Drawing.Point(514, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 195);
            this.panel1.TabIndex = 11;
            // 
            // AdressGroupBox
            // 
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
            this.AdressGroupBox.Location = new System.Drawing.Point(137, 19);
            this.AdressGroupBox.Name = "AdressGroupBox";
            this.AdressGroupBox.Size = new System.Drawing.Size(229, 167);
            this.AdressGroupBox.TabIndex = 20;
            this.AdressGroupBox.TabStop = false;
            this.AdressGroupBox.Text = "Адрес";
            // 
            // flatLabel
            // 
            this.flatLabel.AutoSize = true;
            this.flatLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.flatLabel.Location = new System.Drawing.Point(6, 139);
            this.flatLabel.Name = "flatLabel";
            this.flatLabel.Size = new System.Drawing.Size(76, 17);
            this.flatLabel.TabIndex = 27;
            this.flatLabel.Text = "Квартира*";
            // 
            // flatTextBox
            // 
            this.flatTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.flatTextBox.Location = new System.Drawing.Point(120, 133);
            this.flatTextBox.Name = "flatTextBox";
            this.flatTextBox.Size = new System.Drawing.Size(92, 23);
            this.flatTextBox.TabIndex = 26;
            this.flatTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.flatTextBox_Validating);
            // 
            // houseTextBox
            // 
            this.houseTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.houseTextBox.Location = new System.Drawing.Point(120, 107);
            this.houseTextBox.Name = "houseTextBox";
            this.houseTextBox.Size = new System.Drawing.Size(92, 23);
            this.houseTextBox.TabIndex = 25;
            this.houseTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.houseTextBox_Validating);
            // 
            // houseLabel
            // 
            this.houseLabel.AutoSize = true;
            this.houseLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.houseLabel.Location = new System.Drawing.Point(6, 114);
            this.houseLabel.Name = "houseLabel";
            this.houseLabel.Size = new System.Drawing.Size(41, 17);
            this.houseLabel.TabIndex = 24;
            this.houseLabel.Text = "Дом*";
            // 
            // streetTextBox
            // 
            this.streetTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.streetTextBox.Location = new System.Drawing.Point(120, 78);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(92, 23);
            this.streetTextBox.TabIndex = 23;
            this.streetTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.streetTextBox_Validating);
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.streetLabel.Location = new System.Drawing.Point(6, 85);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(54, 17);
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
            this.cityComboBox.Location = new System.Drawing.Point(120, 48);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(92, 24);
            this.cityComboBox.TabIndex = 21;
            this.cityComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.cityComboBox_Validating);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cityLabel.Location = new System.Drawing.Point(6, 54);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(53, 17);
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
            this.countryComboBox.Location = new System.Drawing.Point(120, 17);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(92, 24);
            this.countryComboBox.TabIndex = 22;
            this.countryComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.countryComboBox_Validating);
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.countryLabel.Location = new System.Drawing.Point(6, 25);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(61, 17);
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
            this.FloorListBox.Location = new System.Drawing.Point(218, 77);
            this.FloorListBox.MultiColumn = true;
            this.FloorListBox.Name = "FloorListBox";
            this.FloorListBox.Size = new System.Drawing.Size(16, 325);
            this.FloorListBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(215, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Этаж";
            // 
            // SquareLabel
            // 
            this.SquareLabel.AutoSize = true;
            this.SquareLabel.BackColor = System.Drawing.Color.Transparent;
            this.SquareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SquareLabel.Location = new System.Drawing.Point(249, 343);
            this.SquareLabel.Name = "SquareLabel";
            this.SquareLabel.Size = new System.Drawing.Size(79, 18);
            this.SquareLabel.TabIndex = 14;
            this.SquareLabel.Text = "Площадь*";
            // 
            // SqareTextBox
            // 
            this.SqareTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SqareTextBox.Location = new System.Drawing.Point(397, 348);
            this.SqareTextBox.Name = "SqareTextBox";
            this.SqareTextBox.Size = new System.Drawing.Size(111, 20);
            this.SqareTextBox.TabIndex = 15;
            this.SqareTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.SqareTextBox_Validating);
            // 
            // phoneNumberMaskedTextBox
            // 
            this.phoneNumberMaskedTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.phoneNumberMaskedTextBox.Location = new System.Drawing.Point(397, 392);
            this.phoneNumberMaskedTextBox.Mask = "+375 (00) 000-00-00";
            this.phoneNumberMaskedTextBox.Name = "phoneNumberMaskedTextBox";
            this.phoneNumberMaskedTextBox.Size = new System.Drawing.Size(111, 20);
            this.phoneNumberMaskedTextBox.SkipLiterals = false;
            this.phoneNumberMaskedTextBox.TabIndex = 16;
            this.phoneNumberMaskedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.phoneNumberMaskedTextBox_Validating);
            // 
            // infoRichTextBox
            // 
            this.infoRichTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.infoRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoRichTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.infoRichTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.infoRichTextBox.Location = new System.Drawing.Point(901, 60);
            this.infoRichTextBox.Name = "infoRichTextBox";
            this.infoRichTextBox.ReadOnly = true;
            this.infoRichTextBox.Size = new System.Drawing.Size(199, 266);
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
            this.saveButton.Location = new System.Drawing.Point(765, 385);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(98, 40);
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
            this.showButton.Location = new System.Drawing.Point(899, 385);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(93, 40);
            this.showButton.TabIndex = 24;
            this.showButton.Text = "Вывод";
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.priceTextBox.Location = new System.Drawing.Point(9, 34);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(78, 27);
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
            this.priceButton.Location = new System.Drawing.Point(149, 34);
            this.priceButton.Name = "priceButton";
            this.priceButton.Size = new System.Drawing.Size(105, 32);
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
            this.priceGroupBox.Location = new System.Drawing.Point(524, 295);
            this.priceGroupBox.Name = "priceGroupBox";
            this.priceGroupBox.Size = new System.Drawing.Size(269, 73);
            this.priceGroupBox.TabIndex = 28;
            this.priceGroupBox.TabStop = false;
            this.priceGroupBox.Text = "Примерная стоимость квартиры";
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.Location = new System.Drawing.Point(93, 37);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(18, 20);
            this.currencyLabel.TabIndex = 28;
            this.currencyLabel.Text = "$";
            // 
            // m2Label
            // 
            this.m2Label.AutoSize = true;
            this.m2Label.BackColor = System.Drawing.Color.Transparent;
            this.m2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m2Label.Location = new System.Drawing.Point(320, 343);
            this.m2Label.Name = "m2Label";
            this.m2Label.Size = new System.Drawing.Size(36, 18);
            this.m2Label.TabIndex = 29;
            this.m2Label.Text = "(m²)";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumberLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.phoneNumberLabel.Location = new System.Drawing.Point(249, 385);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(92, 36);
            this.phoneNumberLabel.TabIndex = 30;
            this.phoneNumberLabel.Text = "Контактный\r\nтелефон";
            // 
            // flatPictureBox
            // 
            this.flatPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.flatPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("flatPictureBox.Image")));
            this.flatPictureBox.Location = new System.Drawing.Point(323, 56);
            this.flatPictureBox.Name = "flatPictureBox";
            this.flatPictureBox.Size = new System.Drawing.Size(136, 176);
            this.flatPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flatPictureBox.TabIndex = 28;
            this.flatPictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.infoLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.infoLabel.Location = new System.Drawing.Point(993, 37);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(107, 20);
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
            this.exportButton.Location = new System.Drawing.Point(1004, 336);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(96, 39);
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
            this.importButton.Location = new System.Drawing.Point(1004, 386);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(96, 39);
            this.importButton.TabIndex = 34;
            this.importButton.Text = "Импорт";
            this.importButton.UseVisualStyleBackColor = false;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // FlatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1227, 450);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1243, 488);
            this.MinimumSize = new System.Drawing.Size(1243, 488);
            this.Name = "FlatForm";
            this.Text = "Квартира";
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
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button importButton;
    }
}

