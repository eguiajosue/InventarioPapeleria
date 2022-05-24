// Decompiled with JetBrains decompiler
// Type: EnviarEmail.Properties.Resources
// Assembly: EnviarEmail, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 18E8F7DE-84B0-41DB-B957-D2041674B30F
// Assembly location: C:\Users\josue\OneDrive\Desktop\EnviarEmail.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace EnviarEmail.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
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
        if (EnviarEmail.Properties.Resources.resourceMan == null)
          EnviarEmail.Properties.Resources.resourceMan = new ResourceManager("EnviarEmail.Properties.Resources", typeof (EnviarEmail.Properties.Resources).Assembly);
        return EnviarEmail.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => EnviarEmail.Properties.Resources.resourceCulture;
      set => EnviarEmail.Properties.Resources.resourceCulture = value;
    }
  }
}
