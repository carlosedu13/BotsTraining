using System;
using System.Collections.Generic;
using System.Text;

namespace BotInstagram01
{
    public class Profile
    {
        public Profile(string username)
        {
            username = username;
        }

        public string username { get; set; }
        public string IosAppName { get; set; }
        public string IosAppId { get; set; }
        public string IosUrl { get; set; }
        public string AndroidAppName { get; set; }
        public string AndroidAppId { get; set; }
        public string AndroidUrl { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
    }
}
