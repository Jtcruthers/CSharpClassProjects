using Carruthers.RPGCore;

namespace WPFBattle
{
    class ComputerWizardHero : ComputerWizard
    {

      private CharacterImage characterImage;

      public ComputerWizardHero(CharacterImage characterImage)
      {
        this.characterImage = characterImage;
        this.attackBehavior = new BadGradeAttack2(characterImage);
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
