namespace ApiProjeKampi.WebApi.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public List<Product> products { get; set; } // bire çok ilişki
        // yani ürünü kategorilerin içine yazarak bir kategoriye ait birden fazla ürün olabileceğini belirmiş olduk
    }
}
