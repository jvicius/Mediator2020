using System;

namespace MediadorDemo.Models
{
    public class Participante
    {
        private string _nombre;
        private ChatRoom _chatRoom;

        public Participante(string nombre)
        {
            _nombre = nombre;
        }

        public string Nombre
        {
            get { return _nombre; }
        }

        public ChatRoom ChatRoom
        {
            get { return _chatRoom; }
            set { _chatRoom = value; }
        }

        public void EnviarMensaje(string para, string mensaje)
        {
            _chatRoom.EnviarMensaje(_nombre, para, mensaje);
        }

        public virtual void RecibirMensaje(string de, string mensaje)
        {
            Console.WriteLine($"{de} para {_nombre} : {mensaje}");
        }

    }
}
