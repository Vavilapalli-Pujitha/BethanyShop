namespace BethanyWorkShop.Models
{
    public interface ICategoryRepository
    {
        //auto implemented properties
        IEnumerable<Category> AllCategories { get; }

    }
}
