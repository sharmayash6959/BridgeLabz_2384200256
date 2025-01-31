using System;

class DisplayCurrentTimeInDifferentTimeZones
{
    static void Main(string[] args)
    {
        DateTimeOffset utcTime = DateTimeOffset.UtcNow;
        
        TimeZoneInfo gmtZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        
        DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(utcTime, gmtZone);
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcTime, istZone);
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcTime, pstZone);
        
        Console.WriteLine("Current Time in Different Time Zones:");
        Console.WriteLine("UTC Time: " + utcTime.ToString("yyyy-MM-dd HH:mm:ss") + " UTC");
        Console.WriteLine("GMT Time: " + gmtTime.ToString("yyyy-MM-dd HH:mm:ss") + " GMT");
        Console.WriteLine("IST Time: " + istTime.ToString("yyyy-MM-dd HH:mm:ss") + " IST");
        Console.WriteLine("PST Time: " + pstTime.ToString("yyyy-MM-dd HH:mm:ss") + " PST");
        
        Console.ReadLine();
    }
}
