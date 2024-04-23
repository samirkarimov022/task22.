using Newtonsoft.Json;

namespace TaskHome22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add("samir");
            //Add("emil");
            //Add("garib");
            //Add("samir");
            Console.WriteLine(Search("mesi mestanski"));
            //Delete("samir");




        }


        public static List<string> DeSerialize(string path)
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
        public static void Add(string name)
        {
            string path = @"C:\Users\Asus\OneDrive\Masaüstü\TaskHome22\Json\Names.json";
            List<string> names = DeSerialize(path);
            names.Add(name);

            Serialize(path, names);

        }
        public static bool Search(string name) 
        {
            string path = @"C:\Users\Asus\OneDrive\Masaüstü\TaskHome22\Json\Names.json";
            List<string> names = DeSerialize(path);
            
            Serialize(path, names);
            return names.Contains(name);
        }



        public static void Delete(string name)
        {
            string path = @"C:\Users\Asus\OneDrive\Masaüstü\TaskHome22\Json\Names.json";
            List<string> names = DeSerialize(path);
            names.Remove(name);
            Serialize<List<string>>(path, names);
        }
    }
}
