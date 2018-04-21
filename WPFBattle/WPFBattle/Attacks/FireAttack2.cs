using Carruthers.RoleplayingGameInterfaces;
using Carruthers.RPGCore;
using System.Threading;

namespace WPFBattle
{
    class FireAttack2 : FireAttack
    {

      private CharacterImage characterImage;

      public FireAttack2(CharacterImage characterImage)
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
