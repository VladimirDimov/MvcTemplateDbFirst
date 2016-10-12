namespace CommonHelpers.JsonProvider
{
    using System.IO;
    using Newtonsoft.Json;

    public class JsonProvider
    {
        public static void SerializeToFile<T>(T obj, string path)
        {
            var jsonObject = JsonConvert.SerializeObject(obj);

            using (var writer = new StreamWriter(path, append: false))
            {
                SetFileReadonlyStatus(path, false);
                writer.Write(jsonObject.ToString());
            }
        }

        public static string Serialize<T>(T obj)
        {
            var jsonString = JsonConvert.SerializeObject(obj);

            return jsonString;
        }

        public static T DeserializeFromFile<T>(string path)
        {
            CreateFileIfNotExist(path);

            using (var reader = new StreamReader(path))
            {
                var jsonAsString = reader.ReadToEnd();
                var existingSearchResult = JsonConvert.DeserializeObject<T>(jsonAsString);
                return existingSearchResult;
            }
        }

        public static T Deserialize<T>(string json)
        {
            var existingSearchResult = JsonConvert.DeserializeObject<T>(json);
            return existingSearchResult;
        }

        public static void SetFileContentToNull(string path)
        {
            var jsonObject = JsonConvert.SerializeObject(null);
            SetFileReadonlyStatus(path, false);

            using (var writer = new StreamWriter(path, append: false))
            {
                writer.Write(jsonObject.ToString());
            }
        }

        private static void SetFileReadonlyStatus(string path, bool isReadonly)
        {
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(path);
            fileInfo.IsReadOnly = isReadonly;
        }

        private static void CreateFileIfNotExist(string path)
        {
            if (!File.Exists(path))
            {
                using (var writer = new StreamWriter(path))
                {
                    // Create file
                }
            }
        }
    }
}
