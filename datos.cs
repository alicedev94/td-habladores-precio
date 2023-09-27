// NAME-TEC-AL-0001
// VERSION-Alpha 1.0.0
// AUTHOR-ALICE
// FECHA-24/08/2022

using System.Text;
using System.Data;
using System.Data.SqlClient;
using DocumentFormat.OpenXml.Bibliography;

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
    }

    public class datos01
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string FirtsName { get; set; }
        public string price1 { get; set; }
        public string lista4 { get; set; }
    }

    public class Obtner
    {
        public static bool valorBandera = false;
        public static bool margarita = false;
        public static bool verde = false;
        public static bool naranja = false;
        public static bool azul = false;
        public static bool A = false;
        public static bool B = false;
        public static bool C = false;
        public static bool Maturin = false;
        public static bool conectionServer = false;
        public static int valorLogo = 0;
        public static string listaPrecio = "7";
        public static string ecxellUbicacion = "";
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

        public static string query = "SELECT T1.[Referencia] ItemCode\r\n      ,T1.[Nombre] ItemName\r\n\t  ,T5.[Marca] FirmName\r\n\t  ,T4.[CantidadDiasGarantia] U_DK_GARANTIA\r\n\t  ,isNull(T3.[Barra], 0) CodeBar\r\n\t  ,T2.[Precio] Price1\r\n\t  ,0 Price2\r\n  FROM [DB_AWS_MELE].[dbo].[Transaccional.Productos] T1 \r\n  INNER JOIN [DB_AWS_MELE].[dbo].[ListasPrecios] T2 ON T1.Referencia = T2.[Cod_Producto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[Transaccional.Empaques] T3 ON  T1.[IdProducto] = T3.[IdProducto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[ProductosGarantias] T4 ON T1.[Referencia] = T4.[Cod_Producto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[Marcas] T5 ON T4.[Cod_Marca] = T5.[Cod_Marca] \r\n  WHERE T1.[Referencia] LIKE 'L%' AND T1.[Referencia] LIKE '%L%' AND T2.Cod_ListaPrecio = '2' AND T3.[NumeroUnidades] > 0;";
       
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
        public static string listaSeleccionada(string indice)
        {
            string i = indice;
            Obtner.IndiceLista = i;
            string listaDinamica = "SELECT \r\n       T1.[Referencia] Codigo\r\n      ,T1.[Nombre] Nombre\r\n\t  ,T5.[Marca] Marca\r\n\t  ,T4.[CantidadDiasGarantia] Garantia\r\n\t  ,isNull(T3.[Barra], 0) Codigo_Barra\r\n\t  ,T2.[Precio] PrecioaMostrar\r\n\t  ,0 PrecioTachado\r\n  FROM [DB_AWS_MELE].[dbo].[Transaccional.Productos] T1 \r\n  INNER JOIN [DB_AWS_MELE].[dbo].[ListasPrecios] T2 ON T1.Referencia = T2.[Cod_Producto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[Transaccional.Empaques] T3 ON  T1.[IdProducto] = T3.[IdProducto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[ProductosGarantias] T4 ON T1.[Referencia] = T4.[Cod_Producto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[Marcas] T5 ON T4.[Cod_Marca] = T5.[Cod_Marca] \r\n  WHERE T1.[Referencia] LIKE 'L%' AND T1.[Referencia] LIKE 'L%' AND T2.Cod_ListaPrecio = '" + indice + "' AND T3.[NumeroUnidades] > 0;";
            return listaDinamica;
        }
        public static string busquedaEnLaLista(string sapCode, string IndiceLista)
        {
            string queryBusquedaEnLaLista = "SELECT \r\n       T1.[Referencia] Codigo\r\n      ,T1.[Nombre] Nombre\r\n\t  ,T5.[Marca] Marca\r\n\t  ,T4.[CantidadDiasGarantia] Garantia\r\n\t  ,isNull(T3.[Barra], 0) Codigo_Barra\r\n\t  ,T2.[Precio] PrecioaMostrar\r\n\t  ,0 PrecioTachado\r\n  FROM [DB_AWS_MELE].[dbo].[Transaccional.Productos] T1 \r\n  INNER JOIN [DB_AWS_MELE].[dbo].[ListasPrecios] T2 ON T1.Referencia = T2.[Cod_Producto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[Transaccional.Empaques] T3 ON  T1.[IdProducto] = T3.[IdProducto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[ProductosGarantias] T4 ON T1.[Referencia] = T4.[Cod_Producto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[Marcas] T5 ON T4.[Cod_Marca] = T5.[Cod_Marca] \r\n  WHERE T1.[Referencia] LIKE 'L%' AND T1.[Referencia] LIKE '" + sapCode + "%' AND T2.Cod_ListaPrecio = '" + IndiceLista + "' AND T3.[NumeroUnidades] > 0;";
			return queryBusquedaEnLaLista;
        }
        public static string busquedaEnLaListaNombre(string sapCode, string IndiceLista)
        {
            string queryBusquedaEnLaLista = "SELECT \r\n       T1.[Referencia] Codigo\r\n      ,T1.[Nombre] Nombre\r\n\t  ,T5.[Marca] Marca\r\n\t  ,T4.[CantidadDiasGarantia] Garantia\r\n\t  ,isNull(T3.[Barra], 0) Codigo_Barra\r\n\t  ,T2.[Precio] PrecioaMostrar\r\n\t  ,0 PrecioTachado\r\n  FROM [DB_AWS_MELE].[dbo].[Transaccional.Productos] T1 \r\n  INNER JOIN [DB_AWS_MELE].[dbo].[ListasPrecios] T2 ON T1.Referencia = T2.[Cod_Producto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[Transaccional.Empaques] T3 ON  T1.[IdProducto] = T3.[IdProducto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[ProductosGarantias] T4 ON T1.[Referencia] = T4.[Cod_Producto]\r\n  INNER JOIN [DB_AWS_MELE].[dbo].[Marcas] T5 ON T4.[Cod_Marca] = T5.[Cod_Marca] \r\n  WHERE T1.[Referencia] LIKE 'L%' AND T1.[Referencia] LIKE 'LB-00000001%' AND T2.Cod_ListaPrecio = '2' AND T3.[NumeroUnidades] > 0;";
			return queryBusquedaEnLaLista;
        }
    }   
}

