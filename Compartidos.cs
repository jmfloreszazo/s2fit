// Decompiled with JetBrains decompiler
// Type: s2fit.Compartidos
// Assembly: s2fit, Version=2013.3.18.9, Culture=neutral, PublicKeyToken=null
// MVID: 2E7A4E2C-2CBB-4E29-BE48-9870B53D7378
// Assembly location: C:\Users\JoséMaríaFloresZazo\Downloads\SCALE2FIT\s2fit.exe

using Microsoft.VisualBasic.CompilerServices;
using System;

namespace s2fit
{
  [StandardModule]
  internal sealed class Compartidos
  {
    public const string fitbit_ConsumerKey = "75f47db3edf34217bbf75aa1f07e04b0";
    public const string fitbit_ConsumerSecret = "3ed25705358c4f0f886adefc742e0c31";
    public const string withings_ConsumerKey = "03e740705275c7400fd224d7cb8700d84919574d3ef0845c7d40f1012de7304";
    public const string withings_ConsumerSecret = "fbc75c0916608631c771ef41bc74ec50b1d78323380f070d470807924365d";
    public const string fitbit_baseUrl = "https://api.fitbit.com/";
    public const string fitbit_RequestTokenUrl = "oauth/request_token";
    public const string fitbit_AuthorizationUrl = "oauth/authorize";
    public const string fitbit_AccessTokenUrl = "oauth/access_token";

    public static string Encrypt(string cadena)
    {
      string empty1 = string.Empty;
      string empty2;
      try
      {
        return EncryptDecryptClass.EncryptMD5(cadena, "75f47db3edf34217bbf75aa1f07e04b0");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        empty2 = string.Empty;
        ProjectData.ClearProjectError();
      }
      return empty2;
    }

    public static string Decrypt(string cadena)
    {
      string empty1 = string.Empty;
      string empty2;
      try
      {
        return EncryptDecryptClass.DecryptMD5(cadena, "75f47db3edf34217bbf75aa1f07e04b0");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        empty2 = string.Empty;
        ProjectData.ClearProjectError();
      }
      return empty2;
    }
  }
}
