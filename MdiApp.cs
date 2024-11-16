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
    public partial class MdiApp : Form
    {
        public MdiApp()
        {
            InitializeComponent();
        }

        private void Btn_PetOwner_Click(object sender, EventArgs e)
        {
            //Crear un instancia de Propietario de Mascota
            PetOwnerUI p_owner = new PetOwnerUI();  
            p_owner.MdiParent = this;   //Indicar que se cargue en el MDI
            p_owner.Show();             //Mandar a cargar el formulario
        }//End-Btn_PetyOwner
    }//End-Class
}//End-Namespace
