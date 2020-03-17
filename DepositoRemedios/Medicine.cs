using System;
using System.Collections.Generic;
using System.Text;

namespace DepositoRemedios
{
    class Medicine
    {
        public string Name { get;  set; }
        public double Price {get; set;}
        public int Quant { get; set;}


        //constructor

        public Medicine()
        {
  
        }

        public Medicine(string nameMed, double priceMed, int quantMed)
        {
            Name = nameMed;
            Price = priceMed;
            Quant = quantMed;
        }

        
    }
}
