
namespace PracaDyplomowa_MichalMoric
{
    partial class PolibiusForm
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
            this.Key_Grid = new System.Windows.Forms.DataGridView();
            this.AddCol_Btn = new System.Windows.Forms.Button();
            this.DelCol_Btn = new System.Windows.Forms.Button();
            this.AddRow_Btn = new System.Windows.Forms.Button();
            this.DelRow_Btn = new System.Windows.Forms.Button();
            this.Val_Btn = new System.Windows.Forms.Button();
            this.RelKey_Btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StepByStepEncryptBtn = new System.Windows.Forms.Button();
            this.EncryptBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DecryptBtn = new System.Windows.Forms.Button();
            this.StepByStepDecryptBtn = new System.Windows.Forms.Button();
            this.NextStepBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InputMessageBox = new System.Windows.Forms.TextBox();
            this.ProccesGroup = new System.Windows.Forms.GroupBox();
            this.MessageOutputLabel = new System.Windows.Forms.TextBox();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RowColRad = new System.Windows.Forms.RadioButton();
            this.ColRowRad = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Key_Grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.ProccesGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Key_Grid
            // 
            this.Key_Grid.AllowUserToAddRows = false;
            this.Key_Grid.AllowUserToResizeColumns = false;
            this.Key_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Key_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Key_Grid.Location = new System.Drawing.Point(32, 30);
            this.Key_Grid.Name = "Key_Grid";
            this.Key_Grid.Size = new System.Drawing.Size(550, 258);
            this.Key_Grid.TabIndex = 0;
            // 
            // AddCol_Btn
            // 
            this.AddCol_Btn.Location = new System.Drawing.Point(32, 306);
            this.AddCol_Btn.Name = "AddCol_Btn";
            this.AddCol_Btn.Size = new System.Drawing.Size(75, 42);
            this.AddCol_Btn.TabIndex = 1;
            this.AddCol_Btn.Text = "Dodaj Kolumne";
            this.AddCol_Btn.UseVisualStyleBackColor = true;
            this.AddCol_Btn.Click += new System.EventHandler(this.AddCol_Btn_Click);
            // 
            // DelCol_Btn
            // 
            this.DelCol_Btn.Location = new System.Drawing.Point(32, 371);
            this.DelCol_Btn.Name = "DelCol_Btn";
            this.DelCol_Btn.Size = new System.Drawing.Size(75, 41);
            this.DelCol_Btn.TabIndex = 2;
            this.DelCol_Btn.Text = "Usun Kolumne";
            this.DelCol_Btn.UseVisualStyleBackColor = true;
            this.DelCol_Btn.Click += new System.EventHandler(this.DelCol_Btn_Click);
            // 
            // AddRow_Btn
            // 
            this.AddRow_Btn.Location = new System.Drawing.Point(150, 306);
            this.AddRow_Btn.Name = "AddRow_Btn";
            this.AddRow_Btn.Size = new System.Drawing.Size(75, 42);
            this.AddRow_Btn.TabIndex = 3;
            this.AddRow_Btn.Text = "Dodaj Wiersz";
            this.AddRow_Btn.UseVisualStyleBackColor = true;
            this.AddRow_Btn.Click += new System.EventHandler(this.AddRow_Btn_Click);
            // 
            // DelRow_Btn
            // 
            this.DelRow_Btn.Location = new System.Drawing.Point(150, 371);
            this.DelRow_Btn.Name = "DelRow_Btn";
            this.DelRow_Btn.Size = new System.Drawing.Size(75, 41);
            this.DelRow_Btn.TabIndex = 4;
            this.DelRow_Btn.Text = "Usun Wiersz";
            this.DelRow_Btn.UseVisualStyleBackColor = true;
            this.DelRow_Btn.Click += new System.EventHandler(this.DelRow_Btn_Click);
            // 
            // Val_Btn
            // 
            this.Val_Btn.Location = new System.Drawing.Point(433, 306);
            this.Val_Btn.Name = "Val_Btn";
            this.Val_Btn.Size = new System.Drawing.Size(75, 42);
            this.Val_Btn.TabIndex = 5;
            this.Val_Btn.Text = "Załaduj Klucz";
            this.Val_Btn.UseVisualStyleBackColor = true;
            this.Val_Btn.Click += new System.EventHandler(this.Val_Btn_Click);
            // 
            // RelKey_Btn
            // 
            this.RelKey_Btn.Enabled = false;
            this.RelKey_Btn.Location = new System.Drawing.Point(433, 371);
            this.RelKey_Btn.Name = "RelKey_Btn";
            this.RelKey_Btn.Size = new System.Drawing.Size(75, 40);
            this.RelKey_Btn.TabIndex = 6;
            this.RelKey_Btn.Text = "Zwolnij Klucz";
            this.RelKey_Btn.UseVisualStyleBackColor = true;
            this.RelKey_Btn.Click += new System.EventHandler(this.RelKey_Btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ColRowRad);
            this.groupBox1.Controls.Add(this.RowColRad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Key_Grid);
            this.groupBox1.Controls.Add(this.RelKey_Btn);
            this.groupBox1.Controls.Add(this.AddCol_Btn);
            this.groupBox1.Controls.Add(this.Val_Btn);
            this.groupBox1.Controls.Add(this.DelCol_Btn);
            this.groupBox1.Controls.Add(this.DelRow_Btn);
            this.groupBox1.Controls.Add(this.AddRow_Btn);
            this.groupBox1.Location = new System.Drawing.Point(513, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 426);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klucz";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EncryptBtn);
            this.groupBox2.Controls.Add(this.StepByStepEncryptBtn);
            this.groupBox2.Location = new System.Drawing.Point(32, 348);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(109, 151);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Szyfrowanie";
            // 
            // StepByStepEncryptBtn
            // 
            this.StepByStepEncryptBtn.Enabled = false;
            this.StepByStepEncryptBtn.Location = new System.Drawing.Point(18, 35);
            this.StepByStepEncryptBtn.Name = "StepByStepEncryptBtn";
            this.StepByStepEncryptBtn.Size = new System.Drawing.Size(75, 40);
            this.StepByStepEncryptBtn.TabIndex = 0;
            this.StepByStepEncryptBtn.Text = "Krok Po Kroku";
            this.StepByStepEncryptBtn.UseVisualStyleBackColor = true;
            this.StepByStepEncryptBtn.Click += new System.EventHandler(this.StepByStepEncryptBtn_Click);
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.Enabled = false;
            this.EncryptBtn.Location = new System.Drawing.Point(18, 101);
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Size = new System.Drawing.Size(75, 37);
            this.EncryptBtn.TabIndex = 1;
            this.EncryptBtn.Text = "Na Raz";
            this.EncryptBtn.UseVisualStyleBackColor = true;
            this.EncryptBtn.Click += new System.EventHandler(this.EncryptBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DecryptBtn);
            this.groupBox3.Controls.Add(this.StepByStepDecryptBtn);
            this.groupBox3.Location = new System.Drawing.Point(173, 348);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(109, 151);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Deszyfrowanie";
            // 
            // DecryptBtn
            // 
            this.DecryptBtn.Enabled = false;
            this.DecryptBtn.Location = new System.Drawing.Point(18, 101);
            this.DecryptBtn.Name = "DecryptBtn";
            this.DecryptBtn.Size = new System.Drawing.Size(75, 37);
            this.DecryptBtn.TabIndex = 1;
            this.DecryptBtn.Text = "Na Raz";
            this.DecryptBtn.UseVisualStyleBackColor = true;
            this.DecryptBtn.Click += new System.EventHandler(this.DecryptBtn_Click);
            // 
            // StepByStepDecryptBtn
            // 
            this.StepByStepDecryptBtn.Enabled = false;
            this.StepByStepDecryptBtn.Location = new System.Drawing.Point(18, 35);
            this.StepByStepDecryptBtn.Name = "StepByStepDecryptBtn";
            this.StepByStepDecryptBtn.Size = new System.Drawing.Size(75, 40);
            this.StepByStepDecryptBtn.TabIndex = 0;
            this.StepByStepDecryptBtn.Text = "Krok Po Kroku";
            this.StepByStepDecryptBtn.UseVisualStyleBackColor = true;
            this.StepByStepDecryptBtn.Click += new System.EventHandler(this.StepByStepDecryptBtn_Click);
            // 
            // NextStepBtn
            // 
            this.NextStepBtn.Enabled = false;
            this.NextStepBtn.Location = new System.Drawing.Point(323, 376);
            this.NextStepBtn.Name = "NextStepBtn";
            this.NextStepBtn.Size = new System.Drawing.Size(75, 55);
            this.NextStepBtn.TabIndex = 10;
            this.NextStepBtn.Text = "Następny krok";
            this.NextStepBtn.UseVisualStyleBackColor = true;
            this.NextStepBtn.Click += new System.EventHandler(this.NextStepBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Wiadomość:";
            // 
            // InputMessageBox
            // 
            this.InputMessageBox.Location = new System.Drawing.Point(143, 42);
            this.InputMessageBox.Name = "InputMessageBox";
            this.InputMessageBox.Size = new System.Drawing.Size(232, 20);
            this.InputMessageBox.TabIndex = 12;
            // 
            // ProccesGroup
            // 
            this.ProccesGroup.Controls.Add(this.MessageOutputLabel);
            this.ProccesGroup.Controls.Add(this.InstructionLabel);
            this.ProccesGroup.Controls.Add(this.label3);
            this.ProccesGroup.Controls.Add(this.label2);
            this.ProccesGroup.Location = new System.Drawing.Point(32, 101);
            this.ProccesGroup.Name = "ProccesGroup";
            this.ProccesGroup.Size = new System.Drawing.Size(475, 179);
            this.ProccesGroup.TabIndex = 13;
            this.ProccesGroup.TabStop = false;
            this.ProccesGroup.Text = "Postęp";
            // 
            // MessageOutputLabel
            // 
            this.MessageOutputLabel.Location = new System.Drawing.Point(152, 117);
            this.MessageOutputLabel.Name = "MessageOutputLabel";
            this.MessageOutputLabel.Size = new System.Drawing.Size(185, 20);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tryb szyfrowania:";
            // 
            // RowColRad
            // 
            this.RowColRad.AutoSize = true;
            this.RowColRad.Location = new System.Drawing.Point(260, 336);
            this.RowColRad.Name = "RowColRad";
            this.RowColRad.Size = new System.Drawing.Size(103, 17);
            this.RowColRad.TabIndex = 8;
            this.RowColRad.TabStop = true;
            this.RowColRad.Text = "Wiersz/Kolumna";
            this.RowColRad.UseVisualStyleBackColor = true;
            this.RowColRad.CheckedChanged += new System.EventHandler(this.RowColRad_CheckedChanged);
            // 
            // ColRowRad
            // 
            this.ColRowRad.AutoSize = true;
            this.ColRowRad.Location = new System.Drawing.Point(260, 381);
            this.ColRowRad.Name = "ColRowRad";
            this.ColRowRad.Size = new System.Drawing.Size(103, 17);
            this.ColRowRad.TabIndex = 9;
            this.ColRowRad.TabStop = true;
            this.ColRowRad.Text = "Kolumna/Wiersz";
            this.ColRowRad.UseVisualStyleBackColor = true;
            this.ColRowRad.CheckedChanged += new System.EventHandler(this.ColRowRad_CheckedChanged);
            // 
            // PolibiusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 579);
            this.Controls.Add(this.ProccesGroup);
            this.Controls.Add(this.InputMessageBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NextStepBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PolibiusForm";
            this.Text = "PolibiusForm";
            ((System.ComponentModel.ISupportInitialize)(this.Key_Grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ProccesGroup.ResumeLayout(false);
            this.ProccesGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Key_Grid;
        private System.Windows.Forms.Button AddCol_Btn;
        private System.Windows.Forms.Button DelCol_Btn;
        private System.Windows.Forms.Button AddRow_Btn;
        private System.Windows.Forms.Button DelRow_Btn;
        private System.Windows.Forms.Button Val_Btn;
        private System.Windows.Forms.Button RelKey_Btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button StepByStepEncryptBtn;
        private System.Windows.Forms.Button EncryptBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button DecryptBtn;
        private System.Windows.Forms.Button StepByStepDecryptBtn;
        private System.Windows.Forms.Button NextStepBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputMessageBox;
        private System.Windows.Forms.GroupBox ProccesGroup;
        private System.Windows.Forms.TextBox MessageOutputLabel;
        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton ColRowRad;
        private System.Windows.Forms.RadioButton RowColRad;
        private System.Windows.Forms.Label label4;
    }
}