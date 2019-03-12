using ApiPmoIntel.Models;
using ApiPmoIntel.Security;
using System.Threading.Tasks;

namespace ApiPmoIntel.Services.Interfaces
{
    public interface IUserService
    {
        object GetByLogin(AccessCredentials credentials);
    }
}
