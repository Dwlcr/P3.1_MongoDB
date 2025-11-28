using System.IO.Packaging;
using MongoDB.Driver;   

var connectionString = "mongodb+srv://a23300755:0u7/o0k1$4$u1|4b/34/t@mmdsclit.jktwo08.mongodb.net/?appName=MmdsClit";
var client = new MongoClient(connectionString);
var database = client.GetDatabase("mmdsClit");
namespace P3._1_23300755
{
    internal static class Program
    {
        public class Nota  {
            public string Id { get; set; }
            public string Titulo { get; set; }
            public string Contenido { get; set; }
            public DateTime fechaCreacion{get; set; }
        }
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}