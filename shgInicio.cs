// NAME-TEC-AL-0001
// VERSION-Alpha 1.0.0
// AUTHOR-ALICE
// FECHA-24/08/2022

using phApp.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace phApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool  shgInicio = false;

        // CONEXION A SQL SERVER
		public SqlConnection conexion_server = new SqlConnection(DefaultConnection.connectionString);

		private void Form1_Load(object sender, EventArgs e)
        {
            label1.Font = new System.Drawing.Font(label1.Font, FontStyle.Bold);
            label2.Font = new System.Drawing.Font(label1.Font, FontStyle.Bold);
            label3.Font = new System.Drawing.Font(label1.Font, FontStyle.Bold);

            radioButton1.Checked = false;
            radioButton2.Checked = false;
			radioButton3.Checked = false;

			button1.Enabled = false;
            comboBox1.Items.Add("Lista Estandar");
            comboBox1.Items.Add("Lista Para Porlamar");
            comboBox1.Items.Add("Lista Especial");
            comboBox1.Items.Add("Naranja");
            comboBox1.Items.Add("Azul");
            comboBox1.Items.Add("Verde");
			comboBox1.Items.Add("Magenta");
			comboBox1.Items.Add("A");
            comboBox1.Items.Add("B");
            comboBox1.Items.Add("C");
            comboBox2.Items.Add("-SELECCIONE EL TAMAÑO DEL HABLADOR:");
			comboBox3.Items.Add("Agencia Valencia");
			comboBox3.Items.Add("Agencia San Diego");
			comboBox3.Items.Add("Agencia Centro Valencia");
			// ESTRUCTURA COMBO
			comboBox3.Items.Add("Sucursal Lechería");
			comboBox3.Items.Add("Sucursal Puerto Ordaz");
			comboBox3.Items.Add("Sucursal Puerto Ordaz II");
			comboBox3.Items.Add("Sucursal El Paraiso");
			comboBox3.Items.Add("Sucursal Chacao");
			comboBox3.Items.Add("Sucursal Maracaibo");
			comboBox3.Items.Add("Agencia Puerto Cabello");
			comboBox3.Items.Add("Sucursal La Trinidad");
			comboBox3.Items.Add("Sucursal Candelaria");
			comboBox3.Items.Add("Sucursal El Recreo");
			comboBox3.Items.Add("Sucursal Acarigua-Araure");
			comboBox3.Items.Add("Sucursal Valle La Pascua");
			comboBox3.Items.Add("Sucursal Maturin");
			comboBox3.Items.Add("Sucursal El Tigre");
			comboBox3.Items.Add("Agencia Guacara");
			comboBox3.Items.Add("Sucursal Porlamar");
			comboBox3.Items.Add("Sucursal Punto Fijo");
			comboBox3.Items.Add("Sucursal Barquisimeto");
			comboBox3.Items.Add("Sucursal Barquisimeto Centro");
			comboBox3.Items.Add("Sucursal Maracay");
			comboBox3.Items.Add("Sucursal Maracay Centro");
			comboBox3.Items.Add("Sucursal San Felipe");
			comboBox3.Items.Add("Sucursal San Cristobal");
			comboBox3.Items.Add("Sucursal Valera");
			comboBox3.Items.Add("Sucursal Puerto La Cruz Centro");
			comboBox3.Items.Add("Sucursal La Guaira");
			comboBox3.Items.Add("Sucursal Bello Monte");
			comboBox3.Items.Add("Sucursal Boleita");
			//comboBox3.Items.Add("Sucursal Maracay");
			comboBox3.Items.Add("Sucursal Carrizal");
			//conexion_server.Open();
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
			else if (comboBox1.SelectedIndex == 9)
			{
				button1.Enabled = true;
			}
		}

        // COMBOBOX PARA SUCURSAL
		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
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
			else if (this.radioButton3.Checked == true)
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
			else if (this.radioButton3.Checked == true)
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
					Obtner.almacen = "EXH";
					Obtner.almacen1 = "ALM";
					Obtner.almacen2 = "ALM-CDD";
					Obtner.almacen3 = "ALMD";
					Obtner.almacen4 = "EXH";
					Obtner.almacen4 = "EXHD";
					Obtner.almacen6 = "MVD";
					Obtner.almacen7 = "MPT";
					Obtner.almacen8 = "MHS";
					Obtner.almacen9 = "MVKAD";
					Obtner.almacen10 = "MVSAM";
					Obtner.almacen11 = "MVWH";
					Obtner.almacen12 = "OB";
					Obtner.almacen13 = "RCP";
					Obtner.almacen14 = "SM"; // 13
				}
                else if (comboBox1.SelectedItem == "Lista Para Porlamar")
                {
                    Obtner.margarita = true;
                    Obtner.listaPrecio = "6";
					Obtner.almacen = "EXH";
					Obtner.almacen12 = "OB";
					Obtner.almacen1 = "ALM";
				}
                else if (comboBox1.SelectedItem == "Naranja")// query de exibición con detalles
                {
                    AgregarNuevaLista.identificadorLista = "NJ";
                    Obtner.naranja = true;
                    Obtner.almacen = "ALM-NJ";
					Obtner.almacen1 = "EXH-NJ";
					//Obtner.listaPrecio = "16";
                }
                else if (comboBox1.SelectedItem == "Azul")// query de exibición con detalles
                {
                    AgregarNuevaLista.identificadorLista = "AZ";
                    Obtner.azul = true;
					Obtner.almacen = "ALM-AZ";
					Obtner.almacen1 = "EXH-AZ";
					Obtner.almacen1 = "RC-RCBLE";
					//Obtner.listaPrecio = "15";
				}
				else if (comboBox1.SelectedItem == "Verde")// query de exibición con detalles
                {
                    AgregarNuevaLista.identificadorLista = "VD";
                    Obtner.verde = true;
                   // Obtner.listaPrecio = "14";
                    Obtner.almacen = "EXH-VD";
					Obtner.almacen1 = "ALM-VD";
				}
				else if (comboBox1.SelectedItem == "Magenta")// query de exibición con detalles
				{
					AgregarNuevaLista.identificadorLista = "MG";
					Obtner.magenta = true;
					//Obtner.listaPrecio = "7";
					Obtner.almacen = "EXH-MG";
					Obtner.almacen1 = "ALM-MG";
				}
				else if (comboBox1.SelectedItem == "A")// query de exibición con detalles
                {
                    AgregarNuevaLista.identificadorLista = "A";
                    Obtner.A = true;
                    Obtner.almacen = "ALM-GD-A";
					Obtner.almacen1 = "GD-A";
					//Obtner.listaPrecio = "18";
                }
                else if (comboBox1.SelectedItem == "B")// query de exibición con detalles
                {
                    AgregarNuevaLista.identificadorLista = "B";
                    Obtner.B = true;
					Obtner.almacen = "ALM-GD-B";
					Obtner.almacen1 = "GD-B";
					//Obtner.listaPrecio = "19";
                }
                else if (comboBox1.SelectedItem == "C")// query de exibición con detalles
                {
                    AgregarNuevaLista.identificadorLista = "C";
                    Obtner.C = true;
					Obtner.almacen = "ALM-GD-C";
					Obtner.almacen1 = "GD-C";
					//Obtner.listaPrecio = "20";
                }
                else if (comboBox1.SelectedItem == "Lista Especial")// query de exibición con detalles
                {
                    Obtner.Maturin = true;
                    //Obtner.listaPrecio = "11";
					Obtner.almacen = "EXH";
					Obtner.almacen1 = "ALM";
					Obtner.almacen2 = "OB";				
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
					if (comboBox3.SelectedItem == "Agencia Valencia")
					{
						Obtner.sucursal = "4";
					}
					if (comboBox3.SelectedItem == "Agencia San Diego")
					{
						Obtner.sucursal = "12";
					}
					if (comboBox3.SelectedItem == "Agencia Centro Valencia")
					{
						Obtner.sucursal = "13"; 
					}
					if (comboBox3.SelectedItem == "Sucursal Lechería")
					{
						Obtner.sucursal = "10";
					}
					// 11
					if (comboBox3.SelectedItem == "Sucursal Puerto Ordaz")
					{
						Obtner.sucursal = "11";
					}
					// 14
					if (comboBox3.SelectedItem == "Sucursal El Paraiso")
					{
						Obtner.sucursal = "14";
					}
					// 15
					if (comboBox3.SelectedItem == "Sucursal Chacao")
					{
						Obtner.sucursal = "15";
					}
					// 16
					if (comboBox3.SelectedItem == "Sucursal Maracaibo")
					{
						Obtner.sucursal = "16";
					}
					// 17
					if (comboBox3.SelectedItem == "Agencia Puerto Cabello")
					{
						Obtner.sucursal = "17";
					}
					// 18
					if (comboBox3.SelectedItem == "Sucursal La Trinidad")
					{
						Obtner.sucursal = "18";
					}
					// 19
					if (comboBox3.SelectedItem == "Sucursal Candelaria")
					{
						Obtner.sucursal = "19";
					}
					// 21
					if (comboBox3.SelectedItem == "Sucursal Puerto Ordaz II")
					{
						Obtner.sucursal = "21";
					}
					// 22
					if (comboBox3.SelectedItem == "Sucursal El Recreo")
					{
						Obtner.sucursal = "22";
					}
					// 23
					if (comboBox3.SelectedItem == "Sucursal Acarigua-Araure")
					{
						Obtner.sucursal = "23";
					}
					// 24
					if (comboBox3.SelectedItem == "Sucursal Valle La Pascua")
					{
						Obtner.sucursal = "24";
					}
					// 25
					if (comboBox3.SelectedItem == "Sucursal Maturin")
					{
						Obtner.sucursal = "25";
					}
					// 26
					if (comboBox3.SelectedItem == "Sucursal El Tigre")
					{
						Obtner.sucursal = "26";
					}
					// 27
					if (comboBox3.SelectedItem == "Agencia Guacara")
					{
						Obtner.sucursal = "27";
					}
					// 29
					if (comboBox3.SelectedItem == "Sucursal Porlamar")
					{
						Obtner.sucursal = "29";
					}
					// 3
					if (comboBox3.SelectedItem == "Sucursal Punto Fijo")
					{
						Obtner.sucursal = "3";
					}
					// 7
					if (comboBox3.SelectedItem == "Sucursal Barquisimeto")
					{
						Obtner.sucursal = "7";
					}
					// 30
					if (comboBox3.SelectedItem == "Sucursal Barquisimeto Centro")
					{
						Obtner.sucursal = "30";
					}
					// 8
					if (comboBox3.SelectedItem == "Sucursal Maracay")
					{
						Obtner.sucursal = "8";
					}
					// 31
					if (comboBox3.SelectedItem == "Sucursal Maracay Centro")
					{
						Obtner.sucursal = "31";
					}
					// 32
					if (comboBox3.SelectedItem == "Sucursal San Felipe")
					{
						Obtner.sucursal = "32";
					}
					// 33
					if (comboBox3.SelectedItem == "Sucursal San Cristobal")
					{
						Obtner.sucursal = "33";
					}
					// 34
					if (comboBox3.SelectedItem == "Sucursal Valera")
					{
						Obtner.sucursal = "34";
					}
					// 35
					if (comboBox3.SelectedItem == "Sucursal Puerto La Cruz Centro")
					{
						Obtner.sucursal = "35";
					}
					// 36
					if (comboBox3.SelectedItem == "Sucursal Cabimas")
					{
						Obtner.sucursal = "36";
					}
					// 37
					if (comboBox3.SelectedItem == "Sucursal La Guaira")
					{
						Obtner.sucursal = "37";
					}
					// 5
					if (comboBox3.SelectedItem == "Sucursal Bello Monte")
					{
						Obtner.sucursal = "5";
					}
					// 6
					if (comboBox3.SelectedItem == "Sucursal Boleita")
					{
						Obtner.sucursal = "6";
					}
					// 7
					if (comboBox3.SelectedItem == "Sucursal Barquisimeto")
					{
						Obtner.sucursal = "7";
					}
					// 8
					if (comboBox3.SelectedItem == "Sucursal Maracay")
					{
						Obtner.sucursal = "8";
					}
					// 9
					if (comboBox3.SelectedItem == "Sucursal Carrizal")
					{
						Obtner.sucursal = "9";
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
					if (comboBox3.SelectedItem == "Agencia Valencia")
					{
						Obtner.sucursal = "4";
					}
					if (comboBox3.SelectedItem == "Agencia San Diego")
					{
						Obtner.sucursal = "12";
					}
					if (comboBox3.SelectedItem == "Agencia Centro Valencia")
					{
						Obtner.sucursal = "13";
					}
					if (comboBox3.SelectedItem == "Sucursal Lechería")
					{
						Obtner.sucursal = "10";
					}
					// 11
					if (comboBox3.SelectedItem == "Sucursal Puerto Ordaz")
					{
						Obtner.sucursal = "11";
					}
					// 14
					if (comboBox3.SelectedItem == "Sucursal El Paraiso")
					{
						Obtner.sucursal = "14";
					}
					// 15
					if (comboBox3.SelectedItem == "Sucursal Chacao")
					{
						Obtner.sucursal = "15";
					}
					// 16
					if (comboBox3.SelectedItem == "Sucursal Maracaibo")
					{
						Obtner.sucursal = "16";
					}
					// 17
					if (comboBox3.SelectedItem == "Agencia Puerto Cabello")
					{
						Obtner.sucursal = "17";
					}
					// 18
					if (comboBox3.SelectedItem == "Sucursal La Trinidad")
					{
						Obtner.sucursal = "18";
					}
					// 19
					if (comboBox3.SelectedItem == "Sucursal Candelaria")
					{
						Obtner.sucursal = "19";
					}
					// 21
					if (comboBox3.SelectedItem == "Sucursal Puerto Ordaz II")
					{
						Obtner.sucursal = "21";
					}
					// 22
					if (comboBox3.SelectedItem == "Sucursal El Recreo")
					{
						Obtner.sucursal = "22";
					}
					// 23
					if (comboBox3.SelectedItem == "Sucursal Acarigua-Araure")
					{
						Obtner.sucursal = "23";
					}
					// 24
					if (comboBox3.SelectedItem == "Sucursal Valle La Pascua")
					{
						Obtner.sucursal = "24";
					}
					// 25
					if (comboBox3.SelectedItem == "Sucursal Maturin")
					{
						Obtner.sucursal = "25";
					}
					// 26
					if (comboBox3.SelectedItem == "Sucursal El Tigre")
					{
						Obtner.sucursal = "26";
					}
					// 27
					if (comboBox3.SelectedItem == "Agencia Guacara")
					{
						Obtner.sucursal = "27";
					}
					// 29
					if (comboBox3.SelectedItem == "Sucursal Porlamar")
					{
						Obtner.sucursal = "29";
					}
					// 3
					if (comboBox3.SelectedItem == "Sucursal Punto Fijo")
					{
						Obtner.sucursal = "3";
					}
					// 7
					if (comboBox3.SelectedItem == "Sucursal Barquisimeto")
					{
						Obtner.sucursal = "7";
					}
					// 30
					if (comboBox3.SelectedItem == "Sucursal Barquisimeto Centro")
					{
						Obtner.sucursal = "30";
					}
					// 8
					if (comboBox3.SelectedItem == "Sucursal Maracay")
					{
						Obtner.sucursal = "8";
					}
					// 31
					if (comboBox3.SelectedItem == "Sucursal Maracay Centro")
					{
						Obtner.sucursal = "31";
					}
					// 32
					if (comboBox3.SelectedItem == "Sucursal San Felipe")
					{
						Obtner.sucursal = "32";
					}
					// 33
					if (comboBox3.SelectedItem == "Sucursal San Cristobal")
					{
						Obtner.sucursal = "33";
					}
					// 34
					if (comboBox3.SelectedItem == "Sucursal Valera")
					{
						Obtner.sucursal = "34";
					}
					// 35
					if (comboBox3.SelectedItem == "Sucursal Puerto La Cruz Centro")
					{
						Obtner.sucursal = "35";
					}
					// 36
					if (comboBox3.SelectedItem == "Sucursal Cabimas")
					{
						Obtner.sucursal = "36";
					}
					// 37
					if (comboBox3.SelectedItem == "Sucursal La Guaira")
					{
						Obtner.sucursal = "37";
					}
					// 5
					if (comboBox3.SelectedItem == "Sucursal Bello Monte")
					{
						Obtner.sucursal = "5";
					}
					// 6
					if (comboBox3.SelectedItem == "Sucursal Boleita")
					{
						Obtner.sucursal = "6";
					}
					// 7
					if (comboBox3.SelectedItem == "Sucursal Barquisimeto")
					{
						Obtner.sucursal = "7";
					}
					// 8
					if (comboBox3.SelectedItem == "Sucursal Maracay")
					{
						Obtner.sucursal = "8";
					}
					// 9
					if (comboBox3.SelectedItem == "Sucursal Carrizal")
					{
						Obtner.sucursal = "9";
					}
				}
				else if (radioButton3.Checked == true)
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
					if (comboBox3.SelectedItem == "Agencia Valencia")
					{
						Obtner.sucursal = "4";
					}
					if (comboBox3.SelectedItem == "Agencia San Diego")
					{
						Obtner.sucursal = "12";
					}
					if (comboBox3.SelectedItem == "Agencia Centro Valencia")
					{
						Obtner.sucursal = "13";
					}
					if (comboBox3.SelectedItem == "Sucursal Lechería")
					{
						Obtner.sucursal = "10";
					}
					// 11
					if (comboBox3.SelectedItem == "Sucursal Puerto Ordaz")
					{
						Obtner.sucursal = "11";
					}
					// 14
					if (comboBox3.SelectedItem == "Sucursal El Paraiso")
					{
						Obtner.sucursal = "14";
					}
					// 15
					if (comboBox3.SelectedItem == "Sucursal Chacao")
					{
						Obtner.sucursal = "15";
					}
					// 16
					if (comboBox3.SelectedItem == "Sucursal Maracaibo")
					{
						Obtner.sucursal = "16";
					}
					// 17
					if (comboBox3.SelectedItem == "Agencia Puerto Cabello")
					{
						Obtner.sucursal = "17";
					}
					// 18
					if (comboBox3.SelectedItem == "Sucursal La Trinidad")
					{
						Obtner.sucursal = "18";
					}
					// 19
					if (comboBox3.SelectedItem == "Sucursal Candelaria")
					{
						Obtner.sucursal = "19";
					}
					// 21
					if (comboBox3.SelectedItem == "Sucursal Puerto Ordaz II")
					{
						Obtner.sucursal = "21";
					}
					// 22
					if (comboBox3.SelectedItem == "Sucursal El Recreo")
					{
						Obtner.sucursal = "22";
					}
					// 23
					if (comboBox3.SelectedItem == "Sucursal Acarigua-Araure")
					{
						Obtner.sucursal = "23";
					}
					// 24
					if (comboBox3.SelectedItem == "Sucursal Valle La Pascua")
					{
						Obtner.sucursal = "24";
					}
					// 25
					if (comboBox3.SelectedItem == "Sucursal Maturin")
					{
						Obtner.sucursal = "25";
					}
					// 26
					if (comboBox3.SelectedItem == "Sucursal El Tigre")
					{
						Obtner.sucursal = "26";
					}
					// 27
					if (comboBox3.SelectedItem == "Agencia Guacara")
					{
						Obtner.sucursal = "27";
					}
					// 29
					if (comboBox3.SelectedItem == "Sucursal Porlamar")
					{
						Obtner.sucursal = "29";
					}
					// 3
					if (comboBox3.SelectedItem == "Sucursal Punto Fijo")
					{
						Obtner.sucursal = "3";
					}
					// 7
					if (comboBox3.SelectedItem == "Sucursal Barquisimeto")
					{
						Obtner.sucursal = "7";
					}
					// 30
					if (comboBox3.SelectedItem == "Sucursal Barquisimeto Centro")
					{
						Obtner.sucursal = "30";
					}
					// 8
					if (comboBox3.SelectedItem == "Sucursal Maracay")
					{
						Obtner.sucursal = "8";
					}
					// 31
					if (comboBox3.SelectedItem == "Sucursal Maracay Centro")
					{
						Obtner.sucursal = "31";
					}
					// 32
					if (comboBox3.SelectedItem == "Sucursal San Felipe")
					{
						Obtner.sucursal = "32";
					}
					// 33
					if (comboBox3.SelectedItem == "Sucursal San Cristobal")
					{
						Obtner.sucursal = "33";
					}
					// 34
					if (comboBox3.SelectedItem == "Sucursal Valera")
					{
						Obtner.sucursal = "34";
					}
					// 35
					if (comboBox3.SelectedItem == "Sucursal Puerto La Cruz Centro")
					{
						Obtner.sucursal = "35";
					}
					// 36
					if (comboBox3.SelectedItem == "Sucursal Cabimas")
					{
						Obtner.sucursal = "36";
					}
					// 37
					if (comboBox3.SelectedItem == "Sucursal La Guaira")
					{
						Obtner.sucursal = "37";
					}
					// 5
					if (comboBox3.SelectedItem == "Sucursal Bello Monte")
					{
						Obtner.sucursal = "5";
					}
					// 6
					if (comboBox3.SelectedItem == "Sucursal Boleita")
					{
						Obtner.sucursal = "6";
					}
					// 7
					if (comboBox3.SelectedItem == "Sucursal Barquisimeto")
					{
						Obtner.sucursal = "7";
					}
					// 8
					if (comboBox3.SelectedItem == "Sucursal Maracay")
					{
						Obtner.sucursal = "8";
					}
					// 9
					if (comboBox3.SelectedItem == "Sucursal Carrizal")
					{
						Obtner.sucursal = "9";
					}
				}
				if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
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

                    }else if (radioButton3.Checked)
					{
						// Interfaz para habladores grandes
						shg shg_form = new shg();
						shg_form.Show();
						Obtner.estandar = true;
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

		private void label4_Click(object sender, EventArgs e)
		{
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
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
			else if (this.radioButton3.Checked == true)
			{
				this.comboBox2.Items.Clear();
				comboBox2.Items.Add("Se Feliz con entero");
				comboBox2.Items.Add("Pida su Descuento");
				comboBox2.Items.Add("Se Feliz .99");
				comboBox2.Items.Add("Promo Actual");
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}
	}
}
