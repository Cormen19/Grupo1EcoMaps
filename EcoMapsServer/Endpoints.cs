namespace EcoMapsServer
{
    public class Endpoints
    {
        public static string GetAllPersonajes()
        {
            return $"https://rickandmortyapi.com/api/character";
        }
        public static string GetPersonajesId(string id)
        {
            return $"https://rickandmortyapi.com/api/character/{id}";
        }
        public static string GetPersonajesByName(string name)
        {
            return $"https://rickandmortyapi.com/api/character/?name={name}";
        }
    }
}
