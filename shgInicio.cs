// NAME-TEC-AL-0001
// VERSION-Alpha 1.0.0
// AUTHOR-ALICE
// FECHA-24/08/2022

namespace phApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool  shgInicio = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Font = new System.Drawing.Font(label1.Font, FontStyle.Bold);
            label2.Font = new System.Drawing.Font(label1.Font, FontStyle.Bold);
            label3.Font = new System.Drawing.Font(label1.Font, FontStyle.Bold);

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            button1.Enabled = false;
            comboBox1.Items.Add("Lista Estandar");
            comboBox1.Items.Add("Lista Para Porlamar");
            comboBox1.Items.Add("Lista para Maturin");
            comboBox1.Items.Add("Naranja");
            comboBox1.Items.Add("Azul");
            comboBox1.Items.Add("Verde");
            comboBox1.Items.Add("A");
            comboBox1.Items.Add("B");
            comboBox1.Items.Add("C");
            comboBox2.Items.Add("-SELECCIONE EL TAMAÑO DEL HABLADOR:");
        }
        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
              button1.Enabled = true;

            }
            else if (comboBox1.SelectedIndex == 1)
            {
              button1.Enabled = true;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
              button1.Enabled = true;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                button1.Enabled = true;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                button1.Enabled = true;
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                button1.Enabled = true;
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                button1.Enabled = true;
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                button1.Enabled = true;
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                button1.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                // Usuario administrador
                configAdmin admin = new configAdmin();
                if (checkBox1.Checked)
                {
                    admin.Show();
                    checkBox1.Checked = false;
                }
            }
            catch
            {
                return;
            }
        }
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            // Se Feliz con entero Se Feliz .99
            if (this.radioButton1.Checked == true)
            {
                this.comboBox2.Items.Clear();
                comboBox2.Items.Add("Se Feliz con entero");
                comboBox2.Items.Add("Se Feliz .99");
                comboBox2.Items.Add("Promo Actual");
            }
            else if (this.radioButton2.Checked == true)
            {
                this.comboBox2.Items.Clear();
                comboBox2.Items.Add("Se Feliz con entero");
                comboBox2.Items.Add("Pida su Descuento");
                comboBox2.Items.Add("Se Feliz .99");
                comboBox2.Items.Add("Promo Actual");
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            //
            comboBox2.Items.Add("Se Feliz");

            if (this.radioButton1.Checked == true)
            {
                this.comboBox2.Items.Clear();
                comboBox2.Items.Add("Se Feliz con entero");
                comboBox2.Items.Add("Se Feliz .99");
                comboBox2.Items.Add("Promo Actual");
            }
            else if (this.radioButton2.Checked == true)
            {
                this.comboBox2.Items.Clear();
                comboBox2.Items.Add("Se Feliz con entero");
                comboBox2.Items.Add("Pida su Descuento");
                comboBox2.Items.Add("Se Feliz .99");
                comboBox2.Items.Add("Promo Actual");
            }
        }

        //pass
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        // Cerrar App
        public void cerrarSecion()
        {
            this.Dispose();
        }

        // BOTON_SIGUIENTE: 
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedText == " ")
            {
                MessageBox.Show("Sin promo");
            }
            else
            {
                // Selecion de lista de precios
                if (comboBox1.SelectedItem == "Lista Estandar")
                {
                    Obtner.margarita = false;

                }
                else if (comboBox1.SelectedItem == "Lista Para Porlamar")
                {
               
                    Obtner.margarita = true;
                    Obtner.listaPrecio = "6";
                }
                else if (comboBox1.SelectedItem == "Naranja")// query de exibición con detalles
                {
                    AgregarNuevaLista.identificadorLista = "NJ";
                    Obtner.naranja = true;
                    Obtner.listaPrecio = "16";
                }
                else if (comboBox1.SelectedItem == "Azul")// query de exibición con detalles
                {
                    AgregarNuevaLista.identificadorLista = "AZ";
                    Obtner.azul = true;
                    Obtner.listaPrecio = "15";
                }
                else if (comboBox1.SelectedItem == "Verde")// query de exibición con detalles
                {
                    AgregarNuevaLista.identificadorLista = "VD";
                    Obtner.verde = true;
                    Obtner.listaPrecio = "14";
                }
                else if (comboBox1.SelectedItem == "A")// query de exibición con detalles
                {
                    AgregarNuevaLista.identificadorLista = "A";
                    Obtner.A = true;
                    Obtner.listaPrecio = "18";
                }
                else if (comboBox1.SelectedItem == "B")// query de exibición con detalles
                {
                    AgregarNuevaLista.identificadorLista = "B";
                    Obtner.B = true;
                    Obtner.listaPrecio = "19";
                }
                else if (comboBox1.SelectedItem == "C")// query de exibición con detalles
                {
                    AgregarNuevaLista.identificadorLista = "C";
                    Obtner.C = true;
                    Obtner.listaPrecio = "20";
                }
                else if (comboBox1.SelectedItem == "Lista para Maturin")// query de exibición con detalles
                {
                    Obtner.Maturin = true;
                    Obtner.listaPrecio = "8";
                }

                // SELECCIÓN DE HBLADORES GRANDES Y PEQUEÑOS
                if (radioButton1.Checked == true)
                {
                    if (comboBox2.SelectedItem == "Se Feliz con entero")
                    {
                        Obtner.valorLogo = 0;
                    }
                    if (comboBox2.SelectedItem == "Se Feliz .99")
                    {
                        // Se Feliz .99
                        Obtner.valorLogo = 4;
                    }
                    if (comboBox2.SelectedItem == "Promo Actual")
                    {
                        // pida su descuento
                        Obtner.valorLogo = 2;
                    }
                }
                else if (radioButton2.Checked == true)
                {
                    // Selecion de promociones
                    if (comboBox2.SelectedItem == "Se Feliz con entero")
                    {
                        Obtner.valorLogo = 0;
                    }
                    if (comboBox2.SelectedItem == "Pida su Descuento")
                    {
                        // pida su descuento
                        Obtner.valorLogo = 1;
                        Obtner.valorBandera = true;
                    }
                    if (comboBox2.SelectedItem == "Se Feliz .99")
                    {
                        // Se Feliz .99
                        Obtner.valorLogo = 4;
                    }
                    if (comboBox2.SelectedItem == "Promo Actual")
                    {
                        // promo actual
                        Obtner.valorLogo = 3;
                    }
                }

                if (radioButton1.Checked || radioButton2.Checked)
                {
                    if (radioButton1.Checked)
                    {
                        // Interfaz para habladores pequeños
                        shp shp_form = new shp();
                        shp_form.Show();
                    }
                    else if (radioButton2.Checked)
                    {
                        // Interfaz para habladores grandes
                        shg shg_form = new shg();
                        shg_form.Show();

                    }
                }
                else
                {
                    MessageBox.Show("Seleccione el Tipo de Hablador", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // MouseDowm
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            shgInicio = true;
        }

        // MouseMove
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (shgInicio)
            {
                this.Location = Cursor.Position;
            }
        }

        // MouseUp
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            shgInicio = false;
        }
        
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
        }
    }
}
