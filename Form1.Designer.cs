namespace dizii
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
            this.dizi_isim_al = new System.Windows.Forms.TextBox();
            this.sezon_sayi_al = new System.Windows.Forms.TextBox();
            this.bolum_sayi_al = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "aranacak dizi veya film";
            // 
            // dizi_isim_al
            // 
            this.dizi_isim_al.Location = new System.Drawing.Point(75, 50);
            this.dizi_isim_al.Name = "dizi_isim_al";
            this.dizi_isim_al.Size = new System.Drawing.Size(100, 20);
            this.dizi_isim_al.TabIndex = 1;
            // 
            // sezon_sayi_al
            // 
            this.sezon_sayi_al.Location = new System.Drawing.Point(315, 50);
            this.sezon_sayi_al.Name = "sezon_sayi_al";
            this.sezon_sayi_al.Size = new System.Drawing.Size(40, 20);
            this.sezon_sayi_al.TabIndex = 2;
            // 
            // bolum_sayi_al
            // 
            this.bolum_sayi_al.Location = new System.Drawing.Point(387, 50);
            this.bolum_sayi_al.Name = "bolum_sayi_al";
            this.bolum_sayi_al.Size = new System.Drawing.Size(46, 20);
            this.bolum_sayi_al.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "çalıştır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(39, 175);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(456, 127);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "sezon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "bölüm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(659, 367);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bolum_sayi_al);
            this.Controls.Add(this.sezon_sayi_al);
            this.Controls.Add(this.dizi_isim_al);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dizi_isim_al;
        private System.Windows.Forms.TextBox sezon_sayi_al;
        private System.Windows.Forms.TextBox bolum_sayi_al;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

