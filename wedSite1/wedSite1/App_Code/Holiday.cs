using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;

/// <summary>
/// Summary description for Holiday
/// </summary>
public class Holiday
{
    public ObjectId Id { get; set; }
    public DateTime date { get; set; }
    public string englishName { get; set; }
    public string russianName { get; set; }
    public Holiday(string namE, string namR, DateTime dat)
    {
        englishName = namE;
        russianName = namR;
        date = dat;
    }
}