using Carruthers.RoleplayingGameInterfaces;
using Carruthers.RPGCore;
using System.Threading;

namespace WPFBattle
{
    class BadGradeAttack2 : BadGradeAttack
    {

      private CharacterImage characterImage;

      public BadGradeAttack2(CharacterImage characterImage)
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
