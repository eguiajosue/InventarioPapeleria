// Decompiled with JetBrains decompiler
// Type: ExamenDistancia.Program
// Assembly: ExamenDistancia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 929C66B3-BE42-4041-A340-38CD61776081
// Assembly location: C:\Users\josue\OneDrive\Desktop\ExamenDistancia_2.exe

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
