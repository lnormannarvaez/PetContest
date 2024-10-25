using MascotContest.UserClass;
using System;
using System.Windows.Forms;

namespace MascotContest
{
    public partial class PetOwnerUI : Form
    {
        //Variable de array para almacenar a los propietarios registrados
        private PetOwner[] arrayOwn = new PetOwner[10];
        //Control del crecimiento del arreglo
        private int index = 0;
        
        public PetOwnerUI()
        {
            //Método Constructor Propio del Formulario
            InitializeComponent();
        }

        private void BtnClosed_Click(object sender, EventArgs e)
        {
            this.Close(); //Cerrar la ventana de formulario
        }//End-Method

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //Crear una instancia de PetOwner
            PetOwner pown = new PetOwner ();

            pown.IdNumber = MskIdNumber.Text;
            pown.Name = TxtNames.Text;
            pown.Surname = TxtNames.Text;
            pown.Phone = MskPhone.Text;
            pown.Email =TxtEmail.Text;
            pown.Address = TxtAddress.Text;

            //Mandar a Guardar los datos capturados al Array
            int rst = pown.AddPetOwner(arrayOwn, index);
            if (rst >= 0)
            {
                MessageBox.Show("Registro Guardo", "No Joder");
            }

        }
    }//End-Class
}//End-Namespace
