using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CorePhoneBook.Models;

    public class CorePhoneBookDBContext : DbContext
    {
        public CorePhoneBookDBContext (DbContextOptions<CorePhoneBookDBContext> options)
            : base(options)
        {
        }

        public DbSet<CorePhoneBook.Models.PhoneRecord> PhoneRecord { get; set; }
    }
