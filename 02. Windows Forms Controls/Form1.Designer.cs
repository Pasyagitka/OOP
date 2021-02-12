
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
            this.toYearResultLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.FloorListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SquareLabel = new System.Windows.Forms.Label();
            this.SqareTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
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
            this.splitter1 = new System.Windows.Forms.Splitter();
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
            this.headingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headingLabel.Location = new System.Drawing.Point(353, 9);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(155, 37);
            this.headingLabel.TabIndex = 0;
            this.headingLabel.Text = "Квартира";
            // 
            // roomCountLabel
            // 
            this.roomCountLabel.AutoSize = true;
            this.roomCountLabel.Location = new System.Drawing.Point(90, 236);
            this.roomCountLabel.Name = "roomCountLabel";
            this.roomCountLabel.Size = new System.Drawing.Size(106, 13);
            this.roomCountLabel.TabIndex = 1;
            this.roomCountLabel.Text = "Количество комнат";
            // 
            // roomsCountComboBox
            // 
            this.roomsCountComboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.roomsCountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomsCountComboBox.FormattingEnabled = true;
            this.roomsCountComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5 и более"});
            this.roomsCountComboBox.Location = new System.Drawing.Point(212, 233);
            this.roomsCountComboBox.Name = "roomsCountComboBox";
            this.roomsCountComboBox.Size = new System.Drawing.Size(80, 21);
            this.roomsCountComboBox.TabIndex = 2;
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.Controls.Add(this.BalconyCheckBox);
            this.OptionsGroupBox.Controls.Add(this.FooterCheckBox);
            this.OptionsGroupBox.Controls.Add(this.WCCheckBox);
            this.OptionsGroupBox.Controls.Add(this.BathroomCheckBox);
            this.OptionsGroupBox.Controls.Add(this.KitchenСheckBox);
            this.OptionsGroupBox.Location = new System.Drawing.Point(19, 19);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(94, 147);
            this.OptionsGroupBox.TabIndex = 3;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Опции";
            // 
            // BalconyCheckBox
            // 
            this.BalconyCheckBox.AutoSize = true;
            this.BalconyCheckBox.Location = new System.Drawing.Point(17, 124);
            this.BalconyCheckBox.Name = "BalconyCheckBox";
            this.BalconyCheckBox.Size = new System.Drawing.Size(63, 17);
            this.BalconyCheckBox.TabIndex = 4;
            this.BalconyCheckBox.Text = "Балкон";
            this.BalconyCheckBox.UseVisualStyleBackColor = true;
            // 
            // FooterCheckBox
            // 
            this.FooterCheckBox.AutoSize = true;
            this.FooterCheckBox.Location = new System.Drawing.Point(17, 100);
            this.FooterCheckBox.Name = "FooterCheckBox";
            this.FooterCheckBox.Size = new System.Drawing.Size(64, 17);
            this.FooterCheckBox.TabIndex = 3;
            this.FooterCheckBox.Text = "Подвал";
            this.FooterCheckBox.UseVisualStyleBackColor = true;
            // 
            // WCCheckBox
            // 
            this.WCCheckBox.AutoSize = true;
            this.WCCheckBox.Location = new System.Drawing.Point(17, 76);
            this.WCCheckBox.Name = "WCCheckBox";
            this.WCCheckBox.Size = new System.Drawing.Size(61, 17);
            this.WCCheckBox.TabIndex = 2;
            this.WCCheckBox.Text = "Туалет";
            this.WCCheckBox.UseVisualStyleBackColor = true;
            // 
            // BathroomCheckBox
            // 
            this.BathroomCheckBox.AutoSize = true;
            this.BathroomCheckBox.Location = new System.Drawing.Point(17, 52);
            this.BathroomCheckBox.Name = "BathroomCheckBox";
            this.BathroomCheckBox.Size = new System.Drawing.Size(63, 17);
            this.BathroomCheckBox.TabIndex = 1;
            this.BathroomCheckBox.Text = "Ванная";
            this.BathroomCheckBox.UseVisualStyleBackColor = true;
            // 
            // KitchenСheckBox
            // 
            this.KitchenСheckBox.AutoSize = true;
            this.KitchenСheckBox.Location = new System.Drawing.Point(17, 28);
            this.KitchenСheckBox.Name = "KitchenСheckBox";
            this.KitchenСheckBox.Size = new System.Drawing.Size(55, 17);
            this.KitchenСheckBox.TabIndex = 0;
            this.KitchenСheckBox.Text = "Кухня";
            this.KitchenСheckBox.UseVisualStyleBackColor = true;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(93, 275);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(81, 13);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Год постройки";
            // 
            // yearTrackBar
            // 
            this.yearTrackBar.Location = new System.Drawing.Point(205, 275);
            this.yearTrackBar.Maximum = 2021;
            this.yearTrackBar.Minimum = 1950;
            this.yearTrackBar.Name = "yearTrackBar";
            this.yearTrackBar.Size = new System.Drawing.Size(107, 45);
            this.yearTrackBar.TabIndex = 6;
            this.yearTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.yearTrackBar.Value = 2021;
            this.yearTrackBar.Scroll += new System.EventHandler(this.toYearTrackBar_Scroll);
            // 
            // toYearResultLabel
            // 
            this.toYearResultLabel.AutoSize = true;
            this.toYearResultLabel.Location = new System.Drawing.Point(242, 307);
            this.toYearResultLabel.Name = "toYearResultLabel";
            this.toYearResultLabel.Size = new System.Drawing.Size(31, 13);
            this.toYearResultLabel.TabIndex = 10;
            this.toYearResultLabel.Text = "2021";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OptionsGroupBox);
            this.panel1.Location = new System.Drawing.Point(335, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 189);
            this.panel1.TabIndex = 11;
            // 
            // FloorListBox
            // 
            this.FloorListBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.FloorListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FloorListBox.ColumnWidth = 20;
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
            this.FloorListBox.Location = new System.Drawing.Point(53, 75);
            this.FloorListBox.MultiColumn = true;
            this.FloorListBox.Name = "FloorListBox";
            this.FloorListBox.Size = new System.Drawing.Size(18, 327);
            this.FloorListBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Этаж";
            // 
            // SquareLabel
            // 
            this.SquareLabel.AutoSize = true;
            this.SquareLabel.Location = new System.Drawing.Point(93, 341);
            this.SquareLabel.Name = "SquareLabel";
            this.SquareLabel.Size = new System.Drawing.Size(54, 13);
            this.SquareLabel.TabIndex = 14;
            this.SquareLabel.Text = "Площадь";
            // 
            // SqareTextBox
            // 
            this.SqareTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SqareTextBox.Location = new System.Drawing.Point(212, 341);
            this.SqareTextBox.Name = "SqareTextBox";
            this.SqareTextBox.Size = new System.Drawing.Size(80, 20);
            this.SqareTextBox.TabIndex = 15;
            // 
            // phoneNumberMaskedTextBox
            // 
            this.phoneNumberMaskedTextBox.Location = new System.Drawing.Point(212, 383);
            this.phoneNumberMaskedTextBox.Mask = "+375 (99) 000-00-00";
            this.phoneNumberMaskedTextBox.Name = "phoneNumberMaskedTextBox";
            this.phoneNumberMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberMaskedTextBox.TabIndex = 16;
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
            this.AdressGroupBox.Location = new System.Drawing.Point(490, 114);
            this.AdressGroupBox.Name = "AdressGroupBox";
            this.AdressGroupBox.Size = new System.Drawing.Size(178, 157);
            this.AdressGroupBox.TabIndex = 20;
            this.AdressGroupBox.TabStop = false;
            this.AdressGroupBox.Text = "Адрес";
            // 
            // flatLabel
            // 
            this.flatLabel.AutoSize = true;
            this.flatLabel.Location = new System.Drawing.Point(6, 138);
            this.flatLabel.Name = "flatLabel";
            this.flatLabel.Size = new System.Drawing.Size(55, 13);
            this.flatLabel.TabIndex = 27;
            this.flatLabel.Text = "Квартира";
            // 
            // flatTextBox
            // 
            this.flatTextBox.Location = new System.Drawing.Point(66, 131);
            this.flatTextBox.Name = "flatTextBox";
            this.flatTextBox.Size = new System.Drawing.Size(92, 20);
            this.flatTextBox.TabIndex = 26;
            // 
            // houseTextBox
            // 
            this.houseTextBox.Location = new System.Drawing.Point(66, 105);
            this.houseTextBox.Name = "houseTextBox";
            this.houseTextBox.Size = new System.Drawing.Size(92, 20);
            this.houseTextBox.TabIndex = 25;
            // 
            // houseLabel
            // 
            this.houseLabel.AutoSize = true;
            this.houseLabel.Location = new System.Drawing.Point(17, 108);
            this.houseLabel.Name = "houseLabel";
            this.houseLabel.Size = new System.Drawing.Size(30, 13);
            this.houseLabel.TabIndex = 24;
            this.houseLabel.Text = "Дом";
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(66, 77);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(92, 20);
            this.streetTextBox.TabIndex = 23;
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(17, 80);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(39, 13);
            this.streetLabel.TabIndex = 21;
            this.streetLabel.Text = "Улица";
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Items.AddRange(new object[] {
            "Минск",
            "Витебск",
            "Гомель",
            "Брест",
            "Гродно",
            "Могилёв"});
            this.cityComboBox.Location = new System.Drawing.Point(66, 50);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(92, 21);
            this.cityComboBox.TabIndex = 21;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(17, 55);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(37, 13);
            this.cityLabel.TabIndex = 21;
            this.cityLabel.Text = "Город";
            // 
            // countryComboBox
            // 
            this.countryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Items.AddRange(new object[] {
            "Беларусь"});
            this.countryComboBox.Location = new System.Drawing.Point(66, 23);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(92, 21);
            this.countryComboBox.TabIndex = 22;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(13, 31);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(43, 13);
            this.countryLabel.TabIndex = 21;
            this.countryLabel.Text = "Страна";
            // 
            // infoRichTextBox
            // 
            this.infoRichTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.infoRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoRichTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.infoRichTextBox.Location = new System.Drawing.Point(726, 75);
            this.infoRichTextBox.Name = "infoRichTextBox";
            this.infoRichTextBox.ReadOnly = true;
            this.infoRichTextBox.Size = new System.Drawing.Size(197, 266);
            this.infoRichTextBox.TabIndex = 21;
            this.infoRichTextBox.Text = "";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.saveButton.FlatAppearance.BorderSize = 2;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(613, 379);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 24);
            this.saveButton.TabIndex = 23;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.showButton.FlatAppearance.BorderSize = 2;
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Location = new System.Drawing.Point(833, 375);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 24;
            this.showButton.Text = "Вывод";
            this.showButton.UseVisualStyleBackColor = false;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(23, 21);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(61, 20);
            this.priceTextBox.TabIndex = 26;
            this.priceTextBox.Text = "0";
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.priceTextBox.TextChanged += new System.EventHandler(this.costTextBox_TextChanged);
            // 
            // priceButton
            // 
            this.priceButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.priceButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.priceButton.FlatAppearance.BorderSize = 2;
            this.priceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priceButton.Location = new System.Drawing.Point(127, 19);
            this.priceButton.Name = "priceButton";
            this.priceButton.Size = new System.Drawing.Size(86, 23);
            this.priceButton.TabIndex = 27;
            this.priceButton.Text = "Рассчитать";
            this.priceButton.UseVisualStyleBackColor = false;
            this.priceButton.Click += new System.EventHandler(this.priceButton_Click);
            // 
            // priceGroupBox
            // 
            this.priceGroupBox.Controls.Add(this.currencyLabel);
            this.priceGroupBox.Controls.Add(this.priceButton);
            this.priceGroupBox.Controls.Add(this.priceTextBox);
            this.priceGroupBox.Location = new System.Drawing.Point(335, 307);
            this.priceGroupBox.Name = "priceGroupBox";
            this.priceGroupBox.Size = new System.Drawing.Size(219, 55);
            this.priceGroupBox.TabIndex = 28;
            this.priceGroupBox.TabStop = false;
            this.priceGroupBox.Text = "Примерная стоимость квартиры";
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.Location = new System.Drawing.Point(90, 24);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(13, 13);
            this.currencyLabel.TabIndex = 28;
            this.currencyLabel.Text = "$";
            // 
            // m2Label
            // 
            this.m2Label.AutoSize = true;
            this.m2Label.Location = new System.Drawing.Point(298, 343);
            this.m2Label.Name = "m2Label";
            this.m2Label.Size = new System.Drawing.Size(18, 13);
            this.m2Label.TabIndex = 29;
            this.m2Label.Text = "m²";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(93, 386);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(114, 13);
            this.phoneNumberLabel.TabIndex = 30;
            this.phoneNumberLabel.Text = "Контактный телефон";
            // 
            // flatPictureBox
            // 
            this.flatPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("flatPictureBox.Image")));
            this.flatPictureBox.Location = new System.Drawing.Point(93, 88);
            this.flatPictureBox.Name = "flatPictureBox";
            this.flatPictureBox.Size = new System.Drawing.Size(219, 129);
            this.flatPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            this.infoLabel.Location = new System.Drawing.Point(723, 56);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(73, 13);
            this.infoLabel.TabIndex = 32;
            this.infoLabel.Text = "Информация";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 450);
            this.splitter1.TabIndex = 33;
            this.splitter1.TabStop = false;
            // 
            // FlatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.flatPictureBox);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.m2Label);
            this.Controls.Add(this.priceGroupBox);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.infoRichTextBox);
            this.Controls.Add(this.AdressGroupBox);
            this.Controls.Add(this.phoneNumberMaskedTextBox);
            this.Controls.Add(this.SqareTextBox);
            this.Controls.Add(this.SquareLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FloorListBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toYearResultLabel);
            this.Controls.Add(this.yearTrackBar);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.roomsCountComboBox);
            this.Controls.Add(this.roomCountLabel);
            this.Controls.Add(this.headingLabel);
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
        private System.Windows.Forms.Label toYearResultLabel;
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
        private System.Windows.Forms.Splitter splitter1;
    }
}

