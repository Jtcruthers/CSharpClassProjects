using Carruthers.RoleplayingGameInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carruthers.RPGCore
{
  class NormalAttack : IAttack
  {
    protected Random randomNumbers = new Random();
    public virtual void Attack(ICharacter attacker, ICharacter target)
    {
      int damage = GameConstants.Instance.DamageBonus + randomNumbers.Next(GameConstants.Instance.DamageRange);
      target.ReceiveAttack(damage);
    }
  }
}
