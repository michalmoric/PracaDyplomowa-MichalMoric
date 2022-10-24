
namespace PracaDyplomowa_MichalMoric
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cezar_Button = new System.Windows.Forms.Button();
            this.Polibius_Button = new System.Windows.Forms.Button();
            this.Rsa_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(35, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Program do nauki algorytow szyfrowania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(315, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "By: Michał Moric";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(251, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Proszę wybrać algoytm szyfrowania:";
            // 
            // Cezar_Button
            // 
            this.Cezar_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Cezar_Button.Location = new System.Drawing.Point(76, 321);
            this.Cezar_Button.Name = "Cezar_Button";
            this.Cezar_Button.Size = new System.Drawing.Size(104, 57);
            this.Cezar_Button.TabIndex = 3;
            this.Cezar_Button.Text = "Szyfr cezara";
            this.Cezar_Button.UseVisualStyleBackColor = true;
            this.Cezar_Button.Click += new System.EventHandler(this.Cezar_Button_Click);
            // 
            // Polibius_Button
            // 
            this.Polibius_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Polibius_Button.Location = new System.Drawing.Point(335, 321);
            this.Polibius_Button.Name = "Polibius_Button";
            this.Polibius_Button.Size = new System.Drawing.Size(103, 57);
            this.Polibius_Button.TabIndex = 4;
            this.Polibius_Button.Text = "Szyfr Polibiusza";
            this.Polibius_Button.UseVisualStyleBackColor = true;
            this.Polibius_Button.Click += new System.EventHandler(this.Polibius_Button_Click);
            // 
            // Rsa_Button
            // 
            this.Rsa_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rsa_Button.Location = new System.Drawing.Point(593, 321);
            this.Rsa_Button.Name = "Rsa_Button";
            this.Rsa_Button.Size = new System.Drawing.Size(98, 57);
            this.Rsa_Button.TabIndex = 5;
            this.Rsa_Button.Text = "Szyfr RSA";
            this.Rsa_Button.UseVisualStyleBackColor = true;
            this.Rsa_Button.Click += new System.EventHandler(this.Rsa_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Rsa_Button);
            this.Controls.Add(this.Polibius_Button);
            this.Controls.Add(this.Cezar_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Algorytmy Szyfrowania";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Cezar_Button;
        private System.Windows.Forms.Button Polibius_Button;
        private System.Windows.Forms.Button Rsa_Button;
    }
}

