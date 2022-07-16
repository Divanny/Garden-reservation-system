using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class Ver_Reservaciones : Form
    {
        public Ver_Reservaciones()
        {
            InitializeComponent();
        }
        int m, mx, my;
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Ver_Reservaciones_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;

        }
    
    }
}
