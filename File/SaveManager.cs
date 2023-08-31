using System.IO;
using UnityEngine;

namespace UnityTools.File
{
    public class SaveManager
    {
        public static void Save<T>(T saveData, string path)
        {
            var saveJson = JsonUtility.ToJson(saveData);
            System.IO.File.WriteAllText(path, saveJson);
        }

        public static T Load<T>(string path) where T : new()
        {
            var saveJson = "";
            try
            {
                saveJson = System.IO.File.ReadAllText(path);
            }
            catch (FileNotFoundException)
            {
                var f = System.IO.File.Open(path, FileMode.Create);
                f.Close();
                var t = new T();
                Save(t, path);
                return t;
            }

            return JsonUtility.FromJson<T>(saveJson);
        }
    }
}