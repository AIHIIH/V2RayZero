using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace V2RayZero
{
    class ServiceDate
    {
        private List<string> listService = new List<string>();
        //private Dictionary<string, string> dicService = new Dictionary<string, string>();   
        private string path = Environment.CurrentDirectory + "\\service.zero";
        private bool bLoad = false;

        public bool BLoad
        {
            get
            {
                return bLoad;
            }
        }

        public int Count
        {
            get
            {
                return listService.Count;
            }
        }

        public Dictionary<string, string> GetParameter(int no)
        {
            //本地端口，IP，远程端口，id，level，alterId，kcp，备注，组
            Dictionary<string, string> dic = new Dictionary<string, string>();
            string[] tmps = listService[no].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in tmps)
            {
                string[] kv = item.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                dic.Add(kv[0], kv[1]);
            }
            return dic;
        }

        public void LoadService()
        {
            if (File.Exists(path))
            {
                listService.AddRange(File.ReadAllLines(path));
                bLoad = true;
            }
            else
            {
                Dictionary<string, string> dic = new ConfigDispose().ReadConfig();
                if (dic.Count != 0)
                {
                    string tmp = "";
                    //foreach (var item in list)
                    //{
                    //    tmp += (item + ",");
                    //}
                    //tmp += "Null,Null";
                    //listService.Add(tmp);
                    foreach (KeyValuePair<string, string> item in dic)
                    {
                        tmp += (item.Key + ":" + item.Value+",");
                    }
                    tmp += "group:null,mark:null";
                    listService.Add(tmp);
                    bLoad = true;
                }
            }
        }

        public void AddService(Dictionary<string, string> dic)
        {
            string str = Compose(dic);
            listService.Add(str);
        }

        public void RemoveService(int no)
        {
            listService.RemoveAt(no);
        }

        public void Exchange(int n1, int n2)
        {
            string tmp = listService[n1];
            listService[n1] = listService[n2];
            listService[n2] = tmp;
        }

        public void SaveService(int no, Dictionary<string, string> dic)
        {
            listService[no] = Compose(dic);
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                foreach (var item in listService)
                {
                    sw.WriteLine(item);
                }
            }
        }

        private string Compose(Dictionary<string, string> dic)
        {
            string str = "";
            foreach (KeyValuePair<string, string> item in dic)
            {
                str += (item.Key + ":" + item.Value + ",");
            }
            return str;
        }

        public string GetServiceTag(int no)
        {
            Dictionary<string, string> dic = GetParameter(no);
            return (dic["group"] + " > " + dic["mark"] + " : " + dic["remote"]);
        }


    }
}
