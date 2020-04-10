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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.bankaButton = new FontAwesome.Sharp.IconButton();
            this.kurlarButton = new FontAwesome.Sharp.IconButton();
            this.muhasebeButton = new FontAwesome.Sharp.IconButton();
            this.alisSatisButton = new FontAwesome.Sharp.IconButton();
            this.TopBPanel = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Gainsboro;
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
            this.bankaButton.Location = new System.Drawing.Point(424, 0);
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
            this.kurlarButton.Location = new System.Drawing.Point(283, 0);
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
            this.muhasebeButton.Location = new System.Drawing.Point(142, 0);
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
            this.alisSatisButton.Location = new System.Drawing.Point(1, 0);
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
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 73);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(958, 300);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.chart1);
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

