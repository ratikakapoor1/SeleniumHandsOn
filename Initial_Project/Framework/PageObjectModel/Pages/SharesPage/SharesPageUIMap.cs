using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISFramework.PageObjectModel.Pages
{
    public class SharesPageUIMap : UIMap
    {
        public string SPSharesLink { get { return "#menu > li:nth-child(4) > div > div > div > div > div:nth-child(2) > div.slide-nav > div > ul > li:nth-child(1) > a"; } }
        public string SPDropdownCss { get { return "#SectorID"; } }
        public string SPFindSharesButton { get { return "input.btn.btn-primary.triggerSpinner"; } }
        public string SPTableCss { get { return "div.table-responsive > table > tbody > tr"; } }
        public string SPTableColumnCss { get { return "div.table-responsive > table > tbody > tr:nth-child({0}) > td:nth-child(3)"; }  }
    }
}
