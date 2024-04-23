using Newtonsoft.Json;
using Task22.Json;

namespace Task22
{
    internal class Program
    {
        
      // mellim kod bele deyildi error cox idi errorlari sildim qaldi bele belede islemir onsuz :)
        
        static void Main(string[] args)
        {

            List<string> namesList = new List<string>();
            string json = JsonConvert.SerializeObject(namesList);
            Add("samir");
            Add("garib");
            Add("emil");

            using (StreamReader sr = new StreamReader(@""))
            {
                Console.WriteLine(sr.ReadToEnd());
            }

            using (StreamWriter sw = new StreamWriter(@""))
            {
                sw.WriteLine(json);
            }
            
            Console.WriteLine( Search("samir")); 
            Console.WriteLine( Search("garib"));
        }
        
        static void Add(string name) 
        {
            Add(name); 
        }
        static bool Search(string name)
        {
            return Search(name);
        }

        static void Delete(int index)
        {
           
        }
        
    }
}
