using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pokemon.Models
{
    public class Pokemon
    {
        [Key]
        [Display(Name ="Pokemon ID")]
        [Required(ErrorMessage ="Pokemon ID is required")]
        public int PokemonID { get; set; }

        [Key]
        [Display(Name = "Pokemon Type")]
        [Required(ErrorMessage = "Pokemon Type is required")]
        public string PokemonType { get; set; }

        [Key]
        [Display(Name = "Pokemon Name")]
        [Required(ErrorMessage = "Pokemon Name is required")]
        public string PokemonName { get; set; }

        [Key]
        [Display(Name = "Pokemon Gender")]
        [Required(ErrorMessage = "Pokemon Gender is required")]
        public string PokemonGender { get; set; }

    }
}
