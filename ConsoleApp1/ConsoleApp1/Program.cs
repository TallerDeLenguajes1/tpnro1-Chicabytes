using System;
using System.Collections.Generic;
using System.Dynamic;
using ConsoleApp1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de tareas: ");
            int cantTareas = Convert.ToInt32(Console.ReadLine());
            List<Tarea> ListaT = new List<Tarea>();
            for (int i = 0; i < cantTareas; i++)
            { 
                Tarea Ntarea = new Tarea();
                Ntarea.CargarTarea(i);
                ListaT.Add(Ntarea);
            }
            int realizado;
            List<Tarea> TareasRealizadas = new List<Tarea>();
            foreach (var Tar in ListaT) 
            {
                Console.WriteLine(Tar.ToString());
                Console.WriteLine("Se realizo la tarea? \n1.Si\n0.No");
                realizado = Convert.ToInt32(Console.ReadLine());
                if (realizado == 1)
                {
                    TareasRealizadas.Add(Tar);
                }
            }
            foreach (Tarea T in TareasRealizadas)
            {
                ListaT.Remove(T);
            }

            Console.WriteLine("\nTareas Pendientes: \n");
            foreach (var t in ListaT)
            {
                Console.WriteLine(t.ToString());
            }
            Console.WriteLine("\nTareas Realizadas: \n");
            foreach (var r in TareasRealizadas)
            {
                Console.WriteLine(r.ToString());
            }

            //Busqueda por ID
            Console.Write("Ingrese el id de la tarea que desea buscar: ");
            int idbusqueda = Convert.ToInt32(Console.ReadLine());
            Tarea Busqueda1 = Helper.BuscarID(idbusqueda, TareasRealizadas);
            if(Busqueda1 != null)
            {
                Console.WriteLine(Busqueda1.ToString());
            }
            else
            {
                Console.WriteLine("No se encontro la tarea");
            }

            //Busqueda por Descripcion
            Console.Write("Ingrese la descripcion de la tarea que desea buscar: ");
            string descrip = Console.ReadLine().ToString();
            Tarea Busqueda2 = Helper.BuscarDescripcion(descrip, TareasRealizadas);
            if (Busqueda2 != null)
            {
                Console.WriteLine(Busqueda2.ToString());
            }
            else
            {
                Console.WriteLine("No se encontro la tarea");
            }
        }
    }
}
