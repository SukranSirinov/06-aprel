using System;
using System.Collections.Generic;
using System.Text;

namespace _04062022
{
    internal class Shop
    {
        List<Order>Orders=new List<Order>();
        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
        public double GetOrdersAvg()
        {
            double total=0;
            foreach (var item in Orders)
            {
                total += item.TotalAmout;
            }
            total /= Orders.Count ;
            return total;
        }
        public double GetOrdersAvg(DateTime date)
        {
            double total = 0;
            var result=Orders.FindAll(x=>x.CreatedAt>=date);
            foreach (var item in result)
            {
                total += item.TotalAmout;
            }
            total/=result.Count ;
            return total;
        }
        public List<Order> FilterOrderByPrice(int minPrice,int maxPrice)
        {
            Orders.FindAll(x => x.TotalAmout > minPrice && x.TotalAmout < maxPrice);
               return Orders;   
        }
        public void RemoveOrderByNo(string no)
        {
            if (!string.IsNullOrWhiteSpace(no))
            {
                throw new NullReferenceException("Null dir");

            }
            var result =Orders.Find(x =>x.No==no);
            if (no == null)
            {
                throw new NullReferenceException("Null daxil edilib");
            }
            Orders.Remove(result);
        }

    }
}
