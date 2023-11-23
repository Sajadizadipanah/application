namespace application
{

	internal static class Program : object
	{
		static Program()
		{
		}

		private static void Main()
		{
			CreateCategory();
		}

		private static void CreateCategory()
		{
			Models.DatabaseContext databaseContext = new Models.DatabaseContext();

			Models.Category category = new Models.Category();

			category.Name = "My Category";

			databaseContext.Categories.Add(entity: category);

			databaseContext.SaveChanges();
		}
	}
}