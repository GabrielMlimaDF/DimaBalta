﻿using Dima.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Dima.Api.Data
{
    public class ContextApp : DbContext
    {
        public ContextApp(DbContextOptions<ContextApp> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Transaction> Transactions { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

    }
}
