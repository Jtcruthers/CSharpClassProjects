using Carruthers.RoleplayingGameInterfaces;
using Carruthers.RPGCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carruthers.RPGame
{

  class Program
  {
    private IList<ICharacter> playerParty = new List<ICharacter>();

    static void Main(string[] args)
    {
      ICharacter player1 = new Mage("Gandalf");
      ICharacter player2 = new Warrior("Boromir");
      ICharacter player3 = new ComputerWizard("Tim");
      ICharacter player4 = new Archer("Robin");

      IList<ICharacter> playerParty = new List<ICharacter>();
      IList<ICharacter> enemyParty = new List<ICharacter>();

      playerParty.Add(player1);
      playerParty.Add(player2);

      enemyParty.Add(player3);
      enemyParty.Add(player4);

      ICombat combat = new Combat(playerParty, enemyParty, "Allies", "Baddies");
      combat.AutoBattle();

      Console.ReadLine();
    }
  }
}
