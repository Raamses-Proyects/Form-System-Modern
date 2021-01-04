namespace PruebaXML_TXT
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_employee_id = new System.Windows.Forms.TextBox();
            this.txt_last_name = new System.Windows.Forms.TextBox();
            this.txt_first_name = new System.Windows.Forms.TextBox();
            this.txt_date_of_birth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_txt_file = new System.Windows.Forms.Button();
            this.btn_xml_file = new System.Windows.Forms.Button();
            this.openFileDialog_txt = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog_xml = new System.Windows.Forms.OpenFileDialog();
            this.panel_cabecera = new System.Windows.Forms.Panel();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_procedure_update = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_submit = new System.Windows.Forms.Button();
            this.pictureBox_menu = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_cabecera.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_employee_id
            // 
            this.txt_employee_id.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_employee_id.Location = new System.Drawing.Point(305, 50);
            this.txt_employee_id.Name = "txt_employee_id";
            this.txt_employee_id.Size = new System.Drawing.Size(337, 22);
            this.txt_employee_id.TabIndex = 2;
            // 
            // txt_last_name
            // 
            this.txt_last_name.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_last_name.Location = new System.Drawing.Point(305, 76);
            this.txt_last_name.Name = "txt_last_name";
            this.txt_last_name.Size = new System.Drawing.Size(337, 22);
            this.txt_last_name.TabIndex = 3;
            // 
            // txt_first_name
            // 
            this.txt_first_name.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_first_name.Location = new System.Drawing.Point(305, 102);
            this.txt_first_name.Name = "txt_first_name";
            this.txt_first_name.Size = new System.Drawing.Size(337, 22);
            this.txt_first_name.TabIndex = 4;
            // 
            // txt_date_of_birth
            // 
            this.txt_date_of_birth.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date_of_birth.Location = new System.Drawing.Point(305, 128);
            this.txt_date_of_birth.MaxLength = 8;
            this.txt_date_of_birth.Name = "txt_date_of_birth";
            this.txt_date_of_birth.Size = new System.Drawing.Size(337, 22);
            this.txt_date_of_birth.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(201, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Employee ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(203, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(203, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(201, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date of Birth:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(66, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "RC_Project";
            // 
            // btn_txt_file
            // 
            this.btn_txt_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_txt_file.FlatAppearance.BorderSize = 0;
            this.btn_txt_file.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.btn_txt_file.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(49)))), ((int)(((byte)(65)))));
            this.btn_txt_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_txt_file.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_txt_file.ForeColor = System.Drawing.Color.White;
            this.btn_txt_file.Location = new System.Drawing.Point(0, 123);
            this.btn_txt_file.Name = "btn_txt_file";
            this.btn_txt_file.Size = new System.Drawing.Size(190, 40);
            this.btn_txt_file.TabIndex = 11;
            this.btn_txt_file.Text = "Create TXT";
            this.btn_txt_file.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_txt_file.UseVisualStyleBackColor = true;
            this.btn_txt_file.Click += new System.EventHandler(this.btn_txt_file_Click);
            // 
            // btn_xml_file
            // 
            this.btn_xml_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xml_file.FlatAppearance.BorderSize = 0;
            this.btn_xml_file.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.btn_xml_file.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(49)))), ((int)(((byte)(65)))));
            this.btn_xml_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xml_file.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xml_file.ForeColor = System.Drawing.Color.White;
            this.btn_xml_file.Location = new System.Drawing.Point(0, 172);
            this.btn_xml_file.Name = "btn_xml_file";
            this.btn_xml_file.Size = new System.Drawing.Size(190, 40);
            this.btn_xml_file.TabIndex = 12;
            this.btn_xml_file.Text = "Create XML";
            this.btn_xml_file.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xml_file.UseVisualStyleBackColor = true;
            this.btn_xml_file.Click += new System.EventHandler(this.btn_xml_file_Click);
            // 
            // openFileDialog_txt
            // 
            this.openFileDialog_txt.FileName = "openFileDialog1";
            // 
            // openFileDialog_xml
            // 
            this.openFileDialog_xml.FileName = "openFileDialog2";
            // 
            // panel_cabecera
            // 
            this.panel_cabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_cabecera.Controls.Add(this.btn_min);
            this.panel_cabecera.Controls.Add(this.btn_close);
            this.panel_cabecera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_cabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_cabecera.ForeColor = System.Drawing.Color.White;
            this.panel_cabecera.Location = new System.Drawing.Point(0, 0);
            this.panel_cabecera.Name = "panel_cabecera";
            this.panel_cabecera.Size = new System.Drawing.Size(657, 35);
            this.panel_cabecera.TabIndex = 13;
            this.panel_cabecera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_cabecera_MouseDown);
            this.panel_cabecera.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_cabecera_MouseMove);
            this.panel_cabecera.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_cabecera_MouseUp);
            // 
            // btn_min
            // 
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Image = global::PruebaXML_TXT.Properties.Resources.Icono_Minimizar;
            this.btn_min.Location = new System.Drawing.Point(581, 0);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(35, 35);
            this.btn_min.TabIndex = 1;
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::PruebaXML_TXT.Properties.Resources.Icono_cerrar_FN;
            this.btn_close.Location = new System.Drawing.Point(622, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 35);
            this.btn_close.TabIndex = 0;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.panelMenu.Controls.Add(this.panel10);
            this.panelMenu.Controls.Add(this.panel9);
            this.panelMenu.Controls.Add(this.panel8);
            this.panelMenu.Controls.Add(this.panel6);
            this.panelMenu.Controls.Add(this.btn_delete);
            this.panelMenu.Controls.Add(this.btn_procedure_update);
            this.panelMenu.Controls.Add(this.panel7);
            this.panelMenu.Controls.Add(this.panel5);
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Controls.Add(this.btn_xml_file);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.btn_submit);
            this.panelMenu.Controls.Add(this.btn_txt_file);
            this.panelMenu.Controls.Add(this.label5);
            this.panelMenu.Controls.Add(this.pictureBox_menu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 35);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(190, 363);
            this.panelMenu.TabIndex = 14;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel10.Location = new System.Drawing.Point(183, 264);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(7, 40);
            this.panel10.TabIndex = 17;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel9.Location = new System.Drawing.Point(0, 264);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(7, 40);
            this.panel9.TabIndex = 17;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel8.Location = new System.Drawing.Point(183, 218);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(7, 40);
            this.panel8.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Location = new System.Drawing.Point(0, 218);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(7, 40);
            this.panel6.TabIndex = 16;
            // 
            // btn_delete
            // 
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(49)))), ((int)(((byte)(65)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(0, 264);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(190, 40);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_procedure_update
            // 
            this.btn_procedure_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_procedure_update.FlatAppearance.BorderSize = 0;
            this.btn_procedure_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.btn_procedure_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(49)))), ((int)(((byte)(65)))));
            this.btn_procedure_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_procedure_update.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_procedure_update.ForeColor = System.Drawing.Color.White;
            this.btn_procedure_update.Location = new System.Drawing.Point(0, 218);
            this.btn_procedure_update.Name = "btn_procedure_update";
            this.btn_procedure_update.Size = new System.Drawing.Size(190, 40);
            this.btn_procedure_update.TabIndex = 18;
            this.btn_procedure_update.Text = "UPDATE";
            this.btn_procedure_update.UseVisualStyleBackColor = true;
            this.btn_procedure_update.Click += new System.EventHandler(this.btn_procedure_update_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel7.Location = new System.Drawing.Point(183, 172);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(7, 40);
            this.panel7.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Location = new System.Drawing.Point(0, 172);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(7, 40);
            this.panel5.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Location = new System.Drawing.Point(183, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(7, 40);
            this.panel4.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(0, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 40);
            this.panel3.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(183, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 40);
            this.panel2.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 40);
            this.panel1.TabIndex = 15;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submit.FlatAppearance.BorderSize = 0;
            this.btn_submit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.btn_submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(49)))), ((int)(((byte)(65)))));
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.White;
            this.btn_submit.Location = new System.Drawing.Point(0, 80);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(190, 40);
            this.btn_submit.TabIndex = 15;
            this.btn_submit.Text = "INSERT";
            this.btn_submit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // pictureBox_menu
            // 
            this.pictureBox_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_menu.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_menu.Image")));
            this.pictureBox_menu.Location = new System.Drawing.Point(25, 10);
            this.pictureBox_menu.Name = "pictureBox_menu";
            this.pictureBox_menu.Size = new System.Drawing.Size(35, 35);
            this.pictureBox_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_menu.TabIndex = 0;
            this.pictureBox_menu.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(89)))), ((int)(((byte)(106)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.ColumnHeadersHeight = 25;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(200, 190);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.Size = new System.Drawing.Size(447, 195);
            this.dataGridView.TabIndex = 11;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(203, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Employees List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(89)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(657, 398);
            this.Controls.Add(this.txt_employee_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_last_name);
            this.Controls.Add(this.txt_first_name);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_date_of_birth);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel_cabecera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_cabecera.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_employee_id;
        private System.Windows.Forms.TextBox txt_last_name;
        private System.Windows.Forms.TextBox txt_first_name;
        private System.Windows.Forms.TextBox txt_date_of_birth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_txt_file;
        private System.Windows.Forms.Button btn_xml_file;
        private System.Windows.Forms.OpenFileDialog openFileDialog_txt;
        private System.Windows.Forms.OpenFileDialog openFileDialog_xml;
        private System.Windows.Forms.Panel panel_cabecera;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox_menu;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_procedure_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
    }
}

