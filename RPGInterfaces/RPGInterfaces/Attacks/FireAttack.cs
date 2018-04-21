using Carruthers.RoleplayingGameInterfaces;
using System;

namespace Carruthers.RPGCore
{
  public class FireAttack : NormalAttack
  {
    public override void Attack(ICharacter attacker, ICharacter target)
    {
      Console.WriteLine(attacker.Name + " burns " + target.Name + "!");
      base.Attack(attacker, target);
    }
  }
}
