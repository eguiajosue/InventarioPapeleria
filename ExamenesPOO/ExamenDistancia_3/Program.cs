// Decompiled with JetBrains decompiler
// Type: ExamenDistancia.Program
// Assembly: ExamenDistancia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F2BF469-798D-40E5-B468-6ECB67F0C795
// Assembly location: C:\Users\josue\OneDrive\Desktop\ExamenDistancia_3.exe

using System;
using System.Windows.Forms;

namespace ExamenDistancia
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new frmForma1());
    }
  }
}
