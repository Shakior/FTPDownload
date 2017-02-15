using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.IO;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class FtpDownloadForm : Form
    {
        FtpDownload ftpDownload;
        private long rest;
        private long loaded;
        private long filesize;
        private double speed;
        private bool stop = false;
        private bool downloadProcessing = false;
        string uri;

        public FtpDownloadForm()
        {
            InitializeComponent();
            ftpDownload = new FtpDownload();
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            if (downloadProcessing)
            {
                MessageBox.Show("Закачка уже идет! Подождите или омените!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                uri = textBoxAddress.Text;
                Thread thread = new Thread(download);
                thread.Start();
            }
        }

        private void download()
        {
            stop = false;
            downloadProcessing = true;
            string filename = uri.Substring(uri.LastIndexOf('/') + 1);
            try
            {
                filesize = rest = ftpDownload.getFilesize(uri);
                loaded = 0;
                setLoaded(loaded);
                progressMax((int)filesize);//если размер больше инта?
                progressValue((int)loaded);

                FtpWebRequest requestDownload = (FtpWebRequest)WebRequest.Create(uri);
                requestDownload.Method = WebRequestMethods.Ftp.DownloadFile;
                FtpWebResponse response = (FtpWebResponse)requestDownload.GetResponse();
                Stream responseStream = response.GetResponseStream();
                FileStream file = File.Create(filename);
                byte[] buffer = new byte[512 * 1024];//оптимальный размер
                int read;
                
                DateTime date = DateTime.Now;

                while (((read = responseStream.Read(buffer, 0, buffer.Length)) > 0) && (!stop))
                {
                    file.Write(buffer, 0, read);
                    TimeSpan diff = DateTime.Now - date;
                    rest -= read;
                    loaded += read;
                    speed = (loaded / diff.TotalSeconds);

                    progressSum(read);
                    setLoaded(loaded);
                    setSpeed((int)(speed / 1024));//Kbs
                    setRest((int)(rest / speed));
                }
                file.Close();
                responseStream.Close();
                response.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка загрузки файла!");
                downloadProcessing = false;
                return;
            }

            downloadProcessing = false;

            if ((filesize != loaded) && (stop))
            {
                File.Delete(filename);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            stop = true;
        }

        private void progressSum(int sum)
        {
            if (progressBarDownload.InvokeRequired)
            {
                progressBarDownload.Invoke(new Action<int>((s) => progressBarDownload.Value += s), sum);
            }
            else
            {
                progressBarDownload.Value += sum;
            }
        }

        private void progressValue(int value)
        {
            if (progressBarDownload.InvokeRequired)
            {
                progressBarDownload.Invoke(new Action<int>((s) => progressBarDownload.Value = s), value);
            }
            else
            {
                progressBarDownload.Value = value;
            }
        }

        private void progressMax(int max)
        {
            if (progressBarDownload.InvokeRequired)
            {
                progressBarDownload.Invoke(new Action<int>((s) => progressBarDownload.Maximum = s), max);
            }
            else
            {
                progressBarDownload.Maximum = max;
            }
        }

        private void setSpeed(double speed)
        {
            if (textBoxSpeed.InvokeRequired)
            {
                textBoxSpeed.Invoke(new Action<string>((s) => textBoxSpeed.Text = s), speed.ToString());
                textBoxSpeed.Invoke(new Action<string>((s) => textBoxSpeed.Refresh()), speed.ToString());
            }
            else
            {
                textBoxSpeed.Text = speed.ToString();
                textBoxSpeed.Refresh();
            }
        }

        private void setRest(double rest)
        {
            if (textBoxRest.InvokeRequired)
            {
                textBoxRest.Invoke(new Action<string>((s) => textBoxRest.Text = s), rest.ToString());
                textBoxRest.Invoke(new Action<string>((s) => textBoxRest.Refresh()), rest.ToString());
            }
            else
            {
                textBoxRest.Text = rest.ToString();
                textBoxRest.Refresh();
            }
        }

        private void setLoaded(long loaded)
        {
            if (textBoxLoaded.InvokeRequired)
            {
                textBoxLoaded.Invoke(new Action<string>((s) => textBoxLoaded.Text = s), loaded.ToString());
                textBoxLoaded.Invoke(new Action<string>((s) => textBoxLoaded.Refresh()), loaded.ToString());
            }
            else
            {
                textBoxLoaded.Text = loaded.ToString();
                textBoxLoaded.Refresh();
            }
        }
    }
}
