using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.DBconnention;

    public class RoomDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<RoomUser>Users{get; set;}
    public DbSet<Message>Messages{get; set;}


}

