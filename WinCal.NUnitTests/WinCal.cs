using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinCal.NUnitTests
{
    class WinCal : BaseAutoIT
    {
        static string APPLICATION_TITLE = "Cascade Microtech WinCal XE 4.8";
        static string APPLICATION = "C:/software/cmicro/4.8.56/SysBin/WinCal.exe";

        public WinCal()
        {
            Initialize();
        }

        private void Initialize()
        {
            base.application_title = WinCal.APPLICATION_TITLE;
            base.application = WinCal.APPLICATION;
            base.Open();
        }

        public int IsApplicationOpen()
        {
            int result = 0;

            result = autoIT.WinActive(base.application_title);

            return result;
        }
    }
}
