using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CharacterRepository : ICharacterDal
    {

        Context c = new Context();

        public void AddCharacter(Character character)
        {
            c.Add(character);
            c.SaveChanges();
        }

        public void Delete(Character t)
        {
            throw new NotImplementedException();
        }

        public void DeleteCharacter(Character character)
        {
            c.Remove(character);
            c.SaveChanges();
        }

        public Character GetById(int id)
        {
            return c.Characters.Find(id);
        }

        public Character GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Character> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Character t)
        {
            throw new NotImplementedException();
        }

        public List<Character> ListAllCharacter()
        {
            return c.Characters.ToList();
        }

        public void Update(Character t)
        {
            throw new NotImplementedException();
        }

        public void UpdateCharacter(Character character)
        {
            c.Update(character);
            c.SaveChanges();
        }
    }
}
