using Newtonsoft.Json;
using System.ComponentModel;
using System.IO;
using TaskManager.Models;

namespace TaskManager.Services
{
    class FileService
    {
        private readonly string PATH;

        public FileService(string path)
        {
            PATH = path;
        }
        public BindingList<Model> DataLoad()
        {
            var fileExists = File.Exists(PATH);
            if (!fileExists)
            {
                File.CreateText(PATH).Dispose();
                return new BindingList<Model>();
            }
            using (var reader = File.OpenText(PATH))
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<Model>>(fileText);

            }
        }

        public void DataSave(object DataList)
        {
            using (StreamWriter writer = File.CreateText(PATH))
            {
                string output = JsonConvert.SerializeObject(DataList);
                writer.Write(output);
            }
        }
    }
}
