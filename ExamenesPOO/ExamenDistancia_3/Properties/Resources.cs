// Decompiled with JetBrains decompiler
// Type: ExamenDistancia.Properties.Resources
// Assembly: ExamenDistancia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F2BF469-798D-40E5-B468-6ECB67F0C795
// Assembly location: C:\Users\josue\OneDrive\Desktop\ExamenDistancia_3.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ExamenDistancia.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (ExamenDistancia.Properties.Resources.resourceMan == null)
          ExamenDistancia.Properties.Resources.resourceMan = new ResourceManager("ExamenDistancia.Properties.Resources", typeof (ExamenDistancia.Properties.Resources).Assembly);
        return ExamenDistancia.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => ExamenDistancia.Properties.Resources.resourceCulture;
      set => ExamenDistancia.Properties.Resources.resourceCulture = value;
    }

    internal static Bitmap Ayuda => (Bitmap) ExamenDistancia.Properties.Resources.ResourceManager.GetObject(nameof (Ayuda), ExamenDistancia.Properties.Resources.resourceCulture);

    internal static Bitmap AyudaExamen3JPOO => (Bitmap) ExamenDistancia.Properties.Resources.ResourceManager.GetObject(nameof (AyudaExamen3JPOO), ExamenDistancia.Properties.Resources.resourceCulture);

    internal static Bitmap AyudaExamen3JPOO1 => (Bitmap) ExamenDistancia.Properties.Resources.ResourceManager.GetObject(nameof (AyudaExamen3JPOO1), ExamenDistancia.Properties.Resources.resourceCulture);

    internal static Bitmap FigurasGeometricas => (Bitmap) ExamenDistancia.Properties.Resources.ResourceManager.GetObject(nameof (FigurasGeometricas), ExamenDistancia.Properties.Resources.resourceCulture);
  }
}
