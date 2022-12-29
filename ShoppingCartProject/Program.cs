namespace ShoppingCartProject
{
    public class ShoppingCart
    {
        static void Main(string[] args)
        {
            Item item1= new Item();
            Item item2 = new Item();
            Item item3 = new Item();

            item1.FieldId = 101;
            item1.desc = "laptop";
            item1.Quantity = 5;
            item1.Price = 45000;


            item2.FieldId = 102;
            item2.desc = "mobile";
            item2.Quantity = 4;
            item2.Price = 15000;

            item3.FieldId = 103;
            item3.desc = "watch";
            item3.Quantity = 2;
            item3.Price = 2500;

            item1.PrintItemDetails();
            item2.PrintItemDetails();
            item3.PrintItemDetails();
            item1.PrintDiscountPrice();
            item2.PrintDiscountPrice();
            item3.PrintDiscountPrice();


            //

        }
    }
}