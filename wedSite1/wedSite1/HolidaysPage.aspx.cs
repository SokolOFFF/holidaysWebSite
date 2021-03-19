using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using MongoDB.Bson;
using System.Web.UI.WebControls;
using MongoDB.Driver;
using System.Text;

public partial class HolidaysPage : System.Web.UI.Page
{

    IMongoDatabase database;
    string[] months = new string[] {"January", "February", "March", "April", "May",
        "June", "July", "August", "September", "October", "November", "December" };

    protected void Page_Load(object sender, EventArgs e)
    {
        ConnectToDB();
    }
    protected void ConnectToDB ()
    {
        string connectionString = "mongodb://localhost:27017";
        MongoClient client = new MongoClient(connectionString);
        database = client.GetDatabase("holidays");
    }
    protected void AddingTest()
    {
        var collection = database.GetCollection<Holiday>("holidays");

        Holiday hol = new Holiday("1 holiday", "1 holiday", DateTime.Parse("2020-11-30"));

        collection.InsertOne(hol);
    }

    protected string ShowingTest()
    {
        StringBuilder html = new StringBuilder();
        var collection = database.GetCollection<Holiday>("holidays");
        List<Holiday> holidays = new List<Holiday>();

        holidays = collection.FindSync(FilterDefinition<Holiday>.Empty).ToList();

        foreach (Holiday holToday in holidays)
        {
            string request = "<p > " + holToday.englishName + "</p>";
            html.Append(request);
        }

        return html.ToString();
    }

    protected string ShowingHolidays()
    {
        StringBuilder html = new StringBuilder();
        var collection = database.GetCollection<Holiday>("holidays");
        List<Holiday> holidays = new List<Holiday>();

        DateTime today = new DateTime(2020, DateTime.Today.Month, DateTime.Today.Day);

        var filter = new BsonDocument("date", today);
        holidays = collection.Find(filter).ToList();

        foreach (Holiday holToday in holidays)
        {
            string request = "<p class='holiday'> " + holToday.englishName + " </p>";
            html.Append(request);
        }
        return html.ToString();
    }

    protected string ShowingDateToday()
    {
        StringBuilder html = new StringBuilder();
        DateTime today = DateTime.Today;
        int day = today.Day;
        int month = today.Month;

        string request = "<p class='date'> " + day.ToString() + "</p>";
        html.Append(request);
        request = "<p class='date'> " + months[month-1] + "</p>";
        html.Append(request);
        return html.ToString();
    }
}