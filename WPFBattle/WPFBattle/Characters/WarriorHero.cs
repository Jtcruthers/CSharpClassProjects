using Carruthers.RPGCore;
using Carruthers.RoleplayingGameInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBattle
{
    class WarriorHero : Warrior
    {

    private CharacterImage characterImage;

    public WarriorHero(CharacterImage characterImage)
    {
      this.characterImage = characterImage;
      this.attackBehavior = new SwordAttack2(characterImage);
    }

    public override void ReceiveAttack(int damage)
    {
      characterImage.State = CharacterImage.CharacterState.Defending;
      base.ReceiveAttack(damage);
      if (this.Health <= 0)
      {
        characterImage.State = CharacterImage.CharacterState.Dead;
      }
    }
  }
}
