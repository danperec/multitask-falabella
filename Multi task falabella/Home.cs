using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Multi_task_falabella
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnPublicidadSS_Click(object sender, EventArgs e)
        {
            // Crear y mostrar el formulario PublicidadSSForm
            PublicidadSSForm publicidadSSForm = new PublicidadSSForm();
            publicidadSSForm.Show();
        }

        private void btnSalirHome_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            Application.Exit();
        }
    }
}
