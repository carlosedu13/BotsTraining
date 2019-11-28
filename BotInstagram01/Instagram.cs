using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using HtmlAgilityPack;

namespace BotInstagram01
{
    public static class Instagram
    {
        public static Profile GetProfileByUser(string username)
        {
            Profile profile = new Profile(username);
            string url = $@"https://www.instagram.com/{username}/";
            string pageHtml;

            using (WebClient webClient = new WebClient())
            {
                pageHtml = webClient.DownloadString(url);
            }

            HtmlDocument html = new HtmlDocument();
            html.LoadHtml(pageHtml);

            var list = html.DocumentNode.SelectNodes("//meta");

            return profile;
        }
    }
}
