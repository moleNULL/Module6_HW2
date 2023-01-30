namespace MicroserviceWebAPIToDocker.Models
{
    public class GameProduct
    {
        public GameProduct(string title, int year, decimal price, string developer)
        {
            Title = title;
            Year = year;
            Price = price;
            Developer = developer;
        }

        public string? Title { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string? Developer { get; set; }
    }
}
