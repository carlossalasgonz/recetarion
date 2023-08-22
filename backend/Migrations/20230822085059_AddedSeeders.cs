using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Name", "PublicationId", "Type" },
                values: new object[] { new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Image.png", null, "png" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Calories", "Density", "ImageId", "Name", "UserPermissionAction", "UserPermissionUserRolesId" },
                values: new object[,]
                {
                    { new Guid("0727f01c-0685-4e0f-ba81-d4fb697ef347"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Beef", null, null },
                    { new Guid("0a82836c-2613-4233-a9ec-d74d4b72159b"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Mushroom", null, null },
                    { new Guid("0d0200e8-a871-472e-8911-88f897e51030"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Pork Tenderloin", null, null },
                    { new Guid("101d95cf-50b6-45ea-822c-386acc075831"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Seafood", null, null },
                    { new Guid("15a45451-8ba7-4556-be85-47841e957392"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Wild Rice", null, null },
                    { new Guid("17e9e943-fc4e-4756-a724-4c84a5891051"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Pineapples", null, null },
                    { new Guid("1e2201c0-11a9-4724-a8af-26a47281f73c"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Veal", null, null },
                    { new Guid("21eea24a-22d1-4cf4-8473-1c1e1cab65d4"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Chicken", null, null },
                    { new Guid("2bef99d0-638c-46b0-b4f6-2746b570aaaf"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Spelt", null, null },
                    { new Guid("2d7c1fda-450b-4524-bf8b-67b0ec84343f"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Chocolate", null, null },
                    { new Guid("2e22ed0f-9d6b-4def-9b24-b5b52084756a"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Oats", null, null },
                    { new Guid("3293a4e7-2981-4b42-b8ab-a0495da2d0a6"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Ground Chicken", null, null },
                    { new Guid("39f5c75e-189b-4378-b946-bb59e3af57e5"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Tapioca Flour", null, null },
                    { new Guid("3ddbc63b-a61d-4869-9b70-0508602d439c"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Apricots", null, null },
                    { new Guid("5118ac29-bd70-43c5-80ee-609157f5eb1a"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Brisket", null, null },
                    { new Guid("54b27ae8-2fa8-4bf9-9222-6d0c3e84521b"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Chicken Legs", null, null },
                    { new Guid("564a4321-7958-40a1-8af4-2d4c32287de0"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Beef Ribs", null, null },
                    { new Guid("5764d92f-6526-414e-b128-2f5e7952239a"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Duck", null, null },
                    { new Guid("6a24b7cc-8635-4faa-9820-666b8d1b24ad"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Cherries", null, null },
                    { new Guid("6a305f6e-5008-4e19-aa80-dc2873444195"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Buckwheat", null, null },
                    { new Guid("6d9425fb-67f7-4718-9270-6ddd794ffa12"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Bulgur", null, null },
                    { new Guid("74a5b416-569c-422e-8d5c-fa44d8fd2de6"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Sirloin", null, null },
                    { new Guid("7a071675-f027-4933-9b6f-c422eebfd2e9"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Cornish Hens", null, null },
                    { new Guid("7cc1d1ba-4dc1-4dfc-a930-7dc9f2093f66"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "White Rice Flour", null, null },
                    { new Guid("7e146cb3-eb7f-44a3-bf62-da355e075b2b"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Pomegranates", null, null },
                    { new Guid("7f7fe312-303a-4e6e-9a82-42b4944f6fca"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Ground Pork", null, null },
                    { new Guid("834687b4-1bce-4b77-bd5d-cb83974cd6f1"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Pork", null, null },
                    { new Guid("875d4333-76b5-49ab-9c77-fbb23fd8b5d7"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Pork Ribs", null, null },
                    { new Guid("8dcd4bc7-c54e-4e13-b561-31a606ae89d5"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Flax Seeds", null, null },
                    { new Guid("8e3207e2-b581-4eb5-a7d2-b8e78677b27b"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Avocados", null, null },
                    { new Guid("901541b2-b704-430b-8123-67308ad943da"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Wild Game", null, null },
                    { new Guid("918927dc-c209-430d-9b18-f914579d6fbb"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Almond Meal", null, null },
                    { new Guid("92307062-243c-427d-b86e-4004f18973a5"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Coconut", null, null },
                    { new Guid("935de0d8-5a49-4d06-a369-6be45ad6234b"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Steak", null, null },
                    { new Guid("9360b981-2b6c-4e37-b68e-3b4d257e7a60"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Chicken Wings", null, null },
                    { new Guid("9593addd-3554-4d0a-b453-a722682f1315"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Ground Beef", null, null },
                    { new Guid("986ef3c4-8d19-4f6e-8308-1972b1227555"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Brown Rice", null, null },
                    { new Guid("9c1a6fbb-38ee-47a9-9ba1-38388545d175"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Chicken Breasts", null, null },
                    { new Guid("9fff82d8-b0db-4794-818d-5c979b858b43"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Nectarines", null, null },
                    { new Guid("a0299838-d0f6-43af-a6b1-d86e6cdd4895"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Goat", null, null },
                    { new Guid("a09afd45-216b-4fb5-8e2e-1abb0e25ab7e"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Ground Turkey", null, null },
                    { new Guid("a6ea8c41-f6ba-46f6-a526-e68297c05454"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Cornmeal", null, null },
                    { new Guid("ad361b0c-e6fd-41e6-8be7-e90d9af34796"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Apples", null, null },
                    { new Guid("b188ec51-371a-4b1a-99dd-cd3703146dfd"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Fish", null, null },
                    { new Guid("b839798a-ec69-4dad-b89f-33355c21be55"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Millet", null, null },
                    { new Guid("bba2e0d4-93b1-4543-92fd-7c423b774d1e"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Amaranth", null, null },
                    { new Guid("bdf01259-6013-49ce-a5d3-dbca5a887a39"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Turkey", null, null },
                    { new Guid("be3b57cb-a38a-4b02-874c-14bd9dfdee05"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Plums", null, null },
                    { new Guid("c0403162-7be5-4fdf-92b3-e269d6a1c343"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Oat Flour", null, null },
                    { new Guid("c0e637aa-4137-4ec9-bf33-4d9f2c76bf9b"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Barley", null, null },
                    { new Guid("c1f6e588-5072-402c-94a9-a55964e9b4ee"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Pears", null, null },
                    { new Guid("c2d0d4cc-ef8e-4b7f-8199-ac11634c9bff"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Mangos", null, null },
                    { new Guid("c2ff80f4-0248-4631-bafb-656e9bed38c0"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Shellfish", null, null },
                    { new Guid("c4f36e41-f2f2-4119-83fb-e8c81a2c06f0"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Bananas", null, null },
                    { new Guid("c7493d21-a5ab-4628-9ebd-1b8a482b7e5b"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Almonds", null, null },
                    { new Guid("d6879f79-bdc4-48df-b9e7-09377301c63b"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Chia Seeds", null, null },
                    { new Guid("dac4b8dd-46bf-4dbc-8e0b-90efe8872e8c"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Cheese", null, null },
                    { new Guid("e008199f-9390-4388-9e01-e5828289bee2"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Lamb", null, null },
                    { new Guid("e29d4b64-0468-4fb8-bd9b-8fa4eddf03d7"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Beef Chuck", null, null },
                    { new Guid("e5cd6545-4ac6-44cf-bbc9-ed82211a6729"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Peanuts", null, null },
                    { new Guid("e7165e85-39d5-4179-9eac-ef179788dc92"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Venison", null, null },
                    { new Guid("e8123e0a-e5f6-4284-8e08-fb9bdcea097c"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Sausage", null, null },
                    { new Guid("f0babb14-9d7e-4fbd-bf6d-f1ed09985de7"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Corn Flour", null, null },
                    { new Guid("f4159f48-1d96-4f93-a29c-ee64616c43cc"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Pork Shoulder", null, null },
                    { new Guid("f876bebb-bcee-4462-a0c8-9d80f6086907"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Prime Rib", null, null },
                    { new Guid("f92bab10-96f5-4b3a-8879-6b7c231e422c"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Chicken Thighs", null, null },
                    { new Guid("f94eff13-f547-4561-96f2-cfaa4b25b25d"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Quinoa", null, null },
                    { new Guid("fbbf8f1f-93c6-495d-9761-d52690b1d31c"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Peaches", null, null },
                    { new Guid("fd14af59-99bd-4a37-a4b6-7f034ea7acb8"), 0, 1f, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), "Beef Tenderloin", null, null }
                });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "Abbreviation", "Default", "Equivalence", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("0e42a728-0898-44aa-a60d-db845551b71e"), "ml", false, 1000f, "Milliliters", "Volume" },
                    { new Guid("2d825b4a-62d3-4583-8209-4a1d74fd7382"), "lb", false, 0.035274f, "Pound", "Mass" },
                    { new Guid("30295b4e-b843-4805-9dde-9054ac1665dd"), "qt", false, 1.056688f, "Quart", "Volume" },
                    { new Guid("43b1e4b9-2a03-4eec-927d-06bf8c28eddc"), "tbsp", false, 67.62805f, "Tablespoon", "Volume" },
                    { new Guid("4e5b14da-26f0-4366-b4cb-d18445774bac"), "g", true, 1f, "Grams", "Mass" },
                    { new Guid("57908bc8-08e6-41ef-a8cc-3e714c397213"), "gal", false, 0.264172f, "Gallon", "Volume" },
                    { new Guid("5e554090-bc9c-4124-85e8-c7f37e6338de"), "kg", false, 0.001f, "Kilogram", "Mass" },
                    { new Guid("692fa015-0ebc-40a8-91b2-b524a74b0740"), "l", true, 1f, "Liters", "Volume" },
                    { new Guid("79cc4ad5-c038-49fd-bb73-c31258dc4055"), "pt", false, 2.113376f, "Pint", "Volume" },
                    { new Guid("8297cb28-42c8-43e7-914b-c1211ae43a85"), "mg", false, 1000f, "Milligram", "Mass" },
                    { new Guid("83ef07c1-e727-4052-b53d-f55506c350f7"), "c", false, 4.226753f, "Cup", "Volume" },
                    { new Guid("93373be9-1f20-43eb-8b16-fc54bcf22053"), "tsp", false, 202.8841f, "Teaspoon", "Volume" },
                    { new Guid("9ac926d0-065c-44ed-adb9-6306e4e3f0f4"), "oz", false, 0.035274f, "Ounce", "Mass" },
                    { new Guid("ab27297a-665a-4ecc-8ccc-aba3ae3c6fb2"), "st", false, 0.035274f, "Stone", "Mass" },
                    { new Guid("b93d21e9-afc9-4357-b93a-28b3d05c1b58"), "fl. oz", false, 33.81402f, "Fluid ounce", "Volume" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("4f0c7823-7118-48f9-9ad7-55981fa19d59"), "Admin" },
                    { new Guid("65d13a15-e697-4111-add5-511fe9f39b6a"), "Client" },
                    { new Guid("cf3ae832-fb2c-4c5f-8781-6be5afff1a9f"), "SuperAdmin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Email", "FollowerCount", "ImageId", "IngredientId", "PasswordHash", "PasswordSalt", "TokenFacebook", "TokenTwitter", "UpdatedAt", "UserRoleId", "Username" },
                values: new object[] { new Guid("34ffc692-398e-4ae4-8f9c-b1ab9e616721"), new DateTime(2023, 8, 22, 1, 50, 59, 151, DateTimeKind.Local).AddTicks(7775), null, "", "admin@recetarion.com", 0u, new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"), null, "8��B�uo��ʊ�Zj�E���(�Ykx>L��#t�\r��%DXh:p�)Yh+��ZU��iG", "������ք#~Ag�r�,���U4m47$٨��<z���?��)f�N�s��>`�,_q�X�]�݁��矕���a+O �ZVG�;9��H\r�>r 6���R~{(��M%��g!�K�i�G/s��t�V", null, null, null, new Guid("cf3ae832-fb2c-4c5f-8781-6be5afff1a9f"), "Recetarion Admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("19e2a5ec-0e4a-41b0-b143-90d5a824dd94"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("0727f01c-0685-4e0f-ba81-d4fb697ef347"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("0a82836c-2613-4233-a9ec-d74d4b72159b"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("0d0200e8-a871-472e-8911-88f897e51030"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("101d95cf-50b6-45ea-822c-386acc075831"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("15a45451-8ba7-4556-be85-47841e957392"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("17e9e943-fc4e-4756-a724-4c84a5891051"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("1e2201c0-11a9-4724-a8af-26a47281f73c"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("21eea24a-22d1-4cf4-8473-1c1e1cab65d4"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("2bef99d0-638c-46b0-b4f6-2746b570aaaf"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("2d7c1fda-450b-4524-bf8b-67b0ec84343f"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("2e22ed0f-9d6b-4def-9b24-b5b52084756a"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("3293a4e7-2981-4b42-b8ab-a0495da2d0a6"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("39f5c75e-189b-4378-b946-bb59e3af57e5"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("3ddbc63b-a61d-4869-9b70-0508602d439c"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("5118ac29-bd70-43c5-80ee-609157f5eb1a"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("54b27ae8-2fa8-4bf9-9222-6d0c3e84521b"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("564a4321-7958-40a1-8af4-2d4c32287de0"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("5764d92f-6526-414e-b128-2f5e7952239a"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("6a24b7cc-8635-4faa-9820-666b8d1b24ad"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("6a305f6e-5008-4e19-aa80-dc2873444195"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("6d9425fb-67f7-4718-9270-6ddd794ffa12"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("74a5b416-569c-422e-8d5c-fa44d8fd2de6"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7a071675-f027-4933-9b6f-c422eebfd2e9"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7cc1d1ba-4dc1-4dfc-a930-7dc9f2093f66"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7e146cb3-eb7f-44a3-bf62-da355e075b2b"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7f7fe312-303a-4e6e-9a82-42b4944f6fca"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("834687b4-1bce-4b77-bd5d-cb83974cd6f1"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("875d4333-76b5-49ab-9c77-fbb23fd8b5d7"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("8dcd4bc7-c54e-4e13-b561-31a606ae89d5"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("8e3207e2-b581-4eb5-a7d2-b8e78677b27b"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("901541b2-b704-430b-8123-67308ad943da"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("918927dc-c209-430d-9b18-f914579d6fbb"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("92307062-243c-427d-b86e-4004f18973a5"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("935de0d8-5a49-4d06-a369-6be45ad6234b"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("9360b981-2b6c-4e37-b68e-3b4d257e7a60"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("9593addd-3554-4d0a-b453-a722682f1315"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("986ef3c4-8d19-4f6e-8308-1972b1227555"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("9c1a6fbb-38ee-47a9-9ba1-38388545d175"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("9fff82d8-b0db-4794-818d-5c979b858b43"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("a0299838-d0f6-43af-a6b1-d86e6cdd4895"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("a09afd45-216b-4fb5-8e2e-1abb0e25ab7e"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("a6ea8c41-f6ba-46f6-a526-e68297c05454"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("ad361b0c-e6fd-41e6-8be7-e90d9af34796"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("b188ec51-371a-4b1a-99dd-cd3703146dfd"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("b839798a-ec69-4dad-b89f-33355c21be55"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bba2e0d4-93b1-4543-92fd-7c423b774d1e"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bdf01259-6013-49ce-a5d3-dbca5a887a39"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("be3b57cb-a38a-4b02-874c-14bd9dfdee05"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("c0403162-7be5-4fdf-92b3-e269d6a1c343"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("c0e637aa-4137-4ec9-bf33-4d9f2c76bf9b"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("c1f6e588-5072-402c-94a9-a55964e9b4ee"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("c2d0d4cc-ef8e-4b7f-8199-ac11634c9bff"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("c2ff80f4-0248-4631-bafb-656e9bed38c0"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("c4f36e41-f2f2-4119-83fb-e8c81a2c06f0"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("c7493d21-a5ab-4628-9ebd-1b8a482b7e5b"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("d6879f79-bdc4-48df-b9e7-09377301c63b"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("dac4b8dd-46bf-4dbc-8e0b-90efe8872e8c"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("e008199f-9390-4388-9e01-e5828289bee2"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("e29d4b64-0468-4fb8-bd9b-8fa4eddf03d7"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("e5cd6545-4ac6-44cf-bbc9-ed82211a6729"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("e7165e85-39d5-4179-9eac-ef179788dc92"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("e8123e0a-e5f6-4284-8e08-fb9bdcea097c"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("f0babb14-9d7e-4fbd-bf6d-f1ed09985de7"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("f4159f48-1d96-4f93-a29c-ee64616c43cc"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("f876bebb-bcee-4462-a0c8-9d80f6086907"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("f92bab10-96f5-4b3a-8879-6b7c231e422c"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("f94eff13-f547-4561-96f2-cfaa4b25b25d"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("fbbf8f1f-93c6-495d-9761-d52690b1d31c"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("fd14af59-99bd-4a37-a4b6-7f034ea7acb8"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("0e42a728-0898-44aa-a60d-db845551b71e"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("2d825b4a-62d3-4583-8209-4a1d74fd7382"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("30295b4e-b843-4805-9dde-9054ac1665dd"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("43b1e4b9-2a03-4eec-927d-06bf8c28eddc"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("4e5b14da-26f0-4366-b4cb-d18445774bac"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("57908bc8-08e6-41ef-a8cc-3e714c397213"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("5e554090-bc9c-4124-85e8-c7f37e6338de"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("692fa015-0ebc-40a8-91b2-b524a74b0740"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("79cc4ad5-c038-49fd-bb73-c31258dc4055"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("8297cb28-42c8-43e7-914b-c1211ae43a85"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("83ef07c1-e727-4052-b53d-f55506c350f7"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("93373be9-1f20-43eb-8b16-fc54bcf22053"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("9ac926d0-065c-44ed-adb9-6306e4e3f0f4"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("ab27297a-665a-4ecc-8ccc-aba3ae3c6fb2"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("b93d21e9-afc9-4357-b93a-28b3d05c1b58"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("4f0c7823-7118-48f9-9ad7-55981fa19d59"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("65d13a15-e697-4111-add5-511fe9f39b6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34ffc692-398e-4ae4-8f9c-b1ab9e616721"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("cf3ae832-fb2c-4c5f-8781-6be5afff1a9f"));
        }
    }
}
