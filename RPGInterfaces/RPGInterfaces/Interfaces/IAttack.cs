﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carruthers.RoleplayingGameInterfaces
{
  public interface IAttack
  {
    void Attack(ICharacter attacker, ICharacter target);
  }
}
