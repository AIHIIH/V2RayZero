using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace V2RayZero
{
    class ServiceDate
    {
        private List<string> listService = new List<string>();
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

        public List<string> GetParameter(int no, out string group, out string mark)
        {
            //本地端口，IP，远程端口，id，level，alterId，kcp，备注，组
            List<string> list = new List<string>();
            string[] tmps = listService[no].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < 7; i++)
            {
                list.Add(tmps[i]);
            }
            group = tmps[7];
            mark = tmps[8];
            return list;
        }

        public List<string> GetParameter(int no)
        {
            List<string> list = new List<string>();
            string[] tmps = listService[no].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < 7; i++)
            {
                list.Add(tmps[i]);
            }
            return list;
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
                List<string> list = new ConfigDispose().ReadConfig();
                if (list.Count != 0)
                {
                    string tmp = "";
                    foreach (var item in list)
                    {
                        tmp += (item + ",");
                    }
                    tmp += "Null,Null";
                    listService.Add(tmp);
                    bLoad = true;
                }
            }
        }

        public void AddService(List<string> list)
        {
            string str = Compose(list);
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

        public void SaveService(int no, List<string> list)
        {
            listService[no] = Compose(list);
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                foreach (var item in listService)
                {
                    sw.WriteLine(item);
                }
            }
        }

        private string Compose(List<string> list)
        {
            string str = "";
            int i = 0;
            for (; i < list.Count - 1; i++)
            {
                str += (list[i] + ",");
            }
            str += list[i];
            return str;
        }

        public string GetServiceTag(int no)
        {
            string[] tmps = listService[no].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            return tmps[7] + " > " + tmps[8] + " : " + tmps[2];
        }


    }
}
