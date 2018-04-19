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
    public MainWindow()
    {
      InitializeComponent();

      var x = new Testtt { Role = "Pion", Pay = 0 };

      Console.WriteLine(x.Role);
      Console.ReadLine();
    }
  }

  class Testtt
  {
    public string Role { get; set; }
    public int Pay { get; set; }
    public Testtt(string r, int p)
    {
      this.Role = r;
      this.Pay = p;
    }
    public Testtt()
    {

    }
  }
}
