using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_4_IrynaKyman
{
    class DeskQuote
    {
        #region member variables
        //A desk quote description
        private string CustomerName;
        private DateTime QuoteDate;
        private Desk Desk = new Desk();
        private int RushDays;


        #endregion
        #region constants

        private const int PRICE_BASE = 200;
        #endregion

        public DeskQuote(int width, int depth, int drawers, string material, int rushDays)
        {
            Desk.Width = width;
            Desk.Depth = depth;
            Desk.NumberOfDrawers = drawers;
            this.RushDays = rushDays;
        }

        public int CalculateQuoteTotal()
        {
            return PRICE_BASE;
        }

        //private int SurfaceAreaCost()
        //{
       
      //  }

        //private int DrawerCost()
        //{

        //}
    }
}
