

namespace CrmBL.Model
{
   public class Sell
    {
        public int SellId { get; set; }
        public int ChequeId { get; set; }
        public int ProductId { get; set; }

        public virtual Cheque Cheque { get; set; }
        public virtual Product Product { get; set; }
    }
}
