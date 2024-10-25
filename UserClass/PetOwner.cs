using System;

namespace MascotContest.UserClass
{
    public class PetOwner
    {
        /* --------------------------------------------------------------------------------------- */
        /*                  ENCAPSULACIÓN DE CAMPOS => MÉTODOS DE PROPIEDADES
        /* --------------------------------------------------------------------------------------- */
        public String IdNumber { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
        public String Address { get; set; }
        public int Enable { get; set; }

        //Atributo que indica la cantidad máxima de elementos que debe tener el arreglo
        private int SIZE = 10; 

        /* --------------------------------------------------------------------------------------- */
        /*                                  Metodo  Constructor                                    */
        /* --------------------------------------------------------------------------------------- */

        public PetOwner() {
            Enable = 1;
        }

        /* --------------------------------------------------------------------------------------- */
        /*                                  Instance methods                                       */
        /* --------------------------------------------------------------------------------------- */

        public int AddPetOwner(PetOwner[] arr, int i)
        {
            //Verificar si hay espacio en el arreglo para agregar un nuevo elemento
            if (i < SIZE)
            {
                //Si hay espacio se agrega el nuevo objeto propietario
                arr[i + 1] = this; //Le agrego el objeto que esta actualmente en uso
                return i;
            }//End if            
            return -1;
        }//End-Methods


    }//End-Class
}//End-namespace
