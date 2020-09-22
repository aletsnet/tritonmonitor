using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;

namespace TritonMonitor
{
    class utilerias
    {
        string urlService;
        public String OpenFile(string nameFile)
        {
            string texto = "";
            using (StreamReader sr = new StreamReader(nameFile))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    texto += line;

                }
            }
            return texto;
        }

        public void PostTraferencia(string url, Dictionary<string, string> param)
        {
            try
            {
                WebClient page = new WebClient();
                foreach (var item in param)
                {
                    page.QueryString.Add(item.Key, item.Value);
                }

                var data = page.UploadValues(urlService + url, "POST", page.QueryString);
                var sresult = UnicodeEncoding.UTF8.GetString(data);
                File.WriteAllText("portservice.ini", sresult);
            }
            catch (Exception e)
            {
                File.WriteAllText("portservice.ini", "Error 408 " + e);
            }
        }

        public string PostTraferencia(string url)
        {
            string data = "";
            try
            {
                WebClient page = new WebClient();

                data = page.DownloadString(urlService + url);
            }
            catch (Exception e)
            {
                data = "Error 408 " + urlService + url + " | " + e;
            }
            return data;
        }

        public void PostTraferencia(string url, Dictionary<string, string> param, string file)
        {
            try
            {
                WebClient page = new WebClient();
                foreach (var item in param)
                {
                    page.QueryString.Add(item.Key, item.Value);
                }

                var data = page.UploadValues(urlService + url, "POST", page.QueryString);
                var sresult = UnicodeEncoding.UTF8.GetString(data);
                File.WriteAllText(file, sresult);
            }
            catch (Exception e)
            {
                File.WriteAllText(file, "Error 408 " + e);
            }
        }
    }
}
