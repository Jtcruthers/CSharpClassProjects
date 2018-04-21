using Carruthers.RoleplayingGameInterfaces;
using Carruthers.RPGCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFBattle
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private TextBoxStreamWriter consoleWriter;
    private ICombat combat;
    private CombatThread combatThread;

    public MainWindow()
    {
      InitializeComponent();
      consoleWriter = new TextBoxStreamWriter(TextBox);
      Console.SetOut(consoleWriter);

      ICharacter mage = new MageHero(mageImage);
      ICharacter warrior = new WarriorHero(warriorImage);
      ICharacter archer = new ArcherHero(archerImage);
      ICharacter computerWizard = new ComputerWizardHero(computerWizardImage);

      IList<ICharacter> friendlyParty = new List<ICharacter>();
      IList<ICharacter> enemyParty = new List<ICharacter>();

      friendlyParty.Add(warrior);
      enemyParty.Add(mage);
      enemyParty.Add(archer);
      enemyParty.Add(computerWizard);

      combat = new Combat(friendlyParty, enemyParty, "Good Guys", "Baddies");

      combatThread = new CombatThread(combat);
      combatThread.Start();
    }
  }

}
