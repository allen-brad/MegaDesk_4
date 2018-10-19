using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_BradRAllen
{
    public class DeskQoute
    {
        //parts of the desk quote i.e. the desk quote model
        public string CustomerName { get; set; }
        public DateTime Quotedate { get; set; }   
        public int RushDays { get; set; }
        public Desk Desk = new Desk();
        public int QuoteTotal { get; set; }

        private int SurfaceArea = 0;

        private const int BASE_PRICE = 200;
        private const int DRAWER_UNIT_PRICE = 50;
        private const int SQUARE_INCH_THRESHOLD = 1000;
        private const int SQUARE_INCH_FEE = 1;

        public DeskQoute(string customerName, DateTime quoteDate, int width, int depth, int drawers, SurfaceMaterial material, int rushDays)
        {
            CustomerName = customerName;
            Quotedate = quoteDate;
            Desk.Width = width;
            Desk.Depth = depth;
            Desk.NumOfDrawers = drawers;
            Desk.SurfaceMaterial = material;
            RushDays = rushDays;

            SurfaceArea = Desk.Width * Desk.Depth;

            this.QuoteTotal = CalculateQuoteTotal(SurfaceArea, drawers, material,RushDays);
        }

        public int SurfaceAreaFee (int SurfaceArea)
        {
            if (SurfaceArea > SQUARE_INCH_THRESHOLD)
                {
                return (SurfaceArea - SQUARE_INCH_THRESHOLD) * SQUARE_INCH_FEE;
                }
            else
            {
                return 0;
            }
        }

        public int DrawerFee (int drawers)
        {
            return drawers * DRAWER_UNIT_PRICE;
        }

        public int RushFee (int days, int surfacearea)
        {
            switch (days)
            {
                case 3:
                    if (surfacearea < 1000)
                    {
                        return 60;
                    }
                    if (surfacearea >=1000 && surfacearea <=2000)
                    {
                        return 70;

                    }
                    if (surfacearea >2000)
                    {
                        return 80;
                    }
                    break;
                case 5:
                    if (surfacearea < 1000)
                    {
                        return 40;
                    }
                    if (surfacearea >= 1000 && surfacearea <= 2000)
                    {
                        return 50;

                    }
                    if (surfacearea > 2000)
                    {
                        return 60;
                    }
                    break;
                case 7:
                    if (surfacearea < 1000)
                    {
                        return 30;
                    }
                    if (surfacearea >= 1000 && surfacearea <= 2000)
                    {
                        return 35;

                    }
                    if (surfacearea > 2000)
                    {
                        return 40;
                    }
                    break;
                default:
                    return 0;
            }
            return 0;
        }

        public int CalculateQuoteTotal(int surfacearea, int drawers, SurfaceMaterial material, int rushDays)
        {
            QuoteTotal = BASE_PRICE + SurfaceAreaFee(surfacearea) + DrawerFee(drawers) + (int)material + RushFee(rushDays,surfacearea);
            return QuoteTotal;
            //(number of drawers * DrawerPrice) + surfacematerial + RushFee
        }
    }
}
