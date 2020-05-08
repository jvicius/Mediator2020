using System;
using System.Collections.Generic;
using System.Text;

namespace MediadorDemo.Models
{
    public class Alumno : Participante
    {
        public Alumno(string nombre) : base(nombre)
        {
        }

        public override void RecibirMensaje(string de, string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Para un alumno: ");
            base.RecibirMensaje(de, mensaje);
        }
    }
}
