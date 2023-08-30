

namespace CrmBL.Model
{
public class Cheque
    {
        public int ChequeId { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        public int SellerId { get; set; }
        public virtual Seller Seller { get; set; }
        public virtual ICollection<Sell> Sells { get; set; }

        public DateTime DateOfCreation { get; set; }
        public decimal TotalSumm { get; set; }

        public override string ToString()
        {
            return $"№{ChequeId} от {DateOfCreation.ToString("dd.MM.yy hh:mm:ss")}";
        }
    }
}
