using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class CashDesk
    {
        CrmContext db = new CrmContext();
        public int Number { get; set; }
        public Seller Seller { get; set; }
        public Queue<Cart> CustomersQueue { get; set; }

        public int MaxQueueLength { get; set; }
        public int ExitCustomer { get; set; }
        public bool IsModel { get; set; }
        public CashDesk(int number, Seller seller)
        {
            Number = number;
            Seller = seller;
            CustomersQueue = new Queue<Cart>();
            IsModel = true;
        }

        public void Enqueue(Cart cart)
        {
            if (CustomersQueue.Count <= MaxQueueLength)
            {
                CustomersQueue.Enqueue(cart);
            }
            else
            {
                ExitCustomer++;
            }
        }
        public decimal Dequeue()
        {
            decimal summ = 0;
           

                var customerFromQueue = CustomersQueue.Dequeue();
                if (customerFromQueue != null)
                {

                    var cheque = new Cheque()
                    {
                        SellerId = Seller.SellerId,
                        Seller = Seller,
                        CustomerId = customerFromQueue.Customer.CustomerId,
                        Customer = customerFromQueue.Customer,
                        DateOfCreation = DateTime.Now

                    };
                    if (!IsModel)
                    {
                        db.Cheques.Add(cheque);
                        db.SaveChanges();
                    }
                    else
                    {
                        cheque.ChequeId = 0;
                    }
                    var sells = new List<Sell>();
                    foreach (Product product in customerFromQueue)
                    {
                        if (product.Count > 0)
                        {
                            var sell = new Sell()
                            {
                                ChequeId = cheque.ChequeId,
                                Cheque = cheque,
                                ProductId = product.ProductId,
                                Product = product
                            };
                            sells.Add(sell);
                            if (!IsModel)
                            {
                                db.Sells.Add(sell);

                            }
                            product.Count--;

                            if (!IsModel)
                            {
                                db.SaveChanges();
                            }
                        summ += product.Price;
                        }
                    }
                }
            
            
            return summ;
        }
    }
}
