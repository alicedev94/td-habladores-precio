using System;
using System.Threading;
using System.Windows.Forms;
namespace phApp
{
    public partial class PROGRESO : Form
    {
        public static class CC_Progreso
        {
            public static string Path;
            public static int Rows ;
        }
       
        public PROGRESO()
        {
           
            //CC_Progreso.Rows = m;
           // CC_Progreso.Path = n;
            InitializeComponent();
            BGW1.WorkerSupportsCancellation = true;
            CheckForIllegalCrossThreadCalls = false;
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.Show();
            BGW1.RunWorkerAsync();
            BGW2.RunWorkerAsync();
        }
        private void BGW1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int v = 0, f=0;
            PGB.Minimum = 0;
            //MessageBox.Show(""+sharedclass.valorMaximo);
           // PGB.Maximum = sharedclass.valorMaximo;
            PGB.Value = 1;
            while (1 == 1)
            {
                PGB.Value = f;
                //PROCESAR.PROCESAR_FILAS(out f);
               // f=sharedclass.contBarraProcesos;
                sharedclass1.n = PGB.Value;
                //Lbl_Actual.Text = f.ToString() + " / " + sharedclass.valorMaximo.ToString() + " Registros Procesados";
                if (v > 4)
                {
                    v = 0;
                }
                Thread.Sleep(400);
                switch (v )
                {
                    case 0: 
                        Lbl_Procesando.Text="PROCESANDO."; 
                        break;
                    case 1:
                        Lbl_Procesando.Text = "PROCESANDO..";
                        break;
                    case 3:
                        Lbl_Procesando.Text = "PROCESANDO...";
                        break;
                    case 4:
                        Lbl_Procesando.Text = "PROCESANDO....";
                        break;
                    default:
                        break;
                }
                if (BGW1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                v++;
            } 
        }
        private void BGW2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (1 == 1)
            {
                // PROCESAR.PROCESAR_SQL(CC_Progreso.Path);
                Thread.Sleep(500);
               // if (sharedclass1.n >= sharedclass.valorMaximo)
                //{
                    BGW1.CancelAsync();
                    sharedclass1.n = 0;
                    MessageBox.Show("TERMINE","INFORMACION",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                //}
            }
   
        }

        public static class sharedclass1
        {
            public static int n;
        }
    }
}
