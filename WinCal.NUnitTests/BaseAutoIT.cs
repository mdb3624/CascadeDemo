using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinCal.NUnitTests
{
    class BaseAutoIT
    {

        protected string application_title { get; set; }
        protected string application { get; set; }

        protected AutoItX3Lib.AutoItX3 autoIT = new AutoItX3Lib.AutoItX3();

        protected BaseAutoIT() { }

        public void Open()
        {
            autoIT.Run(application);
            autoIT.WinActivate(application_title);
            autoIT.WinWaitActive(application_title);
        }

        public void Close()
        {
            autoIT.WinClose(application_title);
        }

    }
}
