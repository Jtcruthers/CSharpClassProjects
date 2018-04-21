using System;
using Carruthers.RoleplayingGameInterfaces;

namespace Carruthers.RPGCore
{
  public class BadGradeAttack : NormalAttack
  {
    public override void Attack(ICharacter attacker, ICharacter target)
    {
      Console.WriteLine(attacker.Name + " hacks " + target.Name + "!");
      base.Attack(attacker, target);
    }
  }
}
