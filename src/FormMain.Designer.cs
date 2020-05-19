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
            this.kullaniciBilgiPanel = new System.Windows.Forms.Panel();
            this.kullaniciButon = new FontAwesome.Sharp.IconButton();
            this.bankaButton = new FontAwesome.Sharp.IconButton();
            this.kurlarButton = new FontAwesome.Sharp.IconButton();
            this.muhasebeButton = new FontAwesome.Sharp.IconButton();
            this.alisSatisButton = new FontAwesome.Sharp.IconButton();
            this.TopBPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.alisSatisMainPanel = new System.Windows.Forms.Panel();
            this.alisSatisPanel = new System.Windows.Forms.Panel();
            this.donusumPicBox = new FontAwesome.Sharp.IconPictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.alisverisMiktarTextBox = new System.Windows.Forms.TextBox();
            this.islemTurucomboBox = new System.Windows.Forms.ComboBox();
            this.dovizCinsicomboBox = new System.Windows.Forms.ComboBox();
            this.tamamlaButton = new FontAwesome.Sharp.IconButton();
            this.yeniIslemButton = new FontAwesome.Sharp.IconButton();
            this.islemTuruLabel = new System.Windows.Forms.Label();
            this.dovizCinsiLabel = new System.Windows.Forms.Label();
            this.bakiyePanel1 = new System.Windows.Forms.Panel();
            this.kurlarPanel = new System.Windows.Forms.Panel();
            this.kurlarLabel = new System.Windows.Forms.Label();
            this.bankaKurlarPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.muhasebePanel = new System.Windows.Forms.Panel();
            this.muhasebeLabel = new System.Windows.Forms.Label();
            this.donusturLabel1 = new System.Windows.Forms.Label();
            this.donusturLabel2 = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.kullaniciBilgiPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.alisSatisMainPanel.SuspendLayout();
            this.alisSatisPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donusumPicBox)).BeginInit();
            this.kurlarPanel.SuspendLayout();
            this.bankaKurlarPanel.SuspendLayout();
            this.muhasebePanel.SuspendLayout();
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
            // 
            // kullaniciBilgiPanel
            // 
            this.kullaniciBilgiPanel.Controls.Add(this.kullaniciButon);
            this.kullaniciBilgiPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.kullaniciBilgiPanel.Location = new System.Drawing.Point(727, 0);
            this.kullaniciBilgiPanel.Name = "kullaniciBilgiPanel";
            this.kullaniciBilgiPanel.Size = new System.Drawing.Size(255, 56);
            this.kullaniciBilgiPanel.TabIndex = 2;
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
            this.mainPanel.Controls.Add(this.alisSatisMainPanel);
            this.mainPanel.Controls.Add(this.kurlarPanel);
            this.mainPanel.Controls.Add(this.bankaKurlarPanel);
            this.mainPanel.Controls.Add(this.muhasebePanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 67);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(982, 486);
            this.mainPanel.TabIndex = 2;
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
            // 
            // alisSatisPanel
            // 
            this.alisSatisPanel.BackColor = System.Drawing.Color.LightGray;
            this.alisSatisPanel.Controls.Add(this.donusturLabel2);
            this.alisSatisPanel.Controls.Add(this.donusturLabel1);
            this.alisSatisPanel.Controls.Add(this.donusumPicBox);
            this.alisSatisPanel.Controls.Add(this.label5);
            this.alisSatisPanel.Controls.Add(this.alisverisMiktarTextBox);
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
            // donusumPicBox
            // 
            this.donusumPicBox.BackColor = System.Drawing.Color.LightGray;
            this.donusumPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.donusumPicBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(143)))));
            this.donusumPicBox.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            this.donusumPicBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(143)))));
            this.donusumPicBox.IconSize = 120;
            this.donusumPicBox.Location = new System.Drawing.Point(186, 193);
            this.donusumPicBox.Name = "donusumPicBox";
            this.donusumPicBox.Size = new System.Drawing.Size(120, 120);
            this.donusumPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.donusumPicBox.TabIndex = 13;
            this.donusumPicBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(32, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Miktar";
            // 
            // alisverisMiktarTextBox
            // 
            this.alisverisMiktarTextBox.Font = new System.Drawing.Font("Corbel", 15F);
            this.alisverisMiktarTextBox.Location = new System.Drawing.Point(176, 353);
            this.alisverisMiktarTextBox.Margin = new System.Windows.Forms.Padding(50);
            this.alisverisMiktarTextBox.Name = "alisverisMiktarTextBox";
            this.alisverisMiktarTextBox.Size = new System.Drawing.Size(278, 38);
            this.alisverisMiktarTextBox.TabIndex = 10;
            this.alisverisMiktarTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alisverisMiktarTextBox_KeyPress);
            // 
            // islemTurucomboBox
            // 
            this.islemTurucomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.islemTurucomboBox.Font = new System.Drawing.Font("Corbel", 10F);
            this.islemTurucomboBox.FormattingEnabled = true;
            this.islemTurucomboBox.Items.AddRange(new object[] {
            "Alış",
            "Satış"});
            this.islemTurucomboBox.Location = new System.Drawing.Point(215, 69);
            this.islemTurucomboBox.Name = "islemTurucomboBox";
            this.islemTurucomboBox.Size = new System.Drawing.Size(239, 29);
            this.islemTurucomboBox.TabIndex = 7;
            // 
            // dovizCinsicomboBox
            // 
            this.dovizCinsicomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dovizCinsicomboBox.Font = new System.Drawing.Font("Corbel", 10F);
            this.dovizCinsicomboBox.FormattingEnabled = true;
            this.dovizCinsicomboBox.Items.AddRange(new object[] {
            "USD - Amerikan Doları",
            "EUR - Euro",
            "GBP - İngiliz Sterlini"});
            this.dovizCinsicomboBox.Location = new System.Drawing.Point(215, 31);
            this.dovizCinsicomboBox.Name = "dovizCinsicomboBox";
            this.dovizCinsicomboBox.Size = new System.Drawing.Size(239, 29);
            this.dovizCinsicomboBox.TabIndex = 6;
            // 
            // tamamlaButton
            // 
            this.tamamlaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.tamamlaButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.tamamlaButton.FlatAppearance.BorderSize = 0;
            this.tamamlaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tamamlaButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.tamamlaButton.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.tamamlaButton.Click += new System.EventHandler(this.yeniIslemButton_Click);
            // 
            // yeniIslemButton
            // 
            this.yeniIslemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.yeniIslemButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.yeniIslemButton.FlatAppearance.BorderSize = 0;
            this.yeniIslemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yeniIslemButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.yeniIslemButton.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.yeniIslemButton.Click += new System.EventHandler(this.yeniIslemButton_Click_1);
            // 
            // islemTuruLabel
            // 
            this.islemTuruLabel.AutoSize = true;
            this.islemTuruLabel.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemTuruLabel.Location = new System.Drawing.Point(31, 72);
            this.islemTuruLabel.Name = "islemTuruLabel";
            this.islemTuruLabel.Size = new System.Drawing.Size(94, 23);
            this.islemTuruLabel.TabIndex = 9;
            this.islemTuruLabel.Text = "İşlem Türü";
            // 
            // dovizCinsiLabel
            // 
            this.dovizCinsiLabel.AutoSize = true;
            this.dovizCinsiLabel.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dovizCinsiLabel.Location = new System.Drawing.Point(31, 34);
            this.dovizCinsiLabel.Name = "dovizCinsiLabel";
            this.dovizCinsiLabel.Size = new System.Drawing.Size(100, 23);
            this.dovizCinsiLabel.TabIndex = 0;
            this.dovizCinsiLabel.Text = "Döviz Cinsi";
            // 
            // bakiyePanel1
            // 
            this.bakiyePanel1.BackColor = System.Drawing.Color.LightGray;
            this.bakiyePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bakiyePanel1.Location = new System.Drawing.Point(491, 0);
            this.bakiyePanel1.Name = "bakiyePanel1";
            this.bakiyePanel1.Size = new System.Drawing.Size(491, 486);
            this.bakiyePanel1.TabIndex = 6;
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
            // donusturLabel1
            // 
            this.donusturLabel1.AutoSize = true;
            this.donusturLabel1.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.donusturLabel1.Location = new System.Drawing.Point(66, 234);
            this.donusturLabel1.Name = "donusturLabel1";
            this.donusturLabel1.Size = new System.Drawing.Size(94, 23);
            this.donusturLabel1.TabIndex = 14;
            this.donusturLabel1.Text = "donustur1";
            // 
            // donusturLabel2
            // 
            this.donusturLabel2.AutoSize = true;
            this.donusturLabel2.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.donusturLabel2.Location = new System.Drawing.Point(326, 234);
            this.donusturLabel2.Name = "donusturLabel2";
            this.donusturLabel2.Size = new System.Drawing.Size(94, 23);
            this.donusturLabel2.TabIndex = 15;
            this.donusturLabel2.Text = "donustur2";
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
            this.kullaniciBilgiPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.alisSatisMainPanel.ResumeLayout(false);
            this.alisSatisPanel.ResumeLayout(false);
            this.alisSatisPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donusumPicBox)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconPictureBox donusumPicBox;
        private System.Windows.Forms.Label donusturLabel2;
        private System.Windows.Forms.Label donusturLabel1;
    }
}

