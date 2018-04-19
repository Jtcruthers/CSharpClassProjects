using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carruthers.RPGCore
{
  class GameConstants
  {
    private const int dodgeDifficulty = 5;
    private const int damageBonus = 5;
    private const int damageRange = 10;
    private const int playerHitpoints = 50;

    private static GameConstants instance = new GameConstants();

    public static GameConstants Instance { get { return instance; } }

    public int DodgeDifficulty { get { return dodgeDifficulty; } }

    public int DamageBonus { get { return damageBonus; } }
    public int DamageRange { get { return damageRange; } }
    public int PlayerHitpoints { get { return playerHitpoints; } }

    private GameConstants() { }
  }
}
