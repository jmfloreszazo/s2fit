// Decompiled with JetBrains decompiler
// Type: s2fit.EncryptDecryptClass
// Assembly: s2fit, Version=2013.3.18.9, Culture=neutral, PublicKeyToken=null
// MVID: 2E7A4E2C-2CBB-4E29-BE48-9870B53D7378
// Assembly location: C:\Users\JoséMaríaFloresZazo\Downloads\SCALE2FIT\s2fit.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace s2fit
{
  public class EncryptDecryptClass
  {
    private static string m_strPassPhrase = "@ja(K.dAn13Ll_*254897ERkjshi";
    private static string m_strHashAlgorithm = "MD5";
    private static int m_strPasswordIterations = 2;
    private static string m_strInitVector = "s0Fr12$%1258qW#=";
    private static int m_intKeySize = 256;

    internal static string EncryptMD5(string plainText, string p_strSaltValue)
    {
      string empty = string.Empty;
      string str;
      try
      {
        byte[] bytes1 = Encoding.ASCII.GetBytes(EncryptDecryptClass.m_strInitVector);
        byte[] bytes2 = Encoding.ASCII.GetBytes(p_strSaltValue);
        byte[] bytes3 = Encoding.UTF8.GetBytes(plainText);
        byte[] bytes4 = new Rfc2898DeriveBytes(EncryptDecryptClass.m_strPassPhrase, bytes2, EncryptDecryptClass.m_strPasswordIterations).GetBytes(checked ((int) Math.Round(unchecked ((double) EncryptDecryptClass.m_intKeySize / 8.0))));
        RijndaelManaged rijndaelManaged = new RijndaelManaged();
        rijndaelManaged.Mode = CipherMode.CBC;
        ICryptoTransform encryptor = rijndaelManaged.CreateEncryptor(bytes4, bytes1);
        MemoryStream memoryStream = new MemoryStream();
        CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, encryptor, CryptoStreamMode.Write);
        cryptoStream.Write(bytes3, 0, bytes3.Length);
        cryptoStream.FlushFinalBlock();
        byte[] array = memoryStream.ToArray();
        memoryStream.Close();
        cryptoStream.Close();
        str = Convert.ToBase64String(array);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str = (string) null;
        ProjectData.ClearProjectError();
      }
      return str;
    }

    internal static string DecryptMD5(string cipherText, string p_strSaltValue)
    {
      string empty = string.Empty;
      string str;
      try
      {
        byte[] bytes1 = Encoding.ASCII.GetBytes(EncryptDecryptClass.m_strInitVector);
        byte[] bytes2 = Encoding.ASCII.GetBytes(p_strSaltValue);
        byte[] buffer = Convert.FromBase64String(cipherText);
        byte[] bytes3 = new Rfc2898DeriveBytes(EncryptDecryptClass.m_strPassPhrase, bytes2, EncryptDecryptClass.m_strPasswordIterations).GetBytes(checked ((int) Math.Round(unchecked ((double) EncryptDecryptClass.m_intKeySize / 8.0))));
        RijndaelManaged rijndaelManaged = new RijndaelManaged();
        rijndaelManaged.Mode = CipherMode.CBC;
        ICryptoTransform decryptor = rijndaelManaged.CreateDecryptor(bytes3, bytes1);
        MemoryStream memoryStream = new MemoryStream(buffer);
        CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, decryptor, CryptoStreamMode.Read);
        byte[] numArray = new byte[checked (buffer.Length + 1)];
        int count = cryptoStream.Read(numArray, 0, numArray.Length);
        memoryStream.Close();
        cryptoStream.Close();
        str = Encoding.UTF8.GetString(numArray, 0, count);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str = (string) null;
        ProjectData.ClearProjectError();
      }
      return str;
    }
  }
}
