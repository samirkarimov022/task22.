using Newtonsoft.Json;
using Task22.Json;

namespace Task22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add("samir");
            Add("Emil");
            Add("Garib");

            //Console.WriteLine(Search(@"C:\Users\hp\source\repos\SerializeReparte\Files\tsconfig1.json", "Alik"));
            //Delete("Emil");
        }
        public static void Add(string name)
        {
            string path = @"C:\Users\Asus\OneDrive\Masaüstü\task22.2\Task22\Json\names.json";
            List<string> names = Deserialize(path);
            names.Add(name);

            Serialize<List<string>>(path, names);

        }
        public static void Search(string path)
        {

        }
        public static void Delete(string name)
        {
            string path = @"C:\Users\Asus\OneDrive\Masaüstü\task22.2\Task22\Json\names.json";
            List<string> names = Deserialize(path);
            names.Remove(name);
            Serialize<List<string>>(path, names);
        }
        public static List<string> Deserialize(string path)
        {
            string result;


            using (StreamReader sr = new StreamReader(path))
            {
                result = sr.ReadToEnd();
            }
            List<string> names = JsonConvert.DeserializeObject<List<string>>(result);
            return names;
        }
        public static void Serialize<T>(string path, T obj)
        {
            string result = JsonConvert.SerializeObject(obj);
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(result);
            }
        }
        //public static List<string> Deserialize(string path)
        //{
        //    string result;


        //    using (StreamReader sr = new StreamReader(path))
        //    {
        //        result = sr.ReadToEnd();
        //    }
        //    List<string> names = JsonConvert.DeserializeObject<List<string>>(result);
        //    return names;
        //}
        //public static void Serialize<T>(string path, T obj)
        //{
        //    string result = JsonConvert.SerializeObject(obj);
        //    using (StreamWriter sw = new StreamWriter(path))
        //    {
        //        sw.Write(result);
        //    }
        //}
       
    }
}
