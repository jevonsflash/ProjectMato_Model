using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMato.Model.Interface
{
    public interface IHttpHelper
    {
        Task<string> GetWebAsync(string url, Encoding e = null);
        string PostWeb(string url, string data);
        Task HttpDownloadFileAsync(string url, string path);
        void SetHeaderValue(WebHeaderCollection header, string name, string value);
        Task<string> GetWebDatacAsync(string url, Encoding c);
        Task<string> GetWebDatadAsync(string url, Encoding c);
        Boolean IsNetworkTrue();
    }

}
