using MVC_Tip.Model;
using MVC_Tip.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Tip.Controler
{
    internal class Tipcontroler
    {
        private Tip tip = new Tip();
        private Display display = new Display();

        public Tipcontroler()
        {
            display.Input();

            tip.Amount = display.Amount;
            tip.Percent = display.Percent;

            display.TipAmount=tip.CalculateTip();
            display.Total=tip.CalculateTotal();

            display.Output();

        }
    }
}
