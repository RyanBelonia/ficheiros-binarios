namespace M8_EXrelembrar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnok = new Button();
            btnlimpar = new Button();
            cbox = new ComboBox();
            groupBox1 = new GroupBox();
            numup = new NumericUpDown();
            txtbox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numup).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnok
            // 
            btnok.Location = new Point(28, 193);
            btnok.Name = "btnok";
            btnok.Size = new Size(92, 43);
            btnok.TabIndex = 0;
            btnok.Text = "OK";
            btnok.UseVisualStyleBackColor = true;
            btnok.Click += btnok_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(201, 203);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(83, 33);
            btnlimpar.TabIndex = 1;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += button2_Click;
            // 
            // cbox
            // 
            cbox.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox.FormattingEnabled = true;
            cbox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19" });
            cbox.Location = new Point(87, 45);
            cbox.Name = "cbox";
            cbox.Size = new Size(58, 23);
            cbox.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numup);
            groupBox1.Controls.Add(txtbox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(430, 147);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "entrada de dados";
            // 
            // numup
            // 
            numup.Location = new Point(87, 81);
            numup.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numup.Name = "numup";
            numup.Size = new Size(60, 23);
            numup.TabIndex = 9;
            // 
            // txtbox
            // 
            txtbox.Location = new Point(87, 16);
            txtbox.Name = "txtbox";
            txtbox.Size = new Size(179, 23);
            txtbox.TabIndex = 8;
            txtbox.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 83);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 7;
            label3.Text = "Classificação";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 53);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 6;
            label2.Text = "módulo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 5;
            label1.Text = "Diciplinas";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(22, 242);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(430, 142);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Saida de dados";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 102);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 11;
            label7.Text = "Classificação  ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 69);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 8;
            label5.Text = "Módulo  ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 36);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 7;
            label4.Text = "Diciplina  ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnlimpar);
            Controls.Add(btnok);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numup).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnok;
        private Button btnlimpar;
        private ComboBox cbox;
        private GroupBox groupBox1;
        private NumericUpDown numup;
        private TextBox txtbox;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label7;
    }
}
