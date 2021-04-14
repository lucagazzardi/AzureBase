using InnAndDragons.DataBusiness.Mock;
using InnAndDragons.DataBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnAndDragons.DataBusiness.Business
{

    public interface ILogicHandler
    {
        List<Player> GetPlayers();
        void CreatePlayer(Player player);
        List<Character> GetAll();
        Character GetCharacter(Guid id);
        void CreateCharacter(Character character);
        Character AddExperience(decimal exp, Guid id);
        void Remove(Guid id);
    }
    public class LogicHandler : ILogicHandler
    {
        public List<Player> GetPlayers()
        {
            return Players.playersList.ToList();
        }

        public void CreatePlayer(Player player)
        {
            player.id = Guid.NewGuid();
            Players.playersList.Add(player);
        }

        public List<Character> GetAll()
        {
            return Characters.charactersList.ToList();
        }

        public Character GetCharacter(Guid id)
        {
            return Characters.charactersList.Single(x => Guid.Equals(x.id, id));
        }

        public void CreateCharacter(Character character)
        {
            character.id = Guid.NewGuid();
            Characters.charactersList.Add(character);
        }

        public Character AddExperience(decimal exp, Guid id)
        {
            var character = Characters.charactersList.Single(x => Guid.Equals(x.id, id));
            character.experience += exp;

            return character;
        }

        public void Remove(Guid id)
        {
            Characters.charactersList.RemoveAll(x => Guid.Equals(x.id, id));
        }
    }
}
