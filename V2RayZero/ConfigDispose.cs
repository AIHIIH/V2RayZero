using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace V2RayZero
{
    class ConfigDispose
    {
        private string path = Environment.CurrentDirectory + "\\config.json";
        private List<string> listConfigText = new List<string>();
        private List<int> listPos = new List<int>();
        private Dictionary<string, string> dicParameter = new Dictionary<string, string>();//
        private Dictionary<string, int> dicPos = new Dictionary<string, int>();//


        public void WriteConfig(Dictionary<string, string> dicP)
        {
            ReadConfig();
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.Default))
            {
                foreach (KeyValuePair<string, string> item in dicParameter)
                {
                    listConfigText[dicPos[item.Key]] = listConfigText[dicPos[item.Key]].Replace(dicParameter[item.Key], dicP[item.Key]);
                }
                foreach (var item in listConfigText)
                {
                    sw.WriteLine(item);
                }
            }
        }

        public Dictionary<string, string> ReadConfig()
        {
            Action<string, int, string[]> act = (string s, int t, string[] con) =>
                {
                    dicParameter.Add(s, GetParameterFromLine(con[t]));
                    dicPos.Add(s, t);
                };
            if (File.Exists(path))
            {
                string[] context = File.ReadAllLines(path, Encoding.Default);
                listConfigText.AddRange(context);
                int port = 0;   //用于区分本地端口和服务器端口
                for (int i = 0; i < context.Length; i++)
                {
                    string tmp = context[i];
                    if (tmp.Contains("port"))
                    {
                        if (port == 0)
                        {
                            act("local", i, context);
                            port++;
                        }
                        else if (port == 1)
                        {
                            act("remote", i, context);
                        }
                    }
                    else if (tmp.Contains("address"))
                    {
                        act("address", i, context);
                    }
                    else if (tmp.Contains("id"))
                    {
                        act("id", i, context);
                    }
                    else if (tmp.Contains("level"))
                    {
                        act("level", i, context);
                    }
                    else if (tmp.Contains("security"))
                    {
                        act("security", i, context);
                    }
                    else if (tmp.Contains("alterId"))
                    {
                        act("alterId", i, context);
                    }
                    else if (tmp.Contains("network"))
                    {
                        act("network", i, context);
                        break;
                    }
                    else if (tmp.Contains("outboundDetour"))
                    {
                        break;
                    }
                }
            }
            return dicParameter;
        }

        private string GetParameterFromLine(string str)
        {
            return str.Split(new char[] { '\"', ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)[2];
        }
    }
}
