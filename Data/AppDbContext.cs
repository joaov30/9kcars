using _9kcars.Entities;
using Microsoft.EntityFrameworkCore;

namespace _9kcars.Data
{
	public class AppDbContext : DbContext
	{
		
		public AppDbContext(DbContextOptions<AppDbContext> options) : 
			base(options) { }

		public DbSet<Veiculo> Veiculos { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Veiculo>().HasData(
				new Veiculo
				{
					VeiculoId = 1,
					Marca = "Acura",
					Modelo = "NSX",
					Ano = 1991,
					Categoria = "Sports Car",
					Cor = "Formula Red",
					Valor = 800,
					Placa = "ABC-1234",
					Disponibilidade = true
				}
				);
		}

	}
}
