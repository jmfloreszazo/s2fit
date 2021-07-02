// Decompiled with JetBrains decompiler
// Type: s2fit.My.Resources.Resources
// Assembly: s2fit, Version=2013.3.18.9, Culture=neutral, PublicKeyToken=null
// MVID: 2E7A4E2C-2CBB-4E29-BE48-9870B53D7378
// Assembly location: C:\Users\JoséMaríaFloresZazo\Downloads\SCALE2FIT\s2fit.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace s2fit.My.Resources
{
  [DebuggerNonUserCode]
  [HideModuleName]
  [StandardModule]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [CompilerGenerated]
  internal sealed class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) s2fit.My.Resources.Resources.resourceMan, (object) null))
          s2fit.My.Resources.Resources.resourceMan = new ResourceManager("s2fit.Resources", typeof (s2fit.My.Resources.Resources).Assembly);
        return s2fit.My.Resources.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => s2fit.My.Resources.Resources.resourceCulture;
      set => s2fit.My.Resources.Resources.resourceCulture = value;
    }
  }
}
