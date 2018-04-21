using System.Text;
using System;
using System.IO;
using System.Windows.Controls;

namespace WPFBattle
{
    class TextBoxStreamWriter : TextWriter
    {

        private TextBox textbox;

        public TextBoxStreamWriter(TextBox textbox)
        {
          this.textbox = textbox;
        }

        public override Encoding Encoding
        {
          get { return System.Text.Encoding.UTF8; }
        }

    public override void Write(char value)
    {
      base.Write(value);
      textbox.Dispatcher.BeginInvoke(new Action(() =>
      {
        textbox.AppendText(value.ToString());
        textbox.ScrollToEnd();
      })
      );
    }
        
    }
}
