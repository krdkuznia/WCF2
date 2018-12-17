using System.Collections.Generic;
using System.Threading.Tasks;

namespace GamingRegistryOfDebts.DataAccess.WebAPI.Interface
{
  public interface IGameApiClient
  {
    Task<Dictionary<string, string>> GetCharacterDetailsAsync(string realm, string name);

    Dictionary<string, string> GetCharacterDetails(string realm, string name);
  }
}