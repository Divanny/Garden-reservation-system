namespace Proyecto_Final
{
    partial class Modificar_Citas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Disponibles = new System.Windows.Forms.DataGridView();
            this.dgv_No_Disponibles = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.gbx_Panel_Modificar_Citas = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbx_Nombre_Del_Usuario = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.tbx_Nombre_Del_Jardin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Disponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_No_Disponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbx_Panel_Modificar_Citas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Proyecto_Final.Properties.Resources.Boton_Minimizar;
            this.pictureBox5.Location = new System.Drawing.Point(1283, 11);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(52, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Proyecto_Final.Properties.Resources.Boton_Cerrar;
            this.pictureBox4.Location = new System.Drawing.Point(1358, 11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final.Properties.Resources.Madera_Admin;
            this.pictureBox1.Location = new System.Drawing.Point(-17, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1447, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(1007, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 39);
            this.label2.TabIndex = 45;
            this.label2.Text = "Jardines No Disponibles";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(638, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 35);
            this.label1.TabIndex = 44;
            this.label1.Text = "Jardines Disponibles";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgv_Disponibles
            // 
            this.dgv_Disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Disponibles.Location = new System.Drawing.Point(598, 141);
            this.dgv_Disponibles.Name = "dgv_Disponibles";
            this.dgv_Disponibles.RowTemplate.Height = 25;
            this.dgv_Disponibles.Size = new System.Drawing.Size(405, 600);
            this.dgv_Disponibles.TabIndex = 43;
            this.dgv_Disponibles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Disponibles_CellContentClick);
            // 
            // dgv_No_Disponibles
            // 
            this.dgv_No_Disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_No_Disponibles.Location = new System.Drawing.Point(1013, 141);
            this.dgv_No_Disponibles.Name = "dgv_No_Disponibles";
            this.dgv_No_Disponibles.RowTemplate.Height = 25;
            this.dgv_No_Disponibles.Size = new System.Drawing.Size(405, 600);
            this.dgv_No_Disponibles.TabIndex = 41;
            this.dgv_No_Disponibles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_No_Disponibles_CellContentClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Green;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Location = new System.Drawing.Point(-3, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(576, 689);
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.White;
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modificar.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Modificar.ForeColor = System.Drawing.Color.White;
            this.btn_Modificar.Image = global::Proyecto_Final.Properties.Resources.Madera_Admin;
            this.btn_Modificar.Location = new System.Drawing.Point(34, 654);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(140, 67);
            this.btn_Modificar.TabIndex = 69;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.White;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.Image = global::Proyecto_Final.Properties.Resources.Madera_Admin;
            this.btn_Eliminar.Location = new System.Drawing.Point(190, 654);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(140, 67);
            this.btn_Eliminar.TabIndex = 70;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.White;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.Image = global::Proyecto_Final.Properties.Resources.Madera_Admin;
            this.btn_Cancelar.Location = new System.Drawing.Point(347, 654);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(140, 67);
            this.btn_Cancelar.TabIndex = 71;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // gbx_Panel_Modificar_Citas
            // 
            this.gbx_Panel_Modificar_Citas.BackColor = System.Drawing.Color.Green;
            this.gbx_Panel_Modificar_Citas.Controls.Add(this.label13);
            this.gbx_Panel_Modificar_Citas.Controls.Add(this.tbx_Nombre_Del_Usuario);
            this.gbx_Panel_Modificar_Citas.Controls.Add(this.comboBox1);
            this.gbx_Panel_Modificar_Citas.Controls.Add(this.label8);
            this.gbx_Panel_Modificar_Citas.Controls.Add(this.label10);
            this.gbx_Panel_Modificar_Citas.Controls.Add(this.comboBox2);
            this.gbx_Panel_Modificar_Citas.Controls.Add(this.label11);
            this.gbx_Panel_Modificar_Citas.Controls.Add(this.comboBox3);
            this.gbx_Panel_Modificar_Citas.Controls.Add(this.label12);
            this.gbx_Panel_Modificar_Citas.Controls.Add(this.dateTimePicker1);
            this.gbx_Panel_Modificar_Citas.Controls.Add(this.label14);
            this.gbx_Panel_Modificar_Citas.Controls.Add(this.tbx_Nombre_Del_Jardin);
            this.gbx_Panel_Modificar_Citas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbx_Panel_Modificar_Citas.ForeColor = System.Drawing.Color.White;
            this.gbx_Panel_Modificar_Citas.Location = new System.Drawing.Point(12, 141);
            this.gbx_Panel_Modificar_Citas.Name = "gbx_Panel_Modificar_Citas";
            this.gbx_Panel_Modificar_Citas.Size = new System.Drawing.Size(547, 507);
            this.gbx_Panel_Modificar_Citas.TabIndex = 72;
            this.gbx_Panel_Modificar_Citas.TabStop = false;
            this.gbx_Panel_Modificar_Citas.Text = "Modificar Citas";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Green;
            this.label13.Enabled = false;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label13.Location = new System.Drawing.Point(19, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(477, 19);
            this.label13.TabIndex = 84;
            this.label13.Text = "____________________________________________________";
            // 
            // tbx_Nombre_Del_Usuario
            // 
            this.tbx_Nombre_Del_Usuario.BackColor = System.Drawing.Color.Green;
            this.tbx_Nombre_Del_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Nombre_Del_Usuario.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_Nombre_Del_Usuario.ForeColor = System.Drawing.Color.White;
            this.tbx_Nombre_Del_Usuario.Location = new System.Drawing.Point(19, 89);
            this.tbx_Nombre_Del_Usuario.Name = "tbx_Nombre_Del_Usuario";
            this.tbx_Nombre_Del_Usuario.Size = new System.Drawing.Size(411, 26);
            this.tbx_Nombre_Del_Usuario.TabIndex = 83;
            this.tbx_Nombre_Del_Usuario.Text = "Nombre de Usuario";
            this.tbx_Nombre_Del_Usuario.Enter += new System.EventHandler(this.tbx_Nombre_Del_Usuario_Enter);
            this.tbx_Nombre_Del_Usuario.Leave += new System.EventHandler(this.tbx_Nombre_Del_Usuario_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.comboBox1.Location = new System.Drawing.Point(19, 440);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(377, 32);
            this.comboBox1.TabIndex = 82;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Green;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(19, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 25);
            this.label8.TabIndex = 81;
            this.label8.Text = "Hora de Cierre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Green;
            this.label10.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(19, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 25);
            this.label10.TabIndex = 80;
            this.label10.Text = "Hora de Inicio";
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00",
            ""});
            this.comboBox2.Location = new System.Drawing.Point(19, 367);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(377, 32);
            this.comboBox2.TabIndex = 79;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Green;
            this.label11.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(19, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(215, 25);
            this.label11.TabIndex = 78;
            this.label11.Text = "Cantidad de Personas";
            // 
            // comboBox3
            // 
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.comboBox3.Location = new System.Drawing.Point(19, 291);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(377, 32);
            this.comboBox3.TabIndex = 77;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Green;
            this.label12.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(19, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 25);
            this.label12.TabIndex = 76;
            this.label12.Text = "Fecha de Reserva";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Green;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Green;
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 200);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 7, 14, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(377, 33);
            this.dateTimePicker1.TabIndex = 75;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Green;
            this.label14.Enabled = false;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label14.Location = new System.Drawing.Point(14, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(477, 19);
            this.label14.TabIndex = 73;
            this.label14.Text = "____________________________________________________";
            // 
            // tbx_Nombre_Del_Jardin
            // 
            this.tbx_Nombre_Del_Jardin.BackColor = System.Drawing.Color.Green;
            this.tbx_Nombre_Del_Jardin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Nombre_Del_Jardin.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_Nombre_Del_Jardin.ForeColor = System.Drawing.Color.White;
            this.tbx_Nombre_Del_Jardin.Location = new System.Drawing.Point(19, 26);
            this.tbx_Nombre_Del_Jardin.Name = "tbx_Nombre_Del_Jardin";
            this.tbx_Nombre_Del_Jardin.Size = new System.Drawing.Size(453, 26);
            this.tbx_Nombre_Del_Jardin.TabIndex = 72;
            this.tbx_Nombre_Del_Jardin.Text = "Nombre del Jardin";
            this.tbx_Nombre_Del_Jardin.Enter += new System.EventHandler(this.textBox2_Enter);
            this.tbx_Nombre_Del_Jardin.Leave += new System.EventHandler(this.tbx_Nombre_Del_Jardin_Leave);
            // 
            // Modificar_Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1430, 753);
            this.Controls.Add(this.gbx_Panel_Modificar_Citas);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Disponibles);
            this.Controls.Add(this.dgv_No_Disponibles);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modificar_Citas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar_Citas";
            this.Load += new System.EventHandler(this.Modificar_Citas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Disponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_No_Disponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbx_Panel_Modificar_Citas.ResumeLayout(false);
            this.gbx_Panel_Modificar_Citas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private DataGridView dgv_Disponibles;
        private DataGridView dgv_No_Disponibles;
        private PictureBox pictureBox2;
        private Button btn_Modificar;
        private Button btn_Eliminar;
        private Button btn_Cancelar;
        private GroupBox gbx_Panel_Modificar_Citas;
        private TextBox tbx_Nombre_Del_Usuario;
        private ComboBox comboBox1;
        private Label label8;
        private Label label10;
        private ComboBox comboBox2;
        private Label label11;
        private ComboBox comboBox3;
        private Label label12;
        private DateTimePicker dateTimePicker1;
        private Label label14;
        private TextBox tbx_Nombre_Del_Jardin;
        private Label label13;
    }
}