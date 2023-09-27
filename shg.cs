// NAME-TEC-AL-0001
// VERSION-Alpha 1.0.0
// AUTHOR-ALICE
// FECHA-24/08/2022

using System.Data;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Xml;
using System.Text;
using phApp.Model;
using System.Windows.Forms;

namespace phApp
{
    public partial class shg : Form
    {
        public SqlConnection conexion_server = new SqlConnection(DefaultConnection.connectionString);

        List<datos> lista = new List<datos>();
        List<Articulo> listaEcxell = new List<Articulo>();

        decimal formula = 0;

        int contador = 0;
        string psCaracter = "";
        float medioCm = 14.1732f;

        float x_itemCode = 260.000f;
        float y_itemCode = 490.276f;

        float x_itemName = 141.732f;
        float y_itemName = 549.000f;

        float x_garantia = 200.000f;
        float y_garantia = 425.197f;

        float x_firname = 141.732f;
        float y_firname = 566.929f;

        float x_price1 = 70f;
        float y_price1 = 470f;

        float x_logo = 250.000f;
        float y_logo = 525.276f;

        float x_codebar = 200.000f;
        float y_codebar = 455.276f;

        float x_reCuadro = 30.000f;
        float y_reCuadro = 70.000f;

        public shg()
        {
            InitializeComponent();
        }

        bool shgMove = false;

        private void shg_Load(object sender, EventArgs e)
        {
            //----------
            comboBox1.Items.Add("Nombre Articulo");
            comboBox1.Items.Add("Código Articulo");

            try
            {
                string listaPrecio = Obtner.query;
                Obtner.IndiceLista = "2";

                if (Obtner.margarita == true)
                {
                    //Obtner.IndiceLista = "6";
                    listaPrecio = AgregarNuevaLista.listaSeleccionada("1");
                    //listaPrecio = Obtner.queryMargarita;
                }
                else if (Obtner.azul == true)
                {
                    listaPrecio = AgregarNuevaLista.listaSeleccionada("3"); 
                }
                else if (Obtner.naranja == true)
                {
                    listaPrecio = AgregarNuevaLista.listaSeleccionada("4");
                }
                else if (Obtner.verde == true)
                {
                    listaPrecio = AgregarNuevaLista.listaSeleccionada("6");
                }
                else if (Obtner.A == true)
                {
                    listaPrecio = AgregarNuevaLista.listaSeleccionada("8");
                }
                else if (Obtner.B == true)
                {
                    listaPrecio = AgregarNuevaLista.listaSeleccionada("9");
                }
                else if (Obtner.C == true)
                {
                    listaPrecio = AgregarNuevaLista.listaSeleccionada("10");
                }
                else if (Obtner.Maturin == true)
                {
                    listaPrecio = AgregarNuevaLista.listaSeleccionada("100");
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

        // // ----------SELECCIÓN MANUAL >
        private void button1_Click(object sender, EventArgs e)
        {
            lista.RemoveAll(lista.Remove);
            // buscador 
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                datos dt = new datos();

                if (row.Selected)
                {
                    // error al utilizar la busqueda
                    dt.ItemCode = row.Cells[0].Value.ToString();
                    dt.ItemName = row.Cells[1].Value.ToString();
                    dt.FirtsName = row.Cells[2].Value.ToString();
                    dt.garantia = row.Cells[3].Value.ToString();
                    dt.CodeBars = row.Cells[4].Value.ToString();
                    dt.price1 = row.Cells[5].Value.ToString(); // solucionado
                    dt.lista4 = row.Cells[6].Value.ToString();

                    lista.Add(dt);
                }
            }

            foreach (var dato in lista)
            {
                dataGridView2.Rows.Add(dato.ItemCode, dato.ItemName, dato.FirtsName, dato.garantia, dato.CodeBars, dato.price1, dato.lista4);
            }
            lista.RemoveAll(lista.Remove);
        }

        // ----------SELECCIÓN AUTOMATICA >>
        private void button2_Click(object sender, EventArgs e)
        {
            // probar aqui el buscador
            dataGridView1.SelectAll();
            lista.RemoveAll(lista.Remove);
            // buscador 
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                datos dt = new datos();

                if (row.Selected)
                {
                    // error al utilizar la busqueda
                    dt.ItemCode = row.Cells[0].Value.ToString();
                    dt.ItemName = row.Cells[1].Value.ToString();
                    dt.FirtsName = row.Cells[2].Value.ToString();
                    dt.garantia = row.Cells[3].Value.ToString();
                    dt.CodeBars = row.Cells[4].Value.ToString();
                    dt.price1 = row.Cells[5].Value.ToString(); // solucionado
                    dt.lista4 = row.Cells[6].Value.ToString();

                    lista.Add(dt);
                }
            }

            foreach (var dato in lista)
            {
                dataGridView2.Rows.Add(dato.ItemCode, dato.ItemName, dato.FirtsName, dato.garantia, dato.CodeBars, dato.price1, dato.lista4);
            }
            lista.RemoveAll(lista.Remove);
        }

        // ----------DESELECCIÓN <
        private void button3_Click(object sender, EventArgs e)
        {
            lista.RemoveAll(lista.Remove);
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Selected)
                {
                    dataGridView2.Rows.Remove(row);
                }
            }
            lista.RemoveAll(lista.Remove);
        }

        // ----------DESELECCIÓN AUTOMATICA <<
        private void button4_Click(object sender, EventArgs e)
        {
            lista.RemoveAll(lista.Remove);
            dataGridView2.Rows.Clear();
            lista.RemoveAll(lista.Remove);
        }

        // shg.BOTON_GENERAR.PDF
        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("La lista de datos esta Vacía");
            }
            else
            {
                dataGridView2.SelectAll();
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    datos dt = new datos();

                    if (row.Selected)
                    {
                        // error al utilizar la busqueda
                        dt.ItemCode = row.Cells[0].Value.ToString();
                        dt.ItemName = row.Cells[1].Value.ToString();
                        dt.FirtsName = row.Cells[2].Value?.ToString();
                        dt.garantia = row.Cells[3].Value?.ToString();
                        dt.CodeBars = row.Cells[4].Value?.ToString();
                        dt.price1 = row.Cells[5].Value?.ToString();
                        dt.lista4 = row.Cells[6].Value?.ToString();

                        lista.Add(dt);
                    }
                }

                //------- CARPETA PARA EL ARCHIVO HABLADORES:
                string path01 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\TI.DAKA-HABLADORES\";
                string path02 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string dtime = DateTime.Now.ToString("dd -MM-yyyy H-mm-ss"); // obtener fecha actual

                //------- XML
                // variables
                int contadorRuta = 0;
                string ruta = "";

                // ruta del fichero xml
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
                    if (contadorRuta == 3)
                    {
                        ruta = value.ToString();
                    }
                    contadorRuta++;
                }

                string folderPath = path01;
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // CAMBIO DE LOGO
                string tipoLogo = "";
                string tipoPromo = "";
                int valor = Obtner.valorLogo;

                if (valor == 0)
                {
                    // Se Feliz con entero
                    tipoLogo = @"\\192.168.21.126\Publico\DevTEC-AL-0001\image\logo\Logo Daka - 1,7x1.5cm.png";
                    tipoPromo = "se feliz";
                }
                else if (valor == 1)
                {
                    // Pida su Descuento
                    tipoLogo = @"\\192.168.21.126\Publico\DevTEC-AL-0001\image\logo\Logo Daka - 1,7x1.5cm.png";
                    tipoPromo = "pida su descuento";
                }
                else if (valor == 2)
                {
                    // Promo Daka
                    tipoLogo = @"\\192.168.21.126\Publico\DevTEC-AL-0001\image\logo\Logo Hablador Grande - 2,3x1.2cm.png";
                    tipoPromo = "promo daka";
                }
                else if (valor == 3)
                {
                    // Promo Actual
                    tipoLogo = ruta;
                    tipoPromo = "promo actual";
                }
                else if (valor == 4)
                {
                    // Se Feliz con .99
                    tipoLogo = @"\\192.168.21.126\Publico\DevTEC-AL-0001\image\logo\Logo Daka - 1,7x1.5cm.png";
                    tipoPromo = "Se Feliz .99";
                }

                // TIPOS DE LETRA Y TAMAÑO
                iTextSharp.text.Font Arial = FontFactory.GetFont("Arial", 12);
                iTextSharp.text.Font ArialP = FontFactory.GetFont("Arial", 10);
                iTextSharp.text.Font ArialBold = FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font Arial01 = FontFactory.GetFont("Arial", 26, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font Arial001 = FontFactory.GetFont("Arial", 16, iTextSharp.text.Font.BOLD);
                FontFamily fontFamily = new FontFamily("Arial");

                // PDF
                Document doc = new Document();
                doc.SetPageSize(iTextSharp.text.PageSize.A4.Rotate());
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(path01 + dtime + @" TI.DAKA-HABLADOR_G_PRUEBAS.pdf", FileMode.Create)); // DIRECIÓN DEL FICHERO PDF

                iTextSharp.text.Image image2 = iTextSharp.text.Image.GetInstance(tipoLogo); // DIRECCIÓN IMAGEN LOGO, ACCEDER SIEMPRE A LA CARPETA IMAGENES
                doc.Open();

                // Para el codigo de barras
                string codigoBarras = "";

                // HABLADORES G
                int contBarraProcesos = 0;
                foreach (var dato in lista) // lista
                {
                    if (dato.ItemCode == "LB-00001357")
                    {
                        dato.ItemName = "MICROONDAS FMDO20S3GSPW FMDO20S3GSPW FRIGIDAIRE";
                    }
                    // --------------------------- PARCHE 1.0 PARA LA SOLUCIÓN DEL ERROR: CODE39
                    try
                    {
                        // CÓDIGO DE BARRAS 
                        codigoBarras = dato.CodeBars.ToString();
                        BarcodeLib.Barcode codeBars = new BarcodeLib.Barcode();
                        codeBars.IncludeLabel = true;
                        codeBars.Alignment = BarcodeLib.AlignmentPositions.CENTER;
                        codeBars.LabelFont = new System.Drawing.Font(fontFamily, 10, FontStyle.Regular);

                        codeBars.Encode(BarcodeLib.TYPE.CODE39, codigoBarras, Color.Black, Color.White, 300, 100); //dato.CodeBars 
                        codeBars.SaveImage(path02 + @"new_code.png", BarcodeLib.SaveTypes.PNG);
                    }
                    catch
                    {
                        codigoBarras = "INVALID DATA";
                        BarcodeLib.Barcode codeBars = new BarcodeLib.Barcode();
                        codeBars.IncludeLabel = true;
                        codeBars.Alignment = BarcodeLib.AlignmentPositions.CENTER;
                        codeBars.LabelFont = new System.Drawing.Font(fontFamily, 10, FontStyle.Regular);

                        codeBars.Encode(BarcodeLib.TYPE.CODE39, codigoBarras, Color.Black, Color.White, 300, 100); //dato.CodeBars
                        codeBars.SaveImage(path02 + @"new_code.png", BarcodeLib.SaveTypes.PNG);
                    }

                    iTextSharp.text.Image image1 = iTextSharp.text.Image.GetInstance(path02 + @"new_code.png"); // DIRECCIÓN IMAGEN CÓDIGO
                    if (contador > 3)
                    {
                        doc.NewPage();
                        contador = 0;
                    }
                    if (contador == 0)
                    {
                        x_itemCode = 70.000f + 238.11f + 56.6929f; y_itemCode = 340.000f - 20.000f + 133.228f; //
                        x_itemName = 70.000f + 113.386f + 56.6929f; y_itemName = 340.000f - 20.000f + 187.087f; //
                        x_garantia = 70.000f + 155.906f + 56.6929f; y_garantia = 340.000f - 20.000f + 62.3622f; //
                        x_firname = 70.000f + 113.386f + 56.6929f; y_firname = 340.000f - 20.000f + 204.094f; //
                        x_price1 = 70.000f + 51.0236f + 56.6929f; y_price1 = 340.000f - 20.000f + 99.2126f; //
                        x_logo = 70.000f + 249.449f + 56.6929f; y_logo = 340.000f - 20.000f + 167.244f; //
                        x_codebar = 70.000f + 206.929f + 56.6929f; y_codebar = 340.000f - 20.000f + 99.2126f; //
                        x_reCuadro = 340.000f - 20.000f; y_reCuadro = 70.000f + 56.6929f;
                    }

                    if (contador == 1) // SEGUNDA POSICIÓN
                    {
                        x_itemCode = 470.000f - 20.000f - 15.000f + 238.11f + 56.6929f; y_itemCode = 340.000f - 20.000f + 133.228f; //
                        x_itemName = 470.000f - 20.000f - 15.000f + 113.386f + 56.6929f; y_itemName = 340.000f - 20.000f + 187.087f; //
                        x_garantia = 470.000f - 20.000f - 15.000f + 155.906f + 56.6929f; y_garantia = 340.000f - 20.000f + 62.3622f; //
                        x_firname = 470.000f - 20.000f - 15.000f + 113.386f + 56.6929f; y_firname = 340.000f - 20.000f + 204.094f; //
                        x_price1 = 470.000f - 20.000f - 15.000f + 51.0236f + 56.6929f; y_price1 = 340.000f - 20.000f + 99.2126f; //
                        x_logo = 470.000f - 20.000f - 15.000f + 249.449f + 56.6929f; y_logo = 340.000f - 20.000f + 167.244f; //
                        x_codebar = 470.000f - 20.000f - 15.000f + 206.929f + 56.6929f; y_codebar = 340.000f - 20.000f + 99.2126f; //
                        x_reCuadro = 340.000f - 20.000f; y_reCuadro = 470.000f - 20.000f - 15.000f + 56.6929f; //Y X
                    }

                    if (contador == 2) // TERCERA POSICIÓN
                    {
                        x_itemCode = 70.000f + 238.11f + 56.6929f; y_itemCode = 70.000f - 20.000f + 7.000f + 133.228f;
                        x_itemName = 70.000f + 113.386f + 56.6929f; y_itemName = 70.000f - 20.000f + 7.000f + +187.087f;
                        x_garantia = 70.000f + 155.906f + 56.6929f; y_garantia = 70.000f - 20.000f + 7.000f + 62.3622f;
                        x_firname = 70.000f + 113.386f + 56.6929f; y_firname = 70.000f - 20.000f + 7.000f + 204.094f;
                        x_price1 = 70.000f + 51.0236f + 56.6929f; y_price1 = 70.000f - 20.000f + 7.000f + 99.2126f;
                        x_logo = 70.000f + 249.449f + 56.6929f; y_logo = 70.000f - 20.000f + 7.000f + 167.244f;
                        x_codebar = 70.000f + 206.929f + 56.6929f; y_codebar = 70.000f - 20.000f + 7.000f + 99.2126f;
                        x_reCuadro = 70.000f - 20.000f + 7.000f; y_reCuadro = 70.000f + 56.6929f;
                    }

                    if (contador == 3) // CUARTA POSICIÓN
                    {
                        x_itemCode = 470.000f - 20.000f - 15.000f + 238.11f + 56.6929f; y_itemCode = 70.000f - 20.000f + 7.000f + 133.228f;
                        x_itemName = 470.000f - 20.000f - 15.000f + 113.386f + 56.6929f; y_itemName = 70.000f - 20.000f + 7.000f + +187.087f;
                        x_garantia = 470.000f - 20.000f - 15.000f + 155.906f + 56.6929f; y_garantia = 110.000f - 20.000f + 10.000f + 14.1732f;
                        x_firname = 470.000f - 20.000f - 15.000f + 113.386f + 56.6929f; y_firname = 70.000f - 20.000f + 7.000f + 204.094f;
                        x_price1 = 470.000f - 20.000f - 15.000f + 51.0236f + 56.6929f; y_price1 = 70.000f - 20.000f + 7.000f + 99.2126f;
                        x_logo = 470.000f - 20.000f - 15.000f + 249.449f + 56.6929f; y_logo = 70.000f - 20.000f + 7.000f + 167.244f;
                        x_codebar = 470.000f - 20.000f - 15.000f + 206.929f + 56.6929f; y_codebar = 70.000f - 20.000f + 7.000f + 99.2126f;
                        x_reCuadro = 70.000f - 20.000f + 7.000f; y_reCuadro = 470.000f - 20.000f - 15.000f + 56.6929f; //Y X
                    }

                    PdfContentByte cb = writer.DirectContent;
                    cb.Rectangle(y_reCuadro - 30.000f, x_reCuadro, 362.8346f, 263.622f); // x,y w,h
                    cb.SetLineWidth(0.50f);
                    cb.SetColorStroke(BaseColor.LIGHT_GRAY);
                    cb.Stroke();

                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase(dato.ItemCode, ArialP), x_itemCode, y_itemCode, 0); // ItemCode

                    // Formato al componente ItemName
                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase(User.shgFormat(dato.ItemName), Arial), x_itemName, y_itemName, 0); // primeros 30 caracteres
                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase(User.shgFormat2(dato.ItemName), Arial), x_itemName, y_itemName - 15.000f, 0); // mitad de la cadena
                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase(User.shgFormat3(dato.ItemName), Arial), x_itemName, y_itemName - 30.000f, 0); // parte final
                    //-----------------------------------------------------------------------------------------------------------------------------------------------------:
                   
                    if (Obtner.IndiceLista == "3" || Obtner.IndiceLista == "4" || Obtner.IndiceLista == "6")
                    {
                        string psCaracter = dato.ItemCode;
                        psCaracter = psCaracter.Substring(0, 2);

                        if (psCaracter == "LD" || psCaracter == "LH" || psCaracter == "LJ" || psCaracter == "LC" || psCaracter == "LF" || psCaracter == "LP" || psCaracter == "LL")
                        {
                            ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("Tiempo de Garantía 30 días", ArialP), x_garantia, y_garantia, 0); // D_K.Garantía
                        }
                        else if (psCaracter == "LB" || psCaracter == "LM")
                        {
                            ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("Tiempo de Garantía 90 días", ArialP), x_garantia, y_garantia, 0); // D_K.Garantía
                        }
                        else
                        {
                            ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("", ArialP), x_garantia, y_garantia, 0); // D_K.Garantía
                        }

                    }
                    else
                    {
                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("Tiempo de Garantía " + Math.Round(Convert.ToDecimal(dato.garantia)) + " días", ArialP), x_garantia, y_garantia, 0); // D_K.Garantía
                    }

                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase(dato.FirtsName, ArialBold), x_firname, y_firname, 0); // FirmName
                    //------------------------------------------------------------------ PROMO MARGARITA ------------------------------------------------------------------:
                    if (dato.price1.All(char.IsDigit))
                    {
                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("PRICE NULL", ArialBold), x_price1, y_price1, 0); // price1
                    }
                    else
                    {
                        if (Obtner.margarita == true)
                        {
                            // Tipo de promoción sin 16% // modificado
                            if (tipoPromo == "se feliz")
                            {
                                string formulaMargarita = dato.price1;
                                ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$  " + Math.Ceiling(Convert.ToDecimal(formulaMargarita)) + ",00", Arial01), x_price1, y_price1, 0); // price1
                            }

                            // Tipo de promoción sin 16%
                            if (tipoPromo == "pida su descuento") // pida su descuento
                            {
                                psCaracter = dato.ItemCode;
                                psCaracter = psCaracter.Substring(0, 2);

                                ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_RIGHT, new Phrase("Pida Su Descuento", Arial001), x_garantia, y_garantia + medioCm, 0); // Frase Pida

                                if (psCaracter == "LB")
                                {
                                    //form1
                                    decimal formula01 = Math.Round(Convert.ToDecimal(dato.price1));
                                    decimal formula02 = Math.Ceiling(formula01 + (formula01 * 0.15m));

                                    formula = Math.Round(Convert.ToDecimal(dato.price1)) - 0.01m;
                                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$  " + Math.Round(formula, 2), Arial01), x_price1, y_price1, 0); // price1
                                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$" + Math.Round(Convert.ToDecimal(formula02), 2), ArialBold), x_price1, y_itemCode, 0); // price2
                                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("____", ArialBold), x_price1, y_itemCode + 5.000f, 0); // price1
                                }
                                else if (psCaracter == "LM")
                                {
                                    //form2
                                    decimal formula01 = Math.Round(Convert.ToDecimal(dato.price1));
                                    decimal formula02 = Math.Ceiling(formula01 + (formula01 * 0.10m));

                                    formula = Math.Round(Convert.ToDecimal(dato.price1)) - 0.01m;
                                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$  " + Math.Round(formula, 2), Arial01), x_price1, y_price1, 0); // price1
                                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$" + Math.Round(Convert.ToDecimal(formula02), 2), ArialBold), x_price1, y_itemCode, 0); // price2
                                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("____", ArialBold), x_price1, y_itemCode + 5.000f, 0); // price1
                                }
                                else if (psCaracter == "LD")//and laptops
                                {
                                    int truelaptop = 0;
                                    truelaptop = dato.ItemName.IndexOf("LAPTOP");

                                    if (truelaptop != 0)
                                    {
                                        formula = Math.Round(Convert.ToDecimal(dato.price1)) - 0.01m;
                                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$  " + Math.Round(formula, 2), Arial01), x_price1, y_price1, 0); // price1
                                    }
                                    else
                                    {
                                        //form3
                                        decimal formula01 = Math.Round(Convert.ToDecimal(dato.price1));
                                        decimal formula02 = Math.Ceiling(formula01 + (formula01 * 0.10m));

                                        formula = Math.Round(Convert.ToDecimal(dato.price1)) - 0.01m;
                                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$  " + Math.Round(formula, 2), Arial01), x_price1, y_price1, 0); // price1
                                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$" + Math.Round(Convert.ToDecimal(formula02), 2), ArialBold), x_price1, y_itemCode, 0); // price2
                                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("____", ArialBold), x_price1, y_itemCode + 5.000f, 0); // price1
                                    }
                                }
                                else
                                {
                                    formula = Math.Round(Convert.ToDecimal(dato.price1));
                                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$  " + Math.Round(formula, 2), Arial01), x_price1, y_price1, 0); // price1
                                }
                            }
                            else if (tipoPromo == "promo daka") // esto es promo daka
                            {
                                if (dato.lista4.All(char.IsDigit))
                                {
                                    formula = Math.Round(Convert.ToDecimal(dato.price1)) - 0.01m;
                                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$  " + Math.Round(formula, 2), Arial01), x_price1, y_price1, 0); // price1
                                }
                                else
                                {
                                    decimal formula01 = Math.Round(Convert.ToDecimal(dato.lista4) * 1.16m);

                                    formula = Math.Round(Convert.ToDecimal(dato.price1)) - 0.01m;
                                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$  " + Math.Round(formula, 2), Arial01), x_price1, y_price1, 0); // price1
                                }
                            }
                            else if (tipoPromo == "promo actual") // esto es promo actual
                            {
                                if (dato.lista4.All(char.IsDigit))
                                {
                                    formula = Math.Round(Convert.ToDecimal(dato.price1)) - 0.01m;
                                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$  " + Math.Round(formula, 2), Arial01), x_price1, y_price1, 0); // price1
                                }
                                else
                                {
                                    decimal formula01 = Math.Round(Convert.ToDecimal(dato.lista4) * 1.16m);

                                    formula = Math.Round(Convert.ToDecimal(dato.price1)) - 0.01m;
                                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$  " + Math.Round(formula, 2), Arial01), x_price1, y_price1, 0); // price1

                                }
                            }
                            else if (tipoPromo == "Se Feliz .99") // se feliz .99
                            {
                                if (dato.lista4.All(char.IsDigit))
                                {
                                    formula = Math.Round(Convert.ToDecimal(dato.price1)) - 0.01m;
                                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$  " + Math.Round(formula, 2), Arial01), x_price1, y_price1, 0); // price1
                                }
                                else
                                {

                                    formula = Math.Round(Convert.ToDecimal(dato.price1)) - 0.01m;
                                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$  " + Math.Round(formula, 2), Arial01), x_price1, y_price1, 0); // price1
                                }
                            }
                        }
                        else // ------------------------------------------------------------------- TODAS LAS TIENDAS ------------------------------------------------------------------:
                        {
                            if (AgregarNuevaLista.identificadorLista == "A" || AgregarNuevaLista.identificadorLista == "B" || AgregarNuevaLista.identificadorLista == "C" || AgregarNuevaLista.identificadorLista == "NJ" || AgregarNuevaLista.identificadorLista == "AZ" || AgregarNuevaLista.identificadorLista == "VD")
                            {
                                //formula = Math.Round(Convert.ToDecimal(dato.price1) * 1.16m);
                                formula = (Convert.ToDecimal(dato.price1) * 1.16m);
                                ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$  " + Math.Round(formula, 2), Arial01), x_price1, y_price1, 0); // price1
                            }
                            else
                            {
                                // Tipo de promoción con el 16%
                                if (tipoPromo == "se feliz")
                                {
                                    //formula = Math.Round(Convert.ToDecimal(dato.price1) * 1.16m);
                                    formula = (Convert.ToDecimal(dato.price1) * 1.16m);
                                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$  " + Math.Round(formula) + ",00", Arial01), x_price1, y_price1, 0); // price1
                                }
                                if (tipoPromo == "pida su descuento")
                                {
                                    psCaracter = dato.ItemCode;
                                    psCaracter = psCaracter.Substring(0, 2);

                                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_RIGHT, new Phrase("Pida Su Descuento", Arial001), x_garantia, y_garantia + medioCm, 0); // Frase Pida

                                    if (psCaracter == "LB")
                                    {
                                        //"___________" probar esta para el tachado 
                                        //form1
                                        decimal formula01 = Math.Round(Convert.ToDecimal(dato.price1)) * 1.16m;
                                        decimal formula02 = Math.Ceiling(formula01 + (formula01 * 0.15m));

                                        formula = Math.Round(Convert.ToDecimal(dato.price1) * 1.16m) - 0.01m;
                                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$  " + Math.Round(formula, 2), Arial01), x_price1, y_price1, 0); // price1
                                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$" + Math.Round(Convert.ToDecimal(formula02), 2), ArialBold), x_price1, y_itemCode, 0); // price2
                                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("____", ArialBold), x_price1, y_itemCode + 5.000f, 0); // price1
                                    }
                                    else if (psCaracter == "LM")
                                    {
                                        //form2
                                        decimal formula01 = Math.Round(Convert.ToDecimal(dato.price1)) * 1.16m;
                                        decimal formula02 = Math.Ceiling(formula01 + (formula01 * 0.10m));

                                        formula = Math.Round(Convert.ToDecimal(dato.price1) * 1.16m) - 0.01m;
                                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$  " + Math.Round(formula, 2), Arial01), x_price1, y_price1, 0); // price1
                                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$" + Math.Round(Convert.ToDecimal(formula02), 2), ArialBold), x_price1, y_itemCode, 0); // price2
                                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("____", ArialBold), x_price1, y_itemCode + 5.000f, 0); // price1
                                    }
                                    else if (psCaracter == "LD")//and laptops
                                    {
                                        int truelaptop = 0;
                                        truelaptop = dato.ItemName.IndexOf("LAPTOP");

                                        if (truelaptop != 0)
                                        {
                                            formula = Math.Round(Convert.ToDecimal(dato.price1) * 1.16m) - 0.01m;
                                            ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$  " + Math.Round(formula, 2), Arial01), x_price1, y_price1, 0); // price1
                                        }
                                        else
                                        {
                                            //form3
                                            decimal formula01 = Math.Round(Convert.ToDecimal(dato.price1)) * 1.16m;
                                            decimal formula02 = Math.Ceiling(formula01 + (formula01 * 0.10m));

                                            formula = Math.Round(Convert.ToDecimal(dato.price1) * 1.16m) - 0.01m;
                                            ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$  " + Math.Round(formula, 2), Arial01), x_price1, y_price1, 0); // price1
                                            ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$" + Math.Round(Convert.ToDecimal(formula02), 2), ArialBold), x_price1, y_itemCode, 0); // price2
                                            ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("____", ArialBold), x_price1, y_itemCode + 5.000f, 0); // price2
                                        }
                                    }
                                    else
                                    {
                                        formula = Math.Round(Convert.ToDecimal(dato.price1) * 1.16m);
                                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$  " + Math.Round(formula, 2), Arial01), x_price1, y_price1, 0); // price1
                                    }

                                }
                                else if (tipoPromo == "promo daka") // esto es promo daka
                                {
                                    if (dato.lista4.All(char.IsDigit))
                                    {
                                        formula = Math.Round(Convert.ToDecimal(dato.price1) * 1.16m) - 0.01m;
                                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$  " + Math.Round(formula, 2), Arial01), x_price1, y_price1, 0); // price1
                                    }
                                    else
                                    {
                                        decimal formula01 = Math.Round(Convert.ToDecimal(dato.lista4) * 1.16m);
                                        formula = Math.Round(Convert.ToDecimal(dato.price1) * 1.16m) - 0.01m;
                                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$  " + Math.Round(formula, 2), Arial01), x_price1, y_price1, 0); // price1
                                    }
                                }
                                else if (tipoPromo == "promo actual") // esto es promo daka
                                {
                                    if (dato.lista4.All(char.IsDigit))
                                    {
                                        formula = Math.Round(Convert.ToDecimal(dato.price1) * 1.16m) - 0.01m;
                                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$  " + Math.Round(formula, 2), Arial01), x_price1, y_price1, 0); // price1

                                    }
                                    else
                                    {
                                        decimal formula01 = Math.Round(Convert.ToDecimal(dato.lista4) * 1.16m);

                                        formula = Math.Round(Convert.ToDecimal(dato.price1) * 1.16m) - 0.01m;
                                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$  " + Math.Round(formula, 2), Arial01), x_price1, y_price1, 0); // price1
                                    }
                                }
                                else if (tipoPromo == "Se Feliz .99") // se feliz .99
                                {
                                    if (dato.lista4.All(char.IsDigit))
                                    {
                                        formula = Math.Round(Convert.ToDecimal(dato.price1) * 1.16m) - 0.01m;
                                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$  " + Math.Round(formula, 2), Arial01), x_price1, y_price1, 0); // price1
                                    }
                                    else
                                    {
                                        formula = Math.Round(Convert.ToDecimal(dato.price1) * 1.16m) - 0.01m;
                                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase("$  " + Math.Round(formula, 2), Arial01), x_price1, y_price1, 0); // price1
                                    }
                                }
                            }
                        }
                    }

                    if (codigoBarras == "0")
                    {
                        // Hacer nada
                    }
                    else
                    {
                        image1.ScaleAbsoluteWidth(170.000f); // w
                        image1.ScaleAbsoluteHeight(31.1811f); // h
                        image1.SetAbsolutePosition(x_codebar - 50, y_codebar); // posicion de la imagen (x,y)
                        doc.Add(image1);
                    }

                    image2.ScaleAbsoluteWidth(48.189f); // w 48.189f
                    image2.ScaleAbsoluteHeight(42.5197f); // h 42.5197f
                    image2.SetAbsolutePosition(x_logo - 10, y_logo); // posicion de la imagen (x,y);
                    doc.Add(image2);

                    //IDENTIFICADOR
                    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, new Phrase(AgregarNuevaLista.identificadorLista, Arial01), x_logo - 35.000f, y_logo + 23.000f, 0);
                    if (AgregarNuevaLista.identificadorLista == "AZ" || AgregarNuevaLista.identificadorLista == "NJ" || AgregarNuevaLista.identificadorLista == "VD" || AgregarNuevaLista.identificadorLista == "A" || AgregarNuevaLista.identificadorLista == "B" || AgregarNuevaLista.identificadorLista == "C")
                    {
                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_RIGHT, new Phrase("Mercancía Especial", Arial001), x_garantia, y_garantia + medioCm, 0); // Frase Pida
                    }

                    contador++;
                    contBarraProcesos++;
                }
                contador = 0;
                doc.Close();
                MessageBox.Show("ruta: " + path01);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // pass
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // BUSQUEDA
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
				dataGridView1.Columns["Nombre"].Width = 580;
				dataGridView1.Columns["Marca"].Visible = false;
				dataGridView1.Columns["Garantia"].Visible = false;
				dataGridView1.Columns["Codigo_Barra"].Visible = false;
				dataGridView1.Columns["PrecioaMostrar"].Visible = false;
				dataGridView1.Columns["PrecioTachado"].Visible = false;
			}
			else if (comboBox1.SelectedIndex == 1)
			{
				try
				{
					conexion_server.Open();
					SqlCommand cmd = conexion_server.CreateCommand();

					// busqueda por codigo
					string textQueryBusqueda = "";

					if (Obtner.margarita == true)
					{
						textQueryBusqueda = AgregarNuevaLista.busquedaEnLaLista(textBox1.Text, Obtner.IndiceLista); ;
					}
					else
					{
						textQueryBusqueda = AgregarNuevaLista.busquedaEnLaLista(textBox1.Text, Obtner.IndiceLista);
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
				dataGridView1.Columns["Nombre"].Width = 580;
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

        //MouseDowm
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            shgMove = true;
        }

        //MouseMove
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (shgMove)
            {
                this.Location = Cursor.Position;
            }
        }

        //MouseUp
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            shgMove = false;
        }

        private void shg_MouseDown(object sender, MouseEventArgs e)
        {
        }
        private void shg_MouseMove(object sender, MouseEventArgs e)
        {
        }
        private void shg_MouseUp(object sender, MouseEventArgs e)
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
                string query = @"SELECT 
                       T1.[Referencia] ItemCode
                      ,T1.[Nombre] ItemName
	                  ,T5.[Marca] FirmName
	                  ,T4.[CantidadDiasGarantia] U_DK_GARANTIA
	                  ,isNull(T3.[Barra], 0) CodeBar
	                  ,T2.[Precio] Price1
	                  ,0 Price2
                  FROM [DB_AWS_MELE].[dbo].[Transaccional.Productos] T1 
                  INNER JOIN [DB_AWS_MELE].[dbo].[ListasPrecios] T2 ON T1.Referencia = T2.[Cod_Producto]
                  INNER JOIN [DB_AWS_MELE].[dbo].[Transaccional.Empaques] T3 ON  T1.[IdProducto] = T3.[IdProducto]
                  INNER JOIN [DB_AWS_MELE].[dbo].[ProductosGarantias] T4 ON T1.[Referencia] = T4.[Cod_Producto]
                  INNER JOIN [DB_AWS_MELE].[dbo].[Marcas] T5 ON T4.[Cod_Marca] = T5.[Cod_Marca] 
                  WHERE T1.[Referencia] LIKE 'L%' AND T1.[Referencia] LIKE '" + codigoSap + "%' AND T2.Cod_ListaPrecio = '" + IndiceLista + "' AND T3.[NumeroUnidades] > 0";

				/*--Realizara la consulta por cada articulo- and A.OnHand > 0-*/
				SqlConnection conn = new SqlConnection(DefaultConnection.connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string ItemCode = reader[0].ToString();
                    string ItemName = reader[1].ToString();
                    string FirtsName = reader[2].ToString();
                    string garantia = reader[3].ToString();
                    string Codebars = reader[4].ToString();
                    string price1 = reader[5].ToString();
                    string list4 = reader[6].ToString();

                    List<Articulo> articulos()
                    {
                        return new List<Articulo>
                        {
                             new Articulo{ItemCode=ItemCode, ItemName=ItemName, FirtsName=FirtsName, garantia=garantia, CodeBars=Codebars, price1=price1, lista4=list4}
                        };
                    }

                    Articulo dt = new Articulo();
                    foreach (var articulo in articulos())
                    {
                        dt.ItemCode = articulo.ItemCode;
                        dt.ItemName = articulo.ItemName;
                        dt.FirtsName = articulo.FirtsName;
                        dt.garantia = articulo.garantia;
                        dt.CodeBars = articulo.CodeBars;
                        dt.price1 = articulo.price1;
                        dt.lista4 = articulo.lista4;

                        listaEcxell.Add(dt);
                    }
                }
                reader.Close();
                conn.Close();
            }

            foreach (var hablador in listaEcxell)
            {
                dataGridView2.Rows.Add(hablador.ItemCode, hablador.ItemName, hablador.FirtsName, hablador.garantia, hablador.CodeBars, hablador.price1, hablador.lista4);
            }
        }

		private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
