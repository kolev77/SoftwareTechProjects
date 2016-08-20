using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MY_DEMO_BLOG.Classes
{
    public class Utils
    {
        public static string CutText(string text, int maxLength = 100)
        {
            if (text == null || text.Length <= maxLength)
            {
                return text;
            }
            var shortText = text.Substring(0, maxLength - 3) + "...";
            return shortText;
        }
    }
}