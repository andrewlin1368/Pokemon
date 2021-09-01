using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pokemon.Models
{
    public class PokemonRepo : IPokemonRepo
    {
        public DBContext context;
        public PokemonRepo(DBContext dBContext)
        {
            context = dBContext;
        }
        public List<Pokemon> ViewAll()
        {
            return context.Pokemon.ToList();
        }
    }
}
