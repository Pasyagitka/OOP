
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
            this.FemaleEuropeanSize = new System.Windows.Forms.TextBox();
            this.FemaleBelarussianSize = new System.Windows.Forms.TextBox();
            this.FemaleAmericanSize = new System.Windows.Forms.TextBox();
            this.FemaleBritishSize = new System.Windows.Forms.TextBox();
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
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
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Name = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Name = "label8";
            // 
            // FemaleSizeSM
            // 
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
            // 
            // MaleSizeSM
            // 
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
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Name = "label3";
            // 
            // FemaleEuropeanSize
            // 
            resources.ApplyResources(this.FemaleEuropeanSize, "FemaleEuropeanSize");
            this.FemaleEuropeanSize.Name = "FemaleEuropeanSize";
            // 
            // FemaleBelarussianSize
            // 
            resources.ApplyResources(this.FemaleBelarussianSize, "FemaleBelarussianSize");
            this.FemaleBelarussianSize.Name = "FemaleBelarussianSize";
            // 
            // FemaleAmericanSize
            // 
            resources.ApplyResources(this.FemaleAmericanSize, "FemaleAmericanSize");
            this.FemaleAmericanSize.Name = "FemaleAmericanSize";
            // 
            // FemaleBritishSize
            // 
            resources.ApplyResources(this.FemaleBritishSize, "FemaleBritishSize");
            this.FemaleBritishSize.Name = "FemaleBritishSize";
            // 
            // Calculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.FemaleBritishSize);
            this.Controls.Add(this.FemaleAmericanSize);
            this.Controls.Add(this.FemaleBelarussianSize);
            this.Controls.Add(this.FemaleEuropeanSize);
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
        private System.Windows.Forms.TextBox FemaleEuropeanSize;
        private System.Windows.Forms.TextBox FemaleBelarussianSize;
        private System.Windows.Forms.TextBox FemaleAmericanSize;
        private System.Windows.Forms.TextBox FemaleBritishSize;
    }
}

