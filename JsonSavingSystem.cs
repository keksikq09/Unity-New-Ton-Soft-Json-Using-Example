using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace keksikq9.Json
{
    public class JsonSavingSystem<T>
    {
        public void Save(T savingObject, string path)
        {
            File.WriteAllText(path,
            JsonConvert.SerializeObject(savingObject, Formatting.Indented, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            }
            ));
        }

        public void SaveArray(T[] savingObjects, string path)
        {
            File.WriteAllText(path,
            JsonConvert.SerializeObject(savingObjects, Formatting.Indented, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            }
            ));
        }

        public void SaveList(List<T> savingObjects, string path)
        {
            File.WriteAllText(path,
            JsonConvert.SerializeObject(savingObjects, Formatting.Indented, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            }
            ));
        }

        public void SaveDictionary(Dictionary<T, T> savingObjects, string path)
        {
            File.WriteAllText(path,
            JsonConvert.SerializeObject(savingObjects, Formatting.Indented, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            }
            ));
        }

        public T Load(string path)
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(path));
        }

        public T[] LoadArray(string path)
        {
            return JsonConvert.DeserializeObject<T[]>(File.ReadAllText(path));
        }

        public List<T> LoadList(string path)
        {
            return JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(path));
        }

        public Dictionary<T,T> LoadDictionary(string path)
        {
            return JsonConvert.DeserializeObject<Dictionary<T, T>>(File.ReadAllText(path));
        }
    }
}