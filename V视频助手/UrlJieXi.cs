using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SufeiUtil;

namespace V视频助手
{
    class UrlJieXi
    {

        #region 定义变量


        HttpHelper _http;

        #endregion


        #region 事件




        #endregion




        public void Start()
        {

        }
               

        //获取网页标题函数
        public String getWebTitle(String url)
        {
            _http = new HttpHelper();
            HttpItem item = new HttpItem()
            {
                URL = url,
                ResultType = ResultType.String,
                Allowautoredirect=true
                
            };

            try
            {

                HttpResult result = _http.GetHtml(item);

                //建立获取网页标题正则表达式
                Regex reg = new Regex(@"<title>(?<title>.+)</title>");
                //String regex = @"<title>(.+)</title>";
                //匹配
                Match match = reg.Match(result.Html);
                if (!match.Success)
                {
                    return "无法获取标题";
                }

                //返回网页标题
                //String title = Regex.Match(result.Html, regex).ToString();
                //title = Regex.Replace(title, @"[\""]+", "");
                string title = match.Groups["title"].Value;
                _http = null;
                item = null;
                result = null;
                return title;
            }
            catch (Exception ex)
            {
                return ex.Message;
                //throw;
            }

        }


    }
}
