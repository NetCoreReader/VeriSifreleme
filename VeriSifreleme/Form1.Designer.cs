namespace VeriSifreleme
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
            this.btnIslemeAl = new System.Windows.Forms.Button();
            this.txtVeri = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCikti = new System.Windows.Forms.TextBox();
            this.rdBtnSifrele = new System.Windows.Forms.RadioButton();
            this.rdBtnSifreCoz = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIslemeAl
            // 
            this.btnIslemeAl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnIslemeAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslemeAl.Location = new System.Drawing.Point(3, 88);
            this.btnIslemeAl.Name = "btnIslemeAl";
            this.btnIslemeAl.Size = new System.Drawing.Size(113, 29);
            this.btnIslemeAl.TabIndex = 0;
            this.btnIslemeAl.Text = "İŞLEME AL";
            this.btnIslemeAl.UseVisualStyleBackColor = true;
            this.btnIslemeAl.Click += new System.EventHandler(this.btnIslemeAl_Click);
            // 
            // txtVeri
            // 
            this.txtVeri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVeri.Location = new System.Drawing.Point(3, 16);
            this.txtVeri.Multiline = true;
            this.txtVeri.Name = "txtVeri";
            this.txtVeri.Size = new System.Drawing.Size(472, 101);
            this.txtVeri.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVeri);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 120);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VERİ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCikti);
            this.groupBox2.Location = new System.Drawing.Point(12, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 131);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ÇIKTI";
            // 
            // txtCikti
            // 
            this.txtCikti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCikti.Location = new System.Drawing.Point(3, 16);
            this.txtCikti.Multiline = true;
            this.txtCikti.Name = "txtCikti";
            this.txtCikti.Size = new System.Drawing.Size(597, 112);
            this.txtCikti.TabIndex = 1;
            // 
            // rdBtnSifrele
            // 
            this.rdBtnSifrele.AutoSize = true;
            this.rdBtnSifrele.Checked = true;
            this.rdBtnSifrele.Location = new System.Drawing.Point(6, 42);
            this.rdBtnSifrele.Name = "rdBtnSifrele";
            this.rdBtnSifrele.Size = new System.Drawing.Size(69, 17);
            this.rdBtnSifrele.TabIndex = 3;
            this.rdBtnSifrele.TabStop = true;
            this.rdBtnSifrele.Text = "ŞİFRELE";
            this.rdBtnSifrele.UseVisualStyleBackColor = true;
            // 
            // rdBtnSifreCoz
            // 
            this.rdBtnSifreCoz.AutoSize = true;
            this.rdBtnSifreCoz.Location = new System.Drawing.Point(6, 65);
            this.rdBtnSifreCoz.Name = "rdBtnSifreCoz";
            this.rdBtnSifreCoz.Size = new System.Drawing.Size(81, 17);
            this.rdBtnSifreCoz.TabIndex = 3;
            this.rdBtnSifreCoz.Text = "ŞİFRE ÇÖZ";
            this.rdBtnSifreCoz.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtKey);
            this.groupBox3.Controls.Add(this.rdBtnSifreCoz);
            this.groupBox3.Controls.Add(this.btnIslemeAl);
            this.groupBox3.Controls.Add(this.rdBtnSifrele);
            this.groupBox3.Location = new System.Drawing.Point(496, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(119, 120);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ANAHTAR";
            // 
            // txtKey
            // 
            this.txtKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKey.Location = new System.Drawing.Point(3, 16);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(113, 20);
            this.txtKey.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 281);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VERİ ŞİFRELEME";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIslemeAl;
        private System.Windows.Forms.TextBox txtVeri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCikti;
        private System.Windows.Forms.RadioButton rdBtnSifrele;
        private System.Windows.Forms.RadioButton rdBtnSifreCoz;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtKey;
    }
}

