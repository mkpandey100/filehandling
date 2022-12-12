
using System.Text;

namespace FileHandling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = "D:\\csharpfile.txt";

            //CreateFile(path);
            //WritingTextFile(path);
            //AppendFileText(path);
            //OpenFile(path);
            //TruncateFile(path);
            DeleteFile(path);
        }

        private static void CreateFile(string path)
        {
            FileStream fs = new(path, FileMode.Create);
            fs.Close();
        }
        private static void WritingTextFile(string path)
        {
            FileStream fs = new(path, FileMode.Create);
            byte[] bdata = Encoding.Default.GetBytes("Hello File Handling!");
            fs.Write(bdata, 0, bdata.Length);
            fs.Close();
        }

        private static void OpenFile(string path)
        {
            File.Open(path, FileMode.Open, FileAccess.Read, FileShare.None);
            //File.OpenRead(path);
            Console.ReadKey();
        }
        private static void AppendFileText(string path)
        {
            File.AppendAllText(path, "Here is new text content new" + Environment.NewLine);
        }

        private static void TruncateFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            fs.SetLength(10);
        }

        private static void DeleteFile(string path)
        {
            File.Delete(path);
        }
    }
}