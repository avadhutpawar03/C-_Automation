using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ShoppingCartProject
{
    public class Item
    {
        public int FieldId;
        public string desc;
        public int Quantity;
        public double Price;

        public void PrintItemDetails()
        {
            Console.WriteLine("Field ID:" + FieldId);
            Console.WriteLine("Description:" + desc);
            Console.WriteLine("Quantity:" + Quantity);
            Console.WriteLine("Price:" + Price);
            Console.WriteLine("*********************************************************");

        }
        public void PrintDiscountPrice()
        {

            if (Quantity == 2)
            {
                double Price1 = (Price - (Price * 10 / 100)) * Quantity;
                Console.WriteLine(Price1);

            }
            else if (Quantity >= 3 && Quantity < 5)
            {
                double Price1 = (Price - (Price * 15 / 100)) * Quantity;
                Console.WriteLine(Price1);

            }
            else if (Quantity >= 5)
            {
                double price1 = (Price - (Price * 25 / 100)) * Quantity;
                Console.WriteLine(price1);
            }


        }

            }
        }
    
