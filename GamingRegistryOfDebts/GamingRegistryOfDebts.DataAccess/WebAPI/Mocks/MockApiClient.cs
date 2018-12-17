using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamingRegistryOfDebts.DataAccess.WebAPI.Interface;

namespace GamingRegistryOfDebts.DataAccess.WebAPI.Mocks
{
  public class MockApiClient : IGameApiClient
  {
    public async Task<Dictionary<string, string>> GetCharacterDetailsAsync(string realm, string name)
    {
      return await Task.FromResult(new Dictionary<string, string>());
    }

    public Dictionary<string, string> GetCharacterDetails(string realm, string name)
    {
      return new Dictionary<string, string>();
    }
  }
}
