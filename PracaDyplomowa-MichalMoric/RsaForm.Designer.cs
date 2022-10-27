
namespace PracaDyplomowa_MichalMoric
{
    partial class RsaForm
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
            this.PublicKeyBox = new System.Windows.Forms.TextBox();
            this.PrivateKeyBox = new System.Windows.Forms.TextBox();
            this.NBox = new System.Windows.Forms.TextBox();
            this.KeyGenBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Encrypt_Btn = new System.Windows.Forms.Button();
            this.Decrypt_Btn = new System.Windows.Forms.Button();
            this.PBox = new System.Windows.Forms.TextBox();
            this.QBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RandomButton = new System.Windows.Forms.RadioButton();
            this.ChosenButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumberButton = new System.Windows.Forms.RadioButton();
            this.ASCIIButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PublicKeyBox
            // 
            this.PublicKeyBox.Location = new System.Drawing.Point(103, 250);
            this.PublicKeyBox.Name = "PublicKeyBox";
            this.PublicKeyBox.Size = new System.Drawing.Size(200, 20);
            this.PublicKeyBox.TabIndex = 0;
            // 
            // PrivateKeyBox
            // 
            this.PrivateKeyBox.Location = new System.Drawing.Point(103, 292);
            this.PrivateKeyBox.Name = "PrivateKeyBox";
            this.PrivateKeyBox.Size = new System.Drawing.Size(200, 20);
            this.PrivateKeyBox.TabIndex = 1;
            // 
            // NBox
            // 
            this.NBox.Location = new System.Drawing.Point(103, 208);
            this.NBox.Name = "NBox";
            this.NBox.Size = new System.Drawing.Size(200, 20);
            this.NBox.TabIndex = 2;
            // 
            // KeyGenBtn
            // 
            this.KeyGenBtn.Location = new System.Drawing.Point(29, 160);
            this.KeyGenBtn.Name = "KeyGenBtn";
            this.KeyGenBtn.Size = new System.Drawing.Size(200, 23);
            this.KeyGenBtn.TabIndex = 3;
            this.KeyGenBtn.Text = "Wygeneruj klucze";
            this.KeyGenBtn.UseVisualStyleBackColor = true;
            this.KeyGenBtn.Click += new System.EventHandler(this.KeyGenBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "N (Oba klucze):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "E (Publiczny Klucz):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "D (Prywany Klucz):";
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(176, 80);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(169, 20);
            this.InputBox.TabIndex = 7;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(68, 80);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(66, 13);
            this.Label.TabIndex = 8;
            this.Label.Text = "Wiadomosc:";
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(176, 133);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(169, 20);
            this.OutputBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Output:";
            // 
            // Encrypt_Btn
            // 
            this.Encrypt_Btn.Location = new System.Drawing.Point(71, 366);
            this.Encrypt_Btn.Name = "Encrypt_Btn";
            this.Encrypt_Btn.Size = new System.Drawing.Size(75, 23);
            this.Encrypt_Btn.TabIndex = 11;
            this.Encrypt_Btn.Text = "Zakoduj";
            this.Encrypt_Btn.UseVisualStyleBackColor = true;
            this.Encrypt_Btn.Click += new System.EventHandler(this.Encrypt_Btn_Click);
            // 
            // Decrypt_Btn
            // 
            this.Decrypt_Btn.Location = new System.Drawing.Point(199, 366);
            this.Decrypt_Btn.Name = "Decrypt_Btn";
            this.Decrypt_Btn.Size = new System.Drawing.Size(75, 23);
            this.Decrypt_Btn.TabIndex = 12;
            this.Decrypt_Btn.Text = "Odkoduj";
            this.Decrypt_Btn.UseVisualStyleBackColor = true;
            this.Decrypt_Btn.Click += new System.EventHandler(this.Decrypt_Btn_Click);
            // 
            // PBox
            // 
            this.PBox.Enabled = false;
            this.PBox.Location = new System.Drawing.Point(83, 51);
            this.PBox.Name = "PBox";
            this.PBox.Size = new System.Drawing.Size(100, 20);
            this.PBox.TabIndex = 13;
            // 
            // QBox
            // 
            this.QBox.Enabled = false;
            this.QBox.Location = new System.Drawing.Point(227, 51);
            this.QBox.Name = "QBox";
            this.QBox.Size = new System.Drawing.Size(100, 20);
            this.QBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "P:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Q:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChosenButton);
            this.groupBox1.Controls.Add(this.RandomButton);
            this.groupBox1.Controls.Add(this.PBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PublicKeyBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.PrivateKeyBox);
            this.groupBox1.Controls.Add(this.QBox);
            this.groupBox1.Controls.Add(this.NBox);
            this.groupBox1.Controls.Add(this.KeyGenBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(412, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 380);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klucze";
            // 
            // RandomButton
            // 
            this.RandomButton.AutoSize = true;
            this.RandomButton.Location = new System.Drawing.Point(63, 89);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(140, 17);
            this.RandomButton.TabIndex = 17;
            this.RandomButton.TabStop = true;
            this.RandomButton.Text = "Losowe Liczby Pierwsze";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.CheckedChanged += new System.EventHandler(this.RandomButton_CheckedChanged);
            // 
            // ChosenButton
            // 
            this.ChosenButton.AutoSize = true;
            this.ChosenButton.Location = new System.Drawing.Point(63, 114);
            this.ChosenButton.Name = "ChosenButton";
            this.ChosenButton.Size = new System.Drawing.Size(146, 17);
            this.ChosenButton.TabIndex = 18;
            this.ChosenButton.TabStop = true;
            this.ChosenButton.Text = "Wybrane Liczby Pierwsze";
            this.ChosenButton.UseVisualStyleBackColor = true;
            this.ChosenButton.CheckedChanged += new System.EventHandler(this.ChosenButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ASCIIButton);
            this.groupBox2.Controls.Add(this.NumberButton);
            this.groupBox2.Location = new System.Drawing.Point(71, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 100);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tryb szyfrowania";
            // 
            // NumberButton
            // 
            this.NumberButton.AutoSize = true;
            this.NumberButton.Location = new System.Drawing.Point(32, 29);
            this.NumberButton.Name = "NumberButton";
            this.NumberButton.Size = new System.Drawing.Size(55, 17);
            this.NumberButton.TabIndex = 0;
            this.NumberButton.TabStop = true;
            this.NumberButton.Text = "Liczby";
            this.NumberButton.UseVisualStyleBackColor = true;
            // 
            // ASCIIButton
            // 
            this.ASCIIButton.AutoSize = true;
            this.ASCIIButton.Location = new System.Drawing.Point(35, 66);
            this.ASCIIButton.Name = "ASCIIButton";
            this.ASCIIButton.Size = new System.Drawing.Size(52, 17);
            this.ASCIIButton.TabIndex = 1;
            this.ASCIIButton.TabStop = true;
            this.ASCIIButton.Text = "ASCII";
            this.ASCIIButton.UseVisualStyleBackColor = true;
            // 
            // RsaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 652);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Decrypt_Btn);
            this.Controls.Add(this.Encrypt_Btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.InputBox);
            this.Name = "RsaForm";
            this.Text = "RsaForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PublicKeyBox;
        private System.Windows.Forms.TextBox PrivateKeyBox;
        private System.Windows.Forms.TextBox NBox;
        private System.Windows.Forms.Button KeyGenBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Encrypt_Btn;
        private System.Windows.Forms.Button Decrypt_Btn;
        private System.Windows.Forms.TextBox PBox;
        private System.Windows.Forms.TextBox QBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ChosenButton;
        private System.Windows.Forms.RadioButton RandomButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton ASCIIButton;
        private System.Windows.Forms.RadioButton NumberButton;
    }
}