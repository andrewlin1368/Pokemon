using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pokemon.Models
{
    public interface IPokemonRepo
    {
        List<Pokemon> ViewAll();
    }
}
