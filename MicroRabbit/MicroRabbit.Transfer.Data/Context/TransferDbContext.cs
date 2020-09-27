using Microsoft.EntityFrameworkCore;
using MircoRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace MicroRabbit.Transfer.Data.Context
{
    public class TransferDbContext: DbContext
    {
        public TransferDbContext(DbContextOptions options): base(options)
        {
           
        }
        public DbSet<TransferLog> TransferLogs { get; set; }
    }
}
