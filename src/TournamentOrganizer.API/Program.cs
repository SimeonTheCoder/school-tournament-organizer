using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TournamentOrganizer.Infrastructure.Data;

public class Program
{
    static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddSqlServer<TournamentOrganizerDbContext>(
            builder.Configuration.GetConnectionString("DefaultConnection")!.ToString()
        );

        var app = builder.Build();

        app.Run();
    }
}
