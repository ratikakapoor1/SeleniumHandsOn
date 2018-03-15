using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    public class SearchSelectors
    {
          public static string InputSearchBox { get { return "input[name = 'q']"; } }
          public static string SearchButton { get { return "input[name='btnK']"; } }

        //Jabong website selectors
        public static string JabongNewClothingWomen { get { return "#mainTopNav > li.nav-women > div > div.dropdown-container.row > div:nth-child(1) > a:nth-child(2)"; } }

        //seek
        public static string SignInLink { get { return "div._3QLrnJD a[title ='Sign in']"; } }
        public static string SignInButton { get { return "div.__STYLE_GUIDE__Button__group___lCBgyH8 button"; }}
        public static string UsernameCss { get { return "#email"; }  }
        public static string PasswordCss { get { return "#password"; } }
        public static string ElementCss { get { return "span._1XOdkjz"; }}
    }
}
