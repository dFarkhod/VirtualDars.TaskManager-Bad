using System.Text.Json;

namespace VirtualDars.Tasks
{
    public class DataManager
    {
        public static void WriteToFile<T>(string filePath, List<T> data)
        {
            try
            {
                string jsonData = JsonSerializer.Serialize(data);
                File.WriteAllText(filePath, jsonData);
                Console.WriteLine("Ma'lumotlar JSON faylga muvaffaqiyatli yozildi. \n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ma'lumotlarni JSON faylga yozishda xato ro'y berdi: {ex.Message}");
            }
        }
        public static List<T> ReadFromFile<T>(string path)
        {
            List<T> list = new();
            string text = File.ReadAllText(path);
            var data = JsonSerializer.Deserialize<List<T>>(text);

            if (data != null && text.Length > 0)
            {
                foreach (var item in data)
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
