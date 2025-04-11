using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;

namespace ScreenSound.Banco;

internal class ScreenSoundContext : DbContext
{
    // Mapeando a entidade Artista da classe para a tabela Artistas no banco de dados
    public DbSet<Artista> Artistas { get; set; }

    // Mapeando a entidade Musica da classe para a tabela Musicas no banco de dados
    public DbSet<Musica> Musicas { get; set; }


    // Conexao com o banco de dados
    private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSoundv0;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

    // Metodo para obter a conexao com o banco de dados utilizando entity
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString)
            .UseLazyLoadingProxies();
    }

    
    

}
