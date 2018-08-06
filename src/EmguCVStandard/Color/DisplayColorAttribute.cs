//----------------------------------------------------------------------------
//  Copyright (C) 2004-2017 by EMGU Corporation. All rights reserved.       
//----------------------------------------------------------------------------

using System;

#if UNITY_ANDROID || UNITY_IOS || UNITY_STANDALONE || UNITY_METRO || UNITY_EDITOR
using UnityEngine;
#elif NETFX_CORE
using Windows.UI;
#else
using System.Drawing;
#endif

namespace Emgu.CV
{
   [AttributeUsage(AttributeTargets.Property)]
   internal sealed class DisplayColorAttribute : Attribute
   {
      public DisplayColorAttribute(int blue, int green, int red)
      {
         DisplayColor = new Structure.Bgr(blue, green, red);
      }

      public Structure.Bgr DisplayColor { get; set; }

    }
}
