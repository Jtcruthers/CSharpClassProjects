using Carruthers.RPGCore;

namespace WPFBattle
{
    class MageHero : Mage
    {

      private CharacterImage characterImage;

      public MageHero(CharacterImage characterImage)
      {
        this.characterImage = characterImage;
        this.attackBehavior = new FireAttack2(characterImage);
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
