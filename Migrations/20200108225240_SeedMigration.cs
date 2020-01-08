using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class SeedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Nissan')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Toyota')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Tesla')");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Sentra', (SELECT ID FROM Makes WHERE Name = 'Nissan'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Versa', (SELECT ID FROM Makes WHERE Name = 'Nissan'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Leaf', (SELECT ID FROM Makes WHERE Name = 'Nissan'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Prius', (SELECT ID FROM Makes WHERE Name = 'Toyota'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Yaris', (SELECT ID FROM Makes WHERE Name = 'Toyota'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Cebolla', (SELECT ID FROM Makes WHERE Name = 'Toyota'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Model 3', (SELECT ID FROM Makes WHERE Name = 'Tesla'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Toaster', (SELECT ID FROM Makes WHERE Name = 'Tesla'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Cybertruck', (SELECT ID FROM Makes WHERE Name = 'Tesla'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes WHERE Name IN ('Nissan', 'Toyota', 'Tesla')");
        }
    }
}
