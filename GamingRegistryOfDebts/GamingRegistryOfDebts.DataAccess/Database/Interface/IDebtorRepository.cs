using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamingRegistryOfDebts.Entity;

namespace GamingRegistryOfDebts.DataAccess.Database.Interface
{
  public interface IDebtorRepository
  {
    DebtorStatus GetDebtorStatus(string realm, string name);
  }
}
