﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Server.Entities;

namespace System.Provider;
public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public string ConnectionString { get; set; } = "Server=localhost;Database=AppMain;Uid=root;Pwd=admin";

    #region User
    public DbSet<UserVipList> UserVipList { get; set; }
    public DbSet<UserInfo> UserInfo { get; set; }
    #endregion
    #region Player
    public DbSet<Player> Players { get; set; }
    public DbSet<PlayerItem> PlayerItems { get; set; }
    public DbSet<PlayerDepotItem> PlayerDepotItems { get; set; }
    public DbSet<PlayerInventoryItem> PlayerInventoryItems { get; set; }
    public DbSet<PlayerQuest> PlayerQuests { get; set; }
    public DbSet<PlayerOutfitAddon> PlayerOutfitAddons { get; set; }
    public DbSet<PlayerSkill> PlayerSkill { get; set; }
    public DbSet<Guild> Guilds { get; set; }
    public DbSet<GuildMembership> GuildMemberships { get; set; }
    public DbSet<World> Worlds { get; set; }
    #endregion
    #region Logs
    public DbSet<LogTrack> Logs { get; set; }
    #endregion

    public ApplicationDbContext() { }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySQL(ConnectionString);
        }
    }


}



