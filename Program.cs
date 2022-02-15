using System;

namespace Generics
{
    class Program
    {
        public static void Main(string[] args)
        {
            DataStore<string> store = new DataStore<string>();
            store.Data = "Hi";

            Console.WriteLine(store.Data);

            DataStore<int> intStore = new DataStore<int>();
            intStore.Data = 200;
            Console.WriteLine(intStore.Data);

            KeyValuePair<int, string> kvp1 = new KeyValuePair<int, string>();
            kvp1.Key = 100;
            kvp1.Value = "Hundred";
            Console.WriteLine(kvp1.Key + " " + kvp1.Value);

            KeyValuePair<string, string> kvp2 = new KeyValuePair<string, string>();
            kvp2.Key = "IT";
            kvp2.Value = "Information Technology";
            Console.WriteLine(kvp2.Key + " " + kvp2.Value);

            DataStore<string> cities = new DataStore<string>();
            cities.AddUp(0, "Mumbai");
            cities.AddUp(1, "Chicago");

            Console.WriteLine(cities.GetData(100));

            DataStore<int> empIds = new DataStore<int>();
            empIds.AddUp(0, 50);
            empIds.AddUp(1, 25);
            empIds.AddUp(2, 89);

            Console.WriteLine(empIds.GetData(0));
        }

    }
    
}