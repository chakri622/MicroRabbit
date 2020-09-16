using MircoRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MircoRabbit.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}
