
namespace Windows_Forms_Controls
{
    partial class RegExSearchWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegExSearchWindow));
            this.OKButton = new System.Windows.Forms.Button();
            this.RegexSearchRichTextBox = new System.Windows.Forms.RichTextBox();
            this.headingLabel = new System.Windows.Forms.Label();
            this.SaveSortResCheckBox = new System.Windows.Forms.CheckBox();
            this.RegExComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(265, 346);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // RegexSearchRichTextBox
            // 
            this.RegexSearchRichTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RegexSearchRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegexSearchRichTextBox.Location = new System.Drawing.Point(191, 92);
            this.RegexSearchRichTextBox.Name = "RegexSearchRichTextBox";
            this.RegexSearchRichTextBox.ReadOnly = true;
            this.RegexSearchRichTextBox.Size = new System.Drawing.Size(235, 239);
            this.RegexSearchRichTextBox.TabIndex = 4;
            this.RegexSearchRichTextBox.Text = "";
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.BackColor = System.Drawing.Color.Transparent;
            this.headingLabel.Font = new System.Drawing.Font("Malgun Gothic", 26F, System.Drawing.FontStyle.Bold);
            this.headingLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.headingLabel.Location = new System.Drawing.Point(12, 80);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(156, 94);
            this.headingLabel.TabIndex = 34;
            this.headingLabel.Text = "REGEX\r\nSEARCH";
            this.headingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.SaveSortResCheckBox.Location = new System.Drawing.Point(346, 344);
            this.SaveSortResCheckBox.Name = "SaveSortResCheckBox";
            this.SaveSortResCheckBox.Size = new System.Drawing.Size(80, 25);
            this.SaveSortResCheckBox.TabIndex = 41;
            this.SaveSortResCheckBox.Text = "Сохранить";
            this.SaveSortResCheckBox.UseVisualStyleBackColor = false;
            // 
            // RegExComboBox
            // 
            this.RegExComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RegExComboBox.FormattingEnabled = true;
            this.RegExComboBox.Items.AddRange(new object[] {
            "\\w*усь",
            "Свер\\w*"});
            this.RegExComboBox.Location = new System.Drawing.Point(191, 40);
            this.RegExComboBox.Name = "RegExComboBox";
            this.RegExComboBox.Size = new System.Drawing.Size(238, 24);
            this.RegExComboBox.TabIndex = 42;
            this.RegExComboBox.Text = "Введите регулярное выражение";
            // 
            // RegExSearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(438, 387);
            this.Controls.Add(this.RegExComboBox);
            this.Controls.Add(this.SaveSortResCheckBox);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.RegexSearchRichTextBox);
            this.Controls.Add(this.OKButton);
            this.Name = "RegExSearchWindow";
            this.Text = "Поиск по регулярному выражению";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.RichTextBox RegexSearchRichTextBox;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.CheckBox SaveSortResCheckBox;
        private System.Windows.Forms.ComboBox RegExComboBox;
    }
}