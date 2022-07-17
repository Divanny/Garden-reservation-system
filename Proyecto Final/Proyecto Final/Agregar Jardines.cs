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
    public partial class Agregar_Jardines : Form
    {
        int id;
        string nombre, apellido;
        public Agregar_Jardines(int ID, string Nombre, string Apellido)
        {
            InitializeComponent();
            int id = ID;
            string nombre = Nombre;
            string apellido = Apellido;

            btn_Agregar.Enabled = true;
            btn_Foto.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Modificar.Enabled = false;
            btn_Cancelar.Enabled = false;

            gb_jardines.Enabled = false;
            dgv_jardines.ReadOnly = true;
        }
        int m, mx, my;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_Descripcion_Del_Jardin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Agregar_Jardines_Load(object sender, EventArgs e)
        {

        }

        private void tbx_Nombre_Del_Jardin_Enter_1(object sender, EventArgs e)
        {
            if (tbx_Nombre_Del_Jardin.Text == "Nombre del Jardin")
            {
                tbx_Nombre_Del_Jardin.Text = "";
                tbx_Nombre_Del_Jardin.ForeColor = Color.White;
            }
        }

        private void tbx_Nombre_Del_Jardin_Leave_1(object sender, EventArgs e)
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

        private void tbx_Descripcion_Del_Jardin_Enter_1(object sender, EventArgs e)
        {
            if (tbx_Descripcion_Del_Jardin.Text == "Descripcion del Jardin")
            {
                tbx_Descripcion_Del_Jardin.Text = "";
                tbx_Descripcion_Del_Jardin.ForeColor = Color.White;
            }
        }

        private void tbx_Descripcion_Del_Jardin_Leave_1(object sender, EventArgs e)
        {
            if (tbx_Descripcion_Del_Jardin.Text == "")
            {
                tbx_Descripcion_Del_Jardin.Text = "Descripcion del Jardin";
                tbx_Descripcion_Del_Jardin.ForeColor = Color.White;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbx_Longitud_Del_Jardin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            btn_Agregar.Enabled = true;
            btn_Foto.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Eliminar.Enabled = true;
            btn_Modificar.Enabled = true;
            btn_Cancelar.Enabled = false;

            gb_jardines.Enabled = false;

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            btn_Agregar.Enabled = false;
            btn_Foto.Enabled = true;
            btn_Guardar.Enabled = true;
            btn_Eliminar.Enabled = true;
            btn_Modificar.Enabled = true;
            btn_Cancelar.Enabled = true;

            gb_jardines.Enabled = true;
            dgv_jardines.ReadOnly = false;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            btn_Agregar.Enabled = true;
            btn_Foto.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Eliminar.Enabled = true;
            btn_Modificar.Enabled = true;
            btn_Cancelar.Enabled = false;

            dgv_jardines.ReadOnly = false;

            MessageBox.Show("El jardín ha sido agregado exitosamente");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Form administrador = new Administrador(id, nombre, apellido);
            administrador.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pbx_Agregar_Foto_Click(object sender, EventArgs e)
        {

        }

        private void dtp_Fecha_De_Apertura_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}
