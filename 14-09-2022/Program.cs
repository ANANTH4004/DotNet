using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
using System.Web.Script.Serialization;


namespace SerializableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie m1 = new Movie();
            m1.AddMovieDetails("SK", "Tamil", "Action", 50);
            Movie m2 = new Movie();
            m2.AddMovieDetails("KRK", "Tamil", "Romance", 60);
            Movie m3 = new Movie();
            m3.AddMovieDetails("DS", "English", "Mystery", 100);
            Movie m4 = new Movie();
            m4.AddMovieDetails("NEPV", "Tamil", "Romance", 60);
            Movie m5 = new Movie();
            m5.AddMovieDetails("SMS", "Tamil", "Comedy", 110);
            Movie m6 = new Movie();
            m6.AddMovieDetails("Don't Brethe", "English", "Thriller", 100);
            Movie m7 = new Movie();
            m7.AddMovieDetails("Deadpool", "English", "Action", 50);
            Movie m8 = new Movie();
            m8.AddMovieDetails("24", "Tamil", "Sci-fi", 120);
            Movie m9 = new Movie();
            m9.AddMovieDetails("MIB", "English", "Sci-fi", 120);
            Movie m10 = new Movie();
            m10.AddMovieDetails("West World", "English", "Sci-fi", 120);
            Movie m11 = new Movie("SMS", "Tamil", "Comedy", 110);

            // BinarySerializable();

            // XmlSerialization();

            JsonSerialization(m1, m2, m3);

        }

        private static void JsonSerialization(Movie m1, Movie m2, Movie m3)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            CustomerUser cus = new CustomerUser();
            cus.UserId = 12345;
            cus.Password = "12345password";
            cus.ValidateUser();
            cus.SearchByGenre("Sci-fi");
            cus.WatchedMovie(m1);
            cus.WatchedMovie(m2);
            cus.WatchedMovie(m3);
            StringBuilder ss = new StringBuilder();
            js.Serialize(cus, ss);
            FileStream fs = new FileStream("CustJson1.json", FileMode.Create, FileAccess.Write);
            StreamWriter sr = new StreamWriter(fs);
            sr.Write(ss);
            sr.Close();
            fs.Close();
            fs.Dispose();
        }

        private static void XmlSerialization()
        {
            FileStream fs1 = new FileStream("SearchedMovies.xml", FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xml = new XmlSerializer(typeof(CustomerUser));
            CustomerUser cus = new CustomerUser();
            cus.UserId = 12345;
            cus.Password = "12345password";
            cus.ValidateUser();
            cus.SearchByGenre("Sci-fi");
            xml.Serialize(fs1, cus);
        }

        private static void BinarySerializable()
        {
            FileStream fs = new FileStream("CustomerUser.bin", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter binary = new BinaryFormatter();
            CustomerUser cus = new CustomerUser();
            cus.UserId = 12345;
            cus.Password = "12345password";
            cus.ValidateUser();
            binary.Serialize(fs, cus);
        }
    }
}
