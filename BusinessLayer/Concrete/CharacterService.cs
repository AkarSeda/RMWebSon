using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CharacterService : ICharacterService
    {
        ICharacterDal _characterDal;

        public CharacterService(ICharacterDal characterDal)
        {
            _characterDal = characterDal;
        }

        public void CharacterAdd(Character character)
        {
            _characterDal.Insert(character);
        }

        public void CharacterDelete(Character character)
        {
            _characterDal.Delete(character);
        }

        public void CharacterUpdate(Character character)
        {
            _characterDal.Update(character);
        }

        public Character GetById(int id)
        {
            return _characterDal.GetByID(id);
        }

        public List<Character> GetList()
        {
            return _characterDal.GetListAll();
        }
    }
}
