using ShelterReport1.Model;
using System.Text.Json;

namespace ShelterReport1.Repository
{
    public class MonkeyRepository : IMonkeyRepository
    {
        private IHostEnvironment _hostEnvironment;

        public IConfiguration _configuration { get; }

        public MonkeyRepository(IConfiguration configuration, IHostEnvironment hostEnvironment)
        {
            _configuration = configuration;
            _hostEnvironment = hostEnvironment;
        }
        public IEnumerable<SpeciesReport> GetSpeciesReport()
        {
            var monkeyList = GetMonkeys();
            var speciesList = monkeyList.Select(x => x.Species).Distinct().ToList();
            IList<SpeciesReport> speciesReportList = new List<SpeciesReport>();
            foreach (var species in speciesList)
            {
                SpeciesReport speciesReport = new SpeciesReport();
                speciesReport.Species = species;
                speciesReport.Count = monkeyList.Where(x => x.Species == species).Count();
                speciesReportList.Add(speciesReport);
            }
            return speciesReportList;
        }

        private IEnumerable<Monkey> GetMonkeys()
        {
            var rootPath = _hostEnvironment.ContentRootPath;
            string jsonFile = Path.Combine(rootPath, _configuration.GetSection("JsonFilePath").Value);
            string jsonString = File.ReadAllText(jsonFile);
            var monkeyList = JsonSerializer.Deserialize<IEnumerable<Monkey>>(jsonString)!;
            return monkeyList;
        }

         
    }
}
