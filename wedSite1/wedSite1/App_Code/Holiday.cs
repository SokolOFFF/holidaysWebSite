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
    public string name { get; set; }
    public Holiday(string nam, DateTime dat)
    {
        name = nam;
        date = dat;
    }
}