using automateWork.Functions;
using automateWork.Models;
using Newtonsoft.Json;
using System.Globalization;
using System.Reflection;

namespace automateWork
{
    public partial class Form1 : Form
    {
        private readonly string pathConfig = $"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}/config.json";
        private PropertiesConfigFolder folderConfig;
        private Thread thr;

        public Form1()
        {
            if (File.Exists(this.pathConfig))
            {
                try
                {
                    StreamReader file = new StreamReader(this.pathConfig);
                    string allJson = file.ReadToEnd();
                    ConfigModel items = JsonConvert.DeserializeObject<ConfigModel>(allJson);

                    if (items != null)
                    {
                        this.folderConfig = items.Folder;
                        InitializeComponent();
                    }
                    else
                        this.CloseProgram("Faltan propiedades dentro del archivo de configuracion", "Error archivo config.json");
                }
                catch (Exception ex)
                {
                    this.CloseProgram(ex.ToString(), "Ha ocurrido un error");
                }
            }
            else
                this.CloseProgram("El archivo de configuracion config.json no existe", "Configuracion carpeta");
        }

        private async void initProcess_Click(object sender, EventArgs e)
        {
            this.initProcess.Enabled = false;
            try
            {
                string currentDate = DateTime.Now.ToString("dd-M-yyyy", CultureInfo.InvariantCulture);
                string pathCreate = $"{this.folderConfig.pathCreateFolder}/{currentDate}";
                Directory.CreateDirectory(pathCreate);

                if (this.folderConfig.allowDecompress == "S")
                {
                    verifyCompressed vf = new(this.folderConfig.pathSearchCompressed, pathCreate, this.folderConfig.compressedFormat);
                    this.thr = new Thread(new ThreadStart(vf.timeOutVerify));
                    this.thr.Start();
                }
            }
            catch (Exception ex)
            {
                this.initProcess.Enabled = true;
                this.CloseProgram(ex.ToString(), "Ha ocurrido un error");
            }
        }

        private void stopProcess_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.thr != null)
                {
                    if (this.thr.IsAlive)
                    {
                        this.thr.Abort();
                    }
                }
            }
            catch (Exception ex){}

            this.initProcess.Enabled = true;
        }

        private void CloseProgram(string description, string title)
        {
            MessageBox.Show(description, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }
    }
}