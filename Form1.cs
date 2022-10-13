using System.Reflection;

namespace automateWork
{
    public partial class Form1 : Form
    {
        private readonly string pathConfig = $"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}/config.json";

        public Form1()
        {
            InitializeComponent();
        }

        private void initProcess_Click(object sender, EventArgs e)
        {
            string currentDate = DateTime.Now.ToString("dd-mm-yyyy");
            if (File.Exists(this.pathConfig))
            {

            }
            else
            {
                MessageBox.Show("El archivo de configuracion config.json no existe", "Configuracion carpeta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void stopProcess_Click(object sender, EventArgs e)
        {

        }
    }
}