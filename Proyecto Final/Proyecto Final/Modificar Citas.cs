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
    public partial class Modificar_Citas : Form
    {
        public Modificar_Citas()
        {
            InitializeComponent();
            btn_Guardar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Modificar.Enabled = false;
            btn_Cancelar.Enabled = false;

            gbx_Panel_Modificar_Citas.Enabled = false;
            //Tambien se le podría colocar con ReadOnly
            dgv_Disponibles.Enabled = false;
            dgv_No_Disponibles.Enabled = false;
        }
        int m, mx, my;//variables que permiten el movimiento del form
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Disponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void dgv_No_Disponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    

        private void textBox2_Enter(object sender, EventArgs e)
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

        private void tbx_Nombre_Del_Usuario_Enter(object sender, EventArgs e)
        {
            if (tbx_Nombre_Del_Usuario.Text == "Nombre de Usuario")
            {
                tbx_Nombre_Del_Usuario.Text = "";
                tbx_Nombre_Del_Usuario.ForeColor = Color.White;
            }
        }

        private void tbx_Nombre_Del_Usuario_Leave(object sender, EventArgs e)
        {
            if (tbx_Nombre_Del_Usuario.Text == "")
            {
                tbx_Nombre_Del_Usuario.Text = "Nombre de Usuario";
                tbx_Nombre_Del_Usuario.ForeColor = Color.White;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modificar_Citas_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            btn_Guardar.Enabled = false;
            btn_Eliminar.Enabled = true;
            btn_Modificar.Enabled = true;
            btn_Cancelar.Enabled = false;

            gbx_Panel_Modificar_Citas.Enabled = false;
            dgv_Disponibles.Enabled = false;
            dgv_No_Disponibles.Enabled = false;

        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            
            btn_Guardar.Enabled = true;
            btn_Eliminar.Enabled = true;
            btn_Modificar.Enabled = true;
            btn_Cancelar.Enabled = true;

            gbx_Panel_Modificar_Citas.Enabled = true;
            dgv_Disponibles.Enabled = true;
            dgv_No_Disponibles.Enabled = true;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            btn_Guardar.Enabled = false;
            btn_Eliminar.Enabled = true;
            btn_Modificar.Enabled = true;
            btn_Cancelar.Enabled = false;

            gbx_Panel_Modificar_Citas.Enabled = false;
            dgv_Disponibles.Enabled = false;
            dgv_No_Disponibles.Enabled = false;

            MessageBox.Show("La cita ha sido registrada exitosamente");
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            
            btn_Guardar.Enabled = true;
            btn_Eliminar.Enabled = true;
            btn_Modificar.Enabled = true;
            btn_Cancelar.Enabled = true;

            gbx_Panel_Modificar_Citas.Enabled = true;
            dgv_Disponibles.Enabled = true;
            dgv_No_Disponibles.Enabled = true;
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
