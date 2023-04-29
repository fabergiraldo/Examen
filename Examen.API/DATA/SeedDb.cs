using Examen.Shared.Entities;

namespace Examen.API.DATA
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckBoletosAsync();
        }

        private async Task CheckBoletosAsync()
        {
            if (!_context.boletos.Any())
            {
                for int i = 1; i <= 50000; i++ {
                    await AddBoletosAsync(i, '29/04/2023 6:00:00 a. m.', false, new List<string>() { "Norte", "Sur", "Oriental", "Ocidental" });
                }
            }

            await _context.SaveChangesAsync();
        }

        private async Task AddBoletosAsync(int  id, DateTime UseDate, Boolean Using, List<string> Entrance)
        {
            Boleto boleto = new()
            {
                Id = id,
                UseDate = UseDate,
                Using = Using,
                //Entrance = new List<Entrance>()
                
            }
            _context.boletos.Add(boleto);
        }
    }
}
