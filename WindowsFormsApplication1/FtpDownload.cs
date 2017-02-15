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
    public class FtpDownload
    {
        public long getFilesize(string uri)
        {
            FtpWebRequest requestFileSize = (FtpWebRequest)WebRequest.Create(uri);
            requestFileSize.Method = WebRequestMethods.Ftp.GetFileSize;
            var q = (FtpWebResponse)requestFileSize.GetResponse();
            return q.ContentLength;
        }
    }
}
