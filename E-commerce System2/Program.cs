using E_commerce_System2;

internal class Program
{
    private static void Main(string[] args)
    {
        //Cart cart = new Cart();


        //ProductsService productsService = new ProductsService();

        //productsService.ReturnProduct("Sare");

        Cart cart = new Cart();

        //cart.CheckOut();

        //cart.AddToCart();

        cart.ViewOrderHistory(2);
    }
}