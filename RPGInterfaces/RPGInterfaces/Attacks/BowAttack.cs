using System;
using Carruthers.RoleplayingGameInterfaces;

namespace Carruthers.RPGCore
{
  public class BowAttack : NormalAttack
  {
    public override void Attack(ICharacter attacker, ICharacter target)
    {
      Console.WriteLine(attacker.Name + " shoots their bow at " + target.Name + "!");
      base.Attack(attacker, target);
    }
  }
}
