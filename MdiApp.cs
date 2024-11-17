
using System;
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
           //Mandar a cargar el formulario
           FrmPetOwner petOwner = new FrmPetOwner();
           petOwner.MdiParent = this;
            petOwner.Show();

        }//End-Btn_PetyOwner
    }//End-Class
}//End-Namespacio