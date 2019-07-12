using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//---------------------------------
using System.Net;
using System.Data;
using System.Data.SqlClient;
//---------------------------------

namespace ReadingWebsite
{
    class Program
    {
        static void Main(string[] args)
        {
         
            /*
            string myText = System.IO.File.ReadAllText(@"C:\111\sampleText.txt");

            int indStart = myText.IndexOf(start);
            int indEnd = myText.IndexOf(end);

            //Console.WriteLine(myText);
            */

            //string start = @"""follower_stats""><STRONG>";
            //string end = @"</STRONG> Followers";

            string start = @"followers_count&quot;:";

            WebClient client = new WebClient();
            String msTwitter = client.DownloadString("http://twitter.com/microsoftcanada");
            
            int indStart = msTwitter.IndexOf(start);
            
            //int indEnd = msTwitter.IndexOf(end);
            //int charBetweenTags = indEnd - (indStart + start.Length);
            //Console.WriteLine(indStart);

            string currentFollowers = msTwitter.Substring(indStart + start.Length, 5);

            //string currentFollowers = myText.Substring(indStart + start.Length, charBetweenTags).Replace(",", "");
            //Console.WriteLine(indStart);
            //Console.WriteLine(indEnd);
            
            /*
            // Write to the Database
            SqlConnection cs = new SqlConnection("Data Source=A-DMVAKH-W500\\DIMSQL; Initial Catalog=bucky; Integrated Security=TRUE");
            
            // "SqlData Adapter" sends data from the form to the pipe
            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = new SqlCommand("INSERT INTO [SocialAnalytics] VALUES(@TwitterFollowers,@TwitterDate)", cs);
            da.InsertCommand.Parameters.Add("@TwitterFollowers", SqlDbType.VarChar).Value = currentFollowers;
            da.InsertCommand.Parameters.Add("@TwitterDate", SqlDbType.DateTime).Value = DateTime.Now;

            // Open/close connesction and execute the query
            cs.Open();
            da.InsertCommand.ExecuteNonQuery();
            cs.Close();

            */

            // Final Message
            Console.WriteLine("The number of Twitter followers was inserted into the [SocialAnalytics] table");
            Console.WriteLine("Followers: " + currentFollowers + "\nDate and Time: " + DateTime.Now);
            Console.ReadLine();
       }
    }
}
