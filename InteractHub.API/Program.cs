using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using InteractHub.Infrastructure.Data;
using InteractHub.Core.Entities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration
        .GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();