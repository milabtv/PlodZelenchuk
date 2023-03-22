using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PlodZelenchuk
{
    internal class Program
    { 
    
        private static long GetFactorial(int number)

        {

            if (number == 0)

            {

                return 1;

            }

            return number * GetFactorial(number - 1);

        }
        static void Main(string[] args)
        {
            //connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + Path.GetFullPath(Directory.GetCurrentDirectory() + "\\..\\..\\DatabaseName.mdf") + "\";Integrated Security=True";
            string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=plodzel;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            List <Vid> vidove = new List<Vid>();
            con.Open();
            string selectquery = "SELECT * FROM vid";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, con);
            DataTable table = new DataTable();
            adpt.Fill(table);
            adpt.Dispose();
            con.Close();
            foreach (DataRow row in table.Rows)
            {
                int ID = int.Parse(row["id"].ToString());
                string Name = row["vid_name"].ToString();
                Vid vidobj = new Vid(ID, Name);
                vidove.Add(vidobj);
            }
            con.Open();
            selectquery = "SELECT * FROM producti";
            SqlCommand comm = new SqlCommand(); 
            adpt = new SqlDataAdapter(selectquery, con);
            table = new DataTable();
            adpt.Fill(table);
            adpt.Dispose();
            con.Close();
            foreach (DataRow row in table.Rows)
            {
                string ID = row["id"].ToString();
                string Name = row["prod_name"].ToString();
                string Quant = row["quantity"].ToString();
                string Type = row["vid"].ToString();
                string Proiz = row["proizhod"].ToString();

                Console.WriteLine($"{ID} {Name} {Quant} {Type} {Proiz}");
            }
        }
    }
}
