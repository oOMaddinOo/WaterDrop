using Newtonsoft.Json;
using WaterDrop.Components.Models;

namespace WaterDrop.Components.Services
{
	public class kloService
	{
		private static readonly HttpClient _httpClient = new HttpClient();

		public async Task<OverpassResponse> GetAllToilets()
		{
			var url = "https://overpass-api.de/api/interpreter";

			var query = @"[out:json][timeout:25];
						area[""name""=""Hamburg""][""boundary""=""administrative""]->.searchArea;
						(
						  node[""amenity""=""toilets""](area.searchArea);
						  way[""amenity""=""toilets""](area.searchArea);
						  relation[""amenity""=""toilets""](area.searchArea);
						);
						out center;";

			var content = new FormUrlEncodedContent(new[]
			{
			new KeyValuePair<string, string>("data", query)
		});
			try
			{
				var response = await _httpClient.PostAsync(url, content);
				response.EnsureSuccessStatusCode();
				var json = await response.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<OverpassResponse>(json);

			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error fetching toilets: {ex.Message}");
				return null;

			}
		}
	}
}
