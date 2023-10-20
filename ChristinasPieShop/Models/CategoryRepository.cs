namespace ChristinasPieShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ChristinasPieShopDbContext _christinasPieShopDbContext;
        public CategoryRepository(ChristinasPieShopDbContext christinasPieShopDbContext)
        {
            _christinasPieShopDbContext = christinasPieShopDbContext;
        }

        public IEnumerable<Category> AllCategories => _christinasPieShopDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}
