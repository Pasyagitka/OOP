
namespace _01.Создание_приложений_на_основе_Windows_Forms
{
    partial class Calculator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FemaleSizeSM = new System.Windows.Forms.ComboBox();
            this.MaleSizeSM = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.EuropeanSizeSelect = new System.Windows.Forms.ComboBox();
            this.BelarussianSizeSelect = new System.Windows.Forms.ComboBox();
            this.AmericanSizeSelect = new System.Windows.Forms.ComboBox();
            this.BritishSizeSelect = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Name = "label4";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Name = "label2";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Name = "label8";
            // 
            // FemaleSizeSM
            // 
            this.FemaleSizeSM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FemaleSizeSM.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FemaleSizeSM.FormattingEnabled = true;
            this.FemaleSizeSM.Items.AddRange(new object[] {
            resources.GetString("FemaleSizeSM.Items"),
            resources.GetString("FemaleSizeSM.Items1"),
            resources.GetString("FemaleSizeSM.Items2"),
            resources.GetString("FemaleSizeSM.Items3"),
            resources.GetString("FemaleSizeSM.Items4"),
            resources.GetString("FemaleSizeSM.Items5"),
            resources.GetString("FemaleSizeSM.Items6"),
            resources.GetString("FemaleSizeSM.Items7"),
            resources.GetString("FemaleSizeSM.Items8"),
            resources.GetString("FemaleSizeSM.Items9")});
            resources.ApplyResources(this.FemaleSizeSM, "FemaleSizeSM");
            this.FemaleSizeSM.Name = "FemaleSizeSM";
            this.FemaleSizeSM.SelectedIndexChanged += new System.EventHandler(this.FemaleSizeSM_SelectedIndexChanged);
            this.FemaleSizeSM.TabIndexChanged += new System.EventHandler(this.FemaleSizeSM_TabIndexChanged);
            // 
            // MaleSizeSM
            // 
            this.MaleSizeSM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaleSizeSM.FormattingEnabled = true;
            this.MaleSizeSM.Items.AddRange(new object[] {
            resources.GetString("MaleSizeSM.Items"),
            resources.GetString("MaleSizeSM.Items1"),
            resources.GetString("MaleSizeSM.Items2"),
            resources.GetString("MaleSizeSM.Items3"),
            resources.GetString("MaleSizeSM.Items4"),
            resources.GetString("MaleSizeSM.Items5"),
            resources.GetString("MaleSizeSM.Items6"),
            resources.GetString("MaleSizeSM.Items7"),
            resources.GetString("MaleSizeSM.Items8"),
            resources.GetString("MaleSizeSM.Items9"),
            resources.GetString("MaleSizeSM.Items10"),
            resources.GetString("MaleSizeSM.Items11"),
            resources.GetString("MaleSizeSM.Items12")});
            resources.ApplyResources(this.MaleSizeSM, "MaleSizeSM");
            this.MaleSizeSM.Name = "MaleSizeSM";
            this.MaleSizeSM.SelectedIndexChanged += new System.EventHandler(this.MaleSizeSM_SelectedIndexChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Name = "label3";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EuropeanSizeSelect
            // 
            this.EuropeanSizeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EuropeanSizeSelect.FormattingEnabled = true;
            this.EuropeanSizeSelect.Items.AddRange(new object[] {
            resources.GetString("EuropeanSizeSelect.Items"),
            resources.GetString("EuropeanSizeSelect.Items1"),
            resources.GetString("EuropeanSizeSelect.Items2"),
            resources.GetString("EuropeanSizeSelect.Items3"),
            resources.GetString("EuropeanSizeSelect.Items4"),
            resources.GetString("EuropeanSizeSelect.Items5"),
            resources.GetString("EuropeanSizeSelect.Items6"),
            resources.GetString("EuropeanSizeSelect.Items7"),
            resources.GetString("EuropeanSizeSelect.Items8"),
            resources.GetString("EuropeanSizeSelect.Items9"),
            resources.GetString("EuropeanSizeSelect.Items10"),
            resources.GetString("EuropeanSizeSelect.Items11"),
            resources.GetString("EuropeanSizeSelect.Items12"),
            resources.GetString("EuropeanSizeSelect.Items13"),
            resources.GetString("EuropeanSizeSelect.Items14"),
            resources.GetString("EuropeanSizeSelect.Items15"),
            resources.GetString("EuropeanSizeSelect.Items16"),
            resources.GetString("EuropeanSizeSelect.Items17"),
            resources.GetString("EuropeanSizeSelect.Items18"),
            resources.GetString("EuropeanSizeSelect.Items19")});
            resources.ApplyResources(this.EuropeanSizeSelect, "EuropeanSizeSelect");
            this.EuropeanSizeSelect.Name = "EuropeanSizeSelect";
            this.EuropeanSizeSelect.SelectedIndexChanged += new System.EventHandler(this.EuropeanSizeSelect_SelectedIndexChanged);
            // 
            // BelarussianSizeSelect
            // 
            this.BelarussianSizeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BelarussianSizeSelect.FormattingEnabled = true;
            this.BelarussianSizeSelect.Items.AddRange(new object[] {
            resources.GetString("BelarussianSizeSelect.Items"),
            resources.GetString("BelarussianSizeSelect.Items1"),
            resources.GetString("BelarussianSizeSelect.Items2"),
            resources.GetString("BelarussianSizeSelect.Items3"),
            resources.GetString("BelarussianSizeSelect.Items4"),
            resources.GetString("BelarussianSizeSelect.Items5"),
            resources.GetString("BelarussianSizeSelect.Items6"),
            resources.GetString("BelarussianSizeSelect.Items7"),
            resources.GetString("BelarussianSizeSelect.Items8"),
            resources.GetString("BelarussianSizeSelect.Items9"),
            resources.GetString("BelarussianSizeSelect.Items10"),
            resources.GetString("BelarussianSizeSelect.Items11"),
            resources.GetString("BelarussianSizeSelect.Items12"),
            resources.GetString("BelarussianSizeSelect.Items13"),
            resources.GetString("BelarussianSizeSelect.Items14"),
            resources.GetString("BelarussianSizeSelect.Items15"),
            resources.GetString("BelarussianSizeSelect.Items16"),
            resources.GetString("BelarussianSizeSelect.Items17"),
            resources.GetString("BelarussianSizeSelect.Items18"),
            resources.GetString("BelarussianSizeSelect.Items19")});
            resources.ApplyResources(this.BelarussianSizeSelect, "BelarussianSizeSelect");
            this.BelarussianSizeSelect.Name = "BelarussianSizeSelect";
            this.BelarussianSizeSelect.SelectedIndexChanged += new System.EventHandler(this.BelarussianSizeSelect_SelectedIndexChanged);
            // 
            // AmericanSizeSelect
            // 
            this.AmericanSizeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AmericanSizeSelect.FormattingEnabled = true;
            this.AmericanSizeSelect.Items.AddRange(new object[] {
            resources.GetString("AmericanSizeSelect.Items"),
            resources.GetString("AmericanSizeSelect.Items1"),
            resources.GetString("AmericanSizeSelect.Items2"),
            resources.GetString("AmericanSizeSelect.Items3"),
            resources.GetString("AmericanSizeSelect.Items4"),
            resources.GetString("AmericanSizeSelect.Items5"),
            resources.GetString("AmericanSizeSelect.Items6"),
            resources.GetString("AmericanSizeSelect.Items7"),
            resources.GetString("AmericanSizeSelect.Items8"),
            resources.GetString("AmericanSizeSelect.Items9"),
            resources.GetString("AmericanSizeSelect.Items10"),
            resources.GetString("AmericanSizeSelect.Items11"),
            resources.GetString("AmericanSizeSelect.Items12"),
            resources.GetString("AmericanSizeSelect.Items13"),
            resources.GetString("AmericanSizeSelect.Items14"),
            resources.GetString("AmericanSizeSelect.Items15"),
            resources.GetString("AmericanSizeSelect.Items16"),
            resources.GetString("AmericanSizeSelect.Items17"),
            resources.GetString("AmericanSizeSelect.Items18"),
            resources.GetString("AmericanSizeSelect.Items19")});
            resources.ApplyResources(this.AmericanSizeSelect, "AmericanSizeSelect");
            this.AmericanSizeSelect.Name = "AmericanSizeSelect";
            this.AmericanSizeSelect.SelectedIndexChanged += new System.EventHandler(this.AmericanSizeSelect_SelectedIndexChanged);
            // 
            // BritishSizeSelect
            // 
            this.BritishSizeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BritishSizeSelect.FormattingEnabled = true;
            this.BritishSizeSelect.Items.AddRange(new object[] {
            resources.GetString("BritishSizeSelect.Items"),
            resources.GetString("BritishSizeSelect.Items1"),
            resources.GetString("BritishSizeSelect.Items2"),
            resources.GetString("BritishSizeSelect.Items3"),
            resources.GetString("BritishSizeSelect.Items4"),
            resources.GetString("BritishSizeSelect.Items5"),
            resources.GetString("BritishSizeSelect.Items6"),
            resources.GetString("BritishSizeSelect.Items7"),
            resources.GetString("BritishSizeSelect.Items8"),
            resources.GetString("BritishSizeSelect.Items9"),
            resources.GetString("BritishSizeSelect.Items10"),
            resources.GetString("BritishSizeSelect.Items11"),
            resources.GetString("BritishSizeSelect.Items12"),
            resources.GetString("BritishSizeSelect.Items13"),
            resources.GetString("BritishSizeSelect.Items14"),
            resources.GetString("BritishSizeSelect.Items15"),
            resources.GetString("BritishSizeSelect.Items16"),
            resources.GetString("BritishSizeSelect.Items17"),
            resources.GetString("BritishSizeSelect.Items18"),
            resources.GetString("BritishSizeSelect.Items19")});
            resources.ApplyResources(this.BritishSizeSelect, "BritishSizeSelect");
            this.BritishSizeSelect.Name = "BritishSizeSelect";
            this.BritishSizeSelect.SelectedIndexChanged += new System.EventHandler(this.BritishSizeSelect_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Calculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BritishSizeSelect);
            this.Controls.Add(this.AmericanSizeSelect);
            this.Controls.Add(this.BelarussianSizeSelect);
            this.Controls.Add(this.EuropeanSizeSelect);
            this.Controls.Add(this.MaleSizeSM);
            this.Controls.Add(this.FemaleSizeSM);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Calculator";
            this.Opacity = 0.98D;
            this.Load += new System.EventHandler(this.Calculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox FemaleSizeSM;
        private System.Windows.Forms.ComboBox MaleSizeSM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox EuropeanSizeSelect;
        private System.Windows.Forms.ComboBox BelarussianSizeSelect;
        private System.Windows.Forms.ComboBox AmericanSizeSelect;
        private System.Windows.Forms.ComboBox BritishSizeSelect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

