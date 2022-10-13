
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
            ((System.ComponentModel.ISupportInitialize)(this.Key_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Key_Grid
            // 
            this.Key_Grid.AllowUserToAddRows = false;
            this.Key_Grid.AllowUserToResizeColumns = false;
            this.Key_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Key_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Key_Grid.Location = new System.Drawing.Point(505, 21);
            this.Key_Grid.Name = "Key_Grid";
            this.Key_Grid.Size = new System.Drawing.Size(550, 258);
            this.Key_Grid.TabIndex = 0;
            // 
            // AddCol_Btn
            // 
            this.AddCol_Btn.Location = new System.Drawing.Point(544, 305);
            this.AddCol_Btn.Name = "AddCol_Btn";
            this.AddCol_Btn.Size = new System.Drawing.Size(75, 42);
            this.AddCol_Btn.TabIndex = 1;
            this.AddCol_Btn.Text = "Dodaj Kolumne";
            this.AddCol_Btn.UseVisualStyleBackColor = true;
            this.AddCol_Btn.Click += new System.EventHandler(this.AddCol_Btn_Click);
            // 
            // DelCol_Btn
            // 
            this.DelCol_Btn.Location = new System.Drawing.Point(544, 353);
            this.DelCol_Btn.Name = "DelCol_Btn";
            this.DelCol_Btn.Size = new System.Drawing.Size(75, 41);
            this.DelCol_Btn.TabIndex = 2;
            this.DelCol_Btn.Text = "Usun Kolumne";
            this.DelCol_Btn.UseVisualStyleBackColor = true;
            this.DelCol_Btn.Click += new System.EventHandler(this.DelCol_Btn_Click);
            // 
            // AddRow_Btn
            // 
            this.AddRow_Btn.Location = new System.Drawing.Point(687, 305);
            this.AddRow_Btn.Name = "AddRow_Btn";
            this.AddRow_Btn.Size = new System.Drawing.Size(75, 42);
            this.AddRow_Btn.TabIndex = 3;
            this.AddRow_Btn.Text = "Dodaj Wiersz";
            this.AddRow_Btn.UseVisualStyleBackColor = true;
            this.AddRow_Btn.Click += new System.EventHandler(this.AddRow_Btn_Click);
            // 
            // DelRow_Btn
            // 
            this.DelRow_Btn.Location = new System.Drawing.Point(687, 353);
            this.DelRow_Btn.Name = "DelRow_Btn";
            this.DelRow_Btn.Size = new System.Drawing.Size(75, 41);
            this.DelRow_Btn.TabIndex = 4;
            this.DelRow_Btn.Text = "Usun Wiersz";
            this.DelRow_Btn.UseVisualStyleBackColor = true;
            this.DelRow_Btn.Click += new System.EventHandler(this.DelRow_Btn_Click);
            // 
            // Val_Btn
            // 
            this.Val_Btn.Location = new System.Drawing.Point(883, 305);
            this.Val_Btn.Name = "Val_Btn";
            this.Val_Btn.Size = new System.Drawing.Size(75, 23);
            this.Val_Btn.TabIndex = 5;
            this.Val_Btn.Text = "Validate";
            this.Val_Btn.UseVisualStyleBackColor = true;
            this.Val_Btn.Click += new System.EventHandler(this.Val_Btn_Click);
            // 
            // PolibiusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 579);
            this.Controls.Add(this.Val_Btn);
            this.Controls.Add(this.DelRow_Btn);
            this.Controls.Add(this.AddRow_Btn);
            this.Controls.Add(this.DelCol_Btn);
            this.Controls.Add(this.AddCol_Btn);
            this.Controls.Add(this.Key_Grid);
            this.Name = "PolibiusForm";
            this.Text = "PolibiusForm";
            ((System.ComponentModel.ISupportInitialize)(this.Key_Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Key_Grid;
        private System.Windows.Forms.Button AddCol_Btn;
        private System.Windows.Forms.Button DelCol_Btn;
        private System.Windows.Forms.Button AddRow_Btn;
        private System.Windows.Forms.Button DelRow_Btn;
        private System.Windows.Forms.Button Val_Btn;
    }
}