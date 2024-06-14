using System;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;

namespace Multi_task_falabella
{
    public partial class PublicidadSSForm : Form
    {
        public PublicidadSSForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnEnvioSS_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("primarios y secundarios.xml");

                XmlNodeList maquinas = xmlDoc.SelectNodes("//maquina");
                progressBar.Maximum = maquinas.Count;

                foreach (XmlNode maquina in maquinas)
                {
                    string nombre = maquina.Attributes["nombre"].Value;
                    string ip = maquina.Attributes["ip"].Value;
                    string tienda = maquina.Attributes["tienda"].Value;

                    // Actualizar mensaje de estado
                    lblStatus.Text = $"Conectando a servidor {nombre}";
                    Thread.Sleep(1000); // Simula tiempo de espera para la conexión

                    try
                    {
                        // Conectar a servidor sin mostrar ventana
                        var startInfo = new ProcessStartInfo("net", $"use T: \\\\{ip}\\c$")
                        {
                            WindowStyle = ProcessWindowStyle.Hidden,
                            CreateNoWindow = true
                        };
                        Process.Start(startInfo).WaitForExit();

                        // Actualizar mensaje de estado
                        lblStatus.Text = $"Transferiendo ss.zip a servidor {nombre}";
                        Thread.Sleep(1000); // Simula tiempo de espera para la transferencia

                        // Copiar el nuevo ss.zip a la tienda sin mostrar ventana
                        startInfo = new ProcessStartInfo("cmd", $"/c copy /y \"C:\\Documents and Settings\\Administrator\\Desktop\\multitask\\Copiar SS SecondScreen\\ss.zip\" T:\\\"Program Files\"\\RCS\\AS\\Data\\SecondScreen\\")
                        {
                            WindowStyle = ProcessWindowStyle.Hidden,
                            CreateNoWindow = true
                        };
                        Process.Start(startInfo).WaitForExit();

                        // Actualizar mensaje de éxito
                        lblStatus.Text = $"SS transferido con éxito a servidor {nombre}";
                    }
                    catch (Exception ex)
                    {
                        // Actualizar mensaje de error
                        lblStatus.Text = $"Error al transferir SS a servidor {nombre}: {ex.Message}";
                    }
                    finally
                    {
                        // Desconectar de la tienda sin mostrar ventana
                        var startInfo = new ProcessStartInfo("net", "use /d T:")
                        {
                            WindowStyle = ProcessWindowStyle.Hidden,
                            CreateNoWindow = true
                        };
                        Process.Start(startInfo).WaitForExit();
                    }

                    // Actualizar la barra de progreso
                    progressBar.Value++;
                }

                // Mostrar mensaje de proceso completado
                lblStatus.Text = "Proceso completado.";
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Error al cargar el archivo XML: {ex.Message}";
            }

            this.Focus(); // Establecer el foco en el formulario
        }

        private void PublicidadSSForm_Load(object sender, EventArgs e)
        {

        }
    }
}



