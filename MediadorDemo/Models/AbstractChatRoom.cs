namespace MediadorDemo.Models
{
    public abstract class AbstractChatRoom
    {
        public abstract void Registrar(Participante participante);

        public abstract void EnviarMensaje(string de, string para, string mensaje);
    }
}
