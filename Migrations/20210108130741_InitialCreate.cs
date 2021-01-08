using Microsoft.EntityFrameworkCore.Migrations;

namespace ExcelFileProcessing.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QAShipment",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Matrix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatrixClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilterLotNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BufferLotNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Target = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinalSpikedConcentration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QAClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrepAnalyst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrepDate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QAShipment", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QAShipment");
        }
    }
}
