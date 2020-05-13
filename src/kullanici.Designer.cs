namespace DovizOtomasyon
{
    partial class kullanici
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.G = new FontAwesome.Sharp.IconButton();
            this.kullanici_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.sifre_txt = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.sifre_txt);
            this.panel1.Controls.Add(this.G);
            this.panel1.Controls.Add(this.kullanici_txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 358);
            this.panel1.TabIndex = 2;
            // 
            // G
            // 
            this.G.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(143)))));
            this.G.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.G.FlatAppearance.BorderSize = 0;
            this.G.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.G.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.G.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.G.ForeColor = System.Drawing.Color.Snow;
            this.G.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.G.IconColor = System.Drawing.Color.WhiteSmoke;
            this.G.IconSize = 30;
            this.G.Location = new System.Drawing.Point(51, 217);
            this.G.Name = "G";
            this.G.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.G.Rotation = 0D;
            this.G.Size = new System.Drawing.Size(140, 34);
            this.G.TabIndex = 5;
            this.G.Text = "GİRİŞ";
            this.G.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.G.UseVisualStyleBackColor = false;
            // 
            // kullanici_txt
            // 
            this.kullanici_txt.Location = new System.Drawing.Point(191, 42);
            this.kullanici_txt.Name = "kullanici_txt";
            this.kullanici_txt.Size = new System.Drawing.Size(120, 22);
            this.kullanici_txt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // sifre_txt
            // 
            this.sifre_txt.Location = new System.Drawing.Point(191, 95);
            this.sifre_txt.Name = "sifre_txt";
            this.sifre_txt.PasswordChar = '*';
            this.sifre_txt.Size = new System.Drawing.Size(120, 22);
            this.sifre_txt.TabIndex = 6;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(143)))));
            this.iconButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iconButton1.ForeColor = System.Drawing.Color.Snow;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.iconButton1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(264, 217);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(148, 34);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.Text = "AYARLAR";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // kullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 358);
            this.Controls.Add(this.panel1);
            this.Name = "kullanici";
            this.Text = "kullanici";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox kullanici_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private FontAwesome.Sharp.IconButton G;
        private System.Windows.Forms.TextBox sifre_txt;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}