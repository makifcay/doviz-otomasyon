using System;
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
            TopBPanel.BackColor = System.Drawing.Color.FromArgb(255, 0, 0); // 27; 79; 143

            alisSatisButton.BackColor = System.Drawing.Color.FromArgb(255, 0, 0);//105, 157, 240
            alisSatisButton.IconColor = System.Drawing.Color.Gold;
        }

        private void muhasebeButton_Click(object sender, EventArgs e)
        {
            allTopButtons_Default();
            TopBPanel.BackColor = System.Drawing.Color.FromArgb(105, 157, 240); // 27; 79; 143
            muhasebeButton.BackColor = System.Drawing.Color.FromArgb(105, 157, 240);//105, 157, 240
        }

        private void kurlarButton_Click(object sender, EventArgs e)
        {
            allTopButtons_Default();
            TopBPanel.BackColor = System.Drawing.Color.FromArgb(105, 157, 240); // 27; 79; 143
            kurlarButton.BackColor = System.Drawing.Color.FromArgb(105, 157, 240);//105, 157, 240
        }

        private void bankaButton_Click(object sender, EventArgs e)
        {
            allTopButtons_Default();
            TopBPanel.BackColor = System.Drawing.Color.FromArgb(105, 157, 240); // 27; 79; 143
            bankaButton.BackColor = System.Drawing.Color.FromArgb(105, 157, 240);//105, 157, 240
        }

        //Tüm butonları sıfırla
        private void allTopButtons_Default()
        {
            alisSatisButton.BackColor = System.Drawing.Color.FromArgb(27, 79, 143);//27; 79; 143
            muhasebeButton.BackColor = System.Drawing.Color.FromArgb(27, 79, 143);//27; 79; 143
            kurlarButton.BackColor = System.Drawing.Color.FromArgb(27, 79, 143);//27; 79; 143
            bankaButton.BackColor = System.Drawing.Color.FromArgb(27, 79, 143);

            alisSatisButton.IconColor = System.Drawing.Color.WhiteSmoke;
        }

    }
}
