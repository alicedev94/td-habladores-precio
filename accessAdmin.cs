// NAME-TEC-AL-0001
// VERSION-Alpha 1.0.0
// AUTHOR-ALICE
// FECHA-24/08/2022

using System.Configuration;
using System.Xml;
using System.Xml.XPath;

namespace phApp
{
    public partial class accessAdmin : MaterialSkin.Controls.MaterialForm
    {
        public accessAdmin()
        {
            InitializeComponent();
        }

        private void accessAdmin_Load(object sender, EventArgs e)
        {
            materialComboBox1.Items.Add("Hablador Pequeño");
            materialComboBox1.Items.Add("Hablador Grande");
        }

        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        private void materialButton1_Click(object sender, EventArgs e)
        { 
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                materialTextBox1.Text = openFileDialog1.FileName;
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (materialComboBox1.SelectedIndex == 0)
            {
                config.AppSettings.Settings["LogoP"].Value = materialTextBox1.Text;
                config.Save(ConfigurationSaveMode.Modified);

            }
            else if (materialComboBox1.SelectedIndex == 1)
            {
                config.AppSettings.Settings["LogoG"].Value = materialTextBox1.Text;
                config.Save(ConfigurationSaveMode.Modified);
            }
            MessageBox.Show("Logo de Promo Actualizado");

            Application.Exit();
        }
    }
}
