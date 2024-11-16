using MascotContest.UI;
using MascotContest.UserClass;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MascotContest
{
    public partial class PetOwnerUI : Form
    {
        //Variable de array para almacenar a los propietarios registrados
        private PetOwner[] arrayOwn = new PetOwner[10];
        //Control del crecimiento del arreglo
        private int index = -1;

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
            PetOwner pown = new PetOwner();

            pown.IdNumber = MskIdNumber.Text;
            pown.Name = TxtNames.Text.ToUpper();        //Convertir en mayuscula el apellido
            pown.Surname = TxtSurName.Text.ToUpper();     //Convertir en mayuscula el apellido 
            pown.Phone = MskPhone.Text;
            pown.Email = TxtEmail.Text;
            pown.Address = TxtAddress.Text.ToUpper();

            //Mandar a Guardar los datos capturados al Array
            //[Se pasa de parámetro el array para almacenar y el indice hasta donde tiene elementos]
            index = pown.AddPetOwner(arrayOwn, index);

            if (index >= 0)
            {
                MessageBox.Show("El registro se ha guardado correctamente",
                    "Guardar Propietario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                //Mandar a limpiar los campos del formulario
                ResetFormFields();
                return; //Hacemos que se concluya el método y retorno al programa principal
            }//End-IF

            MessageBox.Show("No hay espacio suficiente para " +
                "almacenar el registro",
                "Desbordamiento",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }//end-event

        //Reiniciar todos los campos del Formularios y dejarlos en blanco
        private void ResetFormFields()
        {
            MskIdNumber.Clear();        //Borrar contenido del control del Número de cedula
            TxtNames.Clear();           //Borrar el contenido del control text de nombre
            TxtSurName.Clear();         //Borrar el contenido del control text de Apellido
            MskPhone.Clear();           //Borrar contenido del control del Num. Teléfono
            TxtEmail.Clear();           //Borrar contenido del control caja de texto Email
            TxtAddress.Clear();         //Borrar contenido del control caja de texto dirección
        }//End-Reset

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            //Crear una instancia de PetOwner
            PetOwner own = new PetOwner();

            //Determinar si el arreglo tiene elementos, si es así se hace la búsqueda, sino se cancela
            if (index >= 0) 
            {
                own = own.EditOwner(MskIdNumber.Text, index,arrayOwn);

                //Si se obtuvo resultado, pasar a mostrar su contenido en el form
                if (own != null) 
                { 
                    TxtNames.Text = own.Name;
                    TxtSurName.Text = own.Surname;
                    TxtEmail.Text = own.Email;
                    TxtAddress.Text = own.Address;
                    MskPhone.Text = own.Phone;
                }//End-IF 1.1
                //Concluir la ejecución del evento
                return;
            }//End-if 1.0

            MessageBox.Show("No existen elementos que procesar", "Almacenamiento Vacio",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }//End-Method

        private void BtnList_Click(object sender, EventArgs e)
        {
            //Validar si hay elementos actualmente en el Array, si index supera 0 es que tiene elementos
            if (index >= 0)
            {
                //Se carga la ventana (formulario donde desplegará la lista)
                FrmListPetOwner frmList = new FrmListPetOwner(arrayOwn); //Se pasa en el constructor el Array
                frmList.Show();
            }
            else
            {
                MessageBox.Show ("No hay Datos que mostrar, debe realizar \n" +
                    "registro de datos primero", "Propietarios Registrados",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }//End-Methods

        private void Btndischarged_Click(object sender, EventArgs e)
        {
            PetOwner own = new PetOwner();

            //Verificar si hay elementos en el array antes de proceder con la baja
            if (index >= 0)
            {
                int rst = own.DeleteRegister(MskIdNumber.Text, arrayOwn, index);
                //Verificar si la eliminación se realizo correctamente
                if (rst > 0)
                {
                    MessageBox.Show("El registro indicado ha sido dado de baja", 
                        "Baja Propietario",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontro el registro indicado", 
                        "Baja Propietario",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }//End-IF
        }
    }//End-Class
}//End-Namespace
