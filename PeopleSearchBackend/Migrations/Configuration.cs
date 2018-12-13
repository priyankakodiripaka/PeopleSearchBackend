namespace PeopleSearchBackend.Migrations
{
    using PeopleSearchBackend.Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<PeopleSearchBackend.Models.PeopleSearchBackendContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PeopleSearchBackend.Models.PeopleSearchBackendContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            List<PeopleSearch> list = new List<PeopleSearch>()
            {
                new PeopleSearch()
                {
                    ID = 1,
                    FirstName = "Scott",
                    LastName = "Hanselman",
                    Address = "Washington",
                    Age = 35,
                    Interests =  "Cricket, Basketball",
                    PictureUrl = "http://fillmurray.com/200/200"
                },
                new PeopleSearch()
                {
                    ID = 2,
                    FirstName = "Brian",
                    LastName = "Lara",
                    Address = "Washington DC",
                    Age = 35,
                    Interests =  "Cricket, Basketball",
                    PictureUrl = "http://fillmurray.com/200/200"
                },
                new PeopleSearch()
                {
                    ID = 3,
                    FirstName = "Mike",
                    LastName = "Hussey",
                    Address = "Dallas",
                    Age = 35,
                    Interests =  "Cricket, Basketball",
                    PictureUrl = "http://fillmurray.com/200/200"
                },
                new PeopleSearch()
                {
                    ID = 4,
                    FirstName = "Peter",
                    LastName = "Hales",
                    Address = "London",
                    Age = 35,
                    Interests =  "Cricket, Basketball",
                    PictureUrl = "http://fillmurray.com/200/200"
                },
                new PeopleSearch()
                {
                    ID = 5,
                    FirstName = "Robin",
                    LastName = "Uthappa",
                    Address = "Lasvegas",
                    Age = 35,
                    Interests =  "Cricket, Basketball",
                    PictureUrl = "http://fillmurray.com/200/200"
                },
                new PeopleSearch()
                {
                    ID = 6,
                    FirstName = "Jim",
                    LastName = "Cooper",
                    Address = "Newyork",
                    Age = 35,
                    Interests =  "Cricket, Basketball",
                    PictureUrl = "http://fillmurray.com/200/200"
                },
                new PeopleSearch()
                {
                    ID = 7,
                    FirstName = "Stephen",
                    LastName = "Fleming",
                    Address = "Wellington",
                    Age = 35,
                    Interests =  "Cricket, Basketball",
                    PictureUrl = "http://fillmurray.com/200/200"
                },
            };

            context.PeopleSearches.AddOrUpdate(list.ToArray());


        }
    }
}
