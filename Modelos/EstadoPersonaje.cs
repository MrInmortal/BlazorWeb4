namespace Tarea4.Modelos
{
    public class EstadoPersonajesService
    {
        public event Action OnChange;

        private List<Personaje> _personajes = new List<Personaje>();

        public List<Personaje> Personajes
        {
            get => _personajes;
            set
            {
                _personajes = value;
                NotifyStateChanged();
            }
        }

        public void NotifyStateChanged() => OnChange?.Invoke();
    }
}
