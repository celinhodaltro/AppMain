﻿// <auto-generated />
using System;
using System.Provider;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Server.Providers.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Server.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Server.Entities.Guild", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Modt")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<Guid>("UniqueId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Guilds");
                });

            modelBuilder.Entity("Server.Entities.GuildMembership", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("GuildId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nick")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("RankId")
                        .HasColumnType("int");

                    b.Property<Guid>("UniqueId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("GuildId");

                    b.HasIndex("PlayerId")
                        .IsUnique();

                    b.HasIndex("RankId");

                    b.ToTable("GuildMemberships");
                });

            modelBuilder.Entity("Server.Entities.GuildRank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("GuildId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<Guid>("UniqueId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("GuildId");

                    b.ToTable("GuildRank");
                });

            modelBuilder.Entity("Server.Entities.LogTrack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("UniqueId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("Server.Entities.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<uint>("Capacity")
                        .HasColumnType("int unsigned");

                    b.Property<byte>("ChaseMode")
                        .HasColumnType("tinyint unsigned");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Experience")
                        .HasColumnType("double");

                    b.Property<byte>("FightMode")
                        .HasColumnType("tinyint unsigned");

                    b.Property<byte>("Gender")
                        .HasColumnType("tinyint unsigned");

                    b.Property<uint>("Health")
                        .HasColumnType("int unsigned");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime(6)");

                    b.Property<ushort>("Level")
                        .HasColumnType("smallint unsigned");

                    b.Property<int>("LookAddons")
                        .HasColumnType("int");

                    b.Property<int>("LookBody")
                        .HasColumnType("int");

                    b.Property<int>("LookFeet")
                        .HasColumnType("int");

                    b.Property<int>("LookHead")
                        .HasColumnType("int");

                    b.Property<int>("LookLegs")
                        .HasColumnType("int");

                    b.Property<int>("LookType")
                        .HasColumnType("int");

                    b.Property<int>("MagicLevel")
                        .HasColumnType("int");

                    b.Property<double>("MagicLevelTries")
                        .HasColumnType("double");

                    b.Property<ushort>("Mana")
                        .HasColumnType("smallint unsigned");

                    b.Property<uint>("MaxHealth")
                        .HasColumnType("int unsigned");

                    b.Property<ushort>("MaxMana")
                        .HasColumnType("smallint unsigned");

                    b.Property<byte>("MaxSoul")
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Online")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("PlayerType")
                        .HasColumnType("int");

                    b.Property<int>("PosX")
                        .HasColumnType("int");

                    b.Property<int>("PosY")
                        .HasColumnType("int");

                    b.Property<int>("PosZ")
                        .HasColumnType("int");

                    b.Property<int>("RemainingRecoverySeconds")
                        .HasColumnType("int");

                    b.Property<int>("SkillAxe")
                        .HasColumnType("int");

                    b.Property<double>("SkillAxeTries")
                        .HasColumnType("double");

                    b.Property<int>("SkillClub")
                        .HasColumnType("int");

                    b.Property<double>("SkillClubTries")
                        .HasColumnType("double");

                    b.Property<int>("SkillDist")
                        .HasColumnType("int");

                    b.Property<double>("SkillDistTries")
                        .HasColumnType("double");

                    b.Property<int>("SkillFishing")
                        .HasColumnType("int");

                    b.Property<double>("SkillFishingTries")
                        .HasColumnType("double");

                    b.Property<int>("SkillFist")
                        .HasColumnType("int");

                    b.Property<double>("SkillFistTries")
                        .HasColumnType("double");

                    b.Property<int>("SkillShielding")
                        .HasColumnType("int");

                    b.Property<double>("SkillShieldingTries")
                        .HasColumnType("double");

                    b.Property<int>("SkillSword")
                        .HasColumnType("int");

                    b.Property<double>("SkillSwordTries")
                        .HasColumnType("double");

                    b.Property<byte>("Soul")
                        .HasColumnType("tinyint unsigned");

                    b.Property<ushort>("Speed")
                        .HasColumnType("smallint unsigned");

                    b.Property<ushort>("StaminaMinutes")
                        .HasColumnType("smallint unsigned");

                    b.Property<int>("TownId")
                        .HasColumnType("int");

                    b.Property<Guid>("UniqueId")
                        .HasColumnType("char(36)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("UserInfoId")
                        .HasColumnType("int");

                    b.Property<byte>("Vocation")
                        .HasColumnType("tinyint unsigned");

                    b.Property<int>("WorldId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("UserInfoId");

                    b.HasIndex("WorldId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Server.Entities.PlayerDepotItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<short>("Amount")
                        .HasColumnType("smallint");

                    b.Property<ushort?>("Charges")
                        .HasColumnType("smallint unsigned");

                    b.Property<int>("ContainerId")
                        .HasColumnType("int");

                    b.Property<uint?>("DecayDuration")
                        .HasColumnType("int unsigned");

                    b.Property<uint?>("DecayElapsed")
                        .HasColumnType("int unsigned");

                    b.Property<ushort?>("DecayTo")
                        .HasColumnType("smallint unsigned");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("ServerId")
                        .HasColumnType("int");

                    b.Property<Guid>("UniqueId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("PlayerDepotItems");
                });

            modelBuilder.Entity("Server.Entities.PlayerInventoryItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<short>("Amount")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("ServerId")
                        .HasColumnType("int");

                    b.Property<int>("SlotId")
                        .HasColumnType("int");

                    b.Property<Guid>("UniqueId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("PlayerInventoryItems");
                });

            modelBuilder.Entity("Server.Entities.PlayerItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<short>("Amount")
                        .HasColumnType("smallint");

                    b.Property<ushort?>("Charges")
                        .HasColumnType("smallint unsigned");

                    b.Property<int>("ContainerId")
                        .HasColumnType("int");

                    b.Property<uint?>("DecayDuration")
                        .HasColumnType("int unsigned");

                    b.Property<uint?>("DecayElapsed")
                        .HasColumnType("int unsigned");

                    b.Property<ushort?>("DecayTo")
                        .HasColumnType("smallint unsigned");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("ServerId")
                        .HasColumnType("int");

                    b.Property<Guid>("UniqueId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("PlayerItems");
                });

            modelBuilder.Entity("Server.Entities.PlayerOutfitAddon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<byte>("AddonLevel")
                        .HasColumnType("tinyint unsigned");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("LookType")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<Guid>("UniqueId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("PlayerOutfitAddons");
                });

            modelBuilder.Entity("Server.Entities.PlayerQuest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ActionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Done")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("GroupKey")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("UniqueId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("PlayerQuests");
                });

            modelBuilder.Entity("Server.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<Guid>("UniqueId")
                        .HasColumnType("char(36)");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Server.Entities.UserInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("AllowManyOnline")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("BanishedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("BanishmentReason")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<uint?>("BannedBy")
                        .HasColumnType("int unsigned");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("PremiumTime")
                        .HasColumnType("int");

                    b.Property<string>("Secret")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("UniqueId")
                        .HasColumnType("char(36)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserInfo");
                });

            modelBuilder.Entity("Server.Entities.UserVipList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<Guid>("UniqueId")
                        .HasColumnType("char(36)");

                    b.Property<int?>("UserInfoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("UserInfoId");

                    b.ToTable("UserVipList");
                });

            modelBuilder.Entity("Server.Entities.World", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Ip")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("UniqueId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("Worlds");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Server.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Server.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Server.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Server.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Server.Entities.Guild", b =>
                {
                    b.HasOne("Server.Entities.Player", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Server.Entities.GuildMembership", b =>
                {
                    b.HasOne("Server.Entities.Guild", "Guild")
                        .WithMany("Members")
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Server.Entities.Player", "Player")
                        .WithOne("GuildMember")
                        .HasForeignKey("Server.Entities.GuildMembership", "PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Server.Entities.GuildRank", "Rank")
                        .WithMany()
                        .HasForeignKey("RankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guild");

                    b.Navigation("Player");

                    b.Navigation("Rank");
                });

            modelBuilder.Entity("Server.Entities.GuildRank", b =>
                {
                    b.HasOne("Server.Entities.Guild", "Guild")
                        .WithMany("Ranks")
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guild");
                });

            modelBuilder.Entity("Server.Entities.Player", b =>
                {
                    b.HasOne("Server.Entities.User", "Account")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Server.Entities.UserInfo", null)
                        .WithMany("Players")
                        .HasForeignKey("UserInfoId");

                    b.HasOne("Server.Entities.World", "World")
                        .WithMany()
                        .HasForeignKey("WorldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("World");
                });

            modelBuilder.Entity("Server.Entities.PlayerDepotItem", b =>
                {
                    b.HasOne("Server.Entities.Player", "Player")
                        .WithMany("PlayerDepotItems")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Server.Entities.PlayerInventoryItem", b =>
                {
                    b.HasOne("Server.Entities.Player", "Player")
                        .WithMany("PlayerInventoryItems")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Server.Entities.PlayerItem", b =>
                {
                    b.HasOne("Server.Entities.Player", "Player")
                        .WithMany("PlayerItems")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Server.Entities.PlayerOutfitAddon", b =>
                {
                    b.HasOne("Server.Entities.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Server.Entities.PlayerQuest", b =>
                {
                    b.HasOne("Server.Entities.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Server.Entities.UserInfo", b =>
                {
                    b.HasOne("Server.Entities.User", null)
                        .WithOne("UserInfo")
                        .HasForeignKey("Server.Entities.UserInfo", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Server.Entities.UserVipList", b =>
                {
                    b.HasOne("Server.Entities.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Server.Entities.UserInfo", null)
                        .WithMany("VipList")
                        .HasForeignKey("UserInfoId");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Server.Entities.Guild", b =>
                {
                    b.Navigation("Members");

                    b.Navigation("Ranks");
                });

            modelBuilder.Entity("Server.Entities.Player", b =>
                {
                    b.Navigation("GuildMember")
                        .IsRequired();

                    b.Navigation("PlayerDepotItems");

                    b.Navigation("PlayerInventoryItems");

                    b.Navigation("PlayerItems");
                });

            modelBuilder.Entity("Server.Entities.User", b =>
                {
                    b.Navigation("UserInfo");
                });

            modelBuilder.Entity("Server.Entities.UserInfo", b =>
                {
                    b.Navigation("Players");

                    b.Navigation("VipList");
                });
#pragma warning restore 612, 618
        }
    }
}
