namespace DovizOtomasyon
{
    partial class FormMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopPanel = new System.Windows.Forms.Panel();
            this.kullaniciButon = new FontAwesome.Sharp.IconButton();
            this.bankaButton = new FontAwesome.Sharp.IconButton();
            this.kurlarButton = new FontAwesome.Sharp.IconButton();
            this.muhasebeButton = new FontAwesome.Sharp.IconButton();
            this.alisSatisButton = new FontAwesome.Sharp.IconButton();
            this.TopBPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.alisSatisPanel = new System.Windows.Forms.Panel();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.cartesianChart1 = new LiveCharts.Wpf.CartesianChart();
            this.alisSatisLabel = new System.Windows.Forms.Label();
            this.kurlarPanel = new System.Windows.Forms.Panel();
            this.kurlarLabel = new System.Windows.Forms.Label();
            this.bankaKurlarPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.muhasebePanel = new System.Windows.Forms.Panel();
            this.muhasebeLabel = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.alisSatisPanel.SuspendLayout();
            this.kurlarPanel.SuspendLayout();
            this.bankaKurlarPanel.SuspendLayout();
            this.muhasebePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.TopPanel.Controls.Add(this.kullaniciButon);
            this.TopPanel.Controls.Add(this.bankaButton);
            this.TopPanel.Controls.Add(this.kurlarButton);
            this.TopPanel.Controls.Add(this.muhasebeButton);
            this.TopPanel.Controls.Add(this.alisSatisButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(982, 56);
            this.TopPanel.TabIndex = 0;
            // 
            // kullaniciButon
            // 
            this.kullaniciButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(143)))));
            this.kullaniciButon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kullaniciButon.Dock = System.Windows.Forms.DockStyle.Right;
            this.kullaniciButon.FlatAppearance.BorderSize = 0;
            this.kullaniciButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kullaniciButon.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.kullaniciButon.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciButon.ForeColor = System.Drawing.Color.Snow;
            this.kullaniciButon.IconChar = FontAwesome.Sharp.IconChar.User;
            this.kullaniciButon.IconColor = System.Drawing.Color.WhiteSmoke;
            this.kullaniciButon.IconSize = 25;
            this.kullaniciButon.Location = new System.Drawing.Point(948, 0);
            this.kullaniciButon.Name = "kullaniciButon";
            this.kullaniciButon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kullaniciButon.Rotation = 0D;
            this.kullaniciButon.Size = new System.Drawing.Size(34, 56);
            this.kullaniciButon.TabIndex = 5;
            this.kullaniciButon.UseVisualStyleBackColor = false;
            this.kullaniciButon.Click += new System.EventHandler(this.kullaniciButon_Click);
            // 
            // bankaButton
            // 
            this.bankaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(143)))));
            this.bankaButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bankaButton.FlatAppearance.BorderSize = 0;
            this.bankaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bankaButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bankaButton.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bankaButton.ForeColor = System.Drawing.Color.Snow;
            this.bankaButton.IconChar = FontAwesome.Sharp.IconChar.University;
            this.bankaButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bankaButton.IconSize = 30;
            this.bankaButton.Location = new System.Drawing.Point(423, 0);
            this.bankaButton.Name = "bankaButton";
            this.bankaButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bankaButton.Rotation = 0D;
            this.bankaButton.Size = new System.Drawing.Size(140, 56);
            this.bankaButton.TabIndex = 4;
            this.bankaButton.Text = "Banka Kurları";
            this.bankaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bankaButton.UseVisualStyleBackColor = false;
            this.bankaButton.Click += new System.EventHandler(this.bankaButton_Click);
            // 
            // kurlarButton
            // 
            this.kurlarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(143)))));
            this.kurlarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kurlarButton.FlatAppearance.BorderSize = 0;
            this.kurlarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kurlarButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.kurlarButton.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kurlarButton.ForeColor = System.Drawing.Color.Snow;
            this.kurlarButton.IconChar = FontAwesome.Sharp.IconChar.ChartArea;
            this.kurlarButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.kurlarButton.IconSize = 30;
            this.kurlarButton.Location = new System.Drawing.Point(282, 0);
            this.kurlarButton.Name = "kurlarButton";
            this.kurlarButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kurlarButton.Rotation = 0D;
            this.kurlarButton.Size = new System.Drawing.Size(140, 56);
            this.kurlarButton.TabIndex = 3;
            this.kurlarButton.Text = "Kurlar";
            this.kurlarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.kurlarButton.UseVisualStyleBackColor = false;
            this.kurlarButton.Click += new System.EventHandler(this.kurlarButton_Click);
            // 
            // muhasebeButton
            // 
            this.muhasebeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(143)))));
            this.muhasebeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.muhasebeButton.FlatAppearance.BorderSize = 0;
            this.muhasebeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muhasebeButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.muhasebeButton.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.muhasebeButton.ForeColor = System.Drawing.Color.Snow;
            this.muhasebeButton.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.muhasebeButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.muhasebeButton.IconSize = 30;
            this.muhasebeButton.Location = new System.Drawing.Point(141, 0);
            this.muhasebeButton.Name = "muhasebeButton";
            this.muhasebeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.muhasebeButton.Rotation = 0D;
            this.muhasebeButton.Size = new System.Drawing.Size(140, 56);
            this.muhasebeButton.TabIndex = 2;
            this.muhasebeButton.Text = "Muhasebe";
            this.muhasebeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.muhasebeButton.UseVisualStyleBackColor = false;
            this.muhasebeButton.Click += new System.EventHandler(this.muhasebeButton_Click);
            // 
            // alisSatisButton
            // 
            this.alisSatisButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(143)))));
            this.alisSatisButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.alisSatisButton.FlatAppearance.BorderSize = 0;
            this.alisSatisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alisSatisButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.alisSatisButton.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alisSatisButton.ForeColor = System.Drawing.Color.Snow;
            this.alisSatisButton.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.alisSatisButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.alisSatisButton.IconSize = 30;
            this.alisSatisButton.Location = new System.Drawing.Point(0, 0);
            this.alisSatisButton.Name = "alisSatisButton";
            this.alisSatisButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.alisSatisButton.Rotation = 0D;
            this.alisSatisButton.Size = new System.Drawing.Size(140, 56);
            this.alisSatisButton.TabIndex = 1;
            this.alisSatisButton.Text = "Alış/Satış";
            this.alisSatisButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.alisSatisButton.UseVisualStyleBackColor = false;
            this.alisSatisButton.Click += new System.EventHandler(this.alisSatisButton_Click);
            // 
            // TopBPanel
            // 
            this.TopBPanel.BackColor = System.Drawing.Color.DarkGray;
            this.TopBPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBPanel.Location = new System.Drawing.Point(0, 56);
            this.TopBPanel.Name = "TopBPanel";
            this.TopBPanel.Size = new System.Drawing.Size(982, 11);
            this.TopBPanel.TabIndex = 1;
            this.TopBPanel.Visible = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.alisSatisPanel);
            this.mainPanel.Controls.Add(this.kurlarPanel);
            this.mainPanel.Controls.Add(this.bankaKurlarPanel);
            this.mainPanel.Controls.Add(this.muhasebePanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 67);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(982, 486);
            this.mainPanel.TabIndex = 2;
            // 
            // alisSatisPanel
            // 
            this.alisSatisPanel.Controls.Add(this.elementHost1);
            this.alisSatisPanel.Controls.Add(this.alisSatisLabel);
            this.alisSatisPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alisSatisPanel.Location = new System.Drawing.Point(0, 0);
            this.alisSatisPanel.Name = "alisSatisPanel";
            this.alisSatisPanel.Size = new System.Drawing.Size(982, 486);
            this.alisSatisPanel.TabIndex = 3;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(12, 6);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(958, 322);
            this.elementHost1.TabIndex = 1;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.cartesianChart1;
            // 
            // alisSatisLabel
            // 
            this.alisSatisLabel.AutoSize = true;
            this.alisSatisLabel.Location = new System.Drawing.Point(33, 408);
            this.alisSatisLabel.Name = "alisSatisLabel";
            this.alisSatisLabel.Size = new System.Drawing.Size(89, 18);
            this.alisSatisLabel.TabIndex = 0;
            this.alisSatisLabel.Text = "alisSatisLabel";
            // 
            // kurlarPanel
            // 
            this.kurlarPanel.Controls.Add(this.kurlarLabel);
            this.kurlarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kurlarPanel.Location = new System.Drawing.Point(0, 0);
            this.kurlarPanel.Name = "kurlarPanel";
            this.kurlarPanel.Size = new System.Drawing.Size(982, 486);
            this.kurlarPanel.TabIndex = 5;
            // 
            // kurlarLabel
            // 
            this.kurlarLabel.AutoSize = true;
            this.kurlarLabel.Location = new System.Drawing.Point(33, 37);
            this.kurlarLabel.Name = "kurlarLabel";
            this.kurlarLabel.Size = new System.Drawing.Size(45, 18);
            this.kurlarLabel.TabIndex = 0;
            this.kurlarLabel.Text = "Kurlar";
            // 
            // bankaKurlarPanel
            // 
            this.bankaKurlarPanel.Controls.Add(this.label1);
            this.bankaKurlarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bankaKurlarPanel.Location = new System.Drawing.Point(0, 0);
            this.bankaKurlarPanel.Name = "bankaKurlarPanel";
            this.bankaKurlarPanel.Size = new System.Drawing.Size(982, 486);
            this.bankaKurlarPanel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banka Kurları";
            // 
            // muhasebePanel
            // 
            this.muhasebePanel.Controls.Add(this.muhasebeLabel);
            this.muhasebePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.muhasebePanel.Location = new System.Drawing.Point(0, 0);
            this.muhasebePanel.Name = "muhasebePanel";
            this.muhasebePanel.Size = new System.Drawing.Size(982, 486);
            this.muhasebePanel.TabIndex = 4;
            // 
            // muhasebeLabel
            // 
            this.muhasebeLabel.AutoSize = true;
            this.muhasebeLabel.Location = new System.Drawing.Point(33, 37);
            this.muhasebeLabel.Name = "muhasebeLabel";
            this.muhasebeLabel.Size = new System.Drawing.Size(104, 18);
            this.muhasebeLabel.TabIndex = 0;
            this.muhasebeLabel.Text = "muhasebeLabel";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.TopBPanel);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "Döviz Otomasyon";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.TopPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.alisSatisPanel.ResumeLayout(false);
            this.alisSatisPanel.PerformLayout();
            this.kurlarPanel.ResumeLayout(false);
            this.kurlarPanel.PerformLayout();
            this.bankaKurlarPanel.ResumeLayout(false);
            this.bankaKurlarPanel.PerformLayout();
            this.muhasebePanel.ResumeLayout(false);
            this.muhasebePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private void AlisSatisButton_MouseEnter(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private FontAwesome.Sharp.IconButton alisSatisButton;
        private System.Windows.Forms.Panel TopBPanel;
        private FontAwesome.Sharp.IconButton bankaButton;
        private FontAwesome.Sharp.IconButton kurlarButton;
        private FontAwesome.Sharp.IconButton muhasebeButton;
        private FontAwesome.Sharp.IconButton kullaniciButon;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel alisSatisPanel;
        private System.Windows.Forms.Panel muhasebePanel;
        private System.Windows.Forms.Label muhasebeLabel;
        private System.Windows.Forms.Label alisSatisLabel;
        private System.Windows.Forms.Panel bankaKurlarPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel kurlarPanel;
        private System.Windows.Forms.Label kurlarLabel;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LiveCharts.Wpf.CartesianChart cartesianChart1;
    }
}

