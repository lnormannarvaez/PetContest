using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MascotContest.UserClass
{
    internal class Evaluator
    {
        /* --------------------------------------------------------------------------------------- */
        /*                  ENCAPSULACIÓN DE CAMPOS => MÉTODOS DE PROPIEDADES
        /* --------------------------------------------------------------------------------------- */
        public string code { get; set; }
        public string names { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public bool Enable { get; set; }

        /* --------------------------------------------------------------------------------------- */
        /*                                  Metodo  Constructor                                    */
        /* --------------------------------------------------------------------------------------- */
        public Evaluator()
        {
            Enable = true;
        }

        /* --------------------------------------------------------------------------------------- */
        /*                                  Instance methods                                       */
        /* --------------------------------------------------------------------------------------- */
        public void AddPetOwner(List<Evaluator> lstEvaluator)
        {
            //Agregar la información del Evaluator a lista de evaluadores
            lstEvaluator.Add(this);
        }//End-Methods

        public Evaluator EditEvaluator(List<Evaluator> lst, string cod)
        {
            //recorrer la lista para realizar la búsqueda del evaluator
            foreach (Evaluator eval in lst)
            {
                //Verificar por el código del Evaluator
                if (eval.code == cod)
                {
                    return eval; //Devolver el evaluador encontrado
                } //End IF                
            }
            //En caso que no se encuentre, retornar null
            return null;
        }//End-Method

        public int DeleteEvaluator(List<Evaluator> lst, string cod)
        {

            //recorrer la lista para realizar la búsqueda del evaluator
            foreach (Evaluator eval in lst)
            {
                //Verificar por el código del Evaluator
                if (eval.code == cod)
                {
                    eval.Enable = false; //Devolver el evaluador encontrado
                    return 1; //Se ha deshabilitado el registro
                } //End IF                
            }//End-foreach
            return 0; //No se ha encontrado registro y no se ha podido deshabilitar
        }
    }//End-Class
}//End-namespace
