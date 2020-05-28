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
            this.components = new System.ComponentModel.Container();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.kullaniciBilgiPanel = new System.Windows.Forms.Panel();
            this.kullaniciAdiTopLabel = new System.Windows.Forms.Label();
            this.kullaniciButon = new FontAwesome.Sharp.IconButton();
            this.bankaButton = new FontAwesome.Sharp.IconButton();
            this.kurlarButton = new FontAwesome.Sharp.IconButton();
            this.muhasebeButton = new FontAwesome.Sharp.IconButton();
            this.alisSatisButton = new FontAwesome.Sharp.IconButton();
            this.TopBPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.girisYapPanel = new System.Windows.Forms.Panel();
            this.kullaniciFormPanel = new System.Windows.Forms.Panel();
            this.girisYapOrtalaPanel = new System.Windows.Forms.Panel();
            this.kullaniciAdiLabel = new System.Windows.Forms.Label();
            this.TusPanel = new System.Windows.Forms.Panel();
            this.girisButton = new FontAwesome.Sharp.IconButton();
            this.ayarlarButton = new FontAwesome.Sharp.IconButton();
            this.sifreLabel = new System.Windows.Forms.Label();
            this.sifreGosterButton = new FontAwesome.Sharp.IconButton();
            this.kullaniciTextBox = new System.Windows.Forms.TextBox();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.alisSatisMainPanel = new System.Windows.Forms.Panel();
            this.alisSatisPanel = new System.Windows.Forms.Panel();
            this.miktarLogo = new System.Windows.Forms.Label();
            this.karsilikLogo = new System.Windows.Forms.Label();
            this.karsilikLabel = new System.Windows.Forms.Label();
            this.karsilikDegerLabel = new System.Windows.Forms.Label();
            this.miktarLabel = new System.Windows.Forms.Label();
            this.kilitPanel = new System.Windows.Forms.Panel();
            this.kilitleButton = new FontAwesome.Sharp.IconButton();
            this.geriSayimLabel = new System.Windows.Forms.Label();
            this.donusumPanel = new System.Windows.Forms.Panel();
            this.resimOrtalaPanel = new System.Windows.Forms.Panel();
            this.donusumPicBox = new FontAwesome.Sharp.IconPictureBox();
            this.donusturLabel2 = new System.Windows.Forms.Label();
            this.donusturLabel1 = new System.Windows.Forms.Label();
            this.alisverisMiktarTextBox = new System.Windows.Forms.TextBox();
            this.alisverisMiktarOndalikTextBox = new System.Windows.Forms.TextBox();
            this.noktaTextBox = new System.Windows.Forms.Label();
            this.islemTurucomboBox = new System.Windows.Forms.ComboBox();
            this.dovizCinsicomboBox = new System.Windows.Forms.ComboBox();
            this.tamamlaButton = new FontAwesome.Sharp.IconButton();
            this.yeniIslemButton = new FontAwesome.Sharp.IconButton();
            this.islemTuruLabel = new System.Windows.Forms.Label();
            this.dovizCinsiLabel = new System.Windows.Forms.Label();
            this.bakiyePanel1 = new System.Windows.Forms.Panel();
            this.kurlarDataGridView = new System.Windows.Forms.DataGridView();
            this.alisverisTest = new System.Windows.Forms.Label();
            this.muhasebePanel = new System.Windows.Forms.Panel();
            this.muhasebeDataGridView = new System.Windows.Forms.DataGridView();
            this.muhasebeLabel = new System.Windows.Forms.Label();
            this.kurlarPanel = new System.Windows.Forms.Panel();
            this.kurlarLabel = new System.Windows.Forms.Label();
            this.bankaKurlarPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.alısverisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.islemGeriSayim = new System.Windows.Forms.Timer(this.components);
            this.dovizotomasyonDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TopPanel.SuspendLayout();
            this.kullaniciBilgiPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.girisYapPanel.SuspendLayout();
            this.kullaniciFormPanel.SuspendLayout();
            this.girisYapOrtalaPanel.SuspendLayout();
            this.TusPanel.SuspendLayout();
            this.alisSatisMainPanel.SuspendLayout();
            this.alisSatisPanel.SuspendLayout();
            this.kilitPanel.SuspendLayout();
            this.donusumPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donusumPicBox)).BeginInit();
            this.bakiyePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kurlarDataGridView)).BeginInit();
            this.muhasebePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeDataGridView)).BeginInit();
            this.kurlarPanel.SuspendLayout();
            this.bankaKurlarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alısverisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dovizotomasyonDataSet3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.TopPanel.Controls.Add(this.kullaniciBilgiPanel);
            this.TopPanel.Controls.Add(this.bankaButton);
            this.TopPanel.Controls.Add(this.kurlarButton);
            this.TopPanel.Controls.Add(this.muhasebeButton);
            this.TopPanel.Controls.Add(this.alisSatisButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(982, 56);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.Visible = false;
            // 
            // kullaniciBilgiPanel
            // 
            this.kullaniciBilgiPanel.Controls.Add(this.kullaniciAdiTopLabel);
            this.kullaniciBilgiPanel.Controls.Add(this.kullaniciButon);
            this.kullaniciBilgiPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.kullaniciBilgiPanel.Location = new System.Drawing.Point(727, 0);
            this.kullaniciBilgiPanel.Name = "kullaniciBilgiPanel";
            this.kullaniciBilgiPanel.Size = new System.Drawing.Size(255, 56);
            this.kullaniciBilgiPanel.TabIndex = 2;
            // 
            // kullaniciAdiTopLabel
            // 
            this.kullaniciAdiTopLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdiTopLabel.Location = new System.Drawing.Point(24, 16);
            this.kullaniciAdiTopLabel.Name = "kullaniciAdiTopLabel";
            this.kullaniciAdiTopLabel.Size = new System.Drawing.Size(191, 25);
            this.kullaniciAdiTopLabel.TabIndex = 23;
            this.kullaniciAdiTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.kullaniciButon.Location = new System.Drawing.Point(221, 0);
            this.kullaniciButon.Name = "kullaniciButon";
            this.kullaniciButon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kullaniciButon.Rotation = 0D;
            this.kullaniciButon.Size = new System.Drawing.Size(34, 56);
            this.kullaniciButon.TabIndex = 5;
            this.kullaniciButon.Tag = "Kullanıcı";
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
            this.bankaButton.Location = new System.Drawing.Point(420, 0);
            this.bankaButton.Name = "bankaButton";
            this.bankaButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bankaButton.Rotation = 0D;
            this.bankaButton.Size = new System.Drawing.Size(140, 56);
            this.bankaButton.TabIndex = 4;
            this.bankaButton.Text = "Banka Kurları";
            this.bankaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bankaButton.UseVisualStyleBackColor = false;
            this.bankaButton.Visible = false;
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
            this.kurlarButton.Location = new System.Drawing.Point(140, 0);
            this.kurlarButton.Name = "kurlarButton";
            this.kurlarButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kurlarButton.Rotation = 0D;
            this.kurlarButton.Size = new System.Drawing.Size(140, 56);
            this.kurlarButton.TabIndex = 2;
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
            this.muhasebeButton.Location = new System.Drawing.Point(280, 0);
            this.muhasebeButton.Name = "muhasebeButton";
            this.muhasebeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.muhasebeButton.Rotation = 0D;
            this.muhasebeButton.Size = new System.Drawing.Size(140, 56);
            this.muhasebeButton.TabIndex = 3;
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
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.girisYapPanel);
            this.mainPanel.Controls.Add(this.alisSatisMainPanel);
            this.mainPanel.Controls.Add(this.muhasebePanel);
            this.mainPanel.Controls.Add(this.kurlarPanel);
            this.mainPanel.Controls.Add(this.bankaKurlarPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 67);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(982, 486);
            this.mainPanel.TabIndex = 2;
            // 
            // girisYapPanel
            // 
            this.girisYapPanel.Controls.Add(this.kullaniciFormPanel);
            this.girisYapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.girisYapPanel.Location = new System.Drawing.Point(0, 0);
            this.girisYapPanel.Name = "girisYapPanel";
            this.girisYapPanel.Size = new System.Drawing.Size(982, 486);
            this.girisYapPanel.TabIndex = 20;
            // 
            // kullaniciFormPanel
            // 
            this.kullaniciFormPanel.Controls.Add(this.girisYapOrtalaPanel);
            this.kullaniciFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kullaniciFormPanel.Location = new System.Drawing.Point(0, 0);
            this.kullaniciFormPanel.Name = "kullaniciFormPanel";
            this.kullaniciFormPanel.Size = new System.Drawing.Size(982, 486);
            this.kullaniciFormPanel.TabIndex = 3;
            // 
            // girisYapOrtalaPanel
            // 
            this.girisYapOrtalaPanel.Controls.Add(this.kullaniciAdiLabel);
            this.girisYapOrtalaPanel.Controls.Add(this.TusPanel);
            this.girisYapOrtalaPanel.Controls.Add(this.sifreLabel);
            this.girisYapOrtalaPanel.Controls.Add(this.sifreGosterButton);
            this.girisYapOrtalaPanel.Controls.Add(this.kullaniciTextBox);
            this.girisYapOrtalaPanel.Controls.Add(this.sifreTextBox);
            this.girisYapOrtalaPanel.Location = new System.Drawing.Point(292, 142);
            this.girisYapOrtalaPanel.Name = "girisYapOrtalaPanel";
            this.girisYapOrtalaPanel.Size = new System.Drawing.Size(399, 155);
            this.girisYapOrtalaPanel.TabIndex = 10;
            // 
            // kullaniciAdiLabel
            // 
            this.kullaniciAdiLabel.AutoSize = true;
            this.kullaniciAdiLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdiLabel.Location = new System.Drawing.Point(5, 12);
            this.kullaniciAdiLabel.Name = "kullaniciAdiLabel";
            this.kullaniciAdiLabel.Size = new System.Drawing.Size(125, 28);
            this.kullaniciAdiLabel.TabIndex = 2;
            this.kullaniciAdiLabel.Text = "Kullanıcı Adı ";
            // 
            // TusPanel
            // 
            this.TusPanel.Controls.Add(this.girisButton);
            this.TusPanel.Controls.Add(this.ayarlarButton);
            this.TusPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TusPanel.Location = new System.Drawing.Point(0, 97);
            this.TusPanel.Name = "TusPanel";
            this.TusPanel.Size = new System.Drawing.Size(399, 58);
            this.TusPanel.TabIndex = 9;
            // 
            // girisButton
            // 
            this.girisButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.girisButton.FlatAppearance.BorderSize = 0;
            this.girisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.girisButton.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.girisButton.ForeColor = System.Drawing.Color.Snow;
            this.girisButton.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.girisButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.girisButton.IconSize = 30;
            this.girisButton.Location = new System.Drawing.Point(0, 12);
            this.girisButton.Name = "girisButton";
            this.girisButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.girisButton.Rotation = 0D;
            this.girisButton.Size = new System.Drawing.Size(192, 37);
            this.girisButton.TabIndex = 5;
            this.girisButton.Text = "Giriş";
            this.girisButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.girisButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.girisButton.UseVisualStyleBackColor = false;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
            // 
            // ayarlarButton
            // 
            this.ayarlarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.ayarlarButton.FlatAppearance.BorderSize = 0;
            this.ayarlarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ayarlarButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ayarlarButton.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ayarlarButton.ForeColor = System.Drawing.Color.Snow;
            this.ayarlarButton.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.ayarlarButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ayarlarButton.IconSize = 30;
            this.ayarlarButton.Location = new System.Drawing.Point(208, 12);
            this.ayarlarButton.Margin = new System.Windows.Forms.Padding(0);
            this.ayarlarButton.Name = "ayarlarButton";
            this.ayarlarButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ayarlarButton.Rotation = 0D;
            this.ayarlarButton.Size = new System.Drawing.Size(192, 37);
            this.ayarlarButton.TabIndex = 7;
            this.ayarlarButton.Text = "Ayarlar";
            this.ayarlarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ayarlarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ayarlarButton.UseVisualStyleBackColor = false;
            // 
            // sifreLabel
            // 
            this.sifreLabel.AutoSize = true;
            this.sifreLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreLabel.Location = new System.Drawing.Point(5, 56);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(51, 28);
            this.sifreLabel.TabIndex = 1;
            this.sifreLabel.Text = "Şifre";
            // 
            // sifreGosterButton
            // 
            this.sifreGosterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(143)))));
            this.sifreGosterButton.FlatAppearance.BorderSize = 0;
            this.sifreGosterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sifreGosterButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.sifreGosterButton.Font = new System.Drawing.Font("Corbel", 9F);
            this.sifreGosterButton.ForeColor = System.Drawing.Color.Snow;
            this.sifreGosterButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.sifreGosterButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.sifreGosterButton.IconSize = 25;
            this.sifreGosterButton.Location = new System.Drawing.Point(357, 53);
            this.sifreGosterButton.Name = "sifreGosterButton";
            this.sifreGosterButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sifreGosterButton.Rotation = 0D;
            this.sifreGosterButton.Size = new System.Drawing.Size(34, 34);
            this.sifreGosterButton.TabIndex = 8;
            this.sifreGosterButton.UseVisualStyleBackColor = false;
            this.sifreGosterButton.Click += new System.EventHandler(this.sifreGosterButton_Click);
            // 
            // kullaniciTextBox
            // 
            this.kullaniciTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.kullaniciTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciTextBox.Location = new System.Drawing.Point(168, 12);
            this.kullaniciTextBox.MaxLength = 30;
            this.kullaniciTextBox.Name = "kullaniciTextBox";
            this.kullaniciTextBox.Size = new System.Drawing.Size(224, 34);
            this.kullaniciTextBox.TabIndex = 3;
            this.kullaniciTextBox.TextChanged += new System.EventHandler(this.kullaniciTextBox_TextChanged);
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTextBox.Location = new System.Drawing.Point(168, 53);
            this.sifreTextBox.MaxLength = 30;
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.PasswordChar = '*';
            this.sifreTextBox.Size = new System.Drawing.Size(184, 34);
            this.sifreTextBox.TabIndex = 6;
            this.sifreTextBox.TextChanged += new System.EventHandler(this.sifreTextBox_TextChanged);
            // 
            // alisSatisMainPanel
            // 
            this.alisSatisMainPanel.Controls.Add(this.alisSatisPanel);
            this.alisSatisMainPanel.Controls.Add(this.bakiyePanel1);
            this.alisSatisMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alisSatisMainPanel.Location = new System.Drawing.Point(0, 0);
            this.alisSatisMainPanel.Name = "alisSatisMainPanel";
            this.alisSatisMainPanel.Size = new System.Drawing.Size(982, 486);
            this.alisSatisMainPanel.TabIndex = 3;
            this.alisSatisMainPanel.TabStop = true;
            this.alisSatisMainPanel.Visible = false;
            // 
            // alisSatisPanel
            // 
            this.alisSatisPanel.BackColor = System.Drawing.Color.LightGray;
            this.alisSatisPanel.Controls.Add(this.miktarLogo);
            this.alisSatisPanel.Controls.Add(this.karsilikLogo);
            this.alisSatisPanel.Controls.Add(this.karsilikLabel);
            this.alisSatisPanel.Controls.Add(this.karsilikDegerLabel);
            this.alisSatisPanel.Controls.Add(this.miktarLabel);
            this.alisSatisPanel.Controls.Add(this.kilitPanel);
            this.alisSatisPanel.Controls.Add(this.donusumPanel);
            this.alisSatisPanel.Controls.Add(this.alisverisMiktarTextBox);
            this.alisSatisPanel.Controls.Add(this.alisverisMiktarOndalikTextBox);
            this.alisSatisPanel.Controls.Add(this.noktaTextBox);
            this.alisSatisPanel.Controls.Add(this.islemTurucomboBox);
            this.alisSatisPanel.Controls.Add(this.dovizCinsicomboBox);
            this.alisSatisPanel.Controls.Add(this.tamamlaButton);
            this.alisSatisPanel.Controls.Add(this.yeniIslemButton);
            this.alisSatisPanel.Controls.Add(this.islemTuruLabel);
            this.alisSatisPanel.Controls.Add(this.dovizCinsiLabel);
            this.alisSatisPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.alisSatisPanel.Location = new System.Drawing.Point(0, 0);
            this.alisSatisPanel.Name = "alisSatisPanel";
            this.alisSatisPanel.Size = new System.Drawing.Size(491, 486);
            this.alisSatisPanel.TabIndex = 7;
            // 
            // miktarLogo
            // 
            this.miktarLogo.AutoSize = true;
            this.miktarLogo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.miktarLogo.Location = new System.Drawing.Point(141, 360);
            this.miktarLogo.Name = "miktarLogo";
            this.miktarLogo.Size = new System.Drawing.Size(0, 25);
            this.miktarLogo.TabIndex = 24;
            this.miktarLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // karsilikLogo
            // 
            this.karsilikLogo.AutoSize = true;
            this.karsilikLogo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.karsilikLogo.Location = new System.Drawing.Point(141, 314);
            this.karsilikLogo.Name = "karsilikLogo";
            this.karsilikLogo.Size = new System.Drawing.Size(0, 25);
            this.karsilikLogo.TabIndex = 23;
            this.karsilikLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // karsilikLabel
            // 
            this.karsilikLabel.AutoSize = true;
            this.karsilikLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.karsilikLabel.Location = new System.Drawing.Point(32, 316);
            this.karsilikLabel.Name = "karsilikLabel";
            this.karsilikLabel.Size = new System.Drawing.Size(74, 25);
            this.karsilikLabel.TabIndex = 22;
            this.karsilikLabel.Text = "Karşılık";
            // 
            // karsilikDegerLabel
            // 
            this.karsilikDegerLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.karsilikDegerLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.karsilikDegerLabel.Location = new System.Drawing.Point(172, 306);
            this.karsilikDegerLabel.Name = "karsilikDegerLabel";
            this.karsilikDegerLabel.Size = new System.Drawing.Size(91, 41);
            this.karsilikDegerLabel.TabIndex = 21;
            this.karsilikDegerLabel.Text = "Birim seç";
            this.karsilikDegerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // miktarLabel
            // 
            this.miktarLabel.AutoSize = true;
            this.miktarLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.miktarLabel.Location = new System.Drawing.Point(32, 363);
            this.miktarLabel.Name = "miktarLabel";
            this.miktarLabel.Size = new System.Drawing.Size(69, 25);
            this.miktarLabel.TabIndex = 12;
            this.miktarLabel.Text = "Miktar";
            // 
            // kilitPanel
            // 
            this.kilitPanel.Controls.Add(this.kilitleButton);
            this.kilitPanel.Controls.Add(this.geriSayimLabel);
            this.kilitPanel.Location = new System.Drawing.Point(177, 256);
            this.kilitPanel.Name = "kilitPanel";
            this.kilitPanel.Size = new System.Drawing.Size(142, 37);
            this.kilitPanel.TabIndex = 20;
            // 
            // kilitleButton
            // 
            this.kilitleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(143)))));
            this.kilitleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kilitleButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.kilitleButton.FlatAppearance.BorderSize = 0;
            this.kilitleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kilitleButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.kilitleButton.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kilitleButton.ForeColor = System.Drawing.Color.Snow;
            this.kilitleButton.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.kilitleButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.kilitleButton.IconSize = 25;
            this.kilitleButton.Location = new System.Drawing.Point(0, 0);
            this.kilitleButton.Name = "kilitleButton";
            this.kilitleButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kilitleButton.Rotation = 0D;
            this.kilitleButton.Size = new System.Drawing.Size(41, 37);
            this.kilitleButton.TabIndex = 17;
            this.kilitleButton.Tag = "Kullanıcı";
            this.kilitleButton.UseVisualStyleBackColor = false;
            this.kilitleButton.Click += new System.EventHandler(this.kilitleButton_Click);
            // 
            // geriSayimLabel
            // 
            this.geriSayimLabel.AutoSize = true;
            this.geriSayimLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.geriSayimLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriSayimLabel.Location = new System.Drawing.Point(117, 0);
            this.geriSayimLabel.Name = "geriSayimLabel";
            this.geriSayimLabel.Size = new System.Drawing.Size(25, 35);
            this.geriSayimLabel.TabIndex = 19;
            this.geriSayimLabel.Text = "-";
            this.geriSayimLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // donusumPanel
            // 
            this.donusumPanel.Controls.Add(this.resimOrtalaPanel);
            this.donusumPanel.Controls.Add(this.donusumPicBox);
            this.donusumPanel.Controls.Add(this.donusturLabel2);
            this.donusumPanel.Controls.Add(this.donusturLabel1);
            this.donusumPanel.Location = new System.Drawing.Point(3, 128);
            this.donusumPanel.Name = "donusumPanel";
            this.donusumPanel.Size = new System.Drawing.Size(485, 122);
            this.donusumPanel.TabIndex = 16;
            // 
            // resimOrtalaPanel
            // 
            this.resimOrtalaPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.resimOrtalaPanel.Location = new System.Drawing.Point(199, 0);
            this.resimOrtalaPanel.Name = "resimOrtalaPanel";
            this.resimOrtalaPanel.Size = new System.Drawing.Size(99, 18);
            this.resimOrtalaPanel.TabIndex = 16;
            // 
            // donusumPicBox
            // 
            this.donusumPicBox.BackColor = System.Drawing.Color.LightGray;
            this.donusumPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.donusumPicBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.donusumPicBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(143)))));
            this.donusumPicBox.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.donusumPicBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(143)))));
            this.donusumPicBox.IconSize = 98;
            this.donusumPicBox.Location = new System.Drawing.Point(199, 24);
            this.donusumPicBox.Name = "donusumPicBox";
            this.donusumPicBox.Size = new System.Drawing.Size(99, 98);
            this.donusumPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.donusumPicBox.TabIndex = 13;
            this.donusumPicBox.TabStop = false;
            // 
            // donusturLabel2
            // 
            this.donusturLabel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.donusturLabel2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.donusturLabel2.Location = new System.Drawing.Point(298, 0);
            this.donusturLabel2.Name = "donusturLabel2";
            this.donusturLabel2.Size = new System.Drawing.Size(187, 122);
            this.donusturLabel2.TabIndex = 15;
            this.donusturLabel2.Text = "Birim seç";
            this.donusturLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // donusturLabel1
            // 
            this.donusturLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.donusturLabel1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.donusturLabel1.Location = new System.Drawing.Point(0, 0);
            this.donusturLabel1.Name = "donusturLabel1";
            this.donusturLabel1.Size = new System.Drawing.Size(199, 122);
            this.donusturLabel1.TabIndex = 14;
            this.donusturLabel1.Text = "Birim seç";
            this.donusturLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alisverisMiktarTextBox
            // 
            this.alisverisMiktarTextBox.Enabled = false;
            this.alisverisMiktarTextBox.Font = new System.Drawing.Font("Corbel", 15F);
            this.alisverisMiktarTextBox.Location = new System.Drawing.Point(176, 353);
            this.alisverisMiktarTextBox.Margin = new System.Windows.Forms.Padding(50);
            this.alisverisMiktarTextBox.MaxLength = 4;
            this.alisverisMiktarTextBox.Name = "alisverisMiktarTextBox";
            this.alisverisMiktarTextBox.Size = new System.Drawing.Size(130, 38);
            this.alisverisMiktarTextBox.TabIndex = 10;
            this.alisverisMiktarTextBox.TextChanged += new System.EventHandler(this.alisverisMiktarTextBox_TextChanged);
            this.alisverisMiktarTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alisverisMiktarTextBox_KeyPress);
            // 
            // alisverisMiktarOndalikTextBox
            // 
            this.alisverisMiktarOndalikTextBox.Enabled = false;
            this.alisverisMiktarOndalikTextBox.Font = new System.Drawing.Font("Corbel", 15F);
            this.alisverisMiktarOndalikTextBox.Location = new System.Drawing.Point(324, 353);
            this.alisverisMiktarOndalikTextBox.Margin = new System.Windows.Forms.Padding(50);
            this.alisverisMiktarOndalikTextBox.MaxLength = 4;
            this.alisverisMiktarOndalikTextBox.Name = "alisverisMiktarOndalikTextBox";
            this.alisverisMiktarOndalikTextBox.Size = new System.Drawing.Size(130, 38);
            this.alisverisMiktarOndalikTextBox.TabIndex = 25;
            this.alisverisMiktarOndalikTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alisverisMiktarTextBox_KeyPress);
            // 
            // noktaTextBox
            // 
            this.noktaTextBox.AutoSize = true;
            this.noktaTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.noktaTextBox.Location = new System.Drawing.Point(307, 366);
            this.noktaTextBox.Name = "noktaTextBox";
            this.noktaTextBox.Size = new System.Drawing.Size(17, 25);
            this.noktaTextBox.TabIndex = 26;
            this.noktaTextBox.Text = ".";
            // 
            // islemTurucomboBox
            // 
            this.islemTurucomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.islemTurucomboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemTurucomboBox.FormattingEnabled = true;
            this.islemTurucomboBox.Location = new System.Drawing.Point(215, 69);
            this.islemTurucomboBox.Name = "islemTurucomboBox";
            this.islemTurucomboBox.Size = new System.Drawing.Size(239, 31);
            this.islemTurucomboBox.TabIndex = 7;
            this.islemTurucomboBox.SelectedIndexChanged += new System.EventHandler(this.islemTurucomboBox_SelectedIndexChanged);
            // 
            // dovizCinsicomboBox
            // 
            this.dovizCinsicomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dovizCinsicomboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dovizCinsicomboBox.FormattingEnabled = true;
            this.dovizCinsicomboBox.Location = new System.Drawing.Point(215, 31);
            this.dovizCinsicomboBox.Name = "dovizCinsicomboBox";
            this.dovizCinsicomboBox.Size = new System.Drawing.Size(239, 31);
            this.dovizCinsicomboBox.TabIndex = 6;
            this.dovizCinsicomboBox.SelectedIndexChanged += new System.EventHandler(this.dovizCinsicomboBox_SelectedIndexChanged);
            // 
            // tamamlaButton
            // 
            this.tamamlaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.tamamlaButton.Enabled = false;
            this.tamamlaButton.FlatAppearance.BorderSize = 0;
            this.tamamlaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tamamlaButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.tamamlaButton.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.tamamlaButton.ForeColor = System.Drawing.Color.Snow;
            this.tamamlaButton.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.tamamlaButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.tamamlaButton.IconSize = 30;
            this.tamamlaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tamamlaButton.Location = new System.Drawing.Point(44, 428);
            this.tamamlaButton.Margin = new System.Windows.Forms.Padding(0);
            this.tamamlaButton.Name = "tamamlaButton";
            this.tamamlaButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tamamlaButton.Rotation = 0D;
            this.tamamlaButton.Size = new System.Drawing.Size(192, 37);
            this.tamamlaButton.TabIndex = 5;
            this.tamamlaButton.Text = "Tamamla";
            this.tamamlaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tamamlaButton.UseVisualStyleBackColor = false;
            this.tamamlaButton.Click += new System.EventHandler(this.tamamlaButton_Click);
            // 
            // yeniIslemButton
            // 
            this.yeniIslemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.yeniIslemButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.yeniIslemButton.FlatAppearance.BorderSize = 0;
            this.yeniIslemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yeniIslemButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.yeniIslemButton.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.yeniIslemButton.ForeColor = System.Drawing.Color.Snow;
            this.yeniIslemButton.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.yeniIslemButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.yeniIslemButton.IconSize = 30;
            this.yeniIslemButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.yeniIslemButton.Location = new System.Drawing.Point(249, 428);
            this.yeniIslemButton.Margin = new System.Windows.Forms.Padding(0);
            this.yeniIslemButton.Name = "yeniIslemButton";
            this.yeniIslemButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.yeniIslemButton.Rotation = 0D;
            this.yeniIslemButton.Size = new System.Drawing.Size(192, 37);
            this.yeniIslemButton.TabIndex = 7;
            this.yeniIslemButton.Text = "Yeni İşlem";
            this.yeniIslemButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.yeniIslemButton.UseVisualStyleBackColor = false;
            this.yeniIslemButton.Click += new System.EventHandler(this.yeniIslemButton_Click);
            // 
            // islemTuruLabel
            // 
            this.islemTuruLabel.AutoSize = true;
            this.islemTuruLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemTuruLabel.Location = new System.Drawing.Point(31, 72);
            this.islemTuruLabel.Name = "islemTuruLabel";
            this.islemTuruLabel.Size = new System.Drawing.Size(101, 25);
            this.islemTuruLabel.TabIndex = 9;
            this.islemTuruLabel.Text = "İşlem Türü";
            // 
            // dovizCinsiLabel
            // 
            this.dovizCinsiLabel.AutoSize = true;
            this.dovizCinsiLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dovizCinsiLabel.Location = new System.Drawing.Point(31, 34);
            this.dovizCinsiLabel.Name = "dovizCinsiLabel";
            this.dovizCinsiLabel.Size = new System.Drawing.Size(107, 25);
            this.dovizCinsiLabel.TabIndex = 0;
            this.dovizCinsiLabel.Text = "Döviz Cinsi";
            // 
            // bakiyePanel1
            // 
            this.bakiyePanel1.BackColor = System.Drawing.Color.LightGray;
            this.bakiyePanel1.Controls.Add(this.kurlarDataGridView);
            this.bakiyePanel1.Controls.Add(this.alisverisTest);
            this.bakiyePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bakiyePanel1.Location = new System.Drawing.Point(491, 0);
            this.bakiyePanel1.Name = "bakiyePanel1";
            this.bakiyePanel1.Size = new System.Drawing.Size(491, 486);
            this.bakiyePanel1.TabIndex = 6;
            // 
            // kurlarDataGridView
            // 
            this.kurlarDataGridView.AllowUserToAddRows = false;
            this.kurlarDataGridView.AllowUserToDeleteRows = false;
            this.kurlarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kurlarDataGridView.Location = new System.Drawing.Point(9, 6);
            this.kurlarDataGridView.Name = "kurlarDataGridView";
            this.kurlarDataGridView.ReadOnly = true;
            this.kurlarDataGridView.RowHeadersWidth = 51;
            this.kurlarDataGridView.RowTemplate.Height = 24;
            this.kurlarDataGridView.Size = new System.Drawing.Size(470, 291);
            this.kurlarDataGridView.TabIndex = 28;
            // 
            // alisverisTest
            // 
            this.alisverisTest.AutoSize = true;
            this.alisverisTest.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alisverisTest.Location = new System.Drawing.Point(153, 421);
            this.alisverisTest.Name = "alisverisTest";
            this.alisverisTest.Size = new System.Drawing.Size(69, 25);
            this.alisverisTest.TabIndex = 27;
            this.alisverisTest.Text = "Miktar";
            // 
            // muhasebePanel
            // 
            this.muhasebePanel.Controls.Add(this.muhasebeDataGridView);
            this.muhasebePanel.Controls.Add(this.muhasebeLabel);
            this.muhasebePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.muhasebePanel.Location = new System.Drawing.Point(0, 0);
            this.muhasebePanel.Name = "muhasebePanel";
            this.muhasebePanel.Size = new System.Drawing.Size(982, 486);
            this.muhasebePanel.TabIndex = 4;
            // 
            // muhasebeDataGridView
            // 
            this.muhasebeDataGridView.AllowUserToAddRows = false;
            this.muhasebeDataGridView.AllowUserToDeleteRows = false;
            this.muhasebeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.muhasebeDataGridView.Location = new System.Drawing.Point(12, 6);
            this.muhasebeDataGridView.Name = "muhasebeDataGridView";
            this.muhasebeDataGridView.ReadOnly = true;
            this.muhasebeDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.muhasebeDataGridView.RowTemplate.Height = 24;
            this.muhasebeDataGridView.Size = new System.Drawing.Size(958, 354);
            this.muhasebeDataGridView.TabIndex = 1;
            // 
            // muhasebeLabel
            // 
            this.muhasebeLabel.AutoSize = true;
            this.muhasebeLabel.Location = new System.Drawing.Point(233, 373);
            this.muhasebeLabel.Name = "muhasebeLabel";
            this.muhasebeLabel.Size = new System.Drawing.Size(104, 18);
            this.muhasebeLabel.TabIndex = 0;
            this.muhasebeLabel.Text = "muhasebeLabel";
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
            this.kurlarLabel.Location = new System.Drawing.Point(115, 363);
            this.kurlarLabel.Name = "kurlarLabel";
            this.kurlarLabel.Size = new System.Drawing.Size(45, 18);
            this.kurlarLabel.TabIndex = 0;
            this.kurlarLabel.Text = "Kurlar";
            // 
            // bankaKurlarPanel
            // 
            this.bankaKurlarPanel.Controls.Add(this.dataGridView1);
            this.bankaKurlarPanel.Controls.Add(this.label1);
            this.bankaKurlarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bankaKurlarPanel.Location = new System.Drawing.Point(0, 0);
            this.bankaKurlarPanel.Name = "bankaKurlarPanel";
            this.bankaKurlarPanel.Size = new System.Drawing.Size(982, 486);
            this.bankaKurlarPanel.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(958, 354);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banka Kurları";
            // 
            // alısverisBindingSource
            // 
            this.alısverisBindingSource.DataMember = "alısveris";
            // 
            // islemGeriSayim
            // 
            this.islemGeriSayim.Interval = 1000;
            this.islemGeriSayim.Tick += new System.EventHandler(this.islemGeriSayim_Tick);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.TopPanel.ResumeLayout(false);
            this.kullaniciBilgiPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.girisYapPanel.ResumeLayout(false);
            this.kullaniciFormPanel.ResumeLayout(false);
            this.girisYapOrtalaPanel.ResumeLayout(false);
            this.girisYapOrtalaPanel.PerformLayout();
            this.TusPanel.ResumeLayout(false);
            this.alisSatisMainPanel.ResumeLayout(false);
            this.alisSatisPanel.ResumeLayout(false);
            this.alisSatisPanel.PerformLayout();
            this.kilitPanel.ResumeLayout(false);
            this.kilitPanel.PerformLayout();
            this.donusumPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.donusumPicBox)).EndInit();
            this.bakiyePanel1.ResumeLayout(false);
            this.bakiyePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kurlarDataGridView)).EndInit();
            this.muhasebePanel.ResumeLayout(false);
            this.muhasebePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeDataGridView)).EndInit();
            this.kurlarPanel.ResumeLayout(false);
            this.kurlarPanel.PerformLayout();
            this.bankaKurlarPanel.ResumeLayout(false);
            this.bankaKurlarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alısverisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dovizotomasyonDataSet3BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private void AlisSatisButton_MouseEnter(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private FontAwesome.Sharp.IconButton alisSatisButton;
        private System.Windows.Forms.Panel TopBPanel;
        private FontAwesome.Sharp.IconButton bankaButton;
        private FontAwesome.Sharp.IconButton kurlarButton;
        private FontAwesome.Sharp.IconButton muhasebeButton;
        private FontAwesome.Sharp.IconButton kullaniciButon;
        private System.Windows.Forms.Panel alisSatisMainPanel;
        private System.Windows.Forms.Panel muhasebePanel;
        private System.Windows.Forms.Label muhasebeLabel;
        private System.Windows.Forms.Label dovizCinsiLabel;
        private System.Windows.Forms.Panel bankaKurlarPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel kurlarPanel;
        private System.Windows.Forms.Label kurlarLabel;
        private System.Windows.Forms.Panel kullaniciBilgiPanel;
        private FontAwesome.Sharp.IconButton tamamlaButton;
        private System.Windows.Forms.Panel bakiyePanel1;
        private FontAwesome.Sharp.IconButton yeniIslemButton;
        private System.Windows.Forms.Label islemTuruLabel;
        private System.Windows.Forms.Panel alisSatisPanel;
        private System.Windows.Forms.ComboBox dovizCinsicomboBox;
        private System.Windows.Forms.ComboBox islemTurucomboBox;
        private System.Windows.Forms.TextBox alisverisMiktarTextBox;
        private System.Windows.Forms.Label miktarLabel;
        private FontAwesome.Sharp.IconPictureBox donusumPicBox;
        private System.Windows.Forms.Label donusturLabel2;
        private System.Windows.Forms.Label donusturLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel donusumPanel;
        private System.Windows.Forms.Panel resimOrtalaPanel;
        private FontAwesome.Sharp.IconButton kilitleButton;
        private System.Windows.Forms.Timer islemGeriSayim;
        private System.Windows.Forms.Label geriSayimLabel;
        public System.Windows.Forms.Panel mainPanel;
        public System.Windows.Forms.Panel girisYapPanel;
        public System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel kilitPanel;
        private System.Windows.Forms.Label karsilikDegerLabel;
        private System.Windows.Forms.Label karsilikLabel;
        private System.Windows.Forms.BindingSource alısverisBindingSource;
        private System.Windows.Forms.Panel kullaniciFormPanel;
        private System.Windows.Forms.Panel girisYapOrtalaPanel;
        private System.Windows.Forms.Panel TusPanel;
        private FontAwesome.Sharp.IconButton girisButton;
        private FontAwesome.Sharp.IconButton ayarlarButton;
        private FontAwesome.Sharp.IconButton sifreGosterButton;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.TextBox kullaniciTextBox;
        private System.Windows.Forms.Label kullaniciAdiLabel;
        private System.Windows.Forms.Label sifreLabel;
        private System.Windows.Forms.DataGridView muhasebeDataGridView;
        private System.Windows.Forms.BindingSource dovizotomasyonDataSet3BindingSource;
        public System.Windows.Forms.Label miktarLogo;
        public System.Windows.Forms.Label karsilikLogo;
        private System.Windows.Forms.Label kullaniciAdiTopLabel;
        private System.Windows.Forms.TextBox alisverisMiktarOndalikTextBox;
        private System.Windows.Forms.Label noktaTextBox;
        private System.Windows.Forms.Label alisverisTest;
        private System.Windows.Forms.DataGridView kurlarDataGridView;
    }
}

