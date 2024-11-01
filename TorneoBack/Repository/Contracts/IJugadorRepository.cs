 public interface IJugadorRepository
    {
        void Add(Jugador jugador);
        void Delete(int id);
        Jugador Get(int id);
        IEnumerable<Jugador> GetAll();
        void Update(Jugador jugador);
    }