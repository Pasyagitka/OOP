
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
            this.RegExInputTextBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.RegexHeadingLabel = new System.Windows.Forms.Label();
            this.RegexSearchRichTextBox = new System.Windows.Forms.RichTextBox();
            this.headingLabel = new System.Windows.Forms.Label();
            this.SaveSortResCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // RegExInputTextBox
            // 
            this.RegExInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RegExInputTextBox.Location = new System.Drawing.Point(191, 80);
            this.RegExInputTextBox.Name = "RegExInputTextBox";
            this.RegExInputTextBox.Size = new System.Drawing.Size(221, 26);
            this.RegExInputTextBox.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(251, 387);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // RegexHeadingLabel
            // 
            this.RegexHeadingLabel.AutoSize = true;
            this.RegexHeadingLabel.BackColor = System.Drawing.Color.Black;
            this.RegexHeadingLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F);
            this.RegexHeadingLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.RegexHeadingLabel.Location = new System.Drawing.Point(173, 45);
            this.RegexHeadingLabel.Name = "RegexHeadingLabel";
            this.RegexHeadingLabel.Size = new System.Drawing.Size(251, 16);
            this.RegexHeadingLabel.TabIndex = 3;
            this.RegexHeadingLabel.Text = "   Введите регулярное  выражение      ";
            this.RegexHeadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegexSearchRichTextBox
            // 
            this.RegexSearchRichTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RegexSearchRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegexSearchRichTextBox.Location = new System.Drawing.Point(191, 132);
            this.RegexSearchRichTextBox.Name = "RegexSearchRichTextBox";
            this.RegexSearchRichTextBox.ReadOnly = true;
            this.RegexSearchRichTextBox.Size = new System.Drawing.Size(221, 239);
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
            this.SaveSortResCheckBox.Location = new System.Drawing.Point(332, 385);
            this.SaveSortResCheckBox.Name = "SaveSortResCheckBox";
            this.SaveSortResCheckBox.Size = new System.Drawing.Size(80, 25);
            this.SaveSortResCheckBox.TabIndex = 41;
            this.SaveSortResCheckBox.Text = "Сохранить";
            this.SaveSortResCheckBox.UseVisualStyleBackColor = false;
            // 
            // RegExSearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(424, 422);
            this.Controls.Add(this.SaveSortResCheckBox);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.RegexSearchRichTextBox);
            this.Controls.Add(this.RegexHeadingLabel);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.RegExInputTextBox);
            this.Name = "RegExSearchWindow";
            this.Text = "Поиск по регулярному выражению";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RegExInputTextBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label RegexHeadingLabel;
        private System.Windows.Forms.RichTextBox RegexSearchRichTextBox;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.CheckBox SaveSortResCheckBox;
    }
}