namespace pizzaForm
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_atlag = new System.Windows.Forms.TextBox();
            this.button_atlag = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_szamla = new System.Windows.Forms.CheckBox();
            this.comboBox_pizza = new System.Windows.Forms.ComboBox();
            this.groupBox_kezpentVagyKartya = new System.Windows.Forms.GroupBox();
            this.radioButton_kezpenz = new System.Windows.Forms.RadioButton();
            this.radioButton_kartya = new System.Windows.Forms.RadioButton();
            this.textBox_darab = new System.Windows.Forms.TextBox();
            this.pi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_rendeles = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox_kezpentVagyKartya.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza Rendelés";
            // 
            // textBox_atlag
            // 
            this.textBox_atlag.AcceptsReturn = true;
            this.textBox_atlag.Enabled = false;
            this.textBox_atlag.Location = new System.Drawing.Point(66, 83);
            this.textBox_atlag.Name = "textBox_atlag";
            this.textBox_atlag.Size = new System.Drawing.Size(142, 20);
            this.textBox_atlag.TabIndex = 1;
            // 
            // button_atlag
            // 
            this.button_atlag.Location = new System.Drawing.Point(66, 119);
            this.button_atlag.Name = "button_atlag";
            this.button_atlag.Size = new System.Drawing.Size(142, 23);
            this.button_atlag.TabIndex = 2;
            this.button_atlag.Text = "Átlag";
            this.button_atlag.UseVisualStyleBackColor = true;
            this.button_atlag.Click += new System.EventHandler(this.button_atlag_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(63, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pizza átlagára:";
            // 
            // checkBox_szamla
            // 
            this.checkBox_szamla.AutoSize = true;
            this.checkBox_szamla.Location = new System.Drawing.Point(244, 169);
            this.checkBox_szamla.Name = "checkBox_szamla";
            this.checkBox_szamla.Size = new System.Drawing.Size(87, 17);
            this.checkBox_szamla.TabIndex = 4;
            this.checkBox_szamla.Text = "Számlát kér?";
            this.checkBox_szamla.UseVisualStyleBackColor = true;
            // 
            // comboBox_pizza
            // 
            this.comboBox_pizza.FormattingEnabled = true;
            this.comboBox_pizza.Items.AddRange(new object[] {
            "Capricciosa",
            "Frutti di Mare",
            "Hawaii",
            "Vesuvio",
            "Sorrento"});
            this.comboBox_pizza.Location = new System.Drawing.Point(66, 165);
            this.comboBox_pizza.Name = "comboBox_pizza";
            this.comboBox_pizza.Size = new System.Drawing.Size(121, 21);
            this.comboBox_pizza.TabIndex = 5;
            // 
            // groupBox_kezpentVagyKartya
            // 
            this.groupBox_kezpentVagyKartya.Controls.Add(this.radioButton_kartya);
            this.groupBox_kezpentVagyKartya.Controls.Add(this.radioButton_kezpenz);
            this.groupBox_kezpentVagyKartya.Location = new System.Drawing.Point(244, 63);
            this.groupBox_kezpentVagyKartya.Name = "groupBox_kezpentVagyKartya";
            this.groupBox_kezpentVagyKartya.Size = new System.Drawing.Size(200, 100);
            this.groupBox_kezpentVagyKartya.TabIndex = 6;
            this.groupBox_kezpentVagyKartya.TabStop = false;
            this.groupBox_kezpentVagyKartya.Text = "groupBox1";
            // 
            // radioButton_kezpenz
            // 
            this.radioButton_kezpenz.AutoSize = true;
            this.radioButton_kezpenz.Location = new System.Drawing.Point(7, 22);
            this.radioButton_kezpenz.Name = "radioButton_kezpenz";
            this.radioButton_kezpenz.Size = new System.Drawing.Size(65, 17);
            this.radioButton_kezpenz.TabIndex = 0;
            this.radioButton_kezpenz.TabStop = true;
            this.radioButton_kezpenz.Text = "kézpénz";
            this.radioButton_kezpenz.UseVisualStyleBackColor = true;
            // 
            // radioButton_kartya
            // 
            this.radioButton_kartya.AutoSize = true;
            this.radioButton_kartya.Location = new System.Drawing.Point(7, 56);
            this.radioButton_kartya.Name = "radioButton_kartya";
            this.radioButton_kartya.Size = new System.Drawing.Size(54, 17);
            this.radioButton_kartya.TabIndex = 1;
            this.radioButton_kartya.TabStop = true;
            this.radioButton_kartya.Text = "kártya";
            this.radioButton_kartya.UseVisualStyleBackColor = true;
            // 
            // textBox_darab
            // 
            this.textBox_darab.Location = new System.Drawing.Point(66, 209);
            this.textBox_darab.Name = "textBox_darab";
            this.textBox_darab.Size = new System.Drawing.Size(28, 20);
            this.textBox_darab.TabIndex = 7;
            this.textBox_darab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_darab_KeyPress);
            // 
            // pi
            // 
            this.pi.AutoSize = true;
            this.pi.Location = new System.Drawing.Point(66, 149);
            this.pi.Name = "pi";
            this.pi.Size = new System.Drawing.Size(118, 13);
            this.pi.TabIndex = 8;
            this.pi.Text = "Milyen pizzat szeretnél?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "hány darabot szeretnél?";
            // 
            // button_rendeles
            // 
            this.button_rendeles.Location = new System.Drawing.Point(104, 238);
            this.button_rendeles.Name = "button_rendeles";
            this.button_rendeles.Size = new System.Drawing.Size(258, 35);
            this.button_rendeles.TabIndex = 10;
            this.button_rendeles.Text = "Rendelés!";
            this.button_rendeles.UseVisualStyleBackColor = true;
            this.button_rendeles.Click += new System.EventHandler(this.button_rendeles_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(478, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(169, 147);
            this.listBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_rendeles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pi);
            this.Controls.Add(this.textBox_darab);
            this.Controls.Add(this.groupBox_kezpentVagyKartya);
            this.Controls.Add(this.comboBox_pizza);
            this.Controls.Add(this.checkBox_szamla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_atlag);
            this.Controls.Add(this.textBox_atlag);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_kezpentVagyKartya.ResumeLayout(false);
            this.groupBox_kezpentVagyKartya.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_atlag;
        private System.Windows.Forms.Button button_atlag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_szamla;
        private System.Windows.Forms.ComboBox comboBox_pizza;
        private System.Windows.Forms.GroupBox groupBox_kezpentVagyKartya;
        private System.Windows.Forms.RadioButton radioButton_kartya;
        private System.Windows.Forms.RadioButton radioButton_kezpenz;
        private System.Windows.Forms.TextBox textBox_darab;
        private System.Windows.Forms.Label pi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_rendeles;
        private System.Windows.Forms.ListBox listBox1;
    }
}

