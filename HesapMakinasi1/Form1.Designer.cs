
namespace HesapMakinasi1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.btCıkar = new System.Windows.Forms.Button();
            this.btBol = new System.Windows.Forms.Button();
            this.btTopla = new System.Windows.Forms.Button();
            this.btCarp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSonuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btTemizle = new System.Windows.Forms.Button();
            this.btUs = new System.Windows.Forms.Button();
            this.btYuzde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(117, 113);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(124, 20);
            this.tb2.TabIndex = 0;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(117, 70);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(124, 20);
            this.tb1.TabIndex = 0;
            // 
            // btCıkar
            // 
            this.btCıkar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btCıkar.Location = new System.Drawing.Point(117, 279);
            this.btCıkar.Name = "btCıkar";
            this.btCıkar.Size = new System.Drawing.Size(54, 49);
            this.btCıkar.TabIndex = 1;
            this.btCıkar.Text = "-";
            this.btCıkar.UseVisualStyleBackColor = true;
            this.btCıkar.Click += new System.EventHandler(this.btCıkar_Click);
            // 
            // btBol
            // 
            this.btBol.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btBol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btBol.Location = new System.Drawing.Point(277, 279);
            this.btBol.Name = "btBol";
            this.btBol.Size = new System.Drawing.Size(54, 49);
            this.btBol.TabIndex = 1;
            this.btBol.Text = "/";
            this.btBol.UseVisualStyleBackColor = true;
            this.btBol.Click += new System.EventHandler(this.btBol_Click);
            // 
            // btTopla
            // 
            this.btTopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btTopla.Location = new System.Drawing.Point(27, 279);
            this.btTopla.Name = "btTopla";
            this.btTopla.Size = new System.Drawing.Size(54, 49);
            this.btTopla.TabIndex = 1;
            this.btTopla.Text = "+";
            this.btTopla.UseVisualStyleBackColor = true;
            this.btTopla.Click += new System.EventHandler(this.btTopla_Click);
            // 
            // btCarp
            // 
            this.btCarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btCarp.Location = new System.Drawing.Point(197, 279);
            this.btCarp.Name = "btCarp";
            this.btCarp.Size = new System.Drawing.Size(54, 49);
            this.btCarp.TabIndex = 1;
            this.btCarp.Text = "*";
            this.btCarp.UseVisualStyleBackColor = true;
            this.btCarp.Click += new System.EventHandler(this.btCarp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(41, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "1.SAYI : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(41, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "2.SAYI : ";
            // 
            // tbSonuc
            // 
            this.tbSonuc.Enabled = false;
            this.tbSonuc.Location = new System.Drawing.Point(117, 186);
            this.tbSonuc.Name = "tbSonuc";
            this.tbSonuc.Size = new System.Drawing.Size(124, 20);
            this.tbSonuc.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(46, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sonuc :";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(52, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "       Hesap Makinası";
            // 
            // btTemizle
            // 
            this.btTemizle.Location = new System.Drawing.Point(133, 232);
            this.btTemizle.Name = "btTemizle";
            this.btTemizle.Size = new System.Drawing.Size(75, 23);
            this.btTemizle.TabIndex = 4;
            this.btTemizle.Text = "Temizle";
            this.btTemizle.UseVisualStyleBackColor = true;
            this.btTemizle.Click += new System.EventHandler(this.btTemizle_Click);
            // 
            // btUs
            // 
            this.btUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btUs.Location = new System.Drawing.Point(117, 351);
            this.btUs.Name = "btUs";
            this.btUs.Size = new System.Drawing.Size(54, 49);
            this.btUs.TabIndex = 5;
            this.btUs.Text = "x³";
            this.btUs.UseVisualStyleBackColor = true;
            this.btUs.Click += new System.EventHandler(this.btUs_Click);
            // 
            // btYuzde
            // 
            this.btYuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btYuzde.Location = new System.Drawing.Point(197, 351);
            this.btYuzde.Name = "btYuzde";
            this.btYuzde.Size = new System.Drawing.Size(54, 49);
            this.btYuzde.TabIndex = 6;
            this.btYuzde.Text = "%";
            this.btYuzde.UseVisualStyleBackColor = true;
            this.btYuzde.Click += new System.EventHandler(this.btYuzde_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(359, 429);
            this.Controls.Add(this.btYuzde);
            this.Controls.Add(this.btUs);
            this.Controls.Add(this.btTemizle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btTopla);
            this.Controls.Add(this.btCarp);
            this.Controls.Add(this.btBol);
            this.Controls.Add(this.btCıkar);
            this.Controls.Add(this.tbSonuc);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.tb2);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Button btCıkar;
        private System.Windows.Forms.Button btBol;
        private System.Windows.Forms.Button btTopla;
        private System.Windows.Forms.Button btCarp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSonuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btTemizle;
        private System.Windows.Forms.Button btUs;
        private System.Windows.Forms.Button btYuzde;
    }
}

