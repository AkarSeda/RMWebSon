using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICharacterService
    {
        void CharacterAdd(Character character);
        void CharacterDelete(Character character);
        void CharacterUpdate(Character character);
        List<Character> GetList();
        Character GetById(int id);
    }
}
