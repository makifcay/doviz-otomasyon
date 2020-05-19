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
            this.sifreLabel = new System.Windows.Forms.Label();
            this.kullaniciFormPanel = new System.Windows.Forms.Panel();
            this.sifreGosterButton = new FontAwesome.Sharp.IconButton();
            this.ayarlarButton = new FontAwesome.Sharp.IconButton();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.girisButton = new FontAwesome.Sharp.IconButton();
            this.kullaniciTextBox = new System.Windows.Forms.TextBox();
            this.kullaniciAdiLabel = new System.Windows.Forms.Label();
            this.kullaniciFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sifreLabel
            // 
            this.sifreLabel.AutoSize = true;
            this.sifreLabel.Font = new System.Drawing.Font("Corbel", 7.8F);
            this.sifreLabel.Location = new System.Drawing.Point(22, 57);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(42, 17);
            this.sifreLabel.TabIndex = 1;
            this.sifreLabel.Text = "Şifre :";
            // 
            // kullaniciFormPanel
            // 
            this.kullaniciFormPanel.Controls.Add(this.sifreGosterButton);
            this.kullaniciFormPanel.Controls.Add(this.ayarlarButton);
            this.kullaniciFormPanel.Controls.Add(this.sifreTextBox);
            this.kullaniciFormPanel.Controls.Add(this.girisButton);
            this.kullaniciFormPanel.Controls.Add(this.kullaniciTextBox);
            this.kullaniciFormPanel.Controls.Add(this.kullaniciAdiLabel);
            this.kullaniciFormPanel.Controls.Add(this.sifreLabel);
            this.kullaniciFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kullaniciFormPanel.Location = new System.Drawing.Point(0, 0);
            this.kullaniciFormPanel.Name = "kullaniciFormPanel";
            this.kullaniciFormPanel.Size = new System.Drawing.Size(299, 150);
            this.kullaniciFormPanel.TabIndex = 2;
            // 
            // sifreGosterButton
            // 
            this.sifreGosterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(143)))));
            this.sifreGosterButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sifreGosterButton.FlatAppearance.BorderSize = 0;
            this.sifreGosterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sifreGosterButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.sifreGosterButton.Font = new System.Drawing.Font("Corbel", 9F);
            this.sifreGosterButton.ForeColor = System.Drawing.Color.Snow;
            this.sifreGosterButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.sifreGosterButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.sifreGosterButton.IconSize = 25;
            this.sifreGosterButton.Location = new System.Drawing.Point(247, 50);
            this.sifreGosterButton.Name = "sifreGosterButton";
            this.sifreGosterButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sifreGosterButton.Rotation = 0D;
            this.sifreGosterButton.Size = new System.Drawing.Size(30, 30);
            this.sifreGosterButton.TabIndex = 8;
            this.sifreGosterButton.UseVisualStyleBackColor = false;
            this.sifreGosterButton.Click += new System.EventHandler(this.sifreGosterButton_Click);
            // 
            // ayarlarButton
            // 
            this.ayarlarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(143)))));
            this.ayarlarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ayarlarButton.FlatAppearance.BorderSize = 0;
            this.ayarlarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ayarlarButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ayarlarButton.Font = new System.Drawing.Font("Corbel", 9F);
            this.ayarlarButton.ForeColor = System.Drawing.Color.Snow;
            this.ayarlarButton.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.ayarlarButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ayarlarButton.IconSize = 25;
            this.ayarlarButton.Location = new System.Drawing.Point(147, 95);
            this.ayarlarButton.Name = "ayarlarButton";
            this.ayarlarButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ayarlarButton.Rotation = 0D;
            this.ayarlarButton.Size = new System.Drawing.Size(120, 31);
            this.ayarlarButton.TabIndex = 7;
            this.ayarlarButton.Text = "Ayarlar";
            this.ayarlarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ayarlarButton.UseVisualStyleBackColor = false;
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(121, 54);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.PasswordChar = '*';
            this.sifreTextBox.Size = new System.Drawing.Size(120, 22);
            this.sifreTextBox.TabIndex = 6;
            // 
            // girisButton
            // 
            this.girisButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(143)))));
            this.girisButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.girisButton.FlatAppearance.BorderSize = 0;
            this.girisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.girisButton.Font = new System.Drawing.Font("Corbel", 9F);
            this.girisButton.ForeColor = System.Drawing.Color.Snow;
            this.girisButton.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.girisButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.girisButton.IconSize = 25;
            this.girisButton.Location = new System.Drawing.Point(29, 95);
            this.girisButton.Name = "girisButton";
            this.girisButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.girisButton.Rotation = 0D;
            this.girisButton.Size = new System.Drawing.Size(112, 31);
            this.girisButton.TabIndex = 5;
            this.girisButton.Text = "Giriş";
            this.girisButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.girisButton.UseVisualStyleBackColor = false;
            // 
            // kullaniciTextBox
            // 
            this.kullaniciTextBox.Location = new System.Drawing.Point(121, 16);
            this.kullaniciTextBox.Name = "kullaniciTextBox";
            this.kullaniciTextBox.Size = new System.Drawing.Size(156, 22);
            this.kullaniciTextBox.TabIndex = 3;
            // 
            // kullaniciAdiLabel
            // 
            this.kullaniciAdiLabel.AutoSize = true;
            this.kullaniciAdiLabel.Font = new System.Drawing.Font("Corbel", 7.8F);
            this.kullaniciAdiLabel.Location = new System.Drawing.Point(22, 19);
            this.kullaniciAdiLabel.Name = "kullaniciAdiLabel";
            this.kullaniciAdiLabel.Size = new System.Drawing.Size(84, 17);
            this.kullaniciAdiLabel.TabIndex = 2;
            this.kullaniciAdiLabel.Text = "Kullanıcı Adı :";
            // 
            // kullanici
            // 
            this.AcceptButton = this.girisButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 150);
            this.Controls.Add(this.kullaniciFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Name = "kullanici";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "kullanici";
            this.TopMost = true;
            this.kullaniciFormPanel.ResumeLayout(false);
            this.kullaniciFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label sifreLabel;
        private System.Windows.Forms.Panel kullaniciFormPanel;
        private System.Windows.Forms.TextBox kullaniciTextBox;
        private System.Windows.Forms.Label kullaniciAdiLabel;
        private FontAwesome.Sharp.IconButton girisButton;
        private System.Windows.Forms.TextBox sifreTextBox;
        private FontAwesome.Sharp.IconButton ayarlarButton;
        private FontAwesome.Sharp.IconButton sifreGosterButton;
    }
}