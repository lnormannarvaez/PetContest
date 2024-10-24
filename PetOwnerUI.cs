using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MascotContest
{
    public partial class PetOwnerUI : Form
    {
        private 
        public PetOwnerUI()
        {
            //Método Constructor Propio del Formulario
            InitializeComponent();
        }

        private void BtnClosed_Click(object sender, EventArgs e)
        {
            this.Close(); //Cerrar la ventana de formulario
        }//End-Method
    }//End-Class
}//End-Namespace
