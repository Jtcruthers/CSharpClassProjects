using Carruthers.RoleplayingGameInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carruthers.RPGCore
{
  class FireAttack : NormalAttack
  {
    public override void Attack(ICharacter attacker, ICharacter target)
    {
      Console.WriteLine(attacker.Name + " burns " + target.Name + "!");
      base.Attack(attacker, target);
    }
  }
}
