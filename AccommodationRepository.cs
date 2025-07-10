using LadysmithProperties.Model;

namespace LadysmithProperties.Data
{
    public class AccommodationRepository : IAccommodationRepository
    {
        private readonly AppDbContext _appDbContext;

        public AccommodationRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Accommodation> Accommodations
        {
            get
            {
                return _appDbContext.Accommodations;
            }
        }

        public Accommodation GetAccommodationById(int id)
        {
            return _appDbContext.Accommodations.FirstOrDefault(a=> a.AccommodationId == id);
        }
    }
}
