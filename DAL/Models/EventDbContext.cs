using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EventDb.DAL.Models
{
    public class EventDbContext : DbContext
    {
        public DbSet<UserInfo> Users { get; set; }
        public DbSet<EventDetails> Events { get; set; }
        public DbSet<SpeakerDetails> Speakers { get; set; }
        public DbSet<SessionInfo> Sessions { get; set; }
        public DbSet<ParticipantEventDetails> Participants { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DatabaseHelper.GetConnectionString());

        }
    }
}