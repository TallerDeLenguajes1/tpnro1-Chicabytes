using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Tarea
    {
        private int iD;
        private string descripcion;
        private int duracion;

        public int ID { get => iD; set => iD = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion { get => duracion; set => duracion = value; }

        public void CargarTarea(int _id)
        {
            string[] Tareas = { "Cortar queso", "Mandar mails", "Terminar tps de taller", "Sacar la basura", "Imprimir teoría de algebra", "Salir a correr", "Ver teoria de Paradigma", "Jugar a los sims 4", }; 
            Random rand = new Random();
            ID = _id;
            Descripcion = Tareas[rand.Next(Tareas.Length)];
            Duracion = rand.Next(10,100);
        }

        public override string ToString()
        {
            return "ID: " + ID.ToString() + "\nDescripcion: " + descripcion + "\nDuracion: " + duracion.ToString();
        }
    }
}
