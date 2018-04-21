using System;
using System.Windows.Media;
using System.Windows.Controls;

namespace WPFBattle
{
  class CharacterImage : Image
  {

    public ImageSource IdleImageSource { get; set; }
    public ImageSource AttackingImageSource { get; set; }
    public ImageSource TakeDamageImageSource { get; set; }
    public ImageSource DeadImageSource { get; set; }
    private CharacterState state;
    public CharacterState State {
      get { return state; }
      set {
        state = value;
        this.Dispatcher.Invoke((Action)(() =>
        {
          UpdateImageSource();
        }));
      }
    }

    public enum CharacterState { Attacking, Defending, Idle, Dead };

    protected void UpdateImageSource()
    {
      switch (State)
      {
        case CharacterState.Attacking:
          this.Source = AttackingImageSource;
          break;
        case CharacterState.Defending:
          this.Source = TakeDamageImageSource;
          break;
        case CharacterState.Dead:
          this.Source = DeadImageSource;
          break;
        case CharacterState.Idle:
        default:
          this.Source = IdleImageSource;
          break;
      }
    }

    protected override void OnRender(DrawingContext dc)
    {
      UpdateImageSource();
      base.OnRender(dc);
    }


  }
}
