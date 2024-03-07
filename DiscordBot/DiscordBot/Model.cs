using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class BotContext : DbContext
{
    public DbSet<Profile> Profile { get; set; }
    public DbSet<UserList> UserList { get; set; }

    public String DbPath { get; }
    public BotContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "bot.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}

public class UserList
{
    public String UserListID { get; set; }
    public List<Profile> Users { get; } = new();
}

public class Profile
{
    public String ProfileID { get; set; }
    public String Name { get; set; }
    public String Backpack { get; set; }
    public ulong DiscordID { get; set; }
    public int Money { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }
    public int BackpackSpace { get; set; }

    public UserList UserList { get; set; }
}