using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPNET_Boilerplate.Migrations {
  /// <inheritdoc />
  public partial class Initial : Migration {
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder) {
      migrationBuilder.CreateTable(
          name: "Users",
          columns: table => new {
            Id = table.Column<int>(type: "INTEGER", nullable: false)
                  .Annotation("Sqlite:Autoincrement", true),
            Email = table.Column<string>(type: "TEXT", nullable: true),
            Name = table.Column<string>(type: "TEXT", nullable: true),
            Password = table.Column<string>(type: "TEXT", nullable: true),
            Username = table.Column<string>(type: "TEXT", nullable: true)
          },
          constraints: table => {
            table.PrimaryKey("PK_Users", x => x.Id);
          });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder) {
      migrationBuilder.DropTable(
          name: "Users");
    }
  }
}
