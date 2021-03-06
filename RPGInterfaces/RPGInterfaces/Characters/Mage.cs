﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carruthers.RPGCore
{
  public class Mage : CharacterBase
  {
    public Mage(string name, int health)
    {
      this.CharacterClass = "Mage";
      this.attackBehavior = new FireAttack();
      this.Name = name;
      this.Health = health;
    }


    public Mage(string name) : this(name, GameConstants.Instance.PlayerHitpoints)
    {

    }

    public Mage() : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(), GameConstants.Instance.PlayerHitpoints)
    {

    }
  }
}
