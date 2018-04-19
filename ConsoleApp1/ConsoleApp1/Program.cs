using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
  class Program
  {
    [System.STAThread] 
    static void Main(string[] args)
    {
      String text = Clipboard.GetText();
      String textOnlyWords = Regex.Replace(text, @"[^\w\s]", "").ToLower(); //Remove punctuation, make lower case
      String[] individualWords = textOnlyWords.Split(new char[0], StringSplitOptions.RemoveEmptyEntries); // new char[0] defaults to all whitespace for the split
      String[] uniqueWords = individualWords.Distinct().ToArray(); //Get unique words
      String[] finalWords = uniqueWords.Where((e, i) => i < 1000).ToArray();
      Array.Sort(finalWords);
      for (int i = 0; i < finalWords.Length; i++)
        Console.WriteLine(finalWords[i]);

      Console.WriteLine("Press Enter to exit");
      Console.ReadLine();
    }
  }
}
