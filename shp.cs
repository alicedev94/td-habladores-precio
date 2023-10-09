// NAME-TEC-AL-0001
// VERSION-Alpha 1.0.0
// AUTHOR-ALICE
// FECHA-24/08/2022

using System.Data;
using System.Data.SqlClient;
using iTextSharp.text;
using System.Text;
using iTextSharp.text.pdf;
using System.Xml;
using phApp.Model;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Spreadsheet;

namespace phApp
{
    public partial class shp : Form
    {
		public SqlConnection conexion_server = new SqlConnection(DefaultConnection.connectionString);
		List<datos01> lista01 = new List<datos01>();
        List<ArticuloP> listaEcxell01 = new List<ArticuloP>();

        decimal formula = 0;

        int contador = 0;
        string psCaracter = "";
        bool pidaIsOn = false;

        float x_reCuadro = 340.000f - 20.000f;
        float y_reCuadro = 70.000f;

        float x_itemCode;
        float y_itemCode;

        float x_itemName;
        float y_itemName;

        float x_firname;
        float y_firname;

        float x_price1;
        float y_price1;

        float x_logo;
        float y_logo;

        public shp()
        {
            InitializeComponent();
        }

        bool shpMove = false;

        private void shp_Load(object sender, EventArgs e)
        {
            //--------- FORMULA PIDA SU DESCUENTO
            //----------
            comboBox1.Items.Add("Nombre Articulo");
            comboBox1.Items.Add("Código Articulo");

            try
            {
                string listaPrecio = Obtner.queryp;
                Obtner.IndiceLista = "2";
				Obtner.hablador = "P";

				if (Obtner.margarita == true)
                {
					listaPrecio = AgregarNuevaLista.listaSeleccionada("1", Obtner.sucursal, Obtner.almacen);
					//Obtner.IndiceLista = "6";
					//listaPrecio = Obtner.queryMargarita;
				}
                else if (Obtner.azul == true)
                {
                    listaPrecio = AgregarNuevaLista.listaSeleccionada("6", Obtner.sucursal, Obtner.almacen);

                }
                else if (Obtner.naranja == true)
                {
                    listaPrecio = AgregarNuevaLista.listaSeleccionada("4", Obtner.sucursal, Obtner.almacen);
                }
                else if (Obtner.verde == true)
                {
                    listaPrecio = AgregarNuevaLista.listaSeleccionada("6", Obtner.sucursal, Obtner.almacen);
                }
                else if (Obtner.A == true)
                {
                    listaPrecio = AgregarNuevaLista.listaSeleccionada("8", Obtner.sucursal, Obtner.almacen);
                }
                else if (Obtner.B == true)
                {
                    listaPrecio = AgregarNuevaLista.listaSeleccionada("9", Obtner.sucursal, Obtner.almacen);
                }
                else if (Obtner.C == true)
                {
                    listaPrecio = AgregarNuevaLista.listaSeleccionada("10", Obtner.sucursal, Obtner.almacen);
                }
                else if (Obtner.Maturin == true)
                {
                    listaPrecio = AgregarNuevaLista.listaSeleccionada("3", Obtner.sucursal, Obtner.almacen);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(listaPrecio, conexion_server);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                // Ocultar columnas al cargar la data inicial
                dataGridView1.Columns[1].Width = 580;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                Obtner.conectionServer = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Obtner.conectionServer = false;
            }
        }

        // 1
        private void button1_Click(object sender, EventArgs e)
        {
            lista01.RemoveAll(lista01.Remove);
            // buscador 
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                datos01 dt01 = new datos01();

                if (row.Selected)
                {
                    // error al utilizar la busqueda
                    dt01.ItemCode = row.Cells[0].Value.ToString();
                    dt01.ItemName = row.Cells[1].Value.ToString();
                    dt01.price1 = row.Cells[5].Value.ToString();
                    dt01.FirtsName = row.Cells[2].Value.ToString();
                    dt01.lista4 = row.Cells[6].Value.ToString();

                    lista01.Add(dt01);
                }
            }

            // agg al datagrid 2
            foreach (var dato in lista01)
            {
                dataGridView2.Rows.Add(dato.ItemCode, dato.ItemName, dato.price1, dato.FirtsName, dato.lista4);
            }
            lista01.RemoveAll(lista01.Remove);
        }

        // 2
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectAll();
            lista01.RemoveAll(lista01.Remove);
            // buscador 
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                datos01 dt01 = new datos01();

                if (row.Selected)
                {
                    // error al utilizar la busqueda
                    dt01.ItemCode = row.Cells[0].Value.ToString();
                    dt01.ItemName = row.Cells[1].Value.ToString();
                    dt01.price1 = row.Cells[5].Value.ToString();
                    dt01.FirtsName = row.Cells[2].Value.ToString();
                    dt01.lista4 = row.Cells[6].Value.ToString();

                    lista01.Add(dt01);
                }
            }

            // agg al datagrid 2
            foreach (var dato in lista01)
            {
                dataGridView2.Rows.Add(dato.ItemCode, dato.ItemName, dato.price1, dato.FirtsName, dato.lista4);
            }
            lista01.RemoveAll(lista01.Remove);
        }

        // 3
        private void button3_Click(object sender, EventArgs e)
        {
            lista01.RemoveAll(lista01.Remove);
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Selected)
                {
                    dataGridView2.Rows.Remove(row);
                }
            }
            lista01.RemoveAll(lista01.Remove);
        }

        // 4
        private void button4_Click(object sender, EventArgs e)
        {
            lista01.RemoveAll(lista01.Remove);
            dataGridView2.Rows.Clear();
            lista01.RemoveAll(lista01.Remove);
        }

        // Boton Principal
        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("Lista de datos vacía");
            }
            else
            {
                dataGridView2.SelectAll();
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    datos01 dt01 = new datos01();

                    if (row.Selected)
                    {
                        // error al utilizar la busqueda
                        dt01.ItemCode = row.Cells[0].Value.ToString();
                        dt01.ItemName = row.Cells[1].Value.ToString();
                        dt01.price1 = row.Cells[2].Value?.ToString();
                        dt01.FirtsName = row.Cells[3].Value?.ToString();
                        dt01.lista4 = row.Cells[4].Value?.ToString();

                        lista01.Add(dt01);
                    }
                }

                //-------CARPETA PARA EL ARCHIVO HABLADORES:
                string path01 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\TI.DAKA-HABLADORES\";
                string path02 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string dtime = DateTime.Now.ToString("dd -MM-yyyy H-mm-ss"); // obtener fecha actual

                string folderPath = path01;
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                //------- XML
                // variables
                int contadorRuta = 0;
                string ruta = "";

                // ruta del fichero xml
                //MODIFICACION DEL 25/08/2022 ------------------------------------------------------
                XmlTextReader reader = new XmlTextReader(@"\\192.168.21.126\Publico\DevTEC-AL-0001\tecAl0001_beta-1.0.6.5\phApp.dll.config");

                List<string> nodes = new List<string>();

                // lectura del archivo xml
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element: // El nodo es el elemento

                            while (reader.MoveToNextAttribute()) // Leer atributos
                                nodes.Add(reader.Value);
                            break;
                    }
                }

                // seleccion de la cadena que necesitamos
                foreach (var value in nodes)
                {
                    if (contadorRuta == 1)
                    {
                        ruta = value.ToString();
                    }
                    contadorRuta++;
                }

                // CAMBIO DE LOGO
                string tipoLogo = "", tipoPromo = "";
                int valor = Obtner.valorLogo;

                if (valor == 0)
                {
                    //se feliz
                    // MODIFICACION 25/08/2022----------------------------------------------------
                    tipoLogo = "\\\\192.168.21.126\\Publico\\DevTEC-AL-0001\\image\\logo\\Logo Daka - 1.4x1.2cm.png";
                    tipoPromo = "Se Feliz con entero";
                }
                else if (valor == 1) // parametrizar por nombre
                {
                    //ERROR CON PROMO DAKA
                    tipoLogo = @"\\192.168.21.126\Publico\DevTEC-AL-0001\image\logo\Logo Hablador Pequeño - 1.7x0.9cm.png";
                    tipoPromo = "promo daka";
                }
                else if (valor == 2)
                {
                    //ERROR CON PROMO ACTUAL
                    tipoLogo = ruta;
                    tipoPromo = "promo actual";
                }
                else if (valor == 4)
                {
                    //ERROR CON PROMO ACTUAL
                    tipoLogo = "\\\\192.168.21.126\\Publico\\DevTEC-AL-0001\\image\\logo\\Logo Daka - 1.4x1.2cm.png";
                    tipoPromo = "Se Feliz .99";
                }

                // TIPOS DE LETRA Y TAMAÑO
                iTextSharp.text.Font Arial = FontFactory.GetFont("Arial", 8);
                iTextSharp.text.Font ArialBold = FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font Arial01 = FontFactory.GetFont("Arial", 18, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font ArialN_A = FontFactory.GetFont("Arial", 16, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font ArialN_A1 = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font Arial02 = FontFactory.GetFont("Arial", 7);

                // PDF
                Document doc = new Document();
                doc.SetPageSize(iTextSharp.text.PageSize.A4.Rotate());
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(path01 + dtime + @" TI.DAKA-HABLADOR_P_PRUEBAS.pdf", FileMode.Create)); // DIRECIÓN DEL FICHERO PDF
                iTextSharp.text.Image image2 = iTextSharp.text.Image.GetInstance(tipoLogo); // DIRECCIÓN IMAGEN LOGO, ACCEDER SIEMPRE A LA CARPETA IMAGENES
                doc.Open();

                // HABLADORES P
                foreach (var dato in lista01)
                {
                    if (contador > 14)
                    {
                        doc.NewPage();
                        contador = 0;
                    }

                    if (contador == 0)
                    {
                        // 1 Inicial
                        // ALIMEAR PRECIO TACHADO
                        x_itemCode = 30.000f + 102.047f + 56.6929f; y_itemCode = 450.000f + 28.500f + 5.000f - 10.000f - 10.000f + 5.000f + 19.8425f;
                        x_itemName = 30.000f + 85.0394f + 56.6929f; y_itemName = 450.000f + 28.500f + 5.000f - 10.000f - 10.000f + 5.000f + 73.7008f;
                        x_firname = 30.000f + 85.0394f + 56.6929f; y_firname = 450.000f + 28.500f + 5.000f - 10.000f - 10.000f + 5.000f + 85.0394f;
                        x_price1 = 30.000f + 34.0157f + 56.6929f; y_price1 = 450.000f + 28.500f + 5.000f - 10.000f - 10.000f + 5.000f + 34.0157f;
                        x_logo = 30.000f + 119.055f + 56.6929f; y_logo = 450.000f + 28.500f + 5.000f - 10.000f - 10.000f + 5.000f + 28.3465f;
                        x_reCuadro = 30.000f + 56.6929f; y_reCuadro = 450.000f + 28.500f + 5.000f - 10.000f - 10.000f + 5.000f;
                    }

                    if (contador == 1)
                    {
                        // 2 Inicial
                        x_itemCode = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 102.047f + 3.000f + 56.6929f; y_itemCode = 450.000f + 28.500f + 5.000f - 10.000f - 10.000f + 5.000f + 19.8425f;
                        x_itemName = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 85.0394f + 3.000f + 56.6929f; y_itemName = 450.000f + 28.500f + 5.000f - 10.000f - 10.000f + 5.000f + 73.7008f;
                        x_firname = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 85.0394f + 3.000f + 56.6929f; y_firname = 450.000f + 28.500f + 5.000f - 10.000f - 10.000f + 5.000f + 85.0394f;
                        x_price1 = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 34.0157f + 3.000f + 56.6929f; y_price1 = 450.000f + 28.500f + 5.000f - 10.000f - 10.000f + 5.000f + 34.0157f;
                        x_logo = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 119.055f + 3.000f + 56.6929f; y_logo = 450.000f + 28.500f + 5.000f - 10.000f - 10.000f + 5.000f + 28.3465f;
                        x_reCuadro = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 3.000f + 56.6929f; y_reCuadro = 450.000f + 28.500f + 5.000f - 10.000f - 10.000f + 5.000f;
                    }

                    if (contador == 2)
                    {
                        // 3 Inicial
                        x_itemCode = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 102.047f + 3.000f + 56.6929f; y_itemCode = 450.000f + 28.500f + 5.000f - 10.000f - 10.000f + 5.000f + 19.8425f;
                        x_itemName = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 85.0394f + 3.000f + 56.6929f; y_itemName = 450.000f + 28.500f + 5.000f - 10.000f - 10.000f + 5.000f + 73.7008f;
                        x_firname = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 85.0394f + 3.000f + 56.6929f; y_firname = 450.000f + 28.500f + 5.000f - 10.000f - 10.000f + 5.000f + 85.0394f;
                        x_price1 = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 34.0157f + 3.000f + 56.6929f; y_price1 = 450.000f + 28.500f + 5.000f - 10.000f - 10.000f + 5.000f + 34.0157f;
                        x_logo = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 119.055f + 3.000f + 56.6929f; y_logo = 450.000f + 28.500f + 5.000f - 10.000f - 10.000f + 5.000f + 28.3465f;
                        x_reCuadro = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 3.000f + 56.6929f; y_reCuadro = 450.000f + 28.500f + 5.000f - 10.000f - 10.000f + 5.000f;
                    }

                    if (contador == 3)
                    {
                        // 4
                        x_itemCode = 30.000f + 102.047f + 56.6929f; y_itemCode = 450.000f - 110.000f - 10.000f + 28.500f + 20.000f - 35.000f + 5.000f + 19.8425f + 14.1732f;
                        x_itemName = 30.000f + 85.0394f + 56.6929f; y_itemName = 450.000f - 110.000f - 10.000f + 28.500f + 20.000f - 35.000f + 5.000f + 73.7008f + 14.1732f;
                        x_firname = 30.000f + 85.0394f + 56.6929f; y_firname = 450.000f - 110.000f - 10.000f + 28.500f + 20.000f - 35.000f + 5.000f + 85.0394f + 14.1732f;
                        x_price1 = 30.000f + 34.0157f + 56.6929f; y_price1 = 450.000f - 110.000f - 10.000f + 28.500f + 20.000f - 35.000f + 5.000f + 34.0157f + 14.1732f;
                        x_logo = 30.000f + 119.055f + 56.6929f; y_logo = 450.000f - 110.000f - 10.000f + 28.500f + 20.000f - 35.000f + 5.000f + 28.3465f + 14.1732f;
                        x_reCuadro = 30.000f + 56.6929f; y_reCuadro = 450.000f - 110.000f - 10.000f + 28.500f + 20.000f - 35.000f + 5.000f + 14.1732f;
                    }

                    if (contador == 4)
                    {
                        // 5
                        x_itemCode = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 102.047f + 3.000f + 56.6929f; y_itemCode = 450.000f - 110.000f - 10.000f + 28.500f + 20.000f - 35.000f + 5.000f + 19.8425f + 14.1732f;
                        x_itemName = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 85.0394f + 3.000f + 56.6929f; y_itemName = 450.000f - 110.000f - 10.000f + 28.500f + 20.000f - 35.000f + 5.000f + 73.7008f + 14.1732f;
                        x_firname = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 85.0394f + 3.000f + 56.6929f; y_firname = 450.000f - 110.000f - 10.000f + 28.500f + 20.000f - 35.000f + 5.000f + 85.0394f + 14.1732f;
                        x_price1 = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 34.0157f + 3.000f + 56.6929f; y_price1 = 450.000f - 110.000f - 10.000f + 28.500f + 20.000f - 35.000f + 5.000f + 34.0157f + 14.1732f;
                        x_logo = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 119.055f + 3.000f + 56.6929f; y_logo = 450.000f - 110.000f - 10.000f + 28.500f + 20.000f - 35.000f + 5.000f + 28.3465f + 14.1732f;
                        x_reCuadro = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 3.000f + 56.6929f; y_reCuadro = 450.000f - 110.000f - 10.000f + 28.500f + 20.000f - 35.000f + 5.000f + 14.1732f;
                    }

                    //
                    if (contador == 5)
                    {
                        // 6
                        x_itemCode = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 102.047f + 3.000f + 56.6929f; y_itemCode = 450.000f - 110.000f - 10.000f + 28.500f + 20.000f - 35.000f + 5.000f + 19.8425f + 14.1732f;
                        x_itemName = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 85.0394f + 3.000f + 56.6929f; y_itemName = 450.000f - 110.000f - 10.000f + 28.500f + 20.000f - 35.000f + 5.000f + 73.7008f + 14.1732f;
                        x_firname = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 85.0394f + 3.000f + 56.6929f; y_firname = 450.000f - 110.000f - 10.000f + 28.500f + 20.000f - 35.000f + 5.000f + 85.0394f + 14.1732f;
                        x_price1 = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 34.0157f + 3.000f + 56.6929f; y_price1 = 450.000f - 110.000f - 10.000f + 28.500f + 20.000f - 35.000f + 5.000f + 34.0157f + 14.1732f;
                        x_logo = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 119.055f + 3.000f + 56.6929f; y_logo = 450.000f - 110.000f - 10.000f + 28.500f + 20.000f - 35.000f + 5.000f + 28.3465f + 14.1732f;
                        x_reCuadro = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 3.000f + 56.6929f; y_reCuadro = 450.000f - 110.000f - 10.000f + 28.500f + 20.000f - 35.000f + 5.000f + 14.1732f;
                    }

                    //
                    if (contador == 6)
                    {
                        // 7
                        x_itemCode = 30.000f + 102.047f + 56.6929f; y_itemCode = 450.000f - 220.000f - 20.000f + 28.500f + 5.000f + 20.000f - 20.000f + 30.000f - 50.000f + 5.000f + 19.8425f + 28.3465f;
                        x_itemName = 30.000f + 85.0394f + 56.6929f; y_itemName = 450.000f - 220.000f - 20.000f + 28.500f + 5.000f + 20.000f - 20.000f + 30.000f - 50.000f + 5.000f + 73.7008f + 28.3465f;
                        x_firname = 30.000f + 85.0394f + 56.6929f; y_firname = 450.000f - 220.000f - 20.000f + 28.500f + 5.000f + 20.000f - 20.000f + 30.000f - 50.000f + 5.000f + 85.0394f + 28.3465f;
                        x_price1 = 30.000f + 34.0157f + 56.6929f; y_price1 = 450.000f - 220.000f - 20.000f + 28.500f + 5.000f + 20.000f - 20.000f + 30.000f - 50.000f + 5.000f + 34.0157f + 28.3465f;
                        x_logo = 30.000f + 119.055f + 56.6929f; y_logo = 450.000f - 220.000f - 20.000f + 28.500f + 5.000f + 20.000f - 20.000f + 30.000f - 50.000f + 5.000f + 28.3465f + 28.3465f;
                        x_reCuadro = 30.000f + 56.6929f; y_reCuadro = 450.000f - 220.000f - 20.000f + 28.500f + 5.000f + 20.000f - 20.000f + 30.000f - 50.000f + 5.000f + 28.3465f;

                    }

                    //
                    if (contador == 7)
                    {
                        // 8
                        x_itemCode = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 102.047f + 3.000f + 56.6929f; y_itemCode = 450.000f - 220.000f - 20.000f + 28.500f + 5.000f + 20.000f - 20.000f + 30.000f - 50.000f + 5.000f + 19.8425f + 28.3465f;
                        x_itemName = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 85.0394f + 3.000f + 56.6929f; y_itemName = 450.000f - 220.000f - 20.000f + 28.500f + 5.000f + 20.000f - 20.000f + 30.000f - 50.000f + 5.000f + 73.7008f + 28.3465f;
                        x_firname = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 85.0394f + 3.000f + 56.6929f; y_firname = 450.000f - 220.000f - 20.000f + 28.500f + 5.000f + 20.000f - 20.000f + 30.000f - 50.000f + 5.000f + 85.0394f + 28.3465f;
                        x_price1 = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 34.0157f + 3.000f + 56.6929f; y_price1 = 450.000f - 220.000f - 20.000f + 28.500f + 5.000f + 20.000f - 20.000f + 30.000f - 50.000f + 5.000f + 34.0157f + 28.3465f;
                        x_logo = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 119.055f + 3.000f + 56.6929f; y_logo = 450.000f - 220.000f - 20.000f + 28.500f + 5.000f + 20.000f - 20.000f + 30.000f - 50.000f + 5.000f + 28.3465f + 28.3465f;
                        x_reCuadro = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 3.000f + 56.6929f; y_reCuadro = 450.000f - 220.000f - 20.000f + 28.500f + 5.000f + 20.000f - 20.000f + 30.000f - 50.000f + 5.000f + 28.3465f;
                    }

                    //
                    if (contador == 8)
                    {
                        // 9
                        x_itemCode = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 102.047f + 3.000f + 56.6929f; y_itemCode = 450.000f - 220.000f - 20.000f + 28.500f + 5.000f + 20.000f - 20.000f + 30.000f - 50.000f + 5.000f + 19.8425f + 28.3465f;
                        x_itemName = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 85.0394f + 3.000f + 56.6929f; y_itemName = 450.000f - 220.000f - 20.000f + 28.500f + 5.000f + 20.000f - 20.000f + 30.000f - 50.000f + 5.000f + 73.7008f + 28.3465f;
                        x_firname = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 85.0394f + 3.000f + 56.6929f; y_firname = 450.000f - 220.000f - 20.000f + 28.500f + 5.000f + 20.000f - 20.000f + 30.000f - 50.000f + 5.000f + 85.0394f + 28.3465f;
                        x_price1 = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 34.0157f + 3.000f + 56.6929f; y_price1 = 450.000f - 220.000f - 20.000f + 28.500f + 5.000f + 20.000f - 20.000f + 30.000f - 50.000f + 5.000f + 34.0157f + 28.3465f;
                        x_logo = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 119.055f + 3.000f + 56.6929f; y_logo = 450.000f - 220.000f - 20.000f + 28.500f + 5.000f + 20.000f - 20.000f + 30.000f - 50.000f + 5.000f + 28.3465f + 28.3465f;
                        x_reCuadro = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 3.000f + 56.6929f; y_reCuadro = 450.000f - 220.000f - 20.000f + 28.500f + 5.000f + 20.000f - 20.000f + 30.000f - 50.000f + 5.000f + 28.3465f;
                    }

                    if (contador == 9)
                    {
                        // 10
                        x_itemCode = 30.000f + 102.047f + 56.6929f; y_itemCode = 450.000f - 330.000f - 30.000f + 28.500f + 5.000f + 10.000f + 35.000f - 65.000f + 5.000f + 19.8425f + 28.3465f + 14.1732f;
                        x_itemName = 30.000f + 85.0394f + 56.6929f; y_itemName = 450.000f - 330.000f - 30.000f + 28.500f + 5.000f + 10.000f + 35.000f - 65.000f + 5.000f + 73.7008f + 28.3465f + 14.1732f;
                        x_firname = 30.000f + 85.0394f + 56.6929f; y_firname = 450.000f - 330.000f - 30.000f + 28.500f + 5.000f + 10.000f + 35.000f - 65.000f + 5.000f + 85.0394f + 28.3465f + 14.1732f;
                        x_price1 = 30.000f + 34.0157f + 56.6929f; y_price1 = 450.000f - 330.000f - 30.000f + 28.500f + 5.000f + 10.000f + 35.000f - 65.000f + 5.000f + 34.0157f + 28.3465f + 14.1732f;
                        x_logo = 30.000f + 119.055f + 56.6929f; y_logo = 450.000f - 330.000f - 30.000f + 28.500f + 5.000f + 10.000f + 35.000f - 65.000f + 5.000f + 28.3465f + 28.3465f + 14.1732f;
                        x_reCuadro = 30.000f + 56.6929f; y_reCuadro = 450.000f - 330.000f - 30.000f + 28.500f + 5.000f + 10.000f + 35.000f - 65.000f + 5.000f + 28.3465f + 14.1732f;
                    }

                    if (contador == 10)
                    {
                        // 11
                        x_itemCode = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 102.047f + 3.000f + 56.6929f; y_itemCode = 450.000f - 330.000f - 30.000f + 28.500f + 5.000f + 10.000f + 35.000f - 65.000f + 5.000f + 19.8425f + 28.3465f + 14.1732f;
                        x_itemName = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 85.0394f + 3.000f + 56.6929f; y_itemName = 450.000f - 330.000f - 30.000f + 28.500f + 5.000f + 10.000f + 35.000f - 65.000f + 5.000f + 73.7008f + 28.3465f + 14.1732f;
                        x_firname = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 85.0394f + 3.000f + 56.6929f; y_firname = 450.000f - 330.000f - 30.000f + 28.500f + 5.000f + 10.000f + 35.000f - 65.000f + 5.000f + 85.0394f + 28.3465f + 14.1732f;
                        x_price1 = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 34.0157f + 3.000f + 56.6929f; y_price1 = 450.000f - 330.000f - 30.000f + 28.500f + 5.000f + 10.000f + 35.000f - 65.000f + 5.000f + 34.0157f + 28.3465f + 14.1732f;
                        x_logo = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 119.055f + 3.000f + 56.6929f; y_logo = 450.000f - 330.000f - 30.000f + 28.500f + 5.000f + 10.000f + 35.000f - 65.000f + 5.000f + 28.3465f + 28.3465f + 14.1732f;
                        x_reCuadro = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 3.000f + 56.6929f; y_reCuadro = 450.000f - 330.000f - 30.000f + 28.500f + 5.000f + 10.000f + 35.000f - 65.000f + 5.000f + 28.3465f + 14.1732f;
                    }

                    if (contador == 11)
                    {
                        // 12
                        x_itemCode = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 102.047f + 3.000f + 56.6929f; y_itemCode = 450.000f - 330.000f - 30.000f + 28.500f + 5.000f + 10.000f + 35.000f - 65.000f + 5.000f + 19.8425f + 28.3465f + 14.1732f;
                        x_itemName = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 85.0394f + 3.000f + 56.6929f; y_itemName = 450.000f - 330.000f - 30.000f + 28.500f + 5.000f + 10.000f + 35.000f - 65.000f + 5.000f + 73.7008f + 28.3465f + 14.1732f;
                        x_firname = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 85.0394f + 3.000f + 56.6929f; y_firname = 450.000f - 330.000f - 30.000f + 28.500f + 5.000f + 10.000f + 35.000f - 65.000f + 5.000f + 85.0394f + 28.3465f + 14.1732f;
                        x_price1 = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 34.0157f + 3.000f + 56.6929f; y_price1 = 450.000f - 330.000f - 30.000f + 28.500f + 5.000f + 10.000f + 35.000f - 65.000f + 5.000f + 34.0157f + 28.3465f + 14.1732f;
                        x_logo = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 119.055f + 3.000f + 56.6929f; y_logo = 450.000f - 330.000f - 30.000f + 28.500f + 5.000f + 10.000f + 35.000f - 65.000f + 5.000f + 28.3465f + 28.3465f + 14.1732f;
                        x_reCuadro = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 3.000f + 56.6929f; y_reCuadro = 450.000f - 330.000f - 30.000f + 28.500f + 5.000f + 10.000f + 35.000f - 65.000f + 5.000f + 28.3465f + 14.1732f;
                    }

                    if (contador == 12)
                    {
                        // 13 por qui 
                        x_itemCode = 30.000f + 102.047f + 56.6929f; y_itemCode = 450.000f - 440.000f - 40.000f + 28.500f + 5.000f + 10.000f + 50.0000f - 75.000f + 19.8425f + 28.3465f + 28.3465f;
                        x_itemName = 30.000f + 85.0394f + 56.6929f; y_itemName = 450.000f - 440.000f - 40.000f + 28.500f + 5.000f + 10.000f + 50.0000f - 75.000f + 73.7008f + 28.3465f + 28.3465f;
                        x_firname = 30.000f + 85.0394f + 56.6929f; y_firname = 450.000f - 440.000f - 40.000f + 28.500f + 5.000f + 10.000f + 50.0000f - 75.000f + 85.0394f + 28.3465f + 28.3465f;
                        x_price1 = 30.000f + 34.0157f + 56.6929f; y_price1 = 450.000f - 440.000f - 40.000f + 28.500f + 5.000f + 10.000f + 50.0000f - 75.000f + 34.0157f + 28.3465f + 28.3465f;
                        x_logo = 30.000f + 119.055f + 56.6929f; y_logo = 450.000f - 440.000f - 40.000f + 28.500f + 5.000f + 10.000f + 50.0000f - 75.000f + 28.3465f + 28.3465f + 28.3465f;
                        x_reCuadro = 30.000f + 56.6929f; y_reCuadro = 450.000f - 440.000f - 40.000f + 28.500f + 5.000f + 10.000f + 50.0000f - 75.000f + 28.3465f + 28.3465f;
                    }

                    if (contador == 13)
                    {
                        // 14
                        x_itemCode = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 102.047f + 3.000f + 56.6929f; y_itemCode = 450.000f - 440.000f - 40.000f + 28.500f + 5.000f + 10.000f + 50.0000f - 75.000f + 19.8425f + 28.3465f + 28.3465f;
                        x_itemName = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 85.0394f + 3.000f + 56.6929f; y_itemName = 450.000f - 440.000f - 40.000f + 28.500f + 5.000f + 10.000f + 50.0000f - 75.000f + 73.7008f + 28.3465f + 28.3465f;
                        x_firname = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 85.0394f + 3.000f + 56.6929f; y_firname = 450.000f - 440.000f - 40.000f + 28.500f + 5.000f + 10.000f + 50.0000f - 75.000f + 85.0394f + 28.3465f + 28.3465f;
                        x_price1 = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 34.0157f + 3.000f + 56.6929f; y_price1 = 450.000f - 440.000f - 40.000f + 28.500f + 5.000f + 10.000f + 50.0000f - 75.000f + 34.0157f + 28.3465f + 28.3465f;
                        x_logo = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 119.055f + 3.000f + 56.6929f; y_logo = 450.000f - 440.000f - 40.000f + 28.500f + 5.000f + 10.000f + 50.0000f - 75.000f + 28.3465f + 28.3465f + 28.3465f;
                        x_reCuadro = 240.000f + 13.000f + 5.000f + 28.3465f - 36.8504f + 3.000f + 56.6929f; y_reCuadro = 450.000f - 440.000f - 40.000f + 28.500f + 5.000f + 10.000f + 50.0000f - 75.000f + 28.3465f + 28.3465f;
                    }

                    if (contador == 14)
                    {
                        // 15
                        x_itemCode = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 102.047f + 3.000f + 56.6929f; y_itemCode = 450.000f - 440.000f - 40.000f + 28.500f + 5.000f + 10.000f + 50.0000f - 75.000f + 19.8425f + 28.3465f + 28.3465f;
                        x_itemName = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 85.0394f + 3.000f + 56.6929f; y_itemName = 450.000f - 440.000f - 40.000f + 28.500f + 5.000f + 10.000f + 50.0000f - 75.000f + 73.7008f + 28.3465f + 28.3465f;
                        x_firname = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 85.0394f + 3.000f + 56.6929f; y_firname = 450.000f - 440.000f - 40.000f + 28.500f + 5.000f + 10.000f + 50.0000f - 75.000f + 85.0394f + 28.3465f + 28.3465f;
                        x_price1 = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 34.0157f + 3.000f + 56.6929f; y_price1 = 450.000f - 440.000f - 40.000f + 28.500f + 5.000f + 10.000f + 50.0000f - 75.000f + 34.0157f + 28.3465f + 28.3465f;
                        x_logo = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 119.055f + 3.000f + 56.6929f; y_logo = 450.000f - 440.000f - 40.000f + 28.500f + 5.000f + 10.000f + 50.0000f - 75.000f + 28.3465f + 28.3465f + 28.3465f;
                        x_reCuadro = 450.000f + 26.000f + 10.000f + 28.3465f + 28.3465f - 36.8504f - 34.0157f + 3.000f + 56.6929f; y_reCuadro = 450.000f - 440.000f - 40.000f + 28.500f + 5.000f + 10.000f + 50.0000f - 75.000f + 28.3465f + 28.3465f;
                    }

                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Phrase(dato.ItemCode, Arial), x_itemCode, y_itemCode, 0); // ItemCode

                    // Formato al componente ItemName
                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase(User.shgFormat(dato.ItemName), Arial), x_itemName, y_itemName, 0); // primeros 30 caracteres
                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase(User.shgFormat2(dato.ItemName), Arial), x_itemName, y_itemName - 7.000f, 0); // mitad de la cadena
                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase(User.shgFormat3(dato.ItemName), Arial), x_itemName, y_itemName - 14.000f, 0); // parte final
                    // -------------------------------------------------------------------------------:
                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase(dato.FirtsName, Arial), x_firname, y_firname, 0); // FirmName
                                                                                                                                                        // -------------------------------------------------------------------------------:

                    //---------- Cuadro para habladores pequeños: 
                    PdfContentByte cb = writer.DirectContent;
                    //10.50
                    cb.Rectangle(x_reCuadro, y_reCuadro, 221.102f, 104.882f); // x,y w,h 
                    cb.SetLineWidth(0.50f);
                    cb.SetColorStroke(BaseColor.LIGHT_GRAY);
                    cb.Stroke();

                    if (dato.price1.All(char.IsDigit))
                    {
                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Phrase("PRICE NULL", Arial), x_price1, y_price1, 0); // price1
                    }
                    else
                    {
                        //------------------------------------------------------------------ PROMO MARGARITA ------------------------------------------------------------------:
                        if (Obtner.margarita == true)
                        {
                            // sin el 16%
                            if (tipoPromo == "Se Feliz con entero")
                            {
                                string formulaPorlamar = dato.price1;
                                ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Phrase("$ " + Math.Round(Convert.ToDecimal(formulaPorlamar)), Arial01), x_price1, y_price1, 0); // price1
                            }

                            // sin el 16%
                            else if (tipoPromo == "promo daka")
                            {
                                if (dato.lista4.All(char.IsDigit))
                                {

                                    formula = Math.Round(Convert.ToDecimal(dato.price1));
                                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Phrase("$" + Math.Round(Convert.ToDecimal(formula) - 0.01m, 2), Arial01), x_price1, y_price1, 0); // price1

                                }
                                else
                                {
                                    decimal formula01 = Math.Round(Convert.ToDecimal(dato.lista4)) * 1.16m;

                                    formula = Math.Round(Convert.ToDecimal(dato.price1));
                                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Phrase("$" + Math.Round(Convert.ToDecimal(formula) - 0.01m, 2), Arial01), x_price1, y_price1, 0); // price1

                                }
                            }
                            else if (tipoPromo == "promo actual")
                            {
                                if (dato.lista4.All(char.IsDigit))
                                {

                                    formula = Math.Round(Convert.ToDecimal(dato.price1));
                                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Phrase("$" + Math.Round(Convert.ToDecimal(formula) - 0.01m, 2), Arial01), x_price1, y_price1, 0); // price1

                                }
                                else
                                {
                             
                                    formula = Math.Round(Convert.ToDecimal(dato.price1) * 1.16m);
                                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Phrase("$" + Math.Round(Convert.ToDecimal(formula) - 0.01m, 2), Arial01), x_price1, y_price1, 0); // price1

                                }
                            }
                            // sin el 16%
                            else if (tipoPromo == "Se Feliz .99")
                            {
                                if (dato.lista4.All(char.IsDigit))
                                {

                                    formula = Math.Round(Convert.ToDecimal(dato.price1));
                                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Phrase("$" + Math.Round(Convert.ToDecimal(formula) - 0.01m, 2), Arial01), x_price1, y_price1, 0); // price1

                                }
                                else
                                {
                                 
                                    formula = Math.Round(Convert.ToDecimal(dato.price1));
                                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Phrase("$" + Math.Round(Convert.ToDecimal(formula) - 0.01m, 2), Arial01), x_price1, y_price1, 0); // price1

                                }
                            }
                        }
                        else // ------------------------------------------------------------------- TODAS LAS TIENDAS ----------------------------------------------------------------:
                        {

                            if (AgregarNuevaLista.identificadorLista == "A" || AgregarNuevaLista.identificadorLista == "B" || AgregarNuevaLista.identificadorLista == "C" || AgregarNuevaLista.identificadorLista == "NJ" || AgregarNuevaLista.identificadorLista == "AZ" || AgregarNuevaLista.identificadorLista == "VD")
                            {
                                //formula = Math.Round(Convert.ToDecimal(dato.price1) * 1.16m);
                                formula = (Convert.ToDecimal(dato.price1) * 1.16m);
                                ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$ " + Math.Round(formula, 2), Arial01), x_price1, y_price1, 0); // price1
                            }
                            else
                            {
                                //Aplicacion de la formula con 16%
                                if (tipoPromo == "Se Feliz con entero")
                                {
                                    formula = Math.Round(Convert.ToDecimal(dato.price1) * 1.16m);
                                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Phrase("$ " + Math.Round(formula), Arial01), x_price1, y_price1, 0); // price1
                                }
                                else if (tipoPromo == "promo daka")
                                {
                                    if (dato.lista4.All(char.IsDigit))
                                    {

                                        formula = Math.Round(Convert.ToDecimal(dato.price1) * 1.16m);
                                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Phrase("$" + Math.Round(Convert.ToDecimal(formula) - 0.01m, 2), Arial01), x_price1, y_price1, 0); // price1

                                    }
                                    else
                                    {
                                        decimal formula01 = Math.Round(Convert.ToDecimal(dato.lista4)) * 1.16m;

                                        formula = Math.Round(Convert.ToDecimal(dato.price1) * 1.16m);
                                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Phrase("$" + Math.Round(Convert.ToDecimal(formula) - 0.01m, 2), Arial01), x_price1, y_price1, 0); // price1

                                    }
                                }
                                else if (tipoPromo == "promo actual")
                                {
                                    if (dato.lista4.All(char.IsDigit))
                                    {

                                        formula = Math.Round(Convert.ToDecimal(dato.price1) * 1.16m);
                                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Phrase("$" + Math.Round(Convert.ToDecimal(formula) - 0.01m, 2), Arial01), x_price1, y_price1, 0); // price1

                                    }
                                    else
                                    {
                                        decimal formula01 = Math.Round(Convert.ToDecimal(dato.lista4)) * 1.16m;

                                        formula = Math.Round(Convert.ToDecimal(dato.price1) * 1.16m);
                                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Phrase("$" + Math.Round(Convert.ToDecimal(formula) - 0.01m, 2), Arial01), x_price1, y_price1, 0); // price1

                                    }
                                }
                                else if (tipoPromo == "Se Feliz .99")
                                {
                                    if (dato.lista4.All(char.IsDigit))
                                    {

                                        formula = Math.Round(Convert.ToDecimal(dato.price1) * 1.16m);
                                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Phrase("$" + Math.Round(Convert.ToDecimal(formula) - 0.01m, 2), Arial01), x_price1, y_price1, 0); // price1

                                    }
                                    else
                                    {
                                        decimal formula01 = Math.Round(Convert.ToDecimal(dato.lista4)) * 1.16m;

                                        formula = Math.Round(Convert.ToDecimal(dato.price1) * 1.16m);
                                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Phrase("$" + Math.Round(Convert.ToDecimal(formula) - 0.01m, 2), Arial01), x_price1, y_price1, 0); // price1

                                    }
                                }
                            }
                           
                        }

                    }

                    //IDENTIFICADOR
                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase(AgregarNuevaLista.identificadorLista, ArialN_A), x_logo + 30.000f, y_itemName, 0);
                    if (AgregarNuevaLista.identificadorLista == "AZ" || AgregarNuevaLista.identificadorLista == "NJ" || AgregarNuevaLista.identificadorLista == "VD" || AgregarNuevaLista.identificadorLista == "A" 
                        || AgregarNuevaLista.identificadorLista == "B" || AgregarNuevaLista.identificadorLista == "C")
                    {
                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Phrase("Mercancía Especial", ArialN_A1), x_price1 - 30.000f, y_itemCode, 0); // UBICACIÓN
                    }

                    image2.ScaleAbsoluteWidth(34.0157f); // ancho de la imagen;
                    image2.ScaleAbsoluteHeight(28.3465f); // alto de la imagen;
                    image2.SetAbsolutePosition(x_logo, y_logo); // posicion de la imagen (x,y);
                    doc.Add(image2);

                    contador++;
                }
                contador = 0;
                doc.Close();
                MessageBox.Show("ruta: " + path01);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        //BUSQUEDA
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
			if (comboBox1.SelectedIndex == 0)
			{
				try
				{
					conexion_server.Open();
					SqlCommand cmd = conexion_server.CreateCommand();

					// Budqueda por nombre
					string textQueryBusqueda = "";

					if (Obtner.margarita == true)
					{
						textQueryBusqueda = AgregarNuevaLista.busquedaEnLaListaNombre(textBox1.Text, Obtner.IndiceLista);
					}
					else
					{
						textQueryBusqueda = AgregarNuevaLista.busquedaEnLaListaNombre(textBox1.Text, Obtner.IndiceLista);
					}
					cmd.CommandText = textQueryBusqueda;
					DataTable dt = new DataTable();
					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					adapter.Fill(dt);
					dataGridView1.DataSource = dt;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				finally
				{
					conexion_server.Close();
				}

				// Ocultar columnas
				dataGridView1.Columns["Nombre"].Width = 400;
				dataGridView1.Columns["Marca"].Visible = false;
				dataGridView1.Columns["Garantia"].Visible = false;
				dataGridView1.Columns["Codigo_Barra"].Visible = false;
				dataGridView1.Columns["PrecioaMostrar"].Visible = false;
				dataGridView1.Columns["PrecioTachado"].Visible = false;
			}
			else if (comboBox1.SelectedIndex == 1)
			{
				// busqueda por codigo
				try
				{
					conexion_server.Open();
					SqlCommand cmd = conexion_server.CreateCommand();

					// busqueda por codigo
					string textQueryBusqueda = "";

					if (Obtner.margarita == true)
					{
						textQueryBusqueda = AgregarNuevaLista.busquedaEnLaLista(textBox1.Text, Obtner.IndiceLista, Obtner.sucursal, Obtner.almacen, Obtner.almacen1, Obtner.almacen2, Obtner.almacen3, Obtner.almacen4, Obtner.almacen5, Obtner.almacen6, Obtner.almacen7, Obtner.almacen8, Obtner.almacen9, Obtner.almacen10, Obtner.almacen11, Obtner.almacen12, Obtner.almacen13, Obtner.almacen14);
					}
					else
					{
						textQueryBusqueda = AgregarNuevaLista.busquedaEnLaLista(textBox1.Text, Obtner.IndiceLista, Obtner.sucursal, Obtner.almacen, Obtner.almacen1, Obtner.almacen2, Obtner.almacen3, Obtner.almacen4, Obtner.almacen5, Obtner.almacen6, Obtner.almacen7, Obtner.almacen8, Obtner.almacen9, Obtner.almacen10, Obtner.almacen11, Obtner.almacen12, Obtner.almacen13, Obtner.almacen14);
					}
					cmd.CommandText = textQueryBusqueda;
					DataTable dt = new DataTable();
					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					adapter.Fill(dt);
					dataGridView1.DataSource = dt;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				finally
				{
					conexion_server.Close();
				}

				// Ocultar columnas
				dataGridView1.Columns["Nombre"].Width = 400;
				dataGridView1.Columns["Marca"].Visible = false;
				dataGridView1.Columns["Garantia"].Visible = false;
				dataGridView1.Columns["Codigo_Barra"].Visible = false;
				dataGridView1.Columns["PrecioaMostrar"].Visible = false;
				dataGridView1.Columns["PrecioTachado"].Visible = false;
			}


		}

		private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // MouseDown
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            shpMove = true;
        }

        // MouseDown
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (shpMove)
            {
                this.Location = Cursor.Position;
            }
        }

        // MouseUp
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            shpMove = false;
        }

        private void shp_MouseDown(object sender, MouseEventArgs e)
        {
        }
        private void shp_MouseMove(object sender, MouseEventArgs e)
        {
        }
        private void shp_MouseUp(object sender, MouseEventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }

        // Cargar lista de precios mediate un excell
        private void button7_Click(object sender, EventArgs e)
        {
            /*Obtener la ubicación exacta del archivo*/
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Obtner.ecxellUbicacion = openFileDialog1.FileName;
            }

            /*--Retorna una lista con los valores del fichero(exell, csv)--
             *Es necesario crear una lista que reciba esos valores*/
            List<string> productsCsv = new List<string>();
            productsCsv = DefaultConnection.leer().ToList();

            /*--Llamar a la función (Consulta(articulo[LB-0]))--*/
            foreach (string product in productsCsv)
            {
                
                consulta(product, Obtner.IndiceLista);
            }

            // controller
            void consulta(string codigoSap, string IndiceLista)
            {
				/*--Var--*/
				//string query = @"SELECT 
				//                   T1.[Referencia] ItemCode
				//                  ,T1.[Nombre] ItemName
				//               ,T5.[Marca] FirmName
				//               ,T4.[CantidadDiasGarantia] U_DK_GARANTIA
				//               ,isNull(T3.[Barra], 0) CodeBar
				//               ,T2.[Precio] Price1
				//               ,0 Price2
				//              FROM [DB_AWS_MELE].[dbo].[Transaccional.Productos] T1 
				//              INNER JOIN [DB_AWS_MELE].[dbo].[ListasPrecios] T2 ON T1.Referencia = T2.[Cod_Producto]
				//              INNER JOIN [DB_AWS_MELE].[dbo].[Transaccional.Empaques] T3 ON  T1.[IdProducto] = T3.[IdProducto]
				//              INNER JOIN [DB_AWS_MELE].[dbo].[ProductosGarantias] T4 ON T1.[Referencia] = T4.[Cod_Producto]
				//              INNER JOIN [DB_AWS_MELE].[dbo].[Marcas] T5 ON T4.[Cod_Marca] = T5.[Cod_Marca] 
				//              WHERE T1.[Referencia] LIKE 'L%' AND T1.[Referencia] LIKE '" + codigoSap + "%' AND T2.Cod_ListaPrecio = '" + IndiceLista + "' AND T3.[NumeroUnidades] > 0";

				string query = @"
                    SELECT DISTINCT TOP (100)
                       T1.[Referencia] Codigo
                      ,T1.[Nombre] Nombre
                      ,T5.[Marca] Marca
                      ,T4.[CantidadDiasGarantia] Garantia
                      ,isNull(T3.[Barra], 0) Codigo_Barra
                      ,T2.[Precio] PrecioaMostrar
                      ,0 PrecioTachado
                      --,T6.Inventario
                      --,T6.CodigoSucursal
	                  --,T6.Sucursal
	                  --,T6.CodArea
                  FROM [DB_AWS_MELE].[dbo].[Transaccional.Productos] T1 
                  INNER JOIN [DB_AWS_MELE].[dbo].[ListasPrecios] T2 ON T1.Referencia = T2.[Cod_Producto]
                  INNER JOIN [DB_AWS_MELE].[dbo].[Transaccional.Empaques] T3 ON  T1.[IdProducto] = T3.[IdProducto]
                  INNER JOIN [DB_AWS_MELE].[dbo].[ProductosGarantias] T4 ON T1.[Referencia] = T4.[Cod_Producto]
                  INNER JOIN [DB_AWS_MELE].[dbo].[Marcas] T5 ON T4.[Cod_Marca] = T5.[Cod_Marca]
                  INNER JOIN [TIENDAS_MELE].[dbo].[TM_VW_ExistenciaTiendasMele] T6 ON T2.[Cod_Producto] = T6.[CodArticulo]
                  WHERE (T1.[Referencia] NOT LIKE 'LB%' AND  T1.[Referencia] NOT LIKE 'LM%'  AND  T1.[Referencia] NOT LIKE 'LJ%') AND T1.[Referencia] LIKE '" + codigoSap + "%' AND T2.Cod_ListaPrecio = '" + IndiceLista + "' AND T3.[NumeroUnidades] > 0  AND T6.CodigoSucursal = '" + Obtner.sucursal + "' AND T6.Inventario > 0 AND T6.CodArea IN ('" + Obtner.almacen + "', '" + Obtner.almacen1 + "', '" + Obtner.almacen2 + "', '" + Obtner.almacen3 + "', '" + Obtner.almacen4 + "', '" + Obtner.almacen5 + "', '" + Obtner.almacen6 + "', '" + Obtner.almacen7 + "', '" + Obtner.almacen8 + "', '" + Obtner.almacen9 + "', '" + Obtner.almacen10 + "', '" + Obtner.almacen11 + "', '" + Obtner.almacen12 + "', '" + Obtner.almacen13 + "', '" + Obtner.almacen14 + "')";

				/*--Realizara la consulta por cada articulo--*/
				SqlConnection conn = new SqlConnection(DefaultConnection.connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string ItemCode = reader[0].ToString();
                    string ItemName = reader[1].ToString();
                    string price1 = reader[5].ToString();
                    string FirstName = reader[2].ToString();
                    string lista4 = reader[6].ToString();

                    List<ArticuloP> articulos01()
                    {
                        return new List<ArticuloP>
                        {
                             new ArticuloP{ItemCode=ItemCode, ItemName=ItemName, price1=price1, FirstName=FirstName, lista4=lista4}
                        };
                    }

                    ArticuloP dt01 = new ArticuloP();
                    foreach (var articulo01 in articulos01())
                    {
                        dt01.ItemCode = articulo01.ItemCode;
                        dt01.ItemName = articulo01.ItemName;
                        dt01.price1 = articulo01.price1;
                        dt01.FirstName = articulo01.FirstName;
                        dt01.lista4 = articulo01.lista4;

                        listaEcxell01.Add(dt01);
                    }
                }
                reader.Close();
                conn.Close();
            }

            foreach (var hablador in listaEcxell01)
            {
                dataGridView2.Rows.Add(hablador.ItemCode, hablador.ItemName, hablador.price1, hablador.FirstName, hablador.lista4);
            }
        }

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
    
}







