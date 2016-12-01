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
        private List<string> listParameter = new List<string>();
        private bool bKcp = false;


        public List<string> ListParameter
        {
            get
            {
                return listParameter;
            }

            set
            {
                listParameter = value;
            }
        }

        public void WriteConfig(List<string> listP)
        {
            ReadConfig();
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.Default))
            {
                int j = 0;
                for (; j < listP.Count - 1; j++)
                {
                    int no = listPos[j];
                    listConfigText[no] = listConfigText[no].Replace(ListParameter[j], listP[j]);
                }
                //config含有kcp

                if (listP[j] == "False" && bKcp)
                {
                    int no = listPos[j];
                    listConfigText[no - 1] = listConfigText[no - 1].Replace("},", "}");
                    listConfigText.RemoveAt(no);
                    listConfigText.RemoveAt(no);
                    listConfigText.RemoveAt(no);
                }

                else if (listP[j] == "True" && !bKcp)
                {
                    int no = listPos[j - 1];
                    while (true)
                    {
                        no++;
                        if (listConfigText[no].Contains("outboundDetour"))
                        {
                            break;
                        }
                    }
                    listConfigText[no - 2] = listConfigText[no - 2].Replace("}", "},");
                    string tmp = "\"";
                    listConfigText[no - 1] = "\t\t" + tmp + "streamSettings" + tmp + ": {\r\n\t\t\t" + tmp + "network" + tmp + ": " + tmp + "kcp" + tmp + "\r\n\t\t}\r\n\t},";
                }

                foreach (var item in listConfigText)
                {
                    sw.WriteLine(item);
                }
            }
        }

        public List<string> ReadConfig()
        {
            if (File.Exists(path))
            {
                string[] context = File.ReadAllLines(path, Encoding.Default);
                listConfigText.AddRange(context);
                int port = 0;   //用于区分本地端口和服务器端口
                bKcp = false;
                for (int i = 0; i < context.Length; i++)
                {
                    string tmp = context[i];
                    if (tmp.Contains("port"))
                    {
                        if (port == 0)
                        {
                            ListParameter.Add(GetParameterFromLine(context[i]));
                            listPos.Add(i);
                            port++;
                        }
                        else if (port == 1)
                        {
                            ListParameter.Add(GetParameterFromLine(context[i]));
                            listPos.Add(i);
                        }
                    }
                    else if (tmp.Contains("address") || tmp.Contains("id") || tmp.Contains("level"))
                    {
                        ListParameter.Add(GetParameterFromLine(context[i]));
                        listPos.Add(i);
                    }
                    else if (tmp.Contains("alterId"))
                    {
                        ListParameter.Add(GetParameterFromLine(context[i]));
                        listPos.Add(i);
                    }
                    else if (tmp.Contains("streamSettings"))
                    {
                        bKcp = true;
                        listPos.Add(i);
                        break;
                    }
                    else if (tmp.Contains("outboundDetour"))
                    {
                        break;
                    }
                }
                ListParameter.Add(bKcp.ToString());
            }
            return ListParameter;
        }

        private string GetParameterFromLine(string str)
        {
            return str.Split(new char[] { '\"', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)[2];
        }
    }
}
