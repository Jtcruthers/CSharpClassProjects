using System;
using Carruthers.RoleplayingGameInterfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carruthers.RPGCore
{
  class BowAttack : NormalAttack
  {
    public override void Attack(ICharacter attacker, ICharacter target)
    {
      Console.WriteLine(attacker.Name + " shoots their bow at " + target.Name + "!");
      base.Attack(attacker, target);
    }
  }
}
