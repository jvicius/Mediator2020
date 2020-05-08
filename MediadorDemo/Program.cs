using MediadorDemo.Models;
using System;

namespace MediadorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var chat = new ChatRoom();

            var alumno1 = new Alumno("David");
            var alumno2 = new Alumno("Elicia");
            var profe = new Profesor("elprof");

            chat.Registrar(alumno1);
            chat.Registrar(alumno2);
            chat.Registrar(profe);

            profe.EnviarMensaje("David", "Hola david , revisa los comentarios hacerca de tu tarea por favor");
            alumno1.EnviarMensaje("Elicia", "Me anda buscando el porf :(");
            alumno2.EnviarMensaje("David", "Y por que te buscan???");
            alumno1.EnviarMensaje("elprof", "Listo ya lo revise...");
            profe.EnviarMensaje("Elicia", "Hola estas excenta no te presentes al examen, saludos...");
            alumno2.EnviarMensaje("elprof", "Muchas gracias!!!");
            alumno2.EnviarMensaje("juan", "Hola Juan!!!");


            Console.ReadKey();

        }
    }
}
