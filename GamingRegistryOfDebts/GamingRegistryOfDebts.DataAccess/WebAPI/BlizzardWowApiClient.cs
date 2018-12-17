using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using GamingRegistryOfDebts.DataAccess.WebAPI.Interface;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GamingRegistryOfDebts.DataAccess.WebAPI
{
  public class BlizzardWowApiClient : IGameApiClient
  {
    private const string EndpointBaseAddress = "https://eu.api.blizzard.com/wow";

    private static string _token;
    private static DateTime _tokenExpirationDate;

    public async Task<Dictionary<string, string>> GetCharacterDetailsAsync(string realm, string name)
    {
      if (DateTime.Now > _tokenExpirationDate)
        await RefreshToken();

      using (var client = new HttpClient())
      {
        var response = await client.GetAsync($"{EndpointBaseAddress}/character/{realm}/{name}?locale=en_US&access_token={_token}");

        if (response.StatusCode == HttpStatusCode.NotFound)
        {
          throw new ArgumentOutOfRangeException(nameof(name), "Could not find specified character");
        }

        using (var reader = new StreamReader(await response.Content.ReadAsStreamAsync().ConfigureAwait(false)))
        {
          // Write the output.
          var json = await reader.ReadToEndAsync().ConfigureAwait(false);

          return JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }
      }
    }

    public Dictionary<string, string> GetCharacterDetails(string realm, string name)
    {
      return GetCharacterDetailsAsync(realm, name).GetAwaiter().GetResult();
    }

    private async Task RefreshToken()
    {
      using (var client = new HttpClient())
      {
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
          Convert.ToBase64String(
            System.Text.Encoding.ASCII.GetBytes(
              "3081284dbb6c410a88305e7f4ccc4e5d:P7bt0B6IX3BIUdUkM3hGauXtKo8I8Wiy")));

        var requestContent = new FormUrlEncodedContent(new[]
          {new KeyValuePair<string, string>("grant_type", "client_credentials")});

        ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls12 |
                                               SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

        var response = await client.PostAsync("https://eu.battle.net/oauth/token", requestContent).ConfigureAwait(false);

        using (var reader = new StreamReader(await response.Content.ReadAsStreamAsync().ConfigureAwait(false)))
        {
          // Write the output.
          var json = await reader.ReadToEndAsync().ConfigureAwait(false);
          var jObject = JObject.Parse(json);

          _token = jObject["access_token"].ToString();
          _tokenExpirationDate = DateTime.Now + TimeSpan.FromSeconds(double.Parse(jObject["expires_in"].ToString()));
        }
      }
    }
  }
}
