
namespace PracaDyplomowa_MichalMoric
{
    partial class CezarForm
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
            this.InputMessageBox = new System.Windows.Forms.TextBox();
            this.OffsetBox = new System.Windows.Forms.ComboBox();
            this.Pre = new System.Windows.Forms.Label();
            this.ProccesGroup = new System.Windows.Forms.GroupBox();
            this.MessageOutputLabel = new System.Windows.Forms.TextBox();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EncryptBtn = new System.Windows.Forms.Button();
            this.StepByStepEncryptBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DecryptBtn = new System.Windows.Forms.Button();
            this.StepByStepDecryptBtn = new System.Windows.Forms.Button();
            this.NextStepBtn = new System.Windows.Forms.Button();
            this.ProccesGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wiadomość:";
            // 
            // InputMessageBox
            // 
            this.InputMessageBox.Location = new System.Drawing.Point(134, 44);
            this.InputMessageBox.Name = "InputMessageBox";
            this.InputMessageBox.Size = new System.Drawing.Size(202, 20);
            this.InputMessageBox.TabIndex = 1;
            // 
            // OffsetBox
            // 
            this.OffsetBox.FormattingEnabled = true;
            this.OffsetBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26"});
            this.OffsetBox.Location = new System.Drawing.Point(519, 43);
            this.OffsetBox.Name = "OffsetBox";
            this.OffsetBox.Size = new System.Drawing.Size(121, 21);
            this.OffsetBox.TabIndex = 2;
            // 
            // Pre
            // 
            this.Pre.AutoSize = true;
            this.Pre.Location = new System.Drawing.Point(432, 46);
            this.Pre.Name = "Pre";
            this.Pre.Size = new System.Drawing.Size(67, 13);
            this.Pre.TabIndex = 3;
            this.Pre.Text = "Przesunięcie";
            // 
            // ProccesGroup
            // 
            this.ProccesGroup.Controls.Add(this.MessageOutputLabel);
            this.ProccesGroup.Controls.Add(this.InstructionLabel);
            this.ProccesGroup.Controls.Add(this.label3);
            this.ProccesGroup.Controls.Add(this.label2);
            this.ProccesGroup.Location = new System.Drawing.Point(121, 112);
            this.ProccesGroup.Name = "ProccesGroup";
            this.ProccesGroup.Size = new System.Drawing.Size(538, 179);
            this.ProccesGroup.TabIndex = 4;
            this.ProccesGroup.TabStop = false;
            this.ProccesGroup.Text = "Postęp";
            // 
            // MessageOutputLabel
            // 
            this.MessageOutputLabel.Location = new System.Drawing.Point(152, 117);
            this.MessageOutputLabel.Name = "MessageOutputLabel";
            this.MessageOutputLabel.Size = new System.Drawing.Size(100, 20);
            this.MessageOutputLabel.TabIndex = 4;
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Location = new System.Drawing.Point(149, 37);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(16, 13);
            this.InstructionLabel.TabIndex = 3;
            this.InstructionLabel.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Instrukcja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Wiadomość:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EncryptBtn);
            this.groupBox1.Controls.Add(this.StepByStepEncryptBtn);
            this.groupBox1.Location = new System.Drawing.Point(65, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szyfrowanie";
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.Location = new System.Drawing.Point(138, 39);
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Size = new System.Drawing.Size(75, 23);
            this.EncryptBtn.TabIndex = 1;
            this.EncryptBtn.Text = "Na Raz";
            this.EncryptBtn.UseVisualStyleBackColor = true;
            this.EncryptBtn.Click += new System.EventHandler(this.EncryptBtn_Click);
            // 
            // StepByStepEncryptBtn
            // 
            this.StepByStepEncryptBtn.Location = new System.Drawing.Point(17, 39);
            this.StepByStepEncryptBtn.Name = "StepByStepEncryptBtn";
            this.StepByStepEncryptBtn.Size = new System.Drawing.Size(94, 23);
            this.StepByStepEncryptBtn.TabIndex = 0;
            this.StepByStepEncryptBtn.Text = "Krok po Kroku";
            this.StepByStepEncryptBtn.UseVisualStyleBackColor = true;
            this.StepByStepEncryptBtn.Click += new System.EventHandler(this.StepByStepEncryptBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DecryptBtn);
            this.groupBox2.Controls.Add(this.StepByStepDecryptBtn);
            this.groupBox2.Location = new System.Drawing.Point(364, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deszyfrowanie";
            // 
            // DecryptBtn
            // 
            this.DecryptBtn.Location = new System.Drawing.Point(155, 39);
            this.DecryptBtn.Name = "DecryptBtn";
            this.DecryptBtn.Size = new System.Drawing.Size(75, 23);
            this.DecryptBtn.TabIndex = 1;
            this.DecryptBtn.Text = "Na Raz";
            this.DecryptBtn.UseVisualStyleBackColor = true;
            this.DecryptBtn.Click += new System.EventHandler(this.DecryptBtn_Click);
            // 
            // StepByStepDecryptBtn
            // 
            this.StepByStepDecryptBtn.Location = new System.Drawing.Point(20, 39);
            this.StepByStepDecryptBtn.Name = "StepByStepDecryptBtn";
            this.StepByStepDecryptBtn.Size = new System.Drawing.Size(92, 23);
            this.StepByStepDecryptBtn.TabIndex = 0;
            this.StepByStepDecryptBtn.Text = "Krok po Kroku";
            this.StepByStepDecryptBtn.UseVisualStyleBackColor = true;
            this.StepByStepDecryptBtn.Click += new System.EventHandler(this.StepByStepDecryptBtn_Click);
            // 
            // NextStepBtn
            // 
            this.NextStepBtn.Enabled = false;
            this.NextStepBtn.Location = new System.Drawing.Point(667, 379);
            this.NextStepBtn.Name = "NextStepBtn";
            this.NextStepBtn.Size = new System.Drawing.Size(75, 35);
            this.NextStepBtn.TabIndex = 7;
            this.NextStepBtn.Text = "Następny Krok";
            this.NextStepBtn.UseVisualStyleBackColor = true;
            this.NextStepBtn.Click += new System.EventHandler(this.NextStepBtn_Click);
            // 
            // CezarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextStepBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ProccesGroup);
            this.Controls.Add(this.Pre);
            this.Controls.Add(this.OffsetBox);
            this.Controls.Add(this.InputMessageBox);
            this.Controls.Add(this.label1);
            this.Name = "CezarForm";
            this.Text = "CezarForm";
            this.ProccesGroup.ResumeLayout(false);
            this.ProccesGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputMessageBox;
        private System.Windows.Forms.ComboBox OffsetBox;
        private System.Windows.Forms.Label Pre;
        private System.Windows.Forms.GroupBox ProccesGroup;
        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button EncryptBtn;
        private System.Windows.Forms.Button StepByStepEncryptBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DecryptBtn;
        private System.Windows.Forms.Button StepByStepDecryptBtn;
        private System.Windows.Forms.Button NextStepBtn;
        private System.Windows.Forms.TextBox MessageOutputLabel;
    }
}