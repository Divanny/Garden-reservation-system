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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        int m, mx, my;
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Jardin_Click(object sender, EventArgs e)
        {
            var OpenAgregarJardines = new Agregar_Jardines();
            OpenAgregarJardines.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var openModificarCitas = new Modificar_Citas();
            openModificarCitas.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;

        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Consultar_Jardines_Click(object sender, EventArgs e)
        {
            var openVerDIsponibilidad = new Ver_Disponibilidad();
            openVerDIsponibilidad.Show();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }
    }
}
