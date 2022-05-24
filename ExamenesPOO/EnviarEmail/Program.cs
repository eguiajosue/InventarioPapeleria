// Decompiled with JetBrains decompiler
// Type: EnviarEmail.Program
// Assembly: EnviarEmail, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 18E8F7DE-84B0-41DB-B957-D2041674B30F
// Assembly location: C:\Users\josue\OneDrive\Desktop\EnviarEmail.exe

using System;
using System.Windows.Forms;

namespace EnviarEmail
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
