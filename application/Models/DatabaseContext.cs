using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace application.Models;


public class DatabaseContext :
	Microsoft.EntityFrameworkCore.DbContext
{
	public DatabaseContext() : base()
	{
		Database.EnsureCreated();
	}

	public Microsoft.EntityFrameworkCore.DbSet<Category> Categories { get; set; }

	protected override void OnConfiguring
		(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
	{
		var connectionString =
			"Server=.;User ID=sa;Password=1234512345;Database=LEARNING_EF_CORE_0200;MultipleActiveResultSets=true;TrustServerCertificate=True;";

		optionsBuilder.UseSqlServer
			(connectionString: connectionString);
	}
}
