namespace Carruthers.RoleplayingGameInterfaces
{
  public interface ICharacter
  {
    string CharacterClass { get; }
    string Name { get; }
    int Health { get; }

    void PerformAttack(ICharacter target);
    void ReceiveAttack(int damage);
  }
}
