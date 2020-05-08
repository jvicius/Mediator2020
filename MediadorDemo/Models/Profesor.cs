using System;
using System.Collections.Generic;
using System.Text;

namespace MediadorDemo.Models
{
    public class Profesor : Participante
    {
        public Profesor(string nombre) : base(nombre)
        {
        }

        public override void RecibirMensaje(string de, string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Para un profesor: ");
            base.RecibirMensaje(de, mensaje);
        }
    }
}
