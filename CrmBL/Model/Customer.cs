

namespace CrmBL.Model
{
   public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Cheque> Cheques { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
