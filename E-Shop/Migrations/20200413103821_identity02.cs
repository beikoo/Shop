using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Shop.Migrations
{
    public partial class identity02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    CategoryDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    IsAdmin = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    CarID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    ThumbNail = table.Column<string>(nullable: true),
                    IsOnSale = table.Column<bool>(nullable: false),
                    IsOnStock = table.Column<bool>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.CarID);
                    table.ForeignKey(
                        name: "FK_Car_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryDescription", "CategoryName" },
                values: new object[] { 1, "", "Sedan" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryDescription", "CategoryName" },
                values: new object[] { 2, "", "Avant" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryDescription", "CategoryName" },
                values: new object[] { 3, "", "HatchBack" });

            migrationBuilder.InsertData(
                table: "Car",
                columns: new[] { "CarID", "Brand", "CategoryID", "Description", "Image", "IsOnSale", "IsOnStock", "Model", "Price", "ThumbNail" },
                values: new object[,]
                {
                    { 2, "Audi", 1, "To create the S8, Audi takes its flagship A8 luxury sedan and adds a significant amount of power and poise. A standard twin-turbocharged V-8 engine provides the punch, while a firmer suspension and upgraded brakes improve the big sedan's athleticism. Subtle visual enhancements inside and out include different wheels, bumpers, and special interior trim. But the S8 otherwise looks similar to its A8 sibling, meaning that this car is not meant for those who want their luxury sedan to be ostentatious. The S8's spacious, feature-packed cabin makes it a perfect rival to V-8–powered variants of the BMW 7-series and the Mercedes-Benz S-class, and its digital dashboard makes the Audi perfect for high-rolling technophiles.", "\\Images\\s8.jpg", true, true, "S8", 80000m, "\\Images\\s8.jpg" },
                    { 3, "Mercedes", 1, "The Mercedes-AMG GT (C190 / R190) is a sports car produced in coupé and roadster bodystyles by German automobile manufacturer Mercedes-AMG. The car was introduced on 9 September 2014 and was officially unveiled to the public in October 2014 at the Paris Motor Show.[4] After the SLS AMG, it is the second sports car developed entirely in-house by Mercedes-AMG. Formula One driver Lewis Hamilton assisted with the development. The Mercedes-AMG GT went on sale in two variants (GT and GT S) in March 2015, while a GT3 racing variant of the car was introduced in 2015. A high performance variant called the GT R was introduced in 2016. A GT4 racing variant, targeted at semi-professional drivers and based on the GT R variant, was introduced in 2017. All variants are assembled at the Mercedes-Benz plant in Sindelfingen, Germany.", "\\Images\\gt.jpg", true, true, "AMG GT", 180000m, "\\Images\\gt.jpg" },
                    { 4, "BMW", 1, "The BMW i8 is a plug-in hybrid sports car developed by BMW. The i8 is part of BMW's electric fleet Project i being marketed as a new sub-brand, BMW i. The 2015 model year BMW i8 has a 7.1 kWh lithium-ion battery pack that delivers an all-electric range of 37 km (23 mi) under the New European Driving Cycle. Under the United States Environmental Protection Agency cycle, the range in EV mode is 24 km (15 mi) with a small amount of gasoline consumption. Its design is heavily influenced by the BMW M1 Homage concept car, which in turn pays homage to BMW's last production mid-engined sports car prior to the i8: the BMW M1. BMW will cease the production of the BMW i8 in April 2020", "\\Images\\i8.jpg", true, true, "I8", 99999m, "\\Images\\i8.jpg" },
                    { 1, "Audi", 2, "25 years of RS, 25 years of high-performance station wagons from Audi: With the new Audi RS 6 Audi Sport is ushering in a new chapter in the history of the high-performance Avant. Even more power combined with increased efficiency thanks to mild hybrid system turn the RS 6 Avant into the perfect companion for any purpose. The new Audi RS 6 Avant will go on sale in dealerships in Germany and other European countries by the end of 2019.Combined fuel consumption in l / 100 km: 117(20.1) – 115(20.5),Combined CO2 emissions in g / km: 268(431.3) – 263(423.3); Information on fuel consumption and CO2 emissions aswell as efficiency classes in ranges depending on the tires and alloy wheel rims used", "\\Images\\rs6.jpg", true, true, "Rs6", 59999m, "\\Images\\rs6.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Car_CategoryID",
                table: "Car",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
