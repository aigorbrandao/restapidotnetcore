using ApiPmoIntel.Models;
using BackEndAdvOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPmoIntel.Repository.Interfaces
{
    public interface IUserRepository
    {
        TblPessoa GetByLogin(string login);
    }
}
