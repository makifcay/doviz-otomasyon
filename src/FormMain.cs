﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FontAwesome;

using LiveCharts;
using LiveCharts.Wpf;

namespace DovizOtomasyon
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();


            // Form

            // ControlBox'u kaldır.
            //this.Text = string.Empty;
            //this.ControlBox = false;
            //this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void alisSatisButton_Click(object sender, EventArgs e)
        {
            allTopButtons_Default();
            allMainPanels_Invisible();
            alisSatisMainPanel.Visible = true;

            //TopBPanel.BackColor = System.Drawing.Color.FromArgb(255, 0, 0); // 27; 79; 143
            alisSatisButton.BackColor = System.Drawing.Color.FromArgb(105, 157, 240);//105, 157, 240
            //alisSatisButton.BackColor = System.Drawing.Color.FromArgb(255, 0, 0);//105, 157, 240
            //alisSatisButton.IconColor = System.Drawing.Color.Gold;
        }

        private void muhasebeButton_Click(object sender, EventArgs e)
        {
            allTopButtons_Default();
            allMainPanels_Invisible();
            muhasebePanel.Visible = true;
            TopBPanel.BackColor = System.Drawing.Color.FromArgb(105, 157, 240); // 27; 79; 143
            muhasebeButton.BackColor = System.Drawing.Color.FromArgb(105, 157, 240);//105, 157, 240
        }

        private void kurlarButton_Click(object sender, EventArgs e)
        {
            allTopButtons_Default();
            allMainPanels_Invisible();
            kurlarPanel.Visible = true;

            TopBPanel.BackColor = System.Drawing.Color.FromArgb(105, 157, 240); // 27; 79; 143
            kurlarButton.BackColor = System.Drawing.Color.FromArgb(105, 157, 240);//105, 157, 240
        }

        private void bankaButton_Click(object sender, EventArgs e)
        {
            allTopButtons_Default();
            allMainPanels_Invisible();
            bankaKurlarPanel.Visible = true;

            TopBPanel.BackColor = System.Drawing.Color.FromArgb(105, 157, 240); // 27; 79; 143
            bankaButton.BackColor = System.Drawing.Color.FromArgb(105, 157, 240);//105, 157, 240
        }

        // Tüm butonların biçimlendirmelerini sıfırla
        private void allTopButtons_Default()
        {
            alisSatisButton.BackColor = System.Drawing.Color.FromArgb(27, 79, 143);//27; 79; 143
            muhasebeButton.BackColor = System.Drawing.Color.FromArgb(27, 79, 143);//27; 79; 143
            kurlarButton.BackColor = System.Drawing.Color.FromArgb(27, 79, 143);//27; 79; 143
            bankaButton.BackColor = System.Drawing.Color.FromArgb(27, 79, 143);

            alisSatisButton.IconColor = System.Drawing.Color.WhiteSmoke;
        }

        // Tüm ekranları kapat
        private void allMainPanels_Invisible()
        {
            alisSatisMainPanel.Visible = false;
            muhasebePanel.Visible = false;
            kurlarPanel.Visible = false;
            bankaKurlarPanel.Visible = false;
        }

        private void kullaniciButon_Click(object sender, EventArgs e)
        {
            Form kullanici = new kullanici();
            kullanici.ShowDialog();
        }


        // Eğer tamamlanmamış bir form doluysa kaydetmeden çıkılacak uyarı penceresi gelecek
        private void yeniIslemButton_Click(object sender, EventArgs e)
        {

        }


        private void yeniIslemButton_Click_1(object sender, EventArgs e)
        {

        }

        private void alisverisMiktarTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            //
            // TextBox'a sadece sayı yazılabilmesi ve tek bir nokta kullanılması için yapılan kontroller
            //

            // Anlık tuşlanan karakteri tutan değişken
            char ch = e.KeyChar;

            if (ch == 46 && alisverisMiktarTextBox.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            // ASCII'de 46 = '.', 8 = backspace
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
