using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1;

namespace ConsoleApp1
{
    class Helper
    {
        public static Tarea BuscarID(int _id, List<Tarea> ListaTareaABuscar)
        {
            foreach (var T in ListaTareaABuscar)
            {
                if(T.ID == _id)
                {
                    return T;
                }
            }
            return null;
        }

        public static Tarea BuscarDescripcion(string _desc, List<Tarea> ListaTareaABuscar)
        {
            foreach (var T in ListaTareaABuscar)
            {
                if (T.Descripcion.Contains(_desc))
                {
                    return T;
                }
                else
                {
                    Console.WriteLine("No se encontro la tarea.");
                }
            }
            return null;
        }

    }
}
