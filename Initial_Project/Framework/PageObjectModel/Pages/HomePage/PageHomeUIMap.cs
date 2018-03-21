using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISFramework.PageObjectModel.Pages
{
    public class PageHomeUIMap : UIMap
    {
        public string NavItemsCss { get { return "a.opener-nav"; } }
        public string PrimaryButtonsCss { get { return "a.btn.btn-primary"; } }
        public string SecondaryButtonsCss { get { return "a.btn.btn-secondary-inverted"; } }
    }
}
