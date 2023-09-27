// NAME-TEC-AL-0001
// VERSION-Alpha 1.0.0
// AUTHOR-ALICE
// FECHA-24/08/2022

using System.Data.SqlClient;

namespace phApp
{
    public partial class configAdmin : Form
    {
        public configAdmin()
        {
            InitializeComponent();
        }

        public SqlConnection login_server = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TECAL001;Data Source=VSRV-DAKA-BI01"); // .245
        bool accessAdmin = false;
        // -------------------------LOGIN PANTALLA PRINCIPAL---------------------------: 
        private void configAdmin_Load(object sender, EventArgs e)
        {
            label1.Font = new System.Drawing.Font(label1.Font, FontStyle.Bold);
            label2.Font = new System.Drawing.Font(label1.Font, FontStyle.Bold);
            label3.Font = new System.Drawing.Font(label1.Font, FontStyle.Bold);
        }

        // -------------------------PARCHE 2.0 LOGIN LOCAL---------------------------: 
        private void button1_Click(object sender, EventArgs e)
        {
            /* try
            {
                login_server.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = @"select login,password from userhablador where login='admin' and password = 'daka321'";
                SqlDataReader reader = command.ExecuteReader();
            }
            catch
            {
                MessageBox.Show("Fallo al conectar con el servidor"); // Personalizar
                return;
            }*/

            // PARCHE 2.0 LOGIN LOCAL
            if (textBox1.Text == "admin" && textBox2.Text == "daka321")
            {
                accessAdmin ad = new accessAdmin();
                ad.Show();

            }
            else
            {
                MessageBox.Show("Usuaio y/o Contraseña Incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // login.BOTON_CERRAR
        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void configAdmin_MouseDown(object sender, MouseEventArgs e)
        {
        }
        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
        }


        // MouseDown 
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            accessAdmin = true;
        }

        // MouseMove
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (accessAdmin)
            {
                this.Location = Cursor.Position;
            }
        }

        // MouseUp
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            accessAdmin = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
