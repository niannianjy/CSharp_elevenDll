using System.Text;
using System.Net;
using System.IO;

namespace elevendll
{
    public class Neteasy
    {
        #region 获取IP地址
        /// <summary>
        /// 利用IP138获取ID
        /// </summary>
        /// <returns>成功返回IP。失败返回false</returns>
        public static string GetIP()
        {
            string tempip = "";
            try
            {
                WebRequest wr = WebRequest.Create("http://www.ip138.com/ips138.asp");
                Stream s = wr.GetResponse().GetResponseStream();
                StreamReader sr = new StreamReader(s, Encoding.Default);
                string all = sr.ReadToEnd(); //读取网站的数据
                int start = all.IndexOf("您的IP地址是：[") + 9;
                int end = all.IndexOf("]", start);
                tempip = all.Substring(start, end - start);
                sr.Close();
                s.Close();
            }
            catch
            {
                return "false";
            }
            return tempip;
        }
        #endregion

        public string GetDNS()
        {
            
            return "";
        }

        
    }

    public class StringEx
    {
        /// <summary>
        /// 根据左右文本取中间文本
        /// </summary>
        /// <param name="str">原文本</param>
        /// <param name="left">文本左边</param>
        /// <param name="right">文本右边</param>
        /// <returns>返回取到的文本</returns>
        public string Between(string str, string left, string right)
        {
            return "";
        }
    }
    
}