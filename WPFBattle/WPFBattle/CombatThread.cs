using Carruthers.RoleplayingGameInterfaces;
using System.Threading;

namespace WPFBattle
{
    class CombatThread
    {

        private Thread thread;
        private ICombat combat;

        public CombatThread(ICombat combat)
        {
          this.combat = combat;
        }

        public void Start()
        {
          thread = new Thread(() =>
          {
            combat.AutoBattle();
          });

          thread.Name = "GameThread";

          thread.Start();
        }

        public void Deactivate()
        {
          thread.Abort();
        }

    }
}
