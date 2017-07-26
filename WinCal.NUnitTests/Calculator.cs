using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinCal.NUnitTests
{
    class Calculator : BaseAutoIT
    {
        private static string APPLICATION_TITLE = "Calculator";
        private static string APPLICATION = "calc.exe";

        private static Dictionary<int, string> calcNumPad_ObjectRepository;
        private static Dictionary<string, string> calcOperPad_ObjectRepository;

        public Calculator() 
        {
            Initialize();
        }

        private void Initialize()
        {
            base.application_title = Calculator.APPLICATION_TITLE;
            base.application = Calculator.APPLICATION;
            if ( Calculator.calcNumPad_ObjectRepository == null )
            {
                InitNumberPad();
            }
            if (Calculator.calcOperPad_ObjectRepository == null)
            {
                InitOperationPad();
            }
            
        }

        private void InitNumberPad()
        {
            //Object Repository for Calculator Numbers
            Calculator.calcNumPad_ObjectRepository = new Dictionary<int, string>();
            Calculator.calcNumPad_ObjectRepository.Add(0, "130");
            Calculator.calcNumPad_ObjectRepository.Add(1, "131");
            Calculator.calcNumPad_ObjectRepository.Add(2, "132");
            Calculator.calcNumPad_ObjectRepository.Add(3, "133");
            Calculator.calcNumPad_ObjectRepository.Add(4, "134");
            Calculator.calcNumPad_ObjectRepository.Add(5, "135");
            Calculator.calcNumPad_ObjectRepository.Add(6, "136");
            Calculator.calcNumPad_ObjectRepository.Add(7, "137");
            Calculator.calcNumPad_ObjectRepository.Add(8, "138");
            Calculator.calcNumPad_ObjectRepository.Add(9, "139");
        }

        private void InitOperationPad()
        {
            //Object Repository for Calculator Operators
            Calculator.calcOperPad_ObjectRepository = new Dictionary<string, string>();
            Calculator.calcOperPad_ObjectRepository.Add("+", "93");
            Calculator.calcOperPad_ObjectRepository.Add("-", "94");
            Calculator.calcOperPad_ObjectRepository.Add("*", "92");
            Calculator.calcOperPad_ObjectRepository.Add("/", "91");
            Calculator.calcOperPad_ObjectRepository.Add("=", "121");
            Calculator.calcOperPad_ObjectRepository.Add("clear", "81");
        }

        public int Add(int add1, int add2)
        {
            int result = 0;
            ClickNumber(add1);
            PerformOperation("+");
            ClickNumber(add2);
            PerformOperation("=");

            result = Convert.ToInt32(CalcValue());
            return result;
        }

        private void ClickNumber(int number)
        {
            Char[] sNumber = number.ToString().ToArray();
            string buttonID;
            for (int i = 0; i < sNumber.Length; i++)
            {
                buttonID = Calculator.calcNumPad_ObjectRepository[int.Parse(sNumber[i].ToString())];
                base.autoIT.ControlClick(base.application_title, "", buttonID);
            }
        }

        //Perform operations.
        private void PerformOperation(string operation)
        {
            string buttonID = Calculator.calcOperPad_ObjectRepository[operation];
            base.autoIT.ControlClick(base.application_title, "", buttonID);

        }
        private string CalcValue()
        {
            string result = base.autoIT.WinGetText(base.application_title);
            return result.Trim();
        }

        public void ShowAboutBox()
        {
            base.autoIT.WinMenuSelectItem(base.application_title,"About","","About Calculator");
        }
    }
}
