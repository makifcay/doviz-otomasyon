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
        private void ıconButton1_Click(object sender, EventArgs e)
        {

        }

        private void ıconButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            TopBPanel.BackColor = System.Drawing.Color.FromArgb(27, 79, 143); // 27; 79; 143
        }

    }
}
