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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_atlag = new System.Windows.Forms.TextBox();
            this.button_atlag = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_szamla = new System.Windows.Forms.CheckBox();
            this.comboBox_pizza = new System.Windows.Forms.ComboBox();
            this.groupBox_kezpentVagyKartya = new System.Windows.Forms.GroupBox();
            this.radioButton_kartya = new System.Windows.Forms.RadioButton();
            this.radioButton_kezpenz = new System.Windows.Forms.RadioButton();
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
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza Rendelés";
            // 
            // textBox_atlag
            // 
            this.textBox_atlag.AcceptsReturn = true;
            this.textBox_atlag.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox_atlag.Enabled = false;
            this.textBox_atlag.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_atlag.Location = new System.Drawing.Point(228, 110);
            this.textBox_atlag.Name = "textBox_atlag";
            this.textBox_atlag.Size = new System.Drawing.Size(142, 23);
            this.textBox_atlag.TabIndex = 1;
            // 
            // button_atlag
            // 
            this.button_atlag.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_atlag.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_atlag.Location = new System.Drawing.Point(228, 137);
            this.button_atlag.Name = "button_atlag";
            this.button_atlag.Size = new System.Drawing.Size(142, 23);
            this.button_atlag.TabIndex = 2;
            this.button_atlag.Text = "Átlag";
            this.button_atlag.UseVisualStyleBackColor = false;
            this.button_atlag.Click += new System.EventHandler(this.button_atlag_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pizza átlagára:";
            // 
            // checkBox_szamla
            // 
            this.checkBox_szamla.AutoSize = true;
            this.checkBox_szamla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox_szamla.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_szamla.Location = new System.Drawing.Point(228, 267);
            this.checkBox_szamla.Name = "checkBox_szamla";
            this.checkBox_szamla.Size = new System.Drawing.Size(110, 19);
            this.checkBox_szamla.TabIndex = 4;
            this.checkBox_szamla.Text = "Számlát kér?";
            this.checkBox_szamla.UseVisualStyleBackColor = false;
            // 
            // comboBox_pizza
            // 
            this.comboBox_pizza.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBox_pizza.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_pizza.FormattingEnabled = true;
            this.comboBox_pizza.Items.AddRange(new object[] {
            "Capricciosa",
            "Frutti di Mare",
            "Hawaii",
            "Vesuvio",
            "Sorrento"});
            this.comboBox_pizza.Location = new System.Drawing.Point(231, 193);
            this.comboBox_pizza.Name = "comboBox_pizza";
            this.comboBox_pizza.Size = new System.Drawing.Size(121, 23);
            this.comboBox_pizza.TabIndex = 5;
            // 
            // groupBox_kezpentVagyKartya
            // 
            this.groupBox_kezpentVagyKartya.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_kezpentVagyKartya.Controls.Add(this.radioButton_kartya);
            this.groupBox_kezpentVagyKartya.Controls.Add(this.radioButton_kezpenz);
            this.groupBox_kezpentVagyKartya.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_kezpentVagyKartya.Location = new System.Drawing.Point(434, 90);
            this.groupBox_kezpentVagyKartya.Name = "groupBox_kezpentVagyKartya";
            this.groupBox_kezpentVagyKartya.Size = new System.Drawing.Size(144, 100);
            this.groupBox_kezpentVagyKartya.TabIndex = 6;
            this.groupBox_kezpentVagyKartya.TabStop = false;
            // 
            // radioButton_kartya
            // 
            this.radioButton_kartya.AutoSize = true;
            this.radioButton_kartya.Checked = true;
            this.radioButton_kartya.Location = new System.Drawing.Point(7, 60);
            this.radioButton_kartya.Name = "radioButton_kartya";
            this.radioButton_kartya.Size = new System.Drawing.Size(66, 19);
            this.radioButton_kartya.TabIndex = 1;
            this.radioButton_kartya.TabStop = true;
            this.radioButton_kartya.Text = "kártya";
            this.radioButton_kartya.UseVisualStyleBackColor = true;
            // 
            // radioButton_kezpenz
            // 
            this.radioButton_kezpenz.AutoSize = true;
            this.radioButton_kezpenz.Location = new System.Drawing.Point(7, 22);
            this.radioButton_kezpenz.Name = "radioButton_kezpenz";
            this.radioButton_kezpenz.Size = new System.Drawing.Size(78, 19);
            this.radioButton_kezpenz.TabIndex = 0;
            this.radioButton_kezpenz.Text = "kézpénz";
            this.radioButton_kezpenz.UseVisualStyleBackColor = true;
            // 
            // textBox_darab
            // 
            this.textBox_darab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox_darab.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_darab.Location = new System.Drawing.Point(231, 238);
            this.textBox_darab.Name = "textBox_darab";
            this.textBox_darab.Size = new System.Drawing.Size(28, 23);
            this.textBox_darab.TabIndex = 7;
            this.textBox_darab.Text = "1";
            this.textBox_darab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_darab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_darab_KeyPress);
            // 
            // pi
            // 
            this.pi.AutoSize = true;
            this.pi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pi.Location = new System.Drawing.Point(231, 177);
            this.pi.Name = "pi";
            this.pi.Size = new System.Drawing.Size(162, 15);
            this.pi.TabIndex = 8;
            this.pi.Text = "Milyen pizzat szeretnél?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "hány darabot szeretnél?";
            // 
            // button_rendeles
            // 
            this.button_rendeles.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_rendeles.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rendeles.Location = new System.Drawing.Point(249, 348);
            this.button_rendeles.Name = "button_rendeles";
            this.button_rendeles.Size = new System.Drawing.Size(258, 35);
            this.button_rendeles.TabIndex = 10;
            this.button_rendeles.Text = "Rendelés!";
            this.button_rendeles.UseVisualStyleBackColor = false;
            this.button_rendeles.Click += new System.EventHandler(this.button_rendeles_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(409, 193);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(169, 139);
            this.listBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
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

