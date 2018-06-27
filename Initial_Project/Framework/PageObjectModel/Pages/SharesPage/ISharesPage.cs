using ISFramework.PageObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISFramework.Pages
{
    public interface ISharesPage : IWebComponent
    {
        void FindAndClickLink();
        void EnterVal(String val);
        bool VerifyResult();



    }
}
