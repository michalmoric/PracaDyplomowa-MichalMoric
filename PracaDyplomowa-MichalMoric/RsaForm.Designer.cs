
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
            this.MessageBox = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Encrypt_Btn = new System.Windows.Forms.Button();
            this.Decrypt_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PublicKeyBox
            // 
            this.PublicKeyBox.Location = new System.Drawing.Point(559, 84);
            this.PublicKeyBox.Name = "PublicKeyBox";
            this.PublicKeyBox.Size = new System.Drawing.Size(200, 20);
            this.PublicKeyBox.TabIndex = 0;
            // 
            // PrivateKeyBox
            // 
            this.PrivateKeyBox.Location = new System.Drawing.Point(559, 133);
            this.PrivateKeyBox.Name = "PrivateKeyBox";
            this.PrivateKeyBox.Size = new System.Drawing.Size(200, 20);
            this.PrivateKeyBox.TabIndex = 1;
            // 
            // NBox
            // 
            this.NBox.Location = new System.Drawing.Point(559, 38);
            this.NBox.Name = "NBox";
            this.NBox.Size = new System.Drawing.Size(200, 20);
            this.NBox.TabIndex = 2;
            // 
            // KeyGenBtn
            // 
            this.KeyGenBtn.Location = new System.Drawing.Point(559, 191);
            this.KeyGenBtn.Name = "KeyGenBtn";
            this.KeyGenBtn.Size = new System.Drawing.Size(200, 23);
            this.KeyGenBtn.TabIndex = 3;
            this.KeyGenBtn.Text = "Generete Rsa Keys";
            this.KeyGenBtn.UseVisualStyleBackColor = true;
            this.KeyGenBtn.Click += new System.EventHandler(this.KeyGenBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "N (Both Keys):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "E (public key):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "D (private key):";
            // 
            // MessageBox
            // 
            this.MessageBox.Location = new System.Drawing.Point(176, 80);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(169, 20);
            this.MessageBox.TabIndex = 7;
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
            this.Encrypt_Btn.Location = new System.Drawing.Point(71, 222);
            this.Encrypt_Btn.Name = "Encrypt_Btn";
            this.Encrypt_Btn.Size = new System.Drawing.Size(75, 23);
            this.Encrypt_Btn.TabIndex = 11;
            this.Encrypt_Btn.Text = "Zakoduj";
            this.Encrypt_Btn.UseVisualStyleBackColor = true;
            this.Encrypt_Btn.Click += new System.EventHandler(this.Encrypt_Btn_Click);
            // 
            // Decrypt_Btn
            // 
            this.Decrypt_Btn.Location = new System.Drawing.Point(201, 222);
            this.Decrypt_Btn.Name = "Decrypt_Btn";
            this.Decrypt_Btn.Size = new System.Drawing.Size(75, 23);
            this.Decrypt_Btn.TabIndex = 12;
            this.Decrypt_Btn.Text = "Odkoduj";
            this.Decrypt_Btn.UseVisualStyleBackColor = true;
            this.Decrypt_Btn.Click += new System.EventHandler(this.Decrypt_Btn_Click);
            // 
            // RsaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Decrypt_Btn);
            this.Controls.Add(this.Encrypt_Btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KeyGenBtn);
            this.Controls.Add(this.NBox);
            this.Controls.Add(this.PrivateKeyBox);
            this.Controls.Add(this.PublicKeyBox);
            this.Name = "RsaForm";
            this.Text = "RsaForm";
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
        private System.Windows.Forms.TextBox MessageBox;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Encrypt_Btn;
        private System.Windows.Forms.Button Decrypt_Btn;
    }
}