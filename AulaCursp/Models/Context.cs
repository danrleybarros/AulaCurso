using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AulaCursp.Models
{
	public class Context : DbContext
	{
		public DbSet<Categoria> Categorias { get; set; }
		public DbSet<Produto> Produtos { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { 
			optionsBuilder.UseSqlServer(connectionString:@"Server=(localdb)\mssqllocaldb;Database=AulaCursp;Integrated Security=True");
		}

	}
}
