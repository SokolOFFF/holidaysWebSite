using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MongoDB.Driver;
using System.Text;

public partial class HolidaysPage : System.Web.UI.Page
{

    IMongoDatabase database;

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

        Holiday hol = new Holiday("Russia ppp", DateTime.Parse("1999-11-11"));

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
            string request = "<p> " + holToday.name + "</p>";
            html.Append(request);
        }

        return html.ToString();
    }

}