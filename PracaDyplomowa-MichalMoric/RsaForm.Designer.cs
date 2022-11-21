
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
            this.ChosenButton = new System.Windows.Forms.RadioButton();
            this.RandomButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ASCIIButton = new System.Windows.Forms.RadioButton();
            this.NumberButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.StepByStepEncryptBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.StepByStepDecryptBtn = new System.Windows.Forms.Button();
            this.NextStepBtn = new System.Windows.Forms.Button();
            this.InstructionLabel = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.InputBox.Location = new System.Drawing.Point(143, 21);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(169, 20);
            this.InputBox.TabIndex = 7;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(35, 21);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(66, 13);
            this.Label.TabIndex = 8;
            this.Label.Text = "Wiadomosc:";
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(143, 74);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(169, 20);
            this.OutputBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Output:";
            // 
            // Encrypt_Btn
            // 
            this.Encrypt_Btn.Location = new System.Drawing.Point(98, 29);
            this.Encrypt_Btn.Name = "Encrypt_Btn";
            this.Encrypt_Btn.Size = new System.Drawing.Size(75, 40);
            this.Encrypt_Btn.TabIndex = 11;
            this.Encrypt_Btn.Text = "Na raz";
            this.Encrypt_Btn.UseVisualStyleBackColor = true;
            this.Encrypt_Btn.Click += new System.EventHandler(this.Encrypt_Btn_Click);
            // 
            // Decrypt_Btn
            // 
            this.Decrypt_Btn.Location = new System.Drawing.Point(104, 29);
            this.Decrypt_Btn.Name = "Decrypt_Btn";
            this.Decrypt_Btn.Size = new System.Drawing.Size(75, 39);
            this.Decrypt_Btn.TabIndex = 12;
            this.Decrypt_Btn.Text = "Na raz";
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
            this.groupBox1.Location = new System.Drawing.Point(429, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 380);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klucze";
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
            // RandomButton
            // 
            this.RandomButton.AutoSize = true;
            this.RandomButton.Checked = true;
            this.RandomButton.Location = new System.Drawing.Point(63, 89);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(140, 17);
            this.RandomButton.TabIndex = 17;
            this.RandomButton.TabStop = true;
            this.RandomButton.Text = "Losowe Liczby Pierwsze";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.CheckedChanged += new System.EventHandler(this.RandomButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ASCIIButton);
            this.groupBox2.Controls.Add(this.NumberButton);
            this.groupBox2.Location = new System.Drawing.Point(27, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 100);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tryb szyfrowania";
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
            this.ASCIIButton.CheckedChanged += new System.EventHandler(this.ASCIIButton_CheckedChanged);
            // 
            // NumberButton
            // 
            this.NumberButton.AutoSize = true;
            this.NumberButton.Checked = true;
            this.NumberButton.Location = new System.Drawing.Point(32, 29);
            this.NumberButton.Name = "NumberButton";
            this.NumberButton.Size = new System.Drawing.Size(55, 17);
            this.NumberButton.TabIndex = 0;
            this.NumberButton.TabStop = true;
            this.NumberButton.Text = "Liczby";
            this.NumberButton.UseVisualStyleBackColor = true;
            this.NumberButton.CheckedChanged += new System.EventHandler(this.NumberButton_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.InstructionLabel);
            this.groupBox3.Location = new System.Drawing.Point(12, 393);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(755, 303);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Instrukcje";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.StepByStepEncryptBtn);
            this.groupBox4.Controls.Add(this.Encrypt_Btn);
            this.groupBox4.Location = new System.Drawing.Point(21, 219);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Szyfrowanie";
            // 
            // StepByStepEncryptBtn
            // 
            this.StepByStepEncryptBtn.Enabled = false;
            this.StepByStepEncryptBtn.Location = new System.Drawing.Point(17, 29);
            this.StepByStepEncryptBtn.Name = "StepByStepEncryptBtn";
            this.StepByStepEncryptBtn.Size = new System.Drawing.Size(75, 40);
            this.StepByStepEncryptBtn.TabIndex = 12;
            this.StepByStepEncryptBtn.Text = "Krok po Kroku";
            this.StepByStepEncryptBtn.UseVisualStyleBackColor = true;
            this.StepByStepEncryptBtn.Click += new System.EventHandler(this.StepByStepEncryptBtn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.StepByStepDecryptBtn);
            this.groupBox5.Controls.Add(this.Decrypt_Btn);
            this.groupBox5.Location = new System.Drawing.Point(223, 219);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Deszyfrowanie";
            // 
            // StepByStepDecryptBtn
            // 
            this.StepByStepDecryptBtn.Enabled = false;
            this.StepByStepDecryptBtn.Location = new System.Drawing.Point(23, 29);
            this.StepByStepDecryptBtn.Name = "StepByStepDecryptBtn";
            this.StepByStepDecryptBtn.Size = new System.Drawing.Size(75, 39);
            this.StepByStepDecryptBtn.TabIndex = 13;
            this.StepByStepDecryptBtn.Text = "Krok po Kroku";
            this.StepByStepDecryptBtn.UseVisualStyleBackColor = true;
            this.StepByStepDecryptBtn.Click += new System.EventHandler(this.StepByStepDecryptBtn_Click);
            // 
            // NextStepBtn
            // 
            this.NextStepBtn.Enabled = false;
            this.NextStepBtn.Location = new System.Drawing.Point(180, 325);
            this.NextStepBtn.Name = "NextStepBtn";
            this.NextStepBtn.Size = new System.Drawing.Size(75, 62);
            this.NextStepBtn.TabIndex = 22;
            this.NextStepBtn.Text = "Następny Krok";
            this.NextStepBtn.UseVisualStyleBackColor = true;
            this.NextStepBtn.Click += new System.EventHandler(this.NextStepBtn_Click);
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AcceptsReturn = true;
            this.InstructionLabel.Location = new System.Drawing.Point(9, 19);
            this.InstructionLabel.Multiline = true;
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InstructionLabel.Size = new System.Drawing.Size(711, 274);
            this.InstructionLabel.TabIndex = 2;
            // 
            // RsaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 717);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.NextStepBtn);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RsaForm";
            this.Text = "RsaForm";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.RsaForm_HelpButtonClicked);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button StepByStepEncryptBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button StepByStepDecryptBtn;
        private System.Windows.Forms.Button NextStepBtn;
        private System.Windows.Forms.TextBox InstructionLabel;
    }
}