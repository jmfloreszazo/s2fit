// Decompiled with JetBrains decompiler
// Type: s2fit.UnixTimestamp
// Assembly: s2fit, Version=2013.3.18.9, Culture=neutral, PublicKeyToken=null
// MVID: 2E7A4E2C-2CBB-4E29-BE48-9870B53D7378
// Assembly location: C:\Users\JoséMaríaFloresZazo\Downloads\SCALE2FIT\s2fit.exe

using System;

namespace s2fit
{
  public class UnixTimestamp
  {
    private DateTime mdtIniUnixDate;

    public UnixTimestamp() => this.mdtIniUnixDate = new DateTime(1970, 1, 1, 0, 0, 0);

    public DateTime GetDate(long TimestampToConvert, bool Local) => Local ? this.mdtIniUnixDate.AddSeconds((double) TimestampToConvert).ToLocalTime() : this.mdtIniUnixDate.AddSeconds((double) TimestampToConvert);

    public long GetUnixTimestamp(
      DateTime DateToConvert,
      bool Local,
      int Hour = 0,
      int Minut = 0,
      int Second = 0)
    {
      DateTime dateTime = new DateTime(DateToConvert.Year, DateToConvert.Month, DateToConvert.Day, Hour, Minut, Second);
      return Local ? checked ((long) Math.Round(dateTime.ToUniversalTime().Subtract(this.mdtIniUnixDate).TotalSeconds)) : checked ((long) Math.Round(dateTime.Subtract(this.mdtIniUnixDate).TotalSeconds));
    }
  }
}
