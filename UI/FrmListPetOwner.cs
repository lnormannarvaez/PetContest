using MascotContest.UserClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MascotContest.UI
{
    public partial class FrmListPetOwner : Form
    {
        private PetOwner[] list;
        //Constructor por Default, sin parárametros
        public FrmListPetOwner()
        {
            InitializeComponent();
        }

        public FrmListPetOwner(PetOwner[] list )
        {
            this.list = list; //Arreglo de propietarios de mascota que recibe
            InitializeComponent();
        }

        private void FrmListPetOwner_Load(object sender, EventArgs e)
        {
            DGrView.Rows.Clear(); //Asegurar una limpieza de las filas si ya hay

            int i = 0; //Indice para recorrer los elementos del arreglo

            //Realizar un recorrido del Array y Extraer los elementos mientras tenga
            while (list[i] != null) 
            {
                //Validar si el registro esta habilitado para visualizar
                if (list[i].Enable == 1)
                {
                    DGrView.Rows.Add(list[i].IdNumber,
                                     list[i].Name,
                                     list[i].Surname,
                                     list[i].Phone,
                                     list[i].Email,
                                     list[i].Address);
                }//end-if
                ++i; //Incrementar valor de i para pasar al siguiente elemento
            }//End-While
        }//End-Event
    }//End-Class
}//End-NameSpace
