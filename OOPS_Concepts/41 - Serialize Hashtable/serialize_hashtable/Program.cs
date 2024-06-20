using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace serialize_hashtable
{
    // Yes, There is one way to serialize Hashtable is through Binary Serialization providede by the `System.Runtime.Serialization`.
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a Hashtable
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Key1", "Value1");
            hashtable.Add("Key2", "Value2");
            hashtable.Add("Key3", "Value3");

            // Serialize the Hashtable to a file
            SerializeHashtable(hashtable, "hashtable.dat");

            // Deserialize the hashtable from the file
            Hashtable deserializedHashtable = DeserializeHashtable("hashtable.dat");

            // Display the deserialized Hashtable
            foreach (DictionaryEntry entry in deserializedHashtable)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }

        // Method to serialize a Hashtable to a file
        static void SerializeHashtable(Hashtable hashtable, string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                formatter.Serialize(stream, hashtable);
            }
            Console.WriteLine($"Hashtable serialized to {fileName}");
        }

        // Method to derserialized a Hashtable from a file
        static Hashtable DeserializeHashtable(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(fileName, FileMode.Open))
            {
                return (Hashtable)formatter.Deserialize(stream);
            }
        }
    }
}
