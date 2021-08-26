using System;

namespace OptionalParameters
{
    class Program
    {
        public static string OrderDetails(string SellerName, string ProductName, int OrderQuantity = 1, bool IsReturnable = true)
        {
            return $"Here is the order detail – {OrderQuantity} number of {ProductName} by {SellerName} is ordered. It’s returnable status is {IsReturnable}";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(OrderDetails("OnePlus", "OnePlus Buds Z"));
            Console.WriteLine(OrderDetails("OnePlus", "OnePlus Buds Z", 2, false));
            Console.WriteLine(OrderDetails("OnePlus", "OnePlus Buds Z", 3));
        }
    }
}
