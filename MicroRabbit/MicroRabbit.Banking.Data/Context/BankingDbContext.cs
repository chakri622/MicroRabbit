using Microsoft.EntityFrameworkCore;
using MircoRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace MicroRabbit.Banking.Data.Context
{
    public class BankingDbContext: DbContext
    {
        public BankingDbContext(DbContextOptions options): base(options)
        {
           
        }
        public DbSet<Account> Accounts { get; set; }
    }
}
