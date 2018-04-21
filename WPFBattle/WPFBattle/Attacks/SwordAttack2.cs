using Carruthers.RoleplayingGameInterfaces;
using Carruthers.RPGCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPFBattle
{
    class SwordAttack2 : SwordAttack
    {

    private CharacterImage characterImage;

    public SwordAttack2(CharacterImage characterImage)
    {
      this.characterImage = characterImage;
    }

    public override void Attack(ICharacter attacker, ICharacter target)
    {
      base.Attack(attacker, target);
      characterImage.State = CharacterImage.CharacterState.Attacking;
      Thread.Sleep(500);
    }
  }
}
