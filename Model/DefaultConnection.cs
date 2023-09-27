using SpreadsheetLight;

namespace phApp.Model
{
    // class model
    public class DefaultConnection
    {
		/*--Var--*/
		// public static string connectionString = @"Password=Daka321;Persist Security Info=True;User ID=ha;Initial Catalog=DB_TIENDASDAKA_PROD;Data Source=192.168.21.87\SRVSAP2012";
		public static string connectionString = @"Password=Daka321;Persist Security Info=True;User ID=ha;Initial Catalog=DB_AWS_MELE;Data Source=192.168.21.245";
		public static List<string> listProducts = new List<string>();
       

        public static List<string> leer()
        {
            // archivo .csv
            string path = Obtner.ecxellUbicacion;

            // Lectura de archivo .csv
            List<string> listaCsv = new List<string>();
            SLDocument sl = new SLDocument(path);

            int iRow = 1;
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1))) /*fila y columna*/
            {
                listaCsv.Add(sl.GetCellValueAsString(iRow, 1));
                iRow++;
            }

            return listaCsv;
        }
    }
}
