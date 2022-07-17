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
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Crear = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Disponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_No_Disponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbx_Panel_Modificar_Citas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(1013, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 37);
            this.label2.TabIndex = 45;
            this.label2.Text = "JARDINES NO DISPONIBLES";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(598, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 37);
            this.label1.TabIndex = 44;
            this.label1.Text = "JARDINES DISPONIBLES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgv_Disponibles
            // 
            this.dgv_Disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Disponibles.Location = new System.Drawing.Point(598, 141);
            this.dgv_Disponibles.Name = "dgv_Disponibles";
            this.dgv_Disponibles.RowHeadersWidth = 51;
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
            this.dgv_No_Disponibles.RowHeadersWidth = 51;
            this.dgv_No_Disponibles.RowTemplate.Height = 25;
            this.dgv_No_Disponibles.Size = new System.Drawing.Size(405, 600);
            this.dgv_No_Disponibles.TabIndex = 41;
            this.dgv_No_Disponibles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_No_Disponibles_CellContentClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Green;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Location = new System.Drawing.Point(-3, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(576, 687);
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.White;
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modificar.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Modificar.ForeColor = System.Drawing.Color.Black;
            this.btn_Modificar.Location = new System.Drawing.Point(16, 676);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(166, 52);
            this.btn_Modificar.TabIndex = 69;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.White;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Eliminar.ForeColor = System.Drawing.Color.Black;
            this.btn_Eliminar.Location = new System.Drawing.Point(201, 676);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(166, 52);
            this.btn_Eliminar.TabIndex = 70;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.White;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancelar.Location = new System.Drawing.Point(393, 676);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(166, 52);
            this.btn_Cancelar.TabIndex = 71;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
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
            this.gbx_Panel_Modificar_Citas.Controls.Add(this.tbx_Nombre_Del_Jardin);
            this.gbx_Panel_Modificar_Citas.Controls.Add(this.label14);
            this.gbx_Panel_Modificar_Citas.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbx_Panel_Modificar_Citas.ForeColor = System.Drawing.Color.White;
            this.gbx_Panel_Modificar_Citas.Location = new System.Drawing.Point(12, 91);
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
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label13.Location = new System.Drawing.Point(14, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(477, 19);
            this.label13.TabIndex = 84;
            this.label13.Text = "____________________________________________________";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // tbx_Nombre_Del_Usuario
            // 
            this.tbx_Nombre_Del_Usuario.BackColor = System.Drawing.Color.Green;
            this.tbx_Nombre_Del_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Nombre_Del_Usuario.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_Nombre_Del_Usuario.ForeColor = System.Drawing.Color.White;
            this.tbx_Nombre_Del_Usuario.Location = new System.Drawing.Point(19, 89);
            this.tbx_Nombre_Del_Usuario.Name = "tbx_Nombre_Del_Usuario";
            this.tbx_Nombre_Del_Usuario.Size = new System.Drawing.Size(411, 32);
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
            this.comboBox1.Location = new System.Drawing.Point(19, 454);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(377, 32);
            this.comboBox1.TabIndex = 82;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Green;
            this.label8.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 31);
            this.label8.TabIndex = 81;
            this.label8.Text = "Hora de Cierre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Green;
            this.label10.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(14, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 31);
            this.label10.TabIndex = 80;
            this.label10.Text = "Hora de Inicio";
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.comboBox2.Location = new System.Drawing.Point(19, 363);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(377, 34);
            this.comboBox2.TabIndex = 79;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Green;
            this.label11.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(14, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(237, 31);
            this.label11.TabIndex = 78;
            this.label11.Text = "Cantidad de Personas";
            // 
            // comboBox3
            // 
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.comboBox3.Location = new System.Drawing.Point(19, 276);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(377, 34);
            this.comboBox3.TabIndex = 77;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Green;
            this.label12.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(13, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 31);
            this.label12.TabIndex = 76;
            this.label12.Text = "Fecha de Reserva";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Green;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Green;
            this.dateTimePicker1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 188);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 7, 14, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(377, 34);
            this.dateTimePicker1.TabIndex = 75;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Green;
            this.label14.Enabled = false;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label14.Location = new System.Drawing.Point(14, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(477, 19);
            this.label14.TabIndex = 73;
            this.label14.Text = "____________________________________________________";
            // 
            // tbx_Nombre_Del_Jardin
            // 
            this.tbx_Nombre_Del_Jardin.BackColor = System.Drawing.Color.Green;
            this.tbx_Nombre_Del_Jardin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Nombre_Del_Jardin.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_Nombre_Del_Jardin.ForeColor = System.Drawing.Color.White;
            this.tbx_Nombre_Del_Jardin.Location = new System.Drawing.Point(19, 31);
            this.tbx_Nombre_Del_Jardin.Name = "tbx_Nombre_Del_Jardin";
            this.tbx_Nombre_Del_Jardin.Size = new System.Drawing.Size(453, 32);
            this.tbx_Nombre_Del_Jardin.TabIndex = 72;
            this.tbx_Nombre_Del_Jardin.Text = "Nombre del Jardin";
            this.tbx_Nombre_Del_Jardin.Enter += new System.EventHandler(this.textBox2_Enter);
            this.tbx_Nombre_Del_Jardin.Leave += new System.EventHandler(this.tbx_Nombre_Del_Jardin_Leave);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.White;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Guardar.ForeColor = System.Drawing.Color.Black;
            this.btn_Guardar.Location = new System.Drawing.Point(298, 609);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(261, 52);
            this.btn_Guardar.TabIndex = 74;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Crear
            // 
            this.btn_Crear.BackColor = System.Drawing.Color.White;
            this.btn_Crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Crear.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Crear.ForeColor = System.Drawing.Color.Black;
            this.btn_Crear.Location = new System.Drawing.Point(16, 609);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(264, 52);
            this.btn_Crear.TabIndex = 73;
            this.btn_Crear.Text = "Crear";
            this.btn_Crear.UseVisualStyleBackColor = false;
            this.btn_Crear.Click += new System.EventHandler(this.btn_Crear_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.White;
            this.pictureBox9.Image = global::Proyecto_Final.Properties.Resources.Diseño_sin_título__12_;
            this.pictureBox9.Location = new System.Drawing.Point(16, 11);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(69, 50);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 75;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.White;
            this.pictureBox12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox12.Image = global::Proyecto_Final.Properties.Resources.hogar;
            this.pictureBox12.Location = new System.Drawing.Point(1277, 12);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(39, 40);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 78;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.Image = global::Proyecto_Final.Properties.Resources.cerca;
            this.pictureBox8.Location = new System.Drawing.Point(1368, 14);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(39, 40);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 77;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Image = global::Proyecto_Final.Properties.Resources.menos;
            this.pictureBox7.Location = new System.Drawing.Point(1322, 14);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(39, 40);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 76;
            this.pictureBox7.TabStop = false;
            // 
            // Modificar_Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1430, 753);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Crear);
            this.Controls.Add(this.gbx_Panel_Modificar_Citas);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Disponibles);
            this.Controls.Add(this.dgv_No_Disponibles);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modificar_Citas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar_Citas";
            this.Load += new System.EventHandler(this.Modificar_Citas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Disponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_No_Disponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbx_Panel_Modificar_Citas.ResumeLayout(false);
            this.gbx_Panel_Modificar_Citas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private Button btn_Guardar;
        private Button btn_Crear;
        private PictureBox pictureBox9;
        private PictureBox pictureBox12;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
    }
}