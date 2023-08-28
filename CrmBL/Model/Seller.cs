﻿

namespace CrmBL.Model
{
   public class Seller
    {
        public int SellerId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Cheque> Cheques { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
