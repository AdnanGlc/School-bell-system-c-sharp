namespace Skolsko_Zvono
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Vrijeme_label = new System.Windows.Forms.Label();
            this.Cas_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Smjena_comboBox = new System.Windows.Forms.ComboBox();
            this.PrvaSmjena_TimePicker = new System.Windows.Forms.DateTimePicker();
            this.DrugaSmjena_TimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SljedeceZvono_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(199, 228);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(213, 308);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(419, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(221, 419);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Podesite dužinu trajanja časa:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Vrijeme_label
            // 
            this.Vrijeme_label.AutoSize = true;
            this.Vrijeme_label.Location = new System.Drawing.Point(594, 9);
            this.Vrijeme_label.Name = "Vrijeme_label";
            this.Vrijeme_label.Size = new System.Drawing.Size(46, 17);
            this.Vrijeme_label.TabIndex = 7;
            this.Vrijeme_label.Text = "label2";
            // 
            // Cas_comboBox
            // 
            this.Cas_comboBox.FormattingEnabled = true;
            this.Cas_comboBox.Items.AddRange(new object[] {
            "Svi časovi",
            "Prvi čas",
            "Drugi čas",
            "Treći čas",
            "Četvrti čas",
            "Peti čas",
            "Šesti čas",
            "Sedmi čas"});
            this.Cas_comboBox.Location = new System.Drawing.Point(16, 376);
            this.Cas_comboBox.Name = "Cas_comboBox";
            this.Cas_comboBox.Size = new System.Drawing.Size(121, 24);
            this.Cas_comboBox.TabIndex = 8;
            this.Cas_comboBox.SelectedIndexChanged += new System.EventHandler(this.Cas_comboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Početak prve smjene:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Početak druge smjene:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Trajanja malog odmora:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Trajanja velikog odmora:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(283, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "Ažuriraj raspored zvonjenja";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Smjena_comboBox
            // 
            this.Smjena_comboBox.FormattingEnabled = true;
            this.Smjena_comboBox.Items.AddRange(new object[] {
            "Prva Smjena",
            "Druga smjena"});
            this.Smjena_comboBox.Location = new System.Drawing.Point(16, 345);
            this.Smjena_comboBox.Name = "Smjena_comboBox";
            this.Smjena_comboBox.Size = new System.Drawing.Size(121, 24);
            this.Smjena_comboBox.TabIndex = 15;
            this.Smjena_comboBox.SelectedIndexChanged += new System.EventHandler(this.Smjena_comboBox_SelectedIndexChanged);
            // 
            // PrvaSmjena_TimePicker
            // 
            this.PrvaSmjena_TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.PrvaSmjena_TimePicker.Location = new System.Drawing.Point(199, 85);
            this.PrvaSmjena_TimePicker.Name = "PrvaSmjena_TimePicker";
            this.PrvaSmjena_TimePicker.ShowUpDown = true;
            this.PrvaSmjena_TimePicker.Size = new System.Drawing.Size(114, 22);
            this.PrvaSmjena_TimePicker.TabIndex = 16;
            // 
            // DrugaSmjena_TimePicker
            // 
            this.DrugaSmjena_TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DrugaSmjena_TimePicker.Location = new System.Drawing.Point(199, 135);
            this.DrugaSmjena_TimePicker.Name = "DrugaSmjena_TimePicker";
            this.DrugaSmjena_TimePicker.ShowUpDown = true;
            this.DrugaSmjena_TimePicker.Size = new System.Drawing.Size(114, 22);
            this.DrugaSmjena_TimePicker.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 35);
            this.button1.TabIndex = 18;
            this.button1.Text = "Sačuvaj promjene";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 426);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.TabIndex = 19;
            this.button3.Text = "Sačuvaj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SljedeceZvono_label
            // 
            this.SljedeceZvono_label.AutoSize = true;
            this.SljedeceZvono_label.Location = new System.Drawing.Point(647, 443);
            this.SljedeceZvono_label.Name = "SljedeceZvono_label";
            this.SljedeceZvono_label.Size = new System.Drawing.Size(46, 17);
            this.SljedeceZvono_label.TabIndex = 20;
            this.SljedeceZvono_label.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 559);
            this.Controls.Add(this.SljedeceZvono_label);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DrugaSmjena_TimePicker);
            this.Controls.Add(this.PrvaSmjena_TimePicker);
            this.Controls.Add(this.Smjena_comboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cas_comboBox);
            this.Controls.Add(this.Vrijeme_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Školsko Zvono";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Vrijeme_label;
        private System.Windows.Forms.ComboBox Cas_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox Smjena_comboBox;
        private System.Windows.Forms.DateTimePicker PrvaSmjena_TimePicker;
        private System.Windows.Forms.DateTimePicker DrugaSmjena_TimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label SljedeceZvono_label;
    }
}

