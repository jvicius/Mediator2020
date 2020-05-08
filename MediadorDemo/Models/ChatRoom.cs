using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediadorDemo.Models
{
    public class ChatRoom : AbstractChatRoom
    {
        private List<Participante> _participantes;

        public ChatRoom()
        {
            _participantes = new List<Participante>();
        }

        public override void EnviarMensaje(string de, string para, string mensaje)
        {
            var participante = _participantes.FirstOrDefault(miobjeto => miobjeto.Nombre == para);

            if (participante!=null)
            {
                participante.RecibirMensaje(de, mensaje);
            }
        }

        public override void Registrar(Participante participante)
        {
            if (_participantes.FirstOrDefault(f=>f.Nombre==participante.Nombre)!=null)
            {
                Console.WriteLine("Error participante ya registrado");
            }
            else
            {
                _participantes.Add(participante);
                participante.ChatRoom = this;
            }
        }
    }
}
