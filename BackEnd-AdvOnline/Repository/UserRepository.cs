using System.Linq;
using System.Threading.Tasks;
using ApiPmoIntel.Models;
using ApiPmoIntel.Repository.Interfaces;
using BackEndAdvOnline.Models;
using Microsoft.EntityFrameworkCore;


namespace ApiPmoIntel.Repository
{
    public class UserRepository : IUserRepository
    {

        private readonly staAdvOnlineContext _context;

        public UserRepository(staAdvOnlineContext context)
        {
            _context = context;

        }


        public TblPessoa GetByLogin(string login)
        {
            return _context.TblPessoa
                    .SingleOrDefault(p => p.SLogin.Equals(login));
        }
    }
}
