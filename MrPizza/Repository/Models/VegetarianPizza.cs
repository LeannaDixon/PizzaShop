namespace MrPizza.Repository.Models
{
    public class VegetarianPizza : Pizza
    {
        public VegetarianPizza()
        {
            Toppings.Add("Peppers");
            Toppings.Add("Mushrooms");
        }
    }
}