using System.Threading;
using Carruthers.RoleplayingGameInterfaces;
using Carruthers.RPGCore;

namespace WPFBattle
{
    class BowAttack2 : BowAttack
    {

      private CharacterImage characterImage;

      public BowAttack2(CharacterImage characterImage)
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
