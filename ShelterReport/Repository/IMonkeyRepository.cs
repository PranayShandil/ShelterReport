using ShelterReport1.Model;

namespace ShelterReport1.Repository
{
    public interface IMonkeyRepository
    {
        public IEnumerable<SpeciesReport> GetSpeciesReport();
        //public IEnumerable<Monkey> GetMonkeys();

    }
}
