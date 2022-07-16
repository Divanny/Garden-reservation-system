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
    public partial class Hacer_Reserva : Form
    {
        public Hacer_Reserva()
        {
            InitializeComponent();
        }
        int m, mx, my;

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dtp_Fecha_De_Apertura_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbx_Descripcion_Del_Jardin_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_Longitud_Del_Jardin_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_Nombre_Del_Jardin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
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

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Hacer_Reserva_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void tbx_Nombre_Del_Jardin_Enter(object sender, EventArgs e)
        {
            if (tbx_Nombre_Del_Jardin.Text == "Nombre del Jardin")
            {
                tbx_Nombre_Del_Jardin.Text = "";
                tbx_Nombre_Del_Jardin.ForeColor = Color.White;
            }
        }

        private void tbx_Nombre_Del_Jardin_Leave(object sender, EventArgs e)
        {
            if (tbx_Nombre_Del_Jardin.Text == "")
            {
                tbx_Nombre_Del_Jardin.Text = "Nombre del Jardin";
                tbx_Nombre_Del_Jardin.ForeColor = Color.White;
            }
        }

        private void tbx_Longitud_Del_Jardin_Enter(object sender, EventArgs e)
        {
            if (tbx_Longitud_Del_Jardin.Text == "Longitud del Jardin")
            {
                tbx_Longitud_Del_Jardin.Text = "";
                tbx_Longitud_Del_Jardin.ForeColor = Color.White;
            }
        }

        private void tbx_Longitud_Del_Jardin_Leave(object sender, EventArgs e)
        {
            if (tbx_Longitud_Del_Jardin.Text == "")
            {
                tbx_Longitud_Del_Jardin.Text = "Longitud del Jardin";
                tbx_Longitud_Del_Jardin.ForeColor = Color.White;
            }
        }

        private void tbx_Descripcion_Del_Jardin_Enter(object sender, EventArgs e)
        {
            if (tbx_Descripcion_Del_Jardin.Text == "Descripcion del Jardin")
            {
                tbx_Descripcion_Del_Jardin.Text = "";
                tbx_Descripcion_Del_Jardin.ForeColor = Color.White;
            }
        }

        private void tbx_Descripcion_Del_Jardin_Leave(object sender, EventArgs e)
        {
            if (tbx_Descripcion_Del_Jardin.Text == "")
            {
                tbx_Descripcion_Del_Jardin.Text = "Descripcion del Jardin";
                tbx_Descripcion_Del_Jardin.ForeColor = Color.White;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbx_Hora_De_Inicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void cbx_Cantidad_De_Personas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbx_Hora_De_Cierre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}
