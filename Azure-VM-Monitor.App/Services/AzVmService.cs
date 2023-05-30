using System.Globalization;
using AzureVMMonitor.App.Models;
using CsvHelper;

namespace AzureVMMonitor.App.Services;

public interface IAzVmService
{
    Task<IEnumerable<VmStatus>> FetchStatus();
}

public class AzVmService : IAzVmService
{
    private HttpClient _httpClient { get; init; }

    public AzVmService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<VmStatus>> FetchStatus()
    {
        var url = "sample-data/All-VM-Status.csv"; //"sample-data/weather.json"
        var csvData = await _httpClient.GetStringAsync(url);
        var csvRecords = new List<VmStatus>();
        using (var reader = new StringReader(csvData))
        {
            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            csvRecords = csv.GetRecords<VmStatus>().ToList();
        }

        return csvRecords;
    }
}