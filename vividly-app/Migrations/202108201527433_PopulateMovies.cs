namespace vividly_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES (1,'Hungover','20090821','20210820',5,5)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES (2,'Die Hard','19881222','20210820',2,1)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES (3,'The Terminator','19850325','20210820',3,1)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES (4,'Toy Story','19951222','20210820',1,3)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES (5,'Titanic','19980116','20210820',7,4)");
            Sql("SET IDENTITY_INSERT Movies OFF");
        }

        public override void Down()
        {
        }
    }
}
