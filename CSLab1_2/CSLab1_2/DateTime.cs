using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab1_2
{
    abstract class Printer
    {
        public abstract string Print();
    }

    class EUPrinter : Printer
    {
        public override string Print()
        {
            DateTime ddT = DateTime.Now;
            CultureInfo cultureInfo = new CultureInfo("en-GB");
            return ddT.ToString(cultureInfo);
        }
    }

    class USPrinter : Printer
    {
        public override string Print()
        {
            DateTime ddT = DateTime.Now;
            CultureInfo cultureInfo = new CultureInfo("en-US");
            return ddT.ToString(cultureInfo);
        }
    }


    // Decorating
    abstract class Decorator : Printer
    {
        protected Printer printer;

        public Decorator(Printer printer)
        {
            this.printer = printer;
        }

        public override string Print()
        {
            string ddT_looks = printer.Print();
            return DecorateDateTime(ddT_looks);
        }

        protected abstract string DecorateDateTime(string ddT);
    }

    // Init deco 
    class PreDecorator : Decorator
    {
        private string before;  //перед ддт

        public PreDecorator(Printer printer, string before) : base(printer)
        {
            this.before = before;
        }

        protected override string DecorateDateTime(string ddT)
        {
            return before + ddT;
        }
    }

    // To the string's end
    class PostDecorator : Decorator
    {
        private string after;

        public PostDecorator(Printer printer, string after) : base(printer)
        {
            this.after = after;
        }

        protected override string DecorateDateTime(string ddT)
        {
            return ddT + after;
        }
    }
}
