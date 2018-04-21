using Carruthers.RPGCore;

namespace WPFBattle
{
    class ArcherHero : Archer
    {

      private CharacterImage characterImage;

      public ArcherHero(CharacterImage characterImage)
      {
        this.characterImage = characterImage;
        this.attackBehavior = new BowAttack2(characterImage);
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
