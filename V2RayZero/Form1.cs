using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace V2RayZero
{
    public partial class V2Ray_ZERO : Form
    {
        public V2Ray_ZERO()
        {
            InitializeComponent();
            listTextBox.Add(txtLocalPort);
            listTextBox.Add(txtIP);
            listTextBox.Add(txtServicePort);
            listTextBox.Add(txtID);
            listTextBox.Add(txtLevel);
            listTextBox.Add(txtAlterID);
            listTextBox.Add(txtKcp);
            listTextBox.Add(txtGroup);
            listTextBox.Add(txtMark);
            Process[] processcollection = Process.GetProcessesByName("v2ray-taskbar");
            if (processcollection.Length >= 2)
            {
                MessageBox.Show("应用程序已经在运行中。。");
                this.notifyIconV2ray.Visible = false;
                Environment.Exit(1);
            }
            else
            {
                this.V2ray_Process();
            }
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        #region none
        // 运行代理程序
        void V2ray_Process()
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = "v2ray.exe";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.CreateNoWindow = true;
                p.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
                {
                    if (!String.IsNullOrEmpty(e.Data))
                    {
                        this.AppendText(e.Data + Environment.NewLine);
                    }
                });
                p.Start();
                p.BeginOutputReadLine();
            }
            catch (Exception)
            {
                MessageBox.Show("请检查当前目录下是否有 v2ray.exe 程序。。");
                this.notifyIconV2ray.Visible = false;
                Environment.Exit(0);
            }
        }

        delegate void AppendTextDelegate(string text);
        void AppendText(string text)
        {
            if (this.textBoxTaskbar.InvokeRequired)
            {
                Invoke(new AppendTextDelegate(AppendText), new object[] { text });
            }
            else
            {
                this.textBoxTaskbar.AppendText(text);
            }
        }
        static ServiceDate sd = new ServiceDate();
        List<TextBox> listTextBox = new List<TextBox>();
        // 最小化隐藏
        void V2ray_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.Visible = false;
            }
        }

        // 退出
        void Exit_Click(object sender, EventArgs e)
        {
            this.notifyIconV2ray.Visible = false;
            try
            {
                Process[] killp = Process.GetProcessesByName("v2ray");
                foreach (System.Diagnostics.Process p in killp)
                {
                    p.Kill();
                }
                Environment.Exit(0);
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }
        }


        // 重载后台程序
        void V2ray_Click(object sender, EventArgs e)
        {
            // 重载
            this.textBoxTaskbar.Clear();
            if (this.Visible == false)
            {
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
            try
            {
                Process[] killp = Process.GetProcessesByName("v2ray");
                foreach (System.Diagnostics.Process p in killp)
                {
                    p.Kill();
                }
            }
            finally
            {
                this.V2ray_Process();
            }
        }


        // 清空 textBoxV2ray 内容
        void TextBoxClear(object sender, EventArgs e)
        {
            this.textBoxTaskbar.Clear();
        }


        // 复制 textBoxV2ray 内容
        void TextBoxCopy(object sender, EventArgs e)
        {
            if (this.textBoxTaskbar.SelectedText != "")
            {
                Clipboard.SetDataObject(this.textBoxTaskbar.SelectedText);
            }
        }


        // 默认隐藏
        void V2ray_Shown(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;

        }

        #endregion

        // 窗体显示
        void notifyIconV2ray_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.Visible == false && e.Button == MouseButtons.Left)
            {
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
                this.Activate();
                this.textBoxTaskbar.SelectionStart = this.textBoxTaskbar.Text.Length;
                this.textBoxTaskbar.ScrollToCaret();
                if (!sd.BLoad)
                {
                    sd.LoadService();
                    for (int i = 0; i < sd.Count; i++)
                    {
                        lsbService.Items.Add(sd.GetServiceTag(i));
                    }

                    lsbService.SelectedIndex = 0;

                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                this.Hide();
                this.Visible = false;
            }
        }

        //按钮点击事件
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            Action<int, int> exchange = (int n1, int n2) =>
            {
                if (n1 == -1 || n2 == lsbService.Items.Count)
                {
                    return;
                }
                else
                {
                    object o = lsbService.Items[n1];
                    lsbService.Items[n1] = lsbService.Items[n2];
                    lsbService.Items[n2] = o;

                    sd.Exchange(n1, n2);
                }
            };
            if (btn.Name == "btnAdd")
            {
                List<string> list = GetParameter();
                sd.AddService(list);
                lsbService.Items.Add(listTextBox[7].Text + " > " + listTextBox[8].Text + " : " + listTextBox[2].Text);
                lsbService.SelectedIndex = lsbService.Items.Count - 1;
            }
            else if (btn.Name == "btnDel")
            {
                int no = lsbService.SelectedIndex;
                lsbService.Items.RemoveAt(no);
                sd.RemoveService(no);
            }
            else if (btn.Name == "btnUp")
            {
                int n2 = lsbService.SelectedIndex;
                int n1 = n2 - 1;
                exchange(n1, n2);
                lsbService.SelectedIndex = n1;
            }
            else if (btn.Name == "btnDown")
            {
                int n1 = lsbService.SelectedIndex;
                int n2 = n1 + 1;
                exchange(n1, n2);
                lsbService.SelectedIndex = n2;
            }
            else
            {
                sd.SaveService(lsbService.SelectedIndex, GetParameter());
                new ConfigDispose().WriteConfig(sd.GetParameter(lsbService.SelectedIndex));
                V2ray_Click(sender, e);
                lsbService.Items[lsbService.SelectedIndex] = sd.GetServiceTag(lsbService.SelectedIndex);
                Hide();
                Visible = false;
            }
        }

        private List<string> GetParameter()
        {
            List<string> list = new List<string>();
            foreach (var item in listTextBox)
            {
                list.Add(item.Text);
            }
            list.Add(chbKcp.Checked.ToString());
            return list;
        }

        //左侧服务器选中
        private void lsbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int no = lsbService.SelectedIndex;
                string group = null;
                string mark = null;
                List<string> list = sd.GetParameter(no, out group, out mark);
                if (list.Count != 0)
                {
                    list.Add(group);
                    list.Add(mark);
                    for (int i = 0; i < list.Count; i++)
                    {
                        listTextBox[i].Text = list[i];
                    }
                }
                if (txtKcp.Text == "True")
                {
                    chbKcp.Checked = true;
                }
                else
                {
                    chbKcp.Checked = false;
                }
            }
            catch
            {

            }

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.notifyIconV2ray.Visible = false;
            try
            {
                Process[] killp = Process.GetProcessesByName("v2ray");
                foreach (System.Diagnostics.Process p in killp)
                {
                    p.Kill();
                }
                Environment.Exit(0);
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }
        }

        private void chbKcp_CheckedChanged(object sender, EventArgs e)
        {
            txtKcp.Text = chbKcp.Checked.ToString();
        }


    }
}
