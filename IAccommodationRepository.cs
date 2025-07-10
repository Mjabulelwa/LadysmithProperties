using LadysmithProperties.Model;

namespace LadysmithProperties.Data
{
    public interface IAccommodationRepository
    {
        IEnumerable<Accommodation> Accommodations { get; }
        Accommodation GetAccommodationById(int id);
    }
}
