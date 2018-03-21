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
        public static string ElementCss { get { return "span._1XOdkjz"; } }

        //Invest Smart
        public static string ISLogInLink { get { return "div.tool-hold.hidden-sm-down.float-right > a"; } }
        public static string ISLogInButton { get { return "input[type='submit']"; } }
        public static string ISUsernameCss { get { return "#Email"; } }
        public static string ISPasswordCss { get { return "#Password"; } }
        public static string ISElementCss { get { return "div.text > a[title='Log Off']"; } }
        public static string ISLoginError { get { return "span.field-validation-error"; } }

        //Invest Smart - Invest With us page

        public static string IWSInvestWithUsLink { get { return "#menu > li:nth-child(5) > a"; } }
        //public static string IWSStrategyDropDown { get { return "#ourfunds > section > div > div.model-filter-options.ng-scope > div > div > div:nth-child(1) > div > div.dropdown.show > button"; } }
        //public static string IWSTypeDropDown { get { return "#ourfunds > section > div > div.model-filter-options.ng-scope > div > div > div:nth-child(2) > div > div.dropdown > button"; } }
        //public static string IWSStyleDropDown { get { return "#ourfunds > section > div > div.model-filter-options.ng-scope > div > div > div:nth-child(3) > div > div.dropdown > button"; } }
        public static string IWSStrategyDropDown { get { return "#ourfunds > section > div > div.model-filter-options.ng-scope > div > div > div:nth-child(1) > div > div.dropdown.show > div > a:nth-child(4)"; } }
        public static string IWSTypeDropDown { get { return "#ourfunds > section > div > div.model-filter-options.ng-scope > div > div > div:nth-child(2) > div > div.dropdown.show > div > a:nth-child(2)"; } }
        public static string IWSStyleDropDown { get { return "#ourfunds > section > div > div.model-filter-options.ng-scope > div > div > div:nth-child(3) > div > div.dropdown.show > div > a:nth-child(2)"; } }
        public static string IWSErrorDesc { get { return "div.no-results-container > h2";} }

        //Invest Smart Shares page
        public static string SPSharesLink { get { return "#menu > li:nth-child(4) > div > div > div > div > div:nth-child(2) > div.slide-nav > div > ul > li:nth-child(1) > a"; } }
        public static string SPDropdownCss { get { return "#SectorID"; } }
        public static string SPFindSharesButton { get { return "input.btn.btn-primary.triggerSpinner"; } }

    }
    

        
}

