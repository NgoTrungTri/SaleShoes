using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleShoes
{
   public class spmua
    {
        public int masp { get; set; }
        public int soluong { get; set; }
        public float TongTien { get; set; }
        //public  double Giam { get; set; }
        public spmua(int id, int sl, float price)
        {
            masp = id;
            soluong = sl;
            //Giam = giam;
           TongTien = price /** (decimal)giam */*(float)sl;
        }
    }
}
