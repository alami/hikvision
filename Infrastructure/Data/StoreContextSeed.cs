using Microsoft.Extensions.Logging;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Core.Entities;

namespace Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if(!context.Resolutions.Any())
                {
                    var resolutionData = File.ReadAllText("../Infrastructure/Data/SeedData/resolutions.json");
                    var resolutions = JsonSerializer.Deserialize<List<Resolution>>(resolutionData);
                    foreach (var resolution in resolutions)
                    {
                        context.Resolutions.Add(resolution);
                    }
                    context.SaveChangesAsync();
                }
                if (!context.Periods.Any())
                {
                    var periodData = File.ReadAllText("../Infrastructure/Data/SeedData/periods.json");
                    var periods = JsonSerializer.Deserialize<List<Period>>(periodData);
                    foreach (var period in periods)
                    {
                        context.Periods.Add(period);
                    }
                    context.SaveChangesAsync();
                }

                if (!context.Tariffs.Any())
                {
                    var tariffData = File.ReadAllText("../Infrastructure/Data/SeedData/tariffs.json");
                    var tariffs = JsonSerializer.Deserialize<List<Tariff>>(tariffData);
                    foreach (var tariff in tariffs)
                    {
                        context.Tariffs.Add(tariff);
                    }
                    context.SaveChangesAsync();
                }

            }
            catch (Exception ex) {
                var logger = loggerFactory.CreateLogger<StoreContextSeed>();
                logger.LogError(ex.Message);
            }
        }
    }
}
