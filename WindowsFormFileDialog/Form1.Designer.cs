namespace WindowsFormFileDialog
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbBeir = new System.Windows.Forms.TextBox();
            this.listSzovegek = new System.Windows.Forms.ListBox();
            this.btnMent = new System.Windows.Forms.Button();
            this.btnBetolt = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "TextFile(*.txt)|*.txt|All files(*.*)|*.*";
            // 
            // tbBeir
            // 
            this.tbBeir.Location = new System.Drawing.Point(12, 30);
            this.tbBeir.Name = "tbBeir";
            this.tbBeir.Size = new System.Drawing.Size(164, 20);
            this.tbBeir.TabIndex = 0;
            this.tbBeir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBeir_KeyDown);
            // 
            // listSzovegek
            // 
            this.listSzovegek.FormattingEnabled = true;
            this.listSzovegek.Location = new System.Drawing.Point(182, 30);
            this.listSzovegek.Name = "listSzovegek";
            this.listSzovegek.Size = new System.Drawing.Size(120, 394);
            this.listSzovegek.TabIndex = 1;
            // 
            // btnMent
            // 
            this.btnMent.Location = new System.Drawing.Point(50, 66);
            this.btnMent.Name = "btnMent";
            this.btnMent.Size = new System.Drawing.Size(75, 23);
            this.btnMent.TabIndex = 2;
            this.btnMent.Text = "Mentés";
            this.btnMent.UseVisualStyleBackColor = true;
            this.btnMent.Click += new System.EventHandler(this.btnMent_Click);
            // 
            // btnBetolt
            // 
            this.btnBetolt.Location = new System.Drawing.Point(50, 107);
            this.btnBetolt.Name = "btnBetolt";
            this.btnBetolt.Size = new System.Drawing.Size(75, 23);
            this.btnBetolt.TabIndex = 3;
            this.btnBetolt.Text = "Betöltés";
            this.btnBetolt.UseVisualStyleBackColor = true;
            this.btnBetolt.Click += new System.EventHandler(this.btnBetolt_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "TextFile(*.txt)|*.txt|All files(*.*)|*.*";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBetolt);
            this.Controls.Add(this.btnMent);
            this.Controls.Add(this.listSzovegek);
            this.Controls.Add(this.tbBeir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbBeir;
        private System.Windows.Forms.ListBox listSzovegek;
        private System.Windows.Forms.Button btnMent;
        private System.Windows.Forms.Button btnBetolt;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

