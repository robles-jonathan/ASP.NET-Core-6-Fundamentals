using Microsoft.EntityFrameworkCore;

namespace ChristinasPieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly ChristinasPieShopDbContext _christinasPieShopDbContext;

        public PieRepository(ChristinasPieShopDbContext christinasPieShopContext)
        {
            _christinasPieShopDbContext = christinasPieShopContext;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _christinasPieShopDbContext.Pies.Include(c => c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _christinasPieShopDbContext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);
            }
        }

        public Pie? GetPieById(int pieId)
        {
            return _christinasPieShopDbContext.Pies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
