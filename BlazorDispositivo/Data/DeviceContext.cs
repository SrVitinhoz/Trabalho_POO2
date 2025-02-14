using BlazorDispositivo.Models;
using Microsoft.EntityFrameworkCore;

public class DeviceContext : DbContext
{
    public DbSet<Dispositivo> Dispositivos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("server=localhost;database=gestao_vendas;user=root;password=Vitorhugo120#");
    }
}