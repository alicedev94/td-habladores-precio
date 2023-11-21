// NAME-TEC-AL-0001
// VERSION-Alpha 1.0.0
// AUTHOR-ALICE
// FECHA-24/08/2022

using System.Text;
using System.Data;
using System.Data.SqlClient;
using DocumentFormat.OpenXml.Bibliography;
using System.Security.Cryptography.Xml;
using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace phApp
{
    public class datos
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string FirtsName { get; set; }
        public string garantia { get; set; }
        public string CodeBars { get; set; }
        public string price1 { get; set; }
        public string lista4 { get; set; }

		public string idPromo { get; set; }
	}

    public class datos01
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string FirtsName { get; set; }
        public string price1 { get; set; }
        public string lista4 { get; set; }
		public string garantia { get; set; }
	}

    public class Obtner
    {
        public static bool valorBandera = false;
        public static bool margarita = false;
        public static bool verde = false;
        public static bool naranja = false;
        public static bool azul = false;
		public static bool magenta = false;
		public static bool A = false;
        public static bool B = false;
        public static bool C = false;
        public static bool Maturin = false;
        public static bool conectionServer = false;
        public static int valorLogo = 0;
        public static string listaPrecio = "";
        public static string ecxellUbicacion = "";
		public static string sucursal = "";
		public static string almacen = "";
		public static string almacen1;
		public static string almacen2;
		public static string almacen3;
		public static string almacen4;
		public static string almacen5;
		public static string almacen6;
		public static string almacen7;
		public static string almacen8;
		public static string almacen9;
		public static string almacen10;
		public static string almacen11;
		public static string almacen12;
		public static string almacen13;
		public static string almacen14;
		public static string hablador;
		public static bool estandar = false;

		public static List<string> listaHabladoresCsv = new List<string>();
        /*public static string query = @"select ART.ItemCode, ART.ItemName, ART.FirmName, U_DK_GARANTIA, isNull(ART.CodeBars,0), PRE.Price1, PRE.Price2 from
(select A.ItemCode, A.ItemName,  M.FirmName, A.U_DK_GARANTIA, A.CodeBars from OITM A 
join OMRC M on A.FirmCode = M.FirmCode
join ITM1 P on A.ItemCode = P.ItemCode
left join [@FAMILIA_PROD] F on f.Code = a.U_Familia
where a.SellItem = 'Y' and SUBSTRING(a.itemcode,1,1) = 'L' and A.OnHand > 0
group by A.ItemCode, A.ItemName, M.FirmName, A.U_DK_GARANTIA, A.CodeBars) ART
join
(select P1.ItemCode1 as ItemCode, P1.Price1, P2.Price2 from 
(select A.ItemCode ItemCode1, P.Price Price1
from OITM A 
join ITM1 P on A.ItemCode = P.ItemCode
join OPLN L1 on P.PriceList = L1.ListNum
where a.SellItem = 'Y' and SUBSTRING(a.itemcode,1,1) = 'L' and P.PriceList = 7) P1
left join
(select A.ItemCode ItemCode2, P.Price Price2
from OITM A 
join ITM1 P on A.ItemCode = P.ItemCode
join OPLN L1 on P.PriceList = L1.ListNum
where a.SellItem = 'Y' and SUBSTRING(a.itemcode,1,1) = 'L' and P.PriceList = 4) P2
on P1.ItemCode1 = P2.ItemCode2) PRE
on ART.ItemCode = PRE.ItemCode";*/

        public static string query = " SELECT DISTINCT \r\n\r\n                       T1.[Referencia] Codigo\r\n                      ,T1.[Nombre] Nombre\r\n                      ,T5.[Marca] Marca\r\n                      ,T4.[CantidadDiasGarantia] Garantia\r\n                      ,isNull(T3.[Barra], 0) Codigo_Barra\r\n                      ,T2.[Precio] PrecioaMostrar\r\n                      ,0 PrecioTachado\r\n                      --,T6.Inventario\r\n                      --,T6.CodigoSucursal\r\n\t                  --,T6.Sucursal\r\n\t                 -- ,T6.CodArea\r\n\t\t\t\t\t ,T3.[NumeroUnidades]\r\n                  FROM [DB_AWS_MELE].[dbo].[Transaccional.Productos] T1 \r\n                  INNER JOIN [DB_AWS_MELE].[dbo].[ListasPrecios] T2 ON T1.Referencia = T2.[Cod_Producto]\r\n                  INNER JOIN [DB_AWS_MELE].[dbo].[Transaccional.Empaques] T3 ON  T1.[IdProducto] = T3.[IdProducto]\r\n                  INNER JOIN [DB_AWS_MELE].[dbo].[ProductosGarantias] T4 ON T1.[Referencia] = T4.[Cod_Producto]\r\n                  INNER JOIN [DB_AWS_MELE].[dbo].[Marcas] T5 ON T4.[Cod_Marca] = T5.[Cod_Marca]\r\n                  INNER JOIN [TIENDAS_MELE].[dbo].[TM_VW_ExistenciaTiendasMele] T6 ON T2.[Cod_Producto] = T6.[CodArticulo]\r\n                  WHERE (T1.[Referencia]  LIKE 'LB%' OR  T1.[Referencia]  LIKE 'LM%') AND T1.[Referencia] LIKE 'L%' AND T2.Cod_ListaPrecio = '2' AND T3.[NumeroUnidades] > 0 \r\n                  AND T6.CodigoSucursal = 12 \r\n\t\t\t\t AND CodArea = 'ALM'";
		public static string queryp = " SELECT DISTINCT \r\n\r\n                       T1.[Referencia] Codigo\r\n                      ,T1.[Nombre] Nombre\r\n                      ,T5.[Marca] Marca\r\n                      ,T4.[CantidadDiasGarantia] Garantia\r\n                      ,isNull(T3.[Barra], 0) Codigo_Barra\r\n                      ,T2.[Precio] PrecioaMostrar\r\n                      ,0 PrecioTachado\r\n                      --,T6.Inventario\r\n                      --,T6.CodigoSucursal\r\n\t                  --,T6.Sucursal\r\n\t                 -- ,T6.CodArea\r\n\t\t\t\t\t ,T3.[NumeroUnidades]\r\n                  FROM [DB_AWS_MELE].[dbo].[Transaccional.Productos] T1 \r\n                  INNER JOIN [DB_AWS_MELE].[dbo].[ListasPrecios] T2 ON T1.Referencia = T2.[Cod_Producto]\r\n                  INNER JOIN [DB_AWS_MELE].[dbo].[Transaccional.Empaques] T3 ON  T1.[IdProducto] = T3.[IdProducto]\r\n                  INNER JOIN [DB_AWS_MELE].[dbo].[ProductosGarantias] T4 ON T1.[Referencia] = T4.[Cod_Producto]\r\n                  INNER JOIN [DB_AWS_MELE].[dbo].[Marcas] T5 ON T4.[Cod_Marca] = T5.[Cod_Marca]\r\n                  INNER JOIN [TIENDAS_MELE].[dbo].[TM_VW_ExistenciaTiendasMele] T6 ON T2.[Cod_Producto] = T6.[CodArticulo]\r\n                  WHERE (T1.[Referencia]  NOT LIKE 'LB%' AND  T1.[Referencia]  NOT LIKE 'LM%') AND T1.[Referencia] LIKE 'L%' AND T2.Cod_ListaPrecio = '2' AND T3.[NumeroUnidades] > 0 \r\n                  AND T6.CodigoSucursal = 12 \r\n\t\t\t\t AND CodArea = 'ALM'";
		public static string IndiceLista = "0";
        public static string queryMargarita = "SELECT T1.[Referencia] ItemCode\r\n      ,T1.[Nombre] ItemName\r\n\t  ,T5.[Marca] FirmName\r\n\t  ,T4.[CantidadDiasGarantia] U_DK_GARANTIA\r\n\t  ,isNull(T3.[Barra], 0) CodeBar\r\n\t  ,T2.[Precio] Price1\r\n\t  ,0 Price2\r\n  FROM [DB_AWS_MELE].[dbo].[Transaccional.Productos] T1 \r\n  INNER JOIN [DB_AWS_MELE].[dbo].[ListasPrecios] T2 ON T1.Referencia = T2.[Cod_Producto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[Transaccional.Empaques] T3 ON  T1.[IdProducto] = T3.[IdProducto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[ProductosGarantias] T4 ON T1.[Referencia] = T4.[Cod_Producto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[Marcas] T5 ON T4.[Cod_Marca] = T5.[Cod_Marca] \r\n  WHERE T1.[Referencia] LIKE 'L%' AND T1.[Referencia] LIKE '%L%' AND T2.Cod_ListaPrecio = '2' AND T3.[NumeroUnidades] > 0;";
    }

    public class User
    {
        public static string shgFormat(string itemName)
        {
            string CAD1 = "";
            string CAD2 = "";
            string CAD3 = "";
            int AlcanceLetra = 32;

            string datoItemName = itemName;

            if (datoItemName.Length <= AlcanceLetra)
            {
                CAD1 = datoItemName;
            }
            else
            {
                List<string> list = new List<string>();
                List<string> resultante = new List<string>();
                int espacios = 0;

                // contar las palabras de la cadena en cuestion
                int posicion = 0;
                int i;

                // Primer corte de la cadena
                for (i = 0; i < datoItemName.Length; i++)
                {
                    if (datoItemName[i] == ' ')
                    {
                        espacios++;
                    }

                    if (espacios == 2) // cuatro palabras
                    {
                        posicion = i;
                    }
                }

                // delimitar el numero de palabras
                char replacement = '}'; // lo que queremos incluir
                StringBuilder sb = new StringBuilder(datoItemName); // Metodo
                sb[posicion + 1] = replacement; // se le suma 1 porque siempre corta una posicion
                datoItemName = sb.ToString();

                // Separar los valoreos
                list = datoItemName.Split('}').ToList();
                resultante = list.ToList(); // respaldo de la cadena original

                // ----------------------
                bool primeraLinea = false;

                //Frases
                int frase1 = datoItemName.IndexOf(" ");//PRIMERA:

                if (frase1 > 30)
                {
                    Console.WriteLine(datoItemName);
                }
                else
                {
                    // VARIABLES PRINCIPALES---:
                    string PL = "";//
                    string PM = "";//
                    string PF = "";//
                    bool desplazo = false;  //
                    //--------------------------:

                    //(PL)
                    while (primeraLinea != true)
                    {
                        if (list[0].Length <= AlcanceLetra)
                        {
                            // Escribir (PL)
                            CAD1 = list[0];
                            PL = list[0];
                            primeraLinea = true;
                        }
                        else
                        {
                            // Cortar ultima frase (PL)
                            StringBuilder sb01 = new StringBuilder(list[0]);
                            posicion = list[0].LastIndexOf(" ");
                            sb01[posicion] = replacement;
                            list[0] = sb01.ToString();
                            list = list[0].Split('}').ToList(); // guardamos en *list* solamnete la posicion 1 alterada
                        }
                    }
                    //--------------------------------------------------------- (PL):
                    StringBuilder PMFLIST = new StringBuilder();

                    if (resultante[0].Replace(PL, " ").Trim() != "") // Esta función nos devuelve como resultado (PM)
                    {

                        PM = resultante[0].Replace(PL, " ").Trim();
                        PM += " " + resultante[1];

                        if (PM.Length <= AlcanceLetra)
                        {
                            CAD2 = PM;
                        }
                        else if (PM.IndexOf(" ") == -1)
                        {
                            CAD2 = PM;
                        }
                        else
                        {

                            // Parametrizar (PM) con la regla AlcanceLetra.
                            while (1 == 1)
                            {
                                List<string> PMLIST = new List<string>();

                                if (PM.Length <= AlcanceLetra)
                                {
                                    // Escribir (PM)
                                    CAD2 = PM;
                                    break;
                                }
                                else
                                {
                                    // Cortar ultima frase (PM)
                                    StringBuilder sb001 = new StringBuilder(PM);
                                    posicion = PM.LastIndexOf(" ");
                                    sb001[posicion] = replacement;
                                    PM = sb001.ToString();
                                    PMLIST = PM.Split('}').ToList(); // guardamos en *list* solamnete la posicion 1 alterada
                                                                     //--------------------------------------------------------------------------------------

                                    PM = PMLIST[0];
                                    PMFLIST.Insert(0, PMLIST[1] + " ").ToString();
                                }
                            }
                        }
                        desplazo = true;
                    }
                    else
                    {
                        PM = resultante[1];

                        if (PM.Length <= AlcanceLetra)
                        {
                            CAD2 = PM;

                        }
                        else if (PM.IndexOf(" ") == -1)
                        {
                            CAD2 = PM;
                        }
                        else
                        {

                            // Parametrizar (PM) con la regla AlcanceLetra.
                            while (1 == 1)
                            {
                                List<string> PMLIST = new List<string>();

                                if (PM.Length <= AlcanceLetra)
                                {
                                    // Escribir (PM)
                                    CAD2 = PM;
                                    break;
                                }
                                else
                                {
                                    // Cortar ultima frase (PM)
                                    StringBuilder sb001 = new StringBuilder(PM);
                                    posicion = PM.LastIndexOf(" ");
                                    sb001[posicion] = replacement;
                                    PM = sb001.ToString();
                                    PMLIST = PM.Split('}').ToList(); // guardamos en *list* solamnete la posicion 1 alterada
                                                                     //--------------------------------------------------------------------------------------
                                    PM = PMLIST[0];
                                    PMFLIST.Insert(0, PMLIST[1] + " ").ToString();
                                }
                            }
                        }
                    }
                    //-------------------------------------------------------------------------------------- PM:

                    if (desplazo)
                    {
                        //(PF)
                        PF = resultante[1].Insert(0, PMFLIST.ToString());
                        if (resultante[1].Insert(0, PMFLIST.ToString()).Length <= AlcanceLetra)// Esta función nos devuelve como resultado (PF)
                        {

                            // Escribir (PF)
                            if (PF != PM)
                            {
                                CAD3 = PF;
                            }
                        }
                        else
                        {
                            while (1 == 1)
                            {
                                List<string> PFLIST = new List<string>();

                                if (PF.Length <= AlcanceLetra)
                                {
                                    // Escribir (PF)
                                    if (PF != PM)
                                    {
                                        CAD3 = PF;
                                    }
                                    break;
                                }
                                else
                                {
                                    // Cortar ultima frase (PM)
                                    StringBuilder sb0001 = new StringBuilder(PF);
                                    posicion = PF.LastIndexOf(" ");
                                    sb0001[posicion] = replacement;
                                    PF = sb0001.ToString();
                                    PFLIST = PF.Split('}').ToList();

                                    //------------------------------
                                    PF = PFLIST[0];
                                }
                            }
                        }
                    }
                    else
                    {
                        //(PF)
                        PF = PMFLIST.ToString();
                        if (resultante[1].Insert(0, PMFLIST.ToString()).Length <= AlcanceLetra)// Esta función nos devuelve como resultado (PF)
                        {
                            // Escribir (PF)
                            if (PF != PM)
                            {
                                CAD3 = PF;
                            }
                        }
                        else
                        {
                            while (1 == 1)
                            {
                                List<string> PFLIST = new List<string>();

                                if (PF.Length <= AlcanceLetra)
                                {
                                    // Escribir (PF)
                                    if (PF != PM)
                                    {
                                        CAD3 = PF;
                                    }
                                    break;
                                }
                                else
                                {
                                    // Cortar ultima frase (PM)
                                    StringBuilder sb0001 = new StringBuilder(PF);
                                    posicion = PF.LastIndexOf(" ");
                                    sb0001[posicion] = replacement;
                                    PF = sb0001.ToString();
                                    PFLIST = PF.Split('}').ToList();

                                    //------------------------------
                                    PF = PFLIST[0]; // CHECKAR
                                }
                            }
                        }
                    }
                }
            }
            return CAD1;
        }
        public static string shgFormat2(string itemName)
        {
            string CAD1 = "";
            string CAD2 = "";
            string CAD3 = "";
            int AlcanceLetra = 32;

            string datoItemName = itemName;
            if (datoItemName.Length <= AlcanceLetra)
            {
                CAD1 = datoItemName;
            }
            else
            {
                List<string> list = new List<string>();
                List<string> resultante = new List<string>();
                int espacios = 0;

                // contar las palabras de la cadena en cuestion
                int posicion = 0;
                int i;

                // Primer corte de la cadena
                for (i = 0; i < datoItemName.Length; i++)
                {
                    if (datoItemName[i] == ' ')
                    {
                        espacios++;
                    }

                    if (espacios == 2) // cuatro palabras
                    {
                        posicion = i;
                    }
                }

                // delimitar el numero de palabras
                char replacement = '}'; // lo que queremos incluir
                StringBuilder sb = new StringBuilder(datoItemName); // Metodo
                sb[posicion + 1] = replacement; // se le suma 1 porque siempre corta una posicion
                datoItemName = sb.ToString();

                // Separar los valoreos
                list = datoItemName.Split('}').ToList();
                resultante = list.ToList(); // respaldo de la cadena original

                // ----------------------
                bool primeraLinea = false;

                //Frases
                int frase1 = datoItemName.IndexOf(" ");//PRIMERA:

                if (frase1 > 30)
                {
                    Console.WriteLine(datoItemName);
                }
                else
                {
                    // VARIABLES PRINCIPALES---:
                    string PL = "";//
                    string PM = "";//
                    string PF = "";//
                    bool desplazo = false;  //
                    //--------------------------:

                    //(PL)
                    while (primeraLinea != true)
                    {
                        if (list[0].Length <= AlcanceLetra)
                        {
                            // Escribir (PL)
                            CAD1 = list[0];
                            PL = list[0];
                            primeraLinea = true;
                        }
                        else
                        {
                            // Cortar ultima frase (PL)
                            StringBuilder sb01 = new StringBuilder(list[0]);
                            posicion = list[0].LastIndexOf(" ");
                            sb01[posicion] = replacement;
                            list[0] = sb01.ToString();
                            list = list[0].Split('}').ToList(); // guardamos en *list* solamnete la posicion 1 alterada
                        }
                    }
                    //--------------------------------------------------------- (PL):
                    StringBuilder PMFLIST = new StringBuilder();

                    if (resultante[0].Replace(PL, " ").Trim() != "") // Esta función nos devuelve como resultado (PM)
                    {

                        PM = resultante[0].Replace(PL, " ").Trim();
                        PM += " " + resultante[1];

                        if (PM.Length <= AlcanceLetra)
                        {
                            CAD2 = PM;
                        }
                        else if (PM.IndexOf(" ") == -1)
                        {
                            CAD2 = PM;
                        }
                        else
                        {

                            // Parametrizar (PM) con la regla AlcanceLetra.
                            while (1 == 1)
                            {
                                List<string> PMLIST = new List<string>();

                                if (PM.Length <= AlcanceLetra)
                                {
                                    // Escribir (PM)
                                    CAD2 = PM;
                                    break;
                                }
                                else
                                {
                                    // Cortar ultima frase (PM)
                                    StringBuilder sb001 = new StringBuilder(PM);
                                    posicion = PM.LastIndexOf(" ");
                                    sb001[posicion] = replacement;
                                    PM = sb001.ToString();
                                    PMLIST = PM.Split('}').ToList(); // guardamos en *list* solamnete la posicion 1 alterada
                                                                     //--------------------------------------------------------------------------------------

                                    PM = PMLIST[0];
                                    PMFLIST.Insert(0, PMLIST[1] + " ").ToString();
                                }
                            }
                        }
                        desplazo = true;
                    }
                    else
                    {
                        PM = resultante[1];

                        if (PM.Length <= AlcanceLetra)
                        {
                            CAD2 = PM;

                        }
                        else if (PM.IndexOf(" ") == -1)
                        {
                            CAD2 = PM;
                        }
                        else
                        {

                            // Parametrizar (PM) con la regla AlcanceLetra.
                            while (1 == 1)
                            {
                                List<string> PMLIST = new List<string>();

                                if (PM.Length <= AlcanceLetra)
                                {
                                    // Escribir (PM)
                                    CAD2 = PM;
                                    break;
                                }
                                else
                                {
                                    // Cortar ultima frase (PM)
                                    StringBuilder sb001 = new StringBuilder(PM);
                                    posicion = PM.LastIndexOf(" ");
                                    sb001[posicion] = replacement;
                                    PM = sb001.ToString();
                                    PMLIST = PM.Split('}').ToList(); // guardamos en *list* solamnete la posicion 1 alterada
                                                                     //--------------------------------------------------------------------------------------
                                    PM = PMLIST[0];
                                    PMFLIST.Insert(0, PMLIST[1] + " ").ToString();
                                }
                            }
                        }
                    }
                    //-------------------------------------------------------------------------------------- PM:

                    if (desplazo)
                    {
                        //(PF)
                        PF = resultante[1].Insert(0, PMFLIST.ToString());
                        if (resultante[1].Insert(0, PMFLIST.ToString()).Length <= AlcanceLetra)// Esta función nos devuelve como resultado (PF)
                        {

                            // Escribir (PF)
                            if (PF != PM)
                            {
                                CAD3 = PF;
                            }
                        }
                        else
                        {
                            while (1 == 1)
                            {
                                List<string> PFLIST = new List<string>();

                                if (PF.Length <= AlcanceLetra)
                                {
                                    // Escribir (PF)
                                    if (PF != PM)
                                    {
                                        CAD3 = PF;
                                    }
                                    break;
                                }
                                else
                                {
                                    // Cortar ultima frase (PM)
                                    StringBuilder sb0001 = new StringBuilder(PF);
                                    posicion = PF.LastIndexOf(" ");
                                    sb0001[posicion] = replacement;
                                    PF = sb0001.ToString();
                                    PFLIST = PF.Split('}').ToList();

                                    //------------------------------
                                    PF = PFLIST[0];
                                }
                            }
                        }
                    }
                    else
                    {
                        //(PF)
                        PF = PMFLIST.ToString();
                        if (resultante[1].Insert(0, PMFLIST.ToString()).Length <= AlcanceLetra)// Esta función nos devuelve como resultado (PF)
                        {
                            // Escribir (PF)
                            if (PF != PM)
                            {
                                CAD3 = PF;
                            }
                        }
                        else
                        {
                            while (1 == 1)
                            {
                                List<string> PFLIST = new List<string>();

                                if (PF.Length <= AlcanceLetra)
                                {
                                    // Escribir (PF)
                                    if (PF != PM)
                                    {
                                        CAD3 = PF;
                                    }
                                    break;
                                }
                                else
                                {
                                    // Cortar ultima frase (PM)
                                    StringBuilder sb0001 = new StringBuilder(PF);
                                    posicion = PF.LastIndexOf(" ");
                                    sb0001[posicion] = replacement;
                                    PF = sb0001.ToString();
                                    PFLIST = PF.Split('}').ToList();

                                    //------------------------------
                                    PF = PFLIST[0]; // CHECKAR
                                }
                            }
                        }
                    }
                }
            }
            return CAD2;
        }
        public static string shgFormat3(string itemName)
        {
            string CAD1 = "";
            string CAD2 = "";
            string CAD3 = "";
            int AlcanceLetra = 32;

            string datoItemName = itemName;
            if (datoItemName.Length <= AlcanceLetra)
            {
                CAD1 = datoItemName;
            }
            else
            {
                List<string> list = new List<string>();
                List<string> resultante = new List<string>();
                int espacios = 0;

                // contar las palabras de la cadena en cuestion
                int posicion = 0;
                int i;

                // Primer corte de la cadena
                for (i = 0; i < datoItemName.Length; i++)
                {
                    if (datoItemName[i] == ' ')
                    {
                        espacios++;
                    }

                    if (espacios == 2) // cuatro palabras
                    {
                        posicion = i;
                    }
                }

                // delimitar el numero de palabras
                char replacement = '}'; // lo que queremos incluir
                StringBuilder sb = new StringBuilder(datoItemName); // Metodo
                sb[posicion + 1] = replacement; // se le suma 1 porque siempre corta una posicion
                datoItemName = sb.ToString();

                // Separar los valoreos
                list = datoItemName.Split('}').ToList();
                resultante = list.ToList(); // respaldo de la cadena original

                // ----------------------
                bool primeraLinea = false;

                //Frases
                int frase1 = datoItemName.IndexOf(" ");//PRIMERA:

                if (frase1 > 30)
                {
                    Console.WriteLine(datoItemName);
                }
                else
                {
                    // VARIABLES PRINCIPALES---:
                    string PL = "";//
                    string PM = "";//
                    string PF = "";//
                    bool desplazo = false;  //
                    //--------------------------:

                    //(PL)
                    while (primeraLinea != true)
                    {
                        if (list[0].Length <= AlcanceLetra)
                        {
                            // Escribir (PL)
                            CAD1 = list[0];
                            PL = list[0];
                            primeraLinea = true;
                        }
                        else
                        {
                            // Cortar ultima frase (PL)
                            StringBuilder sb01 = new StringBuilder(list[0]);
                            posicion = list[0].LastIndexOf(" ");
                            sb01[posicion] = replacement;
                            list[0] = sb01.ToString();
                            list = list[0].Split('}').ToList(); // guardamos en *list* solamnete la posicion 1 alterada
                        }
                    }
                    //--------------------------------------------------------- (PL):
                    StringBuilder PMFLIST = new StringBuilder();

                    if (resultante[0].Replace(PL, " ").Trim() != "") // Esta función nos devuelve como resultado (PM)
                    {

                        PM = resultante[0].Replace(PL, " ").Trim();
                        PM += " " + resultante[1];

                        if (PM.Length <= AlcanceLetra)
                        {
                            CAD2 = PM;
                        }
                        else if (PM.IndexOf(" ") == -1)
                        {
                            CAD2 = PM;
                        }
                        else
                        {

                            // Parametrizar (PM) con la regla AlcanceLetra.
                            while (1 == 1)
                            {
                                List<string> PMLIST = new List<string>();

                                if (PM.Length <= AlcanceLetra)
                                {
                                    // Escribir (PM)
                                    CAD2 = PM;
                                    break;
                                }
                                else
                                {
                                    // Cortar ultima frase (PM)
                                    StringBuilder sb001 = new StringBuilder(PM);
                                    posicion = PM.LastIndexOf(" ");
                                    sb001[posicion] = replacement;
                                    PM = sb001.ToString();
                                    PMLIST = PM.Split('}').ToList(); // guardamos en *list* solamnete la posicion 1 alterada
                                                                     //--------------------------------------------------------------------------------------

                                    PM = PMLIST[0];
                                    PMFLIST.Insert(0, PMLIST[1] + " ").ToString();
                                }
                            }
                        }
                        desplazo = true;
                    }
                    else
                    {
                        PM = resultante[1];

                        if (PM.Length <= AlcanceLetra)
                        {
                            CAD2 = PM;

                        }
                        else if (PM.IndexOf(" ") == -1)
                        {
                            CAD2 = PM;
                        }
                        else
                        {

                            // Parametrizar (PM) con la regla AlcanceLetra.
                            while (1 == 1)
                            {
                                List<string> PMLIST = new List<string>();

                                if (PM.Length <= AlcanceLetra)
                                {
                                    // Escribir (PM)
                                    CAD2 = PM;
                                    break;
                                }
                                else
                                {
                                    // Cortar ultima frase (PM)
                                    StringBuilder sb001 = new StringBuilder(PM);
                                    posicion = PM.LastIndexOf(" ");
                                    sb001[posicion] = replacement;
                                    PM = sb001.ToString();
                                    PMLIST = PM.Split('}').ToList(); // guardamos en *list* solamnete la posicion 1 alterada
                                                                     //--------------------------------------------------------------------------------------
                                    PM = PMLIST[0];
                                    PMFLIST.Insert(0, PMLIST[1] + " ").ToString();
                                }
                            }
                        }
                    }
                    //-------------------------------------------------------------------------------------- PM:

                    if (desplazo)
                    {
                        //(PF)
                        PF = resultante[1].Insert(0, PMFLIST.ToString());
                        if (resultante[1].Insert(0, PMFLIST.ToString()).Length <= AlcanceLetra)// Esta función nos devuelve como resultado (PF)
                        {

                            // Escribir (PF)
                            if (PF != PM)
                            {
                                CAD3 = PF;
                            }
                        }
                        else
                        {
                            while (1 == 1)
                            {
                                List<string> PFLIST = new List<string>();

                                if (PF.Length <= AlcanceLetra)
                                {
                                    // Escribir (PF)
                                    if (PF != PM)
                                    {
                                        CAD3 = PF;
                                    }
                                    break;
                                }
                                else
                                {
                                    // Cortar ultima frase (PM)
                                    StringBuilder sb0001 = new StringBuilder(PF);
                                    posicion = PF.LastIndexOf(" ");
                                    sb0001[posicion] = replacement;
                                    PF = sb0001.ToString();
                                    PFLIST = PF.Split('}').ToList();

                                    //------------------------------
                                    PF = PFLIST[0];
                                }
                            }
                        }
                    }
                    else
                    {
                        //(PF)
                        PF = PMFLIST.ToString();
                        if (resultante[1].Insert(0, PMFLIST.ToString()).Length <= AlcanceLetra)// Esta función nos devuelve como resultado (PF)
                        {
                            // Escribir (PF)
                            if (PF != PM)
                            {
                                CAD3 = PF;
                            }
                        }
                        else
                        {
                            while (1 == 1)
                            {
                                List<string> PFLIST = new List<string>();

                                if (PF.Length <= AlcanceLetra)
                                {
                                    // Escribir (PF)
                                    if (PF != PM)
                                    {
                                        CAD3 = PF;
                                    }
                                    break;
                                }
                                else
                                {
                                    // Cortar ultima frase (PM)
                                    StringBuilder sb0001 = new StringBuilder(PF);
                                    posicion = PF.LastIndexOf(" ");
                                    sb0001[posicion] = replacement;
                                    PF = sb0001.ToString();
                                    PFLIST = PF.Split('}').ToList();

                                    //------------------------------
                                    PF = PFLIST[0]; // CHECKAR
                                }
                            }
                        }
                    }
                }
            }
            return CAD3;
        }
    }

    class Read
    {
        // Leer el csv y devuelve una lista de valores
        public static List<string> readCsv(string ruta)
        {
            string linea;
            List<string> lista = new List<string>();
            string ubicacionArchivo = ruta;
            StreamReader sr = new StreamReader(ubicacionArchivo);

            while ((linea = sr.ReadLine()) != null)
            {
                string[] fila = linea.Split(',');
                string descripcion1 = fila[0];

                string codigoSap = descripcion1.Substring(0, 11);
                lista.Add(codigoSap);
            }
            return lista;
        }
    }

    class AgregarNuevaLista // agregar nueva lista cuadndo sea necesario
    {
        public static string identificadorLista = "";
        public static string listaSeleccionada(string indice, string sucursal, string almacen)
        {
            string i = indice;
            Obtner.IndiceLista = i;
            //string listaDinamica = "SELECT \r\n       T1.[Referencia] Codigo\r\n      ,T1.[Nombre] Nombre\r\n\t  ,T5.[Marca] Marca\r\n\t  ,T4.[CantidadDiasGarantia] Garantia\r\n\t  ,isNull(T3.[Barra], 0) Codigo_Barra\r\n\t  ,T2.[Precio] PrecioaMostrar\r\n\t  ,0 PrecioTachado\r\n  FROM [DB_AWS_MELE].[dbo].[Transaccional.Productos] T1 \r\n  INNER JOIN [DB_AWS_MELE].[dbo].[ListasPrecios] T2 ON T1.Referencia = T2.[Cod_Producto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[Transaccional.Empaques] T3 ON  T1.[IdProducto] = T3.[IdProducto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[ProductosGarantias] T4 ON T1.[Referencia] = T4.[Cod_Producto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[Marcas] T5 ON T4.[Cod_Marca] = T5.[Cod_Marca] \r\n  WHERE T1.[Referencia] LIKE 'L%' AND T1.[Referencia] LIKE 'L%' AND T2.Cod_ListaPrecio = '" + indice + "' AND T3.[NumeroUnidades] > 0;";
            string listaDinamica = "";

            if (Obtner.estandar)
            {
                listaDinamica = "SELECT TOP (100)\r\n       T1.[Referencia] Codigo\r\n      ,T1.[Nombre] Nombre\r\n      ,T5.[Marca] Marca\r\n      ,T4.[CantidadDiasGarantia] Garantia\r\n      ,isNull(T3.[Barra], 0) Codigo_Barra\r\n      ,T2.[Precio] PrecioaMostrar\r\n      ,0 PrecioTachado\r\n      ,T6.Inventario\r\n      ,T6.CodigoSucursal\r\n\t  ,T6.Sucursal\r\n, 1 as id_prom\r\n,.99 AS nombre_promo  FROM [DB_AWS_MELE].[dbo].[Transaccional.Productos] T1 \r\n  INNER JOIN [DB_AWS_MELE].[dbo].[ListasPrecios] T2 ON T1.Referencia = T2.[Cod_Producto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[Transaccional.Empaques] T3 ON  T1.[IdProducto] = T3.[IdProducto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[ProductosGarantias] T4 ON T1.[Referencia] = T4.[Cod_Producto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[Marcas] T5 ON T4.[Cod_Marca] = T5.[Cod_Marca]\r\n  INNER JOIN [TIENDAS_MELE].[dbo].[TM_VW_ExistenciaTiendasMele] T6 ON T2.[Cod_Producto] = T6.[CodArticulo]\r\n  WHERE T1.[Referencia] LIKE 'L%' AND T2.Cod_ListaPrecio = '" + indice + "'  AND T6.CodigoSucursal = '" + sucursal + "' AND T6.Inventario > 0  AND T6.CodArea = '" + almacen + "'";
            } else
            {
				if (Obtner.hablador == "G")
				{
					listaDinamica = "SELECT TOP (100)\r\n       T1.[Referencia] Codigo\r\n      ,T1.[Nombre] Nombre\r\n      ,T5.[Marca] Marca\r\n      ,T4.[CantidadDiasGarantia] Garantia\r\n      ,isNull(T3.[Barra], 0) Codigo_Barra\r\n      ,T2.[Precio] PrecioaMostrar\r\n      ,0 PrecioTachado\r\n      ,T6.Inventario\r\n      ,T6.CodigoSucursal\r\n\t  ,T6.Sucursal\r\n ,1 as id_prom\r\n,.99 AS nombre_promo  FROM [DB_AWS_MELE].[dbo].[Transaccional.Productos] T1 \r\n  INNER JOIN [DB_AWS_MELE].[dbo].[ListasPrecios] T2 ON T1.Referencia = T2.[Cod_Producto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[Transaccional.Empaques] T3 ON  T1.[IdProducto] = T3.[IdProducto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[ProductosGarantias] T4 ON T1.[Referencia] = T4.[Cod_Producto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[Marcas] T5 ON T4.[Cod_Marca] = T5.[Cod_Marca]\r\n  INNER JOIN [TIENDAS_MELE].[dbo].[TM_VW_ExistenciaTiendasMele] T6 ON T2.[Cod_Producto] = T6.[CodArticulo]\r\n  WHERE (T1.[Referencia] LIKE 'LB%' OR  T1.[Referencia] LIKE 'LM%' OR T1.[Referencia] LIKE 'LJ%') AND T2.Cod_ListaPrecio = '" + indice + "' AND T3.[NumeroUnidades] > 0\r\n  AND T6.CodigoSucursal = '" + sucursal + "' AND T6.Inventario > 0  AND T6.CodArea = '" + almacen + "'";
				}
				else if (Obtner.hablador == "P")
				{
					listaDinamica = "SELECT TOP (100)\r\n       T1.[Referencia] Codigo\r\n      ,T1.[Nombre] Nombre\r\n      ,T5.[Marca] Marca\r\n      ,T4.[CantidadDiasGarantia] Garantia\r\n      ,isNull(T3.[Barra], 0) Codigo_Barra\r\n      ,T2.[Precio] PrecioaMostrar\r\n      ,0 PrecioTachado\r\n      ,T6.Inventario\r\n      ,T6.CodigoSucursal\r\n\t  ,T6.Sucursal\r\n  FROM [DB_AWS_MELE].[dbo].[Transaccional.Productos] T1 \r\n  INNER JOIN [DB_AWS_MELE].[dbo].[ListasPrecios] T2 ON T1.Referencia = T2.[Cod_Producto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[Transaccional.Empaques] T3 ON  T1.[IdProducto] = T3.[IdProducto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[ProductosGarantias] T4 ON T1.[Referencia] = T4.[Cod_Producto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[Marcas] T5 ON T4.[Cod_Marca] = T5.[Cod_Marca]\r\n  INNER JOIN [TIENDAS_MELE].[dbo].[TM_VW_ExistenciaTiendasMele] T6 ON T2.[Cod_Producto] = T6.[CodArticulo]\r\n  WHERE (T1.[Referencia] NOT LIKE 'LB%' AND  T1.[Referencia] NOT LIKE 'LM%' AND  T1.[Referencia] NOT LIKE 'LJ%') AND T2.Cod_ListaPrecio = '" + indice + "' AND T3.[NumeroUnidades] > 0\r\n  AND T6.CodigoSucursal = '" + sucursal + "' AND T6.Inventario > 0  AND T6.CodArea = '" + almacen + "'";
				}
			}
			return listaDinamica;
		}

        public static string busquedaEnLaLista(string sapCode, string IndiceLista, string sucursal, string almacen, string almacen1, string almacen2, string almacen3, string almacen4, string almacen5, string almacen6, string almacen7, string almacen8, string almacen9, string almacen10, string almacen11, string almacen12, string almacen13, string almacen14)
        {
            string queryBusquedaEnLaLista = "";

            if (Obtner.estandar)
            {
				// QUERYS ORIGINALES
				queryBusquedaEnLaLista = @"
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
                  WHERE T1.[Referencia] LIKE 'L%' AND T1.[Referencia] LIKE '%" + sapCode + "%' AND T2.Cod_ListaPrecio = '" + IndiceLista + "' AND T3.[NumeroUnidades] > 0  AND T6.CodigoSucursal = '"+sucursal+"' AND T6.Inventario > 0 AND T6.CodArea IN ('" + almacen + "', '" + almacen1 + "', '" + almacen2 + "', '" + almacen3 + "', '" + almacen4 + "', '" + almacen5 + "', '" + almacen6 + "', '" + almacen7 + "', '" + almacen8 + "', '" + almacen9 + "', '" + almacen10 + "', '" + almacen11 + "', '" + almacen12 + "', '" + almacen13 + "', '" + almacen14 + "')";
			} else
            {
				if (Obtner.hablador == "G")
				{
					queryBusquedaEnLaLista = @"
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
,100 as id_prom
,.99 AS nombre_promo
                  FROM [DB_AWS_MELE].[dbo].[Transaccional.Productos] T1 
                  INNER JOIN [DB_AWS_MELE].[dbo].[ListasPrecios] T2 ON T1.Referencia = T2.[Cod_Producto]
                  INNER JOIN [DB_AWS_MELE].[dbo].[Transaccional.Empaques] T3 ON  T1.[IdProducto] = T3.[IdProducto]
                  INNER JOIN [DB_AWS_MELE].[dbo].[ProductosGarantias] T4 ON T1.[Referencia] = T4.[Cod_Producto]
                  INNER JOIN [DB_AWS_MELE].[dbo].[Marcas] T5 ON T4.[Cod_Marca] = T5.[Cod_Marca]
                  INNER JOIN [TIENDAS_MELE].[dbo].[TM_VW_ExistenciaTiendasMele] T6 ON T2.[Cod_Producto] = T6.[CodArticulo]
                  WHERE (T1.[Referencia] LIKE 'LB%' OR  T1.[Referencia] LIKE 'LM%'  OR  T1.[Referencia] LIKE 'LJ%') AND T1.[Referencia] LIKE '%" + sapCode + "%' AND T2.Cod_ListaPrecio = '" + IndiceLista + "' AND T6.CodigoSucursal = '" + sucursal + "' AND T6.Inventario > 0 AND T6.CodArea IN ('" + almacen + "', '" + almacen1 + "', '" + almacen2 + "', '" + almacen3 + "', '" + almacen4 + "', '" + almacen5 + "', '" + almacen6 + "', '" + almacen7 + "', '" + almacen8 + "', '" + almacen9 + "', '" + almacen10 + "', '" + almacen11 + "', '" + almacen12 + "', '" + almacen13 + "', '" + almacen14 + "')";
				}
				else if (Obtner.hablador == "P")
				{
					queryBusquedaEnLaLista = @"
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
                  WHERE (T1.[Referencia] NOT LIKE 'LB%' AND T1.[Referencia] NOT LIKE 'LM%' AND T1.[Referencia] NOT LIKE 'LJ%') AND T1.[Referencia] LIKE '" + sapCode + "%' AND T2.Cod_ListaPrecio = '" + IndiceLista + "' AND T6.CodigoSucursal = '" + sucursal + "' AND T6.Inventario > 0 AND T6.CodArea IN ('" + almacen + "', '" + almacen1 + "', '" + almacen2 + "', '" + almacen3 + "', '" + almacen4 + "', '" + almacen5 + "', '" + almacen6 + "', '" + almacen7 + "', '" + almacen8 + "', '" + almacen9 + "', '" + almacen10 + "', '" + almacen11 + "', '" + almacen12 + "', '" + almacen13 + "', '" + almacen14 + "')";
				}
			}
			return queryBusquedaEnLaLista;
		}
        public static string busquedaEnLaListaNombre(string sapCode, string IndiceLista)
        {
            string queryBusquedaEnLaLista = "";

            //REPARAR LA CONSULTA PARA LA BUSQUEDA POR NOMBRE

            if (Obtner.hablador == "G")
            {
				//listaDinamica = "SELECT TOP (100)\r\n       T1.[Referencia] Codigo\r\n      ,T1.[Nombre] Nombre\r\n      ,T5.[Marca] Marca\r\n      ,T4.[CantidadDiasGarantia] Garantia\r\n      ,isNull(T3.[Barra], 0) Codigo_Barra\r\n      ,T2.[Precio] PrecioaMostrar\r\n      ,0 PrecioTachado\r\n      ,T6.Inventario\r\n      ,T6.CodigoSucursal\r\n\t  ,T6.Sucursal\r\n  FROM [DB_AWS_MELE].[dbo].[Transaccional.Productos] T1 \r\n  INNER JOIN [DB_AWS_MELE].[dbo].[ListasPrecios] T2 ON T1.Referencia = T2.[Cod_Producto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[Transaccional.Empaques] T3 ON  T1.[IdProducto] = T3.[IdProducto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[ProductosGarantias] T4 ON T1.[Referencia] = T4.[Cod_Producto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[Marcas] T5 ON T4.[Cod_Marca] = T5.[Cod_Marca]\r\n  INNER JOIN [TIENDAS_MELE].[dbo].[TM_VW_ExistenciaTiendasMele] T6 ON T2.[Cod_Producto] = T6.[CodArticulo]\r\n  WHERE (T1.[Referencia] LIKE 'LB%' OR  T1.[Referencia] LIKE 'LM%') AND T2.Cod_ListaPrecio = '" + indice + "' AND T3.[NumeroUnidades] > 0\r\n  AND T6.CodigoSucursal = '" + sucursal + "' AND T6.Inventario > 0  AND T6.CodArea = '" + almacen + "'";
				 queryBusquedaEnLaLista = "SELECT \r\n       T1.[Referencia] Codigo\r\n      ,T1.[Nombre] Nombre\r\n\t  ,T5.[Marca] Marca\r\n\t  ,T4.[CantidadDiasGarantia] Garantia\r\n\t  ,isNull(T3.[Barra], 0) Codigo_Barra\r\n\t  ,T2.[Precio] PrecioaMostrar\r\n\t  ,0 PrecioTachado\r\n  FROM [DB_AWS_MELE].[dbo].[Transaccional.Productos] T1 \r\n  INNER JOIN [DB_AWS_MELE].[dbo].[ListasPrecios] T2 ON T1.Referencia = T2.[Cod_Producto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[Transaccional.Empaques] T3 ON  T1.[IdProducto] = T3.[IdProducto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[ProductosGarantias] T4 ON T1.[Referencia] = T4.[Cod_Producto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[Marcas] T5 ON T4.[Cod_Marca] = T5.[Cod_Marca] \r\n  WHERE T1.[Referencia] LIKE 'L%' AND T1.[Referencia] LIKE '" + sapCode + "%' AND T2.Cod_ListaPrecio = '" + IndiceLista + "' AND T3.[NumeroUnidades] > 0;";
				
			}
            else if (Obtner.hablador == "P")
            {
				// listaDinamica = "SELECT TOP (100)\r\n       T1.[Referencia] Codigo\r\n      ,T1.[Nombre] Nombre\r\n      ,T5.[Marca] Marca\r\n      ,T4.[CantidadDiasGarantia] Garantia\r\n      ,isNull(T3.[Barra], 0) Codigo_Barra\r\n      ,T2.[Precio] PrecioaMostrar\r\n      ,0 PrecioTachado\r\n      ,T6.Inventario\r\n      ,T6.CodigoSucursal\r\n\t  ,T6.Sucursal\r\n  FROM [DB_AWS_MELE].[dbo].[Transaccional.Productos] T1 \r\n  INNER JOIN [DB_AWS_MELE].[dbo].[ListasPrecios] T2 ON T1.Referencia = T2.[Cod_Producto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[Transaccional.Empaques] T3 ON  T1.[IdProducto] = T3.[IdProducto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[ProductosGarantias] T4 ON T1.[Referencia] = T4.[Cod_Producto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[Marcas] T5 ON T4.[Cod_Marca] = T5.[Cod_Marca]\r\n  INNER JOIN [TIENDAS_MELE].[dbo].[TM_VW_ExistenciaTiendasMele] T6 ON T2.[Cod_Producto] = T6.[CodArticulo]\r\n  WHERE (T1.[Referencia] NOT LIKE 'LB%' OR  T1.[Referencia] LIKE 'LM%') AND T2.Cod_ListaPrecio = '" + indice + "' AND T3.[NumeroUnidades] > 0\r\n  AND T6.CodigoSucursal = '" + sucursal + "' AND T6.Inventario > 0  AND T6.CodArea = '" + almacen + "'";
				queryBusquedaEnLaLista = "SELECT \r\n       T1.[Referencia] Codigo\r\n      ,T1.[Nombre] Nombre\r\n\t  ,T5.[Marca] Marca\r\n\t  ,T4.[CantidadDiasGarantia] Garantia\r\n\t  ,isNull(T3.[Barra], 0) Codigo_Barra\r\n\t  ,T2.[Precio] PrecioaMostrar\r\n\t  ,0 PrecioTachado\r\n  FROM [DB_AWS_MELE].[dbo].[Transaccional.Productos] T1 \r\n  INNER JOIN [DB_AWS_MELE].[dbo].[ListasPrecios] T2 ON T1.Referencia = T2.[Cod_Producto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[Transaccional.Empaques] T3 ON  T1.[IdProducto] = T3.[IdProducto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[ProductosGarantias] T4 ON T1.[Referencia] = T4.[Cod_Producto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[Marcas] T5 ON T4.[Cod_Marca] = T5.[Cod_Marca] \r\n  WHERE T1.[Referencia] LIKE 'L%' AND T1.[Referencia] LIKE '" + sapCode + "%' AND T2.Cod_ListaPrecio = '" + IndiceLista + "' AND T3.[NumeroUnidades] > 0;";
				
			}

			return queryBusquedaEnLaLista;

		}
    }   
}

