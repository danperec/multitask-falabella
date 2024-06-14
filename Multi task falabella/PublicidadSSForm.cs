using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Multi_task_falabella
{
    public partial class PublicidadSSForm : Form
    {
        public PublicidadSSForm()
        {
            InitializeComponent();
        }

        private void btnVolverSSH_Click(object sender, EventArgs e)
        {
            // Cerrar esta ventana
            this.Close();
        }

        private void btnEnvioSS_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("primarios y secundarios.xml");

                XmlNodeList maquinas = xmlDoc.SelectNodes("//maquina");
                foreach (XmlNode maquina in maquinas)
                {
                    string nombre = maquina.Attributes["nombre"].Value;
                    string ip = maquina.Attributes["ip"].Value;

                    // Mostrar mensaje de conexión
                    MessageBox.Show($"Conectando a servidor {ip}", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    try
                    {
                        // Conectar a servidor
                        System.Diagnostics.Process.Start("net", $"use T: \\\\{ip}\\c$").WaitForExit();

                        // Mostrar mensaje de transferencia de archivo
                        MessageBox.Show($"Transferiendo ss.zip a {nombre}", "Transferencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Copiar el nuevo ss.zip a la tienda
                        System.Diagnostics.Process.Start("cmd", $"/c copy /y \"C:\\Documents and Settings\\Administrator\\Desktop\\multitask\\Copiar SS SecondScreen\\ss.zip\" T:\\\"Program Files\"\\RCS\\AS\\Data\\SecondScreen\\").WaitForExit();

                        // Mostrar mensaje de éxito
                        MessageBox.Show($"SS transferido con éxito a {nombre}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Mostrar mensaje de error si falla la transferencia
                        MessageBox.Show($"Error al transferir SS a {nombre}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Desconectar de la tienda
                        System.Diagnostics.Process.Start("net", "use /d T:").WaitForExit();
                    }
                }

                // Mostrar mensaje de proceso completado
                MessageBox.Show("Proceso completado. Presione cualquier tecla para salir.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si falla la carga del XML
                MessageBox.Show($"Error al cargar el archivo XML: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
