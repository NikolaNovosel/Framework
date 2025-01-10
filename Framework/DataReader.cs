using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Framework
{
    internal static class DataReader
    {
        private static string ReadData()
        {
            string path = "testData.json";
            using FileStream fileStream = File.OpenRead(path);
            byte[] bt = new byte [1024];
            int byteRead = fileStream.Read(bt, 0, bt.Length);
            UTF8Encoding utf = new();
            if (byteRead > 0) return utf.GetString(bt, 0, byteRead);
            return null;
        }
        private static readonly dynamic json = JsonConvert.DeserializeObject(ReadData());
        internal static string GetParameter(Parameter parameter) => (string) json["parameter"][parameter.ToString()];
        internal static string GetUrl(Url url) => (string) json["url"][url.ToString()];
        internal enum Parameter
        {
            operatingSystem,
            machine,
            gpu,
            ssd,
            region
        }
        internal enum Url
        {
            cloudGooglePage
        }
    }
}
