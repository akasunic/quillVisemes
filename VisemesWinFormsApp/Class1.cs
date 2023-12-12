using SharpQuill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisemesWinFormsApp
{
  internal class Character
  {
    public string Name { get; set; }
    public Layer MainLayer { get; set; }
    public Dictionary<string, Layer> mouthOptions { get; set;} = new Dictionary<string, Layer>();
 
    public Audio Audio { get; set; }
    public ComboBox MouthDropDown { get; set; }

  }

  internal class Audio
  {
    public string ShortAudio { get; set; }
    public string LongAudio { get; set; }
    public string ShortTxt { get; set; }
    public string LongTxt { get; set; } = "";
  }


}
