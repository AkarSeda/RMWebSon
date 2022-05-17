using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Character
    {
        [Key]
        public int CharacterID { get; set; }
        public string? CharacterName { get; set; }
        public string? CharacterStatus { get; set; }
        public string? CharacterSpecies { get; set; }
        public string? CharacterType { get; set; }
        public string? CharacterGender { get; set; }
    }
}
