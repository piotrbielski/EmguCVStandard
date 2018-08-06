//----------------------------------------------------------------------------
//  This file is automatically generated, do not modify.      
//----------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace Emgu.CV
{
   public static partial class CvInvoke
   {

     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern float cveTonemapDurandGetSaturation(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveTonemapDurandSetSaturation(
        IntPtr obj,  
        float val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern float cveTonemapDurandGetContrast(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveTonemapDurandSetContrast(
        IntPtr obj,  
        float val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern float cveTonemapDurandGetSigmaSpace(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveTonemapDurandSetSigmaSpace(
        IntPtr obj,  
        float val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern float cveTonemapDurandGetSigmaColor(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveTonemapDurandSetSigmaColor(
        IntPtr obj,  
        float val);
     
   }

   public partial class TonemapDurand
   {

     /// <summary>
     /// Positive saturation enhancement value. 1.0 preserves saturation, values greater than 1 increase saturation and values less than 1 decrease it.
     /// </summary>
     public float Saturation
     {
        get { return CvInvoke.cveTonemapDurandGetSaturation(_ptr); } 
        set { CvInvoke.cveTonemapDurandSetSaturation(_ptr, value); }
     }
     
     /// <summary>
     /// Resulting contrast on logarithmic scale, i. e. log(max / min), where max and min are maximum and minimum luminance values of the resulting image.
     /// </summary>
     public float Contrast
     {
        get { return CvInvoke.cveTonemapDurandGetContrast(_ptr); } 
        set { CvInvoke.cveTonemapDurandSetContrast(_ptr, value); }
     }
     
     /// <summary>
     /// Bilateral filter sigma in color space
     /// </summary>
     public float SigmaSpace
     {
        get { return CvInvoke.cveTonemapDurandGetSigmaSpace(_ptr); } 
        set { CvInvoke.cveTonemapDurandSetSigmaSpace(_ptr, value); }
     }
     
     /// <summary>
     /// bilateral filter sigma in coordinate space
     /// </summary>
     public float SigmaColor
     {
        get { return CvInvoke.cveTonemapDurandGetSigmaColor(_ptr); } 
        set { CvInvoke.cveTonemapDurandSetSigmaColor(_ptr, value); }
     }
     
   }
}