using Newtonsoft.Json;
using SharpQuill;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VisemesWinFormsApp
{
  
  internal class VisemesGenerator
  {

    public int timeConversion = 12600;
    public int offset;//this is the offset for the audio file in Quill. Apply offset to mouth layer
                      //may not be needed
                      //have a dictionary that maps layers to visemes
    private Dictionary<string, LayerGroup> visemeMap = new Dictionary<string, LayerGroup>();


    public List<string> visemes = new List<string>
      {
        "A",
        "B",
        "C",
        "D",
        "E",
        "F",
        "G",
        "H",
        "X"
      };



    

    //for form: set when enter. try to autofill when possible-- so like, have a dropdown, set dropdown value to letter if it exists (do lower case and upper case)
    public bool SetVisemeMap(LayerGroup mouthRoot)
    {
      List<LayerGroup> groupLayers = new List<LayerGroup>();
      mouthRoot.GetGroupChildren(groupLayers);
      if(groupLayers.Count ==0) {
        return false;

      }
      foreach (var child in groupLayers)
      {
        //Console.WriteLine(child.Name);
        foreach (var item in visemes)
        {
          //maybe take care of special characters here as well. eh
          if (child.Name.ToLower().Trim() == item.ToLower())
          {
            visemeMap[item] = child;
            //Console.WriteLine(item);
          }
        }
        foreach(var letter in visemeMap)
        {
          if (letter.Value == null)
          {
            return false;
          }
        }
        
      }
      return true;

    }  // find group layers with names-- each must contain at least one paint layer (can be empty and fill out later, I suppose)

    //this should be run right after SetVisemeMap, before SetVisemeAnims
   public LayerGroup createNeutralMouth()
    {
      LayerGroup neutralMouth = new LayerGroup();
      neutralMouth.Name = "Neutral_Mouth";
      foreach (Layer child in visemeMap["X"].Children)
      {
        if (child.Type.ToString() == "Paint")
        {
          LayerPaint paintCopy = JsonConvert.DeserializeObject<LayerPaint>(JsonConvert.SerializeObject(child));
          neutralMouth.Children.Add(paintCopy);
        }
      }
     
      return neutralMouth;
      
    }

    public void SetVisemeAnims(string jsonPath)

    {

      string startingViseme = "";
      string visemeJson = File.ReadAllText(jsonPath);//reading rhubarb output
      dynamic doc = JsonConvert.DeserializeObject(visemeJson);
      dynamic mouthCues = doc.mouthCues; //based off how it's organized by Rhubarb
      float endTime = 0;
      string lastViseme = "";
      foreach (var item in mouthCues)
      {
        //Console.WriteLine("item.value: " + item.value + "; item.end: " + item.end);//check at each one, just in case they're ever out of time order (default is that they're in time order)
        if ((int)(item.start * timeConversion) == 0)
        {
          startingViseme = item.value;
        }
        if ((float)(item.end) > endTime)
        {
          endTime = item.end;
          lastViseme = item.value;
          //Console.WriteLine("current endtine: " + endTime + "; current last viseme: " + lastViseme);
        }

        Keyframe<bool> startVis = new SharpQuill.Keyframe<bool>((int)(item.start * timeConversion), true, Interpolation.None);//add a visibility key frame
        Keyframe<bool> endVis = new SharpQuill.Keyframe<bool>((int)(item.end * timeConversion), false, Interpolation.None);


        visemeMap[(string)item.value].Animation.Keys.Visibility.Add(startVis);
        visemeMap[(string)item.value].Animation.Keys.Visibility.Add(endVis);

      }
      //Console.WriteLine("end of visemes json is: " + endTime*timeConversion + " for viseme: " + lastViseme);
      //set visibility animation for the end time, to start the resting mouth position
      Keyframe<bool> restAtEnd = new Keyframe<bool>((int)(endTime * timeConversion), true, Interpolation.None);
      //first see if a key with this value exists\\
      bool seeIfIncl = false;
      foreach (var item in visemeMap["X"].Animation.Keys.Visibility)

      {
        //Console.WriteLine("time is: " + item.Time);
        if ((int)item.Time == (int)restAtEnd.Time)
        {
          //Console.WriteLine("end time is: " + item.Time);
          item.Value = true;
          seeIfIncl = true;
        }
      }
      if (seeIfIncl == false)
      {
        visemeMap["X"].Animation.Keys.Visibility.Add(restAtEnd);
      }

      //now go through each layer, see earliest visibility start, and if greater than 0, set a visibility start key frame to 0
      //um i should do this more efficiently. but like, i like to think in steps so... idk
      foreach (var key in visemeMap.Keys)
      {
        visemeMap[key].Visible = true;
        if (key != startingViseme)
        {
          List<Keyframe<bool>> visibilityKeys = visemeMap[key].Animation.Keys.Visibility;

          //would like to just do the first item in visibility keys, but being safe in case they could ever be out of order
          for (int i = 0; i < visemeMap[key].Animation.Keys.Visibility.Count; i++)
          {
            if (visemeMap[key].Animation.Keys.Visibility[i].Time == 0)
            {
              visemeMap[key].Animation.Keys.Visibility[i].Value = false;
            }
          }
        }
      }
    }
  }


}

