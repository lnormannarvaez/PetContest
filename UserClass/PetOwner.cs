using System;
using System.Security.Policy;

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
        public bool Enable { get; set; }

        //Atributo que indica la cantidad máxima de elementos que debe tener el arreglo
        private int SIZE = 10; 

        /* --------------------------------------------------------------------------------------- */
        /*                                  Metodo  Constructor                                    */
        /* --------------------------------------------------------------------------------------- */

        public PetOwner() {
            Enable = true;
        }

        /* --------------------------------------------------------------------------------------- */
        /*                                  Instance methods                                       */
        /* --------------------------------------------------------------------------------------- */

        /// <summary>
        /// Agrega una nueva instancia de Propietario de Mascota al Array
        /// </summary>
        /// <param name="arr">Arreglo en el cual se debe agregar una nueva instancia al final</param>
        /// <param name="i">Indice actual de elementos en el Array</param>
        /// <returns>Indice en el que fue agregado el elemento si hay espacio, -1  en caso 
        /// que ya el array n o contenga espacio de almacenamiento</returns>
        public int AddPetOwner(PetOwner[] arr, int i)
        {
            //Verificar si hay espacio en el arreglo para agregar un nuevo elemento
            if (i < SIZE)
            {
                //Si hay espacio se agrega el nuevo objeto propietario
                arr[i + 1] = this; //Le agrego el objeto que esta actualmente en uso
                return ++i;
            }//End if            
            return -1; //Retornar el tope del array para indicar que no hay espacio
        }//End-Methods

        /// <summary>
        /// Realiza una modificación o actualización de los datos de una la instancia propietario
        /// de mascota según el id especificado
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ind">limite total de elementos que se tienen actualmente en el array</param>
        /// <param name="arrPet">Array en el cual se encuentran almacenadas las instancias de 
        /// propietarios de mascto</param>
        /// <returns>Retorna la instacia de propietario de mascota modificada, null sino se encuentra</returns>
        public PetOwner EditOwner (string id, int ind, PetOwner[] arrPet) 
        {
            bool seek = false;  //Booleano para controla la busqueda en el arreglo
            int i = 0;  //Variable de control para el recorrido del Array

            //Recorrer el arreglo hasta los elementos actuales para buscar el registro de Owner
            while (i <= ind && !seek)
            {
                if (arrPet[i].IdNumber == id)
                { 
                    return arrPet[i];   //Retornar la instancia PetOwner buscada y se corta la iteración
                    //seek = true;      //Se cambia el valor booleano para indicar que se encontro
                }
                ++i;    //Se incrementa en uno para pasar al siguiente indice
            }//End-While
                    
            return null;  //Si no se encuentra retornará null
        }  //End-Methods 

        /// <summary>
        /// Elimina de forma lógica, no fisica, la instancia de propietario de Mascota indicada por id
        /// </summary>
        /// <param name="id">Identificar de la instancia propietario de mascota a eliminar</param>
        /// <param name="arr">Array en el cual se encuentran almacenadas las instancias de mascotas</param>
        /// <param name="limit">Limite total actual hasta donde se debe buscar la instancia en el 
        /// Array</param>
        /// <returns>El indice del Array donde se encuentra la instancia de Mascota eliminada, -1 en 
        /// caso que no se encuentre</returns>
        public int DeleteRegister (string id, PetOwner[] arr, int limit)
        {
            bool seek = false;  //Booleano para controla la busqueda en el arreglo
            int i = 0;  //Variable de control para el recorrido del Array

            //Recorrer el arreglo hasta los elementos actuales para buscar el registro de Owner
            while (i <= limit && !seek)
            {
                if (arr[i].IdNumber == id)
                {
                    arr[i].Enable = true; //Deshabilitar el registro
                    return i;
                }
                ++i;    //Se incrementa en uno para pasar al siguiente indice
            }//End-While

            return -1;  //Si no se encuentra retornará null
        }

    }//End-Class
}//End-namespace
