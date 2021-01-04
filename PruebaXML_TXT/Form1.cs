using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Xml;



namespace PruebaXML_TXT
{
    public partial class Form1 : Form
    {

        SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConStr);
        SqlCommand cmd;
        SqlDataReader lector;

        DataTable dt;
        SqlDataAdapter da;

        bool datos_correctos = false;

        public Form1()
        {
            InitializeComponent();
        }



        public void cargarUsuarios()//agregar ceros a la izquierda del ID del empleado
        {
            try
            {
                bool agregar = false;

                connection.Open();
                string query_count = "SELECT COUNT(EmployeeID) FROM Usuarios";//_____lenght vector
                cmd = new SqlCommand(query_count, connection);
                int totalFiles = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();

                int[] vectorEmployeeID;
                vectorEmployeeID = new int[totalFiles];

                connection.Open();
                string query_Ids = "SELECT EmployeeID FROM Usuarios";//_____________get IDs
                cmd = new SqlCommand(query_Ids, connection);
                lector = cmd.ExecuteReader();


                for (int i = 0; i <= totalFiles; i++)
                {
                    if (lector.Read())
                    {
                        vectorEmployeeID[i] = Convert.ToInt32(lector["EmployeeID"]);//save of DB
                        string employeeIDStr = Convert.ToString(vectorEmployeeID[i]);

                        if (employeeIDStr.Length < 8)
                        {
                            agregar = true;
                        }
                        else
                        {
                            agregar = false;
                        }
                    }
                }
                lector.Close();
                connection.Close();


                if (agregar)
                {
                    CargarDGV("SELECT REPLICATE('0',(8-LEN(CONVERT(nvarchar(8), EmployeeID)))) + CONVERT(nvarchar(8), EmployeeID) as EmployeeID, LastName, FirstName, DOB FROM Usuarios", dataGridView);
                }
                else
                {
                    CargarDGV("SELECT * FROM Usuarios", dataGridView);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.ToString());
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
        }


        //__________________________Btn Insertar datos en BD____________________________
        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {

                //Validations
                DateTime getDay = DateTime.Now;
                int result = DateTime.Compare(getDay, DateTime.Parse(txt_date_of_birth.Text));

                if (Convert.ToInt32(txt_employee_id.Text) <= 0)
                {
                    MessageBox.Show("Not number negative Employee ID");
                }
                else if (txt_last_name.Text == "")
                {
                    MessageBox.Show("The last name should not be blank value");
                }
                else if (result < 0 || Convert.ToInt32(txt_date_of_birth.Text.Length) < 8)
                {
                    MessageBox.Show("Please check the date of birth");
                    txt_date_of_birth.Text = "";
                }
                else
                {

                    //---------------------------------------Section Insert----------------------------------

                    if(VerificarPersonaRegistrada(Convert.ToInt32(txt_employee_id.Text)) > 0)
                    {
                        MessageBox.Show("El empleado ya esta registrado");
                    }
                    else
                    {
                        QuerysSQL("INSERT INTO Usuarios(EmployeeID, LastName, FirstName, DOB) VALUES(" + txt_employee_id.Text + ", '" + txt_last_name.Text + "', '" + txt_first_name.Text + "', '" + DateTime.Parse(txt_date_of_birth.Text).ToShortDateString() + "')");
                        MessageBox.Show("Insert completed");
                        LimpiarCampos(); 
                    }

                    cargarUsuarios();
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("ERROR Insert: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //-------------------------------------------FUNCIONES----------------------------------------------
        public void CargarDGV(string query, DataGridView dgv)
        {
            try
            {
                connection.Open();
                da = new SqlDataAdapter(query, connection);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.ToString());
            }

        }

        public void QuerysSQL(string query)
        {
            connection.Open();
            cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }


        public int VerificarPersonaRegistrada(int id)
        {
            int contador = 0;

            connection.Open();
            string querySelectFrom = "SELECT * FROM Usuarios WHERE EmployeeID=" + id;
            cmd = new SqlCommand(querySelectFrom, connection);
            lector = cmd.ExecuteReader();

            if(lector.Read())
            {
                contador++;
            }
            lector.Close();
            connection.Close();

            return contador;
        }


        public void LimpiarCampos()
        {
            txt_employee_id.Text = "";
            txt_last_name.Text = "";
            txt_first_name.Text = "";
            txt_date_of_birth.Text = "";
        }


        //___________________________Btn create txt file_____________________________
        private void btn_txt_file_Click(object sender, EventArgs e)
        {
            try
            {
                string route = "";
                int employeeID = 0;

                //Length vector 
                connection.Open();
                string query_tam = "SELECT COUNT(EmployeeID) FROM Usuarios";
                cmd = new SqlCommand(query_tam, connection);
                int totalLength = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();

                int[] vectorEmployeeID;
                vectorEmployeeID = new int[totalLength];

                string[] vectorLastName;
                vectorLastName = new string[totalLength];

                string[] vectorFirstName;
                vectorFirstName = new string[totalLength];

                string[] vectorDateBirth;
                vectorDateBirth = new string[totalLength];


                //Route of file
                MessageBox.Show("Select or create a .txt file to save");
                if (openFileDialog_txt.ShowDialog() == DialogResult.OK)
                {
                    route = openFileDialog_txt.FileName;
                }


                //--------------------------------------Section .txt file------------------------------
                using (StreamWriter outputFile = new StreamWriter(route))
                {

                    //Select data
                    connection.Open();
                    string querySelectFrom = "SELECT * FROM Usuarios";
                    cmd = new SqlCommand(querySelectFrom, connection);
                    lector = cmd.ExecuteReader();

                    string print = "";
                    for (int j = 0; j < totalLength; j++)
                    {
                        if (lector.Read())
                        {
                            employeeID = Convert.ToInt32(lector["EmployeeID"]);
                            string employeeIDStr = Convert.ToString(employeeID);

                            if (employeeIDStr.Length < 8)
                            {
                                string employeeIDCero = String.Format("{0:00000000}", Convert.ToInt32(employeeIDStr));
                                MessageBox.Show("ID: " + employeeIDCero);
                                vectorEmployeeID[j] = Convert.ToInt32(employeeIDCero);
                                vectorLastName[j] = lector["LastName"].ToString();
                                vectorFirstName[j] = lector["FirstName"].ToString();
                                vectorDateBirth[j] = lector["DOB"].ToString();
                                print = print + "[" + employeeIDCero + "]|[" + vectorLastName[j] + "]|[" + vectorFirstName[j] + "]|[" + DateTime.Parse(vectorDateBirth[j]).ToShortDateString() + "]\n";
                            }
                            else
                            {
                                vectorEmployeeID[j] = employeeID;
                                vectorLastName[j] = lector["LastName"].ToString();
                                vectorFirstName[j] = lector["FirstName"].ToString();
                                vectorDateBirth[j] = lector["DOB"].ToString();
                                print = print + "[" + vectorEmployeeID[j] + "]|[" + vectorLastName[j] + "]|[" + vectorFirstName[j] + "]|[" + DateTime.Parse(vectorDateBirth[j]).ToShortDateString() + "]\n";
                            }

                        }
                    }
                    lector.Close();
                    connection.Close();

                    outputFile.Write(print);
                    MessageBox.Show(".txt file created in: " + route);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR txt file: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //____________________________Btn create XML file___________________________
        private void btn_xml_file_Click(object sender, EventArgs e)
        {
            try
            {
                string route = "";
                string employeeIDCero = "";

                //Length vector 
                connection.Open();
                string query_tam = "SELECT COUNT(EmployeeID) FROM Usuarios";
                cmd = new SqlCommand(query_tam, connection);
                int totalLength = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();

                int[] vectorEmployeeID;
                vectorEmployeeID = new int[totalLength];

                string[] vectorLastName;
                vectorLastName = new string[totalLength];

                string[] vectorFirstName;
                vectorFirstName = new string[totalLength];

                string[] vectorDateBirth;
                vectorDateBirth = new string[totalLength];


                //Select data
                connection.Open();
                string querySelectFrom = "SELECT * FROM Usuarios";
                cmd = new SqlCommand(querySelectFrom, connection);
                lector = cmd.ExecuteReader();

                for (int i = 0; i < totalLength; i++)
                {
                    if (lector.Read())
                    {
                        vectorEmployeeID[i] = Convert.ToInt32(lector["EmployeeID"]);
                        vectorLastName[i] = lector["LastName"].ToString();
                        vectorFirstName[i] = lector["FirstName"].ToString();
                        vectorDateBirth[i] = lector["DOB"].ToString();
                    }
                }
                lector.Close();
                connection.Close();



                //------------------------------Section .xml files-----------------------------------
                XmlDocument document = new XmlDocument();
                XmlElement raiz = document.CreateElement("Employees");
                document.AppendChild(raiz);

                for (int j = 0; j < totalLength; j++)
                {
                    XmlElement employee = document.CreateElement("Employee");
                    raiz.AppendChild(employee);


                    if (vectorEmployeeID[j].ToString().Length < 8)
                    {
                        employeeIDCero = String.Format("{0:00000000}", Convert.ToInt32(vectorEmployeeID[j]));
                        MessageBox.Show("ID: " + employeeIDCero);
                        vectorEmployeeID[j] = Convert.ToInt32(employeeIDCero);

                        XmlElement id = document.CreateElement("Employee_ID");
                        id.AppendChild(document.CreateTextNode(employeeIDCero.ToString()));
                        employee.AppendChild(id);
                    }
                    else
                    {
                        XmlElement id = document.CreateElement("Employee_ID");
                        id.AppendChild(document.CreateTextNode(vectorEmployeeID[j].ToString()));
                        employee.AppendChild(id);
                    }

                    XmlElement lastNam = document.CreateElement("LastName");
                    lastNam.AppendChild(document.CreateTextNode(vectorLastName[j]));
                    employee.AppendChild(lastNam);

                    XmlElement firstNam = document.CreateElement("FirstName");
                    firstNam.AppendChild(document.CreateTextNode(vectorFirstName[j]));
                    employee.AppendChild(firstNam);

                    XmlElement dateOfBirt = document.CreateElement("DateOfBirth");
                    dateOfBirt.AppendChild(document.CreateTextNode(DateTime.Parse(vectorDateBirth[j]).ToShortDateString()));
                    employee.AppendChild(dateOfBirt);
                }


                //Route of file
                MessageBox.Show("Select or create a .xml file to save");
                if (openFileDialog_xml.ShowDialog() == DialogResult.OK)
                {
                    route = openFileDialog_xml.FileName;
                }


                document.Save(route);
                MessageBox.Show(".XML file created in: " + route);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR XML file: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }





        //------------------------------------EVENTOS----------------------------------------
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btn_procedure_update_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                using (cmd = new SqlCommand("SP_ActualizarDatosUsuarios", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeID", Convert.ToInt32(txt_employee_id.Text));
                    cmd.Parameters.AddWithValue("@LastName", txt_last_name.Text);
                    cmd.Parameters.AddWithValue("@FirstName", txt_first_name.Text);
                    cmd.Parameters.AddWithValue("@DOB", DateTime.Parse(txt_date_of_birth.Text));
                    cmd.ExecuteNonQuery();
                }
                connection.Close();

                MessageBox.Show("Campos Actualizados");
                cargarUsuarios();
                LimpiarCampos();
            }
            catch(Exception ex)
            {
                connection.Close();
                MessageBox.Show("ERROR Update: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
      
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_employee_id.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
                txt_last_name.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
                txt_first_name.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
                DateTime fecha = DateTime.Parse(dataGridView.CurrentRow.Cells[3].Value.ToString());
                txt_date_of_birth.Text = fecha.ToShortDateString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        int m, mx, my;
        private void panel_cabecera_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                using (cmd = new SqlCommand("SP_EliminarUsuarios", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeID", Convert.ToInt32(txt_employee_id.Text));
                    cmd.ExecuteNonQuery();
                }
                connection.Close();

                MessageBox.Show("Campos Eliminado");
                cargarUsuarios();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("ERROR Delete: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void panel_cabecera_MouseMove(object sender, MouseEventArgs e)
        {
            if(m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y -my);
            }
        }

        private void panel_cabecera_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

      
    }
}
